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
    
    
    public partial class RadnoMjestoGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.RadnoMjesto.ID_RadnoMjesto.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.ID_RadnoMjesto.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.ID_RadnoMjesto.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.ID_RadnoMjesto.Sortable)]
    	public long ID_RadnoMjesto { get; set; }
    
        [Required(ErrorMessage = AtributClass.RadnoMjesto.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.ID_PoslovniSubjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.ID_PoslovniSubjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.ID_PoslovniSubjekt.Sortable)]
    	public long ID_PoslovniSubjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.RadnoMjesto.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.RadnoMjesto.Oznaka.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.RadnoMjesto.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.RadnoMjesto.Naziv.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.RadnoMjesto.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.RadnoMjesto.NazivKr.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.RadnoMjesto.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.RadnoMjesto.Kratica.Required)]
    	[DisplayName(AtributClass.RadnoMjesto.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.RadnoMjesto.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.RadnoMjesto.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public RadnoMjestoGridFormattedBase()
        { }
    	
    	public RadnoMjestoGridFormattedBase(Model.Data.RadnoMjesto gridformated)
    	{
    	    this.ID_RadnoMjesto = gridformated.ID_RadnoMjesto;
    	    this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_RadnoMjesto = model.ID_RadnoMjesto;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    }
}
