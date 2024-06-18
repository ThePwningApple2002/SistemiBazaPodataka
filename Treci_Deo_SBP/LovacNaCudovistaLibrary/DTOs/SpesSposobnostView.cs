using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class SpesSposobnostView
    {
        public virtual int IdSpecSposobnost { get; set; }

        public virtual string? NazivSpecSpos { get; set; }

        public virtual IList<NeMagCudovisteView> NeMagCudovista { get; set; }

        internal SpesSposobnostView(SpecSposobnost p)
        {

            if( p != null)
            {

                IdSpecSposobnost = p.IdSpecSposobnost;
                NazivSpecSpos = p.NazivSpecSpos;


            }

        }
        public SpesSposobnostView()
        {

            NeMagCudovista = new List<NeMagCudovisteView>();

        }
    }
}
