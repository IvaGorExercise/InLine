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
    
    public partial class ZapisGrZapisGr
    {
    
        public long ID
    	{
    		get { return this.ID_ZapisGrZapisGr; }
    		set { this.ID_ZapisGrZapisGr = value; }
    	}
        public long ID_ZapisGrZapisGr { get; set; }
        public long ID_ZapisGr { get; set; }
        public long ID_ZapisGrNad { get; set; }
    
        public virtual ZapisGr ZapisGr { get; set; }
        public virtual ZapisGr ZapisGr1 { get; set; }
    }
}