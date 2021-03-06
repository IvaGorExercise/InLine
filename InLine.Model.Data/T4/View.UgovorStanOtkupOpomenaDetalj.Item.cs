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
    
    public partial class UgovorStanOtkupOpomenaDetaljItem 
    {
    
    	public UgovorStanOtkupOpomenaDetaljItem() {}
    	public UgovorStanOtkupOpomenaDetaljItem(long? id_UgovorStanOtkupOpomena)
    	{
    		ID_UgovorStanOtkupOpomena = id_UgovorStanOtkupOpomena;
    	}
    
        public long? ID_UgovorStanOtkupOpomena { get; set; }
        public long? ID_Opomena { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public int? BrojOpomena { get; set; }
        public int? BrojUgovor { get; set; }
        public decimal? IznosDug { get; set; }
        public decimal? IznosZateznaKamata { get; set; }
        public decimal? IznosZateznaKamataDugOstatak { get; set; }
        public DateTime? DatumInsertUSOO { get; set; }
        public string OsobaInsertUSOO { get; set; }
        public DateTime? DatumUpdateUSOO { get; set; }
        public string OsobaUpdateUSOO { get; set; }
        public long? ID_OsobaInsertUSOO { get; set; }
        public long? ID_OsobaUpdateUSOO { get; set; }
        public bool? Ispis { get; set; }
        public DateTime? Datum { get; set; }
        public int? BrojNeplaceniObrokMin { get; set; }
        public DateTime? DatumDospijeceDo { get; set; }
        public DateTime? DatumDospijeceOd { get; set; }
        public decimal? OpomenaIznosMin { get; set; }
        public DateTime? DatumInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaInsert { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
    
    	public UgovorStanOtkupOpomenaDetaljItem(Model.Data.View.UgovorStanOtkupOpomenaDetalj item)
    	{
    	    this.ID_UgovorStanOtkupOpomena = item.ID_UgovorStanOtkupOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojOpomena = item.BrojOpomena;
        this.BrojUgovor = item.BrojUgovor;
        this.IznosDug = item.IznosDug;
        this.IznosZateznaKamata = item.IznosZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.DatumInsertUSOO = item.DatumInsertUSOO;
        this.OsobaInsertUSOO = item.OsobaInsertUSOO;
        this.DatumUpdateUSOO = item.DatumUpdateUSOO;
        this.OsobaUpdateUSOO = item.OsobaUpdateUSOO;
        this.ID_OsobaInsertUSOO = item.ID_OsobaInsertUSOO;
        this.ID_OsobaUpdateUSOO = item.ID_OsobaUpdateUSOO;
        this.Ispis = item.Ispis;
        this.Datum = item.Datum;
        this.BrojNeplaceniObrokMin = item.BrojNeplaceniObrokMin;
        this.DatumDospijeceDo = item.DatumDospijeceDo;
        this.DatumDospijeceOd = item.DatumDospijeceOd;
        this.OpomenaIznosMin = item.OpomenaIznosMin;
        this.DatumInsert = item.DatumInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaInsert = item.OsobaInsert;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
    	}
    
    	public UgovorStanOtkupOpomenaDetaljItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkupOpomena = item.ID_UgovorStanOtkupOpomena;
        this.ID_Opomena = item.ID_Opomena;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojOpomena = item.BrojOpomena;
        this.BrojUgovor = item.BrojUgovor;
        this.IznosDug = item.IznosDug;
        this.IznosZateznaKamata = item.IznosZateznaKamata;
        this.IznosZateznaKamataDugOstatak = item.IznosZateznaKamataDugOstatak;
        this.DatumInsertUSOO = item.DatumInsertUSOO;
        this.OsobaInsertUSOO = item.OsobaInsertUSOO;
        this.DatumUpdateUSOO = item.DatumUpdateUSOO;
        this.OsobaUpdateUSOO = item.OsobaUpdateUSOO;
        this.ID_OsobaInsertUSOO = item.ID_OsobaInsertUSOO;
        this.ID_OsobaUpdateUSOO = item.ID_OsobaUpdateUSOO;
        this.Ispis = item.Ispis;
        this.Datum = item.Datum;
        this.BrojNeplaceniObrokMin = item.BrojNeplaceniObrokMin;
        this.DatumDospijeceDo = item.DatumDospijeceDo;
        this.DatumDospijeceOd = item.DatumDospijeceOd;
        this.OpomenaIznosMin = item.OpomenaIznosMin;
        this.DatumInsert = item.DatumInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaInsert = item.OsobaInsert;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
    	}
    }
}
