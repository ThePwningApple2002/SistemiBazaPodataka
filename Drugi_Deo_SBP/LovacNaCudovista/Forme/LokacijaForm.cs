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
        public LokacijaForm()
        {
            InitializeComponent();
        }

        private void LokacijaForm_Load(object sender, EventArgs e)
        {
            //popuniPodacima();
            this.Text = $"INFORMACIJE O LOKACIJAMA";

        }

        /*public void popuniPodacima()
        {


            listaLokacija.Items.Clear();
            List<CudovistePregled> podaci = DTOManager.vratiLok();


            foreach (CudovistePregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.IdCudovista.ToString(),
                    p.NazivCud,
                    p.PodTipCud,
                    p.VekPomCud.ToString(),
                });
                listaLokacija.Items.Add(item);
            }

            listaLokacija.Refresh();
        }
        */
    }

}
