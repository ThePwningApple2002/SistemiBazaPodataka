using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class LovacMap : ClassMap<Lovac>
    {
        public LovacMap() {

            Table("LOVAC");

            Id(x => x.IdLovca).Column("IDLOVCA").GeneratedBy.SequenceIdentity("LovacSeq");
            Map(x => x.ImeLovca).Column("IMELOVCA").Nullable();

            HasMany(x => x.SusretiLovac).KeyColumn("IDLOV").Cascade.All().Inverse();

            HasManyToMany(x => x.PoznatiPredstavnici)
                .Table("LOVACTRAGAPOZNATIMPRED")
                .ParentKeyColumn("IDLOV")
                .ChildKeyColumn("IDPP")
                .Cascade.All()
                .Inverse();



        }   
    }
}
