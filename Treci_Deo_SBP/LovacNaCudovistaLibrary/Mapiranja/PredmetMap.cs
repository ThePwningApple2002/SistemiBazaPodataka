using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class PredmetMap : ClassMap<Predmet>
    {
        public PredmetMap() {

            Table("PREDMET");

            Id(x => x.IdPredmeta).Column("IDPREDMETA").GeneratedBy.SequenceIdentity("PredmetSeq");
            Map(x => x.TipPredmeta).Column("TIPPREDMETA");
            Map(x => x.NazivPredmeta).Column("NAZIVPREDMETA");
            Map(x => x.MaterijalPredmeta).Column("MATERIJALPREDMETA");

            HasManyToMany(x => x.ProtivmereList)
                .Table("PROTIVMERAPOSEDUJEPREDMET")
                .ParentKeyColumn("IDPRED")
                .ChildKeyColumn("IDPM")
                .Cascade.All();
           
        } 
    }
}
