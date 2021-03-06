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
    
    
    public partial class PraznikGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Praznik.ID_Praznik.Required)]
    	[DisplayName(AtributClass.Praznik.ID_Praznik.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Praznik.ID_Praznik.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Praznik.ID_Praznik.Sortable)]
    	public long ID_Praznik { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Praznik.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Praznik.Oznaka.Required)]
    	[DisplayName(AtributClass.Praznik.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Praznik.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Praznik.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Praznik.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Praznik.Naziv.Required)]
    	[DisplayName(AtributClass.Praznik.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Praznik.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Praznik.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PraznikGridFormattedBase()
        { }
    	
    	public PraznikGridFormattedBase(Model.Data.Praznik gridformated)
    	{
    	    this.ID_Praznik = gridformated.ID_Praznik;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	}
    
    	/*
    	    mymodel.ID_Praznik = model.ID_Praznik;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    }
}
