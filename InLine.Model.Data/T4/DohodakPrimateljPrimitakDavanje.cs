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
    
    public partial class DohodakPrimateljPrimitakDavanje
    {
    
        public long ID
    	{
    		get { return this.ID_DohodakPrimateljPrimitakDavanje; }
    		set { this.ID_DohodakPrimateljPrimitakDavanje = value; }
    	}
        public long ID_DohodakPrimateljPrimitakDavanje { get; set; }
        public long ID_DohodakPrimateljPrimitak { get; set; }
        public long ID_Davanje { get; set; }
    
        public virtual Davanje Davanje { get; set; }
        public virtual DohodakPrimateljPrimitak DohodakPrimateljPrimitak { get; set; }
    }
}
