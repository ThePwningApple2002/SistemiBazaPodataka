using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class NeMagCudoviste : Cudoviste
    {
        public virtual int? Visina { get; set; }
        public virtual int? Duzina { get; set; }
        public virtual string? Kandze { get; set; }
        public virtual int? BrojGlava { get; set; }
        public virtual string? ZiviUVodi { get; set; }
        public virtual string? Leti { get; set; }
        public virtual string? Otrovno { get; set; }
        public virtual int? Tezina { get; set; }

        public virtual IList<SpecSposobnost> SpecSposobnosti { get; set; }

        public NeMagCudoviste() { 
        
            SpecSposobnosti = new List<SpecSposobnost>();   
        
        }


    }
}
