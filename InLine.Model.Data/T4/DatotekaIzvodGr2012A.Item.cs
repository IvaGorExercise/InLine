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
    
    public partial class DatotekaIzvodGr2012AItem 
    {
    
    	public DatotekaIzvodGr2012AItem() {}
    	public DatotekaIzvodGr2012AItem(long? id_DatotekaIzvodGr2012A)
    	{
    		ID_DatotekaIzvodGr2012A = id_DatotekaIzvodGr2012A;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DatotekaIzvodGr2012A; }
    		set { this.ID_DatotekaIzvodGr2012A = value; }
    	}
        public long? ID_DatotekaIzvodGr2012A { get; set; }
        public long? ID_DatotekaIzvod { get; set; }
        public string VBDI { get; set; }
        public string BIC { get; set; }
        public string Racun { get; set; }
        public string IDValuta { get; set; }
        public string Naziv { get; set; }
        public string Sjediste { get; set; }
        public string MBR { get; set; }
        public string OIB { get; set; }
        public int? Vrsta { get; set; }
        public DateTime? Datum { get; set; }
    
    	public DatotekaIzvodGr2012AItem(Model.Data.DatotekaIzvodGr2012A item)
    	{
    	    this.ID_DatotekaIzvodGr2012A = item.ID_DatotekaIzvodGr2012A;
        this.ID_DatotekaIzvod = item.ID_DatotekaIzvod;
        this.VBDI = item.VBDI;
        this.BIC = item.BIC;
        this.Racun = item.Racun;
        this.IDValuta = item.IDValuta;
        this.Naziv = item.Naziv;
        this.Sjediste = item.Sjediste;
        this.MBR = item.MBR;
        this.OIB = item.OIB;
        this.Vrsta = item.Vrsta;
        this.Datum = item.Datum;
    	}
    
    	public DatotekaIzvodGr2012AItem(dynamic item)
    	{
    	    this.ID_DatotekaIzvodGr2012A = item.ID_DatotekaIzvodGr2012A;
        this.ID_DatotekaIzvod = item.ID_DatotekaIzvod;
        this.VBDI = item.VBDI;
        this.BIC = item.BIC;
        this.Racun = item.Racun;
        this.IDValuta = item.IDValuta;
        this.Naziv = item.Naziv;
        this.Sjediste = item.Sjediste;
        this.MBR = item.MBR;
        this.OIB = item.OIB;
        this.Vrsta = item.Vrsta;
        this.Datum = item.Datum;
    	}
    }
}
