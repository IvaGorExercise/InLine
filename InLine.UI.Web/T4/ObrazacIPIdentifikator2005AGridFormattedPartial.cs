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
    
    
    public partial class ObrazacIPIdentifikator2005AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.IDObrazacIPIdentifikator2005A.Required)]
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.IDObrazacIPIdentifikator2005A.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.IDObrazacIPIdentifikator2005A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.IDObrazacIPIdentifikator2005A.Sortable)]
    	public int IDObrazacIPIdentifikator2005A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Oznaka.Required)]
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(2000, ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Naziv.Required)]
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.NazivKr.Required)]
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIPIdentifikator2005A.Kratica.Required)]
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DisplayName(AtributClass.ObrazacIPIdentifikator2005A.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIPIdentifikator2005A.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIPIdentifikator2005A.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacIPIdentifikator2005AGridFormattedBase()
        { }
    	
    	public ObrazacIPIdentifikator2005AGridFormattedBase(Model.Data.ObrazacIPIdentifikator2005A gridformated)
    	{
    	    this.IDObrazacIPIdentifikator2005A = gridformated.IDObrazacIPIdentifikator2005A;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.IDObrazacIPIdentifikator2005A = model.IDObrazacIPIdentifikator2005A;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}
