using LovacNaCudovista.Entiteti;
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
    public partial class PozPredUpdateForm : Form
    {
        PoznatiPredstavnikBasic predstavnik;
        public PozPredUpdateForm()
        {
            InitializeComponent();
        }
        public PozPredUpdateForm(PoznatiPredstavnikBasic p)
        {
            InitializeComponent();
            this.predstavnik = p;
        }

        private void PozPredUpdateForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE PREDSTAVNIKA";

        }
        public void popuniPodacima()
        {
            txbJedIme.Text = this.predstavnik.JedinstvenoIme;
            txbStarost.Text = this.predstavnik.Starost.ToString();
            txbCudId.Text = this.predstavnik.PoznatiPredCud.IdCudovista.ToString();

        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene predstavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.predstavnik.JedinstvenoIme = txbJedIme.Text;
                this.predstavnik.Starost = int.Parse(txbStarost.Text);
                this.predstavnik.PoznatiPredCud.IdCudovista = int.Parse(txbCudId.Text);


                DTOManager.izmeniPozPred(this.predstavnik);
                MessageBox.Show("Azuriranje prodavnice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
