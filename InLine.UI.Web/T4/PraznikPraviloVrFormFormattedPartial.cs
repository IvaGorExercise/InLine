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
    
    
    public partial class PraznikPraviloVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PraznikPraviloVr.ID_PraznikPraviloVr.Required)]
    	[DisplayName(AtributClass.PraznikPraviloVr.ID_PraznikPraviloVr.DisplayName)]
        	public long ID_PraznikPraviloVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PraznikPraviloVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PraznikPraviloVr.Oznaka.Required)]
    	[DisplayName(AtributClass.PraznikPraviloVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PraznikPraviloVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PraznikPraviloVr.Naziv.Required)]
    	[DisplayName(AtributClass.PraznikPraviloVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PraznikPraviloVrFormFormattedBase()
        { }
    	
    	public PraznikPraviloVrFormFormattedBase(Model.Data.PraznikPraviloVr formformated)
    	{
    	    this.ID_PraznikPraviloVr = formformated.ID_PraznikPraviloVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	}
    
    	/*
    	    mymodel.ID_PraznikPraviloVr = model.ID_PraznikPraviloVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    	
    }
}