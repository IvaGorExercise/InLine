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
    
    public partial class KorisnikGrXReportStGrX
    {
        public long ID
    	{
    		get { return this.ID_KorisnikGrXReportStGrX; }
    		set { this.ID_KorisnikGrXReportStGrX = value; }
    	}
        public long ID_KorisnikGrXReportStGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_ReportStGrX { get; set; }
    
        public virtual KorisnikGrX KorisnikGrX { get; set; }
        public virtual ReportStGrX ReportStGrX { get; set; }
    }
}
