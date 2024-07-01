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
    public partial class LegendaForm : Form
    {
        private int idPozPred;
        public LegendaForm(int idPP)
        {
            InitializeComponent();
            this.idPozPred = idPP;


        }
        public void LegendaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O LEGENDAMA POZNATIH PREDSTAVNIKA";

        }
        public void popuniPodacima()
        {
            listaLegenda.Items.Clear();
            List<LegendaBasic> legende = DTOManager.vratiLeg(idPozPred);

            foreach (LegendaBasic p in legende)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                p.IdLegende.ToString(),
                p.PrvoPominjanje,
                p.TekstLegende,
                p.ZemljaPorekla
                });
                listaLegenda.Items.Add(item);
            }

            listaLegenda.Refresh();
        }

        private void btnDodajLeg_Click(object sender, EventArgs e)
        {


            LegendaAddForm formaDodaj = new LegendaAddForm(idPozPred);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniLeg_Click(object sender, EventArgs e)
        {
            if (listaLegenda.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite legendu cije podatke zelite da izmenite!");
                return;
            }

            int idLegende = Int32.Parse(listaLegenda.SelectedItems[0].SubItems[0].Text);
            LegendaBasic ob = DTOManager.vratiLegende(idLegende);

            LegendaUpdateForm formaUpdate = new LegendaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnObrisiLeg_Click(object sender, EventArgs e)
        {
            if (listaLegenda.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite legendu koju zelite da obrisete!");
                return;
            }

            int idLegenda = Int32.Parse(listaLegenda.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu legendu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiLegendu(idLegenda);
                MessageBox.Show("Brisanje legende je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnLokacijaLeg_Click(object sender, EventArgs e)
        {
            if(listaLegenda.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste ciju lokaciju zelite da vidite!");
                return;
            }
            int idLegende = Int32.Parse(listaLegenda.SelectedItems[0].SubItems[0].Text);

            LokacijaForm forma = new LokacijaForm(idLegende, idPozPred);
            forma.ShowDialog();
        }

        
    }

}
