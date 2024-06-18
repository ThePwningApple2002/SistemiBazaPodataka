
namespace LovacNaCudovista.Entiteti
{
    public class Zastita
    {
        public virtual int IdZastite { get; set; }
        public virtual string? TipZastite { get; set; }
        public virtual string? NazivZastite { get; set; }
        public virtual Lokacija PredmetLokacija { get; set; }

        public Zastita() { }

    }
}
