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
    
    public partial class DohodakOdbitak
    {
    
        public long ID
    	{
    		get { return this.ID_DohodakOdbitak; }
    		set { this.ID_DohodakOdbitak = value; }
    	}
        public long ID_DohodakOdbitak { get; set; }
        public long ID_Dohodak { get; set; }
        public long ID_Odbitak { get; set; }
    
        public virtual Dohodak Dohodak { get; set; }
        public virtual Odbitak Odbitak { get; set; }
    }
}