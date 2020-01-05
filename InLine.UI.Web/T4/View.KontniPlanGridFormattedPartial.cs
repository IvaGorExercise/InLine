//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.View
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
    
    
    public partial class KontniPlanGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KontniPlan.AnalitikaOd.Required)]
    	[DisplayName(AtributClass.KontniPlan.AnalitikaOd.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.AnalitikaOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.AnalitikaOd.Sortable)]
    	public int AnalitikaOd { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.ID_KontniPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_KontniPlan.Sortable)]
    	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_PoslovnaGodina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.ID_PoslovnaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_PoslovnaGodina.Sortable)]
    	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.Godina.Required)]
    	[DisplayName(AtributClass.KontniPlan.Godina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.Godina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.Godina.Sortable)]
    	public int Godina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumOd.Required)]
    	[DisplayName(AtributClass.KontniPlan.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumDo.Required)]
    	[DisplayName(AtributClass.KontniPlan.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.DatumDo.Sortable)]
    	public System.DateTime DatumDo { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.KontniPlan.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.IDValuta.Required)]
    	[DisplayName(AtributClass.KontniPlan.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_PoslovniSubjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.ID_PoslovniSubjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_PoslovniSubjekt.Sortable)]
    	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_Subjekt.Sortable)]
    	public long ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KontniPlan.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.Oznaka.Required)]
    	[DisplayName(AtributClass.KontniPlan.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KontniPlan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.Naziv.Required)]
    	[DisplayName(AtributClass.KontniPlan.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KontniPlan.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KontniPlanGridFormattedBase()
        { }
    	
    	public KontniPlanGridFormattedBase(Model.Data.View.KontniPlan gridformated)
    	{
    	    this.AnalitikaOd = gridformated.AnalitikaOd;
    	    this.ID_KontniPlan = gridformated.ID_KontniPlan;
    	    this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
    	    this.Godina = gridformated.Godina;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	}
    
    	/*
    	    mymodel.AnalitikaOd = model.AnalitikaOd;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.Godina = model.Godina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    }
}
