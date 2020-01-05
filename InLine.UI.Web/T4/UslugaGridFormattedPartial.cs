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
    
    
    public partial class UslugaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Usluga.ID_Usluga.Required)]
    	[DisplayName(AtributClass.Usluga.ID_Usluga.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Usluga.ID_Usluga.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.ID_Usluga.Sortable)]
    	public long ID_Usluga { get; set; }
    
    	[DisplayName(AtributClass.Usluga.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Usluga.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Usluga.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Oznaka.Required)]
    	[DisplayName(AtributClass.Usluga.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Usluga.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Usluga.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Naziv.Required)]
    	[DisplayName(AtributClass.Usluga.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Usluga.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Usluga.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.NazivKr.Required)]
    	[DisplayName(AtributClass.Usluga.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Usluga.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Usluga.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Kratica.Required)]
    	[DisplayName(AtributClass.Usluga.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Usluga.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Usluga.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UslugaGridFormattedBase()
        { }
    	
    	public UslugaGridFormattedBase(Model.Data.Usluga gridformated)
    	{
    	    this.ID_Usluga = gridformated.ID_Usluga;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_Usluga = model.ID_Usluga;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}