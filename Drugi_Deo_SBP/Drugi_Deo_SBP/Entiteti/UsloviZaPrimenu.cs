using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_Deo_SBP.Entiteti
{
    public class UsloviZaPrimenu
    {
        public virtual int IdUslova { get; set; }
        public virtual string Uslov { get; set; }
        public virtual int IdProtivM { get; set; }

    }
}
