using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Lovac
    {
        public virtual int IdLovca { get; set; }
        public virtual string? ImeLovca { get; set; }

        public virtual IList<Susret> SusretiLovac { get; set; } 

        public virtual IList<PoznatiPredstavnik> PoznatiPredstavnici { get; set; }

        public Lovac() { 
        
            SusretiLovac = new List<Susret>();
            PoznatiPredstavnici = new List<PoznatiPredstavnik>();
        }

    }
}
