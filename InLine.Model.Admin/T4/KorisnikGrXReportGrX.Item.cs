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
    
    public partial class KorisnikGrXReportGrXItem : Model.Admin.KorisnikGrXReportGrX
    {
    
    	public KorisnikGrXReportGrXItem() {}
    	public KorisnikGrXReportGrXItem(long id_KorisnikGrXReportGrX)
    	{
    		ID_KorisnikGrXReportGrX = id_KorisnikGrXReportGrX;
    	}
        public long ID
    	{
    		get { return this.ID_KorisnikGrXReportGrX; }
    		set { this.ID_KorisnikGrXReportGrX = value; }
    	}
        public long ID_KorisnikGrXReportGrX { get; set; }
        public long ID_KorisnikGrX { get; set; }
        public long ID_ReportGrX { get; set; }
    }
}