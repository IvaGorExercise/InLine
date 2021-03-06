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
    
    
    public partial class PoticanjeZaposljavanjaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PoticanjeZaposljavanja.IDPoticanjeZaposljavanja.Required)]
    	[DisplayName(AtributClass.PoticanjeZaposljavanja.IDPoticanjeZaposljavanja.DisplayName)]
       	public int IDPoticanjeZaposljavanja { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.PoticanjeZaposljavanja.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PoticanjeZaposljavanja.Oznaka.Required)]
    	[DisplayName(AtributClass.PoticanjeZaposljavanja.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PoticanjeZaposljavanja.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PoticanjeZaposljavanja.Naziv.Required)]
    	[DisplayName(AtributClass.PoticanjeZaposljavanja.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PoticanjeZaposljavanja.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PoticanjeZaposljavanja.NazivKr.Required)]
    	[DisplayName(AtributClass.PoticanjeZaposljavanja.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PoticanjeZaposljavanja.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PoticanjeZaposljavanja.Kratica.Required)]
    	[DisplayName(AtributClass.PoticanjeZaposljavanja.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PoticanjeZaposljavanjaFormFormattedBase()
        { }
    	
    	public PoticanjeZaposljavanjaFormFormattedBase(Model.Data.PoticanjeZaposljavanja formformated)
    	{
    	    this.IDPoticanjeZaposljavanja = formformated.IDPoticanjeZaposljavanja;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDPoticanjeZaposljavanja = model.IDPoticanjeZaposljavanja;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
