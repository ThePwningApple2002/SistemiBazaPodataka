using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Zastita
    {
        public virtual int IdZastite { get; set; }
        public virtual string TipZastite { get; set; }
        public virtual string NazivZastite { get; set; }
        public virtual int IdLok { get; set; }

    }
}
