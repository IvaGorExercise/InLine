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
    
    
    public partial class KriterijFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Kriterij.ID_Kriterij.Required)]
    	[DisplayName(AtributClass.Kriterij.ID_Kriterij.DisplayName)]
        	public long ID_Kriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.Kriterij.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.Kriterij.ID_KontniPlan.DisplayName)]
       	public long ID_KontniPlan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Kriterij.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Oznaka.Required)]
    	[DisplayName(AtributClass.Kriterij.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Kriterij.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Naziv.Required)]
    	[DisplayName(AtributClass.Kriterij.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Kriterij.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.NazivKr.Required)]
    	[DisplayName(AtributClass.Kriterij.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Kriterij.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Kratica.Required)]
    	[DisplayName(AtributClass.Kriterij.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
        [Required(ErrorMessage = AtributClass.Kriterij.RedniBroj.Required)]
    	[DisplayName(AtributClass.Kriterij.RedniBroj.DisplayName)]
       	public int RedniBroj { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KriterijFormFormattedBase()
        { }
    	
    	public KriterijFormFormattedBase(Model.Data.Kriterij formformated)
    	{
    	    this.ID_Kriterij = formformated.ID_Kriterij;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.RedniBroj = formformated.RedniBroj;
    	}
    
    	/*
    	    mymodel.ID_Kriterij = model.ID_Kriterij;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.RedniBroj = model.RedniBroj;
    		
    	*/
    
    		#endregion
    	
    }
}
