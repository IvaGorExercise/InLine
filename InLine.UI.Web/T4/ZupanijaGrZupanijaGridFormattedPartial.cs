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
    
    
    public partial class ZupanijaGrZupanijaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.Sortable)]
    	public long ID_ZupanijaGrZupanija { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.Sortable)]
    	public long ID_ZupanijaGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_Zupanija.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_Zupanija.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.ID_Zupanija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.ID_Zupanija.Sortable)]
    	public long ID_Zupanija { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZupanijaGrZupanija.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Oznaka.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZupanijaGrZupanija.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Naziv.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZupanijaGrZupanija.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.NazivKr.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZupanijaGrZupanija.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Kratica.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZupanijaGrZupanija.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Opis.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZupanijaGrZupanija.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZupanijaGrZupanija.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZupanijaGrZupanijaGridFormattedBase()
        { }
    	
    	public ZupanijaGrZupanijaGridFormattedBase(Model.Data.ZupanijaGrZupanija gridformated)
    	{
    	    this.ID_ZupanijaGrZupanija = gridformated.ID_ZupanijaGrZupanija;
    	    this.ID_ZupanijaGr = gridformated.ID_ZupanijaGr;
    	    this.ID_Zupanija = gridformated.ID_Zupanija;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_ZupanijaGrZupanija = model.ID_ZupanijaGrZupanija;
    	    mymodel.ID_ZupanijaGr = model.ID_ZupanijaGr;
    	    mymodel.ID_Zupanija = model.ID_Zupanija;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}