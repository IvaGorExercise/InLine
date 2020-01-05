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
    
    
    public partial class PrimateljKoeficijentGrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.ID_PrimateljKoeficijentGr.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.ID_PrimateljKoeficijentGr.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.ID_PrimateljKoeficijentGr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.ID_PrimateljKoeficijentGr.Sortable)]
    	public long ID_PrimateljKoeficijentGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.ID_DohodakIsplatitelj.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.ID_DohodakIsplatitelj.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.ID_DohodakIsplatitelj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.ID_DohodakIsplatitelj.Sortable)]
    	public long ID_DohodakIsplatitelj { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PrimateljKoeficijentGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.Oznaka.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PrimateljKoeficijentGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.Naziv.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PrimateljKoeficijentGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.NazivKr.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PrimateljKoeficijentGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimateljKoeficijentGr.Kratica.Required)]
    	[DisplayName(AtributClass.PrimateljKoeficijentGr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PrimateljKoeficijentGr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PrimateljKoeficijentGr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PrimateljKoeficijentGrGridFormattedBase()
        { }
    	
    	public PrimateljKoeficijentGrGridFormattedBase(Model.Data.PrimateljKoeficijentGr gridformated)
    	{
    	    this.ID_PrimateljKoeficijentGr = gridformated.ID_PrimateljKoeficijentGr;
    	    this.ID_DohodakIsplatitelj = gridformated.ID_DohodakIsplatitelj;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_PrimateljKoeficijentGr = model.ID_PrimateljKoeficijentGr;
    	    mymodel.ID_DohodakIsplatitelj = model.ID_DohodakIsplatitelj;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}