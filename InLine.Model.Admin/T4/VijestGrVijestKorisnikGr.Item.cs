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
    
    public partial class VijestGrVijestKorisnikGrItem : Model.Admin.VijestGrVijestKorisnikGr
    {
    
    	public VijestGrVijestKorisnikGrItem() {}
    	public VijestGrVijestKorisnikGrItem(long id_VijestGrVijestKorisnikGr)
    	{
    		ID_VijestGrVijestKorisnikGr = id_VijestGrVijestKorisnikGr;
    	}
        public long ID
    	{
    		get { return this.ID_VijestGrVijestKorisnikGr; }
    		set { this.ID_VijestGrVijestKorisnikGr = value; }
    	}
        public long ID_VijestGrVijestKorisnikGr { get; set; }
        public long ID_VijestGr { get; set; }
        public long ID_VijestKorisnikGr { get; set; }
    }
}
