namespace _20ingrid3c1
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
            this.btnlogar = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlogar
            // 
            this.btnlogar.Location = new System.Drawing.Point(308, 246);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(143, 45);
            this.btnlogar.TabIndex = 0;
            this.btnlogar.Text = "logar";
            this.btnlogar.UseVisualStyleBackColor = true;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(366, 74);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 1;
            this.lbllogin.Text = "Login";
            this.lbllogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(262, 141);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "email";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(257, 187);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(36, 13);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "senha";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(369, 138);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 4;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(369, 184);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnlogar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
    }
}

