using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Legenda
    {
        public virtual int IdLegende { get; set; }
        public virtual DateTime PrvoPominjanje { get; set; }
        public virtual string TekstLegende { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual string ImePoznatogPred { get; set; }
        public virtual string JedinstvenoIme { get; set; }

    }
}
