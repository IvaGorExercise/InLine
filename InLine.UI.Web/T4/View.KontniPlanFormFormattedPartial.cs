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
    
    
    public partial class KontniPlanFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KontniPlan.AnalitikaOd.Required)]
    	[DisplayName(AtributClass.KontniPlan.AnalitikaOd.DisplayName)]
       	public int AnalitikaOd { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_KontniPlan.DisplayName)]
       	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_PoslovnaGodina.DisplayName)]
       	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.Godina.Required)]
    	[DisplayName(AtributClass.KontniPlan.Godina.DisplayName)]
       	public int Godina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumOd.Required)]
    	[DisplayName(AtributClass.KontniPlan.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumDo.Required)]
    	[DisplayName(AtributClass.KontniPlan.DatumDo.DisplayName)]
       	public System.DateTime DatumDo { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.KontniPlan.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.IDValuta.Required)]
    	[DisplayName(AtributClass.KontniPlan.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KontniPlan.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.Oznaka.Required)]
    	[DisplayName(AtributClass.KontniPlan.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlan.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KontniPlanFormFormattedBase()
        { }
    	
    	public KontniPlanFormFormattedBase(Model.Data.View.KontniPlan formformated)
    	{
    	    this.AnalitikaOd = formformated.AnalitikaOd;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
    	    this.Godina = formformated.Godina;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.IDValuta = formformated.IDValuta;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	}
    
    	/*
    	    mymodel.AnalitikaOd = model.AnalitikaOd;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.Godina = model.Godina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    	
    }
}
