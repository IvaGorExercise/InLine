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
    
    
    public partial class OsobaBoravisteGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_OsobaBoraviste.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_OsobaBoraviste.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaBoraviste.ID_OsobaBoraviste.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaBoraviste.ID_OsobaBoraviste.Sortable)]
    	public long ID_OsobaBoraviste { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_Osoba.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaBoraviste.ID_Osoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaBoraviste.ID_Osoba.Sortable)]
    	public long ID_Osoba { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_Opcina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaBoraviste.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaBoraviste.ID_Opcina.Sortable)]
    	public long ID_Opcina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.DatumOd.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaBoraviste.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaBoraviste.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaBoraviste.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaBoraviste.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaBoraviste.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OsobaBoravisteGridFormattedBase()
        { }
    	
    	public OsobaBoravisteGridFormattedBase(Model.Data.OsobaBoraviste gridformated)
    	{
    	    this.ID_OsobaBoraviste = gridformated.ID_OsobaBoraviste;
    	    this.ID_Osoba = gridformated.ID_Osoba;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	}
    
    	/*
    	    mymodel.ID_OsobaBoraviste = model.ID_OsobaBoraviste;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    		
    	*/
    
    		#endregion
    }
}
