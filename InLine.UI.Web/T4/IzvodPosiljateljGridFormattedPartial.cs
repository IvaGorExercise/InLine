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
    
    
    public partial class IzvodPosiljateljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.IzvodPosiljatelj.ID_IzvodPosiljatelj.Required)]
    	[DisplayName(AtributClass.IzvodPosiljatelj.ID_IzvodPosiljatelj.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodPosiljatelj.ID_IzvodPosiljatelj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodPosiljatelj.ID_IzvodPosiljatelj.Sortable)]
    	public long ID_IzvodPosiljatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodPosiljatelj.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.IzvodPosiljatelj.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.IzvodPosiljatelj.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.IzvodPosiljatelj.ID_Subjekt.Sortable)]
    	public long ID_Subjekt { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public IzvodPosiljateljGridFormattedBase()
        { }
    	
    	public IzvodPosiljateljGridFormattedBase(Model.Data.IzvodPosiljatelj gridformated)
    	{
    	    this.ID_IzvodPosiljatelj = gridformated.ID_IzvodPosiljatelj;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	}
    
    	/*
    	    mymodel.ID_IzvodPosiljatelj = model.ID_IzvodPosiljatelj;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    		
    	*/
    
    		#endregion
    }
}