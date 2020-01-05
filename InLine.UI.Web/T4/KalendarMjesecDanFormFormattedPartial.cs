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
    
    
    public partial class KalendarMjesecDanFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.MjesecDan.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.MjesecDan.DisplayName)]
       	public int MjesecDan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KalendarMjesecDan.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.Oznaka.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KalendarMjesecDan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.Naziv.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KalendarMjesecDanFormFormattedBase()
        { }
    	
    	public KalendarMjesecDanFormFormattedBase(Model.Data.KalendarMjesecDan formformated)
    	{
    	    this.MjesecDan = formformated.MjesecDan;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	}
    
    	/*
    	    mymodel.MjesecDan = model.MjesecDan;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    	
    }
}
