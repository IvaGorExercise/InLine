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
    
    
    public partial class PoreznaUpravaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PoreznaUprava.ID_PoreznaUprava.Required)]
    	[DisplayName(AtributClass.PoreznaUprava.ID_PoreznaUprava.DisplayName)]
        	public long ID_PoreznaUprava { get; set; }
    
    	[DisplayName(AtributClass.PoreznaUprava.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PoreznaUprava.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PoreznaUprava.Oznaka.Required)]
    	[DisplayName(AtributClass.PoreznaUprava.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PoreznaUprava.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PoreznaUprava.Naziv.Required)]
    	[DisplayName(AtributClass.PoreznaUprava.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PoreznaUprava.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PoreznaUprava.NazivKr.Required)]
    	[DisplayName(AtributClass.PoreznaUprava.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PoreznaUprava.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PoreznaUprava.Kratica.Required)]
    	[DisplayName(AtributClass.PoreznaUprava.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.PoreznaUprava.OIB.StringLength)]
    	[DisplayName(AtributClass.PoreznaUprava.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PoreznaUpravaFormFormattedBase()
        { }
    	
    	public PoreznaUpravaFormFormattedBase(Model.Data.PoreznaUprava formformated)
    	{
    	    this.ID_PoreznaUprava = formformated.ID_PoreznaUprava;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.OIB = formformated.OIB;
    	}
    
    	/*
    	    mymodel.ID_PoreznaUprava = model.ID_PoreznaUprava;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.OIB = model.OIB;
    		
    	*/
    
    		#endregion
    	
    }
}