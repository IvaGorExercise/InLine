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
    
    public partial class ShemaStItem 
    {
    
    	public ShemaStItem() {}
    	public ShemaStItem(long? id_ShemaSt)
    	{
    		ID_ShemaSt = id_ShemaSt;
    	}
    
        public long? ID
    	{
    		get { return this.ID_ShemaSt; }
    		set { this.ID_ShemaSt = value; }
    	}
        public long? ID_ShemaSt { get; set; }
        public long? ID_Shema { get; set; }
        public long? ID_KontniPlanSt { get; set; }
        public bool? Potrazuje { get; set; }
        public bool? Negativno { get; set; }
        public bool? Sintetika { get; set; }
    
    	public ShemaStItem(Model.Data.ShemaSt item)
    	{
    	    this.ID_ShemaSt = item.ID_ShemaSt;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanSt = item.ID_KontniPlanSt;
        this.Potrazuje = item.Potrazuje;
        this.Negativno = item.Negativno;
        this.Sintetika = item.Sintetika;
    	}
    
    	public ShemaStItem(dynamic item)
    	{
    	    this.ID_ShemaSt = item.ID_ShemaSt;
        this.ID_Shema = item.ID_Shema;
        this.ID_KontniPlanSt = item.ID_KontniPlanSt;
        this.Potrazuje = item.Potrazuje;
        this.Negativno = item.Negativno;
        this.Sintetika = item.Sintetika;
    	}
    }
}
