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
    
    public partial class TemeljnicaStItem 
    {
    
    	public TemeljnicaStItem() {}
    	public TemeljnicaStItem(long? id_TemeljnicaSt)
    	{
    		ID_TemeljnicaSt = id_TemeljnicaSt;
    	}
    
        public long? ID
    	{
    		get { return this.ID_TemeljnicaSt; }
    		set { this.ID_TemeljnicaSt = value; }
    	}
        public long? ID_TemeljnicaSt { get; set; }
        public long? ID_Temeljnica { get; set; }
        public int? RedniBroj { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? DatumDospijeca { get; set; }
        public long? ID_KontniPlanSt { get; set; }
        public long? ID_Subjekt { get; set; }
        public long? ID_Objekt { get; set; }
        public long? ID_Zapis { get; set; }
        public long? ID_Davanje { get; set; }
        public decimal? IznosDuguje { get; set; }
        public decimal? IznosPotrazuje { get; set; }
        public string IDValuta { get; set; }
        public decimal? IznosDugujeValuta { get; set; }
        public decimal? IznosPotrazujeValuta { get; set; }
        public decimal? Tecaj { get; set; }
        public long? ID_Tecaj { get; set; }
        public string Opis { get; set; }
        public string ZapisOpis { get; set; }
        public long? ID_KontniPlanAnalitika { get; set; }
    
    	public TemeljnicaStItem(Model.Data.TemeljnicaSt item)
    	{
    	    this.ID_TemeljnicaSt = item.ID_TemeljnicaSt;
        this.ID_Temeljnica = item.ID_Temeljnica;
        this.RedniBroj = item.RedniBroj;
        this.Datum = item.Datum;
        this.DatumDospijeca = item.DatumDospijeca;
        this.ID_KontniPlanSt = item.ID_KontniPlanSt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.ID_Objekt = item.ID_Objekt;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_Davanje = item.ID_Davanje;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IDValuta = item.IDValuta;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.Tecaj = item.Tecaj;
        this.ID_Tecaj = item.ID_Tecaj;
        this.Opis = item.Opis;
        this.ZapisOpis = item.ZapisOpis;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    
    	public TemeljnicaStItem(dynamic item)
    	{
    	    this.ID_TemeljnicaSt = item.ID_TemeljnicaSt;
        this.ID_Temeljnica = item.ID_Temeljnica;
        this.RedniBroj = item.RedniBroj;
        this.Datum = item.Datum;
        this.DatumDospijeca = item.DatumDospijeca;
        this.ID_KontniPlanSt = item.ID_KontniPlanSt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.ID_Objekt = item.ID_Objekt;
        this.ID_Zapis = item.ID_Zapis;
        this.ID_Davanje = item.ID_Davanje;
        this.IznosDuguje = item.IznosDuguje;
        this.IznosPotrazuje = item.IznosPotrazuje;
        this.IDValuta = item.IDValuta;
        this.IznosDugujeValuta = item.IznosDugujeValuta;
        this.IznosPotrazujeValuta = item.IznosPotrazujeValuta;
        this.Tecaj = item.Tecaj;
        this.ID_Tecaj = item.ID_Tecaj;
        this.Opis = item.Opis;
        this.ZapisOpis = item.ZapisOpis;
        this.ID_KontniPlanAnalitika = item.ID_KontniPlanAnalitika;
    	}
    }
}
