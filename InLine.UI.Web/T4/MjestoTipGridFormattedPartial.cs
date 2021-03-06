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
    
    
    public partial class MjestoTipGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.MjestoTip.ID_MjestoTip.Required)]
    	[DisplayName(AtributClass.MjestoTip.ID_MjestoTip.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.ID_MjestoTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.ID_MjestoTip.Sortable)]
    	public long ID_MjestoTip { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjestoTip.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoTip.Oznaka.Required)]
    	[DisplayName(AtributClass.MjestoTip.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoTip.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoTip.Naziv.Required)]
    	[DisplayName(AtributClass.MjestoTip.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MjestoTip.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoTip.NazivKr.Required)]
    	[DisplayName(AtributClass.MjestoTip.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MjestoTip.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoTip.Kratica.Required)]
    	[DisplayName(AtributClass.MjestoTip.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoTip.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoTip.Opis.Required)]
    	[DisplayName(AtributClass.MjestoTip.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.MjestoTip.StsMjestoTip.StringLength)]
    	[DisplayName(AtributClass.MjestoTip.StsMjestoTip.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoTip.StsMjestoTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoTip.StsMjestoTip.Sortable)]
    	public string StsMjestoTip { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public MjestoTipGridFormattedBase()
        { }
    	
    	public MjestoTipGridFormattedBase(Model.Data.MjestoTip gridformated)
    	{
    	    this.ID_MjestoTip = gridformated.ID_MjestoTip;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	    this.StsMjestoTip = gridformated.StsMjestoTip;
    	}
    
    	/*
    	    mymodel.ID_MjestoTip = model.ID_MjestoTip;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.StsMjestoTip = model.StsMjestoTip;
    		
    	*/
    
    		#endregion
    }
}
