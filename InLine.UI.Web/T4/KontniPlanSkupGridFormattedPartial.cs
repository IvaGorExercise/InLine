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
    
    
    public partial class KontniPlanSkupGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanSkup.ID_KontniPlanSkup.Required)]
    	[DisplayName(AtributClass.KontniPlanSkup.ID_KontniPlanSkup.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkup.ID_KontniPlanSkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkup.ID_KontniPlanSkup.Sortable)]
    	public long ID_KontniPlanSkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanSkup.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlanSkup.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkup.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkup.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlanSkup.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkup.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlanSkup.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkup.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkup.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KontniPlanSkup.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkup.NazivKr.Required)]
    	[DisplayName(AtributClass.KontniPlanSkup.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkup.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkup.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KontniPlanSkup.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkup.Kratica.Required)]
    	[DisplayName(AtributClass.KontniPlanSkup.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkup.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkup.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanSkupGridFormattedBase()
        { }
    	
    	public KontniPlanSkupGridFormattedBase(Model.Data.KontniPlanSkup gridformated)
    	{
    	    this.ID_KontniPlanSkup = gridformated.ID_KontniPlanSkup;
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanSkup = model.ID_KontniPlanSkup;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
