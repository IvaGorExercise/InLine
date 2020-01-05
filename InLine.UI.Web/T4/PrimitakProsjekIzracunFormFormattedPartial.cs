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
    
    
    public partial class PrimitakProsjekIzracunFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PrimitakProsjekIzracun.IDPrimitakProsjekIzracun.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekIzracun.IDPrimitakProsjekIzracun.DisplayName)]
       	public int IDPrimitakProsjekIzracun { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PrimitakProsjekIzracun.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekIzracun.Oznaka.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekIzracun.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PrimitakProsjekIzracun.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekIzracun.Naziv.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekIzracun.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PrimitakProsjekIzracun.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekIzracun.NazivKr.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekIzracun.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PrimitakProsjekIzracun.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekIzracun.Kratica.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekIzracun.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PrimitakProsjekIzracunFormFormattedBase()
        { }
    	
    	public PrimitakProsjekIzracunFormFormattedBase(Model.Data.PrimitakProsjekIzracun formformated)
    	{
    	    this.IDPrimitakProsjekIzracun = formformated.IDPrimitakProsjekIzracun;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDPrimitakProsjekIzracun = model.IDPrimitakProsjekIzracun;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
