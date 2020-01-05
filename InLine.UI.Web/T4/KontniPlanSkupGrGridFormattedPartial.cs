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
    
    
    public partial class KontniPlanSkupGrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkupGr.ID_KontniPlanSkupGr.Sortable)]
    	public long ID_KontniPlanSkupGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KontniPlanSkupGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Oznaka.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkupGr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkupGr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlanSkupGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkupGr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkupGr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KontniPlanSkupGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.NazivKr.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkupGr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkupGr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KontniPlanSkupGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSkupGr.Kratica.Required)]
    	[DisplayName(AtributClass.KontniPlanSkupGr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlanSkupGr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlanSkupGr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanSkupGrGridFormattedBase()
        { }
    	
    	public KontniPlanSkupGrGridFormattedBase(Model.Data.KontniPlanSkupGr gridformated)
    	{
    	    this.ID_KontniPlanSkupGr = gridformated.ID_KontniPlanSkupGr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanSkupGr = model.ID_KontniPlanSkupGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
