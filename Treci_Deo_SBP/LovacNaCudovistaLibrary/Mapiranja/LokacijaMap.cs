using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class LokacijaMap : ClassMap<Lokacija>
    {

        public LokacijaMap()
        {
            Table("LOKACIJA");

            Id(x => x.IdLokacije).Column("IDLOKACIJE").GeneratedBy.SequenceIdentity("LokSeq");

            Map(x => x.TipLok).Column("TIPLOK");
            Map(x => x.NazivLok).Column("NAZIVLOK");
            Map(x => x.ZemljaLok).Column("ZEMLJALOK");
            Map(x => x.Blago).Column("BLAGO");

            References(x => x.LegendaLokacije).Column("IDLEG").LazyLoad();

            HasMany(x => x.Zastite).KeyColumn("IDLOK").Cascade.All().Inverse();
            HasMany(x => x.SusretiLok).KeyColumn("IDLOK").Cascade.All().Inverse();
        }
    }
}
