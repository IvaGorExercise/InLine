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
    
    public partial class OdbitakGrOdbitakGr
    {
    
        public long ID
    	{
    		get { return this.ID_OdbitakGrOdbitakGr; }
    		set { this.ID_OdbitakGrOdbitakGr = value; }
    	}
        public long ID_OdbitakGrOdbitakGr { get; set; }
        public long ID_OdbitakGr { get; set; }
        public long ID_OdbitakGrNad { get; set; }
    
        public virtual OdbitakGr OdbitakGr { get; set; }
        public virtual OdbitakGr OdbitakGr1 { get; set; }
    }
}
