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
    
    public partial class UgovorStanOtkupObrokIznosItem 
    {
    
    	public UgovorStanOtkupObrokIznosItem() {}
    	public UgovorStanOtkupObrokIznosItem(long? id_UgovorStanOtkup)
    	{
    		ID_UgovorStanOtkup = id_UgovorStanOtkup;
    	}
    
        public long? ID_UgovorStanOtkup { get; set; }
        public decimal? IznosKredit { get; set; }
        public decimal? IznosKreditRevalorizacija { get; set; }
        public decimal? IznosKamata { get; set; }
        public decimal? IznosKamataRevalorizacija { get; set; }
        public decimal? IznosKreditOstatakRevalorizacija { get; set; }
        public decimal? IznosKamataOstatakRevalorizacija { get; set; }
        public decimal? IznosUcesce { get; set; }
        public int? BrojObrokMax { get; set; }
    
    	public UgovorStanOtkupObrokIznosItem(Model.Data.View.UgovorStanOtkupObrokIznos item)
    	{
    	    this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.IznosKredit = item.IznosKredit;
        this.IznosKreditRevalorizacija = item.IznosKreditRevalorizacija;
        this.IznosKamata = item.IznosKamata;
        this.IznosKamataRevalorizacija = item.IznosKamataRevalorizacija;
        this.IznosKreditOstatakRevalorizacija = item.IznosKreditOstatakRevalorizacija;
        this.IznosKamataOstatakRevalorizacija = item.IznosKamataOstatakRevalorizacija;
        this.IznosUcesce = item.IznosUcesce;
        this.BrojObrokMax = item.BrojObrokMax;
    	}
    
    	public UgovorStanOtkupObrokIznosItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.IznosKredit = item.IznosKredit;
        this.IznosKreditRevalorizacija = item.IznosKreditRevalorizacija;
        this.IznosKamata = item.IznosKamata;
        this.IznosKamataRevalorizacija = item.IznosKamataRevalorizacija;
        this.IznosKreditOstatakRevalorizacija = item.IznosKreditOstatakRevalorizacija;
        this.IznosKamataOstatakRevalorizacija = item.IznosKamataOstatakRevalorizacija;
        this.IznosUcesce = item.IznosUcesce;
        this.BrojObrokMax = item.BrojObrokMax;
    	}
    }
}
