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
    
    public partial class RacunIzlazKontniPlanItem 
    {
    
    	public RacunIzlazKontniPlanItem() {}
    	public RacunIzlazKontniPlanItem(long? id_RacunIzlazKontniPlan)
    	{
    		ID_RacunIzlazKontniPlan = id_RacunIzlazKontniPlan;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RacunIzlazKontniPlan; }
    		set { this.ID_RacunIzlazKontniPlan = value; }
    	}
        public long? ID_RacunIzlazKontniPlan { get; set; }
        public long? ID_RacunIzlaz { get; set; }
        public long? ID_KontniPlan { get; set; }
        public long? ID_Shema { get; set; }
        public long? ID_KontniPlanAnalitika { get; set; }
    
    	public RacunIzlazKontniPlanItem(Model.Data.RacunIzlazKontniPlan item)
    	{
    	    this.ID_RacunIzlazKontniPlan = item.ID_RacunIzlazKontniPlan;
        this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    
    	public RacunIzlazKontniPlanItem(dynamic item)
    	{
    	    this.ID_RacunIzlazKontniPlan = item.ID_RacunIzlazKontniPlan;
        this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    }
}