//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RacunIzlazKontniPlan
    {
    
        public RacunIzlazKontniPlan()
        {
    
            this.RacunIzlazKontniPlanKriterij = new HashSet<RacunIzlazKontniPlanKriterij>();
        }
    
        public long ID
    	{
    		get { return this.ID_RacunIzlazKontniPlan; }
    		set { this.ID_RacunIzlazKontniPlan = value; }
    	}
        public long ID_RacunIzlazKontniPlan { get; set; }
        public long ID_RacunIzlaz { get; set; }
        public long ID_KontniPlan { get; set; }
        public long? ID_Shema { get; set; }
        public long? ID_KontniPlanAnalitika { get; set; }
    
        public virtual KontniPlan KontniPlan { get; set; }
        public virtual KontniPlanAnalitika KontniPlanAnalitika { get; set; }
        public virtual Shema Shema { get; set; }
        public virtual RacunIzlaz RacunIzlaz { get; set; }
        public virtual ICollection<RacunIzlazKontniPlanKriterij> RacunIzlazKontniPlanKriterij { get; set; }
    }
}
