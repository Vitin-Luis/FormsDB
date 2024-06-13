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

namespace FormularioProva
{
    public partial class FormAdicionar : Form
    {
        Form1 origem;
        public FormAdicionar(Form1 form1)
        {
            InitializeComponent();
            origem = form1;
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnConfirmarContato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxTelefone.Text))
            {
                MessageBox.Show("Digite nome ou telefone!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var insertCmd = origem.conexao.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Contato (Nome, Telefone) VALUES (@nome, @telefone)";
                var paramNome = new SqlParameter("nome", textBoxNome.Text);
                var paramTelefone = new SqlParameter("telefone", textBoxTelefone.Text);

                insertCmd.Parameters.Add(paramNome);
                insertCmd.Parameters.Add(paramTelefone);

                try
                {
                    if(origem.conexao.State == ConnectionState.Closed)
                    {
                        origem.conexao.Open();
                    }
                    insertCmd.ExecuteNonQuery();
                    origem.atualizar();
                    this.Close();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Erro na conexao!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (origem.conexao.State == ConnectionState.Closed)
                    {
                        origem.conexao.Close();
                    }
                }

            }

        }
    }
}
