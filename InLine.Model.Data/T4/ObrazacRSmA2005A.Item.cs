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
    
    public partial class ObrazacRSmA2005AItem 
    {
    
    	public ObrazacRSmA2005AItem() {}
    	public ObrazacRSmA2005AItem(long? id_ObrazacRSmA2005A)
    	{
    		ID_ObrazacRSmA2005A = id_ObrazacRSmA2005A;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObrazacRSmA2005A; }
    		set { this.ID_ObrazacRSmA2005A = value; }
    	}
        public long? ID_ObrazacRSmA2005A { get; set; }
        public long? ID_ObrazacRSm { get; set; }
        public string Identifikator { get; set; }
        public string Mjesec { get; set; }
        public string Godina { get; set; }
        public int? BrojOsiguranika { get; set; }
        public string ObveznikNaziv { get; set; }
        public string ObveznikAdresa { get; set; }
        public string ObveznikIdentifikacijskiBroj { get; set; }
        public string ObveznikVrsta { get; set; }
        public decimal? IznosObracunDohodak { get; set; }
        public decimal? IznosDoprinosOsnova { get; set; }
        public decimal? IznosDoprinosMIO1 { get; set; }
        public decimal? IznosDoprinosMIO2 { get; set; }
        public decimal? IznosIsplataDohodak { get; set; }
        public string GodinaIsplataDohodak { get; set; }
        public string MjesecIsplataDohodak { get; set; }
        public string Hash { get; set; }
    
    	public ObrazacRSmA2005AItem(Model.Data.ObrazacRSmA2005A item)
    	{
    	    this.ID_ObrazacRSmA2005A = item.ID_ObrazacRSmA2005A;
        this.ID_ObrazacRSm = item.ID_ObrazacRSm;
        this.Identifikator = item.Identifikator;
        this.Mjesec = item.Mjesec;
        this.Godina = item.Godina;
        this.BrojOsiguranika = item.BrojOsiguranika;
        this.ObveznikNaziv = item.ObveznikNaziv;
        this.ObveznikAdresa = item.ObveznikAdresa;
        this.ObveznikIdentifikacijskiBroj = item.ObveznikIdentifikacijskiBroj;
        this.ObveznikVrsta = item.ObveznikVrsta;
        this.IznosObracunDohodak = item.IznosObracunDohodak;
        this.IznosDoprinosOsnova = item.IznosDoprinosOsnova;
        this.IznosDoprinosMIO1 = item.IznosDoprinosMIO1;
        this.IznosDoprinosMIO2 = item.IznosDoprinosMIO2;
        this.IznosIsplataDohodak = item.IznosIsplataDohodak;
        this.GodinaIsplataDohodak = item.GodinaIsplataDohodak;
        this.MjesecIsplataDohodak = item.MjesecIsplataDohodak;
        this.Hash = item.Hash;
    	}
    
    	public ObrazacRSmA2005AItem(dynamic item)
    	{
    	    this.ID_ObrazacRSmA2005A = item.ID_ObrazacRSmA2005A;
        this.ID_ObrazacRSm = item.ID_ObrazacRSm;
        this.Identifikator = item.Identifikator;
        this.Mjesec = item.Mjesec;
        this.Godina = item.Godina;
        this.BrojOsiguranika = item.BrojOsiguranika;
        this.ObveznikNaziv = item.ObveznikNaziv;
        this.ObveznikAdresa = item.ObveznikAdresa;
        this.ObveznikIdentifikacijskiBroj = item.ObveznikIdentifikacijskiBroj;
        this.ObveznikVrsta = item.ObveznikVrsta;
        this.IznosObracunDohodak = item.IznosObracunDohodak;
        this.IznosDoprinosOsnova = item.IznosDoprinosOsnova;
        this.IznosDoprinosMIO1 = item.IznosDoprinosMIO1;
        this.IznosDoprinosMIO2 = item.IznosDoprinosMIO2;
        this.IznosIsplataDohodak = item.IznosIsplataDohodak;
        this.GodinaIsplataDohodak = item.GodinaIsplataDohodak;
        this.MjesecIsplataDohodak = item.MjesecIsplataDohodak;
        this.Hash = item.Hash;
    	}
    }
}
