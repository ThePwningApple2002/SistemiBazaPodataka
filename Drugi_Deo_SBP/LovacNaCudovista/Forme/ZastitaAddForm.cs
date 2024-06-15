using NHibernate.Util;
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
    public partial class ZastitaAddForm : Form
    {
        ZastitaBasic zastita;
        private int idLokacije;
        public ZastitaAddForm(int idLokacije)
        {
            InitializeComponent();
            zastita = new ZastitaBasic();
            this.idLokacije= idLokacije;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            string poruka = "Da li zelite da dodate novu zastitu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.zastita.TipZastite = txbTipZastite.Text;
                this.zastita.NazivZastite = txbNazivZastite.Text;
                this.zastita.PredmetLokacija = new LokacijaBasic { IdLokacije = this.idLokacije };
                // dodavanje u zastite ne radi ???
                DTOManager.DodajZastitu(this.zastita.PredmetLokacija, this.zastita);
                MessageBox.Show("Dodavanje zastite je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
