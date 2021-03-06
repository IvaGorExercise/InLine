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
    
    
    public partial class NalogGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Nalog.ID_Nalog.Required)]
    	[DisplayName(AtributClass.Nalog.ID_Nalog.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_Nalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_Nalog.Sortable)]
    	public long ID_Nalog { get; set; }
    
    	[DisplayName(AtributClass.Nalog.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.GodinaNalog.Required)]
    	[DisplayName(AtributClass.Nalog.GodinaNalog.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.GodinaNalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.GodinaNalog.Sortable)]
    	public int GodinaNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.BrojNalog.Required)]
    	[DisplayName(AtributClass.Nalog.BrojNalog.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojNalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojNalog.Sortable)]
    	public int BrojNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.BrojUgovor.Required)]
    	[DisplayName(AtributClass.Nalog.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.BrojAneks.Required)]
    	[DisplayName(AtributClass.Nalog.BrojAneks.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojAneks.Sortable)]
    	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.BrojStorno.Required)]
    	[DisplayName(AtributClass.Nalog.BrojStorno.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojStorno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojStorno.Sortable)]
    	public int BrojStorno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Nalog.DatumPlacanje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DatumPlacanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DatumPlacanje.Sortable)]
    	public Nullable<System.DateTime> DatumPlacanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.Iznos.Required)]
    	[DisplayName(AtributClass.Nalog.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.Iznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.Iznos.Sortable)]
    	public decimal Iznos { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosValuta.Required)]
    	[DisplayName(AtributClass.Nalog.IznosValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosValuta.Sortable)]
    	public decimal IznosValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosTecajnaRazlika.Required)]
    	[DisplayName(AtributClass.Nalog.IznosTecajnaRazlika.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosTecajnaRazlika.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosTecajnaRazlika.Sortable)]
    	public decimal IznosTecajnaRazlika { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosKredit.Required)]
    	[DisplayName(AtributClass.Nalog.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosKredit.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosKredit.Sortable)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosKreditRevalorizacija.Required)]
    	[DisplayName(AtributClass.Nalog.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosKreditRevalorizacija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosKreditRevalorizacija.Sortable)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosKamata.Required)]
    	[DisplayName(AtributClass.Nalog.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosKamata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosKamata.Sortable)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosKamataRevalorizacija.Required)]
    	[DisplayName(AtributClass.Nalog.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosKamataRevalorizacija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosKamataRevalorizacija.Sortable)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosJednokratno.Required)]
    	[DisplayName(AtributClass.Nalog.IznosJednokratno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosJednokratno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosJednokratno.Sortable)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosUcesce.Required)]
    	[DisplayName(AtributClass.Nalog.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosUcesce.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosUcesce.Sortable)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.IznosTecajnaRazlika2.Required)]
    	[DisplayName(AtributClass.Nalog.IznosTecajnaRazlika2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IznosTecajnaRazlika2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IznosTecajnaRazlika2.Sortable)]
    	public decimal IznosTecajnaRazlika2 { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.Nalog.IDValuta.StringLength)]
    	[DisplayName(AtributClass.Nalog.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.Nalog.BrojObrok.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojObrok.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojObrok.Sortable)]
    	public Nullable<int> BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.Nalog.BrojIzvod.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojIzvod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojIzvod.Sortable)]
    	public Nullable<int> BrojIzvod { get; set; }
    
    	[DisplayName(AtributClass.Nalog.BrojObveznica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojObveznica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojObveznica.Sortable)]
    	public Nullable<int> BrojObveznica { get; set; }
    
    	[DisplayName(AtributClass.Nalog.DokumentGrupa.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DokumentGrupa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DokumentGrupa.Sortable)]
    	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.Nalog.DokumentVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DokumentVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DokumentVrsta.Sortable)]
    	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.Nalog.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.Nalog.ID_Racun.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_Racun.Sortable)]
    	public Nullable<long> ID_Racun { get; set; }
    
    	[DisplayName(AtributClass.Nalog.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.Nalog.ID_UgovorStanOtkupAneks.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.ID_UgovorStanOtkupAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.ID_UgovorStanOtkupAneks.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.Nalog.GodinaObracun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.GodinaObracun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.GodinaObracun.Sortable)]
    	public Nullable<int> GodinaObracun { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Nalog.SlovimaIznos.StringLength)]
    	[DisplayName(AtributClass.Nalog.SlovimaIznos.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.SlovimaIznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.SlovimaIznos.Sortable)]
    	public string SlovimaIznos { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Nalog.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.Nalog.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Nalog.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Nalog.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.Nalog.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Nalog.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.Nalog.GodinaRjesenje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.GodinaRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.GodinaRjesenje.Sortable)]
    	public Nullable<int> GodinaRjesenje { get; set; }
    
    	[DisplayName(AtributClass.Nalog.BrojRjesenje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nalog.BrojRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.BrojRjesenje.Sortable)]
    	public Nullable<int> BrojRjesenje { get; set; }
    
        [Required(ErrorMessage = AtributClass.Nalog.Storno.Required)]
    	[DisplayName(AtributClass.Nalog.Storno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.Storno.Sortable)]
    	public bool Storno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Nalog.DatumRjesenje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Nalog.DatumRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.DatumRjesenje.Sortable)]
    	public Nullable<System.DateTime> DatumRjesenje { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Nalog.OpisPovrat.StringLength)]
    	[DisplayName(AtributClass.Nalog.OpisPovrat.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.OpisPovrat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.OpisPovrat.Sortable)]
    	public string OpisPovrat { get; set; }
    
    	
        [StringLength(6, ErrorMessage = AtributClass.Nalog.SifraSubjekt.StringLength)]
    	[DisplayName(AtributClass.Nalog.SifraSubjekt.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.SifraSubjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.SifraSubjekt.Sortable)]
    	public string SifraSubjekt { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.Nalog.SifraRacun.StringLength)]
    	[DisplayName(AtributClass.Nalog.SifraRacun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.SifraRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.SifraRacun.Sortable)]
    	public string SifraRacun { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.Nalog.VeznaOznaka.StringLength)]
    	[DisplayName(AtributClass.Nalog.VeznaOznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.VeznaOznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.VeznaOznaka.Sortable)]
    	public string VeznaOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Nalog.Svrha.StringLength)]
    	[DisplayName(AtributClass.Nalog.Svrha.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.Svrha.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.Svrha.Sortable)]
    	public string Svrha { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.Nalog.PozivNaBrojZaduzenja.StringLength)]
    	[DisplayName(AtributClass.Nalog.PozivNaBrojZaduzenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.PozivNaBrojZaduzenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.PozivNaBrojZaduzenja.Sortable)]
    	public string PozivNaBrojZaduzenja { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.Nalog.PozivNaBrojOdobrenja.StringLength)]
    	[DisplayName(AtributClass.Nalog.PozivNaBrojOdobrenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.PozivNaBrojOdobrenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.PozivNaBrojOdobrenja.Sortable)]
    	public string PozivNaBrojOdobrenja { get; set; }
    
    	
        [StringLength(18, ErrorMessage = AtributClass.Nalog.Racun.StringLength)]
    	[DisplayName(AtributClass.Nalog.Racun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nalog.Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nalog.Racun.Sortable)]
    	public string Racun { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public NalogGridFormattedBase()
        { }
    	
    	public NalogGridFormattedBase(Model.Data.Nalog gridformated)
    	{
    	    this.ID_Nalog = gridformated.ID_Nalog;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.GodinaNalog = gridformated.GodinaNalog;
    	    this.BrojNalog = gridformated.BrojNalog;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.BrojAneks = gridformated.BrojAneks;
    	    this.BrojStorno = gridformated.BrojStorno;
    	    this.DatumPlacanje = gridformated.DatumPlacanje;
    	    this.Iznos = gridformated.Iznos;
    	    this.IznosValuta = gridformated.IznosValuta;
    	    this.IznosTecajnaRazlika = gridformated.IznosTecajnaRazlika;
    	    this.IznosKredit = gridformated.IznosKredit;
    	    this.IznosKreditRevalorizacija = gridformated.IznosKreditRevalorizacija;
    	    this.IznosKamata = gridformated.IznosKamata;
    	    this.IznosKamataRevalorizacija = gridformated.IznosKamataRevalorizacija;
    	    this.IznosJednokratno = gridformated.IznosJednokratno;
    	    this.IznosUcesce = gridformated.IznosUcesce;
    	    this.IznosTecajnaRazlika2 = gridformated.IznosTecajnaRazlika2;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.BrojObrok = gridformated.BrojObrok;
    	    this.BrojIzvod = gridformated.BrojIzvod;
    	    this.BrojObveznica = gridformated.BrojObveznica;
    	    this.DokumentGrupa = gridformated.DokumentGrupa;
    	    this.DokumentVrsta = gridformated.DokumentVrsta;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.ID_Racun = gridformated.ID_Racun;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.ID_UgovorStanOtkupAneks = gridformated.ID_UgovorStanOtkupAneks;
    	    this.GodinaObracun = gridformated.GodinaObracun;
    	    this.SlovimaIznos = gridformated.SlovimaIznos;
    	    this.OsobaInsert = gridformated.OsobaInsert;
    	    this.DatumInsert = gridformated.DatumInsert;
    	    this.OsobaUpdate = gridformated.OsobaUpdate;
    	    this.DatumUpdate = gridformated.DatumUpdate;
    	    this.GodinaRjesenje = gridformated.GodinaRjesenje;
    	    this.BrojRjesenje = gridformated.BrojRjesenje;
    	    this.Storno = gridformated.Storno;
    	    this.DatumRjesenje = gridformated.DatumRjesenje;
    	    this.OpisPovrat = gridformated.OpisPovrat;
    	    this.SifraSubjekt = gridformated.SifraSubjekt;
    	    this.SifraRacun = gridformated.SifraRacun;
    	    this.VeznaOznaka = gridformated.VeznaOznaka;
    	    this.Svrha = gridformated.Svrha;
    	    this.PozivNaBrojZaduzenja = gridformated.PozivNaBrojZaduzenja;
    	    this.PozivNaBrojOdobrenja = gridformated.PozivNaBrojOdobrenja;
    	    this.Racun = gridformated.Racun;
    	}
    
    	/*
    	    mymodel.ID_Nalog = model.ID_Nalog;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.GodinaNalog = model.GodinaNalog;
    	    mymodel.BrojNalog = model.BrojNalog;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.DatumPlacanje = model.DatumPlacanje;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.IznosValuta = model.IznosValuta;
    	    mymodel.IznosTecajnaRazlika = model.IznosTecajnaRazlika;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosTecajnaRazlika2 = model.IznosTecajnaRazlika2;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.BrojIzvod = model.BrojIzvod;
    	    mymodel.BrojObveznica = model.BrojObveznica;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_Racun = model.ID_Racun;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.GodinaObracun = model.GodinaObracun;
    	    mymodel.SlovimaIznos = model.SlovimaIznos;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.GodinaRjesenje = model.GodinaRjesenje;
    	    mymodel.BrojRjesenje = model.BrojRjesenje;
    	    mymodel.Storno = model.Storno;
    	    mymodel.DatumRjesenje = model.DatumRjesenje;
    	    mymodel.OpisPovrat = model.OpisPovrat;
    	    mymodel.SifraSubjekt = model.SifraSubjekt;
    	    mymodel.SifraRacun = model.SifraRacun;
    	    mymodel.VeznaOznaka = model.VeznaOznaka;
    	    mymodel.Svrha = model.Svrha;
    	    mymodel.PozivNaBrojZaduzenja = model.PozivNaBrojZaduzenja;
    	    mymodel.PozivNaBrojOdobrenja = model.PozivNaBrojOdobrenja;
    	    mymodel.Racun = model.Racun;
    		
    	*/
    
    		#endregion
    }
}
