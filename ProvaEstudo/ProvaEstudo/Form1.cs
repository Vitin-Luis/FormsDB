using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaEstudo
{
    public partial class Form1 : Form
    {
        public List<Contato> listaContato;
        public SqlConnection conexao { get; set; }

        public Form1()
        {
            InitializeComponent();
            listaContato = new List<Contato>();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoProva;Integrated Security=True;Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;");
            AtualizarLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionar formAdicionar = new FormAdicionar(this);
            formAdicionar.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewLista.SelectedCells.Count > 0)
            {
                int selecionado = dataGridViewLista.SelectedCells[0].RowIndex;
                int contatoId = listaContato[selecionado].id;

                var deleteCmd = conexao.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Contato WHERE Id = @id;";
                deleteCmd.Parameters.AddWithValue("@id", contatoId);

                try
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.Open();
                    }
                    deleteCmd.ExecuteNonQuery();
                    listaContato.RemoveAt(selecionado);
                    AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        public void AtualizarLista()
        {
            listaContato.Clear();
            try
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                var cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM Contato;";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Contato c = new Contato
                        {
                            id = Convert.ToInt32(reader["Id"]),
                            nome = reader["Nome"].ToString(),
                            telefone = reader["Telefone"].ToString()
                        };

                        listaContato.Add(c);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao ler os dados do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            dataGridViewLista.DataSource = null;
            dataGridViewLista.DataSource = listaContato;
            dataGridViewLista.Refresh();
        }
    }
}