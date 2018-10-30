using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroCliente
{
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("por favor preencha o campo nome!!!");
                txtNome.Text = "";
                txtNome.Focus();
            }
            else if (txtrg.MaskFull == false)
            {
                MessageBox.Show("por favor preencha o campo rg!!!");
                txtrg.Text = "";
                txtrg.Focus();
            }
            else if (txtcpf.MaskFull == false)
            {
                MessageBox.Show("por favor preencha o campo cpf!!!");
                txtcpf.Text = "";
                txtcpf.Focus();
            }
            else if (txtnascimento.MaskFull == false)
            {
                MessageBox.Show("por favor preencha o campo Nascimento!!!");
                txtnascimento.Text = "";
                txtnascimento.Focus();
            }
            else if (txtend.Text.Trim() == "")
            {
                MessageBox.Show("por favor preencha o campo Endereço!!!");
                txtend.Text = "";
                txtend.Focus();
            }
            else if (txtfone.MaskFull == false)
            {
                MessageBox.Show("por favor preencha o campo Fone!!!");
                txtfone.Text = "";
                txtfone.Focus();
            }
            else if (txtemail.Text.Trim() == "")
            {
                MessageBox.Show("por favor preencha o campo E-mail!!!");
                txtemail.Text = "";
                txtemail.Focus();
            }
            else
            {

                MessageBox.Show("\n Nome: " + txtNome.Text.Trim() + "\n RG: " + txtrg.Text.Trim() + "\n CPF: " + txtcpf.Text.Trim() + "\n Nascimento: " + txtnascimento.Text.Trim() + "\n Endereço: " + txtend.Text.Trim() + "\n Fone: " + txtfone.Text.Trim() + "\n E-mail: " + txtemail.Text.Trim());

                StreamWriter arq = new StreamWriter(@"C:\Users\leonardo\Desktop\Registro_de_Clientes.txt", true);
                arq.WriteLine(txtNome.Text.Trim());
                arq.WriteLine(txtrg.Text.Trim());
                arq.WriteLine(txtcpf.Text.Trim());
                arq.WriteLine(txtnascimento.Text.Trim());
                arq.WriteLine(txtend.Text.Trim());
                arq.WriteLine(txtfone.Text.Trim());
                arq.WriteLine(txtemail.Text.Trim());
                arq.Dispose();
                arq.Close();

                txtNome.Text = "";
                txtrg.Text = "";
                txtcpf.Text = "";
                txtnascimento.Text = "";
                txtend.Text = "";
                txtfone.Text = "";
                txtemail.Text = "";
            }
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("informe quem deseja buscar");
            
            //txtNome.Focus();
            string busca = txtNome.Text;
            bool achou = false;
            StreamReader ler = new StreamReader(@"C:\Users\leonardo\Desktop\Registro_de_Clientes.txt");

            string linha = "";
            while ((linha = ler.ReadLine())!= null)
            {
                if (linha == busca)
                {
                    MessageBox.Show("nome: " + linha + "\n RG: " + ler.ReadLine() + "\n CPF: " + ler.ReadLine() + "\n Data de nascimento: " + ler.ReadLine() + "\n Endereço: " + ler.ReadLine() + "\n Telefone: "+ ler.ReadLine()+"\n E-mail: " +ler.ReadLine());

                    txtNome.Text =busca;
                    txtrg.Text = ler.ReadLine();
                    txtcpf.Text = ler.ReadLine();
                    txtnascimento.Text = ler.ReadLine();
                    txtend.Text = ler.ReadLine();
                    txtfone.Text = ler.ReadLine();
                    txtemail.Text = ler.ReadLine();

                    achou = true;
                    break;
                }
                
            }
            if (achou == false)
            {
                MessageBox.Show(busca + " nao encontrado");
            }
            ler.Dispose();
            ler.Close();

        }
    }
}
