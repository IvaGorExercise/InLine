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
    public partial class UgovorStanOtkupTrosakGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkupTrosak.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkupTrosak.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkupTrosak.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkupTrosak.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupTrosak { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupTrosak.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupTrosak.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupTrosak.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupTrosak.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupTrosak.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupTrosak.Iznos.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupTrosak.Iznos.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> Iznos { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupTrosak.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupTrosak.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupTrosak.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojUgovor { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupTrosakGridFormatted()
        { }

        public UgovorStanOtkupTrosakGridFormatted(Model.Data.View.UgovorStanOtkupTrosak gridformated)
        {
            this.ID_UgovorStanOtkupTrosak = gridformated.ID_UgovorStanOtkupTrosak;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.Datum = gridformated.Datum;
            this.Iznos = gridformated.Iznos;
            this.BrojUgovor = gridformated.BrojUgovor;
        }

        /*
            mymodel.ID_UgovorStanOtkupTrosak = model.ID_UgovorStanOtkupTrosak;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.Datum = model.Datum;
            mymodel.Iznos = model.Iznos;
            mymodel.BrojUgovor = model.BrojUgovor;
    		
        */

        #endregion
    }
}