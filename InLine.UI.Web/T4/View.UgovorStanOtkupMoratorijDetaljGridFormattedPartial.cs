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
    
    
    public partial class UgovorStanOtkupMoratorijDetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.Sortable)]
    	public long ID_UgovorStanOtkupMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkup.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.Sortable)]
    	public int BrojMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.BrojUgovor.Sortable)]
    	public Nullable<int> BrojUgovor { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupMoratorijDetaljGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupMoratorijDetaljGridFormattedBase(Model.Data.View.UgovorStanOtkupMoratorijDetalj gridformated)
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
