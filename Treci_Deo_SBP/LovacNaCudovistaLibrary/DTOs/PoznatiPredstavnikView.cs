using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class PoznatiPredstavnikView
    {

        public virtual int IdPozPred { get; set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual int? Starost { get; set; }
        public virtual CudovisteView PoznatiPredCud { get; set; }

        public virtual IList<LegendaView> Legende { get; set; }

        public virtual IList<SusretView> SusretPP { get; set; }
        public virtual IList<LovacView> Lovci { get; set; }

        public PoznatiPredstavnikView(PoznatiPredstavnik p)

            
        {
            if( p != null)
            {


                IdPozPred = p.IdPozPred;
                JedinstvenoIme = p.JedinstvenoIme;
                Starost = p.Starost;
                PoznatiPredCud = new CudovisteView(p.PoznatiPredCud);


            }
        }

        public PoznatiPredstavnikView()
        {
            SusretPP = new List<SusretView>();
            Legende = new List<LegendaView>();
            Lovci = new List<LovacView>();
        }
    }
}
