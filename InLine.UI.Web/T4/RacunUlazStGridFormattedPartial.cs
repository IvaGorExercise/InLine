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
    
    
    public partial class RacunUlazStGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.RacunUlazSt.ID_RacunUlazSt.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.ID_RacunUlazSt.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.ID_RacunUlazSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.ID_RacunUlazSt.Sortable)]
    	public long ID_RacunUlazSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.ID_RacunUlaz.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.ID_RacunUlaz.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.ID_RacunUlaz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.ID_RacunUlaz.Sortable)]
    	public long ID_RacunUlaz { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.RedniBroj.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.RedniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.RedniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.RedniBroj.Sortable)]
    	public int RedniBroj { get; set; }
    
    	[DisplayName(AtributClass.RacunUlazSt.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	[DisplayName(AtributClass.RacunUlazSt.ID_Davanje.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.ID_Davanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.ID_Davanje.Sortable)]
    	public Nullable<long> ID_Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.Cijena.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.Cijena.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.Cijena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.Cijena.Sortable)]
    	public decimal Cijena { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.Kolicina.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.Kolicina.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.Kolicina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.Kolicina.Sortable)]
    	public decimal Kolicina { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosVrijednost.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosVrijednost.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosVrijednost.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosVrijednost.Sortable)]
    	public decimal IznosVrijednost { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.StopaRabat.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.StopaRabat.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.StopaRabat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.StopaRabat.Sortable)]
    	public decimal StopaRabat { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosRabat.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosRabat.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosRabat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosRabat.Sortable)]
    	public decimal IznosRabat { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosOsnova.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosOsnova.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosOsnova.Sortable)]
    	public decimal IznosOsnova { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosPorez.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosPorez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosPorez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosPorez.Sortable)]
    	public decimal IznosPorez { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosUkupno.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosUkupno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosUkupno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosUkupno.Sortable)]
    	public decimal IznosUkupno { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.RacunUlazSt.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IDValuta.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazSt.IznosValuta.Required)]
    	[DisplayName(AtributClass.RacunUlazSt.IznosValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RacunUlazSt.IznosValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RacunUlazSt.IznosValuta.Sortable)]
    	public decimal IznosValuta { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public RacunUlazStGridFormattedBase()
        { }
    	
    	public RacunUlazStGridFormattedBase(Model.Data.RacunUlazSt gridformated)
    	{
    	    this.ID_RacunUlazSt = gridformated.ID_RacunUlazSt;
    	    this.ID_RacunUlaz = gridformated.ID_RacunUlaz;
    	    this.RedniBroj = gridformated.RedniBroj;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.ID_Davanje = gridformated.ID_Davanje;
    	    this.Cijena = gridformated.Cijena;
    	    this.Kolicina = gridformated.Kolicina;
    	    this.IznosVrijednost = gridformated.IznosVrijednost;
    	    this.StopaRabat = gridformated.StopaRabat;
    	    this.IznosRabat = gridformated.IznosRabat;
    	    this.IznosOsnova = gridformated.IznosOsnova;
    	    this.IznosPorez = gridformated.IznosPorez;
    	    this.IznosUkupno = gridformated.IznosUkupno;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.IznosValuta = gridformated.IznosValuta;
    	}
    
    	/*
    	    mymodel.ID_RacunUlazSt = model.ID_RacunUlazSt;
    	    mymodel.ID_RacunUlaz = model.ID_RacunUlaz;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.Cijena = model.Cijena;
    	    mymodel.Kolicina = model.Kolicina;
    	    mymodel.IznosVrijednost = model.IznosVrijednost;
    	    mymodel.StopaRabat = model.StopaRabat;
    	    mymodel.IznosRabat = model.IznosRabat;
    	    mymodel.IznosOsnova = model.IznosOsnova;
    	    mymodel.IznosPorez = model.IznosPorez;
    	    mymodel.IznosUkupno = model.IznosUkupno;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.IznosValuta = model.IznosValuta;
    		
    	*/
    
    		#endregion
    }
}
