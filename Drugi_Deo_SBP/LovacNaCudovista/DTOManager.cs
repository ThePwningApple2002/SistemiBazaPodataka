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

        public static void vratisveprodavnice()
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
            catch(Exception ec) {
                
            }
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

        public static BajalicaBasic azurirajBajalicu(BajalicaBasic b)
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

            return b;
        }
        public static BajalicaBasic vratiBajalicu (int id)
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





        #endregion
    }
}
