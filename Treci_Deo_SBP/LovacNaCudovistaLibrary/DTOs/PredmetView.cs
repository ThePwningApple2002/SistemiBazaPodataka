using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class PredmetView
    {

        public virtual int IdPredmeta { get; set; }
        public virtual string? TipPredmeta { get; set; }
        public virtual string? NazivPredmeta { get; set; }
        public virtual string? MaterijalPredmeta { get; set; }
        public virtual IList<ProtivmereView> ProtivmereList { get; set; }

        internal PredmetView(Predmet p)
        {
            if(p != null)
            {

                IdPredmeta = p.IdPredmeta;
                TipPredmeta = p.TipPredmeta;
                NazivPredmeta = p.NazivPredmeta;
                MaterijalPredmeta = p.MaterijalPredmeta;
            }
        }
        public PredmetView()
        {

            ProtivmereList = new List<ProtivmereView>();

        }
    }
}
