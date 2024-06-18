using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class MagSposobnost
    {
        public virtual int IdMagSpos { get; set; }
        public virtual string? NazivMagSpos { get; set; }
        public virtual string? OpisMagSpos { get; set; }
        public virtual string? Ofanzivna { get; set; }
        public virtual string? Defanzivna { get; set; }

        public virtual IList<MagCudoviste> MagCudovista { get; set; }

        public MagSposobnost()
        {
            MagCudovista = new List<MagCudoviste>();
        }
    }
}
