using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_LTP1
{
    public partial class Registro : Form
    {
        public Registro()
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
            else
            {

                MessageBox.Show("\n Nome: " + txtNome.Text.Trim() + "\n RG: " + txtrg.Text.Trim() + "\n CPF: " + txtcpf.Text.Trim() +"\n Endereço: " + txtend.Text.Trim() + "\n Fone: " + txtfone.Text.Trim());
                dgv.Visible = true;
                int linhas=dgv.Rows.Count;
                dgv.Rows.Add();
                dgv.Rows[linhas].Cells[0].Value = txtNome.Text;
                dgv.Rows[linhas].Cells[1].Value = txtrg.Text;
                dgv.Rows[linhas].Cells[2].Value = txtcpf.Text;
                dgv.Rows[linhas].Cells[3].Value = txtfone.Text;
                dgv.Rows[linhas].Cells[4].Value = txtend.Text;

                txtNome.Text = "";
                txtrg.Text = "";
                txtcpf.Text = "";
                txtfone.Text = "";
                txtend.Text ="";
                btndeletar.Enabled = true;
                btndeletar.Visible = true;
            }
           
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                dgv.Visible = true;
                dgv.Enabled = true;

                dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                dgv.Refresh();
            }else if (dgv.SelectedRows.Count< 0)
            {
                dgv.Visible = false;
                dgv.Enabled = false;
            }
        }
    }
}
