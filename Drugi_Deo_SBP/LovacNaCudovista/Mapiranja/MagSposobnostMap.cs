using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class MagSposobnostMap : ClassMap<MagSposobnost>
    {

        public MagSposobnostMap() {

            Table("MAGSPOSOBNOST");

            Id(x => x.IdMagSpos).Column("IDMAGSPOS").GeneratedBy.SequenceIdentity("MSSeq");

            Map(x => x.NazivMagSpos).Column("NAZIVMAGSPOS");
            Map(x => x.OpisMagSpos).Column("OPISMAGSPOS");
            Map(x => x.Ofanzivna).Column("OFANZIVNA");
            Map(x => x.Defanzivna).Column("DEFANZIVNA");


            HasManyToMany(x => x.MagCudovista)
                .Table("CUDIMAMAGSPOS")
                .ParentKeyColumn("IDMAGICNASPOS")
                .ChildKeyColumn("IDCUD")
                .Cascade.All();


        }
    }
}
