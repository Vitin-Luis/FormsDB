using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProvaEstudo
{
    public partial class FormAdicionar : Form
    {
        Form1 origem;

        public FormAdicionar(Form1 formHome)
        {
            InitializeComponent();
            this.origem = formHome;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (checkBoxPacto.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBoxNome.Text) || string.IsNullOrWhiteSpace(textBoxTelefone.Text))
                {
                    MessageBox.Show("Campo vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var insertCmd = origem.conexao.CreateCommand();
                    insertCmd.CommandText = "INSERT INTO Contato (Nome, Telefone) VALUES (@nome, @telefone);";
                    var paramNome = new SqlParameter("nome", textBoxNome.Text);
                    var paramTelefone = new SqlParameter("telefone", textBoxTelefone.Text);

                    insertCmd.Parameters.Add(paramNome);
                    insertCmd.Parameters.Add(paramTelefone);

                    try
                    {
                        if (origem.conexao.State == ConnectionState.Closed)
                        {
                            origem.conexao.Open();
                        }
                        insertCmd.ExecuteNonQuery();
                        Console.WriteLine("Linha inserida!");

                        origem.AtualizarLista(); // Método para atualizar a lista e o DataGridView

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (origem.conexao.State == ConnectionState.Open)
                        {
                            origem.conexao.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O pacto não foi aceito!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
