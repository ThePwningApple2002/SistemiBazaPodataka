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
    public partial class NeMagCudAddForm : Form
    {
        NeMagCudovisteBasic cudoviste;
        public NeMagCudAddForm()
        {
            InitializeComponent();
            cudoviste = new NeMagCudovisteBasic();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novo cudoviste?";
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


                DTOManager.dodajNeMagCudoviste(this.cudoviste);
                MessageBox.Show("Dodavanje cudovista je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
