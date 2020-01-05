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
    
    
    public partial class DohodakPrimateljPrimitakDavanjeGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitakDavanje.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitakDavanje.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitakDavanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitakDavanje.Sortable)]
    	public long ID_DohodakPrimateljPrimitakDavanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitak.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitak.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljPrimitakDavanje.ID_DohodakPrimateljPrimitak.Sortable)]
    	public long ID_DohodakPrimateljPrimitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitakDavanje.ID_Davanje.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitakDavanje.ID_Davanje.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljPrimitakDavanje.ID_Davanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljPrimitakDavanje.ID_Davanje.Sortable)]
    	public long ID_Davanje { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DohodakPrimateljPrimitakDavanjeGridFormattedBase()
        { }
    	
    	public DohodakPrimateljPrimitakDavanjeGridFormattedBase(Model.Data.DohodakPrimateljPrimitakDavanje gridformated)
    	{
    	    this.ID_DohodakPrimateljPrimitakDavanje = gridformated.ID_DohodakPrimateljPrimitakDavanje;
    	    this.ID_DohodakPrimateljPrimitak = gridformated.ID_DohodakPrimateljPrimitak;
    	    this.ID_Davanje = gridformated.ID_Davanje;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljPrimitakDavanje = model.ID_DohodakPrimateljPrimitakDavanje;
    	    mymodel.ID_DohodakPrimateljPrimitak = model.ID_DohodakPrimateljPrimitak;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    		
    	*/
    
    		#endregion
    }
}