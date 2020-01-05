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
    
    
    public partial class ZbrojniNalogVerzijaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzija.IDZbrojniNalogVerzija.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.IDZbrojniNalogVerzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.IDZbrojniNalogVerzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.IDZbrojniNalogVerzija.Sortable)]
    	public int IDZbrojniNalogVerzija { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzija.DatumOd.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.Napomena.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.Napomena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.Napomena.Sortable)]
    	public string Napomena { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.OpisHTML.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.OpisHTML.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.OpisHTML.Sortable)]
    	public string OpisHTML { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalogVerzija.NapomenaHTML.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZbrojniNalogVerzija.NapomenaHTML.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZbrojniNalogVerzija.NapomenaHTML.Sortable)]
    	public string NapomenaHTML { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZbrojniNalogVerzijaGridFormattedBase()
        { }
    	
    	public ZbrojniNalogVerzijaGridFormattedBase(Model.Data.ZbrojniNalogVerzija gridformated)
    	{
    	    this.IDZbrojniNalogVerzija = gridformated.IDZbrojniNalogVerzija;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.Opis = gridformated.Opis;
    	    this.Napomena = gridformated.Napomena;
    	    this.OpisHTML = gridformated.OpisHTML;
    	    this.NapomenaHTML = gridformated.NapomenaHTML;
    	}
    
    	/*
    	    mymodel.IDZbrojniNalogVerzija = model.IDZbrojniNalogVerzija;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.Opis = model.Opis;
    	    mymodel.Napomena = model.Napomena;
    	    mymodel.OpisHTML = model.OpisHTML;
    	    mymodel.NapomenaHTML = model.NapomenaHTML;
    		
    	*/
    
    		#endregion
    }
}
