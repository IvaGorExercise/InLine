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
    
    
    public partial class JezikGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Jezik.ID_Jezik.Required)]
    	[DisplayName(AtributClass.Jezik.ID_Jezik.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Jezik.ID_Jezik.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.ID_Jezik.Sortable)]
    	public long ID_Jezik { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.Jezik.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Jezik.Oznaka.Required)]
    	[DisplayName(AtributClass.Jezik.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Jezik.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Jezik.Naziv.Required)]
    	[DisplayName(AtributClass.Jezik.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Jezik.NazivEn.StringLength)]
        [Required(ErrorMessage = AtributClass.Jezik.NazivEn.Required)]
    	[DisplayName(AtributClass.Jezik.NazivEn.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.NazivEn.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.NazivEn.Sortable)]
    	public string NazivEn { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.Jezik.Oznaka2T.StringLength)]
        [Required(ErrorMessage = AtributClass.Jezik.Oznaka2T.Required)]
    	[DisplayName(AtributClass.Jezik.Oznaka2T.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.Oznaka2T.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.Oznaka2T.Sortable)]
    	public string Oznaka2T { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.Jezik.Oznaka2B.StringLength)]
        [Required(ErrorMessage = AtributClass.Jezik.Oznaka2B.Required)]
    	[DisplayName(AtributClass.Jezik.Oznaka2B.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.Oznaka2B.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.Oznaka2B.Sortable)]
    	public string Oznaka2B { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.Jezik.Oznaka3.StringLength)]
    	[DisplayName(AtributClass.Jezik.Oznaka3.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Jezik.Oznaka3.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Jezik.Oznaka3.Sortable)]
    	public string Oznaka3 { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public JezikGridFormattedBase()
        { }
    	
    	public JezikGridFormattedBase(Model.Data.Jezik gridformated)
    	{
    	    this.ID_Jezik = gridformated.ID_Jezik;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivEn = gridformated.NazivEn;
    	    this.Oznaka2T = gridformated.Oznaka2T;
    	    this.Oznaka2B = gridformated.Oznaka2B;
    	    this.Oznaka3 = gridformated.Oznaka3;
    	}
    
    	/*
    	    mymodel.ID_Jezik = model.ID_Jezik;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivEn = model.NazivEn;
    	    mymodel.Oznaka2T = model.Oznaka2T;
    	    mymodel.Oznaka2B = model.Oznaka2B;
    	    mymodel.Oznaka3 = model.Oznaka3;
    		
    	*/
    
    		#endregion
    }
}
