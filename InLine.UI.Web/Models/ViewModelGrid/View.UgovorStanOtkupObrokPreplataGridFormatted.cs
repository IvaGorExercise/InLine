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

namespace InLine.UI.Web.T4.GridFormattedTemplate.View
{

    public partial class UgovorStanOtkupObrokPreplataGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrokPreplata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupObrokPreplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkupObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 50)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.IznosPreplata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosPreplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Broj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Broj.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Broj.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> Broj { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.Aktivno.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public bool Aktivno { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokPreplata.BrojObrok.Sortable)]
        public Nullable<int> BrojObrok { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupObrokPreplataGridFormatted()
        { }

        public UgovorStanOtkupObrokPreplataGridFormatted(Model.Data.View.UgovorStanOtkupObrokPreplata gridformated)
        {
            this.ID_UgovorStanOtkupObrokPreplata = gridformated.ID_UgovorStanOtkupObrokPreplata;
            this.ID_UgovorStanOtkupObrok = gridformated.ID_UgovorStanOtkupObrok;
            this.Datum = gridformated.Datum;
            this.IznosPreplata = gridformated.IznosPreplata;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.Broj = gridformated.Broj;
            this.Aktivno = gridformated.Aktivno;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.BrojObrok = gridformated.BrojObrok;
        }


        #endregion
    }
}