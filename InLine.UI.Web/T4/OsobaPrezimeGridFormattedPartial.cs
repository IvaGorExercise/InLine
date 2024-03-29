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
    
    
    public partial class OsobaPrezimeGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OsobaPrezime.ID_OsobaPrezime.Required)]
    	[DisplayName(AtributClass.OsobaPrezime.ID_OsobaPrezime.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.ID_OsobaPrezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.ID_OsobaPrezime.Sortable)]
    	public long ID_OsobaPrezime { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaPrezime.ID_Osoba.Required)]
    	[DisplayName(AtributClass.OsobaPrezime.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.ID_Osoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.ID_Osoba.Sortable)]
    	public long ID_Osoba { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaPrezime.RedniBroj.Required)]
    	[DisplayName(AtributClass.OsobaPrezime.RedniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.RedniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.RedniBroj.Sortable)]
    	public int RedniBroj { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaPrezime.Aktivno.Required)]
    	[DisplayName(AtributClass.OsobaPrezime.Aktivno.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.Aktivno.Sortable)]
    	public bool Aktivno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaPrezime.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.DatumOd.Sortable)]
    	public Nullable<System.DateTime> DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaPrezime.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaPrezime.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.OsobaPrezime.Prezime.Required)]
    	[DisplayName(AtributClass.OsobaPrezime.Prezime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrezime.Prezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrezime.Prezime.Sortable)]
    	public string Prezime { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OsobaPrezimeGridFormattedBase()
        { }
    	
    	public OsobaPrezimeGridFormattedBase(Model.Data.OsobaPrezime gridformated)
    	{
    	    this.ID_OsobaPrezime = gridformated.ID_OsobaPrezime;
    	    this.ID_Osoba = gridformated.ID_Osoba;
    	    this.RedniBroj = gridformated.RedniBroj;
    	    this.Aktivno = gridformated.Aktivno;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.Prezime = gridformated.Prezime;
    	}
    
    	/*
    	    mymodel.ID_OsobaPrezime = model.ID_OsobaPrezime;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.Aktivno = model.Aktivno;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.Prezime = model.Prezime;
    		
    	*/
    
    		#endregion
    }
}
