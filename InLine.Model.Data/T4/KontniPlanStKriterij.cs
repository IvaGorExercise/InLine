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
    
    public partial class KontniPlanStKriterij
    {
    
        public long ID
    	{
    		get { return this.ID_KontniPlanStKriterij; }
    		set { this.ID_KontniPlanStKriterij = value; }
    	}
        public long ID_KontniPlanStKriterij { get; set; }
        public long ID_KontniPlanSt { get; set; }
        public long ID_Kriterij { get; set; }
        public long ID_KriterijSt { get; set; }
        public bool Obavezno { get; set; }
    
        public virtual KontniPlanSt KontniPlanSt { get; set; }
        public virtual Kriterij Kriterij { get; set; }
        public virtual KriterijSt KriterijSt { get; set; }
    }
}
