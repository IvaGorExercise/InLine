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
    
    
    public partial class OperatorAritmetickiGridFormattedBase
    {
    	#region Properities
    	
        [StringLength(2, ErrorMessage = AtributClass.OperatorAritmeticki.AritmetickiOperator.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorAritmeticki.AritmetickiOperator.Required)]
    	[DisplayName(AtributClass.OperatorAritmeticki.AritmetickiOperator.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorAritmeticki.AritmetickiOperator.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorAritmeticki.AritmetickiOperator.Sortable)]
    	public string AritmetickiOperator { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OperatorAritmeticki.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorAritmeticki.Naziv.Required)]
    	[DisplayName(AtributClass.OperatorAritmeticki.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorAritmeticki.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorAritmeticki.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OperatorAritmeticki.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorAritmeticki.NazivKr.Required)]
    	[DisplayName(AtributClass.OperatorAritmeticki.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorAritmeticki.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorAritmeticki.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OperatorAritmeticki.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OperatorAritmeticki.Kratica.Required)]
    	[DisplayName(AtributClass.OperatorAritmeticki.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OperatorAritmeticki.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OperatorAritmeticki.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OperatorAritmetickiGridFormattedBase()
        { }
    	
    	public OperatorAritmetickiGridFormattedBase(Model.Data.OperatorAritmeticki gridformated)
    	{
    	    this.AritmetickiOperator = gridformated.AritmetickiOperator;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.AritmetickiOperator = model.AritmetickiOperator;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
