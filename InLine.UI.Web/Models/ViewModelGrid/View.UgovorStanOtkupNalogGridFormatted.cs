
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


    public partial class UgovorStanOtkupNalogGridFormatted
    {
        #region Properities
        [DisplayName(AtributClass.UgovorStanOtkupNalog.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }


        // rucno dodani property
        // Godina-Broj. kombinacija pojedinacnih propertija godina i broja koji su gore zakomentirani
        [DisplayName("Godina-Br.")]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(false, Index = AtributClass.UgovorStanOtkupNalog.GodinaNalog.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.GodinaNalog.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string GodinaNalogaBrojNaloga { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.DatumPlacanje.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.DatumPlacanje.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.DatumPlacanje.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> DatumPlacanje { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalog.Iznos.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.Iznos.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.Iznos.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public decimal Iznos { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalog.GodinaNalog.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.GodinaNalog.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.GodinaNalog.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.GodinaNalog.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public int GodinaNalog { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalog.BrojNalog.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.BrojNalog.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.BrojNalog.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.BrojNalog.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public int BrojNalog { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalog.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public int BrojUgovor { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalog.ID_Nalog.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupNalog.ID_Nalog.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupNalog.ID_Nalog.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupNalog.ID_Nalog.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_Nalog { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupNalogGridFormatted()
        { }

        public UgovorStanOtkupNalogGridFormatted(Model.Data.View.UgovorStanOtkupNalog gridformated)
        {
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.DatumPlacanje = gridformated.DatumPlacanje;
            this.Iznos = gridformated.Iznos;
            this.GodinaNalog = gridformated.GodinaNalog;
            this.BrojNalog = gridformated.BrojNalog;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.ID_Nalog = gridformated.ID_Nalog;
            // Rucno fgormatiranje propertija
            // Formatirani godina i broj naloga
            this.GodinaNalogaBrojNaloga = gridformated.GodinaNalog.ToString() + "-" + gridformated.BrojNalog.ToString();
        }

        #endregion
    }
}
