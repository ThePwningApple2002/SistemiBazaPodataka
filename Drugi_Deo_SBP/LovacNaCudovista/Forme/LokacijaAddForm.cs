﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LovacNaCudovista.Forme
{
    public partial class LokacijaAddForm : Form
    {
        LokacijaBasic lokacija;
        private int idLegende;
        public LokacijaAddForm(int idLegende)
        {
            InitializeComponent();
            lokacija = new LokacijaBasic();
            this.idLegende = idLegende;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu lokaciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            if (result == DialogResult.OK)
            {
                this.lokacija.TipLok = txbTipLok.Text;
                this.lokacija.NazivLok = txbNazivLok.Text;
                this.lokacija.ZemljaLok = txbZemljaLok.Text;
                this.lokacija.Blago = txbBlago.Text;
                this.lokacija.LegendaLokacije = new LegendaBasic { IdLegende = this.idLegende };

                DTOManager.dodajLokaciju(this.lokacija.LegendaLokacije, this.lokacija);
                MessageBox.Show("Dodavanje lokacije je uspesno izvrseno!");
                this.Close();
            }
            
        }
    }
}
