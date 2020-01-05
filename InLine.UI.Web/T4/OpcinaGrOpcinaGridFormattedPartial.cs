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
    
    
    public partial class OpcinaGrOpcinaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.Sortable)]
    	public long ID_OpcinaGrOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_OpcinaGr.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_OpcinaGr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.ID_OpcinaGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.ID_OpcinaGr.Sortable)]
    	public long ID_OpcinaGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_Opcina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.ID_Opcina.Sortable)]
    	public long ID_Opcina { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.OpcinaGrOpcina.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Oznaka.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrOpcina.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Naziv.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OpcinaGrOpcina.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.NazivKr.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OpcinaGrOpcina.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Kratica.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrOpcina.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Opis.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OpcinaGrOpcina.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OpcinaGrOpcina.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OpcinaGrOpcinaGridFormattedBase()
        { }
    	
    	public OpcinaGrOpcinaGridFormattedBase(Model.Data.OpcinaGrOpcina gridformated)
    	{
    	    this.ID_OpcinaGrOpcina = gridformated.ID_OpcinaGrOpcina;
    	    this.ID_OpcinaGr = gridformated.ID_OpcinaGr;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_OpcinaGrOpcina = model.ID_OpcinaGrOpcina;
    	    mymodel.ID_OpcinaGr = model.ID_OpcinaGr;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}
