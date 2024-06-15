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
    public partial class LovacUpdateForm : Form
    {
        LovacBasic lovac;
        public LovacUpdateForm(LovacBasic lb)
        {
            InitializeComponent();
            lovac = lb;
        }
        private void LovacUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDSTAVNIKA";

        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.lovac.ImeLovca;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene lovca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.lovac.ImeLovca = txbNaziv.Text;
                

                DTOManager.azurirajLovca(this.lovac);
                MessageBox.Show("Azuriranje lovca je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
