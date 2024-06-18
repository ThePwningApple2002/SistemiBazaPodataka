using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class SusretView
    {
        public virtual int IdSusret { get; set; }
        public virtual LovacView LovacSusrtet { get; set; }
        public virtual LokacijaView SusretLok { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string Ishod { get; set; }

        public virtual PoznatiPredstavnikView SusretPP { get; set; }
        public SusretView() { }

        public SusretView(Susret p)
        {
            if(p != null)
            {

                IdSusret = p.IdSusret;
                LovacSusrtet = new LovacView(p.LovacSusrtet);
                SusretLok = new LokacijaView(p.SusretLok);
                Vreme = p.Vreme;
                Ishod = p.Ishod;
                SusretPP = new PoznatiPredstavnikView(p.SusretPP);

            }
            
        }
    }
}
