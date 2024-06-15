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
    public partial class ProtivmeraForm : Form
    {
        public ProtivmeraForm()
        {
            InitializeComponent();
        }
        private void ProtivmeraForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O PROTIVMERAMA";

        }
        public void popuniPodacima()
        {


            listaProtivmera.Items.Clear();
            List<ProtivmerePregled> podaci = DTOManager.VratiSveProtivmere();


            foreach (ProtivmerePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdProtivmere.ToString(),
                    p.NazivProtivmere,
                    p.OpisProtivmere
                });
                listaProtivmera.Items.Add(item);
            }

            listaProtivmera.Refresh();
            //nastavak
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ProtivmeraAddForm formaDodaj = new ProtivmeraAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listaProtivmera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite protivmeru koje zelite da obrisete!");
                return;
            }

            int idPM = Int32.Parse(listaProtivmera.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu bajalicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiProtivmere(idPM);
                MessageBox.Show("Brisanje protivmere  je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaProtivmera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite protivmeru cije podatke zelite da izmenite!");
                return;
            }

            int idProtivmere = Int32.Parse(listaProtivmera.SelectedItems[0].SubItems[0].Text);
            ProtivmereBasic ob = DTOManager.vratiProtivmeru(idProtivmere);

            ProtivmeraUpdateForm formaUpdate = new ProtivmeraUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnUslovi_Click(object sender, EventArgs e)
        {
            if (listaProtivmera.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite protivmeru cije uslove zelite da izmenite!");
                return;
            }

            int idProtivmere = Int32.Parse(listaProtivmera.SelectedItems[0].SubItems[0].Text);
           
            UslovZaPrimenuForm forma = new UslovZaPrimenuForm(idProtivmere);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
