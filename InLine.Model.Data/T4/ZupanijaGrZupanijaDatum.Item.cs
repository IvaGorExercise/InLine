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
    
    public partial class ZupanijaGrZupanijaDatumItem 
    {
    
    	public ZupanijaGrZupanijaDatumItem() {}
    	public ZupanijaGrZupanijaDatumItem(long? id_ZupanijaGrZupanijaDatum)
    	{
    		ID_ZupanijaGrZupanijaDatum = id_ZupanijaGrZupanijaDatum;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZupanijaGrZupanijaDatum; }
    		set { this.ID_ZupanijaGrZupanijaDatum = value; }
    	}
        public long? ID_ZupanijaGrZupanijaDatum { get; set; }
        public long? ID_ZupanijaGrZupanija { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public string Opis { get; set; }
    
    	public ZupanijaGrZupanijaDatumItem(Model.Data.ZupanijaGrZupanijaDatum item)
    	{
    	    this.ID_ZupanijaGrZupanijaDatum = item.ID_ZupanijaGrZupanijaDatum;
        this.ID_ZupanijaGrZupanija = item.ID_ZupanijaGrZupanija;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    
    	public ZupanijaGrZupanijaDatumItem(dynamic item)
    	{
    	    this.ID_ZupanijaGrZupanijaDatum = item.ID_ZupanijaGrZupanijaDatum;
        this.ID_ZupanijaGrZupanija = item.ID_ZupanijaGrZupanija;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Opis = item.Opis;
    	}
    }
}