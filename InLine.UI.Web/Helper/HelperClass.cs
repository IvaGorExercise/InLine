using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;

namespace InLine.UI.Web.Helper
{
    public static class Izvod
    {
        public class Labela
        {
            public String BankaVBDI { get; set; }
            public String BankaNaziv { get; set; }
            public String BankaOIB { get; set; }
            public string DatumObrada { get; set; }
            public string RacunPojedinacnoUcitavanje { get; set; }
            public DateTime DatumOd { get; set; }
            public DateTime DatumDo { get; set; }
            public string kojaPoslovaGodina { get; set; }
            public String RacunGlobal { get; set; }
        }


        [FixedLengthRecord(FixedMode.AllowMoreChars)]
        public class Glava
        {
            [FieldOptional()]
            [FieldFixedLength(7)]
            public String VodeciBrojBanke;

            [FieldOptional()]
            [FieldFixedLength(11)]
            public String BICrojBanke;

            [FieldOptional()]
            [FieldFixedLength(21)]
            public String TransakcijskiRacunKlijenta;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String ValutaTransakcijskogRacuna;


            [FieldOptional()]
            [FieldFixedLength(70)]
            public String NazivKlijenta;

            [FieldOptional()]
            [FieldFixedLength(35)]
            public String SjedisteKlijenta;

            [FieldOptional()]
            [FieldFixedLength(8)]
            public String MaticniBroj;

            [FieldOptional()]
            [FieldFixedLength(11)]
            public String OIBKlijenta;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String RedniBrojIzvadka;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String PodbrojIzvadka;

            [FieldOptional()]
            [FieldFixedLength(8)]
            public String DatumIzvadka;

            [FieldOptional()]
            [FieldFixedLength(4)]
            public String RedniBrojGrupePaketa;

            [FieldOptional()]
            [FieldFixedLength(4)]
            public String VrstaIzvadka;

            [FieldOptional()]
            [FieldFixedLength(809)]
            public String Rezerva;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String TipSloga;
        }

        [FixedLengthRecord(FixedMode.AllowMoreChars)]
        public class Stavka
        {
            [FieldOptional()]
            [FieldFixedLength(2)]
            public String OznakaTransakcije;

            [FieldOptional()]
            [FieldFixedLength(34)]
            public String RacunPrPl;

            [FieldOptional()]
            [FieldFixedLength(70)]
            public String NazivPrPl;

            [FieldOptional()]
            [FieldFixedLength(35)]
            public String AdresaPrPl;

            [FieldOptional()]
            [FieldFixedLength(35)]
            public String SjedistePrPl;

            [FieldOptional()]
            [FieldFixedLength(8)]
            public String DatumValuta;

            [FieldOptional()]
            [FieldFixedLength(8)]
            public String DatumIzvrsenje;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String ValutaPokrice;

            [FieldOptional()]
            [FieldFixedLength(15)]
            public String Tecaj;

            [FieldOptional()]
            [FieldFixedLength(1)]
            public String PredznakValuta;

            [FieldOptional()]
            [FieldFixedLength(15)]
            public String IznosValutaPokrice;

            [FieldOptional()]
            [FieldFixedLength(1)]
            public String Predznak;

            [FieldOptional()]
            [FieldFixedLength(15)]
            public String Iznos;

            [FieldOptional()]
            [FieldFixedLength(4)]
            public String ModelPozivNaBrojPlatitelja;

            [FieldOptional()]
            [FieldFixedLength(22)]
            public String PozivNaBrojPlatitelja;

            [FieldOptional()]
            [FieldFixedLength(4)]
            public String ModelPozivNaBrojPrimatelja;

            [FieldOptional()]
            [FieldFixedLength(22)]
            public String PozivNaBrojPrimatelja;

            [FieldOptional()]
            [FieldFixedLength(4)]
            public String SifraNamjene;

            [FieldOptional()]
            [FieldFixedLength(140)]
            public String OpisPlacanje;

            [FieldOptional()]
            [FieldFixedLength(42)]
            public String IdentifikatorTransakcijeFINA;

            [FieldOptional()]
            [FieldFixedLength(35)]
            public String IdentifikatorTransakcije;

            [FieldOptional()]
            [FieldFixedLength(482)]
            public String Rezerva;

            [FieldOptional()]
            [FieldFixedLength(3)]
            public String TipSloga;

        }

        public class GlavaProsirena : Glava
        {
            public GlavaProsirena() { }

            public GlavaProsirena(Glava item)
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

        public class StavkaProsirena : Stavka
        {
            public String ID_Izvod;

            public StavkaProsirena() { }

            public StavkaProsirena(Stavka item)
            {
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
                this.IznosValutaPokrice = item.IznosValutaPokrice.Trim();
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
 
}