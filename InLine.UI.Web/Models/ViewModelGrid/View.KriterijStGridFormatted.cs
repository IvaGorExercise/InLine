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


    public partial class KriterijStGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.KriterijSt.ID_KriterijSt.Required)]
        [DisplayName(AtributClass.KriterijSt.ID_KriterijSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.ID_KriterijSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.ID_KriterijSt.Sortable)]
        public long ID_KriterijSt { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijSt.ID_Kriterij.Required)]
        [DisplayName(AtributClass.KriterijSt.ID_Kriterij.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.ID_Kriterij.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.ID_Kriterij.Sortable)]
        public long ID_Kriterij { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KriterijSt.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijSt.Oznaka.Required)]
        [DisplayName(AtributClass.KriterijSt.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KriterijSt.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijSt.Naziv.Required)]
        [DisplayName(AtributClass.KriterijSt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KriterijSt.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijSt.NazivKr.Required)]
        [DisplayName(AtributClass.KriterijSt.NazivKr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.NazivKr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.NazivKr.Sortable)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KriterijSt.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijSt.Kratica.Required)]
        [DisplayName(AtributClass.KriterijSt.Kratica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijSt.Kratica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijSt.Kratica.Sortable)]
        public string Kratica { get; set; }

        #endregion


        #region Constructor

        public KriterijStGridFormatted()
        { }

        public KriterijStGridFormatted(Model.Data.View.KriterijSt gridformated)
        {
            this.ID_KriterijSt = gridformated.ID_KriterijSt;
            this.ID_Kriterij = gridformated.ID_Kriterij;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.NazivKr = gridformated.NazivKr;
            this.Kratica = gridformated.Kratica;
        }

        #endregion
    }
}
