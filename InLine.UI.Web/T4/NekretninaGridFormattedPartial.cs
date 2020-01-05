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
    
    
    public partial class NekretninaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Nekretnina.ID_Nekretnina.Required)]
    	[DisplayName(AtributClass.Nekretnina.ID_Nekretnina.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.ID_Nekretnina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.ID_Nekretnina.Sortable)]
    	public long ID_Nekretnina { get; set; }
    
    	[DisplayName(AtributClass.Nekretnina.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Nekretnina.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Nekretnina.Oznaka.Required)]
    	[DisplayName(AtributClass.Nekretnina.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Nekretnina.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Nekretnina.Naziv.Required)]
    	[DisplayName(AtributClass.Nekretnina.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Nekretnina.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Nekretnina.NazivKr.Required)]
    	[DisplayName(AtributClass.Nekretnina.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Nekretnina.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Nekretnina.Kratica.Required)]
    	[DisplayName(AtributClass.Nekretnina.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Nekretnina.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Nekretnina.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public NekretninaGridFormattedBase()
        { }
    	
    	public NekretninaGridFormattedBase(Model.Data.Nekretnina gridformated)
    	{
    	    this.ID_Nekretnina = gridformated.ID_Nekretnina;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_Nekretnina = model.ID_Nekretnina;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
