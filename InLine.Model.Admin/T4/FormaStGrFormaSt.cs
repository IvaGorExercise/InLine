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
    
    public partial class FormaStGrFormaSt
    {
        public FormaStGrFormaSt()
        {
            this.FormaStGrFormaSt1 = new HashSet<FormaStGrFormaSt>();
        }
    
        public long ID
    	{
    		get { return this.ID_FormaStGrFormaSt; }
    		set { this.ID_FormaStGrFormaSt = value; }
    	}
        public long ID_FormaStGrFormaSt { get; set; }
        public long ID_FormaStGr { get; set; }
        public int IDForma { get; set; }
        public int IDFormaSt { get; set; }
        public long? ID_FormaStGrFormaStNad { get; set; }
    
        public virtual FormaStGr FormaStGr { get; set; }
        public virtual FormaSt FormaSt { get; set; }
        public virtual ICollection<FormaStGrFormaSt> FormaStGrFormaSt1 { get; set; }
        public virtual FormaStGrFormaSt FormaStGrFormaSt2 { get; set; }
    }
}
