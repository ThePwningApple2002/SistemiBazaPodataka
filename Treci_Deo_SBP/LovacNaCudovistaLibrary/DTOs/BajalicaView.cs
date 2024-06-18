using LovacNaCudovista.Mapiranja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class BajalicaView
    {

        public int IdBajalica { get; set; }
        public string NazivBajalica { get; set; }
        public string Zastita { get; set; }
        public string Prednost { get; set; }

        public BajalicaView() { }

        internal BajalicaView(Bajalica? p)
        {


            if(p != null)
            {
                IdBajalica = p.IdBajalice;
                NazivBajalica = p.NazivBajalice;
                Zastita = p.Zastita;
                Prednost = p.Prednost;

            }
            


        }
    }
}
