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
    
    public partial class AkcijaGrXItem : Model.Admin.AkcijaGrX
    {
    
    	public AkcijaGrXItem() {}
    	public AkcijaGrXItem(long id_AkcijaGrX)
    	{
    		ID_AkcijaGrX = id_AkcijaGrX;
    	}
        public long ID
    	{
    		get { return this.ID_AkcijaGrX; }
    		set { this.ID_AkcijaGrX = value; }
    	}
        public long ID_AkcijaGrX { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Napomena { get; set; }
    }
}
