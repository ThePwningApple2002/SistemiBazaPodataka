using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class Susret
    {

        public virtual int IdSusret { get; set; }
        public virtual int IdLov {  get; set; }
        public virtual string ImePP { get; set; }
        public virtual int IdLok { get; set; }
        public virtual DateTime Vreme { get; set; }
        public virtual string Ishod {  get; set; }

    }

}
