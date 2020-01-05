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
    
    
    public partial class TransakcijskiRacunGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.TransakcijskiRacun.ID_TransakcijskiRacun.Required)]
    	[DisplayName(AtributClass.TransakcijskiRacun.ID_TransakcijskiRacun.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.ID_TransakcijskiRacun.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.ID_TransakcijskiRacun.Sortable)]
    	public long ID_TransakcijskiRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.TransakcijskiRacun.ID_Banka.Required)]
    	[DisplayName(AtributClass.TransakcijskiRacun.ID_Banka.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.ID_Banka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.ID_Banka.Sortable)]
    	public long ID_Banka { get; set; }
    
        [Required(ErrorMessage = AtributClass.TransakcijskiRacun.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.TransakcijskiRacun.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.ID_Subjekt.Sortable)]
    	public long ID_Subjekt { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TransakcijskiRacun.IDValuta.StringLength)]
    	[DisplayName(AtributClass.TransakcijskiRacun.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.TransakcijskiRacun.DatumOtvaranje.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.DatumOtvaranje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.DatumOtvaranje.Sortable)]
    	public Nullable<System.DateTime> DatumOtvaranje { get; set; }
    
    	
        [StringLength(7, ErrorMessage = AtributClass.TransakcijskiRacun.VBDI.StringLength)]
    	[DisplayName(AtributClass.TransakcijskiRacun.VBDI.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.VBDI.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.VBDI.Sortable)]
    	public string VBDI { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.TransakcijskiRacun.Broj.StringLength)]
    	[DisplayName(AtributClass.TransakcijskiRacun.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.Broj.Sortable)]
    	public string Broj { get; set; }
    
    	
        [StringLength(34, ErrorMessage = AtributClass.TransakcijskiRacun.IBAN.StringLength)]
    	[DisplayName(AtributClass.TransakcijskiRacun.IBAN.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TransakcijskiRacun.IBAN.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TransakcijskiRacun.IBAN.Sortable)]
    	public string IBAN { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TransakcijskiRacunGridFormattedBase()
        { }
    	
    	public TransakcijskiRacunGridFormattedBase(Model.Data.TransakcijskiRacun gridformated)
    	{
    	    this.ID_TransakcijskiRacun = gridformated.ID_TransakcijskiRacun;
    	    this.ID_Banka = gridformated.ID_Banka;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.DatumOtvaranje = gridformated.DatumOtvaranje;
    	    this.VBDI = gridformated.VBDI;
    	    this.Broj = gridformated.Broj;
    	    this.IBAN = gridformated.IBAN;
    	}
    
    	/*
    	    mymodel.ID_TransakcijskiRacun = model.ID_TransakcijskiRacun;
    	    mymodel.ID_Banka = model.ID_Banka;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.DatumOtvaranje = model.DatumOtvaranje;
    	    mymodel.VBDI = model.VBDI;
    	    mymodel.Broj = model.Broj;
    	    mymodel.IBAN = model.IBAN;
    		
    	*/
    
    		#endregion
    }
}
