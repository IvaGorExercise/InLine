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
    
    public partial class KalendarGodinaItem 
    {
    
    	public KalendarGodinaItem() {}
    	public KalendarGodinaItem(int? godina)
    	{
    		Godina = godina;
    	}
    
        public int? Godina { get; set; }
    
    	public KalendarGodinaItem(Model.Data.KalendarGodina item)
    	{
    	    this.Godina = item.Godina;
    	}
    
    	public KalendarGodinaItem(dynamic item)
    	{
    	    this.Godina = item.Godina;
    	}
    }
}
