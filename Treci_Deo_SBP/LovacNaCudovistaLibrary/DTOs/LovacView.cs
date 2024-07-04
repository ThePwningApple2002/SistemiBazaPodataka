using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class LovacView
    {
        public virtual int IdLovca { get; set; }
        public virtual string? ImeLovca { get; set; }
        public virtual IList<SusretView>? SusretiLovac { get; set; }
        public virtual IList<PoznatiPredstavnikView>? PoznatiPredstavnici { get; set; }
        public LovacView()
        {

            SusretiLovac = new List<SusretView>();
            PoznatiPredstavnici = new List<PoznatiPredstavnikView>();
        }
        internal LovacView(Lovac? p) 
        {
            if (p != null) {
                IdLovca = p.IdLovca;
                ImeLovca = p.ImeLovca;
            }
            

        }
    }
}
