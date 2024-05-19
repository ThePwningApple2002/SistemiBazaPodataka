using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Mapiranja
{
    public class SusretMap : ClassMap<Susret>
    {

        public SusretMap() {

            Table("SUSRET");

            Id(x => x.IdSusret).Column("IDSUSRET").GeneratedBy.SequenceIdentity("SusSeq");

            Map(x => x.Vreme).Column("VREME");
            Map(x => x.Ishod).Column("ISHOD");

            References(x => x.LovacSusrtet).Column("IDLOV").LazyLoad();
            References(x => x.SusretPP).Column("IDPP").LazyLoad();
            References(x => x.SusretLok).Column("IDLOK").LazyLoad();



        }  
    }
}
