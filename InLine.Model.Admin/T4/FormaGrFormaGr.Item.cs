//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormaGrFormaGrItem : Model.Admin.FormaGrFormaGr
    {
    
    	public FormaGrFormaGrItem() {}
    	public FormaGrFormaGrItem(long id_FormaGrFormaGr)
    	{
    		ID_FormaGrFormaGr = id_FormaGrFormaGr;
    	}
        public long ID
    	{
    		get { return this.ID_FormaGrFormaGr; }
    		set { this.ID_FormaGrFormaGr = value; }
    	}
        public long ID_FormaGrFormaGr { get; set; }
        public long ID_FormaGr { get; set; }
        public long ID_FormaGrNad { get; set; }
    }
}