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
    
    public partial class IzvodStItem 
    {
    
    	public IzvodStItem() {}
    	public IzvodStItem(long? id_IzvodSt)
    	{
    		ID_IzvodSt = id_IzvodSt;
    	}
    
        public long? ID
    	{
    		get { return this.ID_IzvodSt; }
    		set { this.ID_IzvodSt = value; }
    	}
        public long? ID_IzvodSt { get; set; }
        public long? ID_Izvod { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public decimal? IznosDugujeValuta { get; set; }
        public decimal? IznosPotrazujeValuta { get; set; }
        public long? ID_Subjekt { get; set; }
    
    	public IzvodStItem(Model.Data.IzvodSt item)
    	{
    	    this.ID_IzvodSt = item.ID_IzvodSt;
        this.ID_Izvod = item.ID_Izvod;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    
    	public IzvodStItem(dynamic item)
    	{
    	    this.ID_IzvodSt = item.ID_IzvodSt;
        this.ID_Izvod = item.ID_Izvod;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.ID_Subjekt = item.ID_Subjekt;
    	}
    }
}
