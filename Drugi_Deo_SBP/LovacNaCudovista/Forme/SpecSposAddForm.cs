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
    public partial class SpecSposAddForm : Form
    {
        SpecSposobnostBasic specspos;
        public SpecSposAddForm()
        {
            InitializeComponent();
            specspos = new SpecSposobnostBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu sposobnost?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.specspos.NazivSpecSpos = txbNaziv.Text;

                DTOManager.sacuvajSpecSpos(specspos);
                MessageBox.Show("Dodavanje sposobnosti je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
