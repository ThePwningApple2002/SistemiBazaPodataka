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
    public partial class PozPredAddForm : Form
    {
        PoznatiPredstavnikBasic predstavnik;
        public PozPredAddForm()
        {
            InitializeComponent();
            predstavnik = new PoznatiPredstavnikBasic();
            predstavnik.PoznatiPredCud = new CudovisteBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novog predstavnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {


                
                this.predstavnik.JedinstvenoIme = txbJedIme.Text;
                this.predstavnik.Starost = int.Parse(txbStarost.Text);
                this.predstavnik.PoznatiPredCud.IdCudovista = int.Parse(txbCudId.Text);


                DTOManager.dodajPozPred(this.predstavnik, this.predstavnik.PoznatiPredCud);
                MessageBox.Show("Dodavanje predstavnika je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
