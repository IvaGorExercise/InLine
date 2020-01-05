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
    
    
    public partial class KontniPlanAnalitikaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.ID_KontniPlanAnalitika.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.ID_KontniPlanAnalitika.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.ID_KontniPlanAnalitika.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.ID_KontniPlanAnalitika.Sortable)]
    	public long ID_KontniPlanAnalitika { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.IDZapisVr.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.IDZapisVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.IDZapisVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.IDZapisVr.Sortable)]
    	public int IDZapisVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KontniPlanAnalitika.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.Oznaka.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlanAnalitika.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KontniPlanAnalitika.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.NazivKr.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KontniPlanAnalitika.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitika.Kratica.Required)]
    	[DisplayName(AtributClass.KontniPlanAnalitika.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanAnalitika.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanAnalitika.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanAnalitikaGridFormattedBase()
        { }
    	
    	public KontniPlanAnalitikaGridFormattedBase(Model.Data.KontniPlanAnalitika gridformated)
    	{
    	    this.ID_KontniPlanAnalitika = gridformated.ID_KontniPlanAnalitika;
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.IDZapisVr = gridformated.IDZapisVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanAnalitika = model.ID_KontniPlanAnalitika;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}