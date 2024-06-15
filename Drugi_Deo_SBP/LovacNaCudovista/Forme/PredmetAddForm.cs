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
    public partial class PredmetAddForm : Form
    {
        PredmetBasic predmet;
        public PredmetAddForm()
        {
            InitializeComponent();
            predmet = new PredmetBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate nov predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.predmet.TipPredmeta = txbTip.Text;
                this.predmet.NazivPredmeta = txbNaziv.Text;
                this.predmet.MaterijalPredmeta = txbMaterijal.Text;


                DTOManager.DodajPredmet(predmet);
                MessageBox.Show("Dodavanje predmeta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
