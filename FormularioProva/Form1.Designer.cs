namespace FormularioProva
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewLista = new DataGridView();
            labelBemVindo = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(126, 74);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.Size = new Size(391, 258);
            dataGridViewLista.TabIndex = 0;
            // 
            // labelBemVindo
            // 
            labelBemVindo.AutoSize = true;
            labelBemVindo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBemVindo.Location = new Point(196, 22);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(246, 40);
            labelBemVindo.TabIndex = 1;
            labelBemVindo.Text = "Login necessario";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(131, 356);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(442, 356);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(549, 22);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(labelBemVindo);
            Controls.Add(dataGridViewLista);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelBemVindo;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnLogin;
        public DataGridView dataGridViewLista;
    }
}
