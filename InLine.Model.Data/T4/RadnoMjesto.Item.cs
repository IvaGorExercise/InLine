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
    
    public partial class RadnoMjestoItem 
    {
    
    	public RadnoMjestoItem() {}
    	public RadnoMjestoItem(long? id_RadnoMjesto)
    	{
    		ID_RadnoMjesto = id_RadnoMjesto;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RadnoMjesto; }
    		set { this.ID_RadnoMjesto = value; }
    	}
        public long? ID_RadnoMjesto { get; set; }
        public long? ID_PoslovniSubjekt { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public RadnoMjestoItem(Model.Data.RadnoMjesto item)
    	{
    	    this.ID_RadnoMjesto = item.ID_RadnoMjesto;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public RadnoMjestoItem(dynamic item)
    	{
    	    this.ID_RadnoMjesto = item.ID_RadnoMjesto;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}
