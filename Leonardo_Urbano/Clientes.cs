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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Complete o campo Nome corretamente");
                txtNome.Focus();
            } else if (txtRg.MaskFull == false)
            {
                MessageBox.Show("Complete o campo RG corretamente");
                txtRg.Text = "";
                txtRg.Focus();
            } else if (txtCPF.MaskFull == false)
            {
                MessageBox.Show("Complete o campo CPF corretamente");
                txtCPF.Text = "";
                txtCPF.Focus();
            } else if (CmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Complete o campo Sexo corretamente");
                CmbSexo.Focus();
            } else if (txtEnd.Text.Trim() == "")
            {
                MessageBox.Show("Complete o campo Endereço corretamente");
                txtEnd.Focus();
            } else if (txtFone.MaskFull == false)
            {
                MessageBox.Show("Complete o campo Telefone corretamente");
                txtFone.Text = "";
                txtFone.Focus();
            }
            else
            {
                string nome = txtNome.Text.Trim().ToUpper();
                string rg = txtRg.Text.Trim();
                string cpf = txtCPF.Text.Trim();
                string sexo = CmbSexo.Items[CmbSexo.SelectedIndex].ToString();
                string end = txtEnd.Text.Trim();
                string fone = txtFone.Text.Trim();

                MessageBox.Show("Usuario Cadastrado!!! \n Nome: " + nome + "\n RG: " + rg + "\n CPF: " + cpf + "\n Sexo: " + sexo + "\n Endereço: "+ end+ "\n Telefone: "+fone);

                StreamWriter arq = new StreamWriter(@"C:Clientes_Cadastrados.txt", true);
                arq.WriteLine(nome);
                arq.WriteLine(rg);
                arq.WriteLine(cpf);
                arq.WriteLine(sexo);
                arq.WriteLine(end);
                arq.WriteLine(fone);
                arq.Dispose();
                arq.Close();

                txtNome.Text = "";
                txtRg.Text = "";
                txtCPF.Text = "";
                CmbSexo.SelectedIndex = -1;
                txtEnd.Text = "";
                txtFone.Text = "";
            }

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            txtCPF.Enabled = false;
            txtRg.Enabled = false;
            txtEnd.Enabled = false;
            txtFone.Enabled = false;
            CmbSexo.Enabled = false;
            txtNome.Enabled=false;
            txtBusca.Visible = true;           
            txtBusca.Focus();
 
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            string busca = txtBusca.Text.Trim().ToUpper();
            bool achou = false;

            StreamReader ler = new StreamReader(@"C:Clientes_Cadastrados.txt");
            string linha = "";

            while ((linha = ler.ReadLine()) != null)
            {
                if (linha == busca)
                {
                    MessageBox.Show("Cliente Encontrado!!!\n Nome: " + linha + "\n RG: " + ler.ReadLine() + "\n CPF: " + ler.ReadLine() + "\n Sexo: " + ler.ReadLine() + "\n Endereço: " + ler.ReadLine() + "\n Telefone: " + ler.ReadLine());

                    achou = true;
                    break;
                }
            }
            if (achou == false)
            {
                MessageBox.Show(busca + " Nao foi encontrado");
            }
            ler.Dispose();
            ler.Close();

            txtNome.Text="";
            txtNome.Enabled = true;
            txtRg.Enabled = true;
            txtCPF.Enabled = true;
            txtFone.Enabled = true;
            txtEnd.Enabled = true;
            CmbSexo.Enabled = true;
            txtBusca.Text = "";
            txtBusca.Visible = false;
           
        }
    }
}
