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
    
    
    public partial class PoduzeceGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Poduzece.ID_Poduzece.Required)]
    	[DisplayName(AtributClass.Poduzece.ID_Poduzece.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.ID_Poduzece.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.ID_Poduzece.Sortable)]
    	public long ID_Poduzece { get; set; }
    
    	[DisplayName(AtributClass.Poduzece.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Poduzece.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Poduzece.Oznaka.Required)]
    	[DisplayName(AtributClass.Poduzece.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Poduzece.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Poduzece.Naziv.Required)]
    	[DisplayName(AtributClass.Poduzece.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Poduzece.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Poduzece.NazivKr.Required)]
    	[DisplayName(AtributClass.Poduzece.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Poduzece.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Poduzece.Kratica.Required)]
    	[DisplayName(AtributClass.Poduzece.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.Poduzece.IDDrzava.StringLength)]
    	[DisplayName(AtributClass.Poduzece.IDDrzava.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.IDDrzava.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.IDDrzava.Sortable)]
    	public string IDDrzava { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Poduzece.OIB.StringLength)]
    	[DisplayName(AtributClass.Poduzece.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Poduzece.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Poduzece.OIB.Sortable)]
    	public string OIB { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PoduzeceGridFormattedBase()
        { }
    	
    	public PoduzeceGridFormattedBase(Model.Data.Poduzece gridformated)
    	{
    	    this.ID_Poduzece = gridformated.ID_Poduzece;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.IDDrzava = gridformated.IDDrzava;
    	    this.OIB = gridformated.OIB;
    	}
    
    	/*
    	    mymodel.ID_Poduzece = model.ID_Poduzece;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.IDDrzava = model.IDDrzava;
    	    mymodel.OIB = model.OIB;
    		
    	*/
    
    		#endregion
    }
}
