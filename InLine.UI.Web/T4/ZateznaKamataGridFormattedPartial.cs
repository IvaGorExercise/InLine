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
    
    
    public partial class ZateznaKamataGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZateznaKamata.ID_ZateznaKamata.Required)]
    	[DisplayName(AtributClass.ZateznaKamata.ID_ZateznaKamata.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZateznaKamata.ID_ZateznaKamata.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZateznaKamata.ID_ZateznaKamata.Sortable)]
    	public long ID_ZateznaKamata { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ZateznaKamata.DatumOd.Required)]
    	[DisplayName(AtributClass.ZateznaKamata.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZateznaKamata.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZateznaKamata.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZateznaKamata.Stopa.Required)]
    	[DisplayName(AtributClass.ZateznaKamata.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZateznaKamata.Stopa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZateznaKamata.Stopa.Sortable)]
    	public decimal Stopa { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZateznaKamataGridFormattedBase()
        { }
    	
    	public ZateznaKamataGridFormattedBase(Model.Data.ZateznaKamata gridformated)
    	{
    	    this.ID_ZateznaKamata = gridformated.ID_ZateznaKamata;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.Stopa = gridformated.Stopa;
    	}
    
    	/*
    	    mymodel.ID_ZateznaKamata = model.ID_ZateznaKamata;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.Stopa = model.Stopa;
    		
    	*/
    
    		#endregion
    }
}
