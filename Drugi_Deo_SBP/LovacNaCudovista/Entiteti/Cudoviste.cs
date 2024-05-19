using LovacNaCudovista.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Cudoviste
    {
        public virtual int IdCudovista { get; set; }
        public virtual string? NazivCud { get; set; }
        public virtual string? PodTipCud { get; set; }
        public virtual int ?VekPomCud { get; set; }

        public virtual IList<PoznatiPredstavnik> PoznatiPredstavnici { get; set; }

        public virtual IList<Bajalica> Bajalice {  get; set; }

        public virtual IList<Protivmere> ProtivmereCudovista { get; set; }

        public virtual IList<Legenda> Legende {  get; set; }

        public Cudoviste() {

            PoznatiPredstavnici = new List<PoznatiPredstavnik>();
            Bajalice = new List<Bajalica>();
            ProtivmereCudovista = new List<Protivmere>();
            Legende = new List<Legenda>();


        }

    }

}
