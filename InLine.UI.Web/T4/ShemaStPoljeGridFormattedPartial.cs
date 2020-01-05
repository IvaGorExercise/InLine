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
    
    
    public partial class ShemaStPoljeGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ShemaStPolje.ID_ShemaStPolje.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.ID_ShemaStPolje.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.ID_ShemaStPolje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.ID_ShemaStPolje.Sortable)]
    	public long ID_ShemaStPolje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.ID_ShemaSt.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.ID_ShemaSt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.ID_ShemaSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.ID_ShemaSt.Sortable)]
    	public long ID_ShemaSt { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaShema.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaShema.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.TablicaShema.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.TablicaShema.Sortable)]
    	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaPoljeNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaPoljeNaziv.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaPoljeNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.TablicaPoljeNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.TablicaPoljeNaziv.Sortable)]
    	public string TablicaPoljeNaziv { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ShemaStPolje.AritmetickiOperator.StringLength)]
    	[DisplayName(AtributClass.ShemaStPolje.AritmetickiOperator.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.AritmetickiOperator.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.AritmetickiOperator.Sortable)]
    	public string AritmetickiOperator { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.Operand.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.Operand.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ShemaStPolje.Operand.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.Operand.Sortable)]
    	public decimal Operand { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.Negativno.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.Negativno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.ShemaStPolje.Negativno.Sortable)]
    	public bool Negativno { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ShemaStPoljeGridFormattedBase()
        { }
    	
    	public ShemaStPoljeGridFormattedBase(Model.Data.ShemaStPolje gridformated)
    	{
    	    this.ID_ShemaStPolje = gridformated.ID_ShemaStPolje;
    	    this.ID_ShemaSt = gridformated.ID_ShemaSt;
    	    this.TablicaShema = gridformated.TablicaShema;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	    this.TablicaPoljeNaziv = gridformated.TablicaPoljeNaziv;
    	    this.AritmetickiOperator = gridformated.AritmetickiOperator;
    	    this.Operand = gridformated.Operand;
    	    this.Negativno = gridformated.Negativno;
    	}
    
    	/*
    	    mymodel.ID_ShemaStPolje = model.ID_ShemaStPolje;
    	    mymodel.ID_ShemaSt = model.ID_ShemaSt;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.TablicaPoljeNaziv = model.TablicaPoljeNaziv;
    	    mymodel.AritmetickiOperator = model.AritmetickiOperator;
    	    mymodel.Operand = model.Operand;
    	    mymodel.Negativno = model.Negativno;
    		
    	*/
    
    		#endregion
    }
}