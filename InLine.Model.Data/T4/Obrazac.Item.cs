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
    
    public partial class ObrazacItem 
    {
    
    	public ObrazacItem() {}
    	public ObrazacItem(long? id_Obrazac)
    	{
    		ID_Obrazac = id_Obrazac;
    	}
    
        public long? ID
    	{
    		get { return this.ID_Obrazac; }
    		set { this.ID_Obrazac = value; }
    	}
        public long? ID_Obrazac { get; set; }
        public long? ID_ObrazacVr { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_Poduzece { get; set; }
        public long? ID_Primatelj { get; set; }
    
    	public ObrazacItem(Model.Data.Obrazac item)
    	{
    	    this.ID_Obrazac = item.ID_Obrazac;
        this.ID_ObrazacVr = item.ID_ObrazacVr;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_Poduzece = item.ID_Poduzece;
        this.ID_Primatelj = item.ID_Primatelj;
    	}
    
    	public ObrazacItem(dynamic item)
    	{
    	    this.ID_Obrazac = item.ID_Obrazac;
        this.ID_ObrazacVr = item.ID_ObrazacVr;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_Poduzece = item.ID_Poduzece;
        this.ID_Primatelj = item.ID_Primatelj;
    	}
    }
}