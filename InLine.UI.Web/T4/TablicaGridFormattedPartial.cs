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
    
    
    public partial class TablicaGridFormattedBase
    {
    	#region Properities
    	
        [StringLength(128, ErrorMessage = AtributClass.Tablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.Tablica.TablicaShema.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.TablicaShema.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.TablicaShema.Sortable)]
    	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.Tablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.Tablica.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Tablica.Tip.StringLength)]
    	[DisplayName(AtributClass.Tablica.Tip.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Tip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Tip.Sortable)]
    	public string Tip { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Tablica.Labela.StringLength)]
    	[DisplayName(AtributClass.Tablica.Labela.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Labela.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Labela.Sortable)]
    	public string Labela { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Tablica.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.Oznaka.Required)]
    	[DisplayName(AtributClass.Tablica.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Tablica.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.Naziv.Required)]
    	[DisplayName(AtributClass.Tablica.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Tablica.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.NazivKr.Required)]
    	[DisplayName(AtributClass.Tablica.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Tablica.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.Kratica.Required)]
    	[DisplayName(AtributClass.Tablica.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(2000, ErrorMessage = AtributClass.Tablica.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.Tablica.Opis.Required)]
    	[DisplayName(AtributClass.Tablica.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Tablica.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Tablica.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TablicaGridFormattedBase()
        { }
    	
    	public TablicaGridFormattedBase(Model.Data.Tablica gridformated)
    	{
    	    this.TablicaShema = gridformated.TablicaShema;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	    this.Tip = gridformated.Tip;
    	    this.Labela = gridformated.Labela;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.Tip = model.Tip;
    	    mymodel.Labela = model.Labela;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}