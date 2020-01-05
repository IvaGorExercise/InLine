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
    
    
    public partial class IzvodTemeljnicaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.Sortable)]
    	public long ID_IzvodTemeljnica { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_Izvod.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.ID_Izvod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.ID_Izvod.Sortable)]
    	public Nullable<long> ID_Izvod { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.IznosDuguje.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.IznosDuguje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.IznosDuguje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.IznosDuguje.Sortable)]
    	public decimal IznosDuguje { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.IznosPotrazuje.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.IznosPotrazuje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.IznosPotrazuje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.IznosPotrazuje.Sortable)]
    	public decimal IznosPotrazuje { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.SaldoStaro.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.SaldoStaro.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.SaldoStaro.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.SaldoStaro.Sortable)]
    	public decimal SaldoStaro { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.SaldoNovo.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.SaldoNovo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.SaldoNovo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.SaldoNovo.Sortable)]
    	public decimal SaldoNovo { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.IzvodTemeljnica.TemeljnicaStatus.StringLength)]
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaStatus.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.TemeljnicaStatus.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.TemeljnicaStatus.Sortable)]
    	public string TemeljnicaStatus { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.TemeljnicaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.TemeljnicaGodina.Sortable)]
    	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaVrsta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.TemeljnicaVrsta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.TemeljnicaVrsta.Sortable)]
    	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.TemeljnicaBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.TemeljnicaBroj.Sortable)]
    	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_Temeljnica.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodTemeljnica.ID_Temeljnica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodTemeljnica.ID_Temeljnica.Sortable)]
    	public Nullable<long> ID_Temeljnica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public IzvodTemeljnicaGridFormattedBase()
        { }
    	
    	public IzvodTemeljnicaGridFormattedBase(Model.Data.IzvodTemeljnica gridformated)
    	{
    	    this.ID_IzvodTemeljnica = gridformated.ID_IzvodTemeljnica;
    	    this.ID_Izvod = gridformated.ID_Izvod;
    	    this.IznosDuguje = gridformated.IznosDuguje;
    	    this.IznosPotrazuje = gridformated.IznosPotrazuje;
    	    this.SaldoStaro = gridformated.SaldoStaro;
    	    this.SaldoNovo = gridformated.SaldoNovo;
    	    this.TemeljnicaStatus = gridformated.TemeljnicaStatus;
    	    this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
    	    this.ID_Temeljnica = gridformated.ID_Temeljnica;
    	}
    
    	/*
    	    mymodel.ID_IzvodTemeljnica = model.ID_IzvodTemeljnica;
    	    mymodel.ID_Izvod = model.ID_Izvod;
    	    mymodel.IznosDuguje = model.IznosDuguje;
    	    mymodel.IznosPotrazuje = model.IznosPotrazuje;
    	    mymodel.SaldoStaro = model.SaldoStaro;
    	    mymodel.SaldoNovo = model.SaldoNovo;
    	    mymodel.TemeljnicaStatus = model.TemeljnicaStatus;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    		
    	*/
    
    		#endregion
    }
}
