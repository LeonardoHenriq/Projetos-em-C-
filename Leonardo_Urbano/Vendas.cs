using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Leonardo_Urbano
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1)
            {
                if (txtArroz.Text == "")
                {
                    txtArroz.Focus();
                    MessageBox.Show("Informe o valor 0 se nao deseja comprar o item");

                }
                else if (txtfeijao.Text == "")
                {
                    txtfeijao.Focus();
                    MessageBox.Show("Informe o valor 0 se nao deseja comprar o item");
                }
                else if (txtcarne.Text == "")
                {
                    txtcarne.Focus();
                    MessageBox.Show("Informe o valor 0 se nao deseja comprar o item");
                }
                else if (txtrefrigerante.Text == "")
                {
                    txtrefrigerante.Focus();
                    MessageBox.Show("Informe o valor 0 se nao deseja comprar o item");
                }
                else
                {
                    double total = 0, Pa = 7.00, Pf = 5.00, Pc = 20.00, Pr = 3.50;
                    double arroz = Convert.ToDouble(txtArroz.Text);
                    double feijao = Convert.ToDouble(txtfeijao.Text);
                    double carne = Convert.ToDouble(txtcarne.Text);
                    double refri = Convert.ToDouble(txtrefrigerante.Text);

                    total = (Pa * arroz) + (Pf * feijao) + (Pc * carne) + (Pr * refri);
                    txtTotal.Text = Convert.ToString(total);
                    if (total != 0)
                    {
                        MessageBox.Show("Venda concluida, Total: " + total + " R$");
                        txtTotal.Text = Convert.ToString(total);

                        DgvDados.Visible = true;
                        int linhas = DgvDados.Rows.Count;
                        DgvDados.Rows.Add();
                        DgvDados.Rows[linhas].Cells[0].Value = cmbCliente.Items[cmbCliente.SelectedIndex].ToString();
                        DgvDados.Rows[linhas].Cells[1].Value = txtTotal.Text;

                        txtArroz.Enabled = false;
                        txtArroz.Text = "";
                        txtfeijao.Enabled = false;
                        txtfeijao.Text = "";
                        txtcarne.Enabled = false;
                        txtcarne.Text = "";
                        txtrefrigerante.Enabled = false;
                        txtrefrigerante.Text = "";
                        txtTotal.Text = "";
                        cmbCliente.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Realize alguma compra");
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Selecione Algum cliente para realizar a compra");
                cmbCliente.Focus();
            }          
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            StreamReader ler = new StreamReader(@"C:Clientes_Cadastrados.txt");
            while (ler != null){
                string nome = ler.ReadLine().ToUpper();
                string rg = ler.ReadLine();
                string cpf = ler.ReadLine();
                string sexo = ler.ReadLine();
                string end = ler.ReadLine();
                string telefone = ler.ReadLine();
                cmbCliente.Items.Add(nome);
            }
            ler.Dispose();
            ler.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArroz.Enabled = true;
            txtfeijao.Enabled = true;
            txtcarne.Enabled = true;
            txtrefrigerante.Enabled = true;
        }
    }
}
