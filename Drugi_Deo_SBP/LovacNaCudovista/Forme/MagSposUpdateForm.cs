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
    public partial class MagSposUpdateForm : Form
    {
        MagSposobnostBasic magspos;
        public MagSposUpdateForm(MagSposobnostBasic ms)
        {
            InitializeComponent();
            magspos = ms;
        }

        private void MagSposUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE SPOSOBNOSTI";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.magspos.NazivMagSpos;
            txbOpis.Text = this.magspos.OpisMagSpos;
            txbOfanzivno.Text = this.magspos.Ofanzivna;
            txbDefanzivna.Text = this.magspos.Defanzivna;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene sposobnosti?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.magspos.NazivMagSpos = txbNaziv.Text;
                this.magspos.OpisMagSpos = txbOpis.Text;
                this.magspos.Ofanzivna = txbOfanzivno.Text;
                this.magspos.Defanzivna = txbDefanzivna.Text;


                DTOManager.azurirajMagSpos(this.magspos);
                MessageBox.Show("Azuriranje sposobnosti je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
