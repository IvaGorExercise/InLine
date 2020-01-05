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
    
    
    public partial class ObjektVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObjektVr.IDObjektVr.Required)]
    	[DisplayName(AtributClass.ObjektVr.IDObjektVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObjektVr.IDObjektVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObjektVr.IDObjektVr.Sortable)]
    	public int IDObjektVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ObjektVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektVr.Oznaka.Required)]
    	[DisplayName(AtributClass.ObjektVr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObjektVr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObjektVr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObjektVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektVr.Naziv.Required)]
    	[DisplayName(AtributClass.ObjektVr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObjektVr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObjektVr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObjektVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektVr.NazivKr.Required)]
    	[DisplayName(AtributClass.ObjektVr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObjektVr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObjektVr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObjektVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektVr.Kratica.Required)]
    	[DisplayName(AtributClass.ObjektVr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObjektVr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObjektVr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObjektVrGridFormattedBase()
        { }
    	
    	public ObjektVrGridFormattedBase(Model.Data.ObjektVr gridformated)
    	{
    	    this.IDObjektVr = gridformated.IDObjektVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.IDObjektVr = model.IDObjektVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}