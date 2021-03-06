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
    
    
    public partial class JezikGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.JezikGr.ID_JezikGr.Required)]
    	[DisplayName(AtributClass.JezikGr.ID_JezikGr.DisplayName)]
        	public long ID_JezikGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.JezikGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.JezikGr.Oznaka.Required)]
    	[DisplayName(AtributClass.JezikGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.JezikGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.JezikGr.Naziv.Required)]
    	[DisplayName(AtributClass.JezikGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public JezikGrFormFormattedBase()
        { }
    	
    	public JezikGrFormFormattedBase(Model.Data.JezikGr formformated)
    	{
    	    this.ID_JezikGr = formformated.ID_JezikGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	}
    
    	/*
    	    mymodel.ID_JezikGr = model.ID_JezikGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    	
    }
}
