using NHibernate.Proxy;
using NHibernate.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista
{
    public class DTOManager
    {
        #region Bajalica

        public static List<BajalicaPregled> vratisveBajalice()
        {
            List<BajalicaPregled> bajalice = new List<BajalicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bajalica> sveBajalice = from o in s.Query<Bajalica>() select o;

                foreach (Bajalica p in sveBajalice)
                {
                    bajalice.Add(new BajalicaPregled(p.IdBajalice, p.NazivBajalice, p.Zastita, p.Prednost));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return bajalice;
        }
        public static void dodajBajalicu(BajalicaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalica o = new Bajalica();

                o.IdBajalice = b.IdBajalica;
                o.NazivBajalice = b.NazivBajalica;
                o.Zastita = b.Zastita;
                o.Prednost = b.Prednost;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void azurirajBajalicu(BajalicaBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalica o = s.Load<Bajalica>(b.IdBajalica);

                o.IdBajalice = b.IdBajalica;
                o.NazivBajalice = b.NazivBajalica;
                o.Zastita = b.Zastita;
                o.Prednost = b.Prednost;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static BajalicaBasic vratiBajalicu(int id)
        {
            BajalicaBasic pb = new BajalicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalica o = s.Load<Bajalica>(id);
                pb = new BajalicaBasic(o.IdBajalice, o.NazivBajalice, o.Zastita, o.Prednost);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiBajalicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalica o = s.Load<Bajalica>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region Cudoviste

        public static List<CudovistePregled> vratisvaCudovista()
        {

            List<CudovistePregled> cudovista = new List<CudovistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudoviste> svaCudovista = from o in s.Query<Cudoviste>() select o;

                foreach (Cudoviste p in svaCudovista)
                {
                    cudovista.Add(new CudovistePregled(p.IdCudovista, p.NazivCud, p.PodTipCud, p.VekPomCud));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return cudovista;


        }

        public static void dodajMagCudoviste(MagCudovisteBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagCudoviste o = new MagCudoviste();

                o.IdCudovista = b.IdCudovista;
                o.NazivCud = b.NazivCud;
                o.PodTipCud = b.PodTipCud;
                o.VekPomCud = b.VekPomCud;
                o.Postojanje = b.Postojanje;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void dodajNeMagCudoviste(NeMagCudovisteBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste o = new NeMagCudoviste();

                o.IdCudovista = b.IdCudovista;
                o.NazivCud = b.NazivCud;
                o.PodTipCud = b.PodTipCud;
                o.VekPomCud = b.VekPomCud;
                o.Visina = b.Visina;
                o.Duzina = b.Duzina;
                o.Kandze = b.Kandze;
                o.BrojGlava = b.BrojGlava;
                o.ZiviUVodi = b.ZiviUVodi;
                o.Leti = b.Leti;
                o.Otrovno = b.Otrovno;
                o.Tezina = b.Tezina;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void azurirajMagCudoviste(MagCudovisteBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagCudoviste o = s.Load<MagCudoviste>(b.IdCudovista);

                o.IdCudovista = b.IdCudovista;
                o.NazivCud = b.NazivCud;
                o.PodTipCud = b.PodTipCud;
                o.VekPomCud = b.VekPomCud;
                o.Postojanje = b.Postojanje;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }



        }

        public static void azurirajNeMagCudoviste(NeMagCudovisteBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste o = s.Load<NeMagCudoviste>(b.IdCudovista);

                o.IdCudovista = b.IdCudovista;
                o.NazivCud = b.NazivCud;
                o.PodTipCud = b.PodTipCud;
                o.VekPomCud = b.VekPomCud;
                o.Visina = b.Visina;
                o.Duzina = b.Duzina;
                o.Kandze = b.Kandze;
                o.BrojGlava = b.BrojGlava;
                o.ZiviUVodi = b.ZiviUVodi;
                o.Leti = b.Leti;
                o.Otrovno = b.Otrovno;
                o.Tezina = b.Tezina;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        public static CudovisteBasic vratiCudoviste(int id)
        {
            CudovisteBasic pb = new CudovisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudoviste o = s.Load<Cudoviste>(id);
                pb = new CudovisteBasic(o.IdCudovista, o.NazivCud, o.PodTipCud, o.VekPomCud);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static MagCudovisteBasic vratiMagCudoviste(int id)
        {
            MagCudovisteBasic pb = new MagCudovisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MagCudoviste o = s.Load<MagCudoviste>(id);
                pb = new MagCudovisteBasic(o.IdCudovista, o.NazivCud, o.PodTipCud, o.VekPomCud, o.Postojanje);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static NeMagCudovisteBasic vratiNeMagCudoviste(int id)
        {
            NeMagCudovisteBasic pb = new NeMagCudovisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste o = s.Load<NeMagCudoviste>(id);
                pb = new NeMagCudovisteBasic(o.IdCudovista, o.NazivCud, o.PodTipCud, o.VekPomCud, o.Visina, o.Duzina, o.Kandze, o.BrojGlava, o.ZiviUVodi, o.Leti, o.Otrovno, o.Tezina);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static void obrisiCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudoviste o = s.Load<Cudoviste>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void obrisiMagCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagCudoviste o = s.Load<MagCudoviste>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void obrisiNeMagCudoviste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste o = s.Load<NeMagCudoviste>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Legenda

        public static List<LegendaPregled> vratiLegendePozPred(PoznatiPredstavnikBasic Pozpred)
        {
            List<LegendaPregled> legende = new List<LegendaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Legenda> sveLegende = from o in s.Query<Legenda>()
                                                  where o.LegZaPP.IdPozPred == Pozpred.IdPozPred
                                                  select o;

                foreach (Legenda r in sveLegende)
                {
                    legende.Add(new LegendaPregled(r.IdLegende, r.PrvoPominjanje, r.TekstLegende, r.ZemljaPorekla, DTOManager.vratiPozPred(r.LegZaPP.IdPozPred)));

                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return legende;
        }

        public static LegendaBasic vratiLeg(int id)
        {
            LegendaBasic pb = new LegendaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda o = s.Load<Legenda>(id);
                pb = new LegendaBasic(o.IdLegende, o.PrvoPominjanje, o.TekstLegende, o.ZemljaPorekla, DTOManager.vratiPozPred(o.LegZaPP.IdPozPred));

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void dodajLegendu(PoznatiPredstavnikBasic p, LegendaBasic l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda f = new Legenda();
                f.IdLegende = l.IdLegende;
                f.PrvoPominjanje = l.PrvoPominjanje;
                f.TekstLegende = l.TekstLegende;


                PoznatiPredstavnik pm = s.Load<PoznatiPredstavnik>(p.IdPozPred);
                f.LegZaPP = pm;


                s.Save(f);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void izmeniLegendu(LegendaBasic legend)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda l = s.Load<Legenda>(legend.IdLegende);

                l.PrvoPominjanje = legend.PrvoPominjanje;
                l.TekstLegende = legend.TekstLegende;
                l.ZemljaPorekla = legend.ZemljaPorekla;

                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void obrisiLegendu(string idleg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda legend = s.Load<Legenda>(idleg);

                s.Delete(legend);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }



        #endregion

        #region Lokacija 

        public static List<LokacijaPregled> vratiLokacijuLegende(LegendaBasic legend)
        {
            List<LokacijaPregled> lokacije = new List<LokacijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lokacija> sveLokacije = from o in s.Query<Lokacija>()
                                                    where o.LegendaLokacije.IdLegende == legend.IdLegende
                                                    select o;

                foreach (Lokacija r in sveLokacije)
                {
                    lokacije.Add(new LokacijaPregled(r.IdLokacije, r.TipLok, r.NazivLok, r.ZemljaLok, r.Blago, DTOManager.vratiLeg(r.LegendaLokacije.IdLegende)));

                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lokacije;
        }

        public static LokacijaBasic vratiLok(int id)
        {

            LokacijaBasic pb = new LokacijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija o = s.Load<Lokacija>(id);
                pb = new LokacijaBasic(o.IdLokacije, o.TipLok, o.NazivLok, o.ZemljaLok, o.Blago, DTOManager.vratiLeg(o.LegendaLokacije.IdLegende));

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void dodajLegendu(LegendaBasic p, LokacijaBasic l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija f = new Lokacija();
                f.IdLokacije = l.IdLokacije;
                f.TipLok = l.TipLok;
                f.ZemljaLok = l.ZemljaLok;
                f.Blago = l.Blago;


                Legenda pm = s.Load<Legenda>(p.IdLegende);
                f.LegendaLokacije = pm;


                s.Save(f);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void izmeniLokaciju(LokacijaBasic lok)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija l = s.Load<Lokacija>(lok.IdLokacije);

                l.IdLokacije = lok.IdLokacije;
                l.TipLok = lok.TipLok;
                l.ZemljaLok = lok.ZemljaLok;
                l.Blago = lok.Blago;

                s.SaveOrUpdate(l);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void obrisiLokaciju(string idLok)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija lok = s.Load<Lokacija>(idLok);

                s.Delete(lok);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }



        #endregion

        #region Lovac

        public static List<LovacPregled> vratisveLovce()
        {

            List<LovacPregled> lovci = new List<LovacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lovac> svilovci = from o in s.Query<Lovac>() select o;

                foreach (Lovac p in svilovci)
                {
                    lovci.Add(new LovacPregled(p.IdLovca, p.ImeLovca));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return lovci;


        }

        public static void dodajLovca(LovacBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = new Lovac();

                o.IdLovca = b.IdLovca;
                o.ImeLovca = b.ImeLovca;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void azurirajLovca(LovacBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = s.Load<Lovac>(b.IdLovca);

                o.IdLovca = b.IdLovca;
                o.ImeLovca = b.ImeLovca;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static LovacBasic vratiLovca(int id)
        {
            LovacBasic pb = new LovacBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = s.Load<Lovac>(id);
                pb = new LovacBasic(o.IdLovca, o.ImeLovca);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiLovca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = s.Load<Lovac>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion

        #region MagSposobnost

        public static List<MagSposobnostPregled> vratiMagSposobnosti()
        {

            List<MagSposobnostPregled> sposobnosti = new List<MagSposobnostPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<MagSposobnost> svespos = from o in s.Query<MagSposobnost>() select o;

                foreach (MagSposobnost p in svespos)
                {
                    sposobnosti.Add(new MagSposobnostPregled(p.IdMagSpos, p.NazivMagSpos, p.OpisMagSpos, p.Ofanzivna, p.Defanzivna));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return sposobnosti;


        }

        public static void sacuvajMagSpos(MagSposobnostBasic magspos)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagSposobnost o = new MagSposobnost();

                o.NazivMagSpos = magspos.NazivMagSpos;
                o.OpisMagSpos = magspos.OpisMagSpos;
                o.Ofanzivna = magspos.Ofanzivna;
                o.Defanzivna = magspos.Defanzivna;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void azurirajMagSpos(MagSposobnostBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagSposobnost o = s.Load<MagSposobnost>(b.IdMagSpos);

                o.NazivMagSpos = b.NazivMagSpos;
                o.OpisMagSpos = b.OpisMagSpos;
                o.Ofanzivna = b.Ofanzivna;
                o.Defanzivna = b.Defanzivna;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static MagSposobnostBasic vratiMagSpos(int id)
        {
            MagSposobnostBasic pb = new MagSposobnostBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MagSposobnost o = s.Load<MagSposobnost>(id);
                pb = new MagSposobnostBasic(o.IdMagSpos, o.NazivMagSpos, o.OpisMagSpos, o.Ofanzivna, o.Defanzivna);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiMagSpos(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagSposobnost magspos = s.Load<MagSposobnost>(id);

                s.Delete(magspos);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }

        #endregion

        #region SpecSpos


        public static List<SpecSposobnostPregled> vratiSpecSposobnosti()
        {

            List<SpecSposobnostPregled> sposobnosti = new List<SpecSposobnostPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SpecSposobnost> svespos = from o in s.Query<SpecSposobnost>() select o;

                foreach (SpecSposobnost p in svespos)
                {
                    sposobnosti.Add(new SpecSposobnostPregled(p.IdSpecSposobnost, p.NazivSpecSpos));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return sposobnosti;


        }

        public static void sacuvajSpecSpos(SpecSposobnostBasic specspos)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecSposobnost o = new SpecSposobnost();

                o.NazivSpecSpos = specspos.NazivSpecSpos;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void azurirajSpecSpos(SpecSposobnostBasic b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecSposobnost o = s.Load<SpecSposobnost>(b.IdSpecSposobnost);

                o.NazivSpecSpos = b.NazivSpecSpos;




                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }


        }
        public static SpecSposobnostBasic vratiSpecSpos(int id)
        {
            SpecSposobnostBasic pb = new SpecSposobnostBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                SpecSposobnost o = s.Load<SpecSposobnost>(id);
                pb = new SpecSposobnostBasic(o.IdSpecSposobnost, o.NazivSpecSpos);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static void obrisiSpecSpos(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecSposobnost magspos = s.Load<SpecSposobnost>(id);

                s.Delete(magspos);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }



        #endregion

        #region PoznatiPredstavnik
        public static PoznatiPredstavnikBasic vratiPozPred(int id)
        {
            PoznatiPredstavnikBasic pb = new PoznatiPredstavnikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik o = s.Load<PoznatiPredstavnik>(id);
                pb = new PoznatiPredstavnikBasic(o.IdPozPred, o.JedinstvenoIme, o.Starost, DTOManager.vratiCudoviste(o.PoznatiPredCud.IdCudovista));

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<PoznatiPredstavnikPregled> vratiPozPredstavnike()
        {

            List<PoznatiPredstavnikPregled> sposobnosti = new List<PoznatiPredstavnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PoznatiPredstavnik> svipozpred = from o in s.Query<PoznatiPredstavnik>() select o;

                foreach (PoznatiPredstavnik p in svipozpred)
                {
                    sposobnosti.Add(new PoznatiPredstavnikPregled(p.IdPozPred, p.JedinstvenoIme, p.Starost, DTOManager.vratiCudoviste(p.PoznatiPredCud.IdCudovista)));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return sposobnosti;


        }

        public static void dodajPozPred(PoznatiPredstavnikBasic pozpred, CudovisteBasic cud)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik o = new PoznatiPredstavnik();

                o.JedinstvenoIme = pozpred.JedinstvenoIme;
                o.Starost = pozpred.Starost;

                Cudoviste c = s.Load<Cudoviste>(pozpred.IdPozPred);


                o.PoznatiPredCud = c;



                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void izmeniPozPred(PoznatiPredstavnikBasic pozpred)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik p = s.Load<PoznatiPredstavnik>(pozpred.IdPozPred);

                p.JedinstvenoIme = pozpred.JedinstvenoIme;
                p.Starost = pozpred.Starost;


                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void obrisiPozPred(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik pozpred = s.Load<PoznatiPredstavnik>(id);

                s.Delete(pozpred);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion

        #region Protivmere

        public static List<ProtivmerePregled> VratiSveProtivmere()
        {
            List<ProtivmerePregled> protivmere = new List<ProtivmerePregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Protivmere> sveProtivmere = session.Query<Protivmere>();

                foreach (Protivmere protivmereItem in sveProtivmere)
                {
                    protivmere.Add(new ProtivmerePregled(protivmereItem.IdProtivmere, protivmereItem.NazivProtivmere, protivmereItem.OpisProtivmere));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return protivmere;
        }

        public static void DodajProtivmere(ProtivmereBasic protivmere)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Protivmere novaProtivmere = new Protivmere();

                novaProtivmere.IdProtivmere = protivmere.IdProtivmere;
                novaProtivmere.NazivProtivmere = protivmere.NazivProtivmere;
                novaProtivmere.OpisProtivmere = protivmere.OpisProtivmere;

                session.SaveOrUpdate(novaProtivmere);

                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static List<ProtivmerePregled> vratiProtivmeru()
        {

            List<ProtivmerePregled> protivmere = new List<ProtivmerePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Protivmere> sveprotivmere = from o in s.Query<Protivmere>() select o;

                foreach (Protivmere p in sveprotivmere)
                {
                    protivmere.Add(new ProtivmerePregled(p.IdProtivmere, p.NazivProtivmere, p.OpisProtivmere));
                }
                s.Close();

            }
            catch (Exception ec)
            {

            }
            return protivmere;


        }
        public static void AzurirajProtivmere(ProtivmereBasic protivmere)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Protivmere postojeceProtivmere = session.Get<Protivmere>(protivmere.IdProtivmere);

                if (postojeceProtivmere != null)
                {
                    postojeceProtivmere.NazivProtivmere = protivmere.NazivProtivmere;
                    postojeceProtivmere.OpisProtivmere = protivmere.OpisProtivmere;

                    session.SaveOrUpdate(postojeceProtivmere);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void ObrisiProtivmere(int idProtivmere)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Protivmere postojeceProtivmere = session.Get<Protivmere>(idProtivmere);

                if (postojeceProtivmere != null)
                {
                    session.Delete(postojeceProtivmere);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }


        #endregion



        #region Predmet


        public static List<PredmetPregled> VratiSvePredmete()
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Predmet> sviPredmeti = session.Query<Predmet>();

                foreach (Predmet predmetItem in sviPredmeti)
                {
                    predmeti.Add(new PredmetPregled(predmetItem.IdPredmeta, predmetItem.TipPredmeta, predmetItem.NazivPredmeta, predmetItem.MaterijalPredmeta));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return predmeti;
        }

        public static void DodajPredmet(PredmetBasic predmet)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet noviPredmet = new Predmet();

                noviPredmet.IdPredmeta = predmet.IdPredmeta;
                noviPredmet.NazivPredmeta = predmet.NazivPredmeta;
                noviPredmet.TipPredmeta = predmet.TipPredmeta;
                noviPredmet.MaterijalPredmeta = predmet.MaterijalPredmeta;

                session.SaveOrUpdate(noviPredmet);

                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void AzurirajPredmet(PredmetBasic predmet)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet postojećiPredmet = session.Get<Predmet>(predmet.IdPredmeta);

                if (postojećiPredmet != null)
                {
                    postojećiPredmet.IdPredmeta = predmet.IdPredmeta;
                    postojećiPredmet.NazivPredmeta = predmet.NazivPredmeta;
                    postojećiPredmet.TipPredmeta = predmet.TipPredmeta;
                    postojećiPredmet.MaterijalPredmeta = predmet.MaterijalPredmeta;

                    session.SaveOrUpdate(postojećiPredmet);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void ObrisiPredmet(int idPredmeta)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet postojećiPredmet = session.Get<Predmet>(idPredmeta);

                if (postojećiPredmet != null)
                {
                    session.Delete(postojećiPredmet);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }
        public static PredmetPregled VratiPredmetPoId(int idPredmeta)
        {
            PredmetPregled predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet pronadjeniPredmet = session.Get<Predmet>(idPredmeta);

                if (pronadjeniPredmet != null)
                {
                    predmet = new PredmetPregled(pronadjeniPredmet.IdPredmeta, pronadjeniPredmet.TipPredmeta, pronadjeniPredmet.NazivPredmeta, pronadjeniPredmet.MaterijalPredmeta);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return predmet;
        }

        #endregion



        #region Zastita

        public static List<ZastitaPregled> VratiSveZastite()
        {
            List<ZastitaPregled> zastite = new List<ZastitaPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Zastita> sveZastite = session.Query<Zastita>();

                foreach (Zastita zastitaItem in sveZastite)
                {
                    zastite.Add(new ZastitaPregled(zastitaItem.IdZastite, zastitaItem.TipZastite, zastitaItem.NazivZastite));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return zastite;
        }

        public static void DodajZastitu(ZastitaBasic zastita)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita novaZastita = new Zastita();

                novaZastita.IdZastite = zastita.IdZastite;
                novaZastita.TipZastite = zastita.TipZastite;
                novaZastita.NazivZastite = zastita.NazivZastite;

                session.SaveOrUpdate(novaZastita);

                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void AzurirajZastitu(ZastitaBasic zastita)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita postojećaZastita = session.Get<Zastita>(zastita.IdZastite);

                if (postojećaZastita != null)
                {

                    postojećaZastita.IdZastite = zastita.IdZastite;
                    postojećaZastita.TipZastite = zastita.TipZastite;
                    postojećaZastita.NazivZastite = zastita.NazivZastite;

                    session.SaveOrUpdate(postojećaZastita);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void ObrisiZastitu(int idZastite)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita postojećaZastita = session.Get<Zastita>(idZastite);

                if (postojećaZastita != null)
                {
                    session.Delete(postojećaZastita);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static ZastitaPregled VratiZastita(int idPredmeta)
        {
            ZastitaPregled predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita pronadjeniZastitu = session.Get<Zastita>(idPredmeta);

                if (pronadjeniZastitu != null)
                {
                    predmet = new ZastitaPregled(pronadjeniZastitu.IdZastite, pronadjeniZastitu.TipZastite, pronadjeniZastitu.NazivZastite);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return predmet;

            
     
        }
        #endregion


        #region Susret


        public static List<SusretPregled> VratiSveSusrete()
        {
            List<SusretPregled> susreti = new List<SusretPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Susret> sviSusreti = session.Query<Susret>();

                foreach (Susret susretItem in sviSusreti)
                {
                    susreti.Add(new SusretPregled(susretItem.IdSusret, susretItem.Vreme, susretItem.Ishod));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return susreti;
        }

        public static void DodajSusret(SusretBasic susret)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susret noviSusret = new Susret();

                noviSusret.IdSusret = susret.IdSusret;
                noviSusret.Vreme = susret.Vreme;
                noviSusret.Ishod = susret.Ishod;

                session.SaveOrUpdate(noviSusret);

                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void AzurirajSusret(SusretBasic susret)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susret postojećiSusret = session.Get<Susret>(susret.IdSusret);

                if (postojećiSusret != null)
                {
                    postojećiSusret.Vreme = susret.Vreme;
                    postojećiSusret.Ishod = susret.Ishod;
           

                    session.SaveOrUpdate(postojećiSusret);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void ObrisiSusret(int idSusreta)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susret postojećiSusret = session.Get<Susret>(idSusreta);

                if (postojećiSusret != null)
                {
                    session.Delete(postojećiSusret);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static SusretPregled VratiSusret(int idPredmeta)
        {
            SusretPregled predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Susret pronadjeniSusret = session.Get<Susret>(idPredmeta);

                if (pronadjeniSusret != null)
                {
                    predmet = new SusretPregled(pronadjeniSusret.IdSusret, pronadjeniSusret.Vreme, pronadjeniSusret.Ishod);

                }
                 session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return predmet;



        }



        #endregion

        #region UsloviZaPrimenu
        public static List<UsloviZaPrimenuPregled> VratiSveUslove()
        {
            List<UsloviZaPrimenuPregled> uslovi = new List<UsloviZaPrimenuPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<UsloviZaPrimenuBasic> sviUslovi = session.Query<UsloviZaPrimenuBasic>();

                foreach (UsloviZaPrimenuBasic uslovItem in sviUslovi)
                {
                    uslovi.Add(new UsloviZaPrimenuPregled(uslovItem.IdUslova, uslovItem.Uslov));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return uslovi;
        }

        public static void DodajUslov(UsloviZaPrimenuBasic uslov)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenu noviUslov = new UsloviZaPrimenu();

                noviUslov.IdUslova = uslov.IdUslova;
                noviUslov.Uslov = uslov.Uslov;
                

                session.SaveOrUpdate(noviUslov);

                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void AzurirajUslov(UsloviZaPrimenuBasic uslov)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenuBasic postojećiUslov = session.Get<UsloviZaPrimenuBasic>(uslov.IdUslova);

                if (postojećiUslov != null)
                {
                    postojećiUslov.Uslov = uslov.Uslov;
               

                    session.SaveOrUpdate(postojećiUslov);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static void ObrisiUslov(int idUslova)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenuBasic uslov = session.Get<UsloviZaPrimenuBasic>(idUslova);

                if (uslov != null)
                {
                    session.Delete(uslov);

                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }
        public static UsloviZaPrimenuPregled vratiUslov(int idUslova)
        {
            UsloviZaPrimenuPregled predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenu pronadjiUslov = session.Get<UsloviZaPrimenu>(idUslova);

                if (pronadjiUslov != null)
                {
                    predmet = new UsloviZaPrimenuPregled(pronadjiUslov.IdUslova, pronadjiUslov.Uslov);

                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return predmet;



            #endregion
        }

    }
}

