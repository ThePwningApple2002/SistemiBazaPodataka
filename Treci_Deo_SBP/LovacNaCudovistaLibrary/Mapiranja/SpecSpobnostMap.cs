using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class SpecSpobnostMap : ClassMap<SpecSposobnost>
    {

        public SpecSpobnostMap()
        {

            Table("SPECSPOSOBNOST");

            Id(x => x.IdSpecSposobnost).Column("IDSPECSPOS").GeneratedBy.SequenceIdentity("SSSeq");

            Map(x => x.NazivSpecSpos).Column("NAZIVSPECSPOS");


            HasManyToMany(x => x.NeMagCudovista)
                .Table("CUDIMASPECSPOS")
                .ParentKeyColumn("IDSPECIJALNASPOS")
                .ChildKeyColumn("IDCUD")
                .Cascade.All();
        }
    }
}
