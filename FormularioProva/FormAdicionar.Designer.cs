namespace FormularioProva
{
    partial class FormAdicionar
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
            label1 = new Label();
            label2 = new Label();
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            btnConfirmarContato = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 100);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 178);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(122, 97);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(122, 175);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(100, 23);
            textBoxTelefone.TabIndex = 3;
            // 
            // btnConfirmarContato
            // 
            btnConfirmarContato.Location = new Point(136, 267);
            btnConfirmarContato.Name = "btnConfirmarContato";
            btnConfirmarContato.Size = new Size(75, 23);
            btnConfirmarContato.TabIndex = 5;
            btnConfirmarContato.Text = "Adicionar";
            btnConfirmarContato.UseVisualStyleBackColor = true;
            btnConfirmarContato.Click += btnConfirmarContato_Click;
            // 
            // FormAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 359);
            Controls.Add(btnConfirmarContato);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdicionar";
            Text = "FormAdicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private Button btnConfirmarContato;
    }
}