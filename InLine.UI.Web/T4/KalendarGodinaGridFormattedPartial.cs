//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate
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
    using InLine.UI.Web.T4.GridFormattedTemplate;
    using InLine.UI.Web.Helper;
    
    
    public partial class KalendarGodinaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KalendarGodina.Godina.Required)]
    	[DisplayName(AtributClass.KalendarGodina.Godina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KalendarGodina.Godina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarGodina.Godina.Sortable)]
    	public int Godina { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KalendarGodinaGridFormattedBase()
        { }
    	
    	public KalendarGodinaGridFormattedBase(Model.Data.KalendarGodina gridformated)
    	{
    	    this.Godina = gridformated.Godina;
    	}
    
    	/*
    	    mymodel.Godina = model.Godina;
    		
    	*/
    
    		#endregion
    }
}
