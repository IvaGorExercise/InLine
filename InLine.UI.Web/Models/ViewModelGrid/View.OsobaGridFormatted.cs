
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


    public partial class OsobaGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Osoba.ID_Osoba.Required)]
        [DisplayName(AtributClass.Osoba.ID_Osoba.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Osoba.ID_Osoba.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Osoba.Sortable)]
        public long ID_Osoba { get; set; }

        [DisplayName(AtributClass.Osoba.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Osoba.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.Osoba.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Oznaka.Required)]
        [DisplayName(AtributClass.Osoba.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.Oznaka.Sortable)]
        public string Oznaka { get; set; }

        [StringLength(50, ErrorMessage = AtributClass.Osoba.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Prezime.Required)]
        [DisplayName(AtributClass.Osoba.Prezime.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.Prezime.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.Prezime.Sortable)]
        public string Prezime { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Osoba.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Ime.Required)]
        [DisplayName(AtributClass.Osoba.Ime.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.Ime.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.Ime.Sortable)]
        public string Ime { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Osoba.DatumRodenja.Required)]
        [DisplayName(AtributClass.Osoba.DatumRodenja.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Osoba.DatumRodenja.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.DatumRodenja.Sortable)]
        public System.DateTime DatumRodenja { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Osoba.MjestoRodenja.StringLength)]
        [DisplayName(AtributClass.Osoba.MjestoRodenja.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.MjestoRodenja.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.MjestoRodenja.Sortable)]
        public string MjestoRodenja { get; set; }

        [DisplayName(AtributClass.Osoba.ID_Narodnost.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Osoba.ID_Narodnost.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Narodnost.Sortable)]
        public Nullable<long> ID_Narodnost { get; set; }

        [DisplayName(AtributClass.Osoba.ID_Drzavljanstvo.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Osoba.ID_Drzavljanstvo.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_Drzavljanstvo.Sortable)]
        public Nullable<long> ID_Drzavljanstvo { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIB.StringLength)]
        [DisplayName(AtributClass.Osoba.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.OIB.Sortable)]
        public string OIB { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.Osoba.JMBG.StringLength)]
        [DisplayName(AtributClass.Osoba.JMBG.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.JMBG.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.JMBG.Sortable)]
        public string JMBG { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIBHR.StringLength)]
        [DisplayName(AtributClass.Osoba.OIBHR.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.OIBHR.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.OIBHR.Sortable)]
        public string OIBHR { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.Osoba.OtacIme.StringLength)]
        //[DisplayName(AtributClass.Osoba.OtacIme.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Osoba.OtacIme.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Osoba.OtacIme.Sortable)]
        //public string OtacIme { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezime.StringLength)]
        //[DisplayName(AtributClass.Osoba.MajkaPrezime.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Osoba.MajkaPrezime.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaPrezime.Sortable)]
        //public string MajkaPrezime { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaIme.StringLength)]
        //[DisplayName(AtributClass.Osoba.MajkaIme.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Osoba.MajkaIme.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaIme.Sortable)]
        //public string MajkaIme { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezimeDjevojacko.StringLength)]
        //[DisplayName(AtributClass.Osoba.MajkaPrezimeDjevojacko.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Osoba.MajkaPrezimeDjevojacko.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Osoba.MajkaPrezimeDjevojacko.Sortable)]
        //public string MajkaPrezimeDjevojacko { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.Osoba.NazivDrzavljanstvo.StringLength)]
        [DisplayName(AtributClass.Osoba.NazivDrzavljanstvo.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.DrzavljanstvoFilter, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.NazivDrzavljanstvo.Formatter)]
        [JqGridColumnSortable(true, Index = InLine.Model.Data.FieldString.View.Osoba.ID_Drzavljanstvo)]
        public string NazivDrzavljanstvo { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Osoba.NazivNarodnost.StringLength)]
        [DisplayName(AtributClass.Osoba.NazivNarodnost.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.NarodnostFilter, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Osoba.NazivNarodnost.Formatter)]
        [JqGridColumnSortable(true, Index = InLine.Model.Data.FieldString.View.Osoba.ID_Narodnost)]
        public string NazivNarodnost { get; set; }


        [DisplayName(AtributClass.Osoba.ID_PoslovniSubjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Osoba.ID_PoslovniSubjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Osoba.ID_PoslovniSubjekt.Sortable)]
        public Nullable<long> ID_PoslovniSubjekt { get; set; }


        #endregion


        #region Constructor

        public OsobaGridFormatted()
        { }

        public OsobaGridFormatted(Model.Data.View.Osoba gridformated)
        {
            this.ID_Osoba = gridformated.ID_Osoba;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            this.Prezime = gridformated.Prezime;
            this.Ime = gridformated.Ime;
            this.DatumRodenja = gridformated.DatumRodenja;
            this.MjestoRodenja = gridformated.MjestoRodenja;
            this.ID_Narodnost = gridformated.ID_Narodnost;
            this.ID_Drzavljanstvo = gridformated.ID_Drzavljanstvo;
            this.OIB = gridformated.OIB;
            this.OIBHR = gridformated.OIBHR;
            //this.OtacIme = gridformated.OtacIme;
            //this.MajkaPrezime = gridformated.MajkaPrezime;
            //this.MajkaIme = gridformated.MajkaIme;
            //this.MajkaPrezimeDjevojacko = gridformated.MajkaPrezimeDjevojacko;
            this.NazivDrzavljanstvo = gridformated.NazivDrzavljanstvo;
            this.NazivNarodnost = gridformated.NazivNarodnost;
            this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
            this.Oznaka = gridformated.Oznaka;
            this.JMBG = gridformated.JMBG;
        }

        #endregion
    }
}
