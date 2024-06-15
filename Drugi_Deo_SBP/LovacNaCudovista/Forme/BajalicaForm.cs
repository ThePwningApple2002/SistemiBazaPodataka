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
    public partial class BajalicaForm : Form
    {
        public BajalicaForm()
        {
            InitializeComponent();
        }
        private void BajalicaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O CUDOVISTIMA";

        }
        public void popuniPodacima()
        {


            listaBajalica.Items.Clear();
            List<BajalicaPregled> podaci = DTOManager.vratisveBajalice();


            foreach (BajalicaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdBajalica.ToString(),
                    p.NazivBajalica,
                    p.Zastita,
                    p.Prednost,
                });
                listaBajalica.Items.Add(item);
            }

            listaBajalica.Refresh();
            //nastavak
        }

        private void btnObrisiBaj_Click(object sender, EventArgs e)
        {
            if (listaBajalica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite bajalicu koje zelite da obrisete!");
                return;
            }

            int idBajalice = Int32.Parse(listaBajalica.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu bajalicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiBajalicu(idBajalice);
                MessageBox.Show("Brisanje bajalice  je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnDodajBaj_Click(object sender, EventArgs e)
        {
            BajalicaAddForm formaDodaj = new BajalicaAddForm();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void btnIzmeniBaj_Click(object sender, EventArgs e)
        {
            if (listaBajalica.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite bajalicu cije podatke zelite da izmenite!");
                return;
            }

            int idBajalice = Int32.Parse(listaBajalica.SelectedItems[0].SubItems[0].Text);
            BajalicaBasic ob = DTOManager.vratiBajalicu(idBajalice);

            BajalicaUpdateForm formaUpdate = new BajalicaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }

}
