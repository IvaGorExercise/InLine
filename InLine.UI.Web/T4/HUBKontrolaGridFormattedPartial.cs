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
    
    
    public partial class HUBKontrolaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.HUBKontrola.IDHUBKontrola.Required)]
    	[DisplayName(AtributClass.HUBKontrola.IDHUBKontrola.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.HUBKontrola.IDHUBKontrola.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBKontrola.IDHUBKontrola.Sortable)]
    	public int IDHUBKontrola { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUBKontrola.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.Oznaka.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBKontrola.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBKontrola.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUBKontrola.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.Naziv.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBKontrola.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBKontrola.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.HUBKontrola.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBKontrola.NazivKr.Required)]
    	[DisplayName(AtributClass.HUBKontrola.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBKontrola.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBKontrola.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBKontrola.Koristi.Required)]
    	[DisplayName(AtributClass.HUBKontrola.Koristi.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBKontrola.Koristi.Sortable)]
    	public bool Koristi { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public HUBKontrolaGridFormattedBase()
        { }
    	
    	public HUBKontrolaGridFormattedBase(Model.Data.HUBKontrola gridformated)
    	{
    	    this.IDHUBKontrola = gridformated.IDHUBKontrola;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Koristi = gridformated.Koristi;
    	}
    
    	/*
    	    mymodel.IDHUBKontrola = model.IDHUBKontrola;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Koristi = model.Koristi;
    		
    	*/
    
    		#endregion
    }
}
