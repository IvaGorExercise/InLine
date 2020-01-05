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
    
    
    public partial class TemeljnicaStDetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.Sortable)]
    	public long ID_TemeljnicaSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_Temeljnica.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Temeljnica.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Temeljnica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Temeljnica.Sortable)]
    	public long ID_Temeljnica { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.RedniBroj.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.RedniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.RedniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.RedniBroj.Sortable)]
    	public int RedniBroj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.Datum.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.Datum.Sortable)]
    	public System.DateTime Datum { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.Sortable)]
    	public long ID_KontniPlanSt { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Davanje.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Davanje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Davanje.Sortable)]
    	public Nullable<long> ID_Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosDuguje.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.IznosDuguje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.IznosDuguje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.IznosDuguje.Sortable)]
    	public decimal IznosDuguje { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosPotrazuje.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.IznosPotrazuje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.IznosPotrazuje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.IznosPotrazuje.Sortable)]
    	public decimal IznosPotrazuje { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaStDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IDValuta.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.Sortable)]
    	public decimal IznosDugujeValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.Sortable)]
    	public decimal IznosPotrazujeValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.Tecaj.Required)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.Tecaj.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.Tecaj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.Tecaj.Sortable)]
    	public decimal Tecaj { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_Tecaj.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_Tecaj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_Tecaj.Sortable)]
    	public Nullable<long> ID_Tecaj { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ID_KontniPlanAnalitika.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ID_KontniPlanAnalitika.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ID_KontniPlanAnalitika.Sortable)]
    	public Nullable<long> ID_KontniPlanAnalitika { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.TemeljnicaStDetalj.ZapisOpis.StringLength)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.ZapisOpis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.ZapisOpis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.ZapisOpis.Sortable)]
    	public string ZapisOpis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.TemeljnicaStDetalj.DatumDospijeca.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.TemeljnicaStDetalj.DatumDospijeca.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStDetalj.DatumDospijeca.Sortable)]
    	public Nullable<System.DateTime> DatumDospijeca { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public TemeljnicaStDetaljGridFormattedBase()
        { }
    	
    	public TemeljnicaStDetaljGridFormattedBase(Model.Data.View.TemeljnicaStDetalj gridformated)
    	{
    	    this.ID_TemeljnicaSt = gridformated.ID_TemeljnicaSt;
    	    this.ID_Temeljnica = gridformated.ID_Temeljnica;
    	    this.RedniBroj = gridformated.RedniBroj;
    	    this.Datum = gridformated.Datum;
    	    this.ID_KontniPlanSt = gridformated.ID_KontniPlanSt;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.ID_Davanje = gridformated.ID_Davanje;
    	    this.IznosDuguje = gridformated.IznosDuguje;
    	    this.IznosPotrazuje = gridformated.IznosPotrazuje;
    	    this.IDValuta = gridformated.IDValuta;
    	    this.IznosDugujeValuta = gridformated.IznosDugujeValuta;
    	    this.IznosPotrazujeValuta = gridformated.IznosPotrazujeValuta;
    	    this.Tecaj = gridformated.Tecaj;
    	    this.ID_Tecaj = gridformated.ID_Tecaj;
    	    this.Opis = gridformated.Opis;
    	    this.ID_KontniPlanAnalitika = gridformated.ID_KontniPlanAnalitika;
    	    this.ZapisOpis = gridformated.ZapisOpis;
    	    this.DatumDospijeca = gridformated.DatumDospijeca;
    	}
    
    	/*
    	    mymodel.ID_TemeljnicaSt = model.ID_TemeljnicaSt;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.Datum = model.Datum;
    	    mymodel.ID_KontniPlanSt = model.ID_KontniPlanSt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.IznosDuguje = model.IznosDuguje;
    	    mymodel.IznosPotrazuje = model.IznosPotrazuje;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.IznosDugujeValuta = model.IznosDugujeValuta;
    	    mymodel.IznosPotrazujeValuta = model.IznosPotrazujeValuta;
    	    mymodel.Tecaj = model.Tecaj;
    	    mymodel.ID_Tecaj = model.ID_Tecaj;
    	    mymodel.Opis = model.Opis;
    	    mymodel.ID_KontniPlanAnalitika = model.ID_KontniPlanAnalitika;
    	    mymodel.ZapisOpis = model.ZapisOpis;
    	    mymodel.DatumDospijeca = model.DatumDospijeca;
    		
    	*/
    
    		#endregion
    }
}