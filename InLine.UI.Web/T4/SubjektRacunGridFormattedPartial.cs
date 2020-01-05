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
    
    
    public partial class SubjektRacunGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_SubjektRacun.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_SubjektRacun.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.ID_SubjektRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.ID_SubjektRacun.Sortable)]
    	public long ID_SubjektRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.ID_Subjekt.Sortable)]
    	public long ID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.ID_Banka.Required)]
    	[DisplayName(AtributClass.SubjektRacun.ID_Banka.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.ID_Banka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.ID_Banka.Sortable)]
    	public long ID_Banka { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.SubjektRacun.Broj.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.Broj.Sortable)]
    	public string Broj { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.SubjektRacun.VBDI.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.VBDI.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.VBDI.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.VBDI.Sortable)]
    	public string VBDI { get; set; }
    
    	
        [StringLength(34, ErrorMessage = AtributClass.SubjektRacun.IBAN.StringLength)]
    	[DisplayName(AtributClass.SubjektRacun.IBAN.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.IBAN.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.IBAN.Sortable)]
    	public string IBAN { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektRacun.Devizni.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Devizni.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.Devizni.Sortable)]
    	public bool Devizni { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektRacun.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacun.Naziv.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektRacun.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacun.Opis.Required)]
    	[DisplayName(AtributClass.SubjektRacun.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.SubjektRacun.RedniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektRacun.RedniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektRacun.RedniBroj.Sortable)]
    	public Nullable<int> RedniBroj { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public SubjektRacunGridFormattedBase()
        { }
    	
    	public SubjektRacunGridFormattedBase(Model.Data.SubjektRacun gridformated)
    	{
    	    this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.ID_Banka = gridformated.ID_Banka;
    	    this.Broj = gridformated.Broj;
    	    this.VBDI = gridformated.VBDI;
    	    this.IBAN = gridformated.IBAN;
    	    this.Devizni = gridformated.Devizni;
    	    this.Naziv = gridformated.Naziv;
    	    this.Opis = gridformated.Opis;
    	    this.RedniBroj = gridformated.RedniBroj;
    	}
    
    	/*
    	    mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_Banka = model.ID_Banka;
    	    mymodel.Broj = model.Broj;
    	    mymodel.VBDI = model.VBDI;
    	    mymodel.IBAN = model.IBAN;
    	    mymodel.Devizni = model.Devizni;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Opis = model.Opis;
    	    mymodel.RedniBroj = model.RedniBroj;
    		
    	*/
    
    		#endregion
    }
}