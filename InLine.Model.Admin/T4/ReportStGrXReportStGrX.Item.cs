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
    
    public partial class ReportStGrXReportStGrXItem : Model.Admin.ReportStGrXReportStGrX
    {
    
    	public ReportStGrXReportStGrXItem() {}
    	public ReportStGrXReportStGrXItem(long id_ReportStGrXReportStGrX)
    	{
    		ID_ReportStGrXReportStGrX = id_ReportStGrXReportStGrX;
    	}
        public long ID
    	{
    		get { return this.ID_ReportStGrXReportStGrX; }
    		set { this.ID_ReportStGrXReportStGrX = value; }
    	}
        public long ID_ReportStGrXReportStGrX { get; set; }
        public long ID_ReportStGrX { get; set; }
        public long ID_ReportStGrXNad { get; set; }
    }
}