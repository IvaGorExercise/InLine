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
    
    public partial class RacunIzlazItem 
    {
    
    	public RacunIzlazItem() {}
    	public RacunIzlazItem(long? id_RacunIzlaz)
    	{
    		ID_RacunIzlaz = id_RacunIzlaz;
    	}
    
        public long? ID
    	{
    		get { return this.ID_RacunIzlaz; }
    		set { this.ID_RacunIzlaz = value; }
    	}
        public long? ID_RacunIzlaz { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_PoslovniSubjekt { get; set; }
        public long? ID_Subjekt { get; set; }
    
    	public RacunIzlazItem(Model.Data.RacunIzlaz item)
    	{
    	    this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    
    	public RacunIzlazItem(dynamic item)
    	{
    	    this.ID_RacunIzlaz = item.ID_RacunIzlaz;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    }
}
