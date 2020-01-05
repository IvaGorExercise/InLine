
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


    public partial class TemeljnicaGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Temeljnica.ID_Temeljnica.Required)]
        [DisplayName(AtributClass.Temeljnica.ID_Temeljnica.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.ID_Temeljnica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.ID_Temeljnica.Sortable)]
        public long ID_Temeljnica { get; set; }

        [Required(ErrorMessage = AtributClass.Temeljnica.ID_TemeljnicaVr.Required)]
        [DisplayName(AtributClass.Temeljnica.ID_TemeljnicaVr.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.ID_TemeljnicaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.ID_TemeljnicaVr.Sortable)]
        public long ID_TemeljnicaVr { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.Temeljnica.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Temeljnica.Oznaka.Required)]
        [DisplayName(AtributClass.Temeljnica.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Oznaka.Sortable)]
        public string Oznaka { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.Temeljnica.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Temeljnica.Naziv.Required)]
        [DisplayName(AtributClass.Temeljnica.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Naziv.Sortable)]
        public string Naziv { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Temeljnica.Datum.Required)]
        [DisplayName(AtributClass.Temeljnica.Datum.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.JQueryUIDatepicker, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Datum.Sortable)]
        public System.DateTime Datum { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Temeljnica.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.Temeljnica.IDValuta.Required)]
        [DisplayName(AtributClass.Temeljnica.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.Temeljnica.Knjizeno.Required)]
        [DisplayName(AtributClass.Temeljnica.Knjizeno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Knjizeno.Sortable)]
        public bool Knjizeno { get; set; }

        [Required(ErrorMessage = AtributClass.Temeljnica.Storno.Required)]
        [DisplayName(AtributClass.Temeljnica.Storno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Storno.Sortable)]
        public bool Storno { get; set; }

        [Required(ErrorMessage = AtributClass.Temeljnica.PocetnoStanje.Required)]
        [DisplayName(AtributClass.Temeljnica.PocetnoStanje.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.PocetnoStanje.Sortable)]
        public bool PocetnoStanje { get; set; }

        [Required(ErrorMessage = AtributClass.Temeljnica.ZavrsnoKnjizenje.Required)]
        [DisplayName(AtributClass.Temeljnica.ZavrsnoKnjizenje.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.ZavrsnoKnjizenje.Sortable)]
        public bool ZavrsnoKnjizenje { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Temeljnica.DatumKnjizenje.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.DatumKnjizenje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.DatumKnjizenje.Sortable)]
        public Nullable<System.DateTime> DatumKnjizenje { get; set; }

        //[Required(ErrorMessage = AtributClass.Temeljnica.Tecaj.Required)]
        //[DisplayName(AtributClass.Temeljnica.Tecaj.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Temeljnica.Tecaj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Tecaj.Sortable)]
        //public decimal Tecaj { get; set; }



        //[DisplayName(AtributClass.Temeljnica.SumIznosDuguje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Temeljnica.SumIznosDuguje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Temeljnica.SumIznosDuguje.Sortable)]
        //public Nullable<decimal> SumIznosDuguje { get; set; }

        //[DisplayName(AtributClass.Temeljnica.SumIznosPotrazuje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Temeljnica.SumIznosPotrazuje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Temeljnica.SumIznosPotrazuje.Sortable)]
        //public Nullable<decimal> SumIznosPotrazuje { get; set; }

        //[DisplayName(AtributClass.Temeljnica.SumIznosDugujeValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Temeljnica.SumIznosDugujeValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Temeljnica.SumIznosDugujeValuta.Sortable)]
        //public Nullable<decimal> SumIznosDugujeValuta { get; set; }

        //[DisplayName(AtributClass.Temeljnica.SumIznosPotrazujeValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Temeljnica.SumIznosPotrazujeValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Temeljnica.SumIznosPotrazujeValuta.Sortable)]
        //public Nullable<decimal> SumIznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.Temeljnica.Saldo.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.Saldo.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.Saldo.Sortable)]
        public Nullable<decimal> Saldo { get; set; }

        [DisplayName(AtributClass.Temeljnica.SaldoValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Temeljnica.SaldoValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Temeljnica.SaldoValuta.Sortable)]
        public Nullable<decimal> SaldoValuta { get; set; }

        #endregion


        #region Constructor

        public TemeljnicaGridFormatted()
        { }

        public TemeljnicaGridFormatted(Model.Data.View.Temeljnica gridformated)
        {
            this.ID_Temeljnica = gridformated.ID_Temeljnica;
            this.ID_TemeljnicaVr = gridformated.ID_TemeljnicaVr;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.Datum = gridformated.Datum;
            this.IDValuta = gridformated.IDValuta;
            this.Knjizeno = gridformated.Knjizeno;
            this.Storno = gridformated.Storno;
            this.PocetnoStanje = gridformated.PocetnoStanje;
            this.ZavrsnoKnjizenje = gridformated.ZavrsnoKnjizenje;
            this.DatumKnjizenje = gridformated.DatumKnjizenje;
            //this.Tecaj = gridformated.Tecaj;
            //this.SumIznosDuguje = gridformated.SumIznosDuguje;
            //this.SumIznosPotrazuje = gridformated.SumIznosPotrazuje;
            //this.SumIznosDugujeValuta = gridformated.SumIznosDugujeValuta;
            //this.SumIznosPotrazujeValuta = gridformated.SumIznosPotrazujeValuta;
            this.Saldo = gridformated.Saldo;
            this.SaldoValuta = gridformated.SaldoValuta;
        }

        #endregion
    }
}
