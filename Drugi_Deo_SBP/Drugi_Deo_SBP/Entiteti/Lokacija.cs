using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Lokacija
    {
        public virtual int IdLokacije { get; set; }
        public virtual string TipLok { get; set; }
        public virtual string NazivLok { get; set; }
        public virtual string ZemljaLok { get; set; }
        public virtual string Blago { get; set; }
        public virtual int IdLeg { get; set; }

    }
}
