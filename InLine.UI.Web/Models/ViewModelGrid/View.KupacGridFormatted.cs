
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


    public partial class KupacGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Kupac.ID_Kupac.Required)]
        [DisplayName(AtributClass.Kupac.ID_Kupac.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Kupac.ID_Kupac.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.ID_Kupac.Sortable)]
        public long ID_Kupac { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.Kupac.Oznaka.StringLength)]
        [DisplayName(AtributClass.Kupac.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left, Width = 90)]
        [JqGridColumnFormatter(AtributClass.Kupac.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Kupac.Naziv.StringLength)]
        [DisplayName(AtributClass.Kupac.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left, Width = 250)]
        [JqGridColumnFormatter(AtributClass.Kupac.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.Kupac.JMBG.StringLength)]
        [DisplayName(AtributClass.Kupac.JMBG.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.JMBG.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.JMBG.Sortable)]
        public string JMBG { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Kupac.Ulica.StringLength)]
        [DisplayName(AtributClass.Kupac.Ulica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left, Width = 250)]
        [JqGridColumnFormatter(AtributClass.Kupac.Ulica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.Ulica.Sortable)]
        public string Ulica { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Kupac.KucniBroj.StringLength)]
        [DisplayName(AtributClass.Kupac.KucniBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.KucniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.KucniBroj.Sortable)]
        public string KucniBroj { get; set; }


        [StringLength(2, ErrorMessage = AtributClass.Kupac.KucniBrojDodatak.StringLength)]
        [DisplayName(AtributClass.Kupac.KucniBrojDodatak.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.KucniBrojDodatak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.KucniBrojDodatak.Sortable)]
        public string KucniBrojDodatak { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.Kupac.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.Kupac.PostanskiBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.PostanskiBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.PostanskiBroj.Sortable)]
        public string PostanskiBroj { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.Kupac.OIB.StringLength)]
        [DisplayName(AtributClass.Kupac.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.OIB.Sortable)]
        public string OIB { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Kupac.Posta.StringLength)]
        [DisplayName(AtributClass.Kupac.Posta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Kupac.Posta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.Posta.Sortable)]
        public string Posta { get; set; }

        [DisplayName(AtributClass.Kupac.ID_Posta.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Kupac.ID_Posta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.ID_Posta.Sortable)]
        public Nullable<long> ID_Posta { get; set; }

        [DisplayName(AtributClass.Kupac.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Kupac.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Kupac.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }

        #endregion


        #region Constructor

        public KupacGridFormatted()
        { }

        public KupacGridFormatted(Model.Data.View.Kupac gridformated)
        {
            this.ID_Kupac = gridformated.ID_Kupac;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.JMBG = gridformated.JMBG;
            this.Ulica = gridformated.Ulica;
            this.KucniBroj = gridformated.KucniBroj;
            this.KucniBrojDodatak = gridformated.KucniBrojDodatak;
            this.PostanskiBroj = gridformated.PostanskiBroj;
            this.OIB = gridformated.OIB;
            this.Posta = gridformated.Posta;
            this.ID_Posta = gridformated.ID_Posta;
            this.ID_Subjekt = gridformated.ID_Subjekt;
        }


        #endregion
    }
}
