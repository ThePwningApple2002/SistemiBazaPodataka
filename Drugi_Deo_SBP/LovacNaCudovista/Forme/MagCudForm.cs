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
    public partial class MagCudForm : Form
    {
        public MagCudForm()
        {
            InitializeComponent();
        }
        private void MagCudForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O CUDOVISTIMA";

        }
        public void popuniPodacima()
        {


            listaCudovista.Items.Clear();
            List<MagCudovistePregled> podaci = DTOManager.vratisvaMagCudovista();


            foreach (MagCudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdCudovista.ToString(),
                    p.NazivCud,
                    p.PodTipCud,
                    p.VekPomCud.ToString(),
                    p.Postojanje
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
                DTOManager.obrisiMagCudoviste(idCudovista);
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
            MagCudovisteBasic ob = DTOManager.vratiMagCudoviste(idCudovista);

            MagCudovisteUpdateForm formaUpdate = new MagCudovisteUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void btnDodajCud_Click(object sender, EventArgs e)
        {
            MagCudovisteAddForm formaDodaj = new MagCudovisteAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();

        }

        private void btnMagSpos_Click(object sender, EventArgs e)
        {
            MagSposForm forma = new MagSposForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
