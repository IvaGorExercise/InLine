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


namespace InLine.UI.Web.T4.GridFormattedTemplate.View
{

    public partial class UgovorStanOtkupMoratorijMjesecGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorijMjesec.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorijMjesec.DisplayName)]
        	[ScaffoldColumn(false)]	[JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorijMjesec.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorijMjesec.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public long ID_UgovorStanOtkupMoratorijMjesec { get; set; }
    
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorij.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorij.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.ID_UgovorStanOtkupMoratorij.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //public Nullable<long> ID_UgovorStanOtkupMoratorij { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.Godina.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.Godina.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.Godina.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.Godina.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public int Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.Mjesec.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.Mjesec.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.Mjesec.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.Mjesec.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public int Mjesec { get; set; }
    
        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.BrojUgovor.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.BrojUgovor.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.BrojUgovor.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.BrojUgovor.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //public int BrojUgovor { get; set; }
    
        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.BrojMoratorij.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.BrojMoratorij.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.BrojMoratorij.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.BrojMoratorij.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //public int BrojMoratorij { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.DatumInsert.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.DatumInsert.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.DatumInsert.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaInsert.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaInsert.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaInsert.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //public string OsobaInsert { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.DatumUpdate.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.DatumUpdate.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.DatumUpdate.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaUpdate.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaUpdate.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorijMjesec.OsobaUpdate.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //public string OsobaUpdate { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupMoratorijMjesecGridFormatted()
        { }
    	
    	public UgovorStanOtkupMoratorijMjesecGridFormatted(Model.Data.View.UgovorStanOtkupMoratorijMjesec gridformated)
    	{
    	    this.ID_UgovorStanOtkupMoratorijMjesec = gridformated.ID_UgovorStanOtkupMoratorijMjesec;
            //this.ID_UgovorStanOtkupMoratorij = gridformated.ID_UgovorStanOtkupMoratorij;
    	    this.Godina = gridformated.Godina;
    	    this.Mjesec = gridformated.Mjesec;
            //this.BrojUgovor = gridformated.BrojUgovor;
            //this.BrojMoratorij = gridformated.BrojMoratorij;
            //this.DatumInsert = gridformated.DatumInsert;
            //this.OsobaInsert = gridformated.OsobaInsert;
            //this.DatumUpdate = gridformated.DatumUpdate;
            //this.OsobaUpdate = gridformated.OsobaUpdate;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupMoratorijMjesec = model.ID_UgovorStanOtkupMoratorijMjesec;
    	    mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojMoratorij = model.BrojMoratorij;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    		
    	*/
    
    		#endregion
    }
}