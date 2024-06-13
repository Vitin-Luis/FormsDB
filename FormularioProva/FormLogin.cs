using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioProva
{
    public partial class FormLogin : Form
    {
        Form1 origem;
        private string nome = "admin";
        private string senha = "12345";
        public FormLogin(Form1 form1)
        {
            InitializeComponent();
            origem = form1;
            btnLogar.Enabled = false;
        }



        private void checkBoxPacto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPacto.Checked == true)
            {
                btnLogar.Enabled = true;
            }
            else
            {
                btnLogar.Enabled = false;
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nomeDigitado = textBoxNome.Text;
            string senhaDigitada = textBoxSenha.Text;
            

            if (nomeDigitado.Equals(nome) && senhaDigitada.Equals(senha))
            {
                origem.logado = true;
                origem.verificaLogado();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Incorreto!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
