
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


    public partial class UgovorStanOtkupZavrsetakGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.Sortable)]
        public long ID_UgovorStanOtkupZavrsetak { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.Sortable)]
        public long ID_UgovorstanOtkup { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.Sortable)]
        public int BrojUgovor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Datum.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.Datum.Sortable)]
        public System.DateTime Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.DokumentVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.DokumentVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.DokumentVrsta.Sortable)]
        public Nullable<int> DokumentVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.DokumentGrupa.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.DokumentGrupa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.DokumentGrupa.Sortable)]
        public Nullable<int> DokumentGrupa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_DokumentVr.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.ID_DokumentVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.ID_DokumentVr.Sortable)]
        public Nullable<long> ID_DokumentVr { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Razlog.StringLength)]
        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Razlog.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.Razlog.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.Razlog.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.Razlog.Sortable)]
        //public string Razlog { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.ID_Subjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.ID_Subjekt.Sortable)]
        //public Nullable<long> ID_Subjekt { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.Sortable)]
        //public decimal IznosJednokratno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.Sortable)]
        //public decimal IznosUcesce { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.Sortable)]
        //public decimal IznosKamata { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.Sortable)]
        //public decimal IznosKredit { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.Sortable)]
        //public decimal IznosKamataRevalorizacija { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.Sortable)]
        //public decimal IznosKreditRevalorizacija { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaGodina.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaGodina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaGodina.Sortable)]
        public Nullable<int> TemeljnicaGodina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaVrsta.Sortable)]
        public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaBroj.Sortable)]
        public Nullable<int> TemeljnicaBroj { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_Temeljnica.DisplayName)]
        //[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupZavrsetak.ID_Temeljnica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupZavrsetak.ID_Temeljnica.Sortable)]
        //public Nullable<long> ID_Temeljnica { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupZavrsetakGridFormatted()
        { }

        public UgovorStanOtkupZavrsetakGridFormatted(Model.Data.View.UgovorStanOtkupZavrsetak gridformated)
        {
            this.ID_UgovorStanOtkupZavrsetak = gridformated.ID_UgovorStanOtkupZavrsetak;
            this.ID_UgovorstanOtkup = gridformated.ID_UgovorstanOtkup;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.Datum = gridformated.Datum;
            this.DokumentVrsta = gridformated.DokumentVrsta;
            this.DokumentGrupa = gridformated.DokumentGrupa;
            this.ID_DokumentVr = gridformated.ID_DokumentVr;
            //this.Razlog = gridformated.Razlog;
            //this.ID_Subjekt = gridformated.ID_Subjekt;
            //this.IznosJednokratno = gridformated.IznosJednokratno;
            //this.IznosUcesce = gridformated.IznosUcesce;
            //this.IznosKamata = gridformated.IznosKamata;
            //this.IznosKredit = gridformated.IznosKredit;
            //this.IznosKamataRevalorizacija = gridformated.IznosKamataRevalorizacija;
            //this.IznosKreditRevalorizacija = gridformated.IznosKreditRevalorizacija;
            this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
            this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
            this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
            //this.ID_Temeljnica = gridformated.ID_Temeljnica;
        }

        #endregion
    }
}
