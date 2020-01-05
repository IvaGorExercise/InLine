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
    
    
    public partial class UgovorStanOtkupMoratorijGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Sortable)]
    	public long ID_UgovorStanOtkupMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Sortable)]
    	public int BrojMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.Sortable)]
    	public Nullable<int> BrojUgovor { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupMoratorijGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupMoratorijGridFormattedBase(Model.Data.UgovorStanOtkupMoratorij gridformated)
    	{
    	    this.ID_UgovorStanOtkupMoratorij = gridformated.ID_UgovorStanOtkupMoratorij;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.Datum = gridformated.Datum;
    	    this.BrojMoratorij = gridformated.BrojMoratorij;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.DatumInsert = gridformated.DatumInsert;
    	    this.OsobaInsert = gridformated.OsobaInsert;
    	    this.DatumUpdate = gridformated.DatumUpdate;
    	    this.OsobaUpdate = gridformated.OsobaUpdate;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.Datum = model.Datum;
    	    mymodel.BrojMoratorij = model.BrojMoratorij;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    		
    	*/
    
    		#endregion
    }
}