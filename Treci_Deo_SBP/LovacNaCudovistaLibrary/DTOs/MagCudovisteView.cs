using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class MagCudovisteView : CudovisteView
    {
        public virtual string? Postojanje { get; set; }

        public virtual IList<MagSposobnostView> MagSposobnosti { get; set; }

        internal MagCudovisteView(MagCudoviste? p )
            : base(p)
        {
            if( MagSposobnosti != null)
            {
                Postojanje = p.Postojanje;
            }
            

        }

        public MagCudovisteView()
        {

            MagSposobnosti = new List<MagSposobnostView>();
        }
    }
}
