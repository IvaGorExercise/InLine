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
    
    public partial class ReportVr
    {
        public ReportVr()
        {
            this.Report = new HashSet<Report>();
            this.ReportVr1 = new HashSet<ReportVr>();
            this.ReportVr2 = new HashSet<ReportVr>();
        }
    
        public int IDReportVr { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    
        public virtual ICollection<Report> Report { get; set; }
        public virtual ICollection<ReportVr> ReportVr1 { get; set; }
        public virtual ICollection<ReportVr> ReportVr2 { get; set; }
    }
}
