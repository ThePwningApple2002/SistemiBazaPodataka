using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Protivmere
    {
        public virtual int IdProtivmere { get; set; }
        public virtual string? NazivProtivmere { get; set; }
        public virtual string? OpisProtivmere { get; set; }

        public virtual IList<UsloviZaPrimenu> Uslovi {  get; set; }

        public virtual IList<Predmet> Predmeti { get; set; }

        public virtual IList<Cudoviste> Cudovista { get; set; }


        public Protivmere() {
            Uslovi = new List<UsloviZaPrimenu>();
            Predmeti = new List<Predmet>();
            Cudovista = new List<Cudoviste>();

        }
        


        
    }
}
