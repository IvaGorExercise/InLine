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
    
    
    public partial class HUBVerzijaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.HUBVerzija.IDHUBVerzija.Required)]
    	[DisplayName(AtributClass.HUBVerzija.IDHUBVerzija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.IDHUBVerzija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.IDHUBVerzija.Sortable)]
    	public int IDHUBVerzija { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.HUBVerzija.DatumOd.Required)]
    	[DisplayName(AtributClass.HUBVerzija.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.HUBVerzija.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.Napomena.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.Napomena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.Napomena.Sortable)]
    	public string Napomena { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.OpisHTML.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.OpisHTML.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.OpisHTML.Sortable)]
    	public string OpisHTML { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.NapomenaHTML.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.HUBVerzija.NapomenaHTML.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.HUBVerzija.NapomenaHTML.Sortable)]
    	public string NapomenaHTML { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public HUBVerzijaGridFormattedBase()
        { }
    	
    	public HUBVerzijaGridFormattedBase(Model.Data.HUBVerzija gridformated)
    	{
    	    this.IDHUBVerzija = gridformated.IDHUBVerzija;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.Opis = gridformated.Opis;
    	    this.Napomena = gridformated.Napomena;
    	    this.OpisHTML = gridformated.OpisHTML;
    	    this.NapomenaHTML = gridformated.NapomenaHTML;
    	}
    
    	/*
    	    mymodel.IDHUBVerzija = model.IDHUBVerzija;
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
