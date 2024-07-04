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
    public partial class MagSposForm : Form
    {
        public MagSposForm()
        {
            InitializeComponent();
        }

        private void MagSposForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O LOKACIJAMA";

        }

        public void popuniPodacima()
        {


            listaMagSpos.Items.Clear();
            List<MagSposobnostPregled> podaci = DTOManager.vratiMagSposobnosti();


            foreach (MagSposobnostPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdMagSpos.ToString(),
                    p.NazivMagSpos,
                    p.OpisMagSpos,
                    p.Ofanzivna,
                    p.Defanzivna
                });
                listaMagSpos.Items.Add(item);
            }

            listaMagSpos.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MagSposAddForm formaDodaj = new MagSposAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaMagSpos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sposobnost koju zelite da obrisete!");
                return;
            }

            int idMagSpos = Int32.Parse(listaMagSpos.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu sposobnost?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiMagSpos(idMagSpos);
                MessageBox.Show("Brisanje sposobnosti je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaMagSpos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sposobnost cije podatke zelite da izmenite!");
                return;
            }

            int idMagicneSpos = Int32.Parse(listaMagSpos.SelectedItems[0].SubItems[0].Text);
            MagSposobnostBasic ob = DTOManager.vratiMagSpos(idMagicneSpos);


            MagSposUpdateForm formaUpdate = new MagSposUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
