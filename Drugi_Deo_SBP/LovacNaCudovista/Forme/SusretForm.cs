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
    public partial class SusretForm : Form
    {
        int idLovca, idLok, idPP;
        public SusretForm(int idLovca, int idLokacija, int idPP)
        {
            InitializeComponent();
            this.idLovca = idLovca;
            this.idLok = idLokacija;
            this.idPP= idPP;
        }
        private void SusretForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"INFORMACIJE O SUSRETIMA";

        }
        public void popuniPodacima()
        {


            listaSusreta.Items.Clear();
            List<SusretPregled> podaci = DTOManager.VratiSusreteZaLovca(idLovca);


            foreach (SusretPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdSusret.ToString(),
                    p.LovacSusrtet.IdLovca.ToString(),
                    p.SusretLok.IdLokacije.ToString(),
                    p.Vreme,
                    p.Ishod,
                    p.SusretPP.IdPozPred.ToString()
                }) ;
                listaSusreta.Items.Add(item);
            }

            listaSusreta.Refresh();

        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            

            
            SusretAddForm formaDodaj = new SusretAddForm(idLovca, idLok, idPP);
            formaDodaj.ShowDialog();
            this.popuniPodacima();
            
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {

            if (listaSusreta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite susret kojeg zelite da obrisete!");
                return;
            }

            int idSusreta = Int32.Parse(listaSusreta.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani susret?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.ObrisiSusret(idSusreta);
                MessageBox.Show("Brisanje susreta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listaSusreta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite susret cije podatke zelite da izmenite!");
                return;
            }

            int idSusret = Int32.Parse(listaSusreta.SelectedItems[0].SubItems[0].Text);
            SusretBasic ob = DTOManager.VratiSusret(idSusret);
            if (ob == null)
            {
                MessageBox.Show("Greška: Susret nije pronađen.");
                return;
            }

            SusretUpdateForm formaUpdate = new SusretUpdateForm(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }

}
