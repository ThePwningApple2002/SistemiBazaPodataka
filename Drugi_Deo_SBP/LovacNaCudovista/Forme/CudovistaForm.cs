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


    }


}
