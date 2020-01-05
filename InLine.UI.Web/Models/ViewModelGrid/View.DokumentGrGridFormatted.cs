﻿
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


    public partial class DokumentGrGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.DokumentGr.IDDokumentGr.Required)]
        [DisplayName(AtributClass.DokumentGr.IDDokumentGr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.IDDokumentGr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.IDDokumentGr.Sortable)]
        public int IDDokumentGr { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.DokumentGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentGr.Oznaka.Required)]
        [DisplayName(AtributClass.DokumentGr.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.DokumentGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentGr.Naziv.Required)]
        [DisplayName(AtributClass.DokumentGr.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.DokumentGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentGr.NazivKr.Required)]
        [DisplayName(AtributClass.DokumentGr.NazivKr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.NazivKr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.NazivKr.Sortable)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.DokumentGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentGr.Kratica.Required)]
        [DisplayName(AtributClass.DokumentGr.Kratica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.Kratica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.Kratica.Sortable)]
        public string Kratica { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.DokumentGr.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentGr.Opis.Required)]
        [DisplayName(AtributClass.DokumentGr.Opis.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.DokumentGr.Opis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.DokumentGr.Opis.Sortable)]
        public string Opis { get; set; }

        #endregion


        #region Constructor

        public DokumentGrGridFormatted()
        { }

        public DokumentGrGridFormatted(Model.Data.View.DokumentGr gridformated)
        {
            this.IDDokumentGr = gridformated.IDDokumentGr;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.NazivKr = gridformated.NazivKr;
            this.Kratica = gridformated.Kratica;
            this.Opis = gridformated.Opis;
        }

        #endregion
    }
}
