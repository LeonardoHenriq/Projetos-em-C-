namespace Leonardo_Urbano
{
    partial class FrmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArroz = new System.Windows.Forms.TextBox();
            this.txtfeijao = new System.Windows.Forms.TextBox();
            this.txtcarne = new System.Windows.Forms.TextBox();
            this.txtrefrigerante = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(177, 14);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(170, 23);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produtos";
            // 
            // txtArroz
            // 
            this.txtArroz.Enabled = false;
            this.txtArroz.Location = new System.Drawing.Point(243, 127);
            this.txtArroz.Margin = new System.Windows.Forms.Padding(4);
            this.txtArroz.Name = "txtArroz";
            this.txtArroz.Size = new System.Drawing.Size(32, 23);
            this.txtArroz.TabIndex = 7;
            // 
            // txtfeijao
            // 
            this.txtfeijao.Enabled = false;
            this.txtfeijao.Location = new System.Drawing.Point(243, 157);
            this.txtfeijao.Margin = new System.Windows.Forms.Padding(4);
            this.txtfeijao.Name = "txtfeijao";
            this.txtfeijao.Size = new System.Drawing.Size(32, 23);
            this.txtfeijao.TabIndex = 8;
            // 
            // txtcarne
            // 
            this.txtcarne.Enabled = false;
            this.txtcarne.Location = new System.Drawing.Point(243, 187);
            this.txtcarne.Margin = new System.Windows.Forms.Padding(4);
            this.txtcarne.Name = "txtcarne";
            this.txtcarne.Size = new System.Drawing.Size(32, 23);
            this.txtcarne.TabIndex = 9;
            // 
            // txtrefrigerante
            // 
            this.txtrefrigerante.Enabled = false;
            this.txtrefrigerante.Location = new System.Drawing.Point(243, 217);
            this.txtrefrigerante.Margin = new System.Windows.Forms.Padding(4);
            this.txtrefrigerante.Name = "txtrefrigerante";
            this.txtrefrigerante.Size = new System.Drawing.Size(32, 23);
            this.txtrefrigerante.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(159, 259);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 23);
            this.txtTotal.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(116, 259);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(39, 15);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNome,
            this.ClPreco});
            this.DgvDados.Location = new System.Drawing.Point(437, 52);
            this.DgvDados.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.Size = new System.Drawing.Size(422, 250);
            this.DgvDados.TabIndex = 14;
            this.DgvDados.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arroz 7,00 R$/kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Feijão 5,00 R$/kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Carne 20,00 R$/kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Refrigerante 3,50 R$/Un";
            // 
            // ClNome
            // 
            this.ClNome.HeaderText = "Nome do Cliente";
            this.ClNome.Name = "ClNome";
            this.ClNome.ReadOnly = true;
            // 
            // ClPreco
            // 
            this.ClPreco.HeaderText = "Valor em R$";
            this.ClPreco.Name = "ClPreco";
            this.ClPreco.ReadOnly = true;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Leonardo_Urbano.Properties.Resources.FundoVendas;
            this.ClientSize = new System.Drawing.Size(872, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtrefrigerante);
            this.Controls.Add(this.txtcarne);
            this.Controls.Add(this.txtfeijao);
            this.Controls.Add(this.txtArroz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCliente);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArroz;
        private System.Windows.Forms.TextBox txtfeijao;
        private System.Windows.Forms.TextBox txtcarne;
        private System.Windows.Forms.TextBox txtrefrigerante;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPreco;
    }
}