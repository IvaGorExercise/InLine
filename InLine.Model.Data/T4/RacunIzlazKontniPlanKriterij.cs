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
    
    public partial class RacunIzlazKontniPlanKriterij
    {
    
        public long ID
    	{
    		get { return this.ID_RacunIzlazKontniPlanKriterij; }
    		set { this.ID_RacunIzlazKontniPlanKriterij = value; }
    	}
        public long ID_RacunIzlazKontniPlanKriterij { get; set; }
        public long ID_RacunIzlazKontniPlan { get; set; }
        public long ID_Kriterij { get; set; }
        public long ID_KriterijSt { get; set; }
    
        public virtual Kriterij Kriterij { get; set; }
        public virtual KriterijSt KriterijSt { get; set; }
        public virtual RacunIzlazKontniPlan RacunIzlazKontniPlan { get; set; }
    }
}
