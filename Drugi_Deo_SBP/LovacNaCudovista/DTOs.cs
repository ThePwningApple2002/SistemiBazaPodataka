using LovacNaCudovista.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovacNaCudovista
{
    #region Bajalica

    public class BajalicaBasic {

        public int IdBajalica { get; set; }
        public string NazivBajalica { get; set; }
        public string Zastita { get; set; }
        public string Prednost { get; set; }

        public virtual IList<CudovisteBasic> Cudovista { get; set; }

        public BajalicaBasic()
        {

            Cudovista = new List<CudovisteBasic>();

        }

        public BajalicaBasic(int IdBaj, string NazivBaj, string ZastitaBaj, string PrednostBaj){

            IdBajalica = IdBaj;
            NazivBajalica= NazivBaj;
            Zastita = ZastitaBaj;
            Prednost = PrednostBaj;


        }




    }

    public class BajalicaPregled
    {

        public int IdBajalica { get; set; }
        public string NazivBajalica { get; set; }
        public string Zastita { get; set; }
        public string Prednost { get; set; }

       

        public BajalicaPregled(int IdBaj, string NazivBaj, string ZastitaBaj, string PrednostBaj)
        {

            IdBajalica = IdBaj;
            NazivBajalica = NazivBaj;
            Zastita = ZastitaBaj;
            Prednost = PrednostBaj;


        }




    }

    #endregion

    #region Cudoviste
    public class CudovisteBasic
    {
        public virtual int IdCudovista { get; set; }
        public virtual string? NazivCud { get; set; }
        public virtual string? PodTipCud { get; set; }
        public virtual int? VekPomCud { get; set; }

        public virtual IList<PoznatiPredstavnikBasic> PoznatiPredstavnici { get; set; }

        public virtual IList<BajalicaBasic> Bajalice { get; set; }

        public virtual IList<ProtivmereBasic> ProtivmereCudovista { get; set; }

        public virtual IList<LegendaBasic> Legende { get; set; }

    

        public CudovisteBasic()
        {

            PoznatiPredstavnici = new List<PoznatiPredstavnikBasic>();
            Bajalice = new List<BajalicaBasic>();
            ProtivmereCudovista = new List<ProtivmereBasic>();
            Legende = new List<LegendaBasic>();


        }

        public CudovisteBasic(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud)
        {
            IdCudovista = idCudovista;
            NazivCud = nazivCud;
            PodTipCud = podTipCud;
            VekPomCud = vekPomCud;
        }
    }

    public class CudovistePregled
    {
        public virtual int IdCudovista { get; set; }
        public virtual string? NazivCud { get; set; }
        public virtual string? PodTipCud { get; set; }
        public virtual int? VekPomCud { get; set; }


        public CudovistePregled(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud)
        {
            IdCudovista = idCudovista;
            NazivCud = nazivCud;
            PodTipCud = podTipCud;
            VekPomCud = vekPomCud;

        }


    }

    #endregion

    #region Legenda
    public class LegendaBasic
    {
        public virtual int IdLegende { get; set; }
        public virtual string? PrvoPominjanje { get; set; }
        public virtual string? TekstLegende { get; set; }
        public virtual string? ZemljaPorekla { get; set; }
        public virtual PoznatiPredstavnikBasic LegZaPP { get; set; }

        public virtual IList<LokacijaBasic> Lokacije { get; set; }

        public virtual IList<CudovisteBasic> Cudovista { get; set; }

        public LegendaBasic()
        {

            Lokacije = new List<LokacijaBasic>();
            Cudovista = new List<CudovisteBasic>();

        }

        public LegendaBasic(int idLegende, string prvopominjanje, string tekstlegende, string zemljaporekla, PoznatiPredstavnikBasic legZaPP)
        {   
            IdLegende = idLegende;
            PrvoPominjanje = prvopominjanje;
            TekstLegende = tekstlegende;
            ZemljaPorekla = zemljaporekla;
            LegZaPP = legZaPP;
        }
    }

    public class LegendaPregled {

        public virtual int IdLegende { get; set; }
        public virtual string? PrvoPominjanje { get; set; }
        public virtual string? TekstLegende { get; set; }
        public virtual string? ZemljaPorekla { get; set; }
        public virtual PoznatiPredstavnikBasic LegZaPP { get; set; }


        public LegendaPregled(int idLegende, string prvopominjanje,
            string tekstlegende, string zemljaporekla, PoznatiPredstavnikBasic legZaPP)
        {
            IdLegende = idLegende;
            PrvoPominjanje = prvopominjanje;
            TekstLegende = tekstlegende;
            ZemljaPorekla = zemljaporekla;
            LegZaPP = legZaPP;
            
        }

    }





    #endregion

    #region Lokacija

    public class LokacijaBasic
    {
        public virtual int IdLokacije { get; set; }

        public virtual string TipLok { get; set; }
        public virtual string NazivLok { get; set; }

        public virtual string ZemljaLok { get; set; }
        public virtual string Blago { get; set; }
        public virtual LegendaBasic LegendaLokacije { get; set; }

        public virtual IList<ZastitaBasic> Zastite { get; set; }

        public virtual IList<SusretBasic> SusretiLok { get; set; }

        public LokacijaBasic(int idLokacije, string tipLok, string nazivLok, string zemljaLok, string blago, LegendaBasic legendaLokacije)
        {
            IdLokacije = idLokacije;
            TipLok = tipLok;
            NazivLok = nazivLok;
            ZemljaLok = zemljaLok;
            Blago = blago;
            LegendaLokacije = legendaLokacije;
            
        }

        public LokacijaBasic()
        {

            Zastite = new List<ZastitaBasic>();
            SusretiLok = new List<SusretBasic>();

        }

    }

    public class LokacijaPregled
    {

        public virtual int IdLokacije { get; set; }

        public virtual string TipLok { get; set; }
        public virtual string NazivLok { get; set; }

        public virtual string ZemljaLok { get; set; }
        public virtual string Blago { get; set; }
        public virtual LegendaBasic LegendaLokacije { get; set; }

        public LokacijaPregled(int idLokacije, string tipLok, string nazivLok, string zemljaLok, string blago, LegendaBasic legendaLokacije)
        {
            IdLokacije = idLokacije;
            TipLok = tipLok;
            NazivLok = nazivLok;
            ZemljaLok = zemljaLok;
            Blago = blago;
            LegendaLokacije = legendaLokacije;  
        }
    }

    #endregion

    #region Lovac



    public class LovacBasic
    {
        public virtual int IdLovca { get; set; }
        public virtual string? ImeLovca { get; set; }

        public virtual IList<SusretBasic> SusretiLovac { get; set; }

        public virtual IList<PoznatiPredstavnikBasic> PoznatiPredstavnici { get; set; }

        public LovacBasic(int idLovca, string imelovca) {

            IdLovca = idLovca;
            ImeLovca = imelovca;    
        
        }
        public LovacBasic()
        {

            SusretiLovac = new List<SusretBasic>();
            PoznatiPredstavnici = new List<PoznatiPredstavnikBasic>();
        }

    }

    public class LovacPregled
    {
        public virtual int IdLovca { get; set; }
        public virtual string? ImeLovca { get; set; }

        public LovacPregled(int idLovca, string imelovca)
        {

            IdLovca = idLovca;
            ImeLovca = imelovca;

        }
    

    }

    #endregion

    #region MagCudoviste

    public class MagCudovisteBasic : CudovisteBasic
    {

        public virtual string? Postojanje { get; set; }

        public virtual IList<MagSposobnostBasic> MagSposobnosti { get; set; }

        public MagCudovisteBasic(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud, string? postojanje)
            : base( idCudovista,  nazivCud,   podTipCud,  vekPomCud)
        {
            Postojanje = postojanje;
            
        }

        public MagCudovisteBasic()
        {

            MagSposobnosti = new List<MagSposobnostBasic>();
        }
    }
    public class MagCudovistePregled : CudovistePregled
    {

        public virtual string? Postojanje { get; set; }


        public MagCudovistePregled(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud, string? postojanje)
            : base(idCudovista, nazivCud, podTipCud, vekPomCud)
        {
            Postojanje = postojanje;

        }

   
    }

    #endregion

    #region NeMagCudoviste

    public class NeMagCudovisteBasic : CudovisteBasic
    {
        public virtual int? Visina { get; set; }
        public virtual int? Duzina { get; set; }
        public virtual string? Kandze { get; set; }
        public virtual int? BrojGlava { get; set; }
        public virtual string? ZiviUVodi { get; set; }
        public virtual string? Leti { get; set; }
        public virtual string? Otrovno { get; set; }
        public virtual int? Tezina { get; set; }

        public virtual IList<SpecSposobnostBasic> SpecSposobnosti { get; set; }

        public NeMagCudovisteBasic(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud, int? visina, int? duzina, string? kandze, int? brojGlava, string? ziviUVodi, string? leti, string? otrovno, int? tezina)
        : base(idCudovista, nazivCud, podTipCud, vekPomCud)
        {
            Visina = visina;
            Duzina = duzina;
            Kandze = kandze;
            BrojGlava = brojGlava;
            ZiviUVodi = ziviUVodi;
            Leti = leti;
            Otrovno = otrovno;
            Tezina = tezina;
        }
        public NeMagCudovisteBasic()
        {
            SpecSposobnosti = new List<SpecSposobnostBasic>();
        } 
  


    }

    public class NeMagCudovistePregled : CudovistePregled
    {
        public virtual int? Visina { get; set; }
        public virtual int? Duzina { get; set; }
        public virtual string? Kandze { get; set; }
        public virtual int? BrojGlava { get; set; }
        public virtual string? ZiviUVodi { get; set; }
        public virtual string? Leti { get; set; }
        public virtual string? Otrovno { get; set; }
        public virtual int? Tezina { get; set; }


        public NeMagCudovistePregled(int idCudovista, string? nazivCud, string? podTipCud, int? vekPomCud, int? visina, int? duzina, string? kandze, int? brojGlava, string? ziviUVodi, string? leti, string? otrovno, int? tezina)
        : base(idCudovista, nazivCud, podTipCud, vekPomCud)
        {
            Visina = visina;
            Duzina = duzina;
            Kandze = kandze;
            BrojGlava = brojGlava;
            ZiviUVodi = ziviUVodi;
            Leti = leti;
            Otrovno = otrovno;
            Tezina = tezina;
        }
    }
        #endregion

    #region MagSposobnosti 
    public class MagSposobnostBasic
    {
        public virtual int IdMagSpos { get; set; }
        public virtual string? NazivMagSpos { get; set; }
        public virtual string? OpisMagSpos { get; set; }
        public virtual string? Ofanzivna { get; set; }
        public virtual string? Defanzivna { get; set; }

        public virtual IList<MagCudovisteBasic> MagCudovista { get; set; }

        public MagSposobnostBasic(int idMagSpos, string? nazivmagspos, string? opismagspos, string? ofanzivna, string? defanzivna)
        {
                IdMagSpos = idMagSpos;
                NazivMagSpos = nazivmagspos;
                OpisMagSpos = opismagspos;
                Ofanzivna = ofanzivna;
                Defanzivna = defanzivna;
           

        }
        public MagSposobnostBasic()
        {
            MagCudovista = new List<MagCudovisteBasic>();
        }
    }
    public class MagSposobnostPregled
    {
        public virtual int IdMagSpos { get; set; }
        public virtual string? NazivMagSpos { get; set; }
        public virtual string? OpisMagSpos { get; set; }
        public virtual string? Ofanzivna { get; set; }
        public virtual string? Defanzivna { get; set; }

        
        public MagSposobnostPregled(int idMagSpos, string? nazivmagspos, string? opismagspos, string? ofanzivna, string? defanzivna)
        {
            IdMagSpos = idMagSpos;
            NazivMagSpos = nazivmagspos;
            OpisMagSpos = opismagspos;
            Ofanzivna = ofanzivna;
            Defanzivna = defanzivna;
            
        }
    }
    #endregion

    #region SpecSposobnost

    public class SpecSposobnostBasic
    {
        public virtual int IdSpecSposobnost { get; set; }

        public virtual string? NazivSpecSpos { get; set; }

        public virtual IList<NeMagCudovisteBasic> NeMagCudovista { get; set; }

        public SpecSposobnostBasic(int idSpecSposobnost, string? nazivspecspos)
        {
            IdSpecSposobnost = idSpecSposobnost;
            NazivSpecSpos = nazivspecspos;

        }
        public SpecSposobnostBasic()
        {

            NeMagCudovista = new List<NeMagCudovisteBasic>();

        }

    }
    public class SpecSposobnostPregled
    {
        public virtual int IdSpecSposobnost { get; set; }

        public virtual string? NazivSpecSpos { get; set; }


        public SpecSposobnostPregled(int idSpecSposobnost, string? nazivspecspos)
        {
            IdSpecSposobnost = idSpecSposobnost;
            NazivSpecSpos = nazivspecspos;

        }

    }

    #endregion

    #region PoznatiPredstavnik


    public class PoznatiPredstavnikBasic
    {
        public virtual int IdPozPred { get; set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual int? Starost { get; set; }
        public virtual CudovisteBasic PoznatiPredCud { get; set; }

        public virtual IList<LegendaBasic> Legende { get; set; }

        public virtual IList<SusretBasic> SusretPP { get; set; }
        public virtual IList<LovacBasic> Lovci { get; set; }

        public PoznatiPredstavnikBasic(int idPozPred, string jedime, int? starost, CudovisteBasic pozpredcud)
        {
            IdPozPred = idPozPred;
            JedinstvenoIme = jedime;
            Starost = starost;
            PoznatiPredCud = pozpredcud;
        }

        public PoznatiPredstavnikBasic()
        {
            SusretPP = new List<SusretBasic>();
            Legende = new List<LegendaBasic>();
            Lovci = new List<LovacBasic>();
        }

    }

    public class PoznatiPredstavnikPregled
    {
        public virtual int IdPozPred { get; set; }
        public virtual string JedinstvenoIme { get; set; }
        public virtual int? Starost { get; set; }
        public virtual CudovisteBasic PoznatiPredCud { get; set; }


        public PoznatiPredstavnikPregled(int idPozPred, string jedime, int? starost, CudovisteBasic pozpredcud)
        {
            IdPozPred = idPozPred;
            JedinstvenoIme = jedime;
            Starost = starost;
            PoznatiPredCud = pozpredcud;
        }

      

    }
    #endregion

    #region Protivmere
    public class ProtivmereBasic
    {
        public virtual int IdProtivmere { get; set; }
        public virtual string? NazivProtivmere { get; set; }
        public virtual string? OpisProtivmere { get; set; }

        public virtual IList<UsloviZaPrimenuBasic> Uslovi { get; set; }

        public virtual IList<PredmetBasic> Predmeti { get; set; }

        public virtual IList<CudovisteBasic> Cudovista { get; set; }

        public ProtivmereBasic(int idProtivmere, string? nazivprotivmere, string? opisprotivmere) {
        
            IdProtivmere = idProtivmere;
            NazivProtivmere = nazivprotivmere;
            OpisProtivmere = opisprotivmere;
        
        }
        public ProtivmereBasic()
        {
            Uslovi = new List<UsloviZaPrimenuBasic>();
            Predmeti = new List<PredmetBasic>();
            Cudovista = new List<CudovisteBasic>();

        }




    }

    public class ProtivmerePregled
    {

        public virtual int IdProtivmere { get; set; }
        public virtual string? NazivProtivmere { get; set; }
        public virtual string? OpisProtivmere { get; set; }



        public ProtivmerePregled(int idProtivmere, string? nazivprotivmere, string? opisprotivmere)
        {

            IdProtivmere = idProtivmere;
            NazivProtivmere = nazivprotivmere;
            OpisProtivmere = opisprotivmere;

        }








    }







    #endregion

    #region Predmet

    public class PredmetBasic
    {
        public virtual int IdPredmeta { get; set; }
        public virtual string? TipPredmeta { get; set; }
        public virtual string? NazivPredmeta { get; set; }
        public virtual string? MaterijalPredmeta { get; set; }
        public virtual IList<ProtivmereBasic> ProtivmereList { get; set; }

        public PredmetBasic(int idPredmeta, string? tipredmeta, string? nazivpredmeta, string? materijalpredmeta)
        {
            IdPredmeta = idPredmeta;
            TipPredmeta = tipredmeta;
            NazivPredmeta = tipredmeta;
            MaterijalPredmeta = materijalpredmeta;
        }
        public PredmetBasic()
        {

            ProtivmereList = new List<ProtivmereBasic>();

        }


    }
    public class PredmetPregled
    {
        public virtual int IdPredmeta { get; set; }
        public virtual string? TipPredmeta { get; set; }
        public virtual string? NazivPredmeta { get; set; }
        public virtual string? MaterijalPredmeta { get; set; }
      

        public PredmetPregled(int idPredmeta, string? tipredmeta, string? nazivpredmeta, string? materijalpredmeta)
        {
            IdPredmeta = idPredmeta;
            TipPredmeta = tipredmeta;
            NazivPredmeta = tipredmeta;
            MaterijalPredmeta = materijalpredmeta;
        }


    }


    #endregion

    #region Zastita 

    public class ZastitaBasic
    {
        public virtual int IdZastite { get; set; }
        public virtual string? TipZastite { get; set; }
        public virtual string? NazivZastite { get; set; }
        public virtual LokacijaBasic PredmetLokacija { get; set; }

        public ZastitaBasic(int idZastite, string? tipzastite, string? nazivzastite, LokacijaBasic PredmetLokacija) {

            IdZastite = idZastite;
            TipZastite = tipzastite;
            NazivZastite = nazivzastite;
            PredmetLokacija = PredmetLokacija;

        }
        public ZastitaBasic()
        {
            PredmetLokacija = new LokacijaBasic();
        }

    }

    public class ZastitaPregled
    {
        public virtual int IdZastite { get; set; }
        public virtual string? TipZastite { get; set; }
        public virtual string? NazivZastite { get; set; }
        public virtual LokacijaBasic PredmetLokacija { get; set; }
        public ZastitaPregled(int idZastite, string? tipzastite, string? nazivzastite,LokacijaBasic PredmetLokacija)
        {

            IdZastite = idZastite;
            TipZastite = tipzastite;
            NazivZastite = nazivzastite;
            PredmetLokacija = PredmetLokacija;
            

        }

    }
    #endregion

    #region Susret 

    public class SusretBasic
    {

        public virtual int IdSusret { get; set; }
        public virtual LovacBasic LovacSusrtet { get; set; }
        public virtual LokacijaBasic SusretLok { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string Ishod { get; set; }

        public virtual PoznatiPredstavnikBasic SusretPP { get; set; }
        public SusretBasic() { }

        public SusretBasic(int idsusret,LovacBasic l, LokacijaBasic l2, string vreme, string ishod, PoznatiPredstavnikBasic pp)
        {
            this.IdSusret = idsusret;
            this.LovacSusrtet = l;
            this.SusretLok = l2;
            this.Vreme = vreme;
            this.Ishod = ishod;
            this.SusretPP = pp;
        }

    }

    public class SusretPregled
    {

        public virtual int IdSusret { get; set; }
        public virtual LovacBasic LovacSusrtet { get; set; }
        public virtual LokacijaBasic SusretLok { get; set; }
        public virtual string Vreme { get; set; }
        public virtual string Ishod { get; set; }

        public virtual PoznatiPredstavnikBasic SusretPP { get; set; }

        public SusretPregled(int idsusret, LovacBasic l, LokacijaBasic l2, string vreme, string ishod, PoznatiPredstavnikBasic pp)
        {
            this.IdSusret = idsusret;
            this.LovacSusrtet = l;
            this.SusretLok = l2;
            this.Vreme = vreme;
            this.Ishod = ishod;
            this.SusretPP = pp;
        }

    }

    #endregion

    #region UsloviZaPrimenu

    public class UsloviZaPrimenuBasic
    {

        public virtual int IdUslova { get; set; }
        public virtual string Uslov { get; set; }
        public virtual ProtivmereBasic UslPM { get; set; }

        public UsloviZaPrimenuBasic()
        { }
        public UsloviZaPrimenuBasic(int iduslova, string uslov)
        {
            IdUslova = iduslova;
            Uslov = uslov;

        }



    }
    public class UsloviZaPrimenuPregled
    {

        public virtual int IdUslova { get; set; }
        public virtual string Uslov { get; set; }

        public UsloviZaPrimenuPregled()
        { }
        public UsloviZaPrimenuPregled(int iduslova, string uslov)
        {
            IdUslova = iduslova;
            Uslov = uslov;

        }



    }

    #endregion
}
