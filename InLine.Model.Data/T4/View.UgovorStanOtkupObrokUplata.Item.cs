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
    
    public partial class UgovorStanOtkupObrokUplataItem 
    {
    
    	public UgovorStanOtkupObrokUplataItem() {}
    	public UgovorStanOtkupObrokUplataItem(long? id_UgovorStanOtkupObrokUplata)
    	{
    		ID_UgovorStanOtkupObrokUplata = id_UgovorStanOtkupObrokUplata;
    	}
    
        public long? ID_UgovorStanOtkupObrokUplata { get; set; }
        public long? ID_UgovorStanOtkupObrok { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojUgovor { get; set; }
        public decimal? SumaUplata { get; set; }
        public decimal? SumaZateznaKamata { get; set; }
        public decimal? IznosZateznaKamataDugOstatak { get; set; }
        public decimal? IznosObrokDugOstatak { get; set; }
        public int? BrojObrok { get; set; }
    
    	public UgovorStanOtkupObrokUplataItem(Model.Data.View.UgovorStanOtkupObrokUplata item)
    	{
    	    this.ID_UgovorStanOtkupObrokUplata = item.ID_UgovorStanOtkupObrokUplata;
        this.ID_UgovorStanOtkupObrok = item.ID_UgovorStanOtkupObrok;
        this.Datum = item.Datum;
        this.BrojUgovor = item.BrojUgovor;
        this.SumaUplata = item.SumaUplata;
        this.SumaZateznaKamata = item.SumaZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.IznosObrokDugOstatak = item.IznosObrokDugOstatak;
        this.BrojObrok = item.BrojObrok;
    	}
    
    	public UgovorStanOtkupObrokUplataItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkupObrokUplata = item.ID_UgovorStanOtkupObrokUplata;
        this.ID_UgovorStanOtkupObrok = item.ID_UgovorStanOtkupObrok;
        this.Datum = item.Datum;
        this.BrojUgovor = item.BrojUgovor;
        this.SumaUplata = item.SumaUplata;
        this.SumaZateznaKamata = item.SumaZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.IznosObrokDugOstatak = item.IznosObrokDugOstatak;
        this.BrojObrok = item.BrojObrok;
    	}
    }
}