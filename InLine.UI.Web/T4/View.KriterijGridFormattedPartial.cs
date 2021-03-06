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
    
    
    public partial class KriterijGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Kriterij.ID_Kriterij.Required)]
    	[DisplayName(AtributClass.Kriterij.ID_Kriterij.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.ID_Kriterij.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.ID_Kriterij.Sortable)]
    	public long ID_Kriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.Kriterij.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.Kriterij.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Kriterij.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Oznaka.Required)]
    	[DisplayName(AtributClass.Kriterij.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Kriterij.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Naziv.Required)]
    	[DisplayName(AtributClass.Kriterij.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Kriterij.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.NazivKr.Required)]
    	[DisplayName(AtributClass.Kriterij.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Kriterij.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Kriterij.Kratica.Required)]
    	[DisplayName(AtributClass.Kriterij.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
        [Required(ErrorMessage = AtributClass.Kriterij.RedniBroj.Required)]
    	[DisplayName(AtributClass.Kriterij.RedniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Kriterij.RedniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Kriterij.RedniBroj.Sortable)]
    	public int RedniBroj { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KriterijGridFormattedBase()
        { }
    	
    	public KriterijGridFormattedBase(Model.Data.View.Kriterij gridformated)
    	{
    	    this.ID_Kriterij = gridformated.ID_Kriterij;
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.RedniBroj = gridformated.RedniBroj;
    	}
    
    	/*
    	    mymodel.ID_Kriterij = model.ID_Kriterij;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.RedniBroj = model.RedniBroj;
    		
    	*/
    
    		#endregion
    }
}
