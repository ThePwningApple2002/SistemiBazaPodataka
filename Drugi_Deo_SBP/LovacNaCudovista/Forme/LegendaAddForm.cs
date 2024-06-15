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
    public partial class LegendaAddForm : Form
    {
        LegendaBasic legenda;
        private int idPozPred;
        public LegendaAddForm(int idPozPred)
        {
            InitializeComponent();
            legenda = new LegendaBasic();

            this.idPozPred = idPozPred;

        }

            
        private void btnDodaj_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da dodate novu legendu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.legenda.PrvoPominjanje = txbPrvoPom.Text;
                this.legenda.TekstLegende = txbText.Text;
                this.legenda.ZemljaPorekla = txbZemljaPorekla.Text;

                // Postavite ID predstavnika
                this.legenda.LegZaPP = new PoznatiPredstavnikBasic { IdPozPred = this.idPozPred };


                DTOManager.dodajLegendu(this.legenda.LegZaPP,this.legenda);
                MessageBox.Show("Dodavanje legende je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
