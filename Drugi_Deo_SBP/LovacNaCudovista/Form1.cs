using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LovacNaCudovista.Entiteti;
using LovacNaCudovista.Mapiranja;



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

        private void button1_Click(object sender, EventArgs e)
        {


            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    Cudoviste p = new()
                    {
                        NazivCud = "Drakula",
                        PodTipCud = "Vampir",
                        VekPomCud = 21

                    };

                    PoznatiPredstavnik o = new()
                    {
                        JedinstvenoIme = "Dragisa",
                        Starost = 1500,

                        PoznatiPredCud = p
                    };

                    Legenda l = new()
                    {
                        PrvoPominjanje = "1000 AD",
                        TekstLegende = "AAAAAAAAAAAAAAAAAAAA",
                        ZemljaPorekla = "Austrougarska",
                        LegZaPP = o

                    };

                    Lokacija lok = new()
                    {
                        TipLok = "Vukojebina",
                        NazivLok = "Ne znam gde sam",
                        ZemljaLok = "Opet austrougarska",
                        Blago = "Luk",
                        LegendaLokacije = l
                    };



                    p.PoznatiPredstavnici.Add(o);
                    o.Legende.Add(l);
                    l.Lokacije.Add(lok);



                    session.Save(p);
                    session.Flush();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste r1 = s.Load<NeMagCudoviste>(5);

                foreach (Entiteti.SpecSposobnost p1 in r1.SpecSposobnosti)
                {
                    MessageBox.Show(p1.NazivSpecSpos);
                }


                Entiteti.SpecSposobnost p2 = s.Load<Entiteti.SpecSposobnost>(5);

                foreach (NeMagCudoviste r2 in p2.NeMagCudovista)
                {
                    MessageBox.Show(r2.NazivCud);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session != null)
                {
                    MagCudoviste p =  session.Load<MagCudoviste>(3);
                    MessageBox.Show($"Prodavnica sa ID: 61 \"{p.NazivCud}\" je pronađena.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                session?.Close();
            }
        }
    }
}
