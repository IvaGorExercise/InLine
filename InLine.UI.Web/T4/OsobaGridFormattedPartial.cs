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
    
    
    public partial class OsobaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Osoba.ID_Osoba.Required)]
    	[DisplayName(AtributClass.Osoba.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Osoba.ID_Osoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Osoba.Sortable)]
    	public long ID_Osoba { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Osoba.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Osoba.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Oznaka.Required)]
    	[DisplayName(AtributClass.Osoba.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Prezime.Required)]
    	[DisplayName(AtributClass.Osoba.Prezime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.Prezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.Prezime.Sortable)]
    	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Ime.Required)]
    	[DisplayName(AtributClass.Osoba.Ime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.Ime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.Ime.Sortable)]
    	public string Ime { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Osoba.DatumRodenja.Required)]
    	[DisplayName(AtributClass.Osoba.DatumRodenja.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Osoba.DatumRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.DatumRodenja.Sortable)]
    	public System.DateTime DatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.MjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.Osoba.MjestoRodenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MjestoRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MjestoRodenja.Sortable)]
    	public string MjestoRodenja { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OtacPrezime.StringLength)]
    	[DisplayName(AtributClass.Osoba.OtacPrezime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OtacPrezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OtacPrezime.Sortable)]
    	public string OtacPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OtacIme.StringLength)]
    	[DisplayName(AtributClass.Osoba.OtacIme.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OtacIme.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OtacIme.Sortable)]
    	public string OtacIme { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Osoba.OtacDatumRodenja.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OtacDatumRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OtacDatumRodenja.Sortable)]
    	public Nullable<System.DateTime> OtacDatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.OtacMjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.Osoba.OtacMjestoRodenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OtacMjestoRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OtacMjestoRodenja.Sortable)]
    	public string OtacMjestoRodenja { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezime.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaPrezime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MajkaPrezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaPrezime.Sortable)]
    	public string MajkaPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaIme.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaIme.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MajkaIme.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaIme.Sortable)]
    	public string MajkaIme { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezimeDjevojacko.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaPrezimeDjevojacko.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MajkaPrezimeDjevojacko.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaPrezimeDjevojacko.Sortable)]
    	public string MajkaPrezimeDjevojacko { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Osoba.MajkaDatumRodenja.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MajkaDatumRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaDatumRodenja.Sortable)]
    	public Nullable<System.DateTime> MajkaDatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.MajkaMjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaMjestoRodenja.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.MajkaMjestoRodenja.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaMjestoRodenja.Sortable)]
    	public string MajkaMjestoRodenja { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Narodnost.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Osoba.ID_Narodnost.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Narodnost.Sortable)]
    	public Nullable<long> ID_Narodnost { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Drzavljanstvo.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Osoba.ID_Drzavljanstvo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Drzavljanstvo.Sortable)]
    	public Nullable<long> ID_Drzavljanstvo { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Osoba.DatumSmrti.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Osoba.DatumSmrti.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.DatumSmrti.Sortable)]
    	public Nullable<System.DateTime> DatumSmrti { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIB.StringLength)]
    	[DisplayName(AtributClass.Osoba.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OIB.Sortable)]
    	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIBHR.StringLength)]
    	[DisplayName(AtributClass.Osoba.OIBHR.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.OIBHR.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.OIBHR.Sortable)]
    	public string OIBHR { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.Osoba.JMBG.StringLength)]
    	[DisplayName(AtributClass.Osoba.JMBG.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Osoba.JMBG.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Osoba.JMBG.Sortable)]
    	public string JMBG { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OsobaGridFormattedBase()
        { }
    	
    	public OsobaGridFormattedBase(Model.Data.Osoba gridformated)
    	{
    	    this.ID_Osoba = gridformated.ID_Osoba;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Prezime = gridformated.Prezime;
    	    this.Ime = gridformated.Ime;
    	    this.DatumRodenja = gridformated.DatumRodenja;
    	    this.MjestoRodenja = gridformated.MjestoRodenja;
    	    this.OtacPrezime = gridformated.OtacPrezime;
    	    this.OtacIme = gridformated.OtacIme;
    	    this.OtacDatumRodenja = gridformated.OtacDatumRodenja;
    	    this.OtacMjestoRodenja = gridformated.OtacMjestoRodenja;
    	    this.MajkaPrezime = gridformated.MajkaPrezime;
    	    this.MajkaIme = gridformated.MajkaIme;
    	    this.MajkaPrezimeDjevojacko = gridformated.MajkaPrezimeDjevojacko;
    	    this.MajkaDatumRodenja = gridformated.MajkaDatumRodenja;
    	    this.MajkaMjestoRodenja = gridformated.MajkaMjestoRodenja;
    	    this.ID_Narodnost = gridformated.ID_Narodnost;
    	    this.ID_Drzavljanstvo = gridformated.ID_Drzavljanstvo;
    	    this.DatumSmrti = gridformated.DatumSmrti;
    	    this.OIB = gridformated.OIB;
    	    this.OIBHR = gridformated.OIBHR;
    	    this.JMBG = gridformated.JMBG;
    	}
    
    	/*
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Prezime = model.Prezime;
    	    mymodel.Ime = model.Ime;
    	    mymodel.DatumRodenja = model.DatumRodenja;
    	    mymodel.MjestoRodenja = model.MjestoRodenja;
    	    mymodel.OtacPrezime = model.OtacPrezime;
    	    mymodel.OtacIme = model.OtacIme;
    	    mymodel.OtacDatumRodenja = model.OtacDatumRodenja;
    	    mymodel.OtacMjestoRodenja = model.OtacMjestoRodenja;
    	    mymodel.MajkaPrezime = model.MajkaPrezime;
    	    mymodel.MajkaIme = model.MajkaIme;
    	    mymodel.MajkaPrezimeDjevojacko = model.MajkaPrezimeDjevojacko;
    	    mymodel.MajkaDatumRodenja = model.MajkaDatumRodenja;
    	    mymodel.MajkaMjestoRodenja = model.MajkaMjestoRodenja;
    	    mymodel.ID_Narodnost = model.ID_Narodnost;
    	    mymodel.ID_Drzavljanstvo = model.ID_Drzavljanstvo;
    	    mymodel.DatumSmrti = model.DatumSmrti;
    	    mymodel.OIB = model.OIB;
    	    mymodel.OIBHR = model.OIBHR;
    	    mymodel.JMBG = model.JMBG;
    		
    	*/
    
    		#endregion
    }
}