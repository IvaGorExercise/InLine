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
    
    public partial class UgovorStanOtkupTrosakItem 
    {
    
    	public UgovorStanOtkupTrosakItem() {}
    	public UgovorStanOtkupTrosakItem(long? id_UgovorStanOtkupTrosak)
    	{
    		ID_UgovorStanOtkupTrosak = id_UgovorStanOtkupTrosak;
    	}
    
        public long? ID
    	{
    		get { return this.ID_UgovorStanOtkupTrosak; }
    		set { this.ID_UgovorStanOtkupTrosak = value; }
    	}
        public long? ID_UgovorStanOtkupTrosak { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public DateTime? Datum { get; set; }
        public int? Godina { get; set; }
        public decimal? Iznos { get; set; }
        public int? BrojUgovor { get; set; }
        public int? BrojIzvod { get; set; }
        public int? BrojStavka { get; set; }
        public string IDValuta { get; set; }
        public DateTime? DatumInsert { get; set; }
        public string OsobaInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
    
    	public UgovorStanOtkupTrosakItem(Model.Data.UgovorStanOtkupTrosak item)
    	{
    	    this.ID_UgovorStanOtkupTrosak = item.ID_UgovorStanOtkupTrosak;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.Datum = item.Datum;
        this.Godina = item.Godina;
        this.Iznos = item.Iznos;
        this.BrojUgovor = item.BrojUgovor;
        this.BrojIzvod = item.BrojIzvod;
        this.BrojStavka = item.BrojStavka;
        this.IDValuta = item.IDValuta;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
    	}
    
    	public UgovorStanOtkupTrosakItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkupTrosak = item.ID_UgovorStanOtkupTrosak;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.Datum = item.Datum;
        this.Godina = item.Godina;
        this.Iznos = item.Iznos;
        this.BrojUgovor = item.BrojUgovor;
        this.BrojIzvod = item.BrojIzvod;
        this.BrojStavka = item.BrojStavka;
        this.IDValuta = item.IDValuta;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
    	}
    }
}
