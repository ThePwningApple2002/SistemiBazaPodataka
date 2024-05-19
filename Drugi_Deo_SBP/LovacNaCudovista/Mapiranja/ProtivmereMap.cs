using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class ProtivmereMap : ClassMap<Protivmere>
    {
        public ProtivmereMap()
        {
            Table("PROTIVMERE");

            Id(x => x.IdProtivmere).Column("IDPROTIVMERE").GeneratedBy.SequenceIdentity("ProtivmereSeq");

            Map(x => x.NazivProtivmere).Column("NAZIVPROTIVMERE").Nullable();
            Map(x => x.OpisProtivmere).Column("OPISPROTIVMERE").Nullable();
            
            HasManyToMany(x => x.Predmeti)
                .Table("PROTIVMERAPOSEDUJEPREDMET")
                .ParentKeyColumn("IDPM")
                .ChildKeyColumn("IDPRED")
                .Cascade.All()
                .Inverse();

            HasManyToMany(x => x.Cudovista)
                .Table("PROTIVCUD")
                .ParentKeyColumn("IDPM")
                .ChildKeyColumn("IDCUD")
                .Cascade.All();

        }
    }
}
