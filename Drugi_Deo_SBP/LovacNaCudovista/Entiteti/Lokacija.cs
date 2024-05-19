using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Lokacija
    {
        public virtual int IdLokacije { get; set; }

        public virtual string TipLok {  get; set; }
        public virtual string NazivLok { get; set; }

        public virtual string ZemljaLok { get; set; }
        public virtual string Blago { get; set; }
        public virtual Legenda LegendaLokacije { get; set; }

        public virtual IList<Zastita> Zastite { get; set; }

        public virtual IList<Susret> SusretiLok { get; set; }
        public Lokacija() {
            
            Zastite = new List<Zastita>();
            SusretiLok = new List<Susret>();
            
        }

    }
}
