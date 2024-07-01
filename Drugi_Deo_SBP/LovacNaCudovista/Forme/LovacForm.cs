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
    public partial class LovacForm : Form
    {
        private int idPP, idLokacije;
        public LovacForm(int idPP, int idLok)
        {
            InitializeComponent();
            this.idPP = idPP;
            this.idLokacije = idLok;
        }
        private void LovacForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O LOVCIMA";

        }
        public void popuniPodacima()
        {


            listaLovca.Items.Clear();
            List<LovacPregled> podaci = DTOManager.vratisveLovce();


            foreach (LovacPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdLovca.ToString(),
                    p.ImeLovca
                });
                listaLovca.Items.Add(item);
            }

            listaLovca.Refresh();

        }

        private void btnDodajLovca_Click(object sender, EventArgs e)
        {

            BajalicaAddForm formaDodaj = new BajalicaAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiLovca_Click(object sender, EventArgs e)
        {
            if (listaLovca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lovca kojeg zelite da obrisete!");
                return;
            }

            int idBajalice = Int32.Parse(listaLovca.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog lovca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBajalicu(idBajalice);
                MessageBox.Show("Brisanje lovca je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeniLovca_Click(object sender, EventArgs e)
        {
            if (listaLovca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lovca cije podatke zelite da izmenite!");
                return;
            }

            int idLovca = Int32.Parse(listaLovca.SelectedItems[0].SubItems[0].Text);
            LovacBasic ob = DTOManager.vratiLovca(idLovca);

            LovacUpdateForm formaUpdate = new LovacUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnSusret_Click(object sender, EventArgs e)
        {
            if (listaLovca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lovca cije podatke zelite da vidite!");
                return;
            }

            int idLovca = Int32.Parse(listaLovca.SelectedItems[0].SubItems[0].Text);
            SusretForm forma = new SusretForm(idLovca, idLokacije, idPP);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnPredmet_Click(object sender, EventArgs e)
        {
            PredmetForm forma = new PredmetForm();
            forma.ShowDialog();
        }

        private void btnProtivmere_Click(object sender, EventArgs e)
        {
            ProtivmeraForm forma = new ProtivmeraForm();
            forma.ShowDialog();
        }
    }
}
