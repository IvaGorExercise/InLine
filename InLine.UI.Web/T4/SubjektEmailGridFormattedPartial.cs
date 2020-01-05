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
    
    
    public partial class SubjektEmailGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.SubjektEmail.ID_SubjektEmail.Required)]
    	[DisplayName(AtributClass.SubjektEmail.ID_SubjektEmail.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektEmail.ID_SubjektEmail.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektEmail.ID_SubjektEmail.Sortable)]
    	public long ID_SubjektEmail { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektEmail.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.SubjektEmail.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektEmail.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektEmail.ID_Subjekt.Sortable)]
    	public long ID_Subjekt { get; set; }
    
    	
        [StringLength(400, ErrorMessage = AtributClass.SubjektEmail.URL.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektEmail.URL.Required)]
    	[DisplayName(AtributClass.SubjektEmail.URL.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektEmail.URL.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektEmail.URL.Sortable)]
    	public string URL { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektEmail.Opis.StringLength)]
    	[DisplayName(AtributClass.SubjektEmail.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektEmail.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektEmail.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public SubjektEmailGridFormattedBase()
        { }
    	
    	public SubjektEmailGridFormattedBase(Model.Data.SubjektEmail gridformated)
    	{
    	    this.ID_SubjektEmail = gridformated.ID_SubjektEmail;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.URL = gridformated.URL;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_SubjektEmail = model.ID_SubjektEmail;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.URL = model.URL;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}