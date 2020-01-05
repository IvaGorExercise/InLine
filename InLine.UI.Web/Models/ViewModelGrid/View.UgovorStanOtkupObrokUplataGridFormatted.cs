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
    public partial class UgovorStanOtkupObrokUplataGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupObrokUplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrok.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrok.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.SumaUplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.SumaUplata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.SumaUplata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> SumaUplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.SumaZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.SumaZateznaKamata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.SumaZateznaKamata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> SumaZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataDugOstatak.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataDugOstatak.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosObrokDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.IznosObrokDugOstatak.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.IznosObrokDugOstatak.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosObrokDugOstatak { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojObrok.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrokUplata.BrojObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrokUplata.BrojObrok.Sortable)]
        public Nullable<int> BrojObrok { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupObrokUplataGridFormatted()
        { }

        public UgovorStanOtkupObrokUplataGridFormatted(Model.Data.View.UgovorStanOtkupObrokUplata gridformated)
        {
            this.ID_UgovorStanOtkupObrokUplata = gridformated.ID_UgovorStanOtkupObrokUplata;
            this.ID_UgovorStanOtkupObrok = gridformated.ID_UgovorStanOtkupObrok;
            this.Datum = gridformated.Datum;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.SumaUplata = gridformated.SumaUplata;
            this.SumaZateznaKamata = gridformated.SumaZateznaKamata;
            this.IznosZateznaKamataDugOstatak = gridformated.IznosZateznaKamataDugOstatak;
            this.IznosObrokDugOstatak = gridformated.IznosObrokDugOstatak;
            this.BrojObrok = gridformated.BrojObrok;
        }

        /*
            mymodel.ID_UgovorStanOtkupObrokUplata = model.ID_UgovorStanOtkupObrokUplata;
            mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
            mymodel.Datum = model.Datum;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.SumaUplata = model.SumaUplata;
            mymodel.SumaZateznaKamata = model.SumaZateznaKamata;
            mymodel.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
            mymodel.IznosObrokDugOstatak = model.IznosObrokDugOstatak;
            mymodel.BrojObrok = model.BrojObrok;
    		
        */

        #endregion
    }

}