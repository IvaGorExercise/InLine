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
    
    
    public partial class ZbrojniNalogGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZbrojniNalog.ID_ZbrojniNalog.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog.ID_ZbrojniNalog.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.ID_ZbrojniNalog.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.ID_ZbrojniNalog.Sortable)]
    	public long ID_ZbrojniNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog.ID_Zapis.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog.IDZbrojniNalogVerzija.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog.IDZbrojniNalogVerzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.IDZbrojniNalogVerzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.IDZbrojniNalogVerzija.Sortable)]
    	public int IDZbrojniNalogVerzija { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalog.DatumPredaje.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog.DatumPredaje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.DatumPredaje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.DatumPredaje.Sortable)]
    	public System.DateTime DatumPredaje { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalog.DatumValuta.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog.DatumValuta.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.DatumValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.DatumValuta.Sortable)]
    	public System.DateTime DatumValuta { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZbrojniNalog.DatotekaNaziv.StringLength)]
    	[DisplayName(AtributClass.ZbrojniNalog.DatotekaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.DatotekaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.DatotekaNaziv.Sortable)]
    	public string DatotekaNaziv { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalog.Datoteka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalog.Datoteka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalog.Datoteka.Sortable)]
    	public string Datoteka { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZbrojniNalogGridFormattedBase()
        { }
    	
    	public ZbrojniNalogGridFormattedBase(Model.Data.ZbrojniNalog gridformated)
    	{
    	    this.ID_ZbrojniNalog = gridformated.ID_ZbrojniNalog;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.IDZbrojniNalogVerzija = gridformated.IDZbrojniNalogVerzija;
    	    this.DatumPredaje = gridformated.DatumPredaje;
    	    this.DatumValuta = gridformated.DatumValuta;
    	    this.DatotekaNaziv = gridformated.DatotekaNaziv;
    	    this.Datoteka = gridformated.Datoteka;
    	}
    
    	/*
    	    mymodel.ID_ZbrojniNalog = model.ID_ZbrojniNalog;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDZbrojniNalogVerzija = model.IDZbrojniNalogVerzija;
    	    mymodel.DatumPredaje = model.DatumPredaje;
    	    mymodel.DatumValuta = model.DatumValuta;
    	    mymodel.DatotekaNaziv = model.DatotekaNaziv;
    	    mymodel.Datoteka = model.Datoteka;
    		
    	*/
    
    		#endregion
    }
}
