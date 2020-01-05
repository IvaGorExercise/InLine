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
    
    public partial class IzvodTemeljnicaItem 
    {
    
    	public IzvodTemeljnicaItem() {}
    	public IzvodTemeljnicaItem(long? id_IzvodTemeljnica)
    	{
    		ID_IzvodTemeljnica = id_IzvodTemeljnica;
    	}
    
        public long? ID
    	{
    		get { return this.ID_IzvodTemeljnica; }
    		set { this.ID_IzvodTemeljnica = value; }
    	}
        public long? ID_IzvodTemeljnica { get; set; }
        public long? ID_Izvod { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public decimal? SaldoStaro { get; set; }
        public decimal? SaldoNovo { get; set; }
        public string TemeljnicaStatus { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public long? ID_Temeljnica { get; set; }
    
    	public IzvodTemeljnicaItem(Model.Data.IzvodTemeljnica item)
    	{
    	    this.ID_IzvodTemeljnica = item.ID_IzvodTemeljnica;
        this.ID_Izvod = item.ID_Izvod;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.SaldoStaro = item.SaldoStaro;
        this.SaldoNovo = item.SaldoNovo;
        this.TemeljnicaStatus = item.TemeljnicaStatus;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.ID_Temeljnica = item.ID_Temeljnica;
    	}
    
    	public IzvodTemeljnicaItem(dynamic item)
    	{
    	    this.ID_IzvodTemeljnica = item.ID_IzvodTemeljnica;
        this.ID_Izvod = item.ID_Izvod;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.SaldoStaro = item.SaldoStaro;
        this.SaldoNovo = item.SaldoNovo;
        this.TemeljnicaStatus = item.TemeljnicaStatus;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.ID_Temeljnica = item.ID_Temeljnica;
    	}
    }
}