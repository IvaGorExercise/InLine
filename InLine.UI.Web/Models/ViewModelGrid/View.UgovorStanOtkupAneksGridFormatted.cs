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
    public partial class UgovorStanOtkupAneksGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupAneks { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> Datum { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojUgovor.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojUgovor.Sortable)]
        public int BrojUgovor { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojAneks.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.BrojAneks.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojAneks.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojAneks.Sortable)]
        public int BrojAneks { get; set; }


        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.BrojStorno.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.BrojStorno.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojStorno.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojStorno.Sortable)]
        public int BrojStorno { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkupAneks.TecajDM.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TecajDM.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TecajDM.Sortable)]
        public Nullable<decimal> TecajDM { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaGodina.Sortable)]
        public Nullable<int> TemeljnicaGodina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaVrsta.Sortable)]
        public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.TemeljnicaBroj.Sortable)]
        public Nullable<int> TemeljnicaBroj { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.DokumentGrupa.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.DokumentGrupa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.DokumentGrupa.Sortable)]
        public Nullable<int> DokumentGrupa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.DokumentVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.DokumentVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.DokumentVrsta.Sortable)]
        public Nullable<int> DokumentVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.BrojObrokOd.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.BrojObrokOd.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.BrojObrokOd.Sortable)]
        public Nullable<int> BrojObrokOd { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.ID_DokumentVr.Sortable)]
        public Nullable<long> ID_DokumentVr { get; set; }


        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.Godina.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.Godina.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Godina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Godina.Sortable)]
        public int Godina { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneks.Mjesec.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneks.Mjesec.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupAneks.Mjesec.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupAneks.Mjesec.Sortable)]
        public int Mjesec { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupAneksGridFormatted()
        { }

        public UgovorStanOtkupAneksGridFormatted(Model.Data.View.UgovorStanOtkupAneks gridformated)
        {
            this.ID_UgovorStanOtkupAneks = gridformated.ID_UgovorStanOtkupAneks;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.BrojAneks = gridformated.BrojAneks;
            this.Datum = gridformated.Datum;
            this.BrojStorno = gridformated.BrojStorno;
            this.TecajDM = gridformated.TecajDM;
            this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
            this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
            this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
            this.DokumentGrupa = gridformated.DokumentGrupa;
            this.DokumentVrsta = gridformated.DokumentVrsta;
            this.BrojObrokOd = gridformated.BrojObrokOd;
            this.ID_DokumentVr = gridformated.ID_DokumentVr;
            this.Godina = gridformated.Godina;
            this.Mjesec = gridformated.Mjesec;
        }


        #endregion
    }
}