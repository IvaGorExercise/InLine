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
    
    public partial class KriterijDetaljItem 
    {
    
    	public KriterijDetaljItem() {}
    	public KriterijDetaljItem(int? redniBroj, string kratica, string naziv, string oznaka, long? id_KontniPlan, string nazivKr, long? id_Kriterij)
    	{
    		RedniBroj = redniBroj;
    		Kratica = kratica;
    		Naziv = naziv;
    		Oznaka = oznaka;
    		ID_KontniPlan = id_KontniPlan;
    		NazivKr = nazivKr;
    		ID_Kriterij = id_Kriterij;
    	}
    
        public int? RedniBroj { get; set; }
        public string Kratica { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public long? ID_KontniPlan { get; set; }
        public string NazivKr { get; set; }
        public long? ID_Kriterij { get; set; }
    
    	public KriterijDetaljItem(Model.Data.View.KriterijDetalj item)
    	{
    	    this.RedniBroj = item.RedniBroj;
        this.Kratica = item.Kratica;
        this.Naziv = item.Naziv;
        this.Oznaka = item.Oznaka;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.NazivKr = item.NazivKr;
        this.ID_Kriterij = item.ID_Kriterij;
    	}
    
    	public KriterijDetaljItem(dynamic item)
    	{
    	    this.RedniBroj = item.RedniBroj;
        this.Kratica = item.Kratica;
        this.Naziv = item.Naziv;
        this.Oznaka = item.Oznaka;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.NazivKr = item.NazivKr;
        this.ID_Kriterij = item.ID_Kriterij;
    	}
    }
}