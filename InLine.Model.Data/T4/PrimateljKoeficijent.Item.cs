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
    
    public partial class PrimateljKoeficijentItem 
    {
    
    	public PrimateljKoeficijentItem() {}
    	public PrimateljKoeficijentItem(long? id_PrimateljKoeficijent)
    	{
    		ID_PrimateljKoeficijent = id_PrimateljKoeficijent;
    	}
    
        public long? ID
    	{
    		get { return this.ID_PrimateljKoeficijent; }
    		set { this.ID_PrimateljKoeficijent = value; }
    	}
        public long? ID_PrimateljKoeficijent { get; set; }
        public long? ID_PrimateljKoeficijentGr { get; set; }
        public long? ID_Osoba { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public decimal? Koeficijent { get; set; }
    
    	public PrimateljKoeficijentItem(Model.Data.PrimateljKoeficijent item)
    	{
    	    this.ID_PrimateljKoeficijent = item.ID_PrimateljKoeficijent;
        this.ID_PrimateljKoeficijentGr = item.ID_PrimateljKoeficijentGr;
        this.ID_Osoba = item.ID_Osoba;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Koeficijent = item.Koeficijent;
    	}
    
    	public PrimateljKoeficijentItem(dynamic item)
    	{
    	    this.ID_PrimateljKoeficijent = item.ID_PrimateljKoeficijent;
        this.ID_PrimateljKoeficijentGr = item.ID_PrimateljKoeficijentGr;
        this.ID_Osoba = item.ID_Osoba;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.Koeficijent = item.Koeficijent;
    	}
    }
}