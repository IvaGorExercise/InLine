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
    
    public partial class UgovorStanOtkupObrokPreplataDetaljItem 
    {
    
    	public UgovorStanOtkupObrokPreplataDetaljItem() {}
    	public UgovorStanOtkupObrokPreplataDetaljItem(long? id_UgovorStanOtkupObrokPreplata, bool? aktivno)
    	{
    		ID_UgovorStanOtkupObrokPreplata = id_UgovorStanOtkupObrokPreplata;
    		Aktivno = aktivno;
    	}
    
        public long? ID_UgovorStanOtkupObrokPreplata { get; set; }
        public long? ID_UgovorStanOtkupObrok { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? IznosPreplata { get; set; }
        public int? BrojUgovor { get; set; }
        public int? Broj { get; set; }
        public bool? Aktivno { get; set; }
        public long? ID_UgovorStanOtkup { get; set; }
        public int? BrojAneks { get; set; }
        public int? BrojStorno { get; set; }
        public int? BrojObrok { get; set; }
        public decimal? IznosPreplataValuta { get; set; }
        public int? BrojPreplata { get; set; }
        public string IDValuta { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public DateTime? DatumInsert { get; set; }
        public string OsobaInsert { get; set; }
        public DateTime? DatumUpdate { get; set; }
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public int? GodinaObrokFormiranje { get; set; }
        public int? MjesecObrokFormiranje { get; set; }
        public long? ID_PlacanjeVr { get; set; }
        public int? BrojObveznica { get; set; }
        public bool? NeZateznaKamata { get; set; }
        public long? ID_Racun { get; set; }
    
    	public UgovorStanOtkupObrokPreplataDetaljItem(Model.Data.View.UgovorStanOtkupObrokPreplataDetalj item)
    	{
    	    this.ID_UgovorStanOtkupObrokPreplata = item.ID_UgovorStanOtkupObrokPreplata;
        this.ID_UgovorStanOtkupObrok = item.ID_UgovorStanOtkupObrok;
        this.Datum = item.Datum;
        this.IznosPreplata = item.IznosPreplata;
        this.BrojUgovor = item.BrojUgovor;
        this.Broj = item.Broj;
        this.Aktivno = item.Aktivno;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojAneks = item.BrojAneks;
        this.BrojStorno = item.BrojStorno;
        this.BrojObrok = item.BrojObrok;
        this.IznosPreplataValuta = item.IznosPreplataValuta;
        this.BrojPreplata = item.BrojPreplata;
        this.IDValuta = item.IDValuta;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.GodinaObrokFormiranje = item.GodinaObrokFormiranje;
        this.MjesecObrokFormiranje = item.MjesecObrokFormiranje;
        this.ID_PlacanjeVr = item.ID_PlacanjeVr;
        this.BrojObveznica = item.BrojObveznica;
        this.NeZateznaKamata = item.NeZateznaKamata;
        this.ID_Racun = item.ID_Racun;
    	}
    
    	public UgovorStanOtkupObrokPreplataDetaljItem(dynamic item)
    	{
    	    this.ID_UgovorStanOtkupObrokPreplata = item.ID_UgovorStanOtkupObrokPreplata;
        this.ID_UgovorStanOtkupObrok = item.ID_UgovorStanOtkupObrok;
        this.Datum = item.Datum;
        this.IznosPreplata = item.IznosPreplata;
        this.BrojUgovor = item.BrojUgovor;
        this.Broj = item.Broj;
        this.Aktivno = item.Aktivno;
        this.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
        this.BrojAneks = item.BrojAneks;
        this.BrojStorno = item.BrojStorno;
        this.BrojObrok = item.BrojObrok;
        this.IznosPreplataValuta = item.IznosPreplataValuta;
        this.BrojPreplata = item.BrojPreplata;
        this.IDValuta = item.IDValuta;
        this.TemeljnicaGodina = item.TemeljnicaGodina;
        this.TemeljnicaBroj = item.TemeljnicaBroj;
        this.TemeljnicaVrsta = item.TemeljnicaVrsta;
        this.DatumInsert = item.DatumInsert;
        this.OsobaInsert = item.OsobaInsert;
        this.DatumUpdate = item.DatumUpdate;
        this.OsobaUpdate = item.OsobaUpdate;
        this.ID_OsobaInsert = item.ID_OsobaInsert;
        this.ID_OsobaUpdate = item.ID_OsobaUpdate;
        this.GodinaObrokFormiranje = item.GodinaObrokFormiranje;
        this.MjesecObrokFormiranje = item.MjesecObrokFormiranje;
        this.ID_PlacanjeVr = item.ID_PlacanjeVr;
        this.BrojObveznica = item.BrojObveznica;
        this.NeZateznaKamata = item.NeZateznaKamata;
        this.ID_Racun = item.ID_Racun;
    	}
    }
}
