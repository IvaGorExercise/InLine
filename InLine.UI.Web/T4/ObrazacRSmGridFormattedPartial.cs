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
    
    
    public partial class ObrazacRSmGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacRSm.ID_ObrazacRSm.Required)]
    	[DisplayName(AtributClass.ObrazacRSm.ID_ObrazacRSm.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.ID_ObrazacRSm.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.ID_ObrazacRSm.Sortable)]
    	public long ID_ObrazacRSm { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSm.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ObrazacRSm.ID_Zapis.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSm.ID_Dohodak.Required)]
    	[DisplayName(AtributClass.ObrazacRSm.ID_Dohodak.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.ID_Dohodak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.ID_Dohodak.Sortable)]
    	public long ID_Dohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSm.IDObrazacRSmVerzija.Required)]
    	[DisplayName(AtributClass.ObrazacRSm.IDObrazacRSmVerzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.IDObrazacRSmVerzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.IDObrazacRSmVerzija.Sortable)]
    	public int IDObrazacRSmVerzija { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObrazacRSm.DatotekaNaziv.StringLength)]
    	[DisplayName(AtributClass.ObrazacRSm.DatotekaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.DatotekaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.DatotekaNaziv.Sortable)]
    	public string DatotekaNaziv { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSm.Datoteka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacRSm.Datoteka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacRSm.Datoteka.Sortable)]
    	public string Datoteka { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacRSmGridFormattedBase()
        { }
    	
    	public ObrazacRSmGridFormattedBase(Model.Data.ObrazacRSm gridformated)
    	{
    	    this.ID_ObrazacRSm = gridformated.ID_ObrazacRSm;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.ID_Dohodak = gridformated.ID_Dohodak;
    	    this.IDObrazacRSmVerzija = gridformated.IDObrazacRSmVerzija;
    	    this.DatotekaNaziv = gridformated.DatotekaNaziv;
    	    this.Datoteka = gridformated.Datoteka;
    	}
    
    	/*
    	    mymodel.ID_ObrazacRSm = model.ID_ObrazacRSm;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_Dohodak = model.ID_Dohodak;
    	    mymodel.IDObrazacRSmVerzija = model.IDObrazacRSmVerzija;
    	    mymodel.DatotekaNaziv = model.DatotekaNaziv;
    	    mymodel.Datoteka = model.Datoteka;
    		
    	*/
    
    		#endregion
    }
}