using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class MagCudoviste
    {
        public virtual int IdCudovista { get; set; }
        public virtual string Postojanje { get; set; }
        public virtual Cudoviste Cudoviste { get; set; }


    }
}
