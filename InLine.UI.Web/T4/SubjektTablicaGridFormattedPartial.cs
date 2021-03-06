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
    
    
    public partial class SubjektTablicaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.SubjektTablica.IDSubjektTablica.Required)]
    	[DisplayName(AtributClass.SubjektTablica.IDSubjektTablica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.SubjektTablica.IDSubjektTablica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektTablica.IDSubjektTablica.Sortable)]
    	public int IDSubjektTablica { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.SubjektTablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektTablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.SubjektTablica.TablicaShema.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektTablica.TablicaShema.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektTablica.TablicaShema.Sortable)]
    	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.SubjektTablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektTablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.SubjektTablica.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.SubjektTablica.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.SubjektTablica.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public SubjektTablicaGridFormattedBase()
        { }
    	
    	public SubjektTablicaGridFormattedBase(Model.Data.SubjektTablica gridformated)
    	{
    	    this.IDSubjektTablica = gridformated.IDSubjektTablica;
    	    this.TablicaShema = gridformated.TablicaShema;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	}
    
    	/*
    	    mymodel.IDSubjektTablica = model.IDSubjektTablica;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    		
    	*/
    
    		#endregion
    }
}
