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


    public partial class TemeljnicaStGridFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.ID_TemeljnicaSt.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.ID_TemeljnicaSt.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.ID_TemeljnicaSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.ID_TemeljnicaSt.Sortable)]
        public long ID_TemeljnicaSt { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.ID_Temeljnica.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.ID_Temeljnica.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.ID_Temeljnica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.ID_Temeljnica.Sortable)]
        public long ID_Temeljnica { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.RedniBroj.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.RedniBroj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.RedniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.RedniBroj.Sortable)]
        public int RedniBroj { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaSt.KontniPlanStNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaSt.KontniPlanStNaziv.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.KontniPlanStNaziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.KontniPlanStNaziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.KontniPlanStNaziv.Sortable)]
        public string KontniPlanStNaziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaSt.Konto.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaSt.Konto.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.Konto.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.Konto.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.Konto.Sortable)]
        public string Konto { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TemeljnicaSt.Datum.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.Datum.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.JQueryUIDatepicker, SearchOperators= JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.Datum.Sortable)]
        public System.DateTime Datum { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.IznosDuguje.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [RegularExpression("^[0-9]{1,5}(\\.[0-9]{0,2})?$", ErrorMessage = "tocke")]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.IznosDuguje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.IznosDuguje.Sortable)]
        public decimal IznosDuguje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.IznosPotrazuje.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.IznosPotrazuje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.IznosPotrazuje.Sortable)]
        public decimal IznosPotrazuje { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaSt.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaSt.IDValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.IznosDugujeValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.IznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.IznosDugujeValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.IznosDugujeValuta.Sortable)]
        public decimal IznosDugujeValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.IznosPotrazujeValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.IznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.IznosPotrazujeValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.IznosPotrazujeValuta.Sortable)]
        public decimal IznosPotrazujeValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.Tecaj.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.Tecaj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.Tecaj.Sortable)]
        public decimal Tecaj { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaSt.ID_KontniPlanSt.Required)]
        [DisplayName(AtributClass.TemeljnicaSt.ID_KontniPlanSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaSt.ID_KontniPlanSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaSt.ID_KontniPlanSt.Sortable)]
        public long ID_KontniPlanSt { get; set; }

        #endregion


        #region Constructor

        public TemeljnicaStGridFormatted()
        { }

        public TemeljnicaStGridFormatted(Model.Data.View.TemeljnicaSt gridformated)
        {
            this.ID_TemeljnicaSt = gridformated.ID_TemeljnicaSt;
            this.ID_Temeljnica = gridformated.ID_Temeljnica;
            this.RedniBroj = gridformated.RedniBroj;
            this.KontniPlanStNaziv = gridformated.KontniPlanStNaziv;
            this.Datum = gridformated.Datum;
            this.IznosDuguje = gridformated.IznosDuguje;
            this.IznosPotrazuje = gridformated.IznosPotrazuje;
            this.IDValuta = gridformated.IDValuta;
            this.IznosDugujeValuta = gridformated.IznosDugujeValuta;
            this.IznosPotrazujeValuta = gridformated.IznosPotrazujeValuta;
            this.Tecaj = gridformated.Tecaj;
            this.ID_KontniPlanSt = gridformated.ID_KontniPlanSt;
            this.Konto = gridformated.Konto;
        }

        #endregion
    }
}