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
    
    
    public partial class GlavnaKnjigaKontniPlanKontniPlanStFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.ID_GlavnaKnjiga.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.ID_GlavnaKnjiga.DisplayName)]
       	public long ID_GlavnaKnjiga { get; set; }
    
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.ID_KontniPlan.DisplayName)]
       	public Nullable<long> ID_KontniPlan { get; set; }
    
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.ID_KontniPlanSt.DisplayName)]
       	public Nullable<long> ID_KontniPlanSt { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Naziv.StringLength)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Konto.StringLength)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Konto.DisplayName)]
       	public string Konto { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.SaldoKonti.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.SaldoKonti.DisplayName)]
       	public int SaldoKonti { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Zapis.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Zapis.DisplayName)]
       	public int Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Subjekt.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Subjekt.DisplayName)]
       	public int Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Objekt.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Objekt.DisplayName)]
       	public int Objekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Davanje.Required)]
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.Davanje.DisplayName)]
       	public int Davanje { get; set; }
    
    	[DisplayName(AtributClass.GlavnaKnjigaKontniPlanKontniPlanSt.AnalitikaOd.DisplayName)]
       	public Nullable<int> AnalitikaOd { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public GlavnaKnjigaKontniPlanKontniPlanStFormFormattedBase()
        { }
    	
    	public GlavnaKnjigaKontniPlanKontniPlanStFormFormattedBase(Model.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt formformated)
    	{
    	    this.ID_GlavnaKnjiga = formformated.ID_GlavnaKnjiga;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.ID_KontniPlanSt = formformated.ID_KontniPlanSt;
    	    this.Naziv = formformated.Naziv;
    	    this.Konto = formformated.Konto;
    	    this.SaldoKonti = formformated.SaldoKonti;
    	    this.Zapis = formformated.Zapis;
    	    this.Subjekt = formformated.Subjekt;
    	    this.Objekt = formformated.Objekt;
    	    this.Davanje = formformated.Davanje;
    	    this.AnalitikaOd = formformated.AnalitikaOd;
    	}
    
    	/*
    	    mymodel.ID_GlavnaKnjiga = model.ID_GlavnaKnjiga;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_KontniPlanSt = model.ID_KontniPlanSt;
    	    mymodel.Naziv = model.Naziv;
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
