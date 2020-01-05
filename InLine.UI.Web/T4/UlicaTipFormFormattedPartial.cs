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
    
    
    public partial class UlicaTipFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UlicaTip.ID_UlicaTip.Required)]
    	[DisplayName(AtributClass.UlicaTip.ID_UlicaTip.DisplayName)]
        	public long ID_UlicaTip { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UlicaTip.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Oznaka.Required)]
    	[DisplayName(AtributClass.UlicaTip.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UlicaTip.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Naziv.Required)]
    	[DisplayName(AtributClass.UlicaTip.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.UlicaTip.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.NazivKr.Required)]
    	[DisplayName(AtributClass.UlicaTip.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UlicaTip.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Kratica.Required)]
    	[DisplayName(AtributClass.UlicaTip.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UlicaTip.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Opis.Required)]
    	[DisplayName(AtributClass.UlicaTip.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.UlicaTip.StsUlicaTip.StringLength)]
    	[DisplayName(AtributClass.UlicaTip.StsUlicaTip.DisplayName)]
       	public string StsUlicaTip { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UlicaTipFormFormattedBase()
        { }
    	
    	public UlicaTipFormFormattedBase(Model.Data.UlicaTip formformated)
    	{
    	    this.ID_UlicaTip = formformated.ID_UlicaTip;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Opis = formformated.Opis;
    	    this.StsUlicaTip = formformated.StsUlicaTip;
    	}
    
    	/*
    	    mymodel.ID_UlicaTip = model.ID_UlicaTip;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.StsUlicaTip = model.StsUlicaTip;
    		
    	*/
    
    		#endregion
    	
    }
}
