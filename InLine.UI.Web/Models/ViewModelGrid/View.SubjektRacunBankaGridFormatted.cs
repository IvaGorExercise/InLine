
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


    public partial class SubjektRacunBankaGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.ID_SubjektRacun.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.ID_SubjektRacun.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.ID_SubjektRacun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.ID_SubjektRacun.Sortable)]
        public long ID_SubjektRacun { get; set; }

        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.ID_Subjekt.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.ID_Subjekt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.ID_Subjekt.Sortable)]
        public long ID_Subjekt { get; set; }

        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.ID_Banka.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.ID_Banka.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.ID_Banka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.ID_Banka.Sortable)]
        public long ID_Banka { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.SubjektRacunBanka.Broj.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.Broj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.Broj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Broj.Sortable)]
        public string Broj { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.SubjektRacunBanka.BankaOznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.BankaOznaka.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.BankaOznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.BankaOznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.BankaOznaka.Sortable)]
        public string BankaOznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.SubjektRacunBanka.BankaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.BankaNaziv.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.BankaNaziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.BankaNaziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.BankaNaziv.Sortable)]
        public string BankaNaziv { get; set; }


        [StringLength(7, ErrorMessage = AtributClass.SubjektRacunBanka.VBDI.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.VBDI.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.VBDI.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.VBDI.Sortable)]
        public string VBDI { get; set; }


        [StringLength(34, ErrorMessage = AtributClass.SubjektRacunBanka.IBAN.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.IBAN.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.IBAN.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.IBAN.Sortable)]
        public string IBAN { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.SubjektRacunBanka.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.Naziv.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.SubjektRacunBanka.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.Opis.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.Opis.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.Opis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Opis.Sortable)]
        public string Opis { get; set; }


        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.Devizni.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.Devizni.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Devizni.Sortable)]
        public bool Devizni { get; set; }

        [DisplayName(AtributClass.SubjektRacunBanka.RedniBroj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.RedniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.RedniBroj.Sortable)]
        public Nullable<int> RedniBroj { get; set; }

        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.BankaID_Banka.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.BankaID_Banka.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.BankaID_Banka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.BankaID_Banka.Sortable)]
        public long BankaID_Banka { get; set; }

        [DisplayName(AtributClass.SubjektRacunBanka.BankaID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.BankaID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.BankaID_Subjekt.Sortable)]
        public Nullable<long> BankaID_Subjekt { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.SubjektRacunBanka.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.NazivKr.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.NazivKr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.NazivKr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.NazivKr.Sortable)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.SubjektRacunBanka.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektRacunBanka.Kratica.Required)]
        [DisplayName(AtributClass.SubjektRacunBanka.Kratica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.Kratica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Kratica.Sortable)]
        public string Kratica { get; set; }


        [StringLength(7, ErrorMessage = AtributClass.SubjektRacunBanka.BankaVBDI.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.BankaVBDI.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.BankaVBDI.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.BankaVBDI.Sortable)]
        public string BankaVBDI { get; set; }


        [StringLength(8, ErrorMessage = AtributClass.SubjektRacunBanka.Swift.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.Swift.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.Swift.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.Swift.Sortable)]
        public string Swift { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.SubjektRacunBanka.DealingCode.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.DealingCode.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.DealingCode.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.DealingCode.Sortable)]
        public string DealingCode { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.SubjektRacunBanka.FINAModel.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.FINAModel.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.FINAModel.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.FINAModel.Sortable)]
        public string FINAModel { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.SubjektRacunBanka.OIB.StringLength)]
        [DisplayName(AtributClass.SubjektRacunBanka.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.SubjektRacunBanka.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.SubjektRacunBanka.OIB.Sortable)]
        public string OIB { get; set; }

        #endregion


        #region Constructor

        public SubjektRacunBankaGridFormatted()
        { }

        public SubjektRacunBankaGridFormatted(Model.Data.View.SubjektRacunBanka gridformated)
        {
            this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            this.ID_Banka = gridformated.ID_Banka;
            this.Broj = gridformated.Broj;
            this.VBDI = gridformated.VBDI;
            this.IBAN = gridformated.IBAN;
            this.Devizni = gridformated.Devizni;
            this.Naziv = gridformated.Naziv;
            this.Opis = gridformated.Opis;
            this.RedniBroj = gridformated.RedniBroj;
            this.BankaID_Banka = gridformated.BankaID_Banka;
            this.BankaID_Subjekt = gridformated.BankaID_Subjekt;
            this.BankaOznaka = gridformated.BankaOznaka;
            this.BankaNaziv = gridformated.BankaNaziv;
            this.NazivKr = gridformated.NazivKr;
            this.Kratica = gridformated.Kratica;
            this.BankaVBDI = gridformated.BankaVBDI;
            this.Swift = gridformated.Swift;
            this.DealingCode = gridformated.DealingCode;
            this.FINAModel = gridformated.FINAModel;
            this.OIB = gridformated.OIB;
        }

        #endregion
    }
}
