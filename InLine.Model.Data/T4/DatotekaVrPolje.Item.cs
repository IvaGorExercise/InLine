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
    
    public partial class DatotekaVrPoljeItem 
    {
    
    	public DatotekaVrPoljeItem() {}
    	public DatotekaVrPoljeItem(long? id_DatotekaVrPolje)
    	{
    		ID_DatotekaVrPolje = id_DatotekaVrPolje;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DatotekaVrPolje; }
    		set { this.ID_DatotekaVrPolje = value; }
    	}
        public long? ID_DatotekaVrPolje { get; set; }
        public long? ID_DatotekaVrVerzija { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public long? ID_DatotekaVrPoljeTip { get; set; }
        public int? Duljina { get; set; }
        public int? Pozicija { get; set; }
    
    	public DatotekaVrPoljeItem(Model.Data.DatotekaVrPolje item)
    	{
    	    this.ID_DatotekaVrPolje = item.ID_DatotekaVrPolje;
        this.ID_DatotekaVrVerzija = item.ID_DatotekaVrVerzija;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.ID_DatotekaVrPoljeTip = item.ID_DatotekaVrPoljeTip;
        this.Duljina = item.Duljina;
        this.Pozicija = item.Pozicija;
    	}
    
    	public DatotekaVrPoljeItem(dynamic item)
    	{
    	    this.ID_DatotekaVrPolje = item.ID_DatotekaVrPolje;
        this.ID_DatotekaVrVerzija = item.ID_DatotekaVrVerzija;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.ID_DatotekaVrPoljeTip = item.ID_DatotekaVrPoljeTip;
        this.Duljina = item.Duljina;
        this.Pozicija = item.Pozicija;
    	}
    }
}
