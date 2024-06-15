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
    public partial class PredmetUpdateForm : Form
    {
        PredmetBasic predmet;
        public PredmetUpdateForm(PredmetBasic p)
        {
            InitializeComponent();
            predmet = p;
        }

        private void PredmetUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDMETA";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.predmet.NazivPredmeta;
            txbTip.Text = this.predmet.TipPredmeta;
            txbMaterijal.Text = this.predmet.MaterijalPredmeta;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene bajalice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.predmet.NazivPredmeta = txbNaziv.Text;
                this.predmet.TipPredmeta = txbTip.Text;
                this.predmet.MaterijalPredmeta = txbMaterijal.Text;


                DTOManager.AzurirajPredmet(this.predmet);
                MessageBox.Show("Azuriranje bajalice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
