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
    public partial class SusretUpdateForm : Form
    {
        SusretBasic susret;
        public SusretUpdateForm(SusretBasic sb)
        {
            InitializeComponent();
            susret = sb;
        }
        private void SusretUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE SUSRETA";

        }
        public void popuniPodacima()
        {
            txbIshod.Text = this.susret.Ishod;
            txbVreme.Text = this.susret.Vreme;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene susreta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.susret.Ishod = txbIshod.Text;
                this.susret.Vreme = txbVreme.Text;


                DTOManager.AzurirajSusret(this.susret);
                MessageBox.Show("Azuriranje susreta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
