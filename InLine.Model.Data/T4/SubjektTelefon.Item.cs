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
    
    public partial class SubjektTelefonItem 
    {
    
    	public SubjektTelefonItem() {}
    	public SubjektTelefonItem(long? id_SubjektTelefon)
    	{
    		ID_SubjektTelefon = id_SubjektTelefon;
    	}
    
        public long? ID
    	{
    		get { return this.ID_SubjektTelefon; }
    		set { this.ID_SubjektTelefon = value; }
    	}
        public long? ID_SubjektTelefon { get; set; }
        public long? ID_Subjekt { get; set; }
        public string Broj { get; set; }
    
    	public SubjektTelefonItem(Model.Data.SubjektTelefon item)
    	{
    	    this.ID_SubjektTelefon = item.ID_SubjektTelefon;
        this.ID_Subjekt = item.ID_Subjekt;
        this.Broj = item.Broj;
    	}
    
    	public SubjektTelefonItem(dynamic item)
    	{
    	    this.ID_SubjektTelefon = item.ID_SubjektTelefon;
        this.ID_Subjekt = item.ID_Subjekt;
        this.Broj = item.Broj;
    	}
    }
}
