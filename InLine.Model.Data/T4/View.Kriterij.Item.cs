//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class KriterijItem 
    {
    
    	public KriterijItem() {}
    	public KriterijItem(long? id_Kriterij, long? id_KontniPlan, string oznaka, string naziv, string nazivKr, string kratica, int? redniBroj)
    	{
    		ID_Kriterij = id_Kriterij;
    		ID_KontniPlan = id_KontniPlan;
    		Oznaka = oznaka;
    		Naziv = naziv;
    		NazivKr = nazivKr;
    		Kratica = kratica;
    		RedniBroj = redniBroj;
    	}
    
        public long? ID_Kriterij { get; set; }
        public long? ID_KontniPlan { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
        public int? RedniBroj { get; set; }
    
    	public KriterijItem(Model.Data.View.Kriterij item)
    	{
    	    this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.RedniBroj = item.RedniBroj;
    	}
    
    	public KriterijItem(dynamic item)
    	{
    	    this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.Oznaka = item.Oznaka;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
        this.RedniBroj = item.RedniBroj;
    	}
    }
}
