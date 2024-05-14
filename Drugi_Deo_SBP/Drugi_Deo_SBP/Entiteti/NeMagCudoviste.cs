using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class NeMagCudoviste
    {
        public virtual int IdCudovista { get; set; }
        public virtual int Visina { get; set; }
        public virtual int Duzina { get; set; }
        public virtual string Kandze { get; set; }
        public virtual int BrojGlava { get; set; }
        public virtual string ZiviUVodi { get; set; }
        public virtual string Leti { get; set; }
        public virtual string Otrovno { get; set; }
        public virtual int Tezina { get; set; }
        public virtual Cudoviste Cudoviste { get; set; }

    }
}
