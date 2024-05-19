using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class MagCudoviste : Cudoviste
    {

        public virtual string? Postojanje { get; set; }

        public virtual IList<MagSposobnost> MagSposobnosti { get; set; }

        public MagCudoviste() { 
        
            MagSposobnosti = new List<MagSposobnost>();
        }
    }
}
