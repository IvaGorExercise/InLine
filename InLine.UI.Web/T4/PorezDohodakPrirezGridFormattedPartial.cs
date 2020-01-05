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
    
    
    public partial class PorezDohodakPrirezGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PorezDohodakPrirez.ID_PorezDohodakPrirez.Required)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.ID_PorezDohodakPrirez.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.ID_PorezDohodakPrirez.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.ID_PorezDohodakPrirez.Sortable)]
    	public long ID_PorezDohodakPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.PorezDohodakPrirez.ID_Opcina.Required)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.ID_Opcina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.ID_Opcina.Sortable)]
    	public long ID_Opcina { get; set; }
    
    	[DisplayName(AtributClass.PorezDohodakPrirez.ID_Davanje.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.ID_Davanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.ID_Davanje.Sortable)]
    	public Nullable<long> ID_Davanje { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PorezDohodakPrirez.DatumOd.Required)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.PorezDohodakPrirez.Stopa.Required)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.Stopa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.Stopa.Sortable)]
    	public decimal Stopa { get; set; }
    
    	[DisplayName(AtributClass.PorezDohodakPrirez.NNGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.NNGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.NNGodina.Sortable)]
    	public Nullable<int> NNGodina { get; set; }
    
    	[DisplayName(AtributClass.PorezDohodakPrirez.NNBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.NNBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.NNBroj.Sortable)]
    	public Nullable<int> NNBroj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.PorezDohodakPrirez.NNDatum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PorezDohodakPrirez.NNDatum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PorezDohodakPrirez.NNDatum.Sortable)]
    	public Nullable<System.DateTime> NNDatum { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PorezDohodakPrirezGridFormattedBase()
        { }
    	
    	public PorezDohodakPrirezGridFormattedBase(Model.Data.PorezDohodakPrirez gridformated)
    	{
    	    this.ID_PorezDohodakPrirez = gridformated.ID_PorezDohodakPrirez;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.ID_Davanje = gridformated.ID_Davanje;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.Stopa = gridformated.Stopa;
    	    this.NNGodina = gridformated.NNGodina;
    	    this.NNBroj = gridformated.NNBroj;
    	    this.NNDatum = gridformated.NNDatum;
    	}
    
    	/*
    	    mymodel.ID_PorezDohodakPrirez = model.ID_PorezDohodakPrirez;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.Stopa = model.Stopa;
    	    mymodel.NNGodina = model.NNGodina;
    	    mymodel.NNBroj = model.NNBroj;
    	    mymodel.NNDatum = model.NNDatum;
    		
    	*/
    
    		#endregion
    }
}