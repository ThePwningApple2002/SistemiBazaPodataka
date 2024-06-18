using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class UsloviZaPrimenu
    {

        public virtual int IdUslova { get; set; }
        public virtual string Uslov { get; set; }
        public virtual Protivmere UslPM { get; set; }
    }
}
