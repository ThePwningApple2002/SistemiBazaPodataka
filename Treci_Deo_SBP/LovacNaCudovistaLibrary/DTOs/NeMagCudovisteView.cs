using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class NeMagCudovisteView : CudovisteView
    {
        public virtual int? Visina { get; set; }
        public virtual int? Duzina { get; set; }
        public virtual string? Kandze { get; set; }
        public virtual int? BrojGlava { get; set; }
        public virtual string? ZiviUVodi { get; set; }
        public virtual string? Leti { get; set; }
        public virtual string? Otrovno { get; set; }
        public virtual int? Tezina { get; set; }

        public virtual IList<SpecSposobnostView> SpecSposobnosti { get; set; }

        internal NeMagCudovisteView(NeMagCudoviste p)
        : base(p)
        {

            if(p != null)
            {

                Visina = p.Visina;
                Duzina = p.Duzina;
                Kandze = p.Kandze;
                BrojGlava = p.BrojGlava;
                ZiviUVodi = p.ZiviUVodi;
                Leti = p.Leti;
                Otrovno = p.Otrovno;
                Tezina = p.Tezina;


            }
            
        }
        public NeMagCudovisteView()
        {
            SpecSposobnosti = new List<SpecSposobnostView>();
        }
    }
}
