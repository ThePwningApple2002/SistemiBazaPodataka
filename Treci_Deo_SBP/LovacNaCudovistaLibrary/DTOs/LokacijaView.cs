using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class LokacijaView
    {
        public virtual int IdLokacije { get; set; }

        public virtual string TipLok { get; set; }
        public virtual string NazivLok { get; set; }

        public virtual string ZemljaLok { get; set; }
        public virtual string Blago { get; set; }
        public virtual LegendaView LegendaLokacije { get; set; }

        public LokacijaView() { }
        internal LokacijaView(Lokacija p)
        {

            if(p != null) {


                IdLokacije = p.IdLokacije;
                TipLok = p.TipLok;
                NazivLok = p.NazivLok;
                ZemljaLok = p.ZemljaLok;
                Blago = p.Blago;
                LegendaLokacije = new LegendaView(p.LegendaLokacije);


            }
        }
    }
}
