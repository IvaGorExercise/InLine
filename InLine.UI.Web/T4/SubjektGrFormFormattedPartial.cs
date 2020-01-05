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
    
    
    public partial class SubjektGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektGr.ID_SubjektGr.Required)]
    	[DisplayName(AtributClass.SubjektGr.ID_SubjektGr.DisplayName)]
        	public long ID_SubjektGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.SubjektGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektGr.Oznaka.Required)]
    	[DisplayName(AtributClass.SubjektGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektGr.Naziv.Required)]
    	[DisplayName(AtributClass.SubjektGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.SubjektGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektGr.NazivKr.Required)]
    	[DisplayName(AtributClass.SubjektGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.SubjektGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektGr.Kratica.Required)]
    	[DisplayName(AtributClass.SubjektGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektGrFormFormattedBase()
        { }
    	
    	public SubjektGrFormFormattedBase(Model.Data.SubjektGr formformated)
    	{
    	    this.ID_SubjektGr = formformated.ID_SubjektGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_SubjektGr = model.ID_SubjektGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
