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
    
    
    public partial class OsobaPrebivalisteGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.OsobaPrebivaliste.ID_OsobaPrebivaliste.Required)]
    	[DisplayName(AtributClass.OsobaPrebivaliste.ID_OsobaPrebivaliste.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrebivaliste.ID_OsobaPrebivaliste.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrebivaliste.ID_OsobaPrebivaliste.Sortable)]
    	public long ID_OsobaPrebivaliste { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaPrebivaliste.ID_Osoba.Required)]
    	[DisplayName(AtributClass.OsobaPrebivaliste.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrebivaliste.ID_Osoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrebivaliste.ID_Osoba.Sortable)]
    	public long ID_Osoba { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaPrebivaliste.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OsobaPrebivaliste.ID_Opcina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrebivaliste.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrebivaliste.ID_Opcina.Sortable)]
    	public long ID_Opcina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OsobaPrebivaliste.DatumOd.Required)]
    	[DisplayName(AtributClass.OsobaPrebivaliste.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrebivaliste.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrebivaliste.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaPrebivaliste.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.OsobaPrebivaliste.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.OsobaPrebivaliste.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public OsobaPrebivalisteGridFormattedBase()
        { }
    	
    	public OsobaPrebivalisteGridFormattedBase(Model.Data.OsobaPrebivaliste gridformated)
    	{
    	    this.ID_OsobaPrebivaliste = gridformated.ID_OsobaPrebivaliste;
    	    this.ID_Osoba = gridformated.ID_Osoba;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	}
    
    	/*
    	    mymodel.ID_OsobaPrebivaliste = model.ID_OsobaPrebivaliste;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    		
    	*/
    
    		#endregion
    }
}
