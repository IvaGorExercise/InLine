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
    
    
    public partial class OperatorVremenskiFormFormattedBase
    {
    	#region Properities
    
    	
        [StringLength(2, ErrorMessage = AtributClass.OperatorVremenski.VremenskiOperator.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.VremenskiOperator.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.VremenskiOperator.DisplayName)]
       	public string VremenskiOperator { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OperatorVremenski.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.Naziv.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OperatorVremenski.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.NazivKr.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OperatorVremenski.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.Kratica.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OperatorVremenskiFormFormattedBase()
        { }
    	
    	public OperatorVremenskiFormFormattedBase(Model.Data.OperatorVremenski formformated)
    	{
    	    this.VremenskiOperator = formformated.VremenskiOperator;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.VremenskiOperator = model.VremenskiOperator;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
