using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbArroz.Checked == true)
            {
                txtArroz.Enabled = true;
                if (txtArroz.Text != "") {
                    
                    double QtdA = Convert.ToDouble(txtArroz.Text);
                    double PA = 2.00, res = 0;
                    res = PA * QtdA;
                    txtArroz.Text = Convert.ToString(res);
                    MessageBox.Show("preço total= " + res);
                }
                else
                {
                    MessageBox.Show("complete o campo com a quantidade do produto!");
                }
            }else if (rdbLeite.Checked == true)
            {
                txtLeite.Enabled = true;
                if (txtLeite.Text != "")
                {
                    
                    double QtdL = Convert.ToDouble(txtLeite.Text);
                    double PL = 3.00, res1 = 0;
                    res1 = PL * QtdL;
                    txtLeite.Text = Convert.ToString(res1);
                    MessageBox.Show("preço total= " + res1);
                }
                else
                {
                    MessageBox.Show("complete o campo com a quantidade do produto!");
                }
            }else if (rdbCarne.Checked == true)
            {
                txtCarne.Enabled = true;
                if (txtCarne.Text != "")
                {
                   
                    double Qtdc = Convert.ToDouble(txtCarne.Text);
                    double Pc = 20.00, res2 = 0;
                    res2 = Pc * Qtdc;
                    txtCarne.Text = Convert.ToString(res2);
                    MessageBox.Show("preço total= " + res2);
                }
                else
                {
                    MessageBox.Show("complete o campo com a quantidade do produto!");
                }
            }else if (rdbFeijao.Checked == true)
            {
                txtFeijao.Enabled = true;
                if (txtFeijao.Text != "")
                {
                    
                    double Qtdf = Convert.ToDouble(txtFeijao.Text);
                    double Pf = 2.00, res3 = 0;
                    res3 = Pf * Qtdf;
                    txtFeijao.Text = Convert.ToString(res3);
                    MessageBox.Show("preço total= " + res3);
                }
                else
                {
                    MessageBox.Show("complete o campo com a quantidade do produto!");
                }
            }else if (rdbDolly.Checked == true)
            {
                txtDolly.Enabled = true;
                if (txtDolly.Text != "")
                {
                    
                    double QtdA = Convert.ToDouble(txtDolly.Text);
                    double PA = 1.99, res4 = 0;
                    res4 = PA * QtdA;
                    txtDolly.Text = Convert.ToString(res4);
                    MessageBox.Show("preço total= " + res4);
                }
                else
                {
                    MessageBox.Show("complete o campo com a quantidade do produto!");
                }
            }else
            {
                int linhas = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[linhas].Cells[0].Value = txtArroz.Text;
                dataGridView1.Rows[linhas].Cells[1].Value = txtLeite.Text;
                dataGridView1.Rows[linhas].Cells[2].Value = txtCarne.Text;
                dataGridView1.Rows[linhas].Cells[3].Value = txtFeijao.Text;
                dataGridView1.Rows[linhas].Cells[4].Value = txtDolly.Text;
            }

        }

        private void rdbArroz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbArroz.Checked == true)
            {
                txtArroz.Enabled = true;
                }
                else
                {
                txtArroz.Enabled = false;
                    
                }
            }

            
    }
}
