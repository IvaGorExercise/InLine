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
    
    
    public partial class OdbitakGrOdbitakGrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrOdbitakGr.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrOdbitakGr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrOdbitakGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrOdbitakGr.Sortable)]
    	public long ID_OdbitakGrOdbitakGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGr.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGr.Sortable)]
    	public long ID_OdbitakGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrNad.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrNad.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrNad.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OdbitakGrOdbitakGr.ID_OdbitakGrNad.Sortable)]
    	public long ID_OdbitakGrNad { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OdbitakGrOdbitakGrGridFormattedBase()
        { }
    	
    	public OdbitakGrOdbitakGrGridFormattedBase(Model.Data.OdbitakGrOdbitakGr gridformated)
    	{
    	    this.ID_OdbitakGrOdbitakGr = gridformated.ID_OdbitakGrOdbitakGr;
    	    this.ID_OdbitakGr = gridformated.ID_OdbitakGr;
    	    this.ID_OdbitakGrNad = gridformated.ID_OdbitakGrNad;
    	}
    
    	/*
    	    mymodel.ID_OdbitakGrOdbitakGr = model.ID_OdbitakGrOdbitakGr;
    	    mymodel.ID_OdbitakGr = model.ID_OdbitakGr;
    	    mymodel.ID_OdbitakGrNad = model.ID_OdbitakGrNad;
    		
    	*/
    
    		#endregion
    }
}