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
    
    
    public partial class DokumentVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DokumentVr.ID_DokumentVr.Required)]
    	[DisplayName(AtributClass.DokumentVr.ID_DokumentVr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.ID_DokumentVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.ID_DokumentVr.Sortable)]
    	public long ID_DokumentVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DokumentVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DokumentVr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DokumentVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVr.Naziv.Required)]
    	[DisplayName(AtributClass.DokumentVr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DokumentVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DokumentVr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DokumentVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVr.Kratica.Required)]
    	[DisplayName(AtributClass.DokumentVr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DokumentVr.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVr.Opis.Required)]
    	[DisplayName(AtributClass.DokumentVr.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Opis.Sortable)]
    	public string Opis { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.IDDokumentGr.Required)]
    	[DisplayName(AtributClass.DokumentVr.IDDokumentGr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DokumentVr.IDDokumentGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.IDDokumentGr.Sortable)]
    	public int IDDokumentGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Obrocni.Required)]
    	[DisplayName(AtributClass.DokumentVr.Obrocni.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Obrocni.Sortable)]
    	public bool Obrocni { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Jednokratni.Required)]
    	[DisplayName(AtributClass.DokumentVr.Jednokratni.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Jednokratni.Sortable)]
    	public bool Jednokratni { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Kupac.Required)]
    	[DisplayName(AtributClass.DokumentVr.Kupac.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Kupac.Sortable)]
    	public bool Kupac { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Partner.Required)]
    	[DisplayName(AtributClass.DokumentVr.Partner.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Partner.Sortable)]
    	public bool Partner { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Ugovor.Required)]
    	[DisplayName(AtributClass.DokumentVr.Ugovor.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Ugovor.Sortable)]
    	public bool Ugovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Faktura.Required)]
    	[DisplayName(AtributClass.DokumentVr.Faktura.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Faktura.Sortable)]
    	public bool Faktura { get; set; }
    
        [Required(ErrorMessage = AtributClass.DokumentVr.Nalog.Required)]
    	[DisplayName(AtributClass.DokumentVr.Nalog.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DokumentVr.Nalog.Sortable)]
    	public bool Nalog { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DokumentVrGridFormattedBase()
        { }
    	
    	public DokumentVrGridFormattedBase(Model.Data.View.DokumentVr gridformated)
    	{
    	    this.ID_DokumentVr = gridformated.ID_DokumentVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	    this.IDDokumentGr = gridformated.IDDokumentGr;
    	    this.Obrocni = gridformated.Obrocni;
    	    this.Jednokratni = gridformated.Jednokratni;
    	    this.Kupac = gridformated.Kupac;
    	    this.Partner = gridformated.Partner;
    	    this.Ugovor = gridformated.Ugovor;
    	    this.Faktura = gridformated.Faktura;
    	    this.Nalog = gridformated.Nalog;
    	}
    
    	/*
    	    mymodel.ID_DokumentVr = model.ID_DokumentVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.IDDokumentGr = model.IDDokumentGr;
    	    mymodel.Obrocni = model.Obrocni;
    	    mymodel.Jednokratni = model.Jednokratni;
    	    mymodel.Kupac = model.Kupac;
    	    mymodel.Partner = model.Partner;
    	    mymodel.Ugovor = model.Ugovor;
    	    mymodel.Faktura = model.Faktura;
    	    mymodel.Nalog = model.Nalog;
    		
    	*/
    
    		#endregion
    }
}
