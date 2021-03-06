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
    
    
    public partial class MirovinskiStupGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.MirovinskiStup.IDMirovinskiStup.Required)]
    	[DisplayName(AtributClass.MirovinskiStup.IDMirovinskiStup.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MirovinskiStup.IDMirovinskiStup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MirovinskiStup.IDMirovinskiStup.Sortable)]
    	public int IDMirovinskiStup { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.MirovinskiStup.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MirovinskiStup.Oznaka.Required)]
    	[DisplayName(AtributClass.MirovinskiStup.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MirovinskiStup.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MirovinskiStup.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MirovinskiStup.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MirovinskiStup.Naziv.Required)]
    	[DisplayName(AtributClass.MirovinskiStup.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MirovinskiStup.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MirovinskiStup.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MirovinskiStup.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MirovinskiStup.NazivKr.Required)]
    	[DisplayName(AtributClass.MirovinskiStup.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MirovinskiStup.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MirovinskiStup.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MirovinskiStup.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MirovinskiStup.Kratica.Required)]
    	[DisplayName(AtributClass.MirovinskiStup.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MirovinskiStup.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MirovinskiStup.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public MirovinskiStupGridFormattedBase()
        { }
    	
    	public MirovinskiStupGridFormattedBase(Model.Data.MirovinskiStup gridformated)
    	{
    	    this.IDMirovinskiStup = gridformated.IDMirovinskiStup;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDMirovinskiStup = model.IDMirovinskiStup;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
