

namespace LovacNaCudovista.Mapiranja
{
    public class LegendaMap : ClassMap<Legenda>
    {

        public LegendaMap() {

            Table("LEGENDA");

            Id(x => x.IdLegende).Column("IDLEGENDE").GeneratedBy.SequenceIdentity("LegendaSeq");

            Map(x => x.PrvoPominjanje).Column("PRVOPOMINJANJE");
            Map(x => x.TekstLegende).Column("TEKSTLEGENDE");
            Map(x => x.ZemljaPorekla).Column("ZEMLJAPOREKLA");

            References(x => x.LegZaPP).Column("IDPP").LazyLoad();

            HasMany(x => x.Lokacije).KeyColumn("IDLEG").Cascade.All().Inverse();

            HasManyToMany(x => x.Cudovista)
                .Table("POSTOJILEGENDA")
                .ParentKeyColumn("IDLEG")
                .ChildKeyColumn("IDCUD")
                .Cascade.All();



        }
    }
}
