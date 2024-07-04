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
    public partial class MagSposAddForm : Form
    {
        MagSposobnostBasic ms;
        public MagSposAddForm()
        {
            InitializeComponent();
            ms = new MagSposobnostBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu sposobnost?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.ms.NazivMagSpos = txbNaziv.Text;
                this.ms.OpisMagSpos = txbOpis.Text;
                this.ms.Ofanzivna = txbOfanzivno.Text;
                this.ms.Defanzivna= txbDefanzivna.Text;


                DTOManager.sacuvajMagSpos(ms);
                MessageBox.Show("Dodavanje sposobnosti je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
