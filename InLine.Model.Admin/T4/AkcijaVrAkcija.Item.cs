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
    
    public partial class AkcijaVrAkcijaItem : Model.Admin.AkcijaVrAkcija
    {
    
    	public AkcijaVrAkcijaItem() {}
    	public AkcijaVrAkcijaItem(int akcijaVr, int akcija)
    	{
    		AkcijaVr = akcijaVr;
    		Akcija = akcija;
    	}
        public int AkcijaVr { get; set; }
        public int Akcija { get; set; }
    }
}
