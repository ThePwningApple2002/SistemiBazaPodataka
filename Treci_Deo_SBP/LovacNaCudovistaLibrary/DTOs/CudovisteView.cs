using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class CudovisteView
    {

        public virtual int IdCudovista { get; set; }
        public virtual string? NazivCud { get; set; }
        public virtual string? PodTipCud { get; set; }
        public virtual int? VekPomCud { get; set; }

        public CudovisteView() { }

        internal CudovisteView(Cudoviste? p)
        {

            if(p != null)
            {

                IdCudovista = p.IdCudovista;
                NazivCud = p.NazivCud;
                PodTipCud = p.PodTipCud;
                VekPomCud = p.VekPomCud;



            }

        }

    }
}
