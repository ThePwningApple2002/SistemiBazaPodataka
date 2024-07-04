using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class MagSposobnostView
    {
        public virtual int IdMagSpos { get; set; }
        public virtual string? NazivMagSpos { get; set; }
        public virtual string? OpisMagSpos { get; set; }
        public virtual string? Ofanzivna { get; set; }
        public virtual string? Defanzivna { get; set; }

        public virtual IList<MagCudovisteView> MagCudovista { get; set; }

        internal MagSposobnostView(MagSposobnost? p)
        {

            if (p != null)
            {
                IdMagSpos = p.IdMagSpos;
                NazivMagSpos = p.NazivMagSpos;
                OpisMagSpos = p.OpisMagSpos;
                Ofanzivna = p.Ofanzivna;
                Defanzivna = p.Defanzivna;



            }
       


        }
        public MagSposobnostView()
        {
            MagCudovista = new List<MagCudovisteView>();
        }

    }
}
