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
    public partial class ZastitaForm : Form
    {
        public ZastitaForm()
        {
            InitializeComponent();
        }

        private void ZastitaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O ZASTITI";

        }

        public void popuniPodacima()
        {


            listaZastita.Items.Clear();
            List<ZastitaPregled> podaci = DTOManager.VratiSveZastite();


            foreach (ZastitaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdZastite.ToString(),
                    p.TipZastite,
                    p.NazivZastite,

                });
                listaZastita.Items.Add(item);
            }

            listaZastita.Refresh();
        }

        private void btnObrisiZastitu_Click(object sender, EventArgs e)
        {
            if (listaZastita.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zastitu koju zelite da obrisete!");
                return;
            }

            int idZastite = Int32.Parse(listaZastita.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu zastitu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiCudoviste(idZastite);
                MessageBox.Show("Brisanje zastite je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnIzmeniZastitu_Click(object sender, EventArgs e)
        {
            if (listaZastita.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zastitu cije podatke zelite da izmenite!");
                return;
            }

            int idZastite = Int32.Parse(listaZastita.SelectedItems[0].SubItems[0].Text);
            ZastitaBasic ob = DTOManager.VratiZastita(idZastite);

            ZastitaUpdateForm formaUpdate = new ZastitaUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
