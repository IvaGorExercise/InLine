//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Data.Item.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class TemeljnicaTemeljnicaVrGlavnaKnjigaItem 
    {
    
    	public TemeljnicaTemeljnicaVrGlavnaKnjigaItem() {}
    	public TemeljnicaTemeljnicaVrGlavnaKnjigaItem(long? id_Temeljnica, long? id_TemeljnicaVr, long? id_GlavnaKnjiga, long? id_KontniPlan)
    	{
    		ID_Temeljnica = id_Temeljnica;
    		ID_TemeljnicaVr = id_TemeljnicaVr;
    		ID_GlavnaKnjiga = id_GlavnaKnjiga;
    		ID_KontniPlan = id_KontniPlan;
    	}
    
        public long? ID_Temeljnica { get; set; }
        public long? ID_TemeljnicaVr { get; set; }
        public long? ID_GlavnaKnjiga { get; set; }
        public long? ID_KontniPlan { get; set; }
    
    	public TemeljnicaTemeljnicaVrGlavnaKnjigaItem(Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga item)
    	{
    	    this.ID_Temeljnica = item.ID_Temeljnica;
        this.ID_TemeljnicaVr = item.ID_TemeljnicaVr;
        this.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
        this.ID_KontniPlan = item.ID_KontniPlan;
    	}
    
    	public TemeljnicaTemeljnicaVrGlavnaKnjigaItem(dynamic item)
    	{
    	    this.ID_Temeljnica = item.ID_Temeljnica;
        this.ID_TemeljnicaVr = item.ID_TemeljnicaVr;
        this.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
        this.ID_KontniPlan = item.ID_KontniPlan;
    	}
    }
}
