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
    
    public partial class LicencaReportStGrItem : Model.Admin.LicencaReportStGr
    {
    
    	public LicencaReportStGrItem() {}
    	public LicencaReportStGrItem(long id_LicencaReportStGr)
    	{
    		ID_LicencaReportStGr = id_LicencaReportStGr;
    	}
        public long ID
    	{
    		get { return this.ID_LicencaReportStGr; }
    		set { this.ID_LicencaReportStGr = value; }
    	}
        public long ID_LicencaReportStGr { get; set; }
        public long ID_Licenca { get; set; }
        public long ID_ReportStGr { get; set; }
    }
}
