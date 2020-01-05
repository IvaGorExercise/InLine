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
    
    
    public partial class MjestoGrMjestoGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.ID_MjestoGrMjesto.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.ID_MjestoGrMjesto.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.ID_MjestoGrMjesto.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.ID_MjestoGrMjesto.Sortable)]
    	public long ID_MjestoGrMjesto { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.ID_MjestoGr.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.ID_MjestoGr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.ID_MjestoGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.ID_MjestoGr.Sortable)]
    	public long ID_MjestoGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.ID_Mjesto.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.ID_Mjesto.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.ID_Mjesto.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.ID_Mjesto.Sortable)]
    	public long ID_Mjesto { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjestoGrMjesto.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.Oznaka.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoGrMjesto.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.Naziv.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MjestoGrMjesto.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.NazivKr.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MjestoGrMjesto.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.Kratica.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoGrMjesto.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGrMjesto.Opis.Required)]
    	[DisplayName(AtributClass.MjestoGrMjesto.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoGrMjesto.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoGrMjesto.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public MjestoGrMjestoGridFormattedBase()
        { }
    	
    	public MjestoGrMjestoGridFormattedBase(Model.Data.MjestoGrMjesto gridformated)
    	{
    	    this.ID_MjestoGrMjesto = gridformated.ID_MjestoGrMjesto;
    	    this.ID_MjestoGr = gridformated.ID_MjestoGr;
    	    this.ID_Mjesto = gridformated.ID_Mjesto;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_MjestoGrMjesto = model.ID_MjestoGrMjesto;
    	    mymodel.ID_MjestoGr = model.ID_MjestoGr;
    	    mymodel.ID_Mjesto = model.ID_Mjesto;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}
