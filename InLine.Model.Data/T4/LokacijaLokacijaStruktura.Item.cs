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
    
    public partial class LokacijaLokacijaStrukturaItem 
    {
    
    	public LokacijaLokacijaStrukturaItem() {}
    	public LokacijaLokacijaStrukturaItem(long? id_LokacijaLokacijaStruktura)
    	{
    		ID_LokacijaLokacijaStruktura = id_LokacijaLokacijaStruktura;
    	}
    
        public long? ID
    	{
    		get { return this.ID_LokacijaLokacijaStruktura; }
    		set { this.ID_LokacijaLokacijaStruktura = value; }
    	}
        public long? ID_LokacijaLokacijaStruktura { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public LokacijaLokacijaStrukturaItem(Model.Data.LokacijaLokacijaStruktura item)
    	{
    	    this.ID_LokacijaLokacijaStruktura = item.ID_LokacijaLokacijaStruktura;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public LokacijaLokacijaStrukturaItem(dynamic item)
    	{
    	    this.ID_LokacijaLokacijaStruktura = item.ID_LokacijaLokacijaStruktura;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}
