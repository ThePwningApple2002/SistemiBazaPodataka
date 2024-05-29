using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LovacNaCudovista.Entiteti;
using LovacNaCudovista.Mapiranja;
using LovacNaCudovista.Forme;



namespace LovacNaCudovista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLovac_Click(object sender, EventArgs e)
        {
            LovacForm forma = new LovacForm();
            forma.ShowDialog();

        }

        private void btnCud_Click(object sender, EventArgs e)
        {
            CudovistaForm forma = new CudovistaForm();
            forma.ShowDialog();
        }

        private void btnLegenda_Click(object sender, EventArgs e)
        {

            
        }
    }
}
