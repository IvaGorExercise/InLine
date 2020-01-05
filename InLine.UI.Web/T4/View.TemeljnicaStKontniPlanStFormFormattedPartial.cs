//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Web;
    using System.ComponentModel;
    using Lib.Web.Mvc.JQuery.JqGrid.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid;
    using System.ComponentModel.DataAnnotations;
    using Lib.Web.Mvc.JQuery.JqGrid.Constants;
    using System.Web.Mvc;
    using InLine;
    using InLine.UI.Web.T4.FormFormattedTemplate;
    using InLine.UI.Web.Helper;
    
    
    public partial class TemeljnicaStKontniPlanStFormFormattedBase
    {
    	#region Properities
    
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlanSt.DisplayName)]
       	public Nullable<long> ID_KontniPlanSt { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Naziv.StringLength)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_TemeljnicaVr.DisplayName)]
       	public Nullable<long> ID_TemeljnicaVr { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_GlavnaKnjiga.DisplayName)]
       	public Nullable<long> ID_GlavnaKnjiga { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.DisplayName)]
       	public long ID_KontniPlan { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Konto.StringLength)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Konto.DisplayName)]
       	public string Konto { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.DisplayName)]
       	public int SaldoKonti { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Zapis.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Zapis.DisplayName)]
       	public int Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Subjekt.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Subjekt.DisplayName)]
       	public int Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Objekt.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Objekt.DisplayName)]
       	public int Objekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Davanje.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Davanje.DisplayName)]
       	public int Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.Required)]
    	[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.DisplayName)]
       	public int AnalitikaOd { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public TemeljnicaStKontniPlanStFormFormattedBase()
        { }
    	
    	public TemeljnicaStKontniPlanStFormFormattedBase(Model.Data.View.TemeljnicaStKontniPlanSt formformated)
    	{
    	    this.ID_KontniPlanSt = formformated.ID_KontniPlanSt;
    	    this.Naziv = formformated.Naziv;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.ID_TemeljnicaVr = formformated.ID_TemeljnicaVr;
    	    this.ID_GlavnaKnjiga = formformated.ID_GlavnaKnjiga;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.Konto = formformated.Konto;
    	    this.SaldoKonti = formformated.SaldoKonti;
    	    this.Zapis = formformated.Zapis;
    	    this.Subjekt = formformated.Subjekt;
    	    this.Objekt = formformated.Objekt;
    	    this.Davanje = formformated.Davanje;
    	    this.AnalitikaOd = formformated.AnalitikaOd;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanSt = model.ID_KontniPlanSt;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.ID_TemeljnicaVr = model.ID_TemeljnicaVr;
    	    mymodel.ID_GlavnaKnjiga = model.ID_GlavnaKnjiga;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.Konto = model.Konto;
    	    mymodel.SaldoKonti = model.SaldoKonti;
    	    mymodel.Zapis = model.Zapis;
    	    mymodel.Subjekt = model.Subjekt;
    	    mymodel.Objekt = model.Objekt;
    	    mymodel.Davanje = model.Davanje;
    	    mymodel.AnalitikaOd = model.AnalitikaOd;
    		
    	*/
    
    		#endregion
    	
    }
}