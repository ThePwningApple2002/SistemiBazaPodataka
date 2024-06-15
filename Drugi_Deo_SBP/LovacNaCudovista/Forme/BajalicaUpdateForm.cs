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
    public partial class BajalicaUpdateForm : Form
    {
        BajalicaBasic bajalica;
        public BajalicaUpdateForm(BajalicaBasic baj)
        {
            InitializeComponent();
            bajalica = baj;
        }
        private void BajalicaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDSTAVNIKA";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.bajalica.NazivBajalica;
            txbPrednost.Text = this.bajalica.Prednost;
            txbZastita.Text = this.bajalica.Zastita;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene bajalice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.bajalica.NazivBajalica = txbNaziv.Text;
                this.bajalica.Prednost = txbPrednost.Text; 
                this.bajalica.Zastita = txbZastita.Text;


                DTOManager.azurirajBajalicu(this.bajalica);
                MessageBox.Show("Azuriranje bajalice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
