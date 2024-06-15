using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LovacNaCudovista.Forme
{
    public partial class LokacijaUpdateForm : Form
    {
        LokacijaBasic lokacija;
        public LokacijaUpdateForm(LokacijaBasic lokacija)
        {
            InitializeComponent();
            this.lokacija = lokacija;
        }
        private void LegendaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE LOKACIJE";

        }
        public void popuniPodacima()
        {
            txbTipLok.Text = this.lokacija.TipLok;
            txbNazivLok.Text = this.lokacija.NazivLok;
            txbZemljaLok.Text = this.lokacija.ZemljaLok;
            txbBlago.Text = this.lokacija.Blago;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene lokacije?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.lokacija.TipLok = txbTipLok.Text;
                this.lokacija.NazivLok = txbNazivLok.Text;
                this.lokacija.ZemljaLok = txbZemljaLok.Text;
                this.lokacija.Blago = txbBlago.Text;


                DTOManager.izmeniLokaciju(this.lokacija);
                MessageBox.Show("Azuriranje legende je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
