using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Repository.Data.Helper
{
    //public class HUB_IMPORT
    //{
    //   public string Datoteka { get; set; }
    //   public  int Godina { get; set; }
    //   public  int Mjesec { get; set; }
    //   public  DateTime Datum { get; set; }
    //   public int? IDHUBNamjena2013A { get; set; }
    //   public int? BrojUgovorMin { get; set; }
    //   public int? BrojUgovorMax { get; set; }
    //}

    public class HUB_IMPORT
    {
        public int Godina { get; set; }
        public int Mjesec { get; set; }
        public int? BrojUgovorMin { get; set; }
        public int? BrojUgovorMax { get; set; }
        public int? IDHUBNamjena2013A { get; set; }
        public string Datoteka { get; set; }

    }


    public class RANDOM_TEST
    {
        public int Mjesec { get; set; }
        public int Godina { get; set; }
        public string Server { get; set; }
        public string Baza { get; set; }
        public int Take { get; set; }
        public int Stupaca { get; set; }
        public List<int> KojiUgovori { get; set; }
        public string Poruka { get; set; }

    }

    public class Labela
    {
        public String BankaVBDI { get; set; }
        public String BankaNaziv { get; set; }
        public String BankaOIB { get; set; }
        public string DatumObrada { get; set; }
        public string RacunPojedinacnoUcitavanje{ get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string kojaPoslovaGodina { get; set; }

        public Labela(dynamic item)
        {
            this.BankaVBDI = item.BankaVBDI;
            this.BankaNaziv = item.BankaNaziv;
            this.BankaOIB = item.BankaOIB;
            this.DatumObrada = item.DatumObrada;
            this.RacunPojedinacnoUcitavanje = item.RacunPojedinacnoUcitavanje;
            this.DatumOd = item.DatumOd;
            this.DatumDo = item.DatumDo;
            this.kojaPoslovaGodina = item.kojaPoslovaGodina;
        }
    }

    public class Glava
    {
        public String VodeciBrojBanke;
        public String BICrojBanke;
        public String TransakcijskiRacunKlijenta;
        public String ValutaTransakcijskogRacuna;
        public String NazivKlijenta;
        public String SjedisteKlijenta;
        public String MaticniBroj;
        public String OIBKlijenta;
        public String RedniBrojIzvadka;
        public String PodbrojIzvadka;
        public String DatumIzvadka;
        public String RedniBrojGrupePaketa;
        public String VrstaIzvadka;
        public String Rezerva;
        public String TipSloga;

        public Glava() { }

        public Glava(dynamic item)
    	{
    	    this.VodeciBrojBanke = item.VodeciBrojBanke;
            this.BICrojBanke = item.BICrojBanke;
            this.TransakcijskiRacunKlijenta = item.TransakcijskiRacunKlijenta;
            this.ValutaTransakcijskogRacuna = item.ValutaTransakcijskogRacuna;
            this.NazivKlijenta = item.NazivKlijenta;
            this.SjedisteKlijenta = item.SjedisteKlijenta;
            this.MaticniBroj = item.MaticniBroj;
            this.OIBKlijenta = item.OIBKlijenta;
            this.RedniBrojIzvadka = item.RedniBrojIzvadka;
            this.PodbrojIzvadka = item.PodbrojIzvadka;
            this.DatumIzvadka = item.DatumIzvadka;
            this.RedniBrojGrupePaketa = item.RedniBrojGrupePaketa;
            this.VrstaIzvadka = item.VrstaIzvadka;
            this.Rezerva = item.Rezerva;
            this.TipSloga = item.TipSloga; 

    	}
    }

    public class Stavka
    {
        public String ID_Izvod;
        public String ID_IzvodSt;
        public String OznakaTransakcije;
        public String RacunPrPl;
        public String NazivPrPl;
        public String AdresaPrPl;
        public String SjedistePrPl;
        public String DatumValuta;
        public String DatumIzvrsenje;
        public String ValutaPokrice;
        public String Tecaj;
        public String PredznakValuta;
        public String IznosValutaPokrice;
        public String Predznak;
        public String Iznos;
        public String PozivNaBrojPlatitelja;
        public String PozivNaBrojPrimatelja;
        public String SifraNamjene;
        public String OpisPlacanje;
        public String IdentifikatorTransakcijeFINA;
        public String IdentifikatorTransakcije;
        public String Rezerva;
        public String TipSloga;

        public Stavka() { }

        public Stavka (dynamic item)
        {
            this.ID_Izvod = item.ID_Izvod;
            this.OznakaTransakcije = item.OznakaTransakcije;
            this.RacunPrPl = item.RacunPrPl;
            this.NazivPrPl = item.NazivPrPl;
            this.AdresaPrPl = item.AdresaPrPl;
            this.SjedistePrPl = item.SjedistePrPl;
            this.DatumValuta = item.DatumValuta;
            this.DatumIzvrsenje = item.DatumIzvrsenje;
            this.ValutaPokrice = item.ValutaPokrice;
            this.Tecaj = item.Tecaj;
            this.PredznakValuta = item.PredznakValuta;
            this.IznosValutaPokrice = item.IznosValutaPokrice;
            this.Predznak = item.Predznak;
            this.Iznos = item.Iznos;
            this.PozivNaBrojPlatitelja = item.PozivNaBrojPlatitelja;
            this.PozivNaBrojPrimatelja = item.PozivNaBrojPrimatelja;
            this.SifraNamjene = item.SifraNamjene;
            this.OpisPlacanje = item.OpisPlacanje;
            this.IdentifikatorTransakcijeFINA = item.IdentifikatorTransakcijeFINA;
            this.IdentifikatorTransakcije = item.IdentifikatorTransakcije;
            this.Rezerva = item.Rezerva;
            this.TipSloga = item.TipSloga;
        }

    }

   
}
