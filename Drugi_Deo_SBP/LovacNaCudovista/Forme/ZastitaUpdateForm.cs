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
    public partial class ZastitaUpdateForm : Form
    {
        ZastitaBasic zastita;
        public ZastitaUpdateForm(ZastitaBasic zastita)
        {
            InitializeComponent();
            this.zastita = zastita;
        }
        private void ZastitaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE ZASTITE";

        }
        public void popuniPodacima()
        {
            txbNazivZastite.Text = this.zastita.NazivZastite;
            txbTipZastite.Text = this.zastita.TipZastite;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene zastite?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.zastita.NazivZastite = txbNazivZastite.Text;
                this.zastita.TipZastite = txbTipZastite.Text;


                DTOManager.AzurirajZastitu(this.zastita);
                MessageBox.Show("Azuriranje legende je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
