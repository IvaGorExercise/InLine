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
    
    
    public partial class OpomenaDetaljGridFormattedBase
    {
    	#region Properities
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OpomenaDetalj.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpomenaDetalj.BrojOpomena.Required)]
    	[DisplayName(AtributClass.OpomenaDetalj.BrojOpomena.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.BrojOpomena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.BrojOpomena.Sortable)]
    	public int BrojOpomena { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpomenaDetalj.ID_Opomena.Required)]
    	[DisplayName(AtributClass.OpomenaDetalj.ID_Opomena.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.ID_Opomena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.ID_Opomena.Sortable)]
    	public long ID_Opomena { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OpomenaDetalj.DatumDospijeceOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.DatumDospijeceOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.DatumDospijeceOd.Sortable)]
    	public Nullable<System.DateTime> DatumDospijeceOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OpomenaDetalj.DatumDospijeceDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.DatumDospijeceDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.DatumDospijeceDo.Sortable)]
    	public Nullable<System.DateTime> DatumDospijeceDo { get; set; }
    
    	[DisplayName(AtributClass.OpomenaDetalj.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
    	[DisplayName(AtributClass.OpomenaDetalj.OpomenaIznosMin.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.OpomenaIznosMin.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.OpomenaIznosMin.Sortable)]
    	public Nullable<decimal> OpomenaIznosMin { get; set; }
    
    	[DisplayName(AtributClass.OpomenaDetalj.BrojNeplaceniObrokMin.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.BrojNeplaceniObrokMin.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.BrojNeplaceniObrokMin.Sortable)]
    	public Nullable<int> BrojNeplaceniObrokMin { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OpomenaDetalj.DatumInsert.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.DatumInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.DatumInsert.Sortable)]
    	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.OpomenaDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.OpomenaDetalj.OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.OsobaInsert.Sortable)]
    	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OpomenaDetalj.DatumUpdate.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.DatumUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.DatumUpdate.Sortable)]
    	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.OpomenaDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.OpomenaDetalj.OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.OsobaUpdate.Sortable)]
    	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.OpomenaDetalj.ID_OsobaInsert.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.ID_OsobaInsert.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.ID_OsobaInsert.Sortable)]
    	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.OpomenaDetalj.ID_OsobaUpdate.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpomenaDetalj.ID_OsobaUpdate.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpomenaDetalj.ID_OsobaUpdate.Sortable)]
    	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OpomenaDetaljGridFormattedBase()
        { }
    	
    	public OpomenaDetaljGridFormattedBase(Model.Data.View.OpomenaDetalj gridformated)
    	{
    	    this.Datum = gridformated.Datum;
    	    this.BrojOpomena = gridformated.BrojOpomena;
    	    this.ID_Opomena = gridformated.ID_Opomena;
    	    this.DatumDospijeceOd = gridformated.DatumDospijeceOd;
    	    this.DatumDospijeceDo = gridformated.DatumDospijeceDo;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.OpomenaIznosMin = gridformated.OpomenaIznosMin;
    	    this.BrojNeplaceniObrokMin = gridformated.BrojNeplaceniObrokMin;
    	    this.DatumInsert = gridformated.DatumInsert;
    	    this.OsobaInsert = gridformated.OsobaInsert;
    	    this.DatumUpdate = gridformated.DatumUpdate;
    	    this.OsobaUpdate = gridformated.OsobaUpdate;
    	    this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
    	}
    
    	/*
    	    mymodel.Datum = model.Datum;
    	    mymodel.BrojOpomena = model.BrojOpomena;
    	    mymodel.ID_Opomena = model.ID_Opomena;
    	    mymodel.DatumDospijeceOd = model.DatumDospijeceOd;
    	    mymodel.DatumDospijeceDo = model.DatumDospijeceDo;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.OpomenaIznosMin = model.OpomenaIznosMin;
    	    mymodel.BrojNeplaceniObrokMin = model.BrojNeplaceniObrokMin;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    		
    	*/
    
    		#endregion
    }
}
