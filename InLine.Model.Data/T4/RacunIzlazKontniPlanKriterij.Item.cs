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
    
    public partial class RacunIzlazKontniPlanKriterijItem 
    {
    
    	public RacunIzlazKontniPlanKriterijItem() {}
    	public RacunIzlazKontniPlanKriterijItem(long? id_RacunIzlazKontniPlanKriterij)
    	{
    		ID_RacunIzlazKontniPlanKriterij = id_RacunIzlazKontniPlanKriterij;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RacunIzlazKontniPlanKriterij; }
    		set { this.ID_RacunIzlazKontniPlanKriterij = value; }
    	}
        public long? ID_RacunIzlazKontniPlanKriterij { get; set; }
        public long? ID_RacunIzlazKontniPlan { get; set; }
        public long? ID_Kriterij { get; set; }
        public long? ID_KriterijSt { get; set; }
    
    	public RacunIzlazKontniPlanKriterijItem(Model.Data.RacunIzlazKontniPlanKriterij item)
    	{
    	    this.ID_RacunIzlazKontniPlanKriterij = item.ID_RacunIzlazKontniPlanKriterij;
        this.ID_RacunIzlazKontniPlan = item.ID_RacunIzlazKontniPlan;
        this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KriterijSt = item.ID_KriterijSt;
    	}
    
    	public RacunIzlazKontniPlanKriterijItem(dynamic item)
    	{
    	    this.ID_RacunIzlazKontniPlanKriterij = item.ID_RacunIzlazKontniPlanKriterij;
        this.ID_RacunIzlazKontniPlan = item.ID_RacunIzlazKontniPlan;
        this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KriterijSt = item.ID_KriterijSt;
    	}
    }
}