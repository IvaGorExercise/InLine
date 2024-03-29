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
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Sortable)]
    	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Broj.Sortable)]
    	public Nullable<int> Broj { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Sortable)]
    	public bool Aktivno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Sortable)]
    	public Nullable<int> BrojObrok { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupObrokPreplataGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupObrokPreplataGridFormattedBase(Model.Data.View.UgovorStanOtkupObrokPreplata gridformated)
    	{
    	    this.ID_UgovorStanOtkupObrokPreplata = gridformated.ID_UgovorStanOtkupObrokPreplata;
    	    this.ID_UgovorStanOtkupObrok = gridformated.ID_UgovorStanOtkupObrok;
    	    this.Datum = gridformated.Datum;
    	    this.IznosPreplata = gridformated.IznosPreplata;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.Broj = gridformated.Broj;
    	    this.Aktivno = gridformated.Aktivno;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.BrojObrok = gridformated.BrojObrok;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupObrokPreplata = model.ID_UgovorStanOtkupObrokPreplata;
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.Datum = model.Datum;
    	    mymodel.IznosPreplata = model.IznosPreplata;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Aktivno = model.Aktivno;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojObrok = model.BrojObrok;
    		
    	*/
    
    		#endregion
    }
}
