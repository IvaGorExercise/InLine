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
    
    public partial class FormaStGrFormaStGr
    {
        public long ID
    	{
    		get { return this.ID_FormaStGrFormaStGr; }
    		set { this.ID_FormaStGrFormaStGr = value; }
    	}
        public long ID_FormaStGrFormaStGr { get; set; }
        public long ID_FormaStGr { get; set; }
        public long ID_FormaStGrNad { get; set; }
    
        public virtual FormaStGr FormaStGr { get; set; }
        public virtual FormaStGr FormaStGr1 { get; set; }
    }
}