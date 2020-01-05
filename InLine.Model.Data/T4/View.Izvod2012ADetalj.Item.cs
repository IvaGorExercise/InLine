//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class Izvod2012ADetaljItem 
    {
    
    	public Izvod2012ADetaljItem() {}
    	public Izvod2012ADetaljItem(long? id_Izvod2012A, int? idIzvodVerzija)
    	{
    		ID_Izvod2012A = id_Izvod2012A;
    		IDIzvodVerzija = idIzvodVerzija;
    	}
    
        public long? ID_Izvod2012A { get; set; }
        public long? ID_Izvod { get; set; }
        public string BankaVBDI { get; set; }
        public string BankaNaziv { get; set; }
        public string BankaOIB { get; set; }
        public int? IzvadakVr { get; set; }
        public DateTime? DatumObrada { get; set; }
        public string BankaBIC { get; set; }
        public string Racun { get; set; }
        public string IDValuta { get; set; }
        public string Naziv { get; set; }
        public string Sjediste { get; set; }
        public string MaticniBroj { get; set; }
        public string OIB { get; set; }
        public int? RedniBrojIzvadak { get; set; }
        public int? PodbrojIzvadak { get; set; }
        public DateTime? DatumIzvadak { get; set; }
        public int? RedniBrojGrupa { get; set; }
        public int? VrstaIzvadak { get; set; }
        public long? ID_Zapis { get; set; }
        public int? IDIzvodVerzija { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public decimal? Saldostaro { get; set; }
        public decimal? SaldoNovo { get; set; }
        public long? ID_SubjektRacun { get; set; }
    
    	public Izvod2012ADetaljItem(Model.Data.View.Izvod2012ADetalj item)
    	{
    	    this.ID_Izvod2012A = item.ID_Izvod2012A;
        this.ID_Izvod = item.ID_Izvod;
        this.BankaVBDI = item.BankaVBDI;
        this.BankaNaziv = item.BankaNaziv;
        this.BankaOIB = item.BankaOIB;
        this.IzvadakVr = item.IzvadakVr;
        this.DatumObrada = item.DatumObrada;
        this.BankaBIC = item.BankaBIC;
        this.Racun = item.Racun;
        this.IDValuta = item.IDValuta;
        this.Naziv = item.Naziv;
        this.Sjediste = item.Sjediste;
        this.MaticniBroj = item.MaticniBroj;
        this.OIB = item.OIB;
        this.RedniBrojIzvadak = item.RedniBrojIzvadak;
        this.PodbrojIzvadak = item.PodbrojIzvadak;
        this.DatumIzvadak = item.DatumIzvadak;
        this.RedniBrojGrupa = item.RedniBrojGrupa;
        this.VrstaIzvadak = item.VrstaIzvadak;
        this.ID_Zapis = item.ID_Zapis;
        this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.Saldostaro = item.Saldostaro;
        this.SaldoNovo = item.SaldoNovo;
        this.ID_SubjektRacun = item.ID_SubjektRacun;
    	}
    
    	public Izvod2012ADetaljItem(dynamic item)
    	{
    	    this.ID_Izvod2012A = item.ID_Izvod2012A;
        this.ID_Izvod = item.ID_Izvod;
        this.BankaVBDI = item.BankaVBDI;
        this.BankaNaziv = item.BankaNaziv;
        this.BankaOIB = item.BankaOIB;
        this.IzvadakVr = item.IzvadakVr;
        this.DatumObrada = item.DatumObrada;
        this.BankaBIC = item.BankaBIC;
        this.Racun = item.Racun;
        this.IDValuta = item.IDValuta;
        this.Naziv = item.Naziv;
        this.Sjediste = item.Sjediste;
        this.MaticniBroj = item.MaticniBroj;
        this.OIB = item.OIB;
        this.RedniBrojIzvadak = item.RedniBrojIzvadak;
        this.PodbrojIzvadak = item.PodbrojIzvadak;
        this.DatumIzvadak = item.DatumIzvadak;
        this.RedniBrojGrupa = item.RedniBrojGrupa;
        this.VrstaIzvadak = item.VrstaIzvadak;
        this.ID_Zapis = item.ID_Zapis;
        this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.Saldostaro = item.Saldostaro;
        this.SaldoNovo = item.SaldoNovo;
        this.ID_SubjektRacun = item.ID_SubjektRacun;
    	}
    }
}
