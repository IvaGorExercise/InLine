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
    
    public partial class ReportItem : Model.Admin.Report
    {
    
    	public ReportItem() {}
    	public ReportItem(int idReport)
    	{
    		IDReport = idReport;
    	}
        public int IDReport { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    }
}
