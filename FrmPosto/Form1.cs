using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPosto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text.Trim() == "")
            {
                MessageBox.Show("Complete o campo adequadamente");
                txtcliente.Focus();
                txtcliente.Text = "";
            }
            else if (txtcpf.MaskFull == false)
            {
                MessageBox.Show("Complete o campo adequadamente");
                txtcpf.Focus();
                txtcpf.Text = "";
            }
            else if (txtdata.MaskFull == false)
            {
                MessageBox.Show("Complete o campo adequadamente");
                txtdata.Focus();
                txtdata.Text = "";
            }
            else if (txtqntd.Text.Trim() == "") 
            {
                MessageBox.Show("Complete o campo adequadamente");
                txtqntd.Focus();
                txtqntd.Text = "";
            }
            else if(txtproduto.Text.Trim()=="")
            {
                MessageBox.Show("Complete o campo adequadamente");
                txtproduto.Focus();
                txtproduto.Text = "";
            }
            else if(txtqntd.Text.Trim()=="")
            {
                MessageBox.Show("Complete o campo adequadamente");
            }
            else
            {

            }
        }

        private void txtproduto_Leave(object sender, EventArgs e)
        {

            string produto = txtproduto.Text.Trim();
            if (produto == "gasolina")
            {
                txtproduto.Text = "4,70";
            }
            else if (produto == "alcool")
            {
                txtproduto.Text = "2,50";
            }else if(produto== "diesel")
            {
                txtproduto.Text = "3,00";
            }else
            {
                MessageBox.Show("Produto invalido entre com GASOLINA ALCOOL OU DIESEL");
                txtproduto.Focus();
                txtproduto.Text = "";
            }
           
        }

        private void txtqntd_Leave(object sender, EventArgs e)
        {
            double vunidade = 0, vtotal = 0;
            int qntd = 0;
            vunidade = Convert.ToDouble(txtvunidade.Text);
            vtotal = Convert.ToDouble(txtvtotal.Text);
            qntd = Convert.ToInt32(txtqntd.Text);
            vtotal = qntd * vunidade;
            txtvtotal.Text = Convert.ToString(vtotal);
        }
    }
}
