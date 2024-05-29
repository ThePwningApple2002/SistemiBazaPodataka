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
    public partial class CudovisteUpdateForm : Form
    {
        CudovisteBasic cudoviste;
        public CudovisteUpdateForm()
        {
            InitializeComponent();
        }

        public CudovisteUpdateForm(CudovisteBasic c)
        {
            InitializeComponent();
            this.cudoviste = c;
        }

        private void CudovisteUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE CUDOVISTA {cudoviste.NazivCud.ToUpper()}";
        }
        public void popuniPodacima()
        {
            txbNaziv.Text = this.cudoviste.NazivCud;
            txbPodtip.Text = this.cudoviste.PodTipCud;
            txbVekPom.Text = this.cudoviste.VekPomCud.ToString();

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene cudovista?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.cudoviste.NazivCud = txbNaziv.Text;
                this.cudoviste.PodTipCud = txbPodtip.Text;
                this.cudoviste.VekPomCud = int.Parse(txbVekPom.Text);
                

                DTOManager.azurirajCudoviste(this.cudoviste);
                MessageBox.Show("Azuriranje prodavnice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
