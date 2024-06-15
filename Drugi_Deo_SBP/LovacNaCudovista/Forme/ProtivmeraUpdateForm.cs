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
    public partial class ProtivmeraUpdateForm : Form
    {
        ProtivmereBasic protivmera;
        public ProtivmeraUpdateForm(ProtivmereBasic pb)
        {
            InitializeComponent();
            protivmera = pb;
        }
        private void ProtivmeraUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PROTIVMERE";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.protivmera.NazivProtivmere;
            txbOpis.Text = this.protivmera.OpisProtivmere;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene protivmere?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.protivmera.NazivProtivmere = txbNaziv.Text;
                this.protivmera.OpisProtivmere = txbOpis.Text;


                DTOManager.AzurirajProtivmere(this.protivmera);
                MessageBox.Show("Azuriranje protivmere je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
