namespace Vender
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFeijao = new System.Windows.Forms.RadioButton();
            this.rdbCarne = new System.Windows.Forms.RadioButton();
            this.rdbDolly = new System.Windows.Forms.RadioButton();
            this.rdbLeite = new System.Windows.Forms.RadioButton();
            this.rdbArroz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArroz = new System.Windows.Forms.TextBox();
            this.txtLeite = new System.Windows.Forms.TextBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtFeijao = new System.Windows.Forms.TextBox();
            this.txtDolly = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDolly);
            this.groupBox1.Controls.Add(this.txtFeijao);
            this.groupBox1.Controls.Add(this.txtCarne);
            this.groupBox1.Controls.Add(this.txtLeite);
            this.groupBox1.Controls.Add(this.txtArroz);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbArroz);
            this.groupBox1.Controls.Add(this.rdbLeite);
            this.groupBox1.Controls.Add(this.rdbFeijao);
            this.groupBox1.Controls.Add(this.rdbCarne);
            this.groupBox1.Controls.Add(this.rdbDolly);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // rdbFeijao
            // 
            this.rdbFeijao.AutoSize = true;
            this.rdbFeijao.Location = new System.Drawing.Point(16, 88);
            this.rdbFeijao.Name = "rdbFeijao";
            this.rdbFeijao.Size = new System.Drawing.Size(97, 17);
            this.rdbFeijao.TabIndex = 3;
            this.rdbFeijao.TabStop = true;
            this.rdbFeijao.Text = "Feijao(2.00/kg)";
            this.rdbFeijao.UseVisualStyleBackColor = true;
            // 
            // rdbCarne
            // 
            this.rdbCarne.AutoSize = true;
            this.rdbCarne.Location = new System.Drawing.Point(16, 65);
            this.rdbCarne.Name = "rdbCarne";
            this.rdbCarne.Size = new System.Drawing.Size(103, 17);
            this.rdbCarne.TabIndex = 2;
            this.rdbCarne.TabStop = true;
            this.rdbCarne.Text = "Carne(20.00/kg)";
            this.rdbCarne.UseVisualStyleBackColor = true;
            // 
            // rdbDolly
            // 
            this.rdbDolly.AutoSize = true;
            this.rdbDolly.Location = new System.Drawing.Point(16, 111);
            this.rdbDolly.Name = "rdbDolly";
            this.rdbDolly.Size = new System.Drawing.Size(113, 17);
            this.rdbDolly.TabIndex = 0;
            this.rdbDolly.TabStop = true;
            this.rdbDolly.Text = "Dolly(1.99/garrafa)";
            this.rdbDolly.UseVisualStyleBackColor = true;
            // 
            // rdbLeite
            // 
            this.rdbLeite.AutoSize = true;
            this.rdbLeite.Location = new System.Drawing.Point(16, 42);
            this.rdbLeite.Name = "rdbLeite";
            this.rdbLeite.Size = new System.Drawing.Size(89, 17);
            this.rdbLeite.TabIndex = 4;
            this.rdbLeite.TabStop = true;
            this.rdbLeite.Text = "Leite (3.00/L)";
            this.rdbLeite.UseVisualStyleBackColor = true;
            // 
            // rdbArroz
            // 
            this.rdbArroz.AutoSize = true;
            this.rdbArroz.Location = new System.Drawing.Point(16, 19);
            this.rdbArroz.Name = "rdbArroz";
            this.rdbArroz.Size = new System.Drawing.Size(96, 17);
            this.rdbArroz.TabIndex = 5;
            this.rdbArroz.TabStop = true;
            this.rdbArroz.Text = "Arroz (2.00/kg)";
            this.rdbArroz.UseVisualStyleBackColor = true;
            this.rdbArroz.CheckedChanged += new System.EventHandler(this.rdbArroz_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qnt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qnt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Qnt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qnt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Qnt";
            // 
            // txtArroz
            // 
            this.txtArroz.Enabled = false;
            this.txtArroz.Location = new System.Drawing.Point(247, 16);
            this.txtArroz.Name = "txtArroz";
            this.txtArroz.Size = new System.Drawing.Size(25, 20);
            this.txtArroz.TabIndex = 10;
            // 
            // txtLeite
            // 
            this.txtLeite.Enabled = false;
            this.txtLeite.Location = new System.Drawing.Point(247, 39);
            this.txtLeite.Name = "txtLeite";
            this.txtLeite.Size = new System.Drawing.Size(25, 20);
            this.txtLeite.TabIndex = 11;
            // 
            // txtCarne
            // 
            this.txtCarne.Enabled = false;
            this.txtCarne.Location = new System.Drawing.Point(247, 62);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(25, 20);
            this.txtCarne.TabIndex = 12;
            // 
            // txtFeijao
            // 
            this.txtFeijao.Enabled = false;
            this.txtFeijao.Location = new System.Drawing.Point(247, 85);
            this.txtFeijao.Name = "txtFeijao";
            this.txtFeijao.Size = new System.Drawing.Size(25, 20);
            this.txtFeijao.TabIndex = 13;
            // 
            // txtDolly
            // 
            this.txtDolly.Enabled = false;
            this.txtDolly.Location = new System.Drawing.Point(247, 108);
            this.txtDolly.Name = "txtDolly";
            this.txtDolly.Size = new System.Drawing.Size(25, 20);
            this.txtDolly.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(413, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFeijao;
        private System.Windows.Forms.RadioButton rdbCarne;
        private System.Windows.Forms.RadioButton rdbDolly;
        private System.Windows.Forms.RadioButton rdbArroz;
        private System.Windows.Forms.RadioButton rdbLeite;
        private System.Windows.Forms.TextBox txtDolly;
        private System.Windows.Forms.TextBox txtFeijao;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtLeite;
        private System.Windows.Forms.TextBox txtArroz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

