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
    
    public partial class IzvodStTemeljnicaItem 
    {
    
    	public IzvodStTemeljnicaItem() {}
    	public IzvodStTemeljnicaItem(long? id_IzvodStTemeljnica)
    	{
    		ID_IzvodStTemeljnica = id_IzvodStTemeljnica;
    	}
    
        public long? ID
    	{
    		get { return this.ID_IzvodStTemeljnica; }
    		set { this.ID_IzvodStTemeljnica = value; }
    	}
        public long? ID_IzvodStTemeljnica { get; set; }
        public long? ID_IzvodSt { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public decimal? IznosDugujeValuta { get; set; }
        public decimal? IznosPotrazujeValuta { get; set; }
        public long? ID_DokumentVr { get; set; }
    
    	public IzvodStTemeljnicaItem(Model.Data.IzvodStTemeljnica item)
    	{
    	    this.ID_IzvodStTemeljnica = item.ID_IzvodStTemeljnica;
        this.ID_IzvodSt = item.ID_IzvodSt;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.ID_DokumentVr = item.ID_DokumentVr;
    	}
    
    	public IzvodStTemeljnicaItem(dynamic item)
    	{
    	    this.ID_IzvodStTemeljnica = item.ID_IzvodStTemeljnica;
        this.ID_IzvodSt = item.ID_IzvodSt;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.ID_DokumentVr = item.ID_DokumentVr;
    	}
    }
}