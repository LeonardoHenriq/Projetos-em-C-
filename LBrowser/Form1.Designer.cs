namespace LBrowser
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
            this.Voltar = new System.Windows.Forms.Button();
            this.Avancar = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(13, 13);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 0;
            this.Voltar.Text = "<";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Avancar
            // 
            this.Avancar.Location = new System.Drawing.Point(94, 13);
            this.Avancar.Name = "Avancar";
            this.Avancar.Size = new System.Drawing.Size(75, 23);
            this.Avancar.TabIndex = 1;
            this.Avancar.Text = ">";
            this.Avancar.UseVisualStyleBackColor = true;
            this.Avancar.Click += new System.EventHandler(this.Avancar_Click);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(175, 15);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(445, 20);
            this.URL.TabIndex = 2;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(626, 12);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 3;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(707, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(910, 462);
            this.webBrowser1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Avancar);
            this.Controls.Add(this.Voltar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Avancar;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

