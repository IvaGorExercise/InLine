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
    
    
    public partial class ZapisVrTablicaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZapisVrTablica.IDZapisVr.Required)]
    	[DisplayName(AtributClass.ZapisVrTablica.IDZapisVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrTablica.IDZapisVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrTablica.IDZapisVr.Sortable)]
    	public int IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisVrTablica.IDZapisTablica.Required)]
    	[DisplayName(AtributClass.ZapisVrTablica.IDZapisTablica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisVrTablica.IDZapisTablica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrTablica.IDZapisTablica.Sortable)]
    	public int IDZapisTablica { get; set; }
    
    	[DisplayName(AtributClass.ZapisVrTablica.Odabir.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrTablica.Odabir.Sortable)]
    	public Nullable<bool> Odabir { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisVrTablica.Analitika.Required)]
    	[DisplayName(AtributClass.ZapisVrTablica.Analitika.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisVrTablica.Analitika.Sortable)]
    	public bool Analitika { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisVrTablicaGridFormattedBase()
        { }
    	
    	public ZapisVrTablicaGridFormattedBase(Model.Data.ZapisVrTablica gridformated)
    	{
    	    this.IDZapisVr = gridformated.IDZapisVr;
    	    this.IDZapisTablica = gridformated.IDZapisTablica;
    	    this.Odabir = gridformated.Odabir;
    	    this.Analitika = gridformated.Analitika;
    	}
    
    	/*
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.IDZapisTablica = model.IDZapisTablica;
    	    mymodel.Odabir = model.Odabir;
    	    mymodel.Analitika = model.Analitika;
    		
    	*/
    
    		#endregion
    }
}
