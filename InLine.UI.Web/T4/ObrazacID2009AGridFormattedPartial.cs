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
    
    
    public partial class ObrazacID2009AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ID_ObrazacID2009A.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ID_ObrazacID2009A.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ID_ObrazacID2009A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ID_ObrazacID2009A.Sortable)]
    	public long ID_ObrazacID2009A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ID_ObrazacID.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ID_ObrazacID.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ID_ObrazacID.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ID_ObrazacID.Sortable)]
    	public long ID_ObrazacID { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacID2009A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.Naziv.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacID2009A.Adresa.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.Adresa.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.Adresa.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.Adresa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.Adresa.Sortable)]
    	public string Adresa { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.ObrazacID2009A.PorezniBroj.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.PorezniBroj.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.PorezniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.PorezniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.PorezniBroj.Sortable)]
    	public string PorezniBroj { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.IDObrazacIDIdentifikator2009A.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.IDObrazacIDIdentifikator2009A.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.IDObrazacIDIdentifikator2009A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.IDObrazacIDIdentifikator2009A.Sortable)]
    	public int IDObrazacIDIdentifikator2009A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.IsplataPrimitak.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.IsplataPrimitak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.IsplataPrimitak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.IsplataPrimitak.Sortable)]
    	public decimal IsplataPrimitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDoprinos.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDoprinos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDoprinos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDoprinos.Sortable)]
    	public decimal UplataDoprinos { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDoprinosIz.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDoprinosIz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDoprinosIz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDoprinosIz.Sortable)]
    	public decimal UplataDoprinosIz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDoprinosMIO1.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDoprinosMIO1.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDoprinosMIO1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDoprinosMIO1.Sortable)]
    	public decimal UplataDoprinosMIO1 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDoprinosMIO2.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDoprinosMIO2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDoprinosMIO2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDoprinosMIO2.Sortable)]
    	public decimal UplataDoprinosMIO2 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDoprinosOstaloIz.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDoprinosOstaloIz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDoprinosOstaloIz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDoprinosOstaloIz.Sortable)]
    	public decimal UplataDoprinosOstaloIz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataOsiguranje.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataOsiguranje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataOsiguranje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataOsiguranje.Sortable)]
    	public decimal UplataOsiguranje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataOsiguranjeZivotno.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataOsiguranjeZivotno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataOsiguranjeZivotno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataOsiguranjeZivotno.Sortable)]
    	public decimal UplataOsiguranjeZivotno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataOsiguranjeZdravstvo.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataOsiguranjeZdravstvo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataOsiguranjeZdravstvo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataOsiguranjeZdravstvo.Sortable)]
    	public decimal UplataOsiguranjeZdravstvo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataOsiguranjeMIO.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataOsiguranjeMIO.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataOsiguranjeMIO.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataOsiguranjeMIO.Sortable)]
    	public decimal UplataOsiguranjeMIO { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataDohodak.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataDohodak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataDohodak.Sortable)]
    	public decimal UplataDohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataOsobniOdbitak.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataOsobniOdbitak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataOsobniOdbitak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataOsobniOdbitak.Sortable)]
    	public decimal UplataOsobniOdbitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataPoreznaOsnova.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataPoreznaOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataPoreznaOsnova.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataPoreznaOsnova.Sortable)]
    	public decimal UplataPoreznaOsnova { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunPorezPrirez.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunPorezPrirez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunPorezPrirez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunPorezPrirez.Sortable)]
    	public decimal ObracunPorezPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunPorez.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunPorez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunPorez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunPorez.Sortable)]
    	public decimal ObracunPorez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunPrirez.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunPrirez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunPrirez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunPrirez.Sortable)]
    	public decimal ObracunPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.UplataPorezPrirez.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.UplataPorezPrirez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.UplataPorezPrirez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.UplataPorezPrirez.Sortable)]
    	public decimal UplataPorezPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.BrojPrimatelja.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.BrojPrimatelja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.BrojPrimatelja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.BrojPrimatelja.Sortable)]
    	public int BrojPrimatelja { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosMIO1.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosMIO1.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosMIO1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosMIO1.Sortable)]
    	public decimal ObracunDoprinosMIO1 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosStaz1.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosStaz1.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosStaz1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosStaz1.Sortable)]
    	public decimal ObracunDoprinosStaz1 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosMIO2.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosMIO2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosMIO2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosMIO2.Sortable)]
    	public decimal ObracunDoprinosMIO2 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosStaz2.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosStaz2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosStaz2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosStaz2.Sortable)]
    	public decimal ObracunDoprinosStaz2 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvo.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvo.Sortable)]
    	public decimal ObracunDoprinosZdravstvo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoRad.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoRad.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoRad.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoRad.Sortable)]
    	public decimal ObracunDoprinosZdravstvoRad { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoIno.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoIno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoIno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosZdravstvoIno.Sortable)]
    	public decimal ObracunDoprinosZdravstvoIno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanje.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanje.Sortable)]
    	public decimal ObracunDoprinosZaposljavanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanjeInv.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanjeInv.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanjeInv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.ObracunDoprinosZaposljavanjeInv.Sortable)]
    	public decimal ObracunDoprinosZaposljavanjeInv { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID2009A.BrojOsiguranihOsoba.Required)]
    	[DisplayName(AtributClass.ObrazacID2009A.BrojOsiguranihOsoba.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID2009A.BrojOsiguranihOsoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID2009A.BrojOsiguranihOsoba.Sortable)]
    	public int BrojOsiguranihOsoba { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacID2009AGridFormattedBase()
        { }
    	
    	public ObrazacID2009AGridFormattedBase(Model.Data.ObrazacID2009A gridformated)
    	{
    	    this.ID_ObrazacID2009A = gridformated.ID_ObrazacID2009A;
    	    this.ID_ObrazacID = gridformated.ID_ObrazacID;
    	    this.Naziv = gridformated.Naziv;
    	    this.Adresa = gridformated.Adresa;
    	    this.PorezniBroj = gridformated.PorezniBroj;
    	    this.IDObrazacIDIdentifikator2009A = gridformated.IDObrazacIDIdentifikator2009A;
    	    this.IsplataPrimitak = gridformated.IsplataPrimitak;
    	    this.UplataDoprinos = gridformated.UplataDoprinos;
    	    this.UplataDoprinosIz = gridformated.UplataDoprinosIz;
    	    this.UplataDoprinosMIO1 = gridformated.UplataDoprinosMIO1;
    	    this.UplataDoprinosMIO2 = gridformated.UplataDoprinosMIO2;
    	    this.UplataDoprinosOstaloIz = gridformated.UplataDoprinosOstaloIz;
    	    this.UplataOsiguranje = gridformated.UplataOsiguranje;
    	    this.UplataOsiguranjeZivotno = gridformated.UplataOsiguranjeZivotno;
    	    this.UplataOsiguranjeZdravstvo = gridformated.UplataOsiguranjeZdravstvo;
    	    this.UplataOsiguranjeMIO = gridformated.UplataOsiguranjeMIO;
    	    this.UplataDohodak = gridformated.UplataDohodak;
    	    this.UplataOsobniOdbitak = gridformated.UplataOsobniOdbitak;
    	    this.UplataPoreznaOsnova = gridformated.UplataPoreznaOsnova;
    	    this.ObracunPorezPrirez = gridformated.ObracunPorezPrirez;
    	    this.ObracunPorez = gridformated.ObracunPorez;
    	    this.ObracunPrirez = gridformated.ObracunPrirez;
    	    this.UplataPorezPrirez = gridformated.UplataPorezPrirez;
    	    this.BrojPrimatelja = gridformated.BrojPrimatelja;
    	    this.ObracunDoprinosMIO1 = gridformated.ObracunDoprinosMIO1;
    	    this.ObracunDoprinosStaz1 = gridformated.ObracunDoprinosStaz1;
    	    this.ObracunDoprinosMIO2 = gridformated.ObracunDoprinosMIO2;
    	    this.ObracunDoprinosStaz2 = gridformated.ObracunDoprinosStaz2;
    	    this.ObracunDoprinosZdravstvo = gridformated.ObracunDoprinosZdravstvo;
    	    this.ObracunDoprinosZdravstvoRad = gridformated.ObracunDoprinosZdravstvoRad;
    	    this.ObracunDoprinosZdravstvoIno = gridformated.ObracunDoprinosZdravstvoIno;
    	    this.ObracunDoprinosZaposljavanje = gridformated.ObracunDoprinosZaposljavanje;
    	    this.ObracunDoprinosZaposljavanjeInv = gridformated.ObracunDoprinosZaposljavanjeInv;
    	    this.BrojOsiguranihOsoba = gridformated.BrojOsiguranihOsoba;
    	}
    
    	/*
    	    mymodel.ID_ObrazacID2009A = model.ID_ObrazacID2009A;
    	    mymodel.ID_ObrazacID = model.ID_ObrazacID;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Adresa = model.Adresa;
    	    mymodel.PorezniBroj = model.PorezniBroj;
    	    mymodel.IDObrazacIDIdentifikator2009A = model.IDObrazacIDIdentifikator2009A;
    	    mymodel.IsplataPrimitak = model.IsplataPrimitak;
    	    mymodel.UplataDoprinos = model.UplataDoprinos;
    	    mymodel.UplataDoprinosIz = model.UplataDoprinosIz;
    	    mymodel.UplataDoprinosMIO1 = model.UplataDoprinosMIO1;
    	    mymodel.UplataDoprinosMIO2 = model.UplataDoprinosMIO2;
    	    mymodel.UplataDoprinosOstaloIz = model.UplataDoprinosOstaloIz;
    	    mymodel.UplataOsiguranje = model.UplataOsiguranje;
    	    mymodel.UplataOsiguranjeZivotno = model.UplataOsiguranjeZivotno;
    	    mymodel.UplataOsiguranjeZdravstvo = model.UplataOsiguranjeZdravstvo;
    	    mymodel.UplataOsiguranjeMIO = model.UplataOsiguranjeMIO;
    	    mymodel.UplataDohodak = model.UplataDohodak;
    	    mymodel.UplataOsobniOdbitak = model.UplataOsobniOdbitak;
    	    mymodel.UplataPoreznaOsnova = model.UplataPoreznaOsnova;
    	    mymodel.ObracunPorezPrirez = model.ObracunPorezPrirez;
    	    mymodel.ObracunPorez = model.ObracunPorez;
    	    mymodel.ObracunPrirez = model.ObracunPrirez;
    	    mymodel.UplataPorezPrirez = model.UplataPorezPrirez;
    	    mymodel.BrojPrimatelja = model.BrojPrimatelja;
    	    mymodel.ObracunDoprinosMIO1 = model.ObracunDoprinosMIO1;
    	    mymodel.ObracunDoprinosStaz1 = model.ObracunDoprinosStaz1;
    	    mymodel.ObracunDoprinosMIO2 = model.ObracunDoprinosMIO2;
    	    mymodel.ObracunDoprinosStaz2 = model.ObracunDoprinosStaz2;
    	    mymodel.ObracunDoprinosZdravstvo = model.ObracunDoprinosZdravstvo;
    	    mymodel.ObracunDoprinosZdravstvoRad = model.ObracunDoprinosZdravstvoRad;
    	    mymodel.ObracunDoprinosZdravstvoIno = model.ObracunDoprinosZdravstvoIno;
    	    mymodel.ObracunDoprinosZaposljavanje = model.ObracunDoprinosZaposljavanje;
    	    mymodel.ObracunDoprinosZaposljavanjeInv = model.ObracunDoprinosZaposljavanjeInv;
    	    mymodel.BrojOsiguranihOsoba = model.BrojOsiguranihOsoba;
    		
    	*/
    
    		#endregion
    }
}
