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
    
    public partial class VijestItem : Model.Admin.Vijest
    {
    
    	public VijestItem() {}
    	public VijestItem(long id_Vijest)
    	{
    		ID_Vijest = id_Vijest;
    	}
        public long ID
    	{
    		get { return this.ID_Vijest; }
    		set { this.ID_Vijest = value; }
    	}
        public long ID_Vijest { get; set; }
        public string Naslov { get; set; }
        public string Podnaslov { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? PrikazOd { get; set; }
        public DateTime? PrikazDo { get; set; }
    }
}