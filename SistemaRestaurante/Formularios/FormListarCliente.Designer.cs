namespace SistemaRestaurante.Formularios
{
    partial class FormListarCliente
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
            this.dtGridViewCliente = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewCliente
            // 
            this.dtGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cpf,
            this.dataNascimento,
            this.telefone,
            this.email});
            this.dtGridViewCliente.Location = new System.Drawing.Point(56, 167);
            this.dtGridViewCliente.Name = "dtGridViewCliente";
            this.dtGridViewCliente.RowHeadersWidth = 62;
            this.dtGridViewCliente.RowTemplate.Height = 28;
            this.dtGridViewCliente.Size = new System.Drawing.Size(689, 172);
            this.dtGridViewCliente.TabIndex = 1;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 8;
            this.nome.Name = "nome";
            this.nome.Width = 85;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 8;
            this.cpf.Name = "cpf";
            this.cpf.Width = 120;
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "Data Nascimento";
            this.dataNascimento.MinimumWidth = 8;
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Width = 150;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 8;
            this.telefone.Name = "telefone";
            this.telefone.Width = 120;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "RELAÇÃO DE CADASTRO DE CLIENTES";
            // 
            // FormListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridViewCliente);
            this.Name = "FormListarCliente";
            this.Text = "FormListarCliente";
            this.Load += new System.EventHandler(this.FormListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label1;
    }
}