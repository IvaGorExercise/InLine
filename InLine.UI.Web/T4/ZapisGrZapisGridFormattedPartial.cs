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
    
    
    public partial class ZapisGrZapisGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZapisGrZapis.ID_ZapisGrZapis.Required)]
    	[DisplayName(AtributClass.ZapisGrZapis.ID_ZapisGrZapis.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisGrZapis.ID_ZapisGrZapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisGrZapis.ID_ZapisGrZapis.Sortable)]
    	public long ID_ZapisGrZapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisGrZapis.ID_ZapisGr.Required)]
    	[DisplayName(AtributClass.ZapisGrZapis.ID_ZapisGr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisGrZapis.ID_ZapisGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisGrZapis.ID_ZapisGr.Sortable)]
    	public long ID_ZapisGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisGrZapis.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisGrZapis.ID_Zapis.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisGrZapis.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisGrZapis.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisGrZapisGridFormattedBase()
        { }
    	
    	public ZapisGrZapisGridFormattedBase(Model.Data.ZapisGrZapis gridformated)
    	{
    	    this.ID_ZapisGrZapis = gridformated.ID_ZapisGrZapis;
    	    this.ID_ZapisGr = gridformated.ID_ZapisGr;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	}
    
    	/*
    	    mymodel.ID_ZapisGrZapis = model.ID_ZapisGrZapis;
    	    mymodel.ID_ZapisGr = model.ID_ZapisGr;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    		
    	*/
    
    		#endregion
    }
}
