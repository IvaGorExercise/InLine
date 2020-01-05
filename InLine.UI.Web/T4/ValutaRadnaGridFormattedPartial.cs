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
    
    
    public partial class ValutaRadnaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ValutaRadna.ID_Valuta.Required)]
    	[DisplayName(AtributClass.ValutaRadna.ID_Valuta.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.ID_Valuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.ID_Valuta.Sortable)]
    	public long ID_Valuta { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ValutaRadna.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ValutaRadna.Oznaka.Required)]
    	[DisplayName(AtributClass.ValutaRadna.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ValutaRadna.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ValutaRadna.Naziv.Required)]
    	[DisplayName(AtributClass.ValutaRadna.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ValutaRadna.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ValutaRadna.NazivKr.Required)]
    	[DisplayName(AtributClass.ValutaRadna.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ValutaRadna.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ValutaRadna.Kratica.Required)]
    	[DisplayName(AtributClass.ValutaRadna.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ValutaRadna.Kratica2.StringLength)]
    	[DisplayName(AtributClass.ValutaRadna.Kratica2.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Kratica2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Kratica2.Sortable)]
    	public string Kratica2 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ValutaRadna.Kod.Required)]
    	[DisplayName(AtributClass.ValutaRadna.Kod.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Kod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Kod.Sortable)]
    	public int Kod { get; set; }
    
        [Required(ErrorMessage = AtributClass.ValutaRadna.Decimale.Required)]
    	[DisplayName(AtributClass.ValutaRadna.Decimale.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.Decimale.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.Decimale.Sortable)]
    	public int Decimale { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ValutaRadna.NazivDio.StringLength)]
        [Required(ErrorMessage = AtributClass.ValutaRadna.NazivDio.Required)]
    	[DisplayName(AtributClass.ValutaRadna.NazivDio.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ValutaRadna.NazivDio.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ValutaRadna.NazivDio.Sortable)]
    	public string NazivDio { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ValutaRadnaGridFormattedBase()
        { }
    	
    	public ValutaRadnaGridFormattedBase(Model.Data.ValutaRadna gridformated)
    	{
    	    this.ID_Valuta = gridformated.ID_Valuta;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Kratica2 = gridformated.Kratica2;
    	    this.Kod = gridformated.Kod;
    	    this.Decimale = gridformated.Decimale;
    	    this.NazivDio = gridformated.NazivDio;
    	}
    
    	/*
    	    mymodel.ID_Valuta = model.ID_Valuta;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Kratica2 = model.Kratica2;
    	    mymodel.Kod = model.Kod;
    	    mymodel.Decimale = model.Decimale;
    	    mymodel.NazivDio = model.NazivDio;
    		
    	*/
    
    		#endregion
    }
}
