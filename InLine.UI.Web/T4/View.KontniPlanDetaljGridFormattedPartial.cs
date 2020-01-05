//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.View
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
    
    
    public partial class KontniPlanDetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlanDetalj.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanDetalj.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanDetalj.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.Sortable)]
    	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.AnalitikaOd.Required)]
    	[DisplayName(AtributClass.KontniPlanDetalj.AnalitikaOd.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanDetalj.AnalitikaOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanDetalj.AnalitikaOd.Sortable)]
    	public int AnalitikaOd { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanDetaljGridFormattedBase()
        { }
    	
    	public KontniPlanDetaljGridFormattedBase(Model.Data.View.KontniPlanDetalj gridformated)
    	{
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
    	    this.AnalitikaOd = gridformated.AnalitikaOd;
    	}
    
    	/*
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.AnalitikaOd = model.AnalitikaOd;
    		
    	*/
    
    		#endregion
    }
}