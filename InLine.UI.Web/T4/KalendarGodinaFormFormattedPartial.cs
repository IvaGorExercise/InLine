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
    
    
    public partial class KalendarGodinaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KalendarGodina.Godina.Required)]
    	[DisplayName(AtributClass.KalendarGodina.Godina.DisplayName)]
       	public int Godina { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KalendarGodinaFormFormattedBase()
        { }
    	
    	public KalendarGodinaFormFormattedBase(Model.Data.KalendarGodina formformated)
    	{
    	    this.Godina = formformated.Godina;
    	}
    
    	/*
    	    mymodel.Godina = model.Godina;
    		
    	*/
    
    		#endregion
    	
    }
}
