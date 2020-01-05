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
    
    
    public partial class HUBTroskoviOpcija2013AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.IDHUBTroskoviOpcija2013A.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.IDHUBTroskoviOpcija2013A.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.IDHUBTroskoviOpcija2013A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.IDHUBTroskoviOpcija2013A.Sortable)]
    	public int IDHUBTroskoviOpcija2013A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Oznaka.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Naziv.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.NazivKr.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Kratica.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBTroskoviOpcija2013A.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.Opis.Sortable)]
    	public string Opis { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBTroskoviOpcija2013A.Koristi.Required)]
    	[DisplayName(AtributClass.HUBTroskoviOpcija2013A.Koristi.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBTroskoviOpcija2013A.Koristi.Sortable)]
    	public bool Koristi { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public HUBTroskoviOpcija2013AGridFormattedBase()
        { }
    	
    	public HUBTroskoviOpcija2013AGridFormattedBase(Model.Data.HUBTroskoviOpcija2013A gridformated)
    	{
    	    this.IDHUBTroskoviOpcija2013A = gridformated.IDHUBTroskoviOpcija2013A;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	    this.Koristi = gridformated.Koristi;
    	}
    
    	/*
    	    mymodel.IDHUBTroskoviOpcija2013A = model.IDHUBTroskoviOpcija2013A;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.Koristi = model.Koristi;
    		
    	*/
    
    		#endregion
    }
}