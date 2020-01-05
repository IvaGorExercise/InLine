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
    
    
    public partial class UlicaTipGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UlicaTip.ID_UlicaTip.Required)]
    	[DisplayName(AtributClass.UlicaTip.ID_UlicaTip.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.ID_UlicaTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.ID_UlicaTip.Sortable)]
    	public long ID_UlicaTip { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UlicaTip.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Oznaka.Required)]
    	[DisplayName(AtributClass.UlicaTip.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UlicaTip.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Naziv.Required)]
    	[DisplayName(AtributClass.UlicaTip.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.UlicaTip.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.NazivKr.Required)]
    	[DisplayName(AtributClass.UlicaTip.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UlicaTip.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Kratica.Required)]
    	[DisplayName(AtributClass.UlicaTip.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UlicaTip.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.UlicaTip.Opis.Required)]
    	[DisplayName(AtributClass.UlicaTip.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.UlicaTip.StsUlicaTip.StringLength)]
    	[DisplayName(AtributClass.UlicaTip.StsUlicaTip.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UlicaTip.StsUlicaTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UlicaTip.StsUlicaTip.Sortable)]
    	public string StsUlicaTip { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UlicaTipGridFormattedBase()
        { }
    	
    	public UlicaTipGridFormattedBase(Model.Data.UlicaTip gridformated)
    	{
    	    this.ID_UlicaTip = gridformated.ID_UlicaTip;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	    this.StsUlicaTip = gridformated.StsUlicaTip;
    	}
    
    	/*
    	    mymodel.ID_UlicaTip = model.ID_UlicaTip;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.StsUlicaTip = model.StsUlicaTip;
    		
    	*/
    
    		#endregion
    }
}