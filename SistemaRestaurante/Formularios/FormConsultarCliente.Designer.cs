namespace SistemaRestaurante.Formularios
{
    partial class FormConsultarCliente
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
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtPreferencias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btConsultar.Location = new System.Drawing.Point(513, 66);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(144, 42);
            this.btConsultar.TabIndex = 27;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtPreferencias
            // 
            this.txtPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreferencias.Location = new System.Drawing.Point(493, 261);
            this.txtPreferencias.Multiline = true;
            this.txtPreferencias.Name = "txtPreferencias";
            this.txtPreferencias.ReadOnly = true;
            this.txtPreferencias.Size = new System.Drawing.Size(164, 61);
            this.txtPreferencias.TabIndex = 26;
            this.txtPreferencias.TextChanged += new System.EventHandler(this.txtPreferencias_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(489, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preferencias";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(143, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 26);
            this.txtEmail.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(143, 240);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(100, 26);
            this.txtTelefone.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tefone";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(321, 240);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.ReadOnly = true;
            this.txtDataNasc.Size = new System.Drawing.Size(128, 26);
            this.txtDataNasc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data Nascimento";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(321, 315);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(128, 26);
            this.txtCpf.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 162);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(514, 26);
            this.txtNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "CONSULTAR CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.Location = new System.Drawing.Point(143, 74);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(364, 28);
            this.cbBuscarCliente.TabIndex = 28;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.IndianRed;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(306, 379);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(143, 59);
            this.btLimpar.TabIndex = 59;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.cbBuscarCliente);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txtPreferencias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormConsultarCliente";
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.TextBox txtPreferencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        private System.Windows.Forms.Button btLimpar;
    }
}