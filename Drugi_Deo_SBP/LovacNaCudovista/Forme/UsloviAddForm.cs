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
    public partial class UsloviAddForm : Form
    {
        UsloviZaPrimenuBasic uslovi;
        private int idprotivmera;
        public UsloviAddForm(int idpm)
        {
            InitializeComponent();
            uslovi = new UsloviZaPrimenuBasic();
            this.idprotivmera = idpm;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi uslov?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.uslovi.Uslov = txbUslov.Text;
                this.uslovi.UslPM = new ProtivmereBasic { IdProtivmere = this.idprotivmera };


                DTOManager.DodajUslov(uslovi);
                MessageBox.Show("Dodavanje uslova je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
