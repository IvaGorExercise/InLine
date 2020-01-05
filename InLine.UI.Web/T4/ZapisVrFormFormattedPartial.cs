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
    
    
    public partial class ZapisVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZapisVr.IDZapisVr.Required)]
    	[DisplayName(AtributClass.ZapisVr.IDZapisVr.DisplayName)]
       	public int IDZapisVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVr.Oznaka.Required)]
    	[DisplayName(AtributClass.ZapisVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVr.Naziv.Required)]
    	[DisplayName(AtributClass.ZapisVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVr.NazivKr.Required)]
    	[DisplayName(AtributClass.ZapisVr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZapisVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVr.Kratica.Required)]
    	[DisplayName(AtributClass.ZapisVr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisVrFormFormattedBase()
        { }
    	
    	public ZapisVrFormFormattedBase(Model.Data.ZapisVr formformated)
    	{
    	    this.IDZapisVr = formformated.IDZapisVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}