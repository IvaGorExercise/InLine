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


    public partial class KontniPlanTemeljnicaVrGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr.Sortable)]
        public long ID_KontniPlanTemeljnicaVr { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_KontniPlan.Sortable)]
        public long ID_KontniPlan { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.IDTemeljnicaVrVr.Sortable)]
        public int IDTemeljnicaVrVr { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_TemeljnicaVr.Sortable)]
        public long ID_TemeljnicaVr { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.ID_GlavnaKnjiga.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.ID_GlavnaKnjiga.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.ID_GlavnaKnjiga.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.ID_GlavnaKnjiga.Sortable)]
        public long ID_GlavnaKnjiga { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.Oznaka.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.Naziv.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.OznakaTemeljnicaVrVr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.OznakaTemeljnicaVrVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.OznakaTemeljnicaVrVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.OznakaTemeljnicaVrVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.OznakaTemeljnicaVrVr.Sortable)]
        public string OznakaTemeljnicaVrVr { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.NazivTemeljnicaVrVr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.NazivTemeljnicaVrVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.NazivTemeljnicaVrVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.NazivTemeljnicaVrVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.NazivTemeljnicaVrVr.Sortable)]
        public string NazivTemeljnicaVrVr { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.NazivKrTemeljnicaVrVr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.NazivKrTemeljnicaVrVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.NazivKrTemeljnicaVrVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.NazivKrTemeljnicaVrVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.NazivKrTemeljnicaVrVr.Sortable)]
        public string NazivKrTemeljnicaVrVr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.KraticaTemeljnicaVrVr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanTemeljnicaVr.KraticaTemeljnicaVrVr.Required)]
        [DisplayName(AtributClass.KontniPlanTemeljnicaVr.KraticaTemeljnicaVrVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanTemeljnicaVr.KraticaTemeljnicaVrVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanTemeljnicaVr.KraticaTemeljnicaVrVr.Sortable)]
        public string KraticaTemeljnicaVrVr { get; set; }

        #endregion


        #region Constructor

        public KontniPlanTemeljnicaVrGridFormatted()
        { }

        public KontniPlanTemeljnicaVrGridFormatted(Model.Data.View.KontniPlanTemeljnicaVr gridformated)
        {
            this.ID_KontniPlanTemeljnicaVr = gridformated.ID_KontniPlanTemeljnicaVr;
            this.ID_KontniPlan = gridformated.ID_KontniPlan;
            this.IDTemeljnicaVrVr = gridformated.IDTemeljnicaVrVr;
            this.ID_TemeljnicaVr = gridformated.ID_TemeljnicaVr;
            this.ID_GlavnaKnjiga = gridformated.ID_GlavnaKnjiga;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.OznakaTemeljnicaVrVr = gridformated.OznakaTemeljnicaVrVr;
            this.NazivTemeljnicaVrVr = gridformated.NazivTemeljnicaVrVr;
            this.NazivKrTemeljnicaVrVr = gridformated.NazivKrTemeljnicaVrVr;
            this.KraticaTemeljnicaVrVr = gridformated.KraticaTemeljnicaVrVr;
        }

        #endregion
    }
}
