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
    
    public partial class FormaStGrXFormaSt
    {
        public FormaStGrXFormaSt()
        {
            this.FormaStGrXFormaSt1 = new HashSet<FormaStGrXFormaSt>();
        }
    
        public long ID
    	{
    		get { return this.ID_FormaStGrXFormaSt; }
    		set { this.ID_FormaStGrXFormaSt = value; }
    	}
        public long ID_FormaStGrXFormaSt { get; set; }
        public long ID_FormaStGrX { get; set; }
        public int IDForma { get; set; }
        public int IDFormaSt { get; set; }
        public long? ID_FormaStGrXFormaStNad { get; set; }
    
        public virtual FormaStGrX FormaStGrX { get; set; }
        public virtual FormaSt FormaSt { get; set; }
        public virtual ICollection<FormaStGrXFormaSt> FormaStGrXFormaSt1 { get; set; }
        public virtual FormaStGrXFormaSt FormaStGrXFormaSt2 { get; set; }
    }
}
