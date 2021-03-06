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
    
    
    public partial class ObrazacRSmObracunVr2005AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.IDObrazacRSmObracunVr2005A.Required)]
    	[DisplayName(AtributClass.ObrazacRSmObracunVr2005A.IDObrazacRSmObracunVr2005A.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSmObracunVr2005A.IDObrazacRSmObracunVr2005A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSmObracunVr2005A.IDObrazacRSmObracunVr2005A.Sortable)]
    	public int IDObrazacRSmObracunVr2005A { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Oznaka.Required)]
    	[DisplayName(AtributClass.ObrazacRSmObracunVr2005A.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSmObracunVr2005A.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSmObracunVr2005A.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Naziv.Required)]
    	[DisplayName(AtributClass.ObrazacRSmObracunVr2005A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSmObracunVr2005A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSmObracunVr2005A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.NazivKr.Required)]
    	[DisplayName(AtributClass.ObrazacRSmObracunVr2005A.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSmObracunVr2005A.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSmObracunVr2005A.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmObracunVr2005A.Kratica.Required)]
    	[DisplayName(AtributClass.ObrazacRSmObracunVr2005A.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSmObracunVr2005A.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSmObracunVr2005A.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacRSmObracunVr2005AGridFormattedBase()
        { }
    	
    	public ObrazacRSmObracunVr2005AGridFormattedBase(Model.Data.ObrazacRSmObracunVr2005A gridformated)
    	{
    	    this.IDObrazacRSmObracunVr2005A = gridformated.IDObrazacRSmObracunVr2005A;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDObrazacRSmObracunVr2005A = model.IDObrazacRSmObracunVr2005A;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
