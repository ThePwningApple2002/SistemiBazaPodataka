using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class SpecSposobnostView
    {
        public virtual int IdSpecSposobnost { get; set; }

        public virtual string? NazivSpecSpos { get; set; }

        public virtual IList<NeMagCudovisteView> NeMagCudovista { get; set; }

        internal SpecSposobnostView(SpecSposobnost? p)
        {

            if( p != null)
            {

                IdSpecSposobnost = p.IdSpecSposobnost;
                NazivSpecSpos = p.NazivSpecSpos;


            }

        }
        public SpecSposobnostView()
        {

            NeMagCudovista = new List<NeMagCudovisteView>();

        }
    }
}
