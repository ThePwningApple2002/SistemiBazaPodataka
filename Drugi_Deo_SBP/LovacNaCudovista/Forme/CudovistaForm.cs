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

            
            int idCudovista = Int32.Parse(listaCudovista.SelectedItems[0].SubItems[0].Text);


            PoznatiPredstavnikForm forma = new PoznatiPredstavnikForm(idCudovista);
            forma.ShowDialog();


        }

       
    }


}
