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
    
    public partial class ReportStGrReportStGrItem : Model.Admin.ReportStGrReportStGr
    {
    
    	public ReportStGrReportStGrItem() {}
    	public ReportStGrReportStGrItem(long id_ReportStGrReportStGr)
    	{
    		ID_ReportStGrReportStGr = id_ReportStGrReportStGr;
    	}
        public long ID
    	{
    		get { return this.ID_ReportStGrReportStGr; }
    		set { this.ID_ReportStGrReportStGr = value; }
    	}
        public long ID_ReportStGrReportStGr { get; set; }
        public long ID_ReportStGr { get; set; }
        public long ID_ReportStGrNad { get; set; }
    }
}