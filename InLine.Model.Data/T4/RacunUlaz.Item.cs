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
    
    public partial class RacunUlazItem 
    {
    
    	public RacunUlazItem() {}
    	public RacunUlazItem(long? id_RacunUlaz)
    	{
    		ID_RacunUlaz = id_RacunUlaz;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RacunUlaz; }
    		set { this.ID_RacunUlaz = value; }
    	}
        public long? ID_RacunUlaz { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_PoslovniSubjekt { get; set; }
        public long? ID_Subjekt { get; set; }
    
    	public RacunUlazItem(Model.Data.RacunUlaz item)
    	{
    	    this.ID_RacunUlaz = item.ID_RacunUlaz;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    
    	public RacunUlazItem(dynamic item)
    	{
    	    this.ID_RacunUlaz = item.ID_RacunUlaz;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    }
}
