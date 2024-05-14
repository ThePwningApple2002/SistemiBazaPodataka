using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Protivmere
    {
        public virtual int IdProtivmere { get; set; }
        public virtual string NazivProtivmere { get; set; }
        public virtual string NazivPredmeta { get; set; }
        public virtual string MaterijalPredmeta { get; set; }
    }
}
