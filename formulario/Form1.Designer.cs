namespace formulario
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
            this.cmbGoleiro = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbFixo = new System.Windows.Forms.ComboBox();
            this.cmbAlaDir = new System.Windows.Forms.ComboBox();
            this.cmbAlaEsq = new System.Windows.Forms.ComboBox();
            this.cmbPive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbGoleiro
            // 
            this.cmbGoleiro.Items.AddRange(new object[] {
            "Mario",
            "Cassio",
            "Rogerio ceni"});
            this.cmbGoleiro.Location = new System.Drawing.Point(272, 26);
            this.cmbGoleiro.Name = "cmbGoleiro";
            this.cmbGoleiro.Size = new System.Drawing.Size(148, 21);
            this.cmbGoleiro.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(559, 366);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(217, 56);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar Escalação";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // cmbFixo
            // 
            this.cmbFixo.FormattingEnabled = true;
            this.cmbFixo.Items.AddRange(new object[] {
            "Neymar",
            "F coutinho",
            "marcelo"});
            this.cmbFixo.Location = new System.Drawing.Point(288, 97);
            this.cmbFixo.Name = "cmbFixo";
            this.cmbFixo.Size = new System.Drawing.Size(121, 21);
            this.cmbFixo.TabIndex = 5;
            // 
            // cmbAlaDir
            // 
            this.cmbAlaDir.FormattingEnabled = true;
            this.cmbAlaDir.Items.AddRange(new object[] {
            "Fagner",
            "R Carlos",
            "C Ronaldo"});
            this.cmbAlaDir.Location = new System.Drawing.Point(146, 172);
            this.cmbAlaDir.Name = "cmbAlaDir";
            this.cmbAlaDir.Size = new System.Drawing.Size(121, 21);
            this.cmbAlaDir.TabIndex = 6;
            // 
            // cmbAlaEsq
            // 
            this.cmbAlaEsq.FormattingEnabled = true;
            this.cmbAlaEsq.Items.AddRange(new object[] {
            "L Messi",
            "Maradonna",
            "Carlitos Tevez"});
            this.cmbAlaEsq.Location = new System.Drawing.Point(424, 172);
            this.cmbAlaEsq.Name = "cmbAlaEsq";
            this.cmbAlaEsq.Size = new System.Drawing.Size(121, 21);
            this.cmbAlaEsq.TabIndex = 7;
            // 
            // cmbPive
            // 
            this.cmbPive.FormattingEnabled = true;
            this.cmbPive.Items.AddRange(new object[] {
            "Falcao",
            "Mbbape",
            "Ronaldinho Gaucho"});
            this.cmbPive.Location = new System.Drawing.Point(288, 282);
            this.cmbPive.Name = "cmbPive";
            this.cmbPive.Size = new System.Drawing.Size(121, 21);
            this.cmbPive.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Goleiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fixo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ala Direita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ala Esquerda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPive);
            this.Controls.Add(this.cmbAlaEsq);
            this.Controls.Add(this.cmbAlaDir);
            this.Controls.Add(this.cmbFixo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbGoleiro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGoleiro;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbFixo;
        private System.Windows.Forms.ComboBox cmbAlaDir;
        private System.Windows.Forms.ComboBox cmbAlaEsq;
        private System.Windows.Forms.ComboBox cmbPive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

