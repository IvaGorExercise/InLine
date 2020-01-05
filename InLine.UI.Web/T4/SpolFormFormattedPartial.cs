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
    
    
    public partial class SpolFormFormattedBase
    {
    	#region Properities
    
    	
        [StringLength(1, ErrorMessage = AtributClass.Spol.IDSpol.StringLength)]
        [Required(ErrorMessage = AtributClass.Spol.IDSpol.Required)]
    	[DisplayName(AtributClass.Spol.IDSpol.DisplayName)]
       	public string IDSpol { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Spol.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Spol.Naziv.Required)]
    	[DisplayName(AtributClass.Spol.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Spol.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Spol.NazivKr.Required)]
    	[DisplayName(AtributClass.Spol.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Spol.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Spol.Kratica.Required)]
    	[DisplayName(AtributClass.Spol.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SpolFormFormattedBase()
        { }
    	
    	public SpolFormFormattedBase(Model.Data.Spol formformated)
    	{
    	    this.IDSpol = formformated.IDSpol;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDSpol = model.IDSpol;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
