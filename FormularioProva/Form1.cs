
using System.Data;
using System.Data.SqlClient;

namespace FormularioProva
{
    public partial class Form1 : Form
    {
        public List<Contato> contatoLista;
        public bool logado = false;
        public SqlConnection conexao;

        public Form1()
        {

            InitializeComponent();
            btnAdicionar.Enabled = false;
            btnRemover.Enabled = false;
            contatoLista = new List<Contato>();
            verificaLogado();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoNovo;Integrated Security=True;Connect Timeout=30;Encrypt=False; ApplicationIntent=ReadWrite;");
            atualizar();

            try
            {
                conexao.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void verificaLogado()
        {
            if (logado)
            {
                btnLogin.Text = "Sair";
                labelBemVindo.Text = "Bem Vindo";
                btnAdicionar.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        public void atualizar()
        {
            contatoLista.Clear();
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
                var cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Contato";
                SqlDataReader leitorDados = cmd.ExecuteReader();

                while (leitorDados.Read())
                {
                    try
                    {
                        Contato c = new Contato
                        {
                            id = Convert.ToInt32(leitorDados["Id"]),
                            nome = leitorDados["Nome"].ToString(),
                            telefone = leitorDados["Telefone"].ToString()
                        };

                        contatoLista.Add(c);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao ler dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridViewLista.DataSource = null;
                dataGridViewLista.DataSource = contatoLista;
                dataGridViewLista.Refresh();
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionar formAdicionar = new FormAdicionar(this);
            formAdicionar.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int selecionado = dataGridViewLista.SelectedCells[0].RowIndex;
            int contatoId = contatoLista[selecionado].id;

            var deleteCmd = conexao.CreateCommand();
            deleteCmd.CommandText = "DELETE FROM Contato WHERE Id = @id";
            deleteCmd.Parameters.AddWithValue("@id", contatoId);

            try
            {
                if(conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                deleteCmd.ExecuteNonQuery();
                contatoLista.RemoveAt(selecionado);
                atualizar();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro na conexao", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!logado)
            {
                FormLogin formLogin = new FormLogin(this);
                formLogin.Show();
            }
            else
            {
                this.Close();  
            }
        }
    }
}
