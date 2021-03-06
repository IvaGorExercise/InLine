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
    
    
    public partial class HUBKontrolaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUBKontrola.IDHUBKontrola.Required)]
    	[DisplayName(AtributClass.HUBKontrola.IDHUBKontrola.DisplayName)]
       	public int IDHUBKontrola { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUBKontrola.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.Oznaka.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUBKontrola.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.Naziv.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.HUBKontrola.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.NazivKr.Required)]
    	[DisplayName(AtributClass.HUBKontrola.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBKontrola.Koristi.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Koristi.DisplayName)]
       	public bool Koristi { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUBKontrolaFormFormattedBase()
        { }
    	
    	public HUBKontrolaFormFormattedBase(Model.Data.HUBKontrola formformated)
    	{
    	    this.IDHUBKontrola = formformated.IDHUBKontrola;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Koristi = formformated.Koristi;
    	}
    
    	/*
    	    mymodel.IDHUBKontrola = model.IDHUBKontrola;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Koristi = model.Koristi;
    		
    	*/
    
    		#endregion
    	
    }
}
