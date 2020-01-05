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
    
    
    public partial class DatotekaVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DatotekaVr.ID_DatotekaVr.Required)]
    	[DisplayName(AtributClass.DatotekaVr.ID_DatotekaVr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DatotekaVr.ID_DatotekaVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaVr.ID_DatotekaVr.Sortable)]
    	public long ID_DatotekaVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DatotekaVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DatotekaVr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaVr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaVr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DatotekaVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaVr.Naziv.Required)]
    	[DisplayName(AtributClass.DatotekaVr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaVr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaVr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DatotekaVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DatotekaVr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaVr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaVr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DatotekaVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DatotekaVr.Kratica.Required)]
    	[DisplayName(AtributClass.DatotekaVr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DatotekaVr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DatotekaVr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DatotekaVrGridFormattedBase()
        { }
    	
    	public DatotekaVrGridFormattedBase(Model.Data.DatotekaVr gridformated)
    	{
    	    this.ID_DatotekaVr = gridformated.ID_DatotekaVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_DatotekaVr = model.ID_DatotekaVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
