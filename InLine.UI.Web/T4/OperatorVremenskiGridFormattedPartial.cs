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
    
    
    public partial class OperatorVremenskiGridFormattedBase
    {
    	#region Properities
    	
        [StringLength(2, ErrorMessage = AtributClass.OperatorVremenski.VremenskiOperator.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.VremenskiOperator.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.VremenskiOperator.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorVremenski.VremenskiOperator.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorVremenski.VremenskiOperator.Sortable)]
    	public string VremenskiOperator { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OperatorVremenski.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.Naziv.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorVremenski.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorVremenski.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OperatorVremenski.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.NazivKr.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorVremenski.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorVremenski.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OperatorVremenski.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorVremenski.Kratica.Required)]
    	[DisplayName(AtributClass.OperatorVremenski.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorVremenski.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorVremenski.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OperatorVremenskiGridFormattedBase()
        { }
    	
    	public OperatorVremenskiGridFormattedBase(Model.Data.OperatorVremenski gridformated)
    	{
    	    this.VremenskiOperator = gridformated.VremenskiOperator;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.VremenskiOperator = model.VremenskiOperator;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
