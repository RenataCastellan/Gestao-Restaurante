namespace SistemaRestaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCasdatrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLE CLIENTE";
            // 
            // btCasdatrar
            // 
            this.btCasdatrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCasdatrar.Location = new System.Drawing.Point(230, 115);
            this.btCasdatrar.Name = "btCasdatrar";
            this.btCasdatrar.Size = new System.Drawing.Size(293, 38);
            this.btCasdatrar.TabIndex = 1;
            this.btCasdatrar.Text = "CADASTRAR";
            this.btCasdatrar.UseVisualStyleBackColor = true;
            this.btCasdatrar.Click += new System.EventHandler(this.btCasdatrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(230, 187);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(293, 38);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "ATUALIZAR";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(230, 254);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(293, 38);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExluir
            // 
            this.btExluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExluir.Location = new System.Drawing.Point(230, 329);
            this.btExluir.Name = "btExluir";
            this.btExluir.Size = new System.Drawing.Size(293, 38);
            this.btExluir.TabIndex = 4;
            this.btExluir.Text = "EXCLUIR";
            this.btExluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExluir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCasdatrar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restaurante Sabor da Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCasdatrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExluir;
    }
}

