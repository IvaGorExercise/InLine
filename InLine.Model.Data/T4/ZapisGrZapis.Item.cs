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
    
    public partial class ZapisGrZapisItem 
    {
    
    	public ZapisGrZapisItem() {}
    	public ZapisGrZapisItem(long? id_ZapisGrZapis)
    	{
    		ID_ZapisGrZapis = id_ZapisGrZapis;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZapisGrZapis; }
    		set { this.ID_ZapisGrZapis = value; }
    	}
        public long? ID_ZapisGrZapis { get; set; }
        public long? ID_ZapisGr { get; set; }
        public long? ID_Zapis { get; set; }
    
    	public ZapisGrZapisItem(Model.Data.ZapisGrZapis item)
    	{
    	    this.ID_ZapisGrZapis = item.ID_ZapisGrZapis;
        this.ID_ZapisGr = item.ID_ZapisGr;
        this.ID_Zapis = item.ID_Zapis;
    	}
    
    	public ZapisGrZapisItem(dynamic item)
    	{
    	    this.ID_ZapisGrZapis = item.ID_ZapisGrZapis;
        this.ID_ZapisGr = item.ID_ZapisGr;
        this.ID_Zapis = item.ID_Zapis;
    	}
    }
}
