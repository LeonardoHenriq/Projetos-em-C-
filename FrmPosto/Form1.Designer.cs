namespace FrmPosto
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
            this.btngravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtvunidade = new System.Windows.Forms.TextBox();
            this.txtqntd = new System.Windows.Forms.TextBox();
            this.txtvtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(270, 239);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 8;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor Unidade";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(270, 39);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(100, 20);
            this.txtcliente.TabIndex = 1;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(270, 65);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 7;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(270, 91);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 20);
            this.txtdata.TabIndex = 3;
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(270, 117);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(100, 20);
            this.txtproduto.TabIndex = 4;
            this.txtproduto.Leave += new System.EventHandler(this.txtproduto_Leave);
            // 
            // txtvunidade
            // 
            this.txtvunidade.Enabled = false;
            this.txtvunidade.Location = new System.Drawing.Point(270, 169);
            this.txtvunidade.Name = "txtvunidade";
            this.txtvunidade.Size = new System.Drawing.Size(100, 20);
            this.txtvunidade.TabIndex = 6;
            // 
            // txtqntd
            // 
            this.txtqntd.Location = new System.Drawing.Point(270, 143);
            this.txtqntd.Name = "txtqntd";
            this.txtqntd.Size = new System.Drawing.Size(100, 20);
            this.txtqntd.TabIndex = 5;
            this.txtqntd.Leave += new System.EventHandler(this.txtqntd_Leave);
            // 
            // txtvtotal
            // 
            this.txtvtotal.Enabled = false;
            this.txtvtotal.Location = new System.Drawing.Point(270, 195);
            this.txtvtotal.Name = "txtvtotal";
            this.txtvtotal.Size = new System.Drawing.Size(100, 20);
            this.txtvtotal.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valor Total";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7});
            this.dgv.Location = new System.Drawing.Point(431, 39);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(244, 223);
            this.dgv.TabIndex = 9;
            // 
            // c1
            // 
            this.c1.HeaderText = "Nome Cliente";
            this.c1.Name = "c1";
            // 
            // c2
            // 
            this.c2.HeaderText = "CPF";
            this.c2.Name = "c2";
            // 
            // c3
            // 
            this.c3.HeaderText = "Data";
            this.c3.Name = "c3";
            // 
            // c4
            // 
            this.c4.HeaderText = "Produto";
            this.c4.Name = "c4";
            // 
            // c5
            // 
            this.c5.HeaderText = "Quantidade";
            this.c5.Name = "c5";
            // 
            // c6
            // 
            this.c6.HeaderText = "Valor Unidade";
            this.c6.Name = "c6";
            // 
            // c7
            // 
            this.c7.HeaderText = "Valor Total";
            this.c7.Name = "c7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvtotal);
            this.Controls.Add(this.txtqntd);
            this.Controls.Add(this.txtvunidade);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngravar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtvunidade;
        private System.Windows.Forms.TextBox txtqntd;
        private System.Windows.Forms.TextBox txtvtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.DataGridViewTextBoxColumn c7;
    }
}

