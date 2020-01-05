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
    
    
    public partial class PrimitakGrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PrimitakGr.ID_PrimitakGr.Required)]
    	[DisplayName(AtributClass.PrimitakGr.ID_PrimitakGr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PrimitakGr.ID_PrimitakGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakGr.ID_PrimitakGr.Sortable)]
    	public long ID_PrimitakGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PrimitakGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakGr.Oznaka.Required)]
    	[DisplayName(AtributClass.PrimitakGr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakGr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakGr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PrimitakGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakGr.Naziv.Required)]
    	[DisplayName(AtributClass.PrimitakGr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakGr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakGr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PrimitakGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakGr.NazivKr.Required)]
    	[DisplayName(AtributClass.PrimitakGr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakGr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakGr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PrimitakGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakGr.Kratica.Required)]
    	[DisplayName(AtributClass.PrimitakGr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakGr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakGr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PrimitakGrGridFormattedBase()
        { }
    	
    	public PrimitakGrGridFormattedBase(Model.Data.PrimitakGr gridformated)
    	{
    	    this.ID_PrimitakGr = gridformated.ID_PrimitakGr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_PrimitakGr = model.ID_PrimitakGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
