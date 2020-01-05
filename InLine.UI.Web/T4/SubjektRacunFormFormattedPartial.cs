//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate
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
    
    
    public partial class SubjektRacunFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_SubjektRacun.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_SubjektRacun.DisplayName)]
        	public long ID_SubjektRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_Banka.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_Banka.DisplayName)]
       	public long ID_Banka { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.SubjektRacun.Broj.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.SubjektRacun.VBDI.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.VBDI.DisplayName)]
       	public string VBDI { get; set; }
    
    	
        [StringLength(34, ErrorMessage = AtributClass.SubjektRacun.IBAN.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.IBAN.DisplayName)]
       	public string IBAN { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.Devizni.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Devizni.DisplayName)]
       	public bool Devizni { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektRacun.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacun.Naziv.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektRacun.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacun.Opis.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.SubjektRacun.RedniBroj.DisplayName)]
       	public Nullable<int> RedniBroj { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektRacunFormFormattedBase()
        { }
    	
    	public SubjektRacunFormFormattedBase(Model.Data.SubjektRacun formformated)
    	{
    	    this.ID_SubjektRacun = formformated.ID_SubjektRacun;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.ID_Banka = formformated.ID_Banka;
    	    this.Broj = formformated.Broj;
    	    this.VBDI = formformated.VBDI;
    	    this.IBAN = formformated.IBAN;
    	    this.Devizni = formformated.Devizni;
    	    this.Naziv = formformated.Naziv;
    	    this.Opis = formformated.Opis;
    	    this.RedniBroj = formformated.RedniBroj;
    	}
    
    	/*
    	    mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_Banka = model.ID_Banka;
    	    mymodel.Broj = model.Broj;
    	    mymodel.VBDI = model.VBDI;
    	    mymodel.IBAN = model.IBAN;
    	    mymodel.Devizni = model.Devizni;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Opis = model.Opis;
    	    mymodel.RedniBroj = model.RedniBroj;
    		
    	*/
    
    		#endregion
    	
    }
}
