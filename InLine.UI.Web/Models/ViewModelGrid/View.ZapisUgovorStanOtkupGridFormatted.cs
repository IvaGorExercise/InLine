
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


    public partial class ZapisUgovorStanOtkupGridFormatted
    {
       	#region Properities
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Zapis.DisplayName)]
        [ScaffoldColumn(true)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.Sortable)]
        //public int IDZapisTablica { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapisVr.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapisVr.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IDZapisVr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IDZapisVr.Sortable)]
        //public int IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapis.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IDZapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IDZapis.Sortable)]
    	public long IDZapis { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.VrijemeUpis.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.VrijemeUpis.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.VrijemeUpis.Sortable)]
        //public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        //[StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.Sortable)]
        //public string UrudzbeniBroj { get; set; }
    
    	
        //[StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Predmet.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Predmet.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Predmet.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Predmet.Sortable)]
        //public string Predmet { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Subjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Subjekt.Sortable)]
        //public Nullable<long> ID_Subjekt { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_SubjektUpis.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_SubjektUpis.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_SubjektUpis.Sortable)]
        //public Nullable<long> ID_SubjektUpis { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Temeljnica.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Temeljnica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Temeljnica.Sortable)]
        //public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Broj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Broj.Sortable)]
    	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Datum.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Datum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Datum.Sortable)]
    	public Nullable<System.DateTime> Datum { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Vrijeme.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Vrijeme.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Vrijeme.Sortable)]
        //public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        //[StringLength(128, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.Sortable)]
        //public string TablicaNaziv { get; set; }
    
    	
        //[StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Naziv.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Naziv.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Naziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Naziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Naziv.Sortable)]
        //public string Naziv { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NazivKr.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.NazivKr.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.NazivKr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.NazivKr.Sortable)]
        //public string NazivKr { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Odabir.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Odabir.Sortable)]
        //public Nullable<bool> Odabir { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumGodina.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumGodina.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumGodina.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumGodina.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumGodina.Sortable)]
        //public string DatumGodina { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.Sortable)]
        //public string VrijemeUpisString { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumString.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumString.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumString.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumString.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumString.Sortable)]
        //public string DatumString { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.DisplayName)]
        //[ScaffoldColumn(false)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.Sortable)]
        //public long ID_UgovorStanOtkup { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_ZapisUgovorStanOtkup.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_ZapisUgovorStanOtkup.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_ZapisUgovorStanOtkup.Sortable)]
        //public Nullable<long> ID_ZapisUgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojUgovor.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojAneks.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojAneks.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.BrojAneks.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.BrojAneks.Sortable)]
        //public int BrojAneks { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojStorno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojStorno.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.BrojStorno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.BrojStorno.Sortable)]
        //public int BrojStorno { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupDatum.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupDatum.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupDatum.Sortable)]
        //public Nullable<System.DateTime> UgovorStanOtkupDatum { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Stan.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Stan.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Stan.Sortable)]
        //public Nullable<long> ID_Stan { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcesce.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcesce.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosUcesce.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosUcesce.Sortable)]
        //public decimal IznosUcesce { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.Sortable)]
        //public decimal IznosUcescePlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.Sortable)]
        //public decimal IznosUcesceNeplaceno { get; set; }


        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.Sortable)]
        //public decimal IznosKreditPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.Sortable)]
        //public decimal IznosKreditNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.Sortable)]
        //public decimal IznosKreditRevalorizacija { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Sortable)]
        //public decimal IznosKreditRevalorizacijaPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Sortable)]
        //public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamata.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamata.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamata.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamata.Sortable)]
        //public decimal IznosKamata { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.Sortable)]
        //public decimal IznosKamataPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.Sortable)]
        //public decimal IznosKamataNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.Sortable)]
        //public decimal IznosKamataRevalorizacija { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Sortable)]
        //public decimal IznosKamataRevalorizacijaPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Sortable)]
        //public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.Sortable)]
        //public decimal IznosJednokratno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.Sortable)]
        //public decimal IznosJednokratnoPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.Sortable)]
        //public decimal IznosJednokratnoNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.Sortable)]
        //public decimal IznosJednokratnoValuta { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.Sortable)]
        //public decimal IznosJednokratnoValutaPlaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Sortable)]
        //public decimal IznosJednokratnoValutaNeplaceno { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.Sortable)]
        //public decimal IznosKreditObrok { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.Sortable)]
        //public decimal IznosKamataObrok { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.Sortable)]
        //public decimal IznosUkupnoObrok { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.Sortable)]
        //public decimal IznosTrosakSud { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosPovrat.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosPovrat.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosPovrat.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosPovrat.Sortable)]
        //public decimal IznosPovrat { get; set; }
   
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.TecajDM.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.TecajDM.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.TecajDM.Sortable)]
        //public Nullable<decimal> TecajDM { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceJednokratno.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceJednokratno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumDospijeceJednokratno.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceJednokratno { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceUcesce.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceUcesce.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumDospijeceUcesce.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceUcesce { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojObrok.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.BrojObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.BrojObrok.Sortable)]
        //public Nullable<int> BrojObrok { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceTrosakSud.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceTrosakSud.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumDospijeceTrosakSud.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceTrosakSud { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupID_Subjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupID_Subjekt.Sortable)]
        //public Nullable<long> UgovorStanOtkupID_Subjekt { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojObrokDospjelo.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.BrojObrokDospjelo.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.BrojObrokDospjelo.Sortable)]
        //public Nullable<int> BrojObrokDospjelo { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceObrok.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumDospijeceObrok.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceObrok { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Pretvorba.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Pretvorba.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Pretvorba.Sortable)]
        //public bool Pretvorba { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Napomena.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.Napomena.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Napomena.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Napomena.Sortable)]
        //public string Napomena { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NadstojnickiAdaptiran.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.NadstojnickiAdaptiran.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.NadstojnickiAdaptiran.Sortable)]
        //public bool NadstojnickiAdaptiran { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupStorno.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupStorno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupStorno.Sortable)]
        //public Nullable<long> ID_UgovorStanOtkupStorno { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaGodina.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.TemeljnicaGodina.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.TemeljnicaGodina.Sortable)]
        //public Nullable<int> TemeljnicaGodina { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaVrsta.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.TemeljnicaVrsta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.TemeljnicaVrsta.Sortable)]
        //public Nullable<int> TemeljnicaVrsta { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaBroj.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.TemeljnicaBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.TemeljnicaBroj.Sortable)]
        //public Nullable<int> TemeljnicaBroj { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DokumentGrupa.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DokumentGrupa.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DokumentGrupa.Sortable)]
        //public Nullable<int> DokumentGrupa { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DokumentVrsta.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DokumentVrsta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DokumentVrsta.Sortable)]
        //public Nullable<int> DokumentVrsta { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumInsert.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumInsert.Sortable)]
        //public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OsobaInsert.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.OsobaInsert.Sortable)]
        //public string OsobaInsert { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumUpdate.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.DatumUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.DatumUpdate.Sortable)]
        //public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.Sortable)]
        //public string OsobaUpdate { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_OsobaInsert.Sortable)]
        //public Nullable<long> ID_OsobaInsert { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_OsobaUpdate.Sortable)]
        //public Nullable<long> ID_OsobaUpdate { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.NeZateznaKamata.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.NeZateznaKamata.Sortable)]
        //public Nullable<bool> NeZateznaKamata { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorTuzen.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.UgovorTuzen.Sortable)]
        //public Nullable<bool> UgovorTuzen { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.OtkupNadstojnicki.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.OtkupNadstojnicki.Sortable)]
        //public Nullable<bool> OtkupNadstojnicki { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Kupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Kupac.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Kupac.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Kupac.Sortable)]
    	public long ID_Kupac { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.KupacNaziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.KupacNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.KupacNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.KupacNaziv.Sortable)]
    	public string KupacNaziv { get; set; }

        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Prezime.Required)]
        [DisplayName(AtributClass.ZapisUgovorStanOtkup.Prezime.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Prezime.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Prezime.Sortable)]
        public string Prezime { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ime.Required)]
        [DisplayName(AtributClass.ZapisUgovorStanOtkup.Ime.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Ime.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Ime.Sortable)]
        public string Ime { get; set; }

        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OIB.StringLength)]
        [DisplayName(AtributClass.ZapisUgovorStanOtkup.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.OIB.Sortable)]
        public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ulica.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Ulica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Ulica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Ulica.Sortable)]
    	public string Ulica { get; set; }
    
    	
        //[StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.KucniBroj.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.KucniBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.KucniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.KucniBroj.Sortable)]
        //public string KucniBroj { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.Sortable)]
    	public string PostanskiBroj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Posta.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Posta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.Posta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.Posta.Sortable)]
    	public string Posta { get; set; }

        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKredit.Required)]
        [DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IznosKredit.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IznosKredit.Sortable)]
        public decimal IznosKredit { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDValuta.StringLength)]
        [DisplayName(AtributClass.ZapisUgovorStanOtkup.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.IDValuta.Sortable)]
        public string IDValuta { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Posta.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Posta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Posta.Sortable)]
        //public Nullable<long> ID_Posta { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Osoba.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_Osoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_Osoba.Sortable)]
    	public long ID_Osoba { get; set; }
    
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.KupacID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.KupacID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.KupacID_Subjekt.Sortable)]
    	public Nullable<long> KupacID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.Sortable)]
    	public long ID_UgovorStanOtkupKupac { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisUgovorStanOtkupGridFormatted()
        { }
    	
    	public ZapisUgovorStanOtkupGridFormatted(Model.Data.View.ZapisUgovorStanOtkup gridformated)
    	{
    	    this.ID_Zapis = gridformated.ID_Zapis;
            //this.IDZapisTablica = gridformated.IDZapisTablica;
            //this.IDZapisVr = gridformated.IDZapisVr;
    	    this.IDZapis = gridformated.IDZapis;
            //this.VrijemeUpis = gridformated.VrijemeUpis;
            //this.UrudzbeniBroj = gridformated.UrudzbeniBroj;
            //this.Predmet = gridformated.Predmet;
            //this.ID_Subjekt = gridformated.ID_Subjekt;
            //this.ID_SubjektUpis = gridformated.ID_SubjektUpis;
            //this.ID_Temeljnica = gridformated.ID_Temeljnica;
    	    this.Broj = gridformated.Broj;
    	    this.Datum = gridformated.Datum;
            //this.Vrijeme = gridformated.Vrijeme;
            //this.TablicaNaziv = gridformated.TablicaNaziv;
            //this.Naziv = gridformated.Naziv;
            //this.NazivKr = gridformated.NazivKr;
            //this.Odabir = gridformated.Odabir;
            //this.DatumGodina = gridformated.DatumGodina;
            //this.VrijemeUpisString = gridformated.VrijemeUpisString;
            //this.DatumString = gridformated.DatumString;
            //this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            //this.ID_ZapisUgovorStanOtkup = gridformated.ID_ZapisUgovorStanOtkup;
    	    this.BrojUgovor = gridformated.BrojUgovor;
            //this.BrojAneks = gridformated.BrojAneks;
            //this.BrojStorno = gridformated.BrojStorno;
            //this.UgovorStanOtkupDatum = gridformated.UgovorStanOtkupDatum;
            //this.ID_Stan = gridformated.ID_Stan;
            //this.IznosUcesce = gridformated.IznosUcesce;
            //this.IznosUcescePlaceno = gridformated.IznosUcescePlaceno;
            //this.IznosUcesceNeplaceno = gridformated.IznosUcesceNeplaceno;
            this.IznosKredit = gridformated.IznosKredit;
            //this.IznosKreditPlaceno = gridformated.IznosKreditPlaceno;
            //this.IznosKreditNeplaceno = gridformated.IznosKreditNeplaceno;
            //this.IznosKreditRevalorizacija = gridformated.IznosKreditRevalorizacija;
            //this.IznosKreditRevalorizacijaPlaceno = gridformated.IznosKreditRevalorizacijaPlaceno;
            //this.IznosKreditRevalorizacijaNeplaceno = gridformated.IznosKreditRevalorizacijaNeplaceno;
            //this.IznosKamata = gridformated.IznosKamata;
            //this.IznosKamataPlaceno = gridformated.IznosKamataPlaceno;
            //this.IznosKamataNeplaceno = gridformated.IznosKamataNeplaceno;
            //this.IznosKamataRevalorizacija = gridformated.IznosKamataRevalorizacija;
            //this.IznosKamataRevalorizacijaPlaceno = gridformated.IznosKamataRevalorizacijaPlaceno;
            //this.IznosKamataRevalorizacijaNeplaceno = gridformated.IznosKamataRevalorizacijaNeplaceno;
            //this.IznosJednokratno = gridformated.IznosJednokratno;
            //this.IznosJednokratnoPlaceno = gridformated.IznosJednokratnoPlaceno;
            //this.IznosJednokratnoNeplaceno = gridformated.IznosJednokratnoNeplaceno;
            //this.IznosJednokratnoValuta = gridformated.IznosJednokratnoValuta;
            //this.IznosJednokratnoValutaPlaceno = gridformated.IznosJednokratnoValutaPlaceno;
            //this.IznosJednokratnoValutaNeplaceno = gridformated.IznosJednokratnoValutaNeplaceno;
            //this.IznosKreditObrok = gridformated.IznosKreditObrok;
            //this.IznosKamataObrok = gridformated.IznosKamataObrok;
            //this.IznosUkupnoObrok = gridformated.IznosUkupnoObrok;
            //this.IznosTrosakSud = gridformated.IznosTrosakSud;
            //this.IznosPovrat = gridformated.IznosPovrat;
    	    this.IDValuta = gridformated.IDValuta;
            //this.TecajDM = gridformated.TecajDM;
            //this.DatumDospijeceJednokratno = gridformated.DatumDospijeceJednokratno;
            //this.DatumDospijeceUcesce = gridformated.DatumDospijeceUcesce;
            //this.BrojObrok = gridformated.BrojObrok;
            //this.DatumDospijeceTrosakSud = gridformated.DatumDospijeceTrosakSud;
            //this.UgovorStanOtkupID_Subjekt = gridformated.UgovorStanOtkupID_Subjekt;
            //this.BrojObrokDospjelo = gridformated.BrojObrokDospjelo;
            //this.DatumDospijeceObrok = gridformated.DatumDospijeceObrok;
            //this.Pretvorba = gridformated.Pretvorba;
            //this.Napomena = gridformated.Napomena;
            //this.NadstojnickiAdaptiran = gridformated.NadstojnickiAdaptiran;
            //this.ID_UgovorStanOtkupStorno = gridformated.ID_UgovorStanOtkupStorno;
            //this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
            //this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
            //this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
            //this.DokumentGrupa = gridformated.DokumentGrupa;
            //this.DokumentVrsta = gridformated.DokumentVrsta;
            //this.DatumInsert = gridformated.DatumInsert;
            //this.OsobaInsert = gridformated.OsobaInsert;
            //this.DatumUpdate = gridformated.DatumUpdate;
            //this.OsobaUpdate = gridformated.OsobaUpdate;
            //this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
            //this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
            //this.NeZateznaKamata = gridformated.NeZateznaKamata;
            //this.UgovorTuzen = gridformated.UgovorTuzen;
            //this.OtkupNadstojnicki = gridformated.OtkupNadstojnicki;
    	    this.ID_Kupac = gridformated.ID_Kupac;
    	    this.KupacNaziv = gridformated.KupacNaziv;
    	    this.Ulica = gridformated.Ulica;
            //this.KucniBroj = gridformated.KucniBroj;
    	    this.PostanskiBroj = gridformated.PostanskiBroj;
    	    this.OIB = gridformated.OIB;
    	    this.Posta = gridformated.Posta;
            //this.ID_Posta = gridformated.ID_Posta;
    	    this.ID_Osoba = gridformated.ID_Osoba;
    	    this.Prezime = gridformated.Prezime;
    	    this.Ime = gridformated.Ime;
    	    this.KupacID_Subjekt = gridformated.KupacID_Subjekt;
    	    this.ID_UgovorStanOtkupKupac = gridformated.ID_UgovorStanOtkupKupac;
    	}
    
    		#endregion
    }
}
