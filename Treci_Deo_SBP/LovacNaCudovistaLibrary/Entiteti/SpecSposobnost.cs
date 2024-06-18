using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class SpecSposobnost
    {
        public virtual int IdSpecSposobnost { get; set; }

        public virtual string? NazivSpecSpos { get; set; }

        public virtual IList<NeMagCudoviste> NeMagCudovista { get; set; }

        public SpecSposobnost() { 
        
            NeMagCudovista = new List<NeMagCudoviste>();
        
        }

    }
}
