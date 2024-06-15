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
    public partial class ProtivmeraAddForm : Form
    {
        ProtivmereBasic protivmera;
        public ProtivmeraAddForm()
        {
            InitializeComponent();
            protivmera = new ProtivmereBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu protivmeru?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {



                this.protivmera.NazivProtivmere = txbNaziv.Text;
                this.protivmera.OpisProtivmere = txbOpis.Text;


                DTOManager.DodajProtivmere(protivmera);
                MessageBox.Show("Dodavanje protivmere je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
