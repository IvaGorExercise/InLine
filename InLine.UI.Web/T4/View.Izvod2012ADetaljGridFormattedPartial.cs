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
    
    
    public partial class Izvod2012ADetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Izvod2012ADetalj.ID_Izvod2012A.Required)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.ID_Izvod2012A.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.ID_Izvod2012A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.ID_Izvod2012A.Sortable)]
    	public long ID_Izvod2012A { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.ID_Izvod.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.ID_Izvod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.ID_Izvod.Sortable)]
    	public Nullable<long> ID_Izvod { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaVBDI.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.BankaVBDI.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.BankaVBDI.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.BankaVBDI.Sortable)]
    	public string BankaVBDI { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaNaziv.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.BankaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.BankaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.BankaNaziv.Sortable)]
    	public string BankaNaziv { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaOIB.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.BankaOIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.BankaOIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.BankaOIB.Sortable)]
    	public string BankaOIB { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.IzvadakVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.IzvadakVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.IzvadakVr.Sortable)]
    	public Nullable<int> IzvadakVr { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.DatumObrada.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.DatumObrada.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.DatumObrada.Sortable)]
    	public Nullable<System.DateTime> DatumObrada { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaBIC.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.BankaBIC.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.BankaBIC.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.BankaBIC.Sortable)]
    	public string BankaBIC { get; set; }
    
    	
        [StringLength(21, ErrorMessage = AtributClass.Izvod2012ADetalj.Racun.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.Racun.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.Racun.Sortable)]
    	public string Racun { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.Izvod2012ADetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	
        [StringLength(70, ErrorMessage = AtributClass.Izvod2012ADetalj.Naziv.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.Izvod2012ADetalj.Sjediste.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.Sjediste.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.Sjediste.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.Sjediste.Sortable)]
    	public string Sjediste { get; set; }
    
    	
        [StringLength(8, ErrorMessage = AtributClass.Izvod2012ADetalj.MaticniBroj.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.MaticniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.MaticniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.MaticniBroj.Sortable)]
    	public string MaticniBroj { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.OIB.StringLength)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.OIB.Sortable)]
    	public string OIB { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.RedniBrojIzvadak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.RedniBrojIzvadak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.RedniBrojIzvadak.Sortable)]
    	public Nullable<int> RedniBrojIzvadak { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.PodbrojIzvadak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.PodbrojIzvadak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.PodbrojIzvadak.Sortable)]
    	public Nullable<int> PodbrojIzvadak { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.DatumIzvadak.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.DatumIzvadak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.DatumIzvadak.Sortable)]
    	public Nullable<System.DateTime> DatumIzvadak { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.RedniBrojGrupa.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.RedniBrojGrupa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.RedniBrojGrupa.Sortable)]
    	public Nullable<int> RedniBrojGrupa { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.VrstaIzvadak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.VrstaIzvadak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.VrstaIzvadak.Sortable)]
    	public Nullable<int> VrstaIzvadak { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.Izvod2012ADetalj.IDIzvodVerzija.Required)]
    	[DisplayName(AtributClass.Izvod2012ADetalj.IDIzvodVerzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.IDIzvodVerzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.IDIzvodVerzija.Sortable)]
    	public int IDIzvodVerzija { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.IznosDuguje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.IznosDuguje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.IznosDuguje.Sortable)]
    	public Nullable<decimal> IznosDuguje { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.IznosPotrazuje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.IznosPotrazuje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.IznosPotrazuje.Sortable)]
    	public Nullable<decimal> IznosPotrazuje { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.Saldostaro.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.Saldostaro.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.Saldostaro.Sortable)]
    	public Nullable<decimal> Saldostaro { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.SaldoNovo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.SaldoNovo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.SaldoNovo.Sortable)]
    	public Nullable<decimal> SaldoNovo { get; set; }
    
    	[DisplayName(AtributClass.Izvod2012ADetalj.ID_SubjektRacun.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Izvod2012ADetalj.ID_SubjektRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ADetalj.ID_SubjektRacun.Sortable)]
    	public Nullable<long> ID_SubjektRacun { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public Izvod2012ADetaljGridFormattedBase()
        { }
    	
    	public Izvod2012ADetaljGridFormattedBase(Model.Data.View.Izvod2012ADetalj gridformated)
    	{
    	    this.ID_Izvod2012A = gridformated.ID_Izvod2012A;
    	    this.ID_Izvod = gridformated.ID_Izvod;
    	    this.BankaVBDI = gridformated.BankaVBDI;
    	    this.BankaNaziv = gridformated.BankaNaziv;
    	    this.BankaOIB = gridformated.BankaOIB;
    	    this.IzvadakVr = gridformated.IzvadakVr;
    	    this.DatumObrada = gridformated.DatumObrada;
    	    this.BankaBIC = gridformated.BankaBIC;
    	    this.Racun = gridformated.Racun;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.Naziv = gridformated.Naziv;
    	    this.Sjediste = gridformated.Sjediste;
    	    this.MaticniBroj = gridformated.MaticniBroj;
    	    this.OIB = gridformated.OIB;
    	    this.RedniBrojIzvadak = gridformated.RedniBrojIzvadak;
    	    this.PodbrojIzvadak = gridformated.PodbrojIzvadak;
    	    this.DatumIzvadak = gridformated.DatumIzvadak;
    	    this.RedniBrojGrupa = gridformated.RedniBrojGrupa;
    	    this.VrstaIzvadak = gridformated.VrstaIzvadak;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.IDIzvodVerzija = gridformated.IDIzvodVerzija;
    	    this.IznosDuguje = gridformated.IznosDuguje;
    	    this.IznosPotrazuje = gridformated.IznosPotrazuje;
    	    this.Saldostaro = gridformated.Saldostaro;
    	    this.SaldoNovo = gridformated.SaldoNovo;
    	    this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
    	}
    
    	/*
    	    mymodel.ID_Izvod2012A = model.ID_Izvod2012A;
    	    mymodel.ID_Izvod = model.ID_Izvod;
    	    mymodel.BankaVBDI = model.BankaVBDI;
    	    mymodel.BankaNaziv = model.BankaNaziv;
    	    mymodel.BankaOIB = model.BankaOIB;
    	    mymodel.IzvadakVr = model.IzvadakVr;
    	    mymodel.DatumObrada = model.DatumObrada;
    	    mymodel.BankaBIC = model.BankaBIC;
    	    mymodel.Racun = model.Racun;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Sjediste = model.Sjediste;
    	    mymodel.MaticniBroj = model.MaticniBroj;
    	    mymodel.OIB = model.OIB;
    	    mymodel.RedniBrojIzvadak = model.RedniBrojIzvadak;
    	    mymodel.PodbrojIzvadak = model.PodbrojIzvadak;
    	    mymodel.DatumIzvadak = model.DatumIzvadak;
    	    mymodel.RedniBrojGrupa = model.RedniBrojGrupa;
    	    mymodel.VrstaIzvadak = model.VrstaIzvadak;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDIzvodVerzija = model.IDIzvodVerzija;
    	    mymodel.IznosDuguje = model.IznosDuguje;
    	    mymodel.IznosPotrazuje = model.IznosPotrazuje;
    	    mymodel.Saldostaro = model.Saldostaro;
    	    mymodel.SaldoNovo = model.SaldoNovo;
    	    mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    		
    	*/
    
    		#endregion
    }
}