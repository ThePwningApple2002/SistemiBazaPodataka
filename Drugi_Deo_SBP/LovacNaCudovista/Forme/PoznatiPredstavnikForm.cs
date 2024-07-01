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
    public partial class PoznatiPredstavnikForm : Form
    {
        private int cudovisteId;
        public PoznatiPredstavnikForm(int idcud)
        {
            InitializeComponent();
            this.cudovisteId = idcud;
        }

        private void PoznatiPredstavnikForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O POZNATIM PREDSTAVNICIMA";

        }

        public void popuniPodacima()
        {
            listaPozPredstavnik.Items.Clear();
            List<PoznatiPredstavnikBasic> poznatiPredstavnici = DTOManager.vratiPoznatePredstavnikeZaCudoviste(cudovisteId);

            foreach (PoznatiPredstavnikBasic p in poznatiPredstavnici)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdPozPred.ToString(),
                    p.JedinstvenoIme,
                    p.Starost.ToString(),
                    p.PoznatiPredCud.IdCudovista.ToString()

                });
                listaPozPredstavnik.Items.Add(item);
            }

            listaPozPredstavnik.Refresh();
        }

        private void btnIzmeniPozPred_Click(object sender, EventArgs e)
        {
            if (listaPozPredstavnik.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste cije podatke zelite da izmenite!");
                return;
            }

            int idCudovista = Int32.Parse(listaPozPredstavnik.SelectedItems[0].SubItems[0].Text);
            PoznatiPredstavnikBasic ob = DTOManager.vratiPozPred(idCudovista);

            PozPredUpdateForm formaUpdate = new PozPredUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodajPozPred_Click(object sender, EventArgs e)
        {
            PozPredAddForm formaDodaj = new PozPredAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiPozPred_Click(object sender, EventArgs e)
        {
            if (listaPozPredstavnik.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste koje zelite da obrisete!");
                return;
            }

            int idPredstavnika = Int32.Parse(listaPozPredstavnik.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano cuvodiste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPozPred(idPredstavnika);
                MessageBox.Show("Brisanje cudovista je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnLegenda_Click(object sender, EventArgs e)
        {
            if (listaPozPredstavnik.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste ciju legendu zelite da vidite!");
                return;
            }
            int idPozPred = Int32.Parse(listaPozPredstavnik.SelectedItems[0].SubItems[0].Text);

            LegendaForm forma = new LegendaForm(idPozPred);
            forma.ShowDialog();
        }

       
    }
}
