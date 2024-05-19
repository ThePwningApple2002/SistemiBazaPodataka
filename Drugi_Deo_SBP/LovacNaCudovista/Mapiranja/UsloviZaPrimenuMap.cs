using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class UsloviZaPrimenuMap : ClassMap<UsloviZaPrimenu>
    {

        public UsloviZaPrimenuMap()
        {
            Table("USLOVIZAPRIMENU");

            Id(x => x.IdUslova).Column("IDUSLOVA").GeneratedBy.SequenceIdentity("USZSeq");

            Map(x => x.Uslov).Column("USLOV");

            References(x => x.UslPM).Column("IDPROTIVM").LazyLoad();


        }
    }
}
