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
    
    public partial class OdbitakGrOdbitakItem 
    {
    
    	public OdbitakGrOdbitakItem() {}
    	public OdbitakGrOdbitakItem(long? id_OdbitakGrOdbitak)
    	{
    		ID_OdbitakGrOdbitak = id_OdbitakGrOdbitak;
    	}
    
        public long? ID
    	{
    		get { return this.ID_OdbitakGrOdbitak; }
    		set { this.ID_OdbitakGrOdbitak = value; }
    	}
        public long? ID_OdbitakGrOdbitak { get; set; }
        public long? ID_OdbitakGr { get; set; }
        public long? ID_Odbitak { get; set; }
    
    	public OdbitakGrOdbitakItem(Model.Data.OdbitakGrOdbitak item)
    	{
    	    this.ID_OdbitakGrOdbitak = item.ID_OdbitakGrOdbitak;
        this.ID_OdbitakGr = item.ID_OdbitakGr;
        this.ID_Odbitak = item.ID_Odbitak;
    	}
    
    	public OdbitakGrOdbitakItem(dynamic item)
    	{
    	    this.ID_OdbitakGrOdbitak = item.ID_OdbitakGrOdbitak;
        this.ID_OdbitakGr = item.ID_OdbitakGr;
        this.ID_Odbitak = item.ID_Odbitak;
    	}
    }
}
