//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormaGrXFormaGrX
    {
        public long ID
    	{
    		get { return this.ID_FormaGrXFormaGrX; }
    		set { this.ID_FormaGrXFormaGrX = value; }
    	}
        public long ID_FormaGrXFormaGrX { get; set; }
        public long ID_FormaGrX { get; set; }
        public long ID_FormaGrXNad { get; set; }
    
        public virtual FormaGrX FormaGrX { get; set; }
        public virtual FormaGrX FormaGrX1 { get; set; }
    }
}