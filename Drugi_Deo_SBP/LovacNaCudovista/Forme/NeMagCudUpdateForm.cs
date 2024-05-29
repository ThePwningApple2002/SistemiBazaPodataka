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
    public partial class NeMagCudUpdateForm : Form
    {
        NeMagCudovisteBasic cudoviste;
        public NeMagCudUpdateForm()
        {
            InitializeComponent();
        }
        public NeMagCudUpdateForm(NeMagCudovisteBasic c)
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
            txbVisina.Text = this.cudoviste.Visina.ToString();
            txbDuzina.Text = this.cudoviste.Duzina.ToString();
            txbKandze.Text = this.cudoviste.Kandze.ToString();
            txbBrojGlava.Text = this.cudoviste.BrojGlava.ToString();
            txbZiviUVodi.Text = this.cudoviste.ZiviUVodi;
            txbLeti.Text = this.cudoviste.Leti;
            txbOtrovno.Text = this.cudoviste.Otrovno;
            txbTezina.Text = this.cudoviste.Tezina.ToString();

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
                this.cudoviste.Visina = int.Parse(txbVisina.Text);
                this.cudoviste.Duzina = int.Parse(txbDuzina.Text);
                this.cudoviste.Kandze = txbKandze.Text;
                this.cudoviste.BrojGlava = int.Parse(txbBrojGlava.Text);
                this.cudoviste.ZiviUVodi = txbZiviUVodi.Text;
                this.cudoviste.Leti = txbLeti.Text;
                this.cudoviste.Otrovno = txbOtrovno.Text;
                this.cudoviste.Tezina = int.Parse(txbTezina.Text);



                DTOManager.azurirajNeMagCudoviste(this.cudoviste);
                MessageBox.Show("Azuriranje prodavnice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
