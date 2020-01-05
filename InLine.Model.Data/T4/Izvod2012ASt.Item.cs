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
    
    public partial class Izvod2012AStItem 
    {
    
    	public Izvod2012AStItem() {}
    	public Izvod2012AStItem(long? id_Izvod2012ASt)
    	{
    		ID_Izvod2012ASt = id_Izvod2012ASt;
    	}
    
        public long? ID
    	{
    		get { return this.ID_Izvod2012ASt; }
    		set { this.ID_Izvod2012ASt = value; }
    	}
        public long? ID_Izvod2012ASt { get; set; }
        public long? ID_IzvodSt { get; set; }
        public int? IDIzvod2012ATransakcijaVr { get; set; }
        public string Racun { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Sjediste { get; set; }
        public DateTime? DatumValuta { get; set; }
        public DateTime? DatumIzvrsenje { get; set; }
        public string IDValuta { get; set; }
        public decimal? Tecaj { get; set; }
        public decimal? IznosValuta { get; set; }
        public decimal? Iznos { get; set; }
        public string PlatiteljPozivNaBroj { get; set; }
        public string PrimateljPozivNaBroj { get; set; }
        public int? IDHUBNamjena2013A { get; set; }
        public string OpisPlacanje { get; set; }
        public string IdentifikatorTransakcijeFINA { get; set; }
        public string IdentifikatorTransakcije { get; set; }
    
    	public Izvod2012AStItem(Model.Data.Izvod2012ASt item)
    	{
    	    this.ID_Izvod2012ASt = item.ID_Izvod2012ASt;
        this.ID_IzvodSt = item.ID_IzvodSt;
        this.IDIzvod2012ATransakcijaVr = item.IDIzvod2012ATransakcijaVr;
        this.Racun = item.Racun;
        this.Naziv = item.Naziv;
        this.Adresa = item.Adresa;
        this.Sjediste = item.Sjediste;
        this.DatumValuta = item.DatumValuta;
        this.DatumIzvrsenje = item.DatumIzvrsenje;
        this.IDValuta = item.IDValuta;
        this.Tecaj = item.Tecaj;
        this.IznosValuta = item.IznosValuta;
        this.Iznos = item.Iznos;
        this.PlatiteljPozivNaBroj = item.PlatiteljPozivNaBroj;
        this.PrimateljPozivNaBroj = item.PrimateljPozivNaBroj;
        this.IDHUBNamjena2013A = item.IDHUBNamjena2013A;
        this.OpisPlacanje = item.OpisPlacanje;
        this.IdentifikatorTransakcijeFINA = item.IdentifikatorTransakcijeFINA;
        this.IdentifikatorTransakcije = item.IdentifikatorTransakcije;
    	}
    
    	public Izvod2012AStItem(dynamic item)
    	{
    	    this.ID_Izvod2012ASt = item.ID_Izvod2012ASt;
        this.ID_IzvodSt = item.ID_IzvodSt;
        this.IDIzvod2012ATransakcijaVr = item.IDIzvod2012ATransakcijaVr;
        this.Racun = item.Racun;
        this.Naziv = item.Naziv;
        this.Adresa = item.Adresa;
        this.Sjediste = item.Sjediste;
        this.DatumValuta = item.DatumValuta;
        this.DatumIzvrsenje = item.DatumIzvrsenje;
        this.IDValuta = item.IDValuta;
        this.Tecaj = item.Tecaj;
        this.IznosValuta = item.IznosValuta;
        this.Iznos = item.Iznos;
        this.PlatiteljPozivNaBroj = item.PlatiteljPozivNaBroj;
        this.PrimateljPozivNaBroj = item.PrimateljPozivNaBroj;
        this.IDHUBNamjena2013A = item.IDHUBNamjena2013A;
        this.OpisPlacanje = item.OpisPlacanje;
        this.IdentifikatorTransakcijeFINA = item.IdentifikatorTransakcijeFINA;
        this.IdentifikatorTransakcije = item.IdentifikatorTransakcije;
    	}
    }
}
