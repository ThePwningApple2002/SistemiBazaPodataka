using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovacNaCudovista.Forme
{
    public partial class MagCudovisteUpdateForm : Form
    {
        MagCudovisteBasic cudoviste;
        public MagCudovisteUpdateForm()
        {
            InitializeComponent();
        }
        public MagCudovisteUpdateForm(MagCudovisteBasic c)
        {
            InitializeComponent();
            this.cudoviste = c;
        }
        private void MagCudovisteUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE CUDOVISTA";
        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.cudoviste.NazivCud;
            txbPodtip.Text = this.cudoviste.PodTipCud;
            txbVekPom.Text = this.cudoviste.VekPomCud.ToString();
            txbPostojanje.Text = this.cudoviste.Postojanje;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene cudovista?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.cudoviste.NazivCud = txbNaziv.Text;
                this.cudoviste.PodTipCud = txbPodtip.Text;
                this.cudoviste.VekPomCud = int.Parse(txbVekPom.Text);
                this.cudoviste.Postojanje = txbPostojanje.Text;


                DTOManager.azurirajMagCudoviste(this.cudoviste);
                MessageBox.Show("Azuriranje cudovista je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
