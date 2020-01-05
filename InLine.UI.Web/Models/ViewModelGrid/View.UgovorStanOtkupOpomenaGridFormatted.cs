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

    public partial class UgovorStanOtkupOpomenaGridFormatted
    {
        #region Properities
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupOpomena.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> Datum { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkupOpomena.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkupOpomena.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkupOpomena.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkupOpomena.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkupOpomena { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.ID_Opomena.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.ID_Opomena.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.ID_Opomena.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_Opomena { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.BrojOpomena.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.BrojOpomena.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.BrojOpomena.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojOpomena { get; set; }


        [DisplayName("Pošalji na ispis")]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox, Disabled = false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center, Classes = "PosaljiNaIspis")]
        public Nullable<bool> PosaljiNaIspis { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkupOpomena.Ispis.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.Ispis.Sortable)]
        public Nullable<bool> Ispis { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<int> BrojUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.IznosDug.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.IznosDug.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.IznosDug.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosDug { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamataDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamataDugOstatak.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.IznosZateznaKamataDugOstatak.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }


        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.DatumInsert.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.DatumInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.DatumInsert.Sortable)]
        //public Nullable<System.DateTime> DatumInsert { get; set; }


        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomena.OsobaInsert.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.OsobaInsert.Sortable)]
        //public string OsobaInsert { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.DatumUpdate.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.DatumUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.DatumUpdate.Sortable)]
        //public Nullable<System.DateTime> DatumUpdate { get; set; }


        //[StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomena.OsobaUpdate.StringLength)]
        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.OsobaUpdate.Sortable)]
        //public string OsobaUpdate { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.ID_OsobaInsert.DisplayName)]
        //[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.ID_OsobaInsert.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.ID_OsobaInsert.Sortable)]
        //public Nullable<long> ID_OsobaInsert { get; set; }

        //[DisplayName(AtributClass.UgovorStanOtkupOpomena.ID_OsobaUpdate.DisplayName)]
        //[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.ID_OsobaUpdate.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.ID_OsobaUpdate.Sortable)]
        //public Nullable<long> ID_OsobaUpdate { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkupOpomena.SumaIznosDugZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupOpomena.SumaIznosDugZateznaKamata.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupOpomena.SumaIznosDugZateznaKamata.Sortable)]
        public Nullable<decimal> SumaIznosDugZateznaKamata { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupOpomenaGridFormatted()
        { }

        public UgovorStanOtkupOpomenaGridFormatted(Model.Data.View.UgovorStanOtkupOpomena gridformated)
        {
            this.Datum = gridformated.Datum;
            this.ID_UgovorStanOtkupOpomena = gridformated.ID_UgovorStanOtkupOpomena;
            this.ID_Opomena = gridformated.ID_Opomena;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.BrojOpomena = gridformated.BrojOpomena;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.IznosDug = gridformated.IznosDug;
            this.IznosZateznaKamata = gridformated.IznosZateznaKamata;
            this.IznosZateznaKamataDugOstatak = gridformated.IznosZateznaKamataDugOstatak;
            //this.DatumInsert = gridformated.DatumInsert;
            //this.OsobaInsert = gridformated.OsobaInsert;
            //this.DatumUpdate = gridformated.DatumUpdate;
            //this.OsobaUpdate = gridformated.OsobaUpdate;
            //this.ID_OsobaInsert = gridformated.ID_OsobaInsert;
            //this.ID_OsobaUpdate = gridformated.ID_OsobaUpdate;
            this.Ispis = gridformated.Ispis;
            this.SumaIznosDugZateznaKamata = gridformated.SumaIznosDugZateznaKamata;
        }

        /*
            mymodel.Datum = model.Datum;
            mymodel.ID_UgovorStanOtkupOpomena = model.ID_UgovorStanOtkupOpomena;
            mymodel.ID_Opomena = model.ID_Opomena;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.BrojOpomena = model.BrojOpomena;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.IznosDug = model.IznosDug;
            mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
            mymodel.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
            mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.Ispis = model.Ispis;
    	    mymodel.SumaIznosDugZateznaKamata = model.SumaIznosDugZateznaKamata;
    		
        */

        #endregion
    }
}