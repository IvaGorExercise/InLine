//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class ObrazacID1Potvrda2010AItem 
    {
    
    	public ObrazacID1Potvrda2010AItem() {}
    	public ObrazacID1Potvrda2010AItem(long? id_ObrazacID1Potvrda2010A)
    	{
    		ID_ObrazacID1Potvrda2010A = id_ObrazacID1Potvrda2010A;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObrazacID1Potvrda2010A; }
    		set { this.ID_ObrazacID1Potvrda2010A = value; }
    	}
        public long? ID_ObrazacID1Potvrda2010A { get; set; }
        public long? ID_ObrazacID1 { get; set; }
        public long? ID_Osoba { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string OIB { get; set; }
        public decimal? IsplataPrimitak { get; set; }
        public decimal? UplataDoprinos { get; set; }
        public decimal? UplataDoprinosMIO1 { get; set; }
        public decimal? UplataDoprinosMIO2 { get; set; }
        public decimal? UplataDoprinosOstaloIz { get; set; }
        public decimal? UplataDohodak { get; set; }
        public decimal? UplataOsobniOdbitak { get; set; }
        public decimal? UplataPoreznaOsnova { get; set; }
        public decimal? ObracunPorezPrirez { get; set; }
        public decimal? ObracunPorez { get; set; }
        public decimal? ObracunPrirez { get; set; }
        public decimal? UplataPorezPrirez { get; set; }
        public int? BrojPrimatelja { get; set; }
        public decimal? ObracunDoprinosMIO1 { get; set; }
        public decimal? ObracunDoprinosStaz1 { get; set; }
        public decimal? ObracunDoprinosMIO2 { get; set; }
        public decimal? ObracunDoprinosStaz2 { get; set; }
        public decimal? ObracunDoprinosZdravstvo { get; set; }
        public decimal? ObracunDoprinosZdravstvoRad { get; set; }
        public decimal? ObracunDoprinosZdravstvoIno { get; set; }
        public decimal? ObracunDoprinosZaposljavanje { get; set; }
        public decimal? ObracunDoprinosZaposljavanjeInv { get; set; }
        public int? BrojOsiguranihOsoba { get; set; }
    
    	public ObrazacID1Potvrda2010AItem(Model.Data.ObrazacID1Potvrda2010A item)
    	{
    	    this.ID_ObrazacID1Potvrda2010A = item.ID_ObrazacID1Potvrda2010A;
        this.ID_ObrazacID1 = item.ID_ObrazacID1;
        this.ID_Osoba = item.ID_Osoba;
        this.Naziv = item.Naziv;
        this.Adresa = item.Adresa;
        this.OIB = item.OIB;
        this.IsplataPrimitak = item.IsplataPrimitak;
        this.UplataDoprinos = item.UplataDoprinos;
        this.UplataDoprinosMIO1 = item.UplataDoprinosMIO1;
        this.UplataDoprinosMIO2 = item.UplataDoprinosMIO2;
        this.UplataDoprinosOstaloIz = item.UplataDoprinosOstaloIz;
        this.UplataDohodak = item.UplataDohodak;
        this.UplataOsobniOdbitak = item.UplataOsobniOdbitak;
        this.UplataPoreznaOsnova = item.UplataPoreznaOsnova;
        this.ObracunPorezPrirez = item.ObracunPorezPrirez;
        this.ObracunPorez = item.ObracunPorez;
        this.ObracunPrirez = item.ObracunPrirez;
        this.UplataPorezPrirez = item.UplataPorezPrirez;
        this.BrojPrimatelja = item.BrojPrimatelja;
        this.ObracunDoprinosMIO1 = item.ObracunDoprinosMIO1;
        this.ObracunDoprinosStaz1 = item.ObracunDoprinosStaz1;
        this.ObracunDoprinosMIO2 = item.ObracunDoprinosMIO2;
        this.ObracunDoprinosStaz2 = item.ObracunDoprinosStaz2;
        this.ObracunDoprinosZdravstvo = item.ObracunDoprinosZdravstvo;
        this.ObracunDoprinosZdravstvoRad = item.ObracunDoprinosZdravstvoRad;
        this.ObracunDoprinosZdravstvoIno = item.ObracunDoprinosZdravstvoIno;
        this.ObracunDoprinosZaposljavanje = item.ObracunDoprinosZaposljavanje;
        this.ObracunDoprinosZaposljavanjeInv = item.ObracunDoprinosZaposljavanjeInv;
        this.BrojOsiguranihOsoba = item.BrojOsiguranihOsoba;
    	}
    
    	public ObrazacID1Potvrda2010AItem(dynamic item)
    	{
    	    this.ID_ObrazacID1Potvrda2010A = item.ID_ObrazacID1Potvrda2010A;
        this.ID_ObrazacID1 = item.ID_ObrazacID1;
        this.ID_Osoba = item.ID_Osoba;
        this.Naziv = item.Naziv;
        this.Adresa = item.Adresa;
        this.OIB = item.OIB;
        this.IsplataPrimitak = item.IsplataPrimitak;
        this.UplataDoprinos = item.UplataDoprinos;
        this.UplataDoprinosMIO1 = item.UplataDoprinosMIO1;
        this.UplataDoprinosMIO2 = item.UplataDoprinosMIO2;
        this.UplataDoprinosOstaloIz = item.UplataDoprinosOstaloIz;
        this.UplataDohodak = item.UplataDohodak;
        this.UplataOsobniOdbitak = item.UplataOsobniOdbitak;
        this.UplataPoreznaOsnova = item.UplataPoreznaOsnova;
        this.ObracunPorezPrirez = item.ObracunPorezPrirez;
        this.ObracunPorez = item.ObracunPorez;
        this.ObracunPrirez = item.ObracunPrirez;
        this.UplataPorezPrirez = item.UplataPorezPrirez;
        this.BrojPrimatelja = item.BrojPrimatelja;
        this.ObracunDoprinosMIO1 = item.ObracunDoprinosMIO1;
        this.ObracunDoprinosStaz1 = item.ObracunDoprinosStaz1;
        this.ObracunDoprinosMIO2 = item.ObracunDoprinosMIO2;
        this.ObracunDoprinosStaz2 = item.ObracunDoprinosStaz2;
        this.ObracunDoprinosZdravstvo = item.ObracunDoprinosZdravstvo;
        this.ObracunDoprinosZdravstvoRad = item.ObracunDoprinosZdravstvoRad;
        this.ObracunDoprinosZdravstvoIno = item.ObracunDoprinosZdravstvoIno;
        this.ObracunDoprinosZaposljavanje = item.ObracunDoprinosZaposljavanje;
        this.ObracunDoprinosZaposljavanjeInv = item.ObracunDoprinosZaposljavanjeInv;
        this.BrojOsiguranihOsoba = item.BrojOsiguranihOsoba;
    	}
    }
}