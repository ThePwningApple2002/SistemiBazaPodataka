
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class CudovisteMap : ClassMap <Cudoviste>
    {
        public CudovisteMap() {

            Table("CUDOVISTE");

            Id(x => x.IdCudovista).Column("IDCUDOVISTA").GeneratedBy.SequenceIdentity("CudovisteSeq");

            Map(x => x.NazivCud).Column("NAZIVCUD").Nullable();
            Map(x => x.PodTipCud).Column("PODTIPCUD").Nullable();
            Map(x => x.VekPomCud).Column("VEKPOMCUD").Nullable();

            HasMany(x => x.PoznatiPredstavnici).KeyColumn("IDCUD").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Bajalice)
                .Table("BAJALICAPROTIVMAGCUD")
                .ParentKeyColumn("IDBAJ")
                .ChildKeyColumn("IDCUD")
                .Cascade.All()
                .Inverse();

            HasManyToMany(x => x.ProtivmereCudovista)
                .Table("PROTIVCUD")
                .ParentKeyColumn("IDCUD")
                .ChildKeyColumn("IDPM")
                .Cascade.All()
                .Inverse();

            HasManyToMany(x => x.Legende)
                .Table("POSTOJILEGENDA")
                .ParentKeyColumn("IDCUD")
                .ChildKeyColumn("IDLEG")
                .Cascade.All()
                .Inverse();

        }


    }
}
