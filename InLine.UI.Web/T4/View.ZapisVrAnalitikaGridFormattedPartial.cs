//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.View
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
    
    
    public partial class ZapisVrAnalitikaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.IDZapisVr.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.IDZapisVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrAnalitika.IDZapisVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.IDZapisVr.Sortable)]
    	public int IDZapisVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisVrAnalitika.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.Oznaka.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrAnalitika.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisVrAnalitika.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.Naziv.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrAnalitika.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisVrAnalitika.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.NazivKr.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrAnalitika.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZapisVrAnalitika.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.Kratica.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrAnalitika.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DisplayName(AtributClass.ZapisVrAnalitika.Odabir.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.Odabir.Sortable)]
    	public Nullable<bool> Odabir { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisVrAnalitika.Analitika.Required)]
    	[DisplayName(AtributClass.ZapisVrAnalitika.Analitika.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrAnalitika.Analitika.Sortable)]
    	public bool Analitika { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisVrAnalitikaGridFormattedBase()
        { }
    	
    	public ZapisVrAnalitikaGridFormattedBase(Model.Data.View.ZapisVrAnalitika gridformated)
    	{
    	    this.IDZapisVr = gridformated.IDZapisVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Odabir = gridformated.Odabir;
    	    this.Analitika = gridformated.Analitika;
    	}
    
    	/*
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Odabir = model.Odabir;
    	    mymodel.Analitika = model.Analitika;
    		
    	*/
    
    		#endregion
    }
}
