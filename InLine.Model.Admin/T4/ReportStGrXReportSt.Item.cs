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
    
    public partial class ReportStGrXReportStItem : Model.Admin.ReportStGrXReportSt
    {
    
    	public ReportStGrXReportStItem() {}
    	public ReportStGrXReportStItem(long id_ReportStGrXReportSt)
    	{
    		ID_ReportStGrXReportSt = id_ReportStGrXReportSt;
    	}
        public long ID
    	{
    		get { return this.ID_ReportStGrXReportSt; }
    		set { this.ID_ReportStGrXReportSt = value; }
    	}
        public long ID_ReportStGrXReportSt { get; set; }
        public long ID_ReportStGrX { get; set; }
        public int IDReport { get; set; }
        public int IDReportSt { get; set; }
        public long? ID_ReportStGrXReportStNad { get; set; }
    }
}
