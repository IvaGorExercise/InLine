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
    
    
    public partial class DatotekaIzvod2012AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod2012A.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod2012A.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod2012A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod2012A.Sortable)]
    	public long ID_DatotekaIzvod2012A { get; set; }
    
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.ID_DatotekaIzvod.Sortable)]
    	public long ID_DatotekaIzvod { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.DatotekaIzvod2012A.VBDI.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.VBDI.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.VBDI.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.VBDI.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.VBDI.Sortable)]
    	public string VBDI { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.DatotekaIzvod2012A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.Naziv.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.DatotekaIzvod2012A.OIB.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.OIB.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.OIB.Sortable)]
    	public string OIB { get; set; }
    
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.Vrsta.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.Vrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.Vrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.Vrsta.Sortable)]
    	public int Vrsta { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.DatotekaIzvod2012A.Datum.Required)]
    	[DisplayName(AtributClass.DatotekaIzvod2012A.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.DatotekaIzvod2012A.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaIzvod2012A.Datum.Sortable)]
    	public System.DateTime Datum { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DatotekaIzvod2012AGridFormattedBase()
        { }
    	
    	public DatotekaIzvod2012AGridFormattedBase(Model.Data.DatotekaIzvod2012A gridformated)
    	{
    	    this.ID_DatotekaIzvod2012A = gridformated.ID_DatotekaIzvod2012A;
    	    this.ID_DatotekaIzvod = gridformated.ID_DatotekaIzvod;
    	    this.VBDI = gridformated.VBDI;
    	    this.Naziv = gridformated.Naziv;
    	    this.OIB = gridformated.OIB;
    	    this.Vrsta = gridformated.Vrsta;
    	    this.Datum = gridformated.Datum;
    	}
    
    	/*
    	    mymodel.ID_DatotekaIzvod2012A = model.ID_DatotekaIzvod2012A;
    	    mymodel.ID_DatotekaIzvod = model.ID_DatotekaIzvod;
    	    mymodel.VBDI = model.VBDI;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.OIB = model.OIB;
    	    mymodel.Vrsta = model.Vrsta;
    	    mymodel.Datum = model.Datum;
    		
    	*/
    
    		#endregion
    }
}
