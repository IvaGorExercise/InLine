//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item
{
    using System;
    using System.Collections.Generic;
    
    public partial class KalendarGodinaDanItem : Model.Admin.KalendarGodinaDan
    {
    
    	public KalendarGodinaDanItem() {}
    	public KalendarGodinaDanItem(int godinaDan)
    	{
    		GodinaDan = godinaDan;
    	}
        public int GodinaDan { get; set; }
        public string Oznaka { get; set; }
    }
}
