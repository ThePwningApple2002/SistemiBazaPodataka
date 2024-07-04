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
    public partial class SpecSposForm : Form
    {
        public SpecSposForm()
        {
            InitializeComponent();
        }

        private void SpecSposForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O SPOSOBNOSTIMA";

        }
        public void popuniPodacima()
        {


            listaSpecSpos.Items.Clear();
            List<SpecSposobnostPregled> podaci = DTOManager.vratiSpecSposobnosti();


            foreach (SpecSposobnostPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdSpecSposobnost.ToString(),
                    p.NazivSpecSpos,
                    
                });
                listaSpecSpos.Items.Add(item);
            }

            listaSpecSpos.Refresh();
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            SpecSposAddForm formaDodaj = new SpecSposAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            if (listaSpecSpos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sposobnost koje zelite da obrisete!");
                return;
            }

            int idSpecSpos = Int32.Parse(listaSpecSpos.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu sposobnost?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSpecSpos(idSpecSpos);
                MessageBox.Show("Brisanje bajalice  je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaSpecSpos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sposobnosti cije podatke zelite da izmenite!");
                return;
            }

            int idSpec = Int32.Parse(listaSpecSpos.SelectedItems[0].SubItems[0].Text);
            SpecSposobnostBasic ob = DTOManager.vratiSpecSpos(idSpec);

            SpecSposUpdateForm formaUpdate = new SpecSposUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
