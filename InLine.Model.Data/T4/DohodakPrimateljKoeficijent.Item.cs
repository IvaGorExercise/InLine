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
    
    public partial class DohodakPrimateljKoeficijentItem 
    {
    
    	public DohodakPrimateljKoeficijentItem() {}
    	public DohodakPrimateljKoeficijentItem(long? id_DohodakPrimateljKoeficijent)
    	{
    		ID_DohodakPrimateljKoeficijent = id_DohodakPrimateljKoeficijent;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DohodakPrimateljKoeficijent; }
    		set { this.ID_DohodakPrimateljKoeficijent = value; }
    	}
        public long? ID_DohodakPrimateljKoeficijent { get; set; }
        public long? ID_DohodakPrimatelj { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public decimal? Koeficijent { get; set; }
    
    	public DohodakPrimateljKoeficijentItem(Model.Data.DohodakPrimateljKoeficijent item)
    	{
    	    this.ID_DohodakPrimateljKoeficijent = item.ID_DohodakPrimateljKoeficijent;
        this.ID_DohodakPrimatelj = item.ID_DohodakPrimatelj;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Koeficijent = item.Koeficijent;
    	}
    
    	public DohodakPrimateljKoeficijentItem(dynamic item)
    	{
    	    this.ID_DohodakPrimateljKoeficijent = item.ID_DohodakPrimateljKoeficijent;
        this.ID_DohodakPrimatelj = item.ID_DohodakPrimatelj;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Koeficijent = item.Koeficijent;
    	}
    }
}