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
    
    public partial class MjernaJedinicaItem 
    {
    
    	public MjernaJedinicaItem() {}
    	public MjernaJedinicaItem(long? id_MjernaJedinica)
    	{
    		ID_MjernaJedinica = id_MjernaJedinica;
    	}
    
        public long? ID
    	{
    		get { return this.ID_MjernaJedinica; }
    		set { this.ID_MjernaJedinica = value; }
    	}
        public long? ID_MjernaJedinica { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public MjernaJedinicaItem(Model.Data.MjernaJedinica item)
    	{
    	    this.ID_MjernaJedinica = item.ID_MjernaJedinica;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public MjernaJedinicaItem(dynamic item)
    	{
    	    this.ID_MjernaJedinica = item.ID_MjernaJedinica;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}