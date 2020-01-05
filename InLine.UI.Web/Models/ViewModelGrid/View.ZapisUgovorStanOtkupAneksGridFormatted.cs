
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


    public partial class ZapisUgovorStanOtkupAneksGridFormatted
    {
       #region Properities
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.Sortable)]
        //public int IDZapisTablica { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisVr.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisVr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.IDZapisVr.Sortable)]
        //public Nullable<int> IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.DisplayName)]
        [ScaffoldColumn(true)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.Sortable)]
    	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.Sortable)]
    	public long IDZapis { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpis.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpis.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpis.Sortable)]
        //public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        //[StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.Sortable)]
        //public string UrudzbeniBroj { get; set; }
    
    	
        //[StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Predmet.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Predmet.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Predmet.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Predmet.Sortable)]
        //public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_Subjekt.Sortable)]
    	public Nullable<long> ID_Subjekt { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_SubjektUpis.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_SubjektUpis.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_SubjektUpis.Sortable)]
        //public Nullable<long> ID_SubjektUpis { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Temeljnica.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_Temeljnica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_Temeljnica.Sortable)]
        //public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Broj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Broj.Sortable)]
    	public string Broj { get; set; }
    
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Datum.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Datum.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Datum.Sortable)]
        //public Nullable<System.DateTime> Datum { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Vrijeme.DisplayName)]
        // [JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Vrijeme.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Vrijeme.Sortable)]
        //public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.Sortable)]
    	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Naziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.Sortable)]
        //public string NazivKr { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Odabir.DisplayName)]
        //[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Odabir.Sortable)]
        //public Nullable<bool> Odabir { get; set; }
    
    	
        //[StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.Sortable)]
        //public string DatumGodina { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.Sortable)]
        //public string VrijemeUpisString { get; set; }
    
    	
        //[StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumString.StringLength)]
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumString.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.DatumString.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.DatumString.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.DatumString.Sortable)]
        //public string DatumString { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.DisplayName)]
        //[ScaffoldColumn(false)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Sortable)]
        //public long ID_UgovorStanOtkupAneks { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_ZapisUgovorStanOtkupAneks.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_ZapisUgovorStanOtkupAneks.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_ZapisUgovorStanOtkupAneks.Sortable)]
        //public Nullable<long> ID_ZapisUgovorStanOtkupAneks { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkup.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkup.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkup.Sortable)]
        //public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.Sortable)]
    	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.Sortable)]
    	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.Sortable)]
    	public long ID_UgovorStanOtkupKupac { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.DisplayName)]
        //[ScaffoldColumn(false)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.Sortable)]
        //public long ID_Kupac { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.Sortable)]
    	public string KupacNaziv { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.JMBG.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.JMBG.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.JMBG.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.JMBG.Sortable)]
    	public string JMBG { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ulica.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Ulica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Ulica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Ulica.Sortable)]
    	public string Ulica { get; set; }
    
    	
        //[StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.Sortable)]
        //public string KucniBroj { get; set; }
    
    	
        //[StringLength(2, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.StringLength)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.Sortable)]
        //public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OIB.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.OIB.Sortable)]
    	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Posta.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Posta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Posta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Posta.Sortable)]
    	public string Posta { get; set; }
    
        //[Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.Required)]
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.DisplayName)]
        //[ScaffoldColumn(false)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.Sortable)]
        //public long ID_Osoba { get; set; }
    
        //[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OsobaID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.OsobaID_Subjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.OsobaID_Subjekt.Sortable)]
        //public Nullable<long> OsobaID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.Sortable)]
    	public string OsobaOznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Prezime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Prezime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Prezime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Prezime.Sortable)]
    	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Ime.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.Ime.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.Ime.Sortable)]
    	public string Ime { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KupacID_Subjekt.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ZapisUgovorStanOtkupAneks.KupacID_Subjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ZapisUgovorStanOtkupAneks.KupacID_Subjekt.Sortable)]
    	public Nullable<long> KupacID_Subjekt { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ZapisUgovorStanOtkupAneksGridFormatted()
        { }
    	
    	public ZapisUgovorStanOtkupAneksGridFormatted(Model.Data.View.ZapisUgovorStanOtkupAneks gridformated)
    	{
            //this.IDZapisTablica = gridformated.IDZapisTablica;
            //this.IDZapisVr = gridformated.IDZapisVr;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.IDZapis = gridformated.IDZapis;
            //this.VrijemeUpis = gridformated.VrijemeUpis;
            //this.UrudzbeniBroj = gridformated.UrudzbeniBroj;
            //this.Predmet = gridformated.Predmet;
    	    this.ID_Subjekt = gridformated.ID_Subjekt;
            //this.ID_SubjektUpis = gridformated.ID_SubjektUpis;
            //this.ID_Temeljnica = gridformated.ID_Temeljnica;
    	    this.Broj = gridformated.Broj;
            //this.Datum = gridformated.Datum;
            //this.Vrijeme = gridformated.Vrijeme;
    	    this.TablicaNaziv = gridformated.TablicaNaziv;
    	    this.Naziv = gridformated.Naziv;
            //this.NazivKr = gridformated.NazivKr;
            //this.Odabir = gridformated.Odabir;
            //this.DatumGodina = gridformated.DatumGodina;
            //this.VrijemeUpisString = gridformated.VrijemeUpisString;
            //this.DatumString = gridformated.DatumString;
            //this.ID_UgovorStanOtkupAneks = gridformated.ID_UgovorStanOtkupAneks;
            //this.ID_ZapisUgovorStanOtkupAneks = gridformated.ID_ZapisUgovorStanOtkupAneks;
            //this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.BrojAneks = gridformated.BrojAneks;
    	    this.BrojStorno = gridformated.BrojStorno;
    	    this.ID_UgovorStanOtkupKupac = gridformated.ID_UgovorStanOtkupKupac;
            //this.ID_Kupac = gridformated.ID_Kupac;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.KupacNaziv = gridformated.KupacNaziv;
    	    this.JMBG = gridformated.JMBG;
    	    this.Ulica = gridformated.Ulica;
            //this.KucniBroj = gridformated.KucniBroj;
            //this.KucniBrojDodatak = gridformated.KucniBrojDodatak;
    	    this.OIB = gridformated.OIB;
    	    this.Posta = gridformated.Posta;
            //this.ID_Osoba = gridformated.ID_Osoba;
            //this.OsobaID_Subjekt = gridformated.OsobaID_Subjekt;
    	    this.OsobaOznaka = gridformated.OsobaOznaka;
    	    this.Prezime = gridformated.Prezime;
    	    this.Ime = gridformated.Ime;
    	    this.KupacID_Subjekt = gridformated.KupacID_Subjekt;
    	}
    
    		#endregion
    }
}
