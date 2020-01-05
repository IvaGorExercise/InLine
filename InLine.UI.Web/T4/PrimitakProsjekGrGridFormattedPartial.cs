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
    
    
    public partial class PrimitakProsjekGrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.Sortable)]
    	public long ID_PrimitakProsjekGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PrimitakProsjekGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Oznaka.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakProsjekGr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakProsjekGr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PrimitakProsjekGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Naziv.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakProsjekGr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakProsjekGr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PrimitakProsjekGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.NazivKr.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakProsjekGr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakProsjekGr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PrimitakProsjekGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Kratica.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimitakProsjekGr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimitakProsjekGr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PrimitakProsjekGrGridFormattedBase()
        { }
    	
    	public PrimitakProsjekGrGridFormattedBase(Model.Data.PrimitakProsjekGr gridformated)
    	{
    	    this.ID_PrimitakProsjekGr = gridformated.ID_PrimitakProsjekGr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_PrimitakProsjekGr = model.ID_PrimitakProsjekGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
