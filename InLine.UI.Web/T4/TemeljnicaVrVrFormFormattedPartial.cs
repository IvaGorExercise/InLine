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
    
    
    public partial class TemeljnicaVrVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.TemeljnicaVrVr.IDTemeljnicaVrVr.Required)]
    	[DisplayName(AtributClass.TemeljnicaVrVr.IDTemeljnicaVrVr.DisplayName)]
       	public int IDTemeljnicaVrVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.TemeljnicaVrVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrVr.Oznaka.Required)]
    	[DisplayName(AtributClass.TemeljnicaVrVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaVrVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrVr.Naziv.Required)]
    	[DisplayName(AtributClass.TemeljnicaVrVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaVrVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrVr.NazivKr.Required)]
    	[DisplayName(AtributClass.TemeljnicaVrVr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.TemeljnicaVrVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrVr.Kratica.Required)]
    	[DisplayName(AtributClass.TemeljnicaVrVr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public TemeljnicaVrVrFormFormattedBase()
        { }
    	
    	public TemeljnicaVrVrFormFormattedBase(Model.Data.TemeljnicaVrVr formformated)
    	{
    	    this.IDTemeljnicaVrVr = formformated.IDTemeljnicaVrVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDTemeljnicaVrVr = model.IDTemeljnicaVrVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
