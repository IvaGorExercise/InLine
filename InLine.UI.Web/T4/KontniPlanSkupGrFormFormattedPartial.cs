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
    
    
    public partial class KontniPlanSkupGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.DisplayName)]
        	public long ID_KontniPlanSkupGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KontniPlanSkupGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Oznaka.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlanSkupGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KontniPlanSkupGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.NazivKr.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KontniPlanSkupGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Kratica.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KontniPlanSkupGrFormFormattedBase()
        { }
    	
    	public KontniPlanSkupGrFormFormattedBase(Model.Data.KontniPlanSkupGr formformated)
    	{
    	    this.ID_KontniPlanSkupGr = formformated.ID_KontniPlanSkupGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanSkupGr = model.ID_KontniPlanSkupGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
