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
    
    public partial class ObjektGrObjektGr
    {
    
        public long ID
    	{
    		get { return this.ID_ObjektGrObjektGr; }
    		set { this.ID_ObjektGrObjektGr = value; }
    	}
        public long ID_ObjektGrObjektGr { get; set; }
        public long ID_ObjektGr { get; set; }
        public long ID_ObjektGrNad { get; set; }
    
        public virtual ObjektGr ObjektGr { get; set; }
        public virtual ObjektGr ObjektGr1 { get; set; }
    }
}