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
    
    public partial class ZapisGrZapisGrItem 
    {
    
    	public ZapisGrZapisGrItem() {}
    	public ZapisGrZapisGrItem(long? id_ZapisGrZapisGr)
    	{
    		ID_ZapisGrZapisGr = id_ZapisGrZapisGr;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZapisGrZapisGr; }
    		set { this.ID_ZapisGrZapisGr = value; }
    	}
        public long? ID_ZapisGrZapisGr { get; set; }
        public long? ID_ZapisGr { get; set; }
        public long? ID_ZapisGrNad { get; set; }
    
    	public ZapisGrZapisGrItem(Model.Data.ZapisGrZapisGr item)
    	{
    	    this.ID_ZapisGrZapisGr = item.ID_ZapisGrZapisGr;
        this.ID_ZapisGr = item.ID_ZapisGr;
        this.ID_ZapisGrNad = item.ID_ZapisGrNad;
    	}
    
    	public ZapisGrZapisGrItem(dynamic item)
    	{
    	    this.ID_ZapisGrZapisGr = item.ID_ZapisGrZapisGr;
        this.ID_ZapisGr = item.ID_ZapisGr;
        this.ID_ZapisGrNad = item.ID_ZapisGrNad;
    	}
    }
}
