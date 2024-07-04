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
    public partial class SpecSposUpdateForm : Form
    {
        SpecSposobnostBasic specspos;
        public SpecSposUpdateForm(SpecSposobnostBasic specspos)
        {
            InitializeComponent();
            this.specspos = specspos;
        }
        private void SpecSposUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE SPOSOBNOSTI";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.specspos.NazivSpecSpos;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene sposobnosti?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.specspos.NazivSpecSpos = txbNaziv.Text;


                DTOManager.azurirajSpecSpos(this.specspos);
                MessageBox.Show("Azuriranje sposobnosti je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
