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
    
    
    public partial class PDVGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PDV.ID_PDV.Required)]
    	[DisplayName(AtributClass.PDV.ID_PDV.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PDV.ID_PDV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.ID_PDV.Sortable)]
    	public long ID_PDV { get; set; }
    
        [Required(ErrorMessage = AtributClass.PDV.ID_PDVVr.Required)]
    	[DisplayName(AtributClass.PDV.ID_PDVVr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PDV.ID_PDVVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.ID_PDVVr.Sortable)]
    	public long ID_PDVVr { get; set; }
    
    	[DisplayName(AtributClass.PDV.ID_Davanje.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PDV.ID_Davanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.ID_Davanje.Sortable)]
    	public Nullable<long> ID_Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.PDV.Stopa.Required)]
    	[DisplayName(AtributClass.PDV.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PDV.Stopa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.Stopa.Sortable)]
    	public decimal Stopa { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PDV.DatumOd.Required)]
    	[DisplayName(AtributClass.PDV.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PDV.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.PDV.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PDV.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PDV.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PDVGridFormattedBase()
        { }
    	
    	public PDVGridFormattedBase(Model.Data.PDV gridformated)
    	{
    	    this.ID_PDV = gridformated.ID_PDV;
    	    this.ID_PDVVr = gridformated.ID_PDVVr;
    	    this.ID_Davanje = gridformated.ID_Davanje;
    	    this.Stopa = gridformated.Stopa;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	}
    
    	/*
    	    mymodel.ID_PDV = model.ID_PDV;
    	    mymodel.ID_PDVVr = model.ID_PDVVr;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.Stopa = model.Stopa;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    		
    	*/
    
    		#endregion
    }
}
