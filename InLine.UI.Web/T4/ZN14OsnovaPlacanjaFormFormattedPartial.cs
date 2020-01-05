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
    
    
    public partial class ZN14OsnovaPlacanjaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZN14OsnovaPlacanja.IDZN14OsnovaPlacanja.Required)]
    	[DisplayName(AtributClass.ZN14OsnovaPlacanja.IDZN14OsnovaPlacanja.DisplayName)]
       	public int IDZN14OsnovaPlacanja { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Oznaka.Required)]
    	[DisplayName(AtributClass.ZN14OsnovaPlacanja.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Naziv.Required)]
    	[DisplayName(AtributClass.ZN14OsnovaPlacanja.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZN14OsnovaPlacanja.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZN14OsnovaPlacanja.NazivKr.Required)]
    	[DisplayName(AtributClass.ZN14OsnovaPlacanja.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZN14OsnovaPlacanja.Kratica.Required)]
    	[DisplayName(AtributClass.ZN14OsnovaPlacanja.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZN14OsnovaPlacanjaFormFormattedBase()
        { }
    	
    	public ZN14OsnovaPlacanjaFormFormattedBase(Model.Data.ZN14OsnovaPlacanja formformated)
    	{
    	    this.IDZN14OsnovaPlacanja = formformated.IDZN14OsnovaPlacanja;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDZN14OsnovaPlacanja = model.IDZN14OsnovaPlacanja;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
