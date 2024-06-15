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
    public partial class UsloviUpdateForm : Form
    {
        UsloviZaPrimenuBasic uslovi;
        public UsloviUpdateForm(UsloviZaPrimenuBasic ub)
        {
            InitializeComponent();
            uslovi = ub;
        }
        private void UsloviUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE USLOVA";

        }
        public void popuniPodacima()
        {
            txbUslov.Text = this.uslovi.Uslov;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene uslova?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.uslovi.Uslov = txbUslov.Text;


                DTOManager.AzurirajUslov(this.uslovi);
                MessageBox.Show("Azuriranje uslova je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
