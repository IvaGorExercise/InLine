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

    public partial class UgovorStanOtkupMoratorijGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public int BrojMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojUgovor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorij.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupMoratorij.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupMoratorij.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> Datum { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupMoratorijGridFormatted()
        { }

        public UgovorStanOtkupMoratorijGridFormatted(Model.Data.View.UgovorStanOtkupMoratorij gridformated)
        {
            this.ID_UgovorStanOtkupMoratorij = gridformated.ID_UgovorStanOtkupMoratorij;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.BrojMoratorij = gridformated.BrojMoratorij;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.Datum = gridformated.Datum;
        }

        /*
            mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.BrojMoratorij = model.BrojMoratorij;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.Datum = model.Datum;
    		
        */

        #endregion
    }
}
