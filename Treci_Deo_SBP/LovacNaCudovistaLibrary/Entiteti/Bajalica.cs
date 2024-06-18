using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista.Entiteti
{
    public class Bajalica
    {
        public virtual int IdBajalice { get; set; }
        public virtual string NazivBajalice { get; set; }
        public virtual string Zastita { get; set; }
        public virtual string Prednost { get; set; }

        public virtual IList<Cudoviste> Cudovista {  get; set; }
        
        public Bajalica() { 
            
            Cudovista = new List<Cudoviste>();
        
        }
    }
}
