
namespace LovacNaCudovista.Entiteti
{
    public class Susret
    {

        public virtual int IdSusret { get; set; }
        public virtual Lovac LovacSusrtet {  get; set; }
        public virtual Lokacija SusretLok { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string Ishod {  get; set; }

        public virtual PoznatiPredstavnik SusretPP { get; set; }

    }

}
