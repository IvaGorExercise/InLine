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


    public partial class UgovorStanOtkupGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.ID_UgovorStanOtkup.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.ID_UgovorStanOtkup.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_UgovorStanOtkup.Sortable)]
        public long ID_UgovorStanOtkup { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.ID_Zapis.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_Zapis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_Zapis.Sortable)]
        public Nullable<long> ID_Zapis { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.BrojUgovor.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.BrojUgovor.Sortable)]
        public string BrojUgovor { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.BrojAneks.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.BrojAneks.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.BrojAneks.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.BrojAneks.Sortable)]
        public int BrojAneks { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkup.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.Datum.Sortable)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.ID_Stan.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_Stan.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_Stan.Sortable)]
        public Nullable<long> ID_Stan { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosUcesce.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosUcesce.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosUcesce.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosUcesce.Sortable)]
        //public decimal IznosUcesce { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosUcescePlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosUcescePlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosUcescePlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosUcescePlaceno.Sortable)]
        //public decimal IznosUcescePlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosUcesceNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosUcesceNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosUcesceNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosUcesceNeplaceno.Sortable)]
        //public decimal IznosUcesceNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKredit.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKredit.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKredit.Sortable)]
        public decimal IznosKredit { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKreditPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditPlaceno.Sortable)]
        //public decimal IznosKreditPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKreditNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditNeplaceno.Sortable)]
        //public decimal IznosKreditNeplaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacija.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacija.Sortable)]
        //public decimal IznosKreditRevalorizacija { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Sortable)]
        //public decimal IznosKreditRevalorizacijaPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Sortable)]
        //public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamata.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamata.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamata.Sortable)]
        public decimal IznosKamata { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKamataPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataPlaceno.Sortable)]
        //public decimal IznosKamataPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKamataNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataNeplaceno.Sortable)]
        //public decimal IznosKamataNeplaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacija.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacija.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacija.Sortable)]
        //public decimal IznosKamataRevalorizacija { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Sortable)]
        //public decimal IznosKamataRevalorizacijaPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Sortable)]
        //public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratno.Sortable)]
        //public decimal IznosJednokratno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratnoPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratnoPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratnoPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratnoPlaceno.Sortable)]
        //public decimal IznosJednokratnoPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratnoNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratnoNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratnoNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratnoNeplaceno.Sortable)]
        //public decimal IznosJednokratnoNeplaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratnoValuta.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratnoValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratnoValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratnoValuta.Sortable)]
        //public decimal IznosJednokratnoValuta { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratnoValutaPlaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratnoValutaPlaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratnoValutaPlaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratnoValutaPlaceno.Sortable)]
        //public decimal IznosJednokratnoValutaPlaceno { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosJednokratnoValutaNeplaceno.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Sortable)]
        //public decimal IznosJednokratnoValutaNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKreditObrok.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.IznosKreditObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKreditObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKreditObrok.Sortable)]
        public decimal IznosKreditObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosKamataObrok.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.IznosKamataObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosKamataObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosKamataObrok.Sortable)]
        public decimal IznosKamataObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosUkupnoObrok.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.IznosUkupnoObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosUkupnoObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosUkupnoObrok.Sortable)]
        public decimal IznosUkupnoObrok { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosTrosakSud.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosTrosakSud.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosTrosakSud.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosTrosakSud.Sortable)]
        //public decimal IznosTrosakSud { get; set; }

        //[Required(ErrorMessage = AtributClass.UgovorStanOtkup.IznosPovrat.Required)]
        //[DisplayName(AtributClass.UgovorStanOtkup.IznosPovrat.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IznosPovrat.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IznosPovrat.Sortable)]
        //public decimal IznosPovrat { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkup.IDValuta.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkup.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left, Width = 60)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.TecajDM.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 60)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.TecajDM.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.TecajDM.Sortable)]
        public Nullable<decimal> TecajDM { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumDospijeceJednokratno.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumDospijeceJednokratno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumDospijeceJednokratno.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceJednokratno { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumDospijeceUcesce.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumDospijeceUcesce.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumDospijeceUcesce.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceUcesce { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.BrojObrok.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.BrojObrok.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.BrojObrok.Sortable)]
        public Nullable<int> BrojObrok { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumDospijeceTrosakSud.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumDospijeceTrosakSud.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumDospijeceTrosakSud.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceTrosakSud { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkup.BrojObrokDospjelo.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.BrojObrokDospjelo.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.BrojObrokDospjelo.Sortable)]
        //public Nullable<int> BrojObrokDospjelo { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumDospijeceObrok.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumDospijeceObrok.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumDospijeceObrok.Sortable)]
        //public Nullable<System.DateTime> DatumDospijeceObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.Pretvorba.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.Pretvorba.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.Pretvorba.Sortable)]
        public bool Pretvorba { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.NadstojnickiAdaptiran.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.NadstojnickiAdaptiran.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center, Width = 60)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.NadstojnickiAdaptiran.Sortable)]
        public bool NadstojnickiAdaptiran { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkup.NeZateznaKamata.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.NeZateznaKamata.Sortable)]
        public Nullable<bool> NeZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.UgovorTuzen.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center, Width = 60)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.UgovorTuzen.Sortable)]
        public Nullable<bool> UgovorTuzen { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.OtkupNadstojnicki.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center )]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.OtkupNadstojnicki.Sortable)]
        public Nullable<bool> OtkupNadstojnicki { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkup.ID_UgovorStanOtkupStorno.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_UgovorStanOtkupStorno.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_UgovorStanOtkupStorno.Sortable)]
        //public Nullable<long> ID_UgovorStanOtkupStorno { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.TemeljnicaGodina.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.TemeljnicaGodina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.TemeljnicaGodina.Sortable)]
        public Nullable<int> TemeljnicaGodina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.TemeljnicaVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.TemeljnicaVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.TemeljnicaVrsta.Sortable)]
        public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.TemeljnicaBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.TemeljnicaBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.TemeljnicaBroj.Sortable)]
        public Nullable<int> TemeljnicaBroj { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.DokumentGrupa.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 70)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DokumentGrupa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DokumentGrupa.Sortable)]
        public Nullable<int> DokumentGrupa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkup.DokumentVrsta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 70)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DokumentVrsta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DokumentVrsta.Sortable)]
        public Nullable<int> DokumentVrsta { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumInsert.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumInsert.Sortable)]
        //public Nullable<System.DateTime> DatumInsert { get; set; }


        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkup.OsobaInsert.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkup.OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.OsobaInsert.Sortable)]
        //public string OsobaInsert { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkup.DatumUpdate.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.DatumUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.DatumUpdate.Sortable)]
        //public Nullable<System.DateTime> DatumUpdate { get; set; }


        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkup.OsobaUpdate.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkup.OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.OsobaUpdate.Sortable)]
        //public string OsobaUpdate { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkup.ID_OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_OsobaInsert.Sortable)]
        //public Nullable<long> ID_OsobaInsert { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkup.ID_OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_OsobaUpdate.Sortable)]
        //public Nullable<long> ID_OsobaUpdate { get; set; }


        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.Napomena.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.Napomena.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.Napomena.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.Napomena.Sortable)]
        public string Napomena { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkup.ID_DokumentVr.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.ID_DokumentVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.ID_DokumentVr.Sortable)]
        public Nullable<long> ID_DokumentVr { get; set; }


        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.StanID_Stan.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.StanID_Stan.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.StanID_Stan.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.StanID_Stan.Sortable)]
        public long StanID_Stan { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkup.Ulica.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkup.Ulica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.Ulica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.Ulica.Sortable)]
        public string Ulica { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkup.KucniBroj.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkup.KucniBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.KucniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.KucniBroj.Sortable)]
        public string KucniBroj { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkup.KucniBrojDodatak.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkup.KucniBrojDodatak.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.KucniBrojDodatak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.KucniBrojDodatak.Sortable)]
        public string KucniBrojDodatak { get; set; }


        // na kraj grida
        [Required(ErrorMessage = AtributClass.UgovorStanOtkup.BrojStorno.Required)]
        [DisplayName(AtributClass.UgovorStanOtkup.BrojStorno.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 80)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkup.BrojStorno.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkup.BrojStorno.Sortable)]
        public int BrojStorno { get; set; }







        #endregion


        #region Constructor

        public UgovorStanOtkupGridFormatted()
        { }

        public UgovorStanOtkupGridFormatted(Model.Data.View.UgovorStanOtkup gridformated)
        {
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.ID_Zapis = gridformated.ID_Zapis;
            this.BrojUgovor = gridformated.BrojUgovor.ToString(KeyWord.FormaterRazno.VodeceNule.VodeceNule7);
            this.BrojAneks = gridformated.BrojAneks;
            //this.BrojStorno = gridformated.BrojStorno;
            this.Datum = gridformated.Datum;
            this.ID_Stan = gridformated.ID_Stan;
            //this.IznosUcesce = gridformated.IznosUcesce;
            //this.IznosUcescePlaceno = gridformated.IznosUcescePlaceno;
            //this.IznosUcesceNeplaceno = gridformated.IznosUcesceNeplaceno;
            this.IznosKredit = gridformated.IznosKredit;
            //this.IznosKreditPlaceno = gridformated.IznosKreditPlaceno;
            //this.IznosKreditNeplaceno = gridformated.IznosKreditNeplaceno;
            //this.IznosKreditRevalorizacija = gridformated.IznosKreditRevalorizacija;
            //this.IznosKreditRevalorizacijaPlaceno = gridformated.IznosKreditRevalorizacijaPlaceno;
            //this.IznosKreditRevalorizacijaNeplaceno = gridformated.IznosKreditRevalorizacijaNeplaceno;
            this.IznosKamata = gridformated.IznosKamata;
            //this.IznosKamataPlaceno = gridformated.IznosKamataPlaceno;
            //this.IznosKamataNeplaceno = gridformated.IznosKamataNeplaceno;
            //this.IznosKamataRevalorizacija = gridformated.IznosKamataRevalorizacija;
            //this.IznosKamataRevalorizacijaPlaceno = gridformated.IznosKamataRevalorizacijaPlaceno;
            //this.IznosKamataRevalorizacijaNeplaceno = gridformated.IznosKamataRevalorizacijaNeplaceno;
            //this.IznosJednokratno = gridformated.IznosJednokratno;
            //this.IznosJednokratnoPlaceno = gridformated.IznosJednokratnoPlaceno;
            //this.IznosJednokratnoNeplaceno = gridformated.IznosJednokratnoNeplaceno;
            //this.IznosJednokratnoValuta = gridformated.IznosJednokratnoValuta;
            //this.IznosJednokratnoValutaPlaceno = gridformated.IznosJednokratnoValutaPlaceno;
            //this.IznosJednokratnoValutaNeplaceno = gridformated.IznosJednokratnoValutaNeplaceno;
            this.IznosKreditObrok = gridformated.IznosKreditObrok;
            this.IznosKamataObrok = gridformated.IznosKamataObrok;
            this.IznosUkupnoObrok = gridformated.IznosUkupnoObrok;
            //this.IznosTrosakSud = gridformated.IznosTrosakSud;
            //this.IznosPovrat = gridformated.IznosPovrat;
            this.IDValuta = gridformated.IDValuta;
            this.TecajDM = gridformated.TecajDM;
            //this.DatumDospijeceJednokratno = gridformated.DatumDospijeceJednokratno;
            //this.DatumDospijeceUcesce = gridformated.DatumDospijeceUcesce;
            this.BrojObrok = gridformated.BrojObrok;
            //this.DatumDospijeceTrosakSud = gridformated.DatumDospijeceTrosakSud;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            //this.BrojObrokDospjelo = gridformated.BrojObrokDospjelo;
            //this.DatumDospijeceObrok = gridformated.DatumDospijeceObrok;
            this.Pretvorba = gridformated.Pretvorba;
            this.Napomena = gridformated.Napomena;
            this.NadstojnickiAdaptiran = gridformated.NadstojnickiAdaptiran;
            //this.ID_UgovorStanOtkupStorno = gridformated.ID_UgovorStanOtkupStorno;
            this.TemeljnicaGodina = gridformated.TemeljnicaGodina;
            this.TemeljnicaVrsta = gridformated.TemeljnicaVrsta;
            this.TemeljnicaBroj = gridformated.TemeljnicaBroj;
            this.DokumentGrupa = gridformated.DokumentGrupa;
            this.DokumentVrsta = gridformated.DokumentVrsta;
            //this.DatumInsert = gridformated.DatumInsert;
            //this.OsobaInsert = gridformated.OsobaInsert;
            //this.DatumUpdate = gridformated.DatumUpdate;
            //this.OsobaUpdate = gridformated.OsobaUpdate;
            //this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
            //this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
            this.NeZateznaKamata = gridformated.NeZateznaKamata;
            this.UgovorTuzen = gridformated.UgovorTuzen;
            this.OtkupNadstojnicki = gridformated.OtkupNadstojnicki;
            this.ID_DokumentVr = gridformated.ID_DokumentVr;

            this.StanID_Stan = gridformated.StanID_Stan;
            this.Ulica = gridformated.Ulica;
            this.KucniBroj = gridformated.KucniBroj;
            this.KucniBrojDodatak = gridformated.KucniBrojDodatak;
        }

        /*
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.ID_Zapis = model.ID_Zapis;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.BrojAneks = model.BrojAneks;
            mymodel.BrojStorno = model.BrojStorno;
            mymodel.Datum = model.Datum;
            mymodel.ID_Stan = model.ID_Stan;
            mymodel.IznosUcesce = model.IznosUcesce;
            mymodel.IznosUcescePlaceno = model.IznosUcescePlaceno;
            mymodel.IznosUcesceNeplaceno = model.IznosUcesceNeplaceno;
            mymodel.IznosKredit = model.IznosKredit;
            mymodel.IznosKreditPlaceno = model.IznosKreditPlaceno;
            mymodel.IznosKreditNeplaceno = model.IznosKreditNeplaceno;
            mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
            mymodel.IznosKreditRevalorizacijaPlaceno = model.IznosKreditRevalorizacijaPlaceno;
            mymodel.IznosKreditRevalorizacijaNeplaceno = model.IznosKreditRevalorizacijaNeplaceno;
            mymodel.IznosKamata = model.IznosKamata;
            mymodel.IznosKamataPlaceno = model.IznosKamataPlaceno;
            mymodel.IznosKamataNeplaceno = model.IznosKamataNeplaceno;
            mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
            mymodel.IznosKamataRevalorizacijaPlaceno = model.IznosKamataRevalorizacijaPlaceno;
            mymodel.IznosKamataRevalorizacijaNeplaceno = model.IznosKamataRevalorizacijaNeplaceno;
            mymodel.IznosJednokratno = model.IznosJednokratno;
            mymodel.IznosJednokratnoPlaceno = model.IznosJednokratnoPlaceno;
            mymodel.IznosJednokratnoNeplaceno = model.IznosJednokratnoNeplaceno;
            mymodel.IznosJednokratnoValuta = model.IznosJednokratnoValuta;
            mymodel.IznosJednokratnoValutaPlaceno = model.IznosJednokratnoValutaPlaceno;
            mymodel.IznosJednokratnoValutaNeplaceno = model.IznosJednokratnoValutaNeplaceno;
            mymodel.IznosKreditObrok = model.IznosKreditObrok;
            mymodel.IznosKamataObrok = model.IznosKamataObrok;
            mymodel.IznosUkupnoObrok = model.IznosUkupnoObrok;
            mymodel.IznosTrosakSud = model.IznosTrosakSud;
            mymodel.IznosPovrat = model.IznosPovrat;
            mymodel.IDValuta = model.IDValuta;
            mymodel.TecajDM = model.TecajDM;
            mymodel.DatumDospijeceJednokratno = model.DatumDospijeceJednokratno;
            mymodel.DatumDospijeceUcesce = model.DatumDospijeceUcesce;
            mymodel.BrojObrok = model.BrojObrok;
            mymodel.DatumDospijeceTrosakSud = model.DatumDospijeceTrosakSud;
            mymodel.ID_Subjekt = model.ID_Subjekt;
            mymodel.BrojObrokDospjelo = model.BrojObrokDospjelo;
            mymodel.DatumDospijeceObrok = model.DatumDospijeceObrok;
            mymodel.Pretvorba = model.Pretvorba;
            mymodel.Napomena = model.Napomena;
            mymodel.NadstojnickiAdaptiran = model.NadstojnickiAdaptiran;
            mymodel.ID_UgovorStanOtkupStorno = model.ID_UgovorStanOtkupStorno;
            mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
            mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
            mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
            mymodel.DokumentGrupa = model.DokumentGrupa;
            mymodel.DokumentVrsta = model.DokumentVrsta;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.OsobaUpdate = model.OsobaUpdate;
            mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
            mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
            mymodel.NeZateznaKamata = model.NeZateznaKamata;
            mymodel.UgovorTuzen = model.UgovorTuzen;
            mymodel.OtkupNadstojnicki = model.OtkupNadstojnicki;
            mymodel.ID_DokumentVr = model.ID_DokumentVr;
    		
        */

        #endregion
    }
}
