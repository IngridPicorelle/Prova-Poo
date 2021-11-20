namespace _20ingrid3c1.UI
{
    partial class Form2
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
            this.lblcadastro = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcadastro
            // 
            this.lblcadastro.AutoSize = true;
            this.lblcadastro.Location = new System.Drawing.Point(345, 68);
            this.lblcadastro.Name = "lblcadastro";
            this.lblcadastro.Size = new System.Drawing.Size(106, 13);
            this.lblcadastro.TabIndex = 0;
            this.lblcadastro.Text = "Cadastro dos oculos ";
            this.lblcadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(298, 130);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome ";
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Location = new System.Drawing.Point(298, 186);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(23, 13);
            this.lblcor.TabIndex = 2;
            this.lblcor.Text = "Cor";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(298, 250);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(35, 13);
            this.lblpreco.TabIndex = 3;
            this.lblpreco.Text = "Preço";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(400, 130);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 4;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(400, 183);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(100, 20);
            this.txtcor.TabIndex = 5;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(400, 243);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 6;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(261, 306);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(425, 306);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 8;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(571, 306);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 9;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(261, 383);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(385, 169);
            this.dgvlista.TabIndex = 10;
            this.dgvlista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlista_CellClick);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(552, 130);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(576, 127);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 634);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadastro;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
    }
}