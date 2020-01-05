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
    
    
    public partial class UgovorStanOtkupObrokPreplataGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Sortable)]
    	public long ID_UgovorStanOtkupObrokPreplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Broj.Sortable)]
    	public Nullable<int> Broj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Sortable)]
    	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojAneks.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojAneks.Sortable)]
    	public Nullable<int> BrojAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojStorno.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojStorno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojStorno.Sortable)]
    	public Nullable<int> BrojStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Sortable)]
    	public Nullable<int> BrojObrok { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.Sortable)]
    	public Nullable<decimal> IznosPreplata { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplataValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplataValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplataValuta.Sortable)]
    	public Nullable<decimal> IznosPreplataValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Sortable)]
    	public bool Aktivno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojPreplata.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojPreplata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojPreplata.Sortable)]
    	public Nullable<int> BrojPreplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaGodina.Sortable)]
    	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaVrsta.Sortable)]
    	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.TemeljnicaBroj.Sortable)]
    	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaInsert.Sortable)]
    	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_OsobaUpdate.Sortable)]
    	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.GodinaObrokFormiranje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.GodinaObrokFormiranje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.GodinaObrokFormiranje.Sortable)]
    	public Nullable<int> GodinaObrokFormiranje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.MjesecObrokFormiranje.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.MjesecObrokFormiranje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.MjesecObrokFormiranje.Sortable)]
    	public Nullable<int> MjesecObrokFormiranje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_PlacanjeVr.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_PlacanjeVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_PlacanjeVr.Sortable)]
    	public Nullable<long> ID_PlacanjeVr { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_Racun.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_Racun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_Racun.Sortable)]
    	public Nullable<long> ID_Racun { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojObveznica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojObveznica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojObveznica.Sortable)]
    	public Nullable<int> BrojObveznica { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.NeZateznaKamata.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.NeZateznaKamata.Sortable)]
    	public Nullable<bool> NeZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupObrokPreplataGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupObrokPreplataGridFormattedBase(Model.Data.UgovorStanOtkupObrokPreplata gridformated)
    	{
    	    this.ID_UgovorStanOtkupObrokPreplata = gridformated.ID_UgovorStanOtkupObrokPreplata;
    	    this.ID_UgovorStanOtkupObrok = gridformated.ID_UgovorStanOtkupObrok;
    	    this.Broj = gridformated.Broj;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.BrojAneks = gridformated.BrojAneks;
    	    this.BrojStorno = gridformated.BrojStorno;
    	    this.BrojObrok = gridformated.BrojObrok;
    	    this.Datum = gridformated.Datum;
    	    this.IznosPreplata = gridformated.IznosPreplata;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.IznosPreplataValuta = gridformated.IznosPreplataValuta;
    	    this.Aktivno = gridformated.Aktivno;
    	    this.BrojPreplata = gridformated.BrojPreplata;
    	    this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
    	    this.DatumInsert = gridformated.DatumInsert;
    	    this.OsobaInsert = gridformated.OsobaInsert;
    	    this.DatumUpdate = gridformated.DatumUpdate;
    	    this.OsobaUpdate = gridformated.OsobaUpdate;
    	    this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
    	    this.GodinaObrokFormiranje = gridformated.GodinaObrokFormiranje;
    	    this.MjesecObrokFormiranje = gridformated.MjesecObrokFormiranje;
    	    this.ID_PlacanjeVr = gridformated.ID_PlacanjeVr;
    	    this.ID_Racun = gridformated.ID_Racun;
    	    this.BrojObveznica = gridformated.BrojObveznica;
    	    this.NeZateznaKamata = gridformated.NeZateznaKamata;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupObrokPreplata = model.ID_UgovorStanOtkupObrokPreplata;
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.Broj = model.Broj;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.Datum = model.Datum;
    	    mymodel.IznosPreplata = model.IznosPreplata;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.IznosPreplataValuta = model.IznosPreplataValuta;
    	    mymodel.Aktivno = model.Aktivno;
    	    mymodel.BrojPreplata = model.BrojPreplata;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.GodinaObrokFormiranje = model.GodinaObrokFormiranje;
    	    mymodel.MjesecObrokFormiranje = model.MjesecObrokFormiranje;
    	    mymodel.ID_PlacanjeVr = model.ID_PlacanjeVr;
    	    mymodel.ID_Racun = model.ID_Racun;
    	    mymodel.BrojObveznica = model.BrojObveznica;
    	    mymodel.NeZateznaKamata = model.NeZateznaKamata;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    		
    	*/
    
    		#endregion
    }
}
