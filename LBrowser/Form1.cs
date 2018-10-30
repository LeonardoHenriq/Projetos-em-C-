using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Avancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URL.Text);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
