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
    public partial class CudovistaForm : Form
    {

        public CudovistaForm()
        {
            InitializeComponent();
        }

        private void CudovistaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O CUDOVISTIMA";

        }
        public void popuniPodacima()
        {


            listaCudovista.Items.Clear();
            List<CudovistePregled> podaci = DTOManager.vratisvaCudovista();


            foreach (CudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdCudovista.ToString(),
                    p.NazivCud,
                    p.PodTipCud,
                    p.VekPomCud.ToString(),
                });
                listaCudovista.Items.Add(item);
            }

            listaCudovista.Refresh();
        }

        private void btnObrisiCud_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste koje zelite da obrisete!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano cuvodiste?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiCudoviste(idCudovista);
                MessageBox.Show("Brisanje cudovista je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeniCud_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite cudoviste cije podatke zelite da izmenite!");
                return;
            }

            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);
            CudovisteBasic ob = DTOManager.vratiCudoviste(idCudovista);

            CudovisteUpdateForm formaUpdate = new CudovisteUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodajCud_Click(object sender, EventArgs e)
        {
            CudovisteAddForm formaDodaj = new CudovisteAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();

        }

        private void btnMagCud_Click(object sender, EventArgs e)
        {
            MagCudForm forma = new MagCudForm();
            forma.ShowDialog();
        }

        private void btnNeMagCud_Click(object sender, EventArgs e)
        {
            NeMagCudForm forma = new NeMagCudForm();
            forma.ShowDialog();
        }

        private void btnPozPred_Click(object sender, EventArgs e)
        {
            if (listaCudovista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas izaberite čudovište.");
                return;
            }

            // Pretpostavljamo da ID čudovišta se nalazi u prvoj koloni ListView-a
            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);


            PoznatiPredstavnikForm forma = new PoznatiPredstavnikForm(idCudovista);
            forma.ShowDialog();


        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            LokacijaForm forma = new LokacijaForm();
            forma.ShowDialog();
        }
    }


}
