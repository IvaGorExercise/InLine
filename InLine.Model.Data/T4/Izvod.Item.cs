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
    
    public partial class IzvodItem 
    {
    
    	public IzvodItem() {}
    	public IzvodItem(long? id_Izvod)
    	{
    		ID_Izvod = id_Izvod;
    	}
    
        public long? ID
    	{
    		get { return this.ID_Izvod; }
    		set { this.ID_Izvod = value; }
    	}
        public long? ID_Izvod { get; set; }
        public long? ID_Zapis { get; set; }
        public int? IDIzvodVerzija { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public decimal? SaldoStaro { get; set; }
        public decimal? SaldoNovo { get; set; }
        public long? ID_SubjektRacun { get; set; }
    
    	public IzvodItem(Model.Data.Izvod item)
    	{
    	    this.ID_Izvod = item.ID_Izvod;
        this.ID_Zapis = item.ID_Zapis;
        this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.SaldoStaro = item.SaldoStaro;
        this.SaldoNovo = item.SaldoNovo;
        this.ID_SubjektRacun = item.ID_SubjektRacun;
    	}
    
    	public IzvodItem(dynamic item)
    	{
    	    this.ID_Izvod = item.ID_Izvod;
        this.ID_Zapis = item.ID_Zapis;
        this.IDIzvodVerzija = item.IDIzvodVerzija;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.SaldoStaro = item.SaldoStaro;
        this.SaldoNovo = item.SaldoNovo;
        this.ID_SubjektRacun = item.ID_SubjektRacun;
    	}
    }
}
