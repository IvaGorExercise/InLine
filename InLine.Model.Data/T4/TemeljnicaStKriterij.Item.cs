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
    
    public partial class TemeljnicaStKriterijItem 
    {
    
    	public TemeljnicaStKriterijItem() {}
    	public TemeljnicaStKriterijItem(long? id_TemeljnicaStKriterij)
    	{
    		ID_TemeljnicaStKriterij = id_TemeljnicaStKriterij;
    	}
    
        public long? ID
    	{
    		get { return this.ID_TemeljnicaStKriterij; }
    		set { this.ID_TemeljnicaStKriterij = value; }
    	}
        public long? ID_TemeljnicaStKriterij { get; set; }
        public long? ID_TemeljnicaSt { get; set; }
        public long? ID_Kriterij { get; set; }
        public long? ID_KriterijSt { get; set; }
    
    	public TemeljnicaStKriterijItem(Model.Data.TemeljnicaStKriterij item)
    	{
    	    this.ID_TemeljnicaStKriterij = item.ID_TemeljnicaStKriterij;
        this.ID_TemeljnicaSt = item.ID_TemeljnicaSt;
        this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KriterijSt = item.ID_KriterijSt;
    	}
    
    	public TemeljnicaStKriterijItem(dynamic item)
    	{
    	    this.ID_TemeljnicaStKriterij = item.ID_TemeljnicaStKriterij;
        this.ID_TemeljnicaSt = item.ID_TemeljnicaSt;
        this.ID_Kriterij = item.ID_Kriterij;
        this.ID_KriterijSt = item.ID_KriterijSt;
    	}
    }
}
