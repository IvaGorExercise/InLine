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
    
    public partial class ObrazacRSmDopusteno2005AItem 
    {
    
    	public ObrazacRSmDopusteno2005AItem() {}
    	public ObrazacRSmDopusteno2005AItem(int? idObrazacRSmObveznikVr2005A)
    	{
    		IDObrazacRSmObveznikVr2005A = idObrazacRSmObveznikVr2005A;
    	}
    
        public int? IDObrazacRSmObveznikVr2005A { get; set; }
        public int? IDObrazacRSmObracunVr2005A { get; set; }
        public int? IDObrazacRSmOsiguranjeOsnova2005A { get; set; }
    
    	public ObrazacRSmDopusteno2005AItem(Model.Data.ObrazacRSmDopusteno2005A item)
    	{
    	    this.IDObrazacRSmObveznikVr2005A = item.IDObrazacRSmObveznikVr2005A;
        this.IDObrazacRSmObracunVr2005A = item.IDObrazacRSmObracunVr2005A;
        this.IDObrazacRSmOsiguranjeOsnova2005A = item.IDObrazacRSmOsiguranjeOsnova2005A;
    	}
    
    	public ObrazacRSmDopusteno2005AItem(dynamic item)
    	{
    	    this.IDObrazacRSmObveznikVr2005A = item.IDObrazacRSmObveznikVr2005A;
        this.IDObrazacRSmObracunVr2005A = item.IDObrazacRSmObracunVr2005A;
        this.IDObrazacRSmOsiguranjeOsnova2005A = item.IDObrazacRSmOsiguranjeOsnova2005A;
    	}
    }
}
