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
    
    
    public partial class VoziloGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.Vozilo.ID_Vozilo.Required)]
    	[DisplayName(AtributClass.Vozilo.ID_Vozilo.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.ID_Vozilo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.ID_Vozilo.Sortable)]
    	public long ID_Vozilo { get; set; }
    
    	[DisplayName(AtributClass.Vozilo.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Vozilo.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Oznaka.Required)]
    	[DisplayName(AtributClass.Vozilo.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Vozilo.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Naziv.Required)]
    	[DisplayName(AtributClass.Vozilo.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Vozilo.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.NazivKr.Required)]
    	[DisplayName(AtributClass.Vozilo.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Vozilo.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Kratica.Required)]
    	[DisplayName(AtributClass.Vozilo.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Vozilo.Registracija.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Registracija.Required)]
    	[DisplayName(AtributClass.Vozilo.Registracija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Vozilo.Registracija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Vozilo.Registracija.Sortable)]
    	public string Registracija { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public VoziloGridFormattedBase()
        { }
    	
    	public VoziloGridFormattedBase(Model.Data.Vozilo gridformated)
    	{
    	    this.ID_Vozilo = gridformated.ID_Vozilo;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Registracija = gridformated.Registracija;
    	}
    
    	/*
    	    mymodel.ID_Vozilo = model.ID_Vozilo;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Registracija = model.Registracija;
    		
    	*/
    
    		#endregion
    }
}
