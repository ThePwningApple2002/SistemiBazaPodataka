
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Reflection;

namespace LovacNaCudovista
{

    static class DataLayer
    {
        private static ISessionFactory? factory;
        private static object lockObj;

        static DataLayer()
        {
            factory = null;
            lockObj = new object();
        }

        public static ISession? GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = CreateSessionFactory();
                    }
                }
            }

            return factory?.OpenSession();
            }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                // ShowSql prikazuje SQL koji je generisan, ali u .NET Core aplikacijama se prikazuju u konzoli.
                // Ako se aplikacija pokrene sa dotnet bin\Debug\net8.0-windows\ProdavnicaIgracaka.dll, mogu da se vide
                string cs = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18899;Password=S18899";
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c => c.Is(cs));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                        //.ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                //string error = e.HandleError();
                /* Logovanje greške!
                 * Console.ForegroundColor = ConsoleColor.Red;
                 * Console.Error.WriteLine(error);
                 * Nema potrebe, već se prikazuje identična greška.
                 */
                return null;
            }
        }


    }
}