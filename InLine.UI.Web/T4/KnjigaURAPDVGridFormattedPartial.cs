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
    
    
    public partial class KnjigaURAPDVGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KnjigaURAPDV.ID_KnjigaURAPDV.Required)]
    	[DisplayName(AtributClass.KnjigaURAPDV.ID_KnjigaURAPDV.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaURAPDV.ID_KnjigaURAPDV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaURAPDV.ID_KnjigaURAPDV.Sortable)]
    	public long ID_KnjigaURAPDV { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaURAPDV.ID_KnjigaURA.Required)]
    	[DisplayName(AtributClass.KnjigaURAPDV.ID_KnjigaURA.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaURAPDV.ID_KnjigaURA.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaURAPDV.ID_KnjigaURA.Sortable)]
    	public long ID_KnjigaURA { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaURAPDV.ID_PDV.Required)]
    	[DisplayName(AtributClass.KnjigaURAPDV.ID_PDV.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaURAPDV.ID_PDV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaURAPDV.ID_PDV.Sortable)]
    	public long ID_PDV { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaURAPDV.IznosOsnova.Required)]
    	[DisplayName(AtributClass.KnjigaURAPDV.IznosOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaURAPDV.IznosOsnova.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaURAPDV.IznosOsnova.Sortable)]
    	public decimal IznosOsnova { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaURAPDV.Iznos.Required)]
    	[DisplayName(AtributClass.KnjigaURAPDV.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaURAPDV.Iznos.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaURAPDV.Iznos.Sortable)]
    	public decimal Iznos { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KnjigaURAPDVGridFormattedBase()
        { }
    	
    	public KnjigaURAPDVGridFormattedBase(Model.Data.KnjigaURAPDV gridformated)
    	{
    	    this.ID_KnjigaURAPDV = gridformated.ID_KnjigaURAPDV;
    	    this.ID_KnjigaURA = gridformated.ID_KnjigaURA;
    	    this.ID_PDV = gridformated.ID_PDV;
    	    this.IznosOsnova = gridformated.IznosOsnova;
    	    this.Iznos = gridformated.Iznos;
    	}
    
    	/*
    	    mymodel.ID_KnjigaURAPDV = model.ID_KnjigaURAPDV;
    	    mymodel.ID_KnjigaURA = model.ID_KnjigaURA;
    	    mymodel.ID_PDV = model.ID_PDV;
    	    mymodel.IznosOsnova = model.IznosOsnova;
    	    mymodel.Iznos = model.Iznos;
    		
    	*/
    
    		#endregion
    }
}
