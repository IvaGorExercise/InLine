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
    
    
    public partial class KalendarMjesecDanGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.MjesecDan.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.MjesecDan.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecDan.MjesecDan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecDan.MjesecDan.Sortable)]
    	public int MjesecDan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KalendarMjesecDan.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.Oznaka.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecDan.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecDan.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KalendarMjesecDan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecDan.Naziv.Required)]
    	[DisplayName(AtributClass.KalendarMjesecDan.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecDan.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecDan.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KalendarMjesecDanGridFormattedBase()
        { }
    	
    	public KalendarMjesecDanGridFormattedBase(Model.Data.KalendarMjesecDan gridformated)
    	{
    	    this.MjesecDan = gridformated.MjesecDan;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	}
    
    	/*
    	    mymodel.MjesecDan = model.MjesecDan;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    }
}