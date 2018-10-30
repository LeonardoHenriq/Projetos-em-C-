using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnremover_Click(object sender, EventArgs e)
        {
            if (cmbGoleiro.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador!!!");
                cmbGoleiro.Focus();

            }else if (cmbAlaDir.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador!!!");
                cmbAlaDir.Focus();

            }else if (cmbAlaEsq.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador!!!");
                cmbAlaEsq.Focus();

            }
            if (cmbFixo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador!!!");
                cmbFixo.Focus();

            }else if (cmbPive.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um jogador!!!");
                cmbPive.Focus();

            }
            else
            {
                string goleiro = cmbGoleiro.Items[cmbGoleiro.SelectedIndex].ToString();
                string fixo = cmbFixo.Items[cmbFixo.SelectedIndex].ToString();
                string alad = cmbAlaDir.Items[cmbAlaDir.SelectedIndex].ToString();
                string alaes = cmbAlaEsq.Items[cmbAlaEsq.SelectedIndex].ToString();
                string pive= cmbPive.Items[cmbPive.SelectedIndex].ToString();

                MessageBox.Show("O time esta formado... \nGoleiro: " + goleiro + "\nFixo: " + fixo + "\nAla Direira: " + alad + "\nAla Esquerda: " + alaes + "\nPive: " + pive);
            }
        }
    }
}
