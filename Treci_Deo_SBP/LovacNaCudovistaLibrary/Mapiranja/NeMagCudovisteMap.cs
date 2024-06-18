using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class NeMagCudovisteMap : SubclassMap<NeMagCudoviste>
    {
        public NeMagCudovisteMap()
        {
            Table("NEMAGCUDOVISTE");

            KeyColumn("IDCUDOVISTA");

            Map(x => x.Visina).Column("VISINA");
            Map(x => x.Duzina).Column("DUZINA");
            Map(x => x.Kandze).Column("KANDZE");
            Map(x => x.BrojGlava).Column("BROJGLAVA");
            Map(x => x.ZiviUVodi).Column("ZIVIUVODI");
            Map(x => x.Leti).Column("LETI");
            Map(x => x.Otrovno).Column("OTROVNO");
            Map(x => x.Tezina).Column("TEZINA");

            HasManyToMany(x => x.SpecSposobnosti)
                .Table("CUDIMASPECSPOS")
                .ParentKeyColumn("IDCUD")
                .ChildKeyColumn("IDSPECIJALNASPOS")
                .Cascade.All()
                .Inverse();




        }
    }
}
