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
    public partial class PredmetForm : Form
    {
        public PredmetForm()
        {
            InitializeComponent();
        }
        private void PredmetForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O PREDMETIMA";

        }
        public void popuniPodacima()
        {


            listaPredmeta.Items.Clear();
            List<PredmetPregled> podaci = DTOManager.VratiSvePredmete();


            foreach (PredmetPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdPredmeta.ToString(),
                    p.TipPredmeta,
                    p.NazivPredmeta,
                    p.MaterijalPredmeta
                });
                listaPredmeta.Items.Add(item);
            }

            listaPredmeta.Refresh();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PredmetAddForm formaDodaj = new PredmetAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet koje zelite da obrisete!");
                return;
            }

            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiPredmet(idPredmeta);
                MessageBox.Show("Brisanje predmeta  je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            if (listaPredmeta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite predmet cije podatke zelite da izmenite!");
                return;
            }

            int idPredmeta = Int32.Parse(listaPredmeta.SelectedItems[0].SubItems[0].Text);
            PredmetBasic ob = DTOManager.VratiPredmetPoId(idPredmeta);

            PredmetUpdateForm formaDodaj = new PredmetUpdateForm(ob);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnProtivmere_Click(object sender, EventArgs e)
        {
            
            ProtivmeraForm forma = new ProtivmeraForm();
            forma.ShowDialog();
        }
    }
}
