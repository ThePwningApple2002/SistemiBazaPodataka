using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class PoznatiPredstavnik
    {
        public virtual int IdPozPred { get; set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual int? Starost { get; set; }
        public virtual Cudoviste PoznatiPredCud { get; set; }

        public virtual IList<Legenda> Legende {  get; set; }

        public virtual IList<Susret> SusretPP { get; set; }
        public virtual IList<Lovac> Lovci { get; set; }

        public PoznatiPredstavnik() {
            SusretPP = new List<Susret>();  
            Legende = new List<Legenda>();
            Lovci = new List<Lovac>();
        }

    }
}
