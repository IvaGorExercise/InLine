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
    
    public partial class GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektItem 
    {
    
    	public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektItem() {}
    	public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektItem(long? id_GlavnaKnjiga)
    	{
    		ID_GlavnaKnjiga = id_GlavnaKnjiga;
    	}
    
        public long? ID_GlavnaKnjiga { get; set; }
        public long? ID_KontniPlan { get; set; }
        public long? ID_PoslovnaGodina { get; set; }
        public long? ID_PoslovniSubjekt { get; set; }
        public long? ID_Subjekt { get; set; }
        public string Naziv { get; set; }
        public string OIB { get; set; }
        public int? Godina { get; set; }
        public string IDValuta { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public int? AnalitikaOd { get; set; }
        public string Oznaka { get; set; }
    
    	public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektItem(Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt item)
    	{
    	    this.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_PoslovnaGodina = item.ID_PoslovnaGodina;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.Naziv = item.Naziv;
        this.OIB = item.OIB;
        this.Godina = item.Godina;
        this.IDValuta = item.IDValuta;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.AnalitikaOd = item.AnalitikaOd;
        this.Oznaka = item.Oznaka;
    	}
    
    	public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektItem(dynamic item)
    	{
    	    this.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
        this.ID_KontniPlan = item.ID_KontniPlan;
        this.ID_PoslovnaGodina = item.ID_PoslovnaGodina;
        this.ID_PoslovniSubjekt = item.ID_PoslovniSubjekt;
        this.ID_Subjekt = item.ID_Subjekt;
        this.Naziv = item.Naziv;
        this.OIB = item.OIB;
        this.Godina = item.Godina;
        this.IDValuta = item.IDValuta;
        this.DatumOd = item.DatumOd;
        this.DatumDo = item.DatumDo;
        this.AnalitikaOd = item.AnalitikaOd;
        this.Oznaka = item.Oznaka;
    	}
    }
}
