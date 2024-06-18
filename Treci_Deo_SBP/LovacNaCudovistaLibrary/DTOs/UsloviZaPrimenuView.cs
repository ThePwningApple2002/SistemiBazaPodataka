using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovistaLibrary.DTOs
{
    public class UsloviZaPrimenuView
    {

        public virtual int IdUslova { get; set; }
        public virtual string Uslov { get; set; }
        public virtual ProtivmereView UslPM { get; set; }

        public UsloviZaPrimenuView()
        { }
        public UsloviZaPrimenuView(UsloviZaPrimenu p)
        {
            if(p != null)
            {
                IdUslova = p.IdUslova;
                Uslov = p.Uslov;
                UslPM = new ProtivmereView(p.UslPM);


            }
            

        }
    }
}
