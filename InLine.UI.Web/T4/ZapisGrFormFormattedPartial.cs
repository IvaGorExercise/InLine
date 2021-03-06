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
    
    
    public partial class ZapisGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZapisGr.ID_ZapisGr.Required)]
    	[DisplayName(AtributClass.ZapisGr.ID_ZapisGr.DisplayName)]
        	public long ID_ZapisGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisGr.Oznaka.Required)]
    	[DisplayName(AtributClass.ZapisGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisGr.Naziv.Required)]
    	[DisplayName(AtributClass.ZapisGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisGr.NazivKr.Required)]
    	[DisplayName(AtributClass.ZapisGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZapisGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisGr.Kratica.Required)]
    	[DisplayName(AtributClass.ZapisGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisGrFormFormattedBase()
        { }
    	
    	public ZapisGrFormFormattedBase(Model.Data.ZapisGr formformated)
    	{
    	    this.ID_ZapisGr = formformated.ID_ZapisGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_ZapisGr = model.ID_ZapisGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
