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
    
    
    public partial class TecajGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Tecaj.ID_Tecaj.Required)]
    	[DisplayName(AtributClass.Tecaj.ID_Tecaj.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Tecaj.ID_Tecaj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tecaj.ID_Tecaj.Sortable)]
    	public long ID_Tecaj { get; set; }
    
        [Required(ErrorMessage = AtributClass.Tecaj.ID_TecajListaSt.Required)]
    	[DisplayName(AtributClass.Tecaj.ID_TecajListaSt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Tecaj.ID_TecajListaSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tecaj.ID_TecajListaSt.Sortable)]
    	public long ID_TecajListaSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.Tecaj.ID_TecajVr.Required)]
    	[DisplayName(AtributClass.Tecaj.ID_TecajVr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Tecaj.ID_TecajVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tecaj.ID_TecajVr.Sortable)]
    	public long ID_TecajVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.Tecaj.Tecaj6.Required)]
    	[DisplayName(AtributClass.Tecaj.Tecaj6.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Tecaj.Tecaj6.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tecaj.Tecaj6.Sortable)]
    	public decimal Tecaj6 { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TecajGridFormattedBase()
        { }
    	
    	public TecajGridFormattedBase(Model.Data.Tecaj gridformated)
    	{
    	    this.ID_Tecaj = gridformated.ID_Tecaj;
    	    this.ID_TecajListaSt = gridformated.ID_TecajListaSt;
    	    this.ID_TecajVr = gridformated.ID_TecajVr;
    	    this.Tecaj6 = gridformated.Tecaj6;
    	}
    
    	/*
    	    mymodel.ID_Tecaj = model.ID_Tecaj;
    	    mymodel.ID_TecajListaSt = model.ID_TecajListaSt;
    	    mymodel.ID_TecajVr = model.ID_TecajVr;
    	    mymodel.Tecaj6 = model.Tecaj6;
    		
    	*/
    
    		#endregion
    }
}