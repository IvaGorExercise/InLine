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
    
    
    public partial class OpcinaOpcinaTipGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.ID_OpcinaOpcinaTip.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.ID_OpcinaOpcinaTip.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.ID_OpcinaOpcinaTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.ID_OpcinaOpcinaTip.Sortable)]
    	public long ID_OpcinaOpcinaTip { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.ID_Opcina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.ID_Opcina.Sortable)]
    	public long ID_Opcina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.DatOd.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.DatOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.DatOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.DatOd.Sortable)]
    	public System.DateTime DatOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.DatDo.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.DatDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.DatDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.DatDo.Sortable)]
    	public System.DateTime DatDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.AktivU.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.AktivU.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.AktivU.Sortable)]
    	public bool AktivU { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaOpcinaTip.ID_OpcinaTip.Required)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.ID_OpcinaTip.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.ID_OpcinaTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.ID_OpcinaTip.Sortable)]
    	public long ID_OpcinaTip { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaOpcinaTip.Opis.StringLength)]
    	[DisplayName(AtributClass.OpcinaOpcinaTip.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaOpcinaTip.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaOpcinaTip.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OpcinaOpcinaTipGridFormattedBase()
        { }
    	
    	public OpcinaOpcinaTipGridFormattedBase(Model.Data.OpcinaOpcinaTip gridformated)
    	{
    	    this.ID_OpcinaOpcinaTip = gridformated.ID_OpcinaOpcinaTip;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.DatOd = gridformated.DatOd;
    	    this.DatDo = gridformated.DatDo;
    	    this.AktivU = gridformated.AktivU;
    	    this.ID_OpcinaTip = gridformated.ID_OpcinaTip;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_OpcinaOpcinaTip = model.ID_OpcinaOpcinaTip;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.DatOd = model.DatOd;
    	    mymodel.DatDo = model.DatDo;
    	    mymodel.AktivU = model.AktivU;
    	    mymodel.ID_OpcinaTip = model.ID_OpcinaTip;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}
