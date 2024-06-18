using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class MagCudovisteMap : SubclassMap<MagCudoviste>
    {
        public MagCudovisteMap() {

            Table("MAGCUDOVISTE");

            KeyColumn("IDCUDOVISTA");

            Map(x => x.Postojanje).Column("POSTOJANJE");

            HasManyToMany(x => x.MagSposobnosti)
                .Table("CUDIMAMAGSPOS")
                .ParentKeyColumn("IDCUD")
                .ChildKeyColumn("IDMAGICNASPOS")
                .Cascade.All()
                .Inverse();
        }
    }
}
