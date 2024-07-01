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
    public partial class UslovZaPrimenuForm : Form
    {
        private int idprotivmere;
        public UslovZaPrimenuForm(int idpm)
        {
            InitializeComponent();
            idprotivmere = idpm;
        }
        private void UslovZaPrimenuForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O USLOVIMA";

        }

        public void popuniPodacima()
        {
            listaUslova.Items.Clear();
            List<UsloviZaPrimenuPregled> sviUslovi = DTOManager.VratiUsloveZaProtivmeru(idprotivmere);

            foreach (UsloviZaPrimenuPregled p in sviUslovi)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdUslova.ToString(),
                    p.Uslov,
                    
                }) ;
                listaUslova.Items.Add(item);
            }

            listaUslova.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UsloviAddForm formaDodaj = new UsloviAddForm(idprotivmere);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaUslova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite uslov koju zelite da obrisete!");
                return;
            }

            int idUslov = Int32.Parse(listaUslova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani uslov?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiUslov(idUslov);
                MessageBox.Show("Brisanje uslova je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (listaUslova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite legendu cije podatke zelite da izmenite!");
                return;
            }

            int idUslova = Int32.Parse(listaUslova.SelectedItems[0].SubItems[0].Text);
            UsloviZaPrimenuBasic ob = DTOManager.vratiUslov(idUslova);

            UsloviUpdateForm formaUpdate = new UsloviUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
