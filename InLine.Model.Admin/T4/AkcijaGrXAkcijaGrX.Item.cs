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
    
    public partial class AkcijaGrXAkcijaGrXItem : Model.Admin.AkcijaGrXAkcijaGrX
    {
    
    	public AkcijaGrXAkcijaGrXItem() {}
    	public AkcijaGrXAkcijaGrXItem(long id_AkcijaGrXAkcijaGrX)
    	{
    		ID_AkcijaGrXAkcijaGrX = id_AkcijaGrXAkcijaGrX;
    	}
        public long ID
    	{
    		get { return this.ID_AkcijaGrXAkcijaGrX; }
    		set { this.ID_AkcijaGrXAkcijaGrX = value; }
    	}
        public long ID_AkcijaGrXAkcijaGrX { get; set; }
        public long ID_AkcijaGrX { get; set; }
        public long ID_AkcijaGrXNad { get; set; }
    }
}
