namespace FormularioProva
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogar = new Button();
            textBoxNome = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBoxPacto = new CheckBox();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(119, 256);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(110, 105);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(110, 165);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 108);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 168);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // checkBoxPacto
            // 
            checkBoxPacto.AutoSize = true;
            checkBoxPacto.Location = new Point(110, 212);
            checkBoxPacto.Name = "checkBoxPacto";
            checkBoxPacto.Size = new Size(96, 19);
            checkBoxPacto.TabIndex = 5;
            checkBoxPacto.Text = "Aceitar pacto";
            checkBoxPacto.UseVisualStyleBackColor = true;
            checkBoxPacto.CheckedChanged += checkBoxPacto_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 363);
            Controls.Add(checkBoxPacto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxNome);
            Controls.Add(btnLogar);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private TextBox textBoxNome;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxPacto;
    }
}