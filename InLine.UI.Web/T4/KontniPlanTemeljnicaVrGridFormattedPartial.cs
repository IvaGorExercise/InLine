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
    
    
    public partial class KontniPlanTemeljnicaVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Required)]
    	[DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Sortable)]
    	public long ID_KontniPlanTemeljnicaVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Required)]
    	[DisplayName(AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Sortable)]
    	public int IDTemeljnicaVrVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Required)]
    	[DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Sortable)]
    	public long ID_TemeljnicaVr { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanTemeljnicaVrGridFormattedBase()
        { }
    	
    	public KontniPlanTemeljnicaVrGridFormattedBase(Model.Data.KontniPlanTemeljnicaVr gridformated)
    	{
    	    this.ID_KontniPlanTemeljnicaVr = gridformated.ID_KontniPlanTemeljnicaVr;
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.IDTemeljnicaVrVr = gridformated.IDTemeljnicaVrVr;
    	    this.ID_TemeljnicaVr = gridformated.ID_TemeljnicaVr;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanTemeljnicaVr = model.ID_KontniPlanTemeljnicaVr;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.IDTemeljnicaVrVr = model.IDTemeljnicaVrVr;
    	    mymodel.ID_TemeljnicaVr = model.ID_TemeljnicaVr;
    		
    	*/
    
    		#endregion
    }
}
