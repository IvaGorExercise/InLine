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
    
    public partial class RacunUlazKontniPlanItem 
    {
    
    	public RacunUlazKontniPlanItem() {}
    	public RacunUlazKontniPlanItem(long? id_RacunUlazKontniPlan)
    	{
    		ID_RacunUlazKontniPlan = id_RacunUlazKontniPlan;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RacunUlazKontniPlan; }
    		set { this.ID_RacunUlazKontniPlan = value; }
    	}
        public long? ID_RacunUlazKontniPlan { get; set; }
        public long? ID_RacunUlaz { get; set; }
        public long? ID_KontniPlan { get; set; }
        public long? ID_Shema { get; set; }
        public long? ID_KontniPlanAnalitika { get; set; }
    
    	public RacunUlazKontniPlanItem(Model.Data.RacunUlazKontniPlan item)
    	{
    	    this.ID_RacunUlazKontniPlan = item.ID_RacunUlazKontniPlan;
        this.ID_RacunUlaz = item.ID_RacunUlaz;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    
    	public RacunUlazKontniPlanItem(dynamic item)
    	{
    	    this.ID_RacunUlazKontniPlan = item.ID_RacunUlazKontniPlan;
        this.ID_RacunUlaz = item.ID_RacunUlaz;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    }
}
