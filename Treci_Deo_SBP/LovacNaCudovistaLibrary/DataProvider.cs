
using LovacNaCudovista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary
{
    public class DataProvider
    {
        #region Bajalica

        public static List<BajalicaView> vratisveBajalice()
        {
            List<BajalicaView> bajalice = new List<BajalicaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Bajalica> sveBajalice = from o in s.Query<Bajalica>() select o;

                foreach (Bajalica p in sveBajalice)
                {
                    bajalice.Add(new BajalicaView(p));
                }
                s.Close();

            }
            catch
            {

            }
            return bajalice;
        }
        public static void dodajBajalicu(BajalicaView b)
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
            catch
            {
                //handle exceptions
            }
        }

        public static void azurirajBajalicu(BajalicaView b)
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
            catch
            {
                //handle exceptions
            }


        }
        public static BajalicaView vratiBajalicu(int id)
        {
            BajalicaView pb = new BajalicaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Bajalica o = s.Load<Bajalica>(id);
                pb = new BajalicaView(o);

                s.Close();
            }
            catch
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
            catch
            {
                //handle exceptions
            }
        }

        #endregion

        #region Cudoviste

        public static List<CudovisteView> vratisvaCudovista()
        {

            List<CudovisteView> cudovista = new List<CudovisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Cudoviste> svaCudovista = from o in s.Query<Cudoviste>() select o;

                foreach (Cudoviste p in svaCudovista)
                {
                    cudovista.Add(new CudovisteView(p));
                }
                s.Close();


            }
            catch
            {

            }
            return cudovista;


        }

        public static List<MagCudovisteView> vratisvaMagCudovista()
        {
            List<MagCudovisteView> magCudovista = new List<MagCudovisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<MagCudoviste> svaMagCudovista = from o in s.Query<MagCudoviste>() select o;

                foreach (MagCudoviste p in svaMagCudovista)
                {
                    magCudovista.Add(new MagCudovisteView(p));
                }
                s.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return magCudovista;
        }
        //MAGICNA CUDOVISTA

        public static List<NeMagCudovisteView> vratisvaNeMagCudovista()
        {
            List<NeMagCudovisteView> nemagCudovista = new List<NeMagCudovisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NeMagCudoviste> svaNeMagCudovista = from o in s.Query<NeMagCudoviste>() select o;

                foreach (NeMagCudoviste p in svaNeMagCudovista)
                {
                    nemagCudovista.Add(new NeMagCudovisteView(p));
                }
                s.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return nemagCudovista;
        }
        //NEMAGICNA CUDOVISTA


        public static void dodajCudoviste(CudovisteView b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudoviste o = new Cudoviste();

                o.IdCudovista = b.IdCudovista;
                o.NazivCud = b.NazivCud;
                o.PodTipCud = b.PodTipCud;
                o.VekPomCud = b.VekPomCud;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

        }

        public static void dodajMagCudoviste(MagCudovisteView b)
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
            catch
            {
                //handle exceptions
            }
        }

        public static void dodajNeMagCudoviste(NeMagCudovisteView b)
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
            catch
            {
                //handle exceptions
            }
        }
        public static void azurirajCudoviste(CudovisteView c)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cudoviste o = s.Load<Cudoviste>(c.IdCudovista);

                o.IdCudovista = c.IdCudovista;
                o.NazivCud = c.NazivCud;
                o.PodTipCud = c.PodTipCud;
                o.VekPomCud = c.VekPomCud;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch
            {
                //handle exceptions
            }



        }

        public static void azurirajMagCudoviste(MagCudovisteView b)
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
            catch
            {
                //handle exceptions
            }



        }

        public static void azurirajNeMagCudoviste(NeMagCudovisteView b)
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
            catch
            {
                //handle exceptions
            }

        }

        public static CudovisteView vratiCudoviste(int id)
        {
            CudovisteView pb = new CudovisteView();
            try
            {
                ISession s = DataLayer.GetSession();

                Cudoviste o = s.Load<Cudoviste>(id);
                pb = new CudovisteView(o);

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return pb;
        }

        public static MagCudovisteView vratiMagCudoviste(int id)
        {
            MagCudovisteView pb = new MagCudovisteView();
            try
            {
                ISession s = DataLayer.GetSession();

                MagCudoviste o = s.Load<MagCudoviste>(id);
                pb = new MagCudovisteView(o);

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return pb;
        }

        public static NeMagCudovisteView vratiNeMagCudoviste(int id)
        {
            NeMagCudovisteView pb = new NeMagCudovisteView();
            try
            {
                ISession s = DataLayer.GetSession();

                NeMagCudoviste o = s.Load<NeMagCudoviste>(id);
                pb = new NeMagCudovisteView(o);

                s.Close();
            }
            catch
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
            catch
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
            catch
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
            catch
            {
                //handle exceptions
            }
        }
        #endregion

        #region Legenda

        public static List<LegendaView> vratiLegendePozPred(PoznatiPredstavnikView Pozpred)
        {
            List<LegendaView> legende = new List<LegendaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Legenda> sveLegende = from o in s.Query<Legenda>()
                                                  where o.LegZaPP.IdPozPred == Pozpred.IdPozPred
                                                  select o;

                foreach (Legenda r in sveLegende)
                {
                    legende.Add(new LegendaView(r));

                }

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return legende;
        }
        public static LegendaView vratiLegende(int id)
        {
            LegendaView pb = new LegendaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda o = s.Load<Legenda>(id);
                pb = new LegendaView(o);

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<LegendaView> vratiLeg(int id)
        {
            List<LegendaView> legende = new List<LegendaView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Legenda> legendeEntiteti = session.Query<Legenda>()
                        .Where(l => l.LegZaPP.IdPozPred == id);

                    foreach (Legenda legenda in legendeEntiteti)
                    {
                        LegendaView legBasic = new LegendaView
                        {
                            IdLegende = legenda.IdLegende,
                            PrvoPominjanje = legenda.PrvoPominjanje,
                            TekstLegende = legenda.TekstLegende,
                            ZemljaPorekla = legenda.ZemljaPorekla,
                            LegZaPP = new PoznatiPredstavnikView
                            {
                                IdPozPred = legenda.LegZaPP.IdPozPred,
                                JedinstvenoIme = legenda.LegZaPP.JedinstvenoIme,
                                Starost = legenda.LegZaPP.Starost
                            }
                        };

                        legende.Add(legBasic);
                    }
                }
            }
            catch
            {
                //handle exceptions
            }

            return legende;
        }

        public static void dodajLegendu(PoznatiPredstavnikView p, LegendaView l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda f = new Legenda();
                f.IdLegende = l.IdLegende;
                f.PrvoPominjanje = l.PrvoPominjanje;
                f.TekstLegende = l.TekstLegende;
                f.ZemljaPorekla = l.ZemljaPorekla;


                PoznatiPredstavnik pm = s.Load<PoznatiPredstavnik>(p.IdPozPred);
                f.LegZaPP = pm;

                s.Save(f);

                s.Flush();

                s.Close();
            }
            catch
            {
                //handle exceptions
            }
        }

        public static void dodajLegendu(LegendaView l)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    using (ITransaction transaction = s.BeginTransaction())
                    {
                        Legenda f = new Legenda
                        {
                            IdLegende = l.IdLegende,
                            PrvoPominjanje = l.PrvoPominjanje,
                            TekstLegende = l.TekstLegende,
                            ZemljaPorekla = l.ZemljaPorekla,
                            LegZaPP = s.Load<PoznatiPredstavnik>(l.LegZaPP.IdPozPred)
                        };



                        s.SaveOrUpdate(f);

                        s.Flush();

                        s.Close();
                    }
                }
            }
            catch
            {
                // Handle exceptions

            }
        }

        public static void izmeniLegendu(LegendaView legend)
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
            catch
            {
                //handle exceptions
            }
        }
        public static void obrisiLegendu(int idleg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda legend = s.Load<Legenda>(idleg);

                s.Delete(legend);
                s.Flush();

                s.Close();

            }
            catch
            {
                //handle exceptions
            }
        }



        #endregion

        #region Lokacija 

        public static List<LokacijaView> vratiLokacijuLegende(LegendaView legend)
        {
            List<LokacijaView> lokacije = new List<LokacijaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lokacija> sveLokacije = from o in s.Query<Lokacija>()
                                                    where o.LegendaLokacije.IdLegende == legend.IdLegende
                                                    select o;

                foreach (Lokacija r in sveLokacije)
                {
                    LokacijaView lokacijaPregled = new LokacijaView(r);

                    lokacije.Add(lokacijaPregled);
                }

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return lokacije;
        }
        public static int VratiIdLokacijePoIdLegende(int idLegende)
        {
            int idLokacije = 0;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Učitajte objekat Legenda koristeći ID legende
                    Legenda legenda = s.Load<Legenda>(idLegende);

                    if (legenda != null && legenda.Lokacije != null && legenda.Lokacije.Count > 0)
                    {
                        // Pretpostavljamo da postoji samo jedna povezana lokacija po legendi
                        idLokacije = legenda.Lokacije.First().IdLokacije;
                    }

                    s.Close();
                }
            }
            catch (Exception ec)
            {
                // Handle exceptions
                Console.WriteLine("Greška: " + ec.Message);
            }

            return idLokacije;
        }

        public static List<LokacijaView> vratiLok(int id)
        {
            List<LokacijaView> lokacije = new List<LokacijaView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Lokacija> lokacijeEntiteti = session.Query<Lokacija>()
                        .Where(l => l.IdLokacije == id);

                    foreach (Lokacija lokacija in lokacijeEntiteti)
                    {
                        LokacijaView lokBasic = new LokacijaView
                        {
                            IdLokacije = lokacija.IdLokacije,
                            TipLok = lokacija.TipLok,
                            NazivLok = lokacija.NazivLok,
                            ZemljaLok = lokacija.ZemljaLok,
                            Blago = lokacija.Blago,
                            LegendaLokacije = DataProvider.vratiLegende(lokacija.LegendaLokacije.IdLegende)
                        };

                        lokacije.Add(lokBasic);
                    }
                }
            }
            catch
            {
                // Handle exceptions
            }

            return lokacije;
        }
        public static LokacijaView vratiJednuLokaciju(int idLokacije)
        {
            LokacijaView lokacija = null;
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    Lokacija l = session.Query<Lokacija>().FirstOrDefault(x => x.IdLokacije == idLokacije);

                    if (l != null)
                    {
                        lokacija = new LokacijaView
                        {
                            IdLokacije = l.IdLokacije,
                            TipLok = l.TipLok,
                            NazivLok = l.NazivLok,
                            ZemljaLok = l.ZemljaLok,
                            Blago = l.Blago
                        };
                    }

                    session.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Greška: " + ex.Message);
            }

            return lokacija;
        }

        public static void dodajLokaciju(LegendaView p, LokacijaView l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija f = new Lokacija();
                f.IdLokacije = l.IdLokacije;
                f.TipLok = l.TipLok;
                f.NazivLok = l.NazivLok;
                f.ZemljaLok = l.ZemljaLok;
                f.Blago = l.Blago;


                Legenda pm = s.Load<Legenda>(p.IdLegende);
                f.LegendaLokacije = pm;


                s.Save(f);

                s.Flush();

                s.Close();
            }
            catch
            {
                //handle exceptions
            }
        }

        public static void izmeniLokaciju(LokacijaView lok)
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
            catch
            {
                //handle exceptions
            }
        }
        public static void obrisiLokaciju(int idLok)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija lok = s.Load<Lokacija>(idLok);

                s.Delete(lok);
                s.Flush();

                s.Close();

            }
            catch
            {
                //handle exceptions
            }
        }



        #endregion

        #region Lovac

        public static List<LovacView> vratisveLovce()
        {

            List<LovacView> lovci = new List<LovacView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lovac> svilovci = from o in s.Query<Lovac>() select o;

                foreach (Lovac p in svilovci)
                {
                    lovci.Add(new LovacView(p));
                }
                s.Close();

            }
            catch
            {

            }
            return lovci;


        }

        public static async Task dodajLovca(LovacView b)
        {
            using (ISession s = DataLayer.GetSession())
            using (ITransaction tx = s.BeginTransaction())
            {
                try
                {
                    Lovac o = new Lovac
                    {
                        ImeLovca = b.ImeLovca
                    };
                    await s.SaveOrUpdateAsync(o);
                    await tx.CommitAsync();
                }
                catch (Exception ex)
                {
                    await tx.RollbackAsync();
                    // Log the exception
                    throw;
                }
            }
        }

        public static void azurirajLovca(LovacView b)
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
            catch
            {
                //handle exceptions
            }


        }
        public static LovacView vratiLovca(int id)
        {
            LovacView pb = new LovacView();
            try
            {
                ISession s = DataLayer.GetSession();

                Lovac o = s.Load<Lovac>(id);
                pb = new LovacView(o);

                s.Close();
            }
            catch
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
            catch
            {
                //handle exceptions
            }
        }


        #endregion

        #region MagSposobnost

        public static List<MagSposobnostView> vratiMagSposobnosti()
        {

            List<MagSposobnostView> sposobnosti = new List<MagSposobnostView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<MagSposobnost> svespos = from o in s.Query<MagSposobnost>() select o;

                foreach (MagSposobnost p in svespos)
                {
                    sposobnosti.Add(new MagSposobnostView(p));
                }
                s.Close();

            }
            catch
            {

            }
            return sposobnosti;


        }

        public static async Task<MagSposobnost> SacuvajMagSpos(MagSposobnostView b)
        {
            using var session = DataLayer.GetSession();
            using var transaction = session.BeginTransaction();
            try
            {
                var magSposobnost = new MagSposobnost
                {
                    NazivMagSpos = b.NazivMagSpos,
                    OpisMagSpos = b.OpisMagSpos,
                    Ofanzivna = b.Ofanzivna,
                    Defanzivna = b.Defanzivna
                };

                // Log the values being inserted
                Console.WriteLine($"Attempting to insert MagSposobnost: " +
                    $"NazivMagSpos={magSposobnost.NazivMagSpos}, " +
                    $"OpisMagSpos={magSposobnost.OpisMagSpos}, " +
                    $"Ofanzivna={magSposobnost.Ofanzivna}, " +
                    $"Defanzivna={magSposobnost.Defanzivna}");

                await session.SaveOrUpdateAsync(magSposobnost);
                await transaction.CommitAsync();

                Console.WriteLine($"Successfully inserted MagSposobnost with ID: {magSposobnost.IdMagSpos}");

                return magSposobnost;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();

                Console.WriteLine($"Error saving MagSposobnost: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }

                // Log NHibernate-specific exception details if available
                if (ex is NHibernate.ADOException adoEx)
                {
                    Console.WriteLine($"SQL: {adoEx.SqlString}");
                }

                throw;
            }
        }

        public static void azurirajMagSpos(MagSposobnostView b)
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
            catch
            {
                //handle exceptions
            }


        }
        public static MagSposobnostView vratiMagSpos(int id)
        {
            MagSposobnostView pb = new MagSposobnostView();
            try
            {
                ISession s = DataLayer.GetSession();

                MagSposobnost o = s.Load<MagSposobnost>(id);
                pb = new MagSposobnostView(o);

                s.Close();
            }
            catch
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
            catch
            {
                //handle exceptions
            }

        }

        #endregion

        #region SpecSpos


        public static List<SpecSposobnostView> vratiSpecSposobnosti()
        {

            List<SpecSposobnostView> sposobnosti = new List<SpecSposobnostView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SpecSposobnost> svespos = from o in s.Query<SpecSposobnost>() select o;

                foreach (SpecSposobnost p in svespos)
                {
                    sposobnosti.Add(new SpecSposobnostView(p));
                }
                s.Close();

            }
            catch
            {

            }
            return sposobnosti;


        }

        public static async Task<SpecSposobnost> sacuvajSpecSpos(SpecSposobnostView b)
        {
            using var session = DataLayer.GetSession();
            using var transaction = session.BeginTransaction();

            try
            {
                var specSposobnost = new SpecSposobnost
                {
                    NazivSpecSpos = b.NazivSpecSpos
                };

                await session.SaveOrUpdateAsync(specSposobnost);
                await transaction.CommitAsync();

                return specSposobnost;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                // Log the exception
                Console.WriteLine($"Error saving SpecSposobnost: {ex.Message}");
                throw; // Re-throw the exception to be handled by the caller
            }
        }





        public static void azurirajSpecSpos(SpecSposobnostView b)
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
            catch
            {
                //handle exceptions
            }


        }
        public static SpecSposobnostView vratiSpecSpos(int id)
        {
            SpecSposobnostView pb = new SpecSposobnostView();
            try
            {
                ISession s = DataLayer.GetSession();

                SpecSposobnost o = s.Load<SpecSposobnost>(id);
                pb = new SpecSposobnostView(o);

                s.Close();
            }
            catch
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
            catch
            {
                //handle exceptions
            }

        }



        #endregion

        #region PoznatiPredstavnik
        public static PoznatiPredstavnikView vratiPozPred(int id)
        {
            PoznatiPredstavnikView pb = new PoznatiPredstavnikView();
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik o = s.Load<PoznatiPredstavnik>(id);
                pb = new PoznatiPredstavnikView(o);

                s.Close();
            }
            catch
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<PoznatiPredstavnikView> vratiPoznatePredstavnikeZaCudoviste(int cudovisteId)
        {
            List<PoznatiPredstavnikView> poznatiPredstavnici = new List<PoznatiPredstavnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                // Upit za dobijanje poznatih predstavnika po ID-u čudovišta
                IEnumerable<PoznatiPredstavnik> sviPredstavnici = from p in s.Query<PoznatiPredstavnik>()
                                                                  where p.PoznatiPredCud.IdCudovista == cudovisteId
                                                                  select p;

                foreach (var predstavnik in sviPredstavnici)
                {
                    poznatiPredstavnici.Add(new PoznatiPredstavnikView
                    {
                        IdPozPred = predstavnik.IdPozPred,
                        JedinstvenoIme = predstavnik.JedinstvenoIme,
                        Starost = predstavnik.Starost,
                        PoznatiPredCud = new CudovisteView { IdCudovista = predstavnik.PoznatiPredCud.IdCudovista }
                    });
                }

                s.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return poznatiPredstavnici;
        }

        public static List<PoznatiPredstavnikView> vratiPozPredstavnike()
        {

            List<PoznatiPredstavnikView> sposobnosti = new List<PoznatiPredstavnikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PoznatiPredstavnik> svipozpred = from o in s.Query<PoznatiPredstavnik>() select o;

                foreach (PoznatiPredstavnik p in svipozpred)
                {
                    sposobnosti.Add(new PoznatiPredstavnikView(p));
                }
                s.Close();

            }
            catch
            {

            }
            return sposobnosti;


        }

        public static void dodajPozPred(PoznatiPredstavnikView pozpred, CudovisteView cud)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoznatiPredstavnik o = new PoznatiPredstavnik();

                o.JedinstvenoIme = pozpred.JedinstvenoIme;
                o.Starost = pozpred.Starost;

                Cudoviste c = s.Load<Cudoviste>(cud.IdCudovista);


                o.PoznatiPredCud = c;



                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch
            {
                //handle exceptions
            }
        }

        public static void izmeniPozPred(PoznatiPredstavnikView pozpred)
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
            catch
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
            catch
            {
                //handle exceptions
            }

        }
        #endregion

        #region Protivmere

        public static List<ProtivmereView> VratiSveProtivmere()
        {
            List<ProtivmereView> protivmere = new List<ProtivmereView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Protivmere> sveProtivmere = session.Query<Protivmere>();

                foreach (Protivmere protivmereItem in sveProtivmere)
                {
                    protivmere.Add(new ProtivmereView(protivmereItem));
                }
                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return protivmere;
        }

        public static void DodajProtivmere(ProtivmereView protivmere)
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
            catch
            {
                // Handle exceptions
            }
        }

        public static ProtivmereView vratiProtivmeru(int idpm)
        {
            ProtivmereView pb = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Protivmere p = s.Get<Protivmere>(idpm);
                if (p != null)
                {
                    pb = new ProtivmereView(p);
                }

                s.Close();
            }
            catch
            {
                // Handle exceptions
            }

            return pb;
        }
        public static void AzurirajProtivmere(ProtivmereView protivmere)
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
            catch
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
            catch
            {
                // Handle exceptions
            }
        }


        #endregion



        #region Predmet


        public static List<PredmetView> VratiSvePredmete()
        {
            List<PredmetView> predmeti = new List<PredmetView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Predmet> sviPredmeti = session.Query<Predmet>();

                foreach (Predmet predmetItem in sviPredmeti)
                {
                    predmeti.Add(new PredmetView(predmetItem));
                }
                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return predmeti;
        }

        public static void DodajPredmet(PredmetView predmet)
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

        public static void AzurirajPredmet(PredmetView predmet)
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
        public static PredmetView VratiPredmetPoId(int idPredmeta)
        {
            PredmetView predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet pronadjeniPredmet = session.Get<Predmet>(idPredmeta);

                if (pronadjeniPredmet != null)
                {
                    predmet = new PredmetView(pronadjeniPredmet);
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

        public static List<ZastitaView> VratiSveZastite()
        {
            List<ZastitaView> zastite = new List<ZastitaView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Zastita> sveZastite = session.Query<Zastita>();

                foreach (Zastita zastitaItem in sveZastite)
                {
                    LokacijaView predmetLokacija = new LokacijaView
                    {
                        IdLokacije = zastitaItem.PredmetLokacija.IdLokacije,
                        TipLok = zastitaItem.PredmetLokacija.TipLok,
                        NazivLok = zastitaItem.PredmetLokacija.NazivLok,
                        ZemljaLok = zastitaItem.PredmetLokacija.ZemljaLok,
                        Blago = zastitaItem.PredmetLokacija.Blago
                    };

                    ZastitaView zastitaPregled = new ZastitaView(   
                        zastitaItem
                    );
                    zastite.Add(zastitaPregled);
                }
                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            return zastite;
        }

        public static List<ZastitaView> VratiZastiteZaLokaciju(int idLokacija)
        {
            List<ZastitaView> zastite = new List<ZastitaView>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Zastita> sveZastite = from z in session.Query<Zastita>()
                                                      where z.PredmetLokacija.IdLokacije == idLokacija
                                                      select z;

                    foreach (Zastita zastita in sveZastite)
                    {
                        LokacijaView lokacija = new LokacijaView
                        {
                            IdLokacije = zastita.PredmetLokacija.IdLokacije,
                            TipLok = zastita.PredmetLokacija.TipLok,
                            NazivLok = zastita.PredmetLokacija.NazivLok,
                            ZemljaLok = zastita.PredmetLokacija.ZemljaLok,
                            Blago = zastita.PredmetLokacija.Blago
                        };

                        ZastitaView zp = new ZastitaView(
                            zastita
                        );
                        zastite.Add(zp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
            }
            return zastite;
        }

        public static void DodajZastitu(LokacijaView l, ZastitaView z)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Lokacija lokacija = s.Get<Lokacija>(l.IdLokacije);

                    Zastita novaZastita = new Zastita
                    {
                        TipZastite = z.TipZastite,
                        NazivZastite = z.NazivZastite,
                        PredmetLokacija = lokacija
                    };

                    s.Save(novaZastita);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void AzurirajZastitu(ZastitaView zastita)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita z = session.Load<Zastita>(zastita.IdZastite);

                if (z != null)
                {
                    z.TipZastite = zastita.TipZastite;
                    z.NazivZastite = zastita.NazivZastite;
                    session.SaveOrUpdate(z);
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

                Zastita postojecaZastita = session.Load<Zastita>(idZastite);

                if (postojecaZastita != null)
                {
                    session.Delete(postojecaZastita);
                    session.Flush();
                }

                session.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
        }

        public static ZastitaView VratiZastita(int idPredmeta)
        {
            ZastitaView predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita pronadjeniZastitu = session.Get<Zastita>(idPredmeta);

                if (pronadjeniZastitu != null)
                {
                    predmet = new ZastitaView(
                    pronadjeniZastitu
                );
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


        public static List<SusretView> VratiSveSusrete()
        {
            List<SusretView> susreti = new List<SusretView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Susret> sviSusreti = session.Query<Susret>();


                foreach (Susret susretItem in sviSusreti)
                {
                    LovacView l = DataProvider.vratiLovca(susretItem.LovacSusrtet.IdLovca);
                    PoznatiPredstavnikView p = DataProvider.vratiPozPred(susretItem.SusretPP.IdPozPred);
                    LokacijaView lokacijaBasic = DataProvider.vratiJednuLokaciju(susretItem.SusretLok.IdLokacije);

                    susreti.Add(new SusretView(susretItem));
                };
                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return susreti;
        }

        public static void DodajSusret(SusretView susret, LovacView l, LokacijaView l2, PoznatiPredstavnikView p)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                {

                    Lovac lovac = session.Get<Lovac>(l.IdLovca);
                    Lokacija lokacija = session.Get<Lokacija>(l2.IdLokacije);
                    PoznatiPredstavnik poznatiPredstavnik = session.Get<PoznatiPredstavnik>(p.IdPozPred);

                    Susret noviSusret = new Susret
                    {
                        Vreme = susret.Vreme,
                        Ishod = susret.Ishod,
                        LovacSusrtet = lovac,
                        SusretLok = lokacija,
                        SusretPP = poznatiPredstavnik
                    };

                    session.Save(noviSusret);
                    session.Flush();
                    susret.IdSusret = noviSusret.IdSusret;
                    session.Close();
                }
            }
            catch
            {
                // Handle exceptions

            }
        }

        public static void AzurirajSusret(SusretView susret)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susret postojećiSusret = session.Load<Susret>(susret.IdSusret);

                if (postojećiSusret != null)
                {
                    postojećiSusret.Vreme = susret.Vreme;
                    postojećiSusret.Ishod = susret.Ishod;
                    postojećiSusret.LovacSusrtet = session.Load<Lovac>(susret.LovacSusrtet.IdLovca);
                    postojećiSusret.SusretLok = session.Load<Lokacija>(susret.SusretLok.IdLokacije);
                    postojećiSusret.SusretPP = session.Load<PoznatiPredstavnik>(susret.SusretPP.IdPozPred);

                    session.SaveOrUpdate(postojećiSusret);
                    session.Flush();
                }

                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
        }

        public static void ObrisiSusret(int idSusreta)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susret postojećiSusret = session.Load<Susret>(idSusreta);

                if (postojećiSusret != null)
                {
                    session.Delete(postojećiSusret);
                    session.Flush();
                }

                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
        }

        public static SusretView VratiSusret(int idSusret)
        {
            SusretView susret = null;
            try
            {
                ISession session = DataLayer.GetSession();


                Susret pronadjeniSusret = session.Get<Susret>(idSusret);

                if (pronadjeniSusret != null)
                {

                    susret = new SusretView(
                        pronadjeniSusret
                    );
                }
                else
                {
                    Console.WriteLine("Susret nije pronađen.");
                }
                session.Close();

            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Greška prilikom vraćanja susreta: {ex.Message}");
            }
            return susret;
        }



        #endregion

        #region UsloviZaPrimenu
        public static List<UsloviZaPrimenuView> VratiSveUslove()
        {
            List<UsloviZaPrimenuView> uslovi = new List<UsloviZaPrimenuView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<UsloviZaPrimenu> sviUslovi = session.Query<UsloviZaPrimenu>();

                foreach (UsloviZaPrimenu uslovItem in sviUslovi)
                {
                    uslovi.Add(new UsloviZaPrimenuView(uslovItem));
                }
                session.Close();
            }
            catch
            {
                // Handle exceptions
            }
            return uslovi;
        }

        public static void DodajUslov(UsloviZaPrimenuView uslov)
        {
            try
            {
                ISession session = DataLayer.GetSession();


                Protivmere protivmera = session.Load<Protivmere>(uslov.UslPM.IdProtivmere);


                UsloviZaPrimenu noviUslov = new UsloviZaPrimenu
                {
                    Uslov = uslov.Uslov,
                    UslPM = protivmera
                };

                session.Save(noviUslov);
                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public static void AzurirajUslov(UsloviZaPrimenuView uslov)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenu postojećiUslov = session.Load<UsloviZaPrimenu>(uslov.IdUslova);

                if (postojećiUslov != null)
                {
                    postojećiUslov.Uslov = uslov.Uslov;
                    postojećiUslov.UslPM = session.Load<Protivmere>(uslov.UslPM.IdProtivmere);

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

                UsloviZaPrimenu uslov = session.Load<UsloviZaPrimenu>(idUslova);

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
        public static UsloviZaPrimenuView vratiUslov(int idUslova)
        {
            UsloviZaPrimenuView predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenu uslov = session.Get<UsloviZaPrimenu>(idUslova);

                if (uslov != null)
                {
                    predmet = new UsloviZaPrimenuView(uslov)
                    {
                        UslPM = new ProtivmereView
                        {
                            IdProtivmere = uslov.UslPM.IdProtivmere,
                            NazivProtivmere = uslov.UslPM.NazivProtivmere,
                            OpisProtivmere = uslov.UslPM.OpisProtivmere
                        }
                    };
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

    }
}
