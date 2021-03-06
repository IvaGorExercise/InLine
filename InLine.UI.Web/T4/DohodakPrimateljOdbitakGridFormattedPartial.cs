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
    
    
    public partial class DohodakPrimateljOdbitakGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimateljOdbitak.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimateljOdbitak.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimateljOdbitak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimateljOdbitak.Sortable)]
    	public long ID_DohodakPrimateljOdbitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimatelj.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimatelj.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimatelj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljOdbitak.ID_DohodakPrimatelj.Sortable)]
    	public long ID_DohodakPrimatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljOdbitak.ID_Odbitak.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljOdbitak.ID_Odbitak.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljOdbitak.ID_Odbitak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljOdbitak.ID_Odbitak.Sortable)]
    	public long ID_Odbitak { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DohodakPrimateljOdbitakGridFormattedBase()
        { }
    	
    	public DohodakPrimateljOdbitakGridFormattedBase(Model.Data.DohodakPrimateljOdbitak gridformated)
    	{
    	    this.ID_DohodakPrimateljOdbitak = gridformated.ID_DohodakPrimateljOdbitak;
    	    this.ID_DohodakPrimatelj = gridformated.ID_DohodakPrimatelj;
    	    this.ID_Odbitak = gridformated.ID_Odbitak;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljOdbitak = model.ID_DohodakPrimateljOdbitak;
    	    mymodel.ID_DohodakPrimatelj = model.ID_DohodakPrimatelj;
    	    mymodel.ID_Odbitak = model.ID_Odbitak;
    		
    	*/
    
    		#endregion
    }
}
