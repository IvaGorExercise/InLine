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
    
    public partial class ObrazacPoljeItem 
    {
    
    	public ObrazacPoljeItem() {}
    	public ObrazacPoljeItem(long? id_ObrazacPolje)
    	{
    		ID_ObrazacPolje = id_ObrazacPolje;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ObrazacPolje; }
    		set { this.ID_ObrazacPolje = value; }
    	}
        public long? ID_ObrazacPolje { get; set; }
        public long? ID_Obrazac { get; set; }
        public int? Redak { get; set; }
        public long? ID_ObrazacVrPolje { get; set; }
        public bool? ValueBit { get; set; }
        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
        public decimal? ValueMoney { get; set; }
        public DateTime? ValueDate { get; set; }
        public TimeSpan? ValueTime { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public decimal? ValueDecimal { get; set; }
    
    	public ObrazacPoljeItem(Model.Data.ObrazacPolje item)
    	{
    	    this.ID_ObrazacPolje = item.ID_ObrazacPolje;
        this.ID_Obrazac = item.ID_Obrazac;
        this.Redak = item.Redak;
        this.ID_ObrazacVrPolje = item.ID_ObrazacVrPolje;
        this.ValueBit = item.ValueBit;
        this.ValueString = item.ValueString;
        this.ValueInt = item.ValueInt;
        this.ValueMoney = item.ValueMoney;
        this.ValueDate = item.ValueDate;
        this.ValueTime = item.ValueTime;
        this.ValueDateTime = item.ValueDateTime;
        this.ValueDecimal = item.ValueDecimal;
    	}
    
    	public ObrazacPoljeItem(dynamic item)
    	{
    	    this.ID_ObrazacPolje = item.ID_ObrazacPolje;
        this.ID_Obrazac = item.ID_Obrazac;
        this.Redak = item.Redak;
        this.ID_ObrazacVrPolje = item.ID_ObrazacVrPolje;
        this.ValueBit = item.ValueBit;
        this.ValueString = item.ValueString;
        this.ValueInt = item.ValueInt;
        this.ValueMoney = item.ValueMoney;
        this.ValueDate = item.ValueDate;
        this.ValueTime = item.ValueTime;
        this.ValueDateTime = item.ValueDateTime;
        this.ValueDecimal = item.ValueDecimal;
    	}
    }
}