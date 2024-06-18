using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class ZastitaMap : ClassMap<Zastita>
    {

        public ZastitaMap() {

            Table("ZASTITA");

            Id(x => x.IdZastite).Column("IDZASTITE").GeneratedBy.SequenceIdentity("ZasSeq");

            Map(x => x.TipZastite).Column("TIPZASTITE");
            Map(x => x.NazivZastite).Column("NAZIVZASTITE");

            References(x => x.PredmetLokacija).Column("IDLOK").LazyLoad();



        }



    }
}
