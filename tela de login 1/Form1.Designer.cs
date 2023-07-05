namespace tela_de_login_1
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
            this.LblNomeLoja = new System.Windows.Forms.Label();
            this.LBLlogin = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.Lblsenha = new System.Windows.Forms.Label();
            this.TxtCampoEmail = new System.Windows.Forms.TextBox();
            this.TxtCampoSenha = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomeLoja
            // 
            this.LblNomeLoja.AutoSize = true;
            this.LblNomeLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeLoja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNomeLoja.Location = new System.Drawing.Point(132, 35);
            this.LblNomeLoja.Name = "LblNomeLoja";
            this.LblNomeLoja.Size = new System.Drawing.Size(275, 25);
            this.LblNomeLoja.TabIndex = 0;
            this.LblNomeLoja.Text = "LOJA DE  INFORMATICA";
            // 
            // LBLlogin
            // 
            this.LBLlogin.AutoSize = true;
            this.LBLlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLlogin.Location = new System.Drawing.Point(220, 102);
            this.LBLlogin.Name = "LBLlogin";
            this.LBLlogin.Size = new System.Drawing.Size(58, 25);
            this.LBLlogin.TabIndex = 1;
            this.LBLlogin.Text = "login";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEmail.Location = new System.Drawing.Point(51, 157);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(67, 24);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "e-mail";
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lblsenha.Location = new System.Drawing.Point(51, 230);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(67, 24);
            this.Lblsenha.TabIndex = 3;
            this.Lblsenha.Text = "senha";
            // 
            // TxtCampoEmail
            // 
            this.TxtCampoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCampoEmail.Location = new System.Drawing.Point(55, 184);
            this.TxtCampoEmail.Name = "TxtCampoEmail";
            this.TxtCampoEmail.Size = new System.Drawing.Size(399, 31);
            this.TxtCampoEmail.TabIndex = 4;
            // 
            // TxtCampoSenha
            // 
            this.TxtCampoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCampoSenha.Location = new System.Drawing.Point(55, 257);
            this.TxtCampoSenha.Name = "TxtCampoSenha";
            this.TxtCampoSenha.Size = new System.Drawing.Size(399, 31);
            this.TxtCampoSenha.TabIndex = 5;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(137, 362);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(102, 34);
            this.BtnConfirmar.TabIndex = 6;
            this.BtnConfirmar.Text = "confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(275, 362);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 34);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(555, 429);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.TxtCampoSenha);
            this.Controls.Add(this.TxtCampoEmail);
            this.Controls.Add(this.Lblsenha);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LBLlogin);
            this.Controls.Add(this.LblNomeLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "tela de login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeLoja;
        private System.Windows.Forms.Label LBLlogin;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.TextBox TxtCampoEmail;
        private System.Windows.Forms.TextBox TxtCampoSenha;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

