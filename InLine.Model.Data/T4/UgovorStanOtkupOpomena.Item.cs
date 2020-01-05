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
    
    public partial class UgovorStanOtkupOpomenaItem 
    {
    
    	public UgovorStanOtkupOpomenaItem() {}
    	public UgovorStanOtkupOpomenaItem(long? id_UgovorStanOtkupOpomena)
    	{
    		ID_UgovorStanOtkupOpomena = id_UgovorStanOtkupOpomena;
    	}
    
        public long? ID
    	{
    		get { return this.ID_UgovorStanOtkupOpomena; }
    		set { this.ID_UgovorStanOtkupOpomena = value; }
    	}
        public long? ID_UgovorStanOtkupOpomena { get; set; }
        public long? ID_Opomena { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public int? BrojOpomena { get; set; }
        public int? BrojUgovor { get; set; }
        public decimal? IznosDug { get; set; }
        public decimal? IznosZateznaKamata { get; set; }
        public decimal? IznosZateznaKamataDugOstatak { get; set; }
        public DateTime? DatumInsert { get; set; }
        public string OsobaInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public bool? Ispis { get; set; }
    
    	public UgovorStanOtkupOpomenaItem(Model.Data.UgovorStanOtkupOpomena item)
    	{
    	    this.ID_UgovorStanOtkupOpomena = item.ID_UgovorStanOtkupOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojOpomena = item.BrojOpomena;
        this.BrojUgovor = item.BrojUgovor;
        this.IznosDug = item.IznosDug;
        this.IznosZateznaKamata = item.IznosZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.Ispis = item.Ispis;
    	}
    
    	public UgovorStanOtkupOpomenaItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkupOpomena = item.ID_UgovorStanOtkupOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojOpomena = item.BrojOpomena;
        this.BrojUgovor = item.BrojUgovor;
        this.IznosDug = item.IznosDug;
        this.IznosZateznaKamata = item.IznosZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.Ispis = item.Ispis;
    	}
    }
}
