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
    public partial class NeMagCudForm : Form
    {
        public NeMagCudForm()
        {
            InitializeComponent();
        }
        private void NeMagCudForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O CUDOVISTIMA";

        }
        public void popuniPodacima()
        {


            listaCudovista.Items.Clear();
            List<NeMagCudovistePregled> podaci = DTOManager.vratisvaNeMagCudovista();


            foreach (NeMagCudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdCudovista.ToString(),
                    p.NazivCud,
                    p.PodTipCud,
                    p.VekPomCud.ToString(),
                    p.Visina.ToString(),
                    p.Duzina.ToString(),
                    p.Kandze,
                    p.BrojGlava.ToString(),
                    p.ZiviUVodi,
                    p.Leti,
                    p.Otrovno,
                    p.Tezina.ToString()
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
                DTOManager.obrisiNeMagCudoviste(idCudovista);
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
            NeMagCudovisteBasic ob = DTOManager.vratiNeMagCudoviste(idCudovista);

            NeMagCudUpdateForm formaUpdate = new NeMagCudUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodajCud_Click(object sender, EventArgs e)
        {
            NeMagCudAddForm formaDodaj = new NeMagCudAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();

        }

        private void btnBajalica_Click(object sender, EventArgs e)
        {
            BajalicaForm forma = new BajalicaForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnSpecSpos_Click(object sender, EventArgs e)
        {
            SpecSposForm forma = new SpecSposForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
