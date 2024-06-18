using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class ZastitaView
    {
        public virtual int IdZastite { get; set; }
        public virtual string? TipZastite { get; set; }
        public virtual string? NazivZastite { get; set; }
        public virtual LokacijaView PredmetLokacija { get; set; }

        public ZastitaView(Zastita? p)
        {
            if (p != null)
            {
                IdZastite = p.IdZastite;
                TipZastite = p.TipZastite;
                NazivZastite = p.NazivZastite;
                PredmetLokacija = new LokacijaView(p.PredmetLokacija);




            }

        }
        public ZastitaView()
        {
            
        }
    }
}
