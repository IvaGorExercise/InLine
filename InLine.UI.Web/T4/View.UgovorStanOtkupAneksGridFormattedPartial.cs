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
    
    
    public partial class UgovorStanOtkupAneksGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Sortable)]
    	public long ID_UgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.BrojAneks.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojAneks.Sortable)]
    	public int BrojAneks { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.BrojStorno.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojStorno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojStorno.Sortable)]
    	public int BrojStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.TecajDM.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TecajDM.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TecajDM.Sortable)]
    	public Nullable<decimal> TecajDM { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.Sortable)]
    	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.Sortable)]
    	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.Sortable)]
    	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.DokumentGrupa.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.DokumentGrupa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.DokumentGrupa.Sortable)]
    	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.DokumentVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.DokumentVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.DokumentVrsta.Sortable)]
    	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.BrojObrokOd.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojObrokOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojObrokOd.Sortable)]
    	public Nullable<int> BrojObrokOd { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.Sortable)]
    	public Nullable<long> ID_DokumentVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.Godina.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.Godina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Godina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Godina.Sortable)]
    	public int Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.Mjesec.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupAneks.Mjesec.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Mjesec.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Mjesec.Sortable)]
    	public int Mjesec { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupAneksGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupAneksGridFormattedBase(Model.Data.View.UgovorStanOtkupAneks gridformated)
    	{
    	    this.ID_UgovorStanOtkupAneks = gridformated.ID_UgovorStanOtkupAneks;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.BrojAneks = gridformated.BrojAneks;
    	    this.Datum = gridformated.Datum;
    	    this.BrojStorno = gridformated.BrojStorno;
    	    this.TecajDM = gridformated.TecajDM;
    	    this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
    	    this.DokumentGrupa = gridformated.DokumentGrupa;
    	    this.DokumentVrsta = gridformated.DokumentVrsta;
    	    this.BrojObrokOd = gridformated.BrojObrokOd;
    	    this.ID_DokumentVr = gridformated.ID_DokumentVr;
    	    this.Godina = gridformated.Godina;
    	    this.Mjesec = gridformated.Mjesec;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.Datum = model.Datum;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.TecajDM = model.TecajDM;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.BrojObrokOd = model.BrojObrokOd;
    	    mymodel.ID_DokumentVr = model.ID_DokumentVr;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    		
    	*/
    
    		#endregion
    }
}