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
    
    public partial class DohodakOdbitakItem 
    {
    
    	public DohodakOdbitakItem() {}
    	public DohodakOdbitakItem(long? id_DohodakOdbitak)
    	{
    		ID_DohodakOdbitak = id_DohodakOdbitak;
    	}
    
        public long? ID
    	{
    		get { return this.ID_DohodakOdbitak; }
    		set { this.ID_DohodakOdbitak = value; }
    	}
        public long? ID_DohodakOdbitak { get; set; }
        public long? ID_Dohodak { get; set; }
        public long? ID_Odbitak { get; set; }
    
    	public DohodakOdbitakItem(Model.Data.DohodakOdbitak item)
    	{
    	    this.ID_DohodakOdbitak = item.ID_DohodakOdbitak;
        this.ID_Dohodak = item.ID_Dohodak;
        this.ID_Odbitak = item.ID_Odbitak;
    	}
    
    	public DohodakOdbitakItem(dynamic item)
    	{
    	    this.ID_DohodakOdbitak = item.ID_DohodakOdbitak;
        this.ID_Dohodak = item.ID_Dohodak;
        this.ID_Odbitak = item.ID_Odbitak;
    	}
    }
}
