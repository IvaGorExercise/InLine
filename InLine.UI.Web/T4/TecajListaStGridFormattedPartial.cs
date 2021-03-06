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
    
    
    public partial class TecajListaStGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.TecajListaSt.ID_TecajListaSt.Required)]
    	[DisplayName(AtributClass.TecajListaSt.ID_TecajListaSt.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajListaSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajListaSt.Sortable)]
    	public long ID_TecajListaSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.TecajListaSt.ID_TecajLista.Required)]
    	[DisplayName(AtributClass.TecajListaSt.ID_TecajLista.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajLista.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajLista.Sortable)]
    	public long ID_TecajLista { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.TecajListaSt.IDDrzavaIz.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDDrzavaIz.Required)]
    	[DisplayName(AtributClass.TecajListaSt.IDDrzavaIz.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.IDDrzavaIz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDDrzavaIz.Sortable)]
    	public string IDDrzavaIz { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.TecajListaSt.IDDrzavaU.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDDrzavaU.Required)]
    	[DisplayName(AtributClass.TecajListaSt.IDDrzavaU.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.IDDrzavaU.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDDrzavaU.Sortable)]
    	public string IDDrzavaU { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TecajListaSt.IDValutaIz.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDValutaIz.Required)]
    	[DisplayName(AtributClass.TecajListaSt.IDValutaIz.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.IDValutaIz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDValutaIz.Sortable)]
    	public string IDValutaIz { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TecajListaSt.IDValutaU.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDValutaU.Required)]
    	[DisplayName(AtributClass.TecajListaSt.IDValutaU.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.IDValutaU.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDValutaU.Sortable)]
    	public string IDValutaU { get; set; }
    
        [Required(ErrorMessage = AtributClass.TecajListaSt.BrojJedinica.Required)]
    	[DisplayName(AtributClass.TecajListaSt.BrojJedinica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TecajListaSt.BrojJedinica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.BrojJedinica.Sortable)]
    	public int BrojJedinica { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TecajListaStGridFormattedBase()
        { }
    	
    	public TecajListaStGridFormattedBase(Model.Data.TecajListaSt gridformated)
    	{
    	    this.ID_TecajListaSt = gridformated.ID_TecajListaSt;
    	    this.ID_TecajLista = gridformated.ID_TecajLista;
    	    this.IDDrzavaIz = gridformated.IDDrzavaIz;
    	    this.IDDrzavaU = gridformated.IDDrzavaU;
    	    this.IDValutaIz = gridformated.IDValutaIz;
    	    this.IDValutaU = gridformated.IDValutaU;
    	    this.BrojJedinica = gridformated.BrojJedinica;
    	}
    
    	/*
    	    mymodel.ID_TecajListaSt = model.ID_TecajListaSt;
    	    mymodel.ID_TecajLista = model.ID_TecajLista;
    	    mymodel.IDDrzavaIz = model.IDDrzavaIz;
    	    mymodel.IDDrzavaU = model.IDDrzavaU;
    	    mymodel.IDValutaIz = model.IDValutaIz;
    	    mymodel.IDValutaU = model.IDValutaU;
    	    mymodel.BrojJedinica = model.BrojJedinica;
    		
    	*/
    
    		#endregion
    }
}
