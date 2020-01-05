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
    
    
    public partial class TablicaPoljeUIGridFormattedBase
    {
    	#region Properities
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPoljeUI.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPoljeUI.TablicaShema.Required)]
    	[DisplayName(AtributClass.TablicaPoljeUI.TablicaShema.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TablicaPoljeUI.TablicaShema.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TablicaPoljeUI.TablicaShema.Sortable)]
    	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPoljeUI.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPoljeUI.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.TablicaPoljeUI.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TablicaPoljeUI.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TablicaPoljeUI.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPoljeUI.TablicaPoljeNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPoljeUI.TablicaPoljeNaziv.Required)]
    	[DisplayName(AtributClass.TablicaPoljeUI.TablicaPoljeNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TablicaPoljeUI.TablicaPoljeNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TablicaPoljeUI.TablicaPoljeNaziv.Sortable)]
    	public string TablicaPoljeNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.TablicaPoljeUI.Labela.StringLength)]
    	[DisplayName(AtributClass.TablicaPoljeUI.Labela.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TablicaPoljeUI.Labela.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TablicaPoljeUI.Labela.Sortable)]
    	public string Labela { get; set; }
    
    	
        [StringLength(2000, ErrorMessage = AtributClass.TablicaPoljeUI.Opis.StringLength)]
    	[DisplayName(AtributClass.TablicaPoljeUI.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TablicaPoljeUI.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TablicaPoljeUI.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TablicaPoljeUIGridFormattedBase()
        { }
    	
    	public TablicaPoljeUIGridFormattedBase(Model.Data.TablicaPoljeUI gridformated)
    	{
    	    this.TablicaShema = gridformated.TablicaShema;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	    this.TablicaPoljeNaziv = gridformated.TablicaPoljeNaziv;
    	    this.Labela = gridformated.Labela;
    	    this.Opis = gridformated.Opis;
    	}
    
    	/*
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.TablicaPoljeNaziv = model.TablicaPoljeNaziv;
    	    mymodel.Labela = model.Labela;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    }
}
