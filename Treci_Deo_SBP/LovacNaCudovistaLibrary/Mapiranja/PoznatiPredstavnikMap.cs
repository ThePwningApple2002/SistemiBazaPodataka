using LovacNaCudovista.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class PoznatiPredstavnikMap : ClassMap<PoznatiPredstavnik>
    {
        public PoznatiPredstavnikMap()
        {
            Table("POZNATIPREDSTAVNIK");

            Id(x => x.IdPozPred).Column("IDPOZPRED").GeneratedBy.Sequence("PozPredSeq");

            Map(x => x.JedinstvenoIme).Column("JEDINSTVENOIME");
            Map(x => x.Starost).Column("STAROST");

            References(x => x.PoznatiPredCud).Column("IDCUD").LazyLoad();


            HasMany(x => x.Legende).KeyColumn("IDPP").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.SusretPP).KeyColumn("IDPP").Cascade.All().Inverse();

            HasManyToMany(x => x.Lovci)
                .Table("LOVACTRAGAPOZNATIMPRED")
                .ParentKeyColumn("IDPP")
                .ChildKeyColumn("IDLOV")
                .Cascade.All();

        }
    }
}
