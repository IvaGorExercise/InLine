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
    
    
    public partial class ObrazacIDIdentifikator2009AGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.IDObrazacIDIdentifikator2009A.Required)]
    	[DisplayName(AtributClass.ObrazacIDIdentifikator2009A.IDObrazacIDIdentifikator2009A.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIDIdentifikator2009A.IDObrazacIDIdentifikator2009A.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIDIdentifikator2009A.IDObrazacIDIdentifikator2009A.Sortable)]
    	public int IDObrazacIDIdentifikator2009A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Oznaka.Required)]
    	[DisplayName(AtributClass.ObrazacIDIdentifikator2009A.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIDIdentifikator2009A.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIDIdentifikator2009A.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(2000, ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Naziv.Required)]
    	[DisplayName(AtributClass.ObrazacIDIdentifikator2009A.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIDIdentifikator2009A.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIDIdentifikator2009A.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.NazivKr.Required)]
    	[DisplayName(AtributClass.ObrazacIDIdentifikator2009A.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIDIdentifikator2009A.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIDIdentifikator2009A.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDIdentifikator2009A.Kratica.Required)]
    	[DisplayName(AtributClass.ObrazacIDIdentifikator2009A.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacIDIdentifikator2009A.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacIDIdentifikator2009A.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacIDIdentifikator2009AGridFormattedBase()
        { }
    	
    	public ObrazacIDIdentifikator2009AGridFormattedBase(Model.Data.ObrazacIDIdentifikator2009A gridformated)
    	{
    	    this.IDObrazacIDIdentifikator2009A = gridformated.IDObrazacIDIdentifikator2009A;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDObrazacIDIdentifikator2009A = model.IDObrazacIDIdentifikator2009A;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
