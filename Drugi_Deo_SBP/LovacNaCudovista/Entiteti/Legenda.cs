using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Legenda
    {
        public virtual int IdLegende { get; set; }
        public virtual string? PrvoPominjanje { get; set; }
        public virtual string? TekstLegende { get; set; }
        public virtual string? ZemljaPorekla { get; set; }
        public virtual  PoznatiPredstavnik LegZaPP { get; set; }

        public virtual IList<Lokacija> Lokacije {  get; set; }

        public virtual IList<Cudoviste> Cudovista { get; set; }

        public Legenda() {
            
            Lokacije = new List<Lokacija>();
            Cudovista = new List<Cudoviste>();

        }    
        

    }
}
