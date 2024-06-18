using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LovacNaCudovista.Entiteti;

namespace LovacNaCudovista.Mapiranja
{
    public class BajalicaMap : ClassMap<Bajalica>
    {

        public BajalicaMap()
        {

            Table("BAJALICA");


            Id(x => x.IdBajalice).Column("IDBAJALICE").GeneratedBy.Sequence("BajalicaSeq");

            Map(x => x.NazivBajalice).Column("NAZIVBAJALICE");
            Map(x => x.Zastita).Column("ZASTITA");
            Map(x => x.Prednost).Column("PREDNOST");

            HasManyToMany(x => x.Cudovista)
                .Table("BAJALICAPROTIVMAGCUD")
                .ParentKeyColumn("IDCUD")
                .ChildKeyColumn("IDBAJ")
                .Cascade.All();


        }
        


    }
}
