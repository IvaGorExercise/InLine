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
    
    public partial class ZateznaKamataItem 
    {
    
    	public ZateznaKamataItem() {}
    	public ZateznaKamataItem(long? id_ZateznaKamata)
    	{
    		ID_ZateznaKamata = id_ZateznaKamata;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ZateznaKamata; }
    		set { this.ID_ZateznaKamata = value; }
    	}
        public long? ID_ZateznaKamata { get; set; }
        public DateTime? DatumOd { get; set; }
        public decimal? Stopa { get; set; }
    
    	public ZateznaKamataItem(Model.Data.ZateznaKamata item)
    	{
    	    this.ID_ZateznaKamata = item.ID_ZateznaKamata;
        this.DatumOd = item.DatumOd;
        this.Stopa = item.Stopa;
    	}
    
    	public ZateznaKamataItem(dynamic item)
    	{
    	    this.ID_ZateznaKamata = item.ID_ZateznaKamata;
        this.DatumOd = item.DatumOd;
        this.Stopa = item.Stopa;
    	}
    }
}