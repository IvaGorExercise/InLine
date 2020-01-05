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
    
    
    public partial class DohodakPrimateljIsplataRacunGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.Sortable)]
    	public long ID_DohodakPrimateljIsplataRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.Sortable)]
    	public long ID_DohodakPrimatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.Sortable)]
    	public long ID_SubjektRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.Iznos.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DohodakPrimateljIsplataRacun.Iznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DohodakPrimateljIsplataRacun.Iznos.Sortable)]
    	public decimal Iznos { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DohodakPrimateljIsplataRacunGridFormattedBase()
        { }
    	
    	public DohodakPrimateljIsplataRacunGridFormattedBase(Model.Data.DohodakPrimateljIsplataRacun gridformated)
    	{
    	    this.ID_DohodakPrimateljIsplataRacun = gridformated.ID_DohodakPrimateljIsplataRacun;
    	    this.ID_DohodakPrimatelj = gridformated.ID_DohodakPrimatelj;
    	    this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
    	    this.Iznos = gridformated.Iznos;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljIsplataRacun = model.ID_DohodakPrimateljIsplataRacun;
    	    mymodel.ID_DohodakPrimatelj = model.ID_DohodakPrimatelj;
    	    mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    	    mymodel.Iznos = model.Iznos;
    		
    	*/
    
    		#endregion
    }
}
