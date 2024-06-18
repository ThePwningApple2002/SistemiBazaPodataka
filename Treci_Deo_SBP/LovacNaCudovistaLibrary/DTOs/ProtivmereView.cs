using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class ProtivmereView
    {

        public virtual int IdProtivmere { get; set; }
        public virtual string? NazivProtivmere { get; set; }
        public virtual string? OpisProtivmere { get; set; }

        public virtual IList<UsloviZaPrimenuView> Uslovi { get; set; }

        public virtual IList<PredmetView> Predmeti { get; set; }

        public virtual IList<CudovisteView> Cudovista { get; set; }

        internal ProtivmereView(Protivmere p)
        {
            if(p != null)
            {
                IdProtivmere = p.IdProtivmere;
                NazivProtivmere = p.NazivProtivmere;
                OpisProtivmere = p.OpisProtivmere;

            }

        }
        public ProtivmereView()
        {
            Uslovi = new List<UsloviZaPrimenuView>();
            Predmeti = new List<PredmetView>();
            Cudovista = new List<CudovisteView>();

        }

    }
}
