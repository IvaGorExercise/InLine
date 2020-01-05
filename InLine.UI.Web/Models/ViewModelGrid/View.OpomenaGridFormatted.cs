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


    public partial class OpomenaGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Opomena.ID_Opomena.Required)]
        [DisplayName(AtributClass.Opomena.ID_Opomena.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.ID_Opomena.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.ID_Opomena.Sortable)]
        public long ID_Opomena { get; set; }

        [DisplayName(AtributClass.Opomena.ID_Zapis.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.ID_Zapis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.ID_Zapis.Sortable)]
        public Nullable<long> ID_Zapis { get; set; }

        [Required(ErrorMessage = AtributClass.Opomena.BrojOpomena.Required)]
        [DisplayName(AtributClass.Opomena.BrojOpomena.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.BrojOpomena.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.BrojOpomena.Sortable)]
        public int BrojOpomena { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Opomena.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Opomena.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.Datum.Sortable)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.Opomena.BrojNeplaceniObrokMin.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.BrojNeplaceniObrokMin.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.BrojNeplaceniObrokMin.Sortable)]
        public Nullable<int> BrojNeplaceniObrokMin { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Opomena.DatumDospijeceOd.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Opomena.DatumDospijeceOd.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.DatumDospijeceOd.Sortable)]
        public Nullable<System.DateTime> DatumDospijeceOd { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Opomena.DatumDospijeceDo.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Opomena.DatumDospijeceDo.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.DatumDospijeceDo.Sortable)]
        public Nullable<System.DateTime> DatumDospijeceDo { get; set; }

 
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Opomena.DatumInsert.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Opomena.DatumInsert.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.DatumInsert.Sortable)]
        public Nullable<System.DateTime> DatumInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Opomena.DatumUpdate.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Opomena.DatumUpdate.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.DatumUpdate.Sortable)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }

        [DisplayName(AtributClass.Opomena.ID_OsobaInsert.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.ID_OsobaInsert.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.ID_OsobaInsert.Sortable)]
        public Nullable<long> ID_OsobaInsert { get; set; }

        [DisplayName(AtributClass.Opomena.ID_OsobaUpdate.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.ID_OsobaUpdate.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.ID_OsobaUpdate.Sortable)]
        public Nullable<long> ID_OsobaUpdate { get; set; }

        [DisplayName(AtributClass.Opomena.OpomenaIznosMin.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Opomena.OpomenaIznosMin.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.OpomenaIznosMin.Sortable)]
        public Nullable<decimal> OpomenaIznosMin { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.Opomena.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.Opomena.OsobaInsert.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Opomena.OsobaInsert.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.OsobaInsert.Sortable)]
        public string OsobaInsert { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.Opomena.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.Opomena.OsobaUpdate.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Opomena.OsobaUpdate.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Opomena.OsobaUpdate.Sortable)]
        public string OsobaUpdate { get; set; }

        #endregion


        #region Constructor

        public OpomenaGridFormatted()
        { }

        public OpomenaGridFormatted(Model.Data.View.Opomena gridformated)
        {
            this.ID_Opomena = gridformated.ID_Opomena;
            this.ID_Zapis = gridformated.ID_Zapis;
            this.BrojOpomena = gridformated.BrojOpomena;
            this.Datum = gridformated.Datum;
            this.BrojNeplaceniObrokMin = gridformated.BrojNeplaceniObrokMin;
            this.DatumDospijeceDo = gridformated.DatumDospijeceDo;
            this.DatumDospijeceOd = gridformated.DatumDospijeceOd;
            this.DatumInsert = gridformated.DatumInsert;
            this.DatumUpdate = gridformated.DatumUpdate;
            this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
            this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
            this.OpomenaIznosMin = gridformated.OpomenaIznosMin;
            this.OsobaInsert = gridformated.OsobaInsert;
            this.OsobaUpdate = gridformated.OsobaUpdate;
        }

        /*
            mymodel.ID_Opomena = model.ID_Opomena;
            mymodel.ID_Zapis = model.ID_Zapis;
            mymodel.BrojOpomena = model.BrojOpomena;
            mymodel.Datum = model.Datum;
            mymodel.BrojNeplaceniObrokMin = model.BrojNeplaceniObrokMin;
            mymodel.DatumDospijeceDo = model.DatumDospijeceDo;
            mymodel.DatumDospijeceOd = model.DatumDospijeceOd;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
            mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
            mymodel.OpomenaIznosMin = model.OpomenaIznosMin;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.OsobaUpdate = model.OsobaUpdate;
    		
        */

        #endregion
    }
}
