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
    
    public partial class ReportStGr
    {
        public ReportStGr()
        {
            this.KorisnikGrReportStGr = new HashSet<KorisnikGrReportStGr>();
            this.LicencaReportStGr = new HashSet<LicencaReportStGr>();
            this.ReportStGrReportSt = new HashSet<ReportStGrReportSt>();
            this.ReportStGrReportStGr = new HashSet<ReportStGrReportStGr>();
            this.ReportStGrReportStGr1 = new HashSet<ReportStGrReportStGr>();
        }
    
        public long ID
    	{
    		get { return this.ID_ReportStGr; }
    		set { this.ID_ReportStGr = value; }
    	}
        public long ID_ReportStGr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<KorisnikGrReportStGr> KorisnikGrReportStGr { get; set; }
        public virtual ICollection<LicencaReportStGr> LicencaReportStGr { get; set; }
        public virtual ICollection<ReportStGrReportSt> ReportStGrReportSt { get; set; }
        public virtual ICollection<ReportStGrReportStGr> ReportStGrReportStGr { get; set; }
        public virtual ICollection<ReportStGrReportStGr> ReportStGrReportStGr1 { get; set; }
    }
}
