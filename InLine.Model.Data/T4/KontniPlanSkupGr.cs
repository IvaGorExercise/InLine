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
    
    public partial class KontniPlanSkupGr
    {
    
        public KontniPlanSkupGr()
        {
    
            this.KontniPlanSkupGrKontniPlanSkup = new HashSet<KontniPlanSkupGrKontniPlanSkup>();
        }
    
        public long ID
    	{
    		get { return this.ID_KontniPlanSkupGr; }
    		set { this.ID_KontniPlanSkupGr = value; }
    	}
        public long ID_KontniPlanSkupGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
        public virtual ICollection<KontniPlanSkupGrKontniPlanSkup> KontniPlanSkupGrKontniPlanSkup { get; set; }
    }
}
