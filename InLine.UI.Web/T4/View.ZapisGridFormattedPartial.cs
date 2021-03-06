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
    
    
    public partial class ZapisGridFormattedBase
    {
    	#region Properities
    	[DisplayName(AtributClass.Zapis.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapisTablica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.IDZapisTablica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.IDZapisTablica.Sortable)]
    	public Nullable<int> IDZapisTablica { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapisVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.IDZapisVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.IDZapisVr.Sortable)]
    	public Nullable<int> IDZapisVr { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.IDZapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.IDZapis.Sortable)]
    	public Nullable<long> IDZapis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Zapis.VrijemeUpis.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Zapis.VrijemeUpis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.VrijemeUpis.Sortable)]
    	public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Zapis.UrudzbeniBroj.StringLength)]
    	[DisplayName(AtributClass.Zapis.UrudzbeniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.UrudzbeniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.UrudzbeniBroj.Sortable)]
    	public string UrudzbeniBroj { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Zapis.Predmet.StringLength)]
    	[DisplayName(AtributClass.Zapis.Predmet.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.Predmet.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Predmet.Sortable)]
    	public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_SubjektUpis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.ID_SubjektUpis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.ID_SubjektUpis.Sortable)]
    	public Nullable<long> ID_SubjektUpis { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_Temeljnica.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.Zapis.ID_Temeljnica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.ID_Temeljnica.Sortable)]
    	public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Zapis.Broj.StringLength)]
    	[DisplayName(AtributClass.Zapis.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Broj.Sortable)]
    	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Zapis.Datum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Zapis.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.Zapis.Vrijeme.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.Zapis.Vrijeme.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Vrijeme.Sortable)]
    	public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.Zapis.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.Zapis.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Zapis.Naziv.StringLength)]
    	[DisplayName(AtributClass.Zapis.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.NazivKr.StringLength)]
    	[DisplayName(AtributClass.Zapis.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	[DisplayName(AtributClass.Zapis.Odabir.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.Odabir.Sortable)]
    	public Nullable<bool> Odabir { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Zapis.DatumGodina.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.DatumGodina.Required)]
    	[DisplayName(AtributClass.Zapis.DatumGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.DatumGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.DatumGodina.Sortable)]
    	public string DatumGodina { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.VrijemeUpisString.StringLength)]
    	[DisplayName(AtributClass.Zapis.VrijemeUpisString.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.VrijemeUpisString.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.VrijemeUpisString.Sortable)]
    	public string VrijemeUpisString { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.DatumString.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.DatumString.Required)]
    	[DisplayName(AtributClass.Zapis.DatumString.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.Zapis.DatumString.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.Zapis.DatumString.Sortable)]
    	public string DatumString { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisGridFormattedBase()
        { }
    	
    	public ZapisGridFormattedBase(Model.Data.View.Zapis gridformated)
    	{
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.IDZapisTablica = gridformated.IDZapisTablica;
    	    this.IDZapisVr = gridformated.IDZapisVr;
    	    this.IDZapis = gridformated.IDZapis;
    	    this.VrijemeUpis = gridformated.VrijemeUpis;
    	    this.UrudzbeniBroj = gridformated.UrudzbeniBroj;
    	    this.Predmet = gridformated.Predmet;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
    	    this.ID_SubjektUpis = gridformated.ID_SubjektUpis;
    	    this.ID_Temeljnica = gridformated.ID_Temeljnica;
    	    this.Broj = gridformated.Broj;
    	    this.Datum = gridformated.Datum;
    	    this.Vrijeme = gridformated.Vrijeme;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Odabir = gridformated.Odabir;
    	    this.DatumGodina = gridformated.DatumGodina;
    	    this.VrijemeUpisString = gridformated.VrijemeUpisString;
    	    this.DatumString = gridformated.DatumString;
    	}
    
    	/*
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDZapisTablica = model.IDZapisTablica;
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.IDZapis = model.IDZapis;
    	    mymodel.VrijemeUpis = model.VrijemeUpis;
    	    mymodel.UrudzbeniBroj = model.UrudzbeniBroj;
    	    mymodel.Predmet = model.Predmet;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_SubjektUpis = model.ID_SubjektUpis;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Datum = model.Datum;
    	    mymodel.Vrijeme = model.Vrijeme;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Odabir = model.Odabir;
    	    mymodel.DatumGodina = model.DatumGodina;
    	    mymodel.VrijemeUpisString = model.VrijemeUpisString;
    	    mymodel.DatumString = model.DatumString;
    		
    	*/
    
    		#endregion
    }
}
