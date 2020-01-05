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
    
    
    public partial class PoslovnaGodinaSubjektGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.ID_PoslovnaGodinaSubjektGr.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjektGr.ID_PoslovnaGodinaSubjektGr.DisplayName)]
        	public long ID_PoslovnaGodinaSubjektGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Oznaka.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjektGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Naziv.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjektGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.NazivKr.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjektGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjektGr.Kratica.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjektGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PoslovnaGodinaSubjektGrFormFormattedBase()
        { }
    	
    	public PoslovnaGodinaSubjektGrFormFormattedBase(Model.Data.PoslovnaGodinaSubjektGr formformated)
    	{
    	    this.ID_PoslovnaGodinaSubjektGr = formformated.ID_PoslovnaGodinaSubjektGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_PoslovnaGodinaSubjektGr = model.ID_PoslovnaGodinaSubjektGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}