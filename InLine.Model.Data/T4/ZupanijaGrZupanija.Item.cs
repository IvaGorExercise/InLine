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
    
    public partial class ZupanijaGrZupanijaItem 
    {
    
    	public ZupanijaGrZupanijaItem() {}
    	public ZupanijaGrZupanijaItem(long? id_ZupanijaGrZupanija)
    	{
    		ID_ZupanijaGrZupanija = id_ZupanijaGrZupanija;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZupanijaGrZupanija; }
    		set { this.ID_ZupanijaGrZupanija = value; }
    	}
        public long? ID_ZupanijaGrZupanija { get; set; }
        public long? ID_ZupanijaGr { get; set; }
        public long? ID_Zupanija { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public ZupanijaGrZupanijaItem(Model.Data.ZupanijaGrZupanija item)
    	{
    	    this.ID_ZupanijaGrZupanija = item.ID_ZupanijaGrZupanija;
        this.ID_ZupanijaGr = item.ID_ZupanijaGr;
        this.ID_Zupanija = item.ID_Zupanija;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public ZupanijaGrZupanijaItem(dynamic item)
    	{
    	    this.ID_ZupanijaGrZupanija = item.ID_ZupanijaGrZupanija;
        this.ID_ZupanijaGr = item.ID_ZupanijaGr;
        this.ID_Zupanija = item.ID_Zupanija;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}