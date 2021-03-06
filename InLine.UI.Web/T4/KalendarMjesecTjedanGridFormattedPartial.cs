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
    
    
    public partial class KalendarMjesecTjedanGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KalendarMjesecTjedan.MjesecTjedan.Required)]
    	[DisplayName(AtributClass.KalendarMjesecTjedan.MjesecTjedan.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecTjedan.MjesecTjedan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecTjedan.MjesecTjedan.Sortable)]
    	public int MjesecTjedan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KalendarMjesecTjedan.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecTjedan.Oznaka.Required)]
    	[DisplayName(AtributClass.KalendarMjesecTjedan.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecTjedan.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecTjedan.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KalendarMjesecTjedan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KalendarMjesecTjedan.Naziv.Required)]
    	[DisplayName(AtributClass.KalendarMjesecTjedan.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KalendarMjesecTjedan.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KalendarMjesecTjedan.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KalendarMjesecTjedanGridFormattedBase()
        { }
    	
    	public KalendarMjesecTjedanGridFormattedBase(Model.Data.KalendarMjesecTjedan gridformated)
    	{
    	    this.MjesecTjedan = gridformated.MjesecTjedan;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	}
    
    	/*
    	    mymodel.MjesecTjedan = model.MjesecTjedan;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    }
}
