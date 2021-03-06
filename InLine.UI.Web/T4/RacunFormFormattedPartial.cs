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
    
    
    public partial class RacunFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Racun.ID_Racun.Required)]
    	[DisplayName(AtributClass.Racun.ID_Racun.DisplayName)]
        	public long ID_Racun { get; set; }
    
        [Required(ErrorMessage = AtributClass.Racun.ID_RacunVr.Required)]
    	[DisplayName(AtributClass.Racun.ID_RacunVr.DisplayName)]
       	public long ID_RacunVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Racun.Oznaka.StringLength)]
    	[DisplayName(AtributClass.Racun.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Racun.Naziv.StringLength)]
    	[DisplayName(AtributClass.Racun.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.Racun.VBDI.StringLength)]
    	[DisplayName(AtributClass.Racun.VBDI.DisplayName)]
       	public string VBDI { get; set; }
    
    	
        [StringLength(18, ErrorMessage = AtributClass.Racun.Broj.StringLength)]
    	[DisplayName(AtributClass.Racun.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	
        [StringLength(21, ErrorMessage = AtributClass.Racun.IBAN.StringLength)]
    	[DisplayName(AtributClass.Racun.IBAN.DisplayName)]
       	public string IBAN { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RacunFormFormattedBase()
        { }
    	
    	public RacunFormFormattedBase(Model.Data.Racun formformated)
    	{
    	    this.ID_Racun = formformated.ID_Racun;
    	    this.ID_RacunVr = formformated.ID_RacunVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.VBDI = formformated.VBDI;
    	    this.Broj = formformated.Broj;
    	    this.IBAN = formformated.IBAN;
    	}
    
    	/*
    	    mymodel.ID_Racun = model.ID_Racun;
    	    mymodel.ID_RacunVr = model.ID_RacunVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.VBDI = model.VBDI;
    	    mymodel.Broj = model.Broj;
    	    mymodel.IBAN = model.IBAN;
    		
    	*/
    
    		#endregion
    	
    }
}
