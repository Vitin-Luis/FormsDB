namespace ProvaEstudo
{
    partial class Form1
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.labelMensagemLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(91, 326);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(352, 326);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(87, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(91, 118);
            this.dataGridViewLista.MultiSelect = false;
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLista.Size = new System.Drawing.Size(348, 192);
            this.dataGridViewLista.TabIndex = 2;
            this.dataGridViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentClick);
            // 
            // labelMensagemLogin
            // 
            this.labelMensagemLogin.AutoSize = true;
            this.labelMensagemLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagemLogin.Location = new System.Drawing.Point(181, 23);
            this.labelMensagemLogin.Name = "labelMensagemLogin";
            this.labelMensagemLogin.Size = new System.Drawing.Size(166, 33);
            this.labelMensagemLogin.TabIndex = 3;
            this.labelMensagemLogin.Text = "Bem Vindo";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(438, 23);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(66, 21);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(91, 93);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(266, 20);
            this.textBoxBusca.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(364, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelMensagemLogin);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.Label labelMensagemLogin;

        public System.Windows.Forms.DataGridView dataGridViewLista;

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;

        #endregion

        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Button btnBuscar;
    }
}