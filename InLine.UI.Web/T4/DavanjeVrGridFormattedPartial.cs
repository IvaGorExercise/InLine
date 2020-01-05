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
    
    
    public partial class DavanjeVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DavanjeVr.IDDavanjeVr.Required)]
    	[DisplayName(AtributClass.DavanjeVr.IDDavanjeVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DavanjeVr.IDDavanjeVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjeVr.IDDavanjeVr.Sortable)]
    	public int IDDavanjeVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DavanjeVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DavanjeVr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjeVr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjeVr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DavanjeVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeVr.Naziv.Required)]
    	[DisplayName(AtributClass.DavanjeVr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjeVr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjeVr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DavanjeVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DavanjeVr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjeVr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjeVr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DavanjeVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeVr.Kratica.Required)]
    	[DisplayName(AtributClass.DavanjeVr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjeVr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjeVr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DavanjeVrGridFormattedBase()
        { }
    	
    	public DavanjeVrGridFormattedBase(Model.Data.DavanjeVr gridformated)
    	{
    	    this.IDDavanjeVr = gridformated.IDDavanjeVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDDavanjeVr = model.IDDavanjeVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}