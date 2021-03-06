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
    
    
    public partial class ObrazacID1GridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacID1.ID_ObrazacID1.Required)]
    	[DisplayName(AtributClass.ObrazacID1.ID_ObrazacID1.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.ID_ObrazacID1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.ID_ObrazacID1.Sortable)]
    	public long ID_ObrazacID1 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID1.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ObrazacID1.ID_Zapis.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID1.ID_DohodakIsplatitelj.Required)]
    	[DisplayName(AtributClass.ObrazacID1.ID_DohodakIsplatitelj.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.ID_DohodakIsplatitelj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.ID_DohodakIsplatitelj.Sortable)]
    	public long ID_DohodakIsplatitelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID1.Godina.Required)]
    	[DisplayName(AtributClass.ObrazacID1.Godina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.Godina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.Godina.Sortable)]
    	public int Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacID1.IDObrazacID1Verzija.Required)]
    	[DisplayName(AtributClass.ObrazacID1.IDObrazacID1Verzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.IDObrazacID1Verzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.IDObrazacID1Verzija.Sortable)]
    	public int IDObrazacID1Verzija { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObrazacID1.DatotekaNaziv.StringLength)]
    	[DisplayName(AtributClass.ObrazacID1.DatotekaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.DatotekaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.DatotekaNaziv.Sortable)]
    	public string DatotekaNaziv { get; set; }
    
    	[DisplayName(AtributClass.ObrazacID1.Datoteka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacID1.Datoteka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacID1.Datoteka.Sortable)]
    	public string Datoteka { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacID1GridFormattedBase()
        { }
    	
    	public ObrazacID1GridFormattedBase(Model.Data.ObrazacID1 gridformated)
    	{
    	    this.ID_ObrazacID1 = gridformated.ID_ObrazacID1;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.ID_DohodakIsplatitelj = gridformated.ID_DohodakIsplatitelj;
    	    this.Godina = gridformated.Godina;
    	    this.IDObrazacID1Verzija = gridformated.IDObrazacID1Verzija;
    	    this.DatotekaNaziv = gridformated.DatotekaNaziv;
    	    this.Datoteka = gridformated.Datoteka;
    	}
    
    	/*
    	    mymodel.ID_ObrazacID1 = model.ID_ObrazacID1;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_DohodakIsplatitelj = model.ID_DohodakIsplatitelj;
    	    mymodel.Godina = model.Godina;
    	    mymodel.IDObrazacID1Verzija = model.IDObrazacID1Verzija;
    	    mymodel.DatotekaNaziv = model.DatotekaNaziv;
    	    mymodel.Datoteka = model.Datoteka;
    		
    	*/
    
    		#endregion
    }
}
