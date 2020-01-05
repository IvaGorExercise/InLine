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
    
    
    public partial class MjernaJedinicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.MjernaJedinica.ID_MjernaJedinica.Required)]
    	[DisplayName(AtributClass.MjernaJedinica.ID_MjernaJedinica.DisplayName)]
        	public long ID_MjernaJedinica { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjernaJedinica.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MjernaJedinica.Oznaka.Required)]
    	[DisplayName(AtributClass.MjernaJedinica.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjernaJedinica.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MjernaJedinica.Naziv.Required)]
    	[DisplayName(AtributClass.MjernaJedinica.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MjernaJedinica.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MjernaJedinica.NazivKr.Required)]
    	[DisplayName(AtributClass.MjernaJedinica.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MjernaJedinica.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MjernaJedinica.Kratica.Required)]
    	[DisplayName(AtributClass.MjernaJedinica.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public MjernaJedinicaFormFormattedBase()
        { }
    	
    	public MjernaJedinicaFormFormattedBase(Model.Data.MjernaJedinica formformated)
    	{
    	    this.ID_MjernaJedinica = formformated.ID_MjernaJedinica;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_MjernaJedinica = model.ID_MjernaJedinica;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
