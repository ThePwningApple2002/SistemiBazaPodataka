using LovacNaCudovista.Entiteti;

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
            catch 
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
            catch 
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
            catch
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
            catch 
            {

            }
            return cudovista;


        }

        public static List<MagCudovistePregled> vratisvaMagCudovista()
        {
            List<MagCudovistePregled> magCudovista = new List<MagCudovistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<MagCudoviste> svaMagCudovista = from o in s.Query<MagCudoviste>() select o;

                foreach (MagCudoviste p in svaMagCudovista)
                {
                    magCudovista.Add(new MagCudovistePregled(p.IdCudovista, p.NazivCud, p.PodTipCud, p.VekPomCud, p.Postojanje));
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

        public static List<NeMagCudovistePregled> vratisvaNeMagCudovista()
        {
            List<NeMagCudovistePregled> nemagCudovista = new List<NeMagCudovistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NeMagCudoviste> svaNeMagCudovista = from o in s.Query<NeMagCudoviste>() select o;

                foreach (NeMagCudoviste p in svaNeMagCudovista)
                {
                    nemagCudovista.Add(new NeMagCudovistePregled(p.IdCudovista, p.NazivCud, p.PodTipCud, p.VekPomCud, p.Visina,p.Duzina,p.Kandze,p.BrojGlava,p.ZiviUVodi,p.Leti,p.Otrovno,p.Tezina));
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


        public static void dodajCudoviste(CudovisteBasic b)
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
            catch 
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
            catch 
            {
                //handle exceptions
            }
        }
        public static void azurirajCudoviste(CudovisteBasic c)
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
            catch 
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
            catch 
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
            catch 
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
            catch
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
            catch 
            {
                //handle exceptions
            }

            return legende;
        }
        public static LegendaBasic vratiLegende(int id)
        {
            LegendaBasic pb = new LegendaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Legenda o = s.Load<Legenda>(id);
                pb = new LegendaBasic(o.IdLegende, o.PrvoPominjanje, o.TekstLegende, o.ZemljaPorekla, DTOManager.vratiPozPred(o.LegZaPP.IdPozPred));

                s.Close();
            }
            catch 
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<LegendaBasic> vratiLeg(int id)
        {
            List<LegendaBasic> legende = new List<LegendaBasic>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Legenda> legendeEntiteti = session.Query<Legenda>()
                        .Where(l => l.LegZaPP.IdPozPred == id);

                    foreach (Legenda legenda in legendeEntiteti)
                    {
                        LegendaBasic legBasic = new LegendaBasic
                        {
                            IdLegende = legenda.IdLegende,
                            PrvoPominjanje = legenda.PrvoPominjanje,
                            TekstLegende = legenda.TekstLegende,
                            ZemljaPorekla = legenda.ZemljaPorekla,
                            LegZaPP = new PoznatiPredstavnikBasic
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

        public static void dodajLegendu(PoznatiPredstavnikBasic p, LegendaBasic l)
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

        public static void dodajLegendu(LegendaBasic l)
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
                    LokacijaPregled lokacijaPregled = new LokacijaPregled(
                        r.IdLokacije,
                        r.TipLok,
                        r.NazivLok,
                        r.ZemljaLok,
                        r.Blago,
                        new LegendaBasic
                        {
                            IdLegende = r.LegendaLokacije.IdLegende,
                            PrvoPominjanje = r.LegendaLokacije.PrvoPominjanje,
                            TekstLegende = r.LegendaLokacije.TekstLegende,
                            ZemljaPorekla = r.LegendaLokacije.ZemljaPorekla
                        }
                    );

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
                    
                    Legenda legenda = s.Load<Legenda>(idLegende);

                    if (legenda != null && legenda.Lokacije != null && legenda.Lokacije.Count > 0)
                    {
                        
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

        public static List<LokacijaBasic> vratiLok(int id)
        {
            List<LokacijaBasic> lokacije = new List<LokacijaBasic>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Lokacija> lokacijeEntiteti = session.Query<Lokacija>()
                        .Where(l => l.IdLokacije == id);

                    foreach (Lokacija lokacija in lokacijeEntiteti)
                    {
                        LokacijaBasic lokBasic = new LokacijaBasic
                        {
                            IdLokacije = lokacija.IdLokacije,
                            TipLok = lokacija.TipLok,
                            NazivLok = lokacija.NazivLok,
                            ZemljaLok = lokacija.ZemljaLok,
                            Blago = lokacija.Blago,
                            LegendaLokacije = DTOManager.vratiLegende(lokacija.LegendaLokacije.IdLegende)
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
        public static LokacijaBasic vratiJednuLokaciju(int idLokacije)
        {
            LokacijaBasic lokacija = null;
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    Lokacija l = session.Query<Lokacija>().FirstOrDefault(x => x.IdLokacije == idLokacije);

                    if (l != null)
                    {
                        lokacija = new LokacijaBasic
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

        public static void dodajLokaciju(LegendaBasic p, LokacijaBasic l)
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
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
            catch 
            {
                //handle exceptions
            }

            return pb;
        }

        public static List<PoznatiPredstavnikBasic> vratiPoznatePredstavnikeZaCudoviste(int cudovisteId)
    {
        List<PoznatiPredstavnikBasic> poznatiPredstavnici = new List<PoznatiPredstavnikBasic>();
        try
        {
            ISession s = DataLayer.GetSession();

            
            IEnumerable<PoznatiPredstavnik> sviPredstavnici = from p in s.Query<PoznatiPredstavnik>()
                                                              where p.PoznatiPredCud.IdCudovista == cudovisteId
                                                              select p;

            foreach (var predstavnik in sviPredstavnici)
            {
                poznatiPredstavnici.Add(new PoznatiPredstavnikBasic
                {
                    IdPozPred = predstavnik.IdPozPred,
                    JedinstvenoIme = predstavnik.JedinstvenoIme,
                    Starost = predstavnik.Starost,
                    PoznatiPredCud = new CudovisteBasic { IdCudovista = predstavnik.PoznatiPredCud.IdCudovista }
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
            catch 
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
            catch 
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
            catch 
            {
                // Handle exceptions
            }
        }

        public static ProtivmereBasic vratiProtivmeru(int idpm)
        {
            ProtivmereBasic pb = null;
            try
            {
                ISession s = DataLayer.GetSession();

                Protivmere p = s.Get<Protivmere>(idpm);
                if (p != null)
                {
                    pb = new ProtivmereBasic(p.IdProtivmere, p.NazivProtivmere, p.OpisProtivmere);
                }

                s.Close();
            }
            catch 
            {
                // Handle exceptions
            }

            return pb;
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
            catch 
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
        public static PredmetBasic VratiPredmetPoId(int idPredmeta)
        {
            PredmetBasic predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Predmet pronadjeniPredmet = session.Get<Predmet>(idPredmeta);

                if (pronadjeniPredmet != null)
                {
                    predmet = new PredmetBasic(pronadjeniPredmet.IdPredmeta, pronadjeniPredmet.TipPredmeta, pronadjeniPredmet.NazivPredmeta, pronadjeniPredmet.MaterijalPredmeta);
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
                    LokacijaBasic predmetLokacija = new LokacijaBasic
                    {
                        IdLokacije = zastitaItem.PredmetLokacija.IdLokacije,
                        TipLok = zastitaItem.PredmetLokacija.TipLok,
                        NazivLok = zastitaItem.PredmetLokacija.NazivLok,
                        ZemljaLok = zastitaItem.PredmetLokacija.ZemljaLok,
                        Blago = zastitaItem.PredmetLokacija.Blago
                    };

                    ZastitaPregled zastitaPregled = new ZastitaPregled(
                        zastitaItem.IdZastite,
                        zastitaItem.TipZastite,
                        zastitaItem.NazivZastite,
                        predmetLokacija
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

        public static List<ZastitaPregled> VratiZastiteZaLokaciju(int idLokacija)
        {
            List<ZastitaPregled> zastite = new List<ZastitaPregled>();
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    IEnumerable<Zastita> sveZastite = from z in session.Query<Zastita>()
                                                      where z.PredmetLokacija.IdLokacije == idLokacija
                                                      select z;

                    foreach (Zastita zastita in sveZastite)
                    {
                        LokacijaBasic lokacija = new LokacijaBasic
                        {
                            IdLokacije = zastita.PredmetLokacija.IdLokacije,
                            TipLok = zastita.PredmetLokacija.TipLok,
                            NazivLok = zastita.PredmetLokacija.NazivLok,
                            ZemljaLok = zastita.PredmetLokacija.ZemljaLok,
                            Blago = zastita.PredmetLokacija.Blago
                        };

                        ZastitaPregled zp = new ZastitaPregled(
                            zastita.IdZastite,
                            zastita.TipZastite,
                            zastita.NazivZastite,
                            lokacija
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

        public static void DodajZastitu(LokacijaBasic l, ZastitaBasic z)
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

        public static void AzurirajZastitu(ZastitaBasic zastita)
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

        public static ZastitaBasic VratiZastita(int idPredmeta)
        {
            ZastitaBasic predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                Zastita pronadjeniZastitu = session.Get<Zastita>(idPredmeta);

                if (pronadjeniZastitu != null)
                {
                    predmet = new ZastitaBasic(
                    pronadjeniZastitu.IdZastite,
                    pronadjeniZastitu.TipZastite,
                    pronadjeniZastitu.NazivZastite,
                    new LokacijaBasic
                    {
                        IdLokacije = pronadjeniZastitu.PredmetLokacija.IdLokacije,
                        TipLok = pronadjeniZastitu.PredmetLokacija.TipLok,
                        NazivLok = pronadjeniZastitu.PredmetLokacija.NazivLok,
                        ZemljaLok = pronadjeniZastitu.PredmetLokacija.ZemljaLok,
                        Blago = pronadjeniZastitu.PredmetLokacija.Blago
                    }
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


        public static List<SusretPregled> VratiSveSusrete()
        {
            List<SusretPregled> susreti = new List<SusretPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Susret> sviSusreti = session.Query<Susret>();


                foreach (Susret susretItem in sviSusreti)
                {
                    LovacBasic l = DTOManager.vratiLovca(susretItem.LovacSusrtet.IdLovca);
                    PoznatiPredstavnikBasic p = DTOManager.vratiPozPred(susretItem.SusretPP.IdPozPred);
                    LokacijaBasic lokacijaBasic = DTOManager.vratiJednuLokaciju(susretItem.SusretLok.IdLokacije);

                    susreti.Add(new SusretPregled(susretItem.IdSusret, l,lokacijaBasic,susretItem.Vreme,susretItem.Ishod,p));
                };
                    session.Close();
            }
            catch 
            {
                // Handle exceptions
            }
            return susreti;
        }

        public static List<SusretPregled> VratiSusreteZaLovca(int idLovca)
        {
            List<SusretPregled> susreti = new List<SusretPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Susret> sviSusreti = from o in s.Query<Susret>()
                                                 where o.LovacSusrtet.IdLovca == idLovca
                                                 select o;

                foreach (Susret p in sviSusreti)
                {
                    LovacBasic lovacBasic = new LovacBasic(p.LovacSusrtet.IdLovca, p.LovacSusrtet.ImeLovca);
                    LokacijaBasic lokacijaBasic = new LokacijaBasic(p.SusretLok.IdLokacije, p.SusretLok.TipLok, p.SusretLok.NazivLok, p.SusretLok.ZemljaLok, p.SusretLok.Blago, null); // Simplified
                    PoznatiPredstavnikBasic poznatiPredstavnikBasic = new PoznatiPredstavnikBasic(p.SusretPP.IdPozPred, p.SusretPP.JedinstvenoIme, p.SusretPP.Starost, null); // Simplified

                    susreti.Add(new SusretPregled(p.IdSusret, lovacBasic, lokacijaBasic, p.Vreme, p.Ishod, poznatiPredstavnikBasic));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                
            }
            return susreti;
        }

        public static void DodajSusret(SusretBasic susret, LovacBasic l, LokacijaBasic l2, PoznatiPredstavnikBasic p)
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

        public static void AzurirajSusret(SusretBasic susret)
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

        public static SusretBasic VratiSusret(int idSusret)
        {
            SusretBasic susret = null;
            try
            {
                ISession session = DataLayer.GetSession();

                
                Susret pronadjeniSusret = session.Get<Susret>(idSusret);

                if (pronadjeniSusret != null)
                {
                    
                    susret = new SusretBasic(
                        pronadjeniSusret.IdSusret,
                        pronadjeniSusret.LovacSusrtet != null
                            ? new LovacBasic
                            {
                                IdLovca = pronadjeniSusret.LovacSusrtet.IdLovca,
                                ImeLovca = pronadjeniSusret.LovacSusrtet.ImeLovca
                            }
                            : null,
                        pronadjeniSusret.SusretLok != null
                            ? new LokacijaBasic
                            {
                                IdLokacije = pronadjeniSusret.SusretLok.IdLokacije,
                                TipLok = pronadjeniSusret.SusretLok.TipLok,
                                NazivLok = pronadjeniSusret.SusretLok.NazivLok,
                                ZemljaLok = pronadjeniSusret.SusretLok.ZemljaLok,
                                Blago = pronadjeniSusret.SusretLok.Blago
                            }
                            : null,
                        pronadjeniSusret.Vreme,
                        pronadjeniSusret.Ishod,
                        pronadjeniSusret.SusretPP != null
                            ? new PoznatiPredstavnikBasic
                            {
                                IdPozPred = pronadjeniSusret.SusretPP.IdPozPred,
                                JedinstvenoIme = pronadjeniSusret.SusretPP.JedinstvenoIme,
                                Starost = pronadjeniSusret.SusretPP.Starost
                            }
                            : null
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
        public static List<UsloviZaPrimenuPregled> VratiSveUslove()
        {
            List<UsloviZaPrimenuPregled> uslovi = new List<UsloviZaPrimenuPregled>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<UsloviZaPrimenu> sviUslovi = session.Query<UsloviZaPrimenu>();

                foreach (UsloviZaPrimenu uslovItem in sviUslovi)
                {
                    uslovi.Add(new UsloviZaPrimenuPregled(uslovItem.IdUslova, uslovItem.Uslov));
                }
                session.Close();
            }
            catch 
            {
                // Handle exceptions
            }
            return uslovi;
        }

        public static List<UsloviZaPrimenuPregled> VratiUsloveZaProtivmeru(int idProtivmere)
        {
            List<UsloviZaPrimenuPregled> uslovi = new List<UsloviZaPrimenuPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<UsloviZaPrimenu> sviUslovi = from o in s.Query<UsloviZaPrimenu>()
                                                         where o.UslPM.IdProtivmere == idProtivmere
                                                         select o;

                foreach (UsloviZaPrimenu p in sviUslovi)
                {
                    uslovi.Add(new UsloviZaPrimenuPregled(p.IdUslova, p.Uslov));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
            return uslovi;
        }

        public static void DodajUslov(UsloviZaPrimenuBasic uslov)
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

        public static void AzurirajUslov(UsloviZaPrimenuBasic uslov)
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
        public static UsloviZaPrimenuBasic vratiUslov(int idUslova)
        {
            UsloviZaPrimenuBasic predmet = null;
            try
            {
                ISession session = DataLayer.GetSession();

                UsloviZaPrimenu uslov = session.Get<UsloviZaPrimenu>(idUslova);

                if (uslov != null)
                {
                    predmet = new UsloviZaPrimenuBasic(uslov.IdUslova, uslov.Uslov)
                    {
                        UslPM = new ProtivmereBasic
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

