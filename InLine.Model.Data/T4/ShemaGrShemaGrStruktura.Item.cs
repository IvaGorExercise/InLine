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
    
    public partial class ShemaGrShemaGrStrukturaItem 
    {
    
    	public ShemaGrShemaGrStrukturaItem() {}
    	public ShemaGrShemaGrStrukturaItem(long? id_ShemaGrShemaGrStruktura)
    	{
    		ID_ShemaGrShemaGrStruktura = id_ShemaGrShemaGrStruktura;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ShemaGrShemaGrStruktura; }
    		set { this.ID_ShemaGrShemaGrStruktura = value; }
    	}
        public long? ID_ShemaGrShemaGrStruktura { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public ShemaGrShemaGrStrukturaItem(Model.Data.ShemaGrShemaGrStruktura item)
    	{
    	    this.ID_ShemaGrShemaGrStruktura = item.ID_ShemaGrShemaGrStruktura;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public ShemaGrShemaGrStrukturaItem(dynamic item)
    	{
    	    this.ID_ShemaGrShemaGrStruktura = item.ID_ShemaGrShemaGrStruktura;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}
