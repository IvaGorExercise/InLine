//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpolItem 
    {
    
    	public SpolItem() {}
    	public SpolItem(string idSpol)
    	{
    		IDSpol = idSpol;
    	}
    
        public string IDSpol { get; set; }
        public string Naziv { get; set; }
        public string NazivKr { get; set; }
        public string Kratica { get; set; }
    
    	public SpolItem(Model.Data.Spol item)
    	{
    	    this.IDSpol = item.IDSpol;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    
    	public SpolItem(dynamic item)
    	{
    	    this.IDSpol = item.IDSpol;
        this.Naziv = item.Naziv;
        this.NazivKr = item.NazivKr;
        this.Kratica = item.Kratica;
    	}
    }
}
