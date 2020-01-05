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
    
    
    public partial class UgovorStanOtkupNalogDetaljGridFormattedBase
    {
    	#region Properities
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumPlacanje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DatumPlacanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DatumPlacanje.Sortable)]
    	public Nullable<System.DateTime> DatumPlacanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Iznos.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.Iznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.Iznos.Sortable)]
    	public decimal Iznos { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.Sortable)]
    	public int GodinaNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.Sortable)]
    	public int BrojNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.Sortable)]
    	public long ID_Nalog { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.Sortable)]
    	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.Sortable)]
    	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.Sortable)]
    	public decimal IznosValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.Sortable)]
    	public decimal IznosTecajnaRazlika { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.Sortable)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.Sortable)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.Sortable)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.Sortable)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.Sortable)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.Sortable)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.Sortable)]
    	public decimal IznosTecajnaRazlika2 { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojObrok.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojObrok.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojObrok.Sortable)]
    	public Nullable<int> BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojIzvod.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojIzvod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojIzvod.Sortable)]
    	public Nullable<int> BrojIzvod { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojObveznica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojObveznica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojObveznica.Sortable)]
    	public Nullable<int> BrojObveznica { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DokumentGrupa.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DokumentGrupa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DokumentGrupa.Sortable)]
    	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DokumentVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DokumentVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DokumentVrsta.Sortable)]
    	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Racun.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_Racun.Sortable)]
    	public Nullable<long> ID_Racun { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkupAneks.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkupAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkupAneks.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaObracun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.GodinaObracun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.GodinaObracun.Sortable)]
    	public Nullable<int> GodinaObracun { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.Sortable)]
    	public string SlovimaIznos { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaRjesenje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.GodinaRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.GodinaRjesenje.Sortable)]
    	public Nullable<int> GodinaRjesenje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojRjesenje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.BrojRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.BrojRjesenje.Sortable)]
    	public Nullable<int> BrojRjesenje { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Storno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Storno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.Storno.Sortable)]
    	public bool Storno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumRjesenje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.DatumRjesenje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.DatumRjesenje.Sortable)]
    	public Nullable<System.DateTime> DatumRjesenje { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.Sortable)]
    	public string OpisPovrat { get; set; }
    
    	
        [StringLength(6, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.Sortable)]
    	public string SifraSubjekt { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.Sortable)]
    	public string SifraRacun { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.Sortable)]
    	public string VeznaOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Svrha.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Svrha.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.Svrha.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.Svrha.Sortable)]
    	public string Svrha { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.Sortable)]
    	public string PozivNaBrojZaduzenja { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.Sortable)]
    	public string PozivNaBrojOdobrenja { get; set; }
    
    	
        [StringLength(18, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Racun.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Racun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalogDetalj.Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalogDetalj.Racun.Sortable)]
    	public string Racun { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupNalogDetaljGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupNalogDetaljGridFormattedBase(Model.Data.View.UgovorStanOtkupNalogDetalj gridformated)
    	{
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.DatumPlacanje = gridformated.DatumPlacanje;
    	    this.Iznos = gridformated.Iznos;
    	    this.GodinaNalog = gridformated.GodinaNalog;
    	    this.BrojNalog = gridformated.BrojNalog;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.ID_Nalog = gridformated.ID_Nalog;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.BrojAneks = gridformated.BrojAneks;
    	    this.BrojStorno = gridformated.BrojStorno;
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
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.DatumPlacanje = model.DatumPlacanje;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.GodinaNalog = model.GodinaNalog;
    	    mymodel.BrojNalog = model.BrojNalog;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.ID_Nalog = model.ID_Nalog;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
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
