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
    public partial class MagCudovisteAddForm : Form
    {
        MagCudovisteBasic cudoviste;
        public MagCudovisteAddForm()
        {
            InitializeComponent();
            cudoviste = new MagCudovisteBasic();
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
                this.cudoviste.Postojanje = txbPostojanje.Text;


                DTOManager.dodajMagCudoviste(this.cudoviste);
                MessageBox.Show("Dodavanje cudovista je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
