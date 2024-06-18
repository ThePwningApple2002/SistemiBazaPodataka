using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class LegendaView
    {
       

        public virtual int IdLegende { get; set; }
        public virtual string? PrvoPominjanje { get; set; }
        public virtual string? TekstLegende { get; set; }
        public virtual string? ZemljaPorekla { get; set; }
        public virtual PoznatiPredstavnikView LegZaPP { get; set; }

        public LegendaView() { }    
        internal LegendaView(Legenda? p)
        {
            if(p != null)
            { 
                IdLegende = p.IdLegende;
                PrvoPominjanje = p.PrvoPominjanje;
                TekstLegende = p.TekstLegende; 
                ZemljaPorekla = p.ZemljaPorekla;
                LegZaPP = new PoznatiPredstavnikView(p.LegZaPP);
            }

        }

    }
}
