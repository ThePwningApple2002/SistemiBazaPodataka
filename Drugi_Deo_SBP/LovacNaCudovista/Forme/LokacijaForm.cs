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
    public partial class LokacijaForm : Form
    {
        private int idLegende, idLokacije,idPP;
        public LokacijaForm(int idLegende, int idPP)
        {
            InitializeComponent();
            this.idLegende = idLegende;
            this.idLokacije = DTOManager.VratiIdLokacijePoIdLegende(idLegende);
            this.idPP = idPP;

        }

        private void LokacijaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O LOKACIJAMA";

        }

        public void popuniPodacima()
        {


            listaLokacija.Items.Clear();
            List<LokacijaPregled> podaci = DTOManager.vratiLokacijuLegende(new LegendaBasic { IdLegende = this.idLegende });


            foreach (LokacijaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdLokacije.ToString(),
                    p.TipLok,
                    p.NazivLok,
                    p.ZemljaLok,
                    p.Blago,
                });
                listaLokacija.Items.Add(item);
            }

            listaLokacija.Refresh();
        }

        private void btnDodajLok_Click(object sender, EventArgs e)
        {
            LokacijaAddForm formaDodaj = new LokacijaAddForm(idLegende);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiLok_Click(object sender, EventArgs e)
        {
            if (listaLokacija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lokaciju koju zelite da obrisete!");
                return;
            }

            int idLokacije = Int32.Parse(listaLokacija.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu lokaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiLokaciju(idLokacije);
                MessageBox.Show("Brisanje lokacije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeniLok_Click(object sender, EventArgs e)
        {
            if (listaLokacija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite legendu cije podatke zelite da izmenite!");
                return;
            }

            int idLokacije = Int32.Parse(listaLokacija.SelectedItems[0].SubItems[0].Text);
            LokacijaBasic ob = DTOManager.vratiJednuLokaciju(idLokacije);


            LokacijaUpdateForm formaUpdate = new LokacijaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnZastita_Click(object sender, EventArgs e)
        {
            if (listaLokacija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste ciju zastitu zelite da vidite!");
                return;
            }
            int idLokacije = Int32.Parse(listaLokacija.SelectedItems[0].SubItems[0].Text);

            ZastitaForm forma = new ZastitaForm(idLokacije);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnLovac_Click(object sender, EventArgs e)
        {
            LovacForm forma = new LovacForm(idPP, idLokacije);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }

}
