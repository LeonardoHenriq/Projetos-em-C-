namespace Trabalho_LTP1
{
    partial class Registro
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
            this.btnvalidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtfone = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(84, 213);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(115, 23);
            this.btnvalidar.TabIndex = 6;
            this.btnvalidar.Text = "Salvar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(115, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(84, 169);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(115, 20);
            this.txtend.TabIndex = 5;
            // 
            // txtfone
            // 
            this.txtfone.Location = new System.Drawing.Point(84, 143);
            this.txtfone.Mask = "(00)00000-0000";
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(115, 20);
            this.txtfone.TabIndex = 4;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(84, 91);
            this.txtrg.Mask = "00.000.000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(115, 20);
            this.txtrg.TabIndex = 2;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(84, 117);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(115, 20);
            this.txtcpf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fone";
            // 
            // dgv
            // 
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(288, 65);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(245, 124);
            this.dgv.TabIndex = 21;
            this.dgv.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CPF";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Endereço";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btndeletar
            // 
            this.btndeletar.Enabled = false;
            this.btndeletar.Location = new System.Drawing.Point(84, 242);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(115, 23);
            this.btndeletar.TabIndex = 7;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Visible = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtfone);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvalidar);
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.MaskedTextBox txtfone;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btndeletar;
    }
}

