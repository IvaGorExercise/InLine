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
    
    public partial class PoslovnaGodinaSubjektGrItem 
    {
    
    	public PoslovnaGodinaSubjektGrItem() {}
    	public PoslovnaGodinaSubjektGrItem(long? id_PoslovnaGodinaSubjektGr)
    	{
    		ID_PoslovnaGodinaSubjektGr = id_PoslovnaGodinaSubjektGr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_PoslovnaGodinaSubjektGr; }
    		set { this.ID_PoslovnaGodinaSubjektGr = value; }
    	}
        public long? ID_PoslovnaGodinaSubjektGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public PoslovnaGodinaSubjektGrItem(Model.Data.PoslovnaGodinaSubjektGr item)
    	{
    	    this.ID_PoslovnaGodinaSubjektGr = item.ID_PoslovnaGodinaSubjektGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public PoslovnaGodinaSubjektGrItem(dynamic item)
    	{
    	    this.ID_PoslovnaGodinaSubjektGr = item.ID_PoslovnaGodinaSubjektGr;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}