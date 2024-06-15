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
    public partial class BajalicaAddForm : Form
    {
        BajalicaBasic bajalica;
        public BajalicaAddForm()
        {
            InitializeComponent();
            bajalica = new BajalicaBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu bajalicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {



                this.bajalica.NazivBajalica = txbNaziv.Text;
                this.bajalica.Zastita = txbZastita.Text;
                this.bajalica.Prednost = txbPrednost.Text;


                DTOManager.dodajBajalicu(bajalica);
                MessageBox.Show("Dodavanje bajalice je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
