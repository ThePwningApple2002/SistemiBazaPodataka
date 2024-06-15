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
    public partial class SusretAddForm : Form
    {
        SusretBasic susret;
        public SusretAddForm()
        {
            InitializeComponent();
            susret = new SusretBasic();
            //nastavak
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novi susret?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {

                this.susret.Vreme = txbVreme.Text;
                this.susret.Ishod = txbIshod.Text;


                DTOManager.DodajSusret(susret);
                MessageBox.Show("Dodavanje susreta je uspesno izvrseno!");
                this.Close();
            }
            else
            {

            }
        }
    }
}
