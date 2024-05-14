using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Predmet
    {
        public virtual int IdPredmeta { get; set; }
        public virtual string TipPredmeta { get; set; }
        public virtual string NazivPredmeta {  get; set; }
        public virtual string MaterijalPredmeta { get; set; }

    }
}
