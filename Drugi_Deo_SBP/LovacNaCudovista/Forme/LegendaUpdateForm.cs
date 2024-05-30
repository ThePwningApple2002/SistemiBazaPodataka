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
    public partial class LegendaUpdateForm : Form
    {
        LegendaBasic legenda;
        public LegendaUpdateForm(LegendaBasic lb)
        {
            InitializeComponent();
            this.legenda = lb;
        }
        private void LegendaUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE LEGENDE";
            
        }
        public void popuniPodacima()
        {
            txbPrvoPom.Text = this.legenda.PrvoPominjanje;
            txbText.Text = this.legenda.TekstLegende;
            txbZemljaPorekla.Text = this.legenda.ZemljaPorekla;

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene legende?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.legenda.PrvoPominjanje = txbPrvoPom.Text;
                this.legenda.TekstLegende = txbText.Text;
                this.legenda.ZemljaPorekla = txbZemljaPorekla.Text;


                DTOManager.izmeniLegendu(this.legenda);
                MessageBox.Show("Azuriranje legende je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
