
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


    public partial class TemeljnicaStKontniPlanStGridFormatted
    {
        #region Properities
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlanSt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlanSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlanSt.Sortable)]
        public Nullable<long> ID_KontniPlanSt { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Naziv.StringLength)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Naziv.Sortable)]
        public string Naziv { get; set; }

        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_Temeljnica.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.ID_Temeljnica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.ID_Temeljnica.Sortable)]
        public long ID_Temeljnica { get; set; }

        //[Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.ID_TemeljnicaVr.Required)]
        //[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_TemeljnicaVr.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.ID_TemeljnicaVr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.ID_TemeljnicaVr.Sortable)]
        //public long ID_TemeljnicaVr { get; set; }

        //[Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.ID_GlavnaKnjiga.Required)]
        //[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_GlavnaKnjiga.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.ID_GlavnaKnjiga.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.ID_GlavnaKnjiga.Sortable)]
        //public long ID_GlavnaKnjiga { get; set; }

        //[Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.Required)]
        //[DisplayName(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.ID_KontniPlan.Sortable)]
        //public long ID_KontniPlan { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Konto.StringLength)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Konto.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Konto.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Konto.Sortable)]
        public string Konto { get; set; }


        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.SaldoKonti.Sortable)]
        public int SaldoKonti { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Zapis.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Zapis.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Zapis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Zapis.Sortable)]
        public int Zapis { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Subjekt.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Subjekt.Sortable)]
        public int Subjekt { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Objekt.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Objekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Objekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Objekt.Sortable)]
        public int Objekt { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.Davanje.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.Davanje.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.Davanje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.Davanje.Sortable)]
        public int Davanje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.Required)]
        [DisplayName(AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaStKontniPlanSt.AnalitikaOd.Sortable)]
        public int AnalitikaOd { get; set; }

        #endregion


        #region Constructor

        public TemeljnicaStKontniPlanStGridFormatted()
        { }

        public TemeljnicaStKontniPlanStGridFormatted(Model.Data.View.TemeljnicaStKontniPlanSt gridformated)
        {
            this.ID_KontniPlanSt = gridformated.ID_KontniPlanSt;
            this.Naziv = gridformated.Naziv;
            //this.ID_Temeljnica = gridformated.ID_Temeljnica;
            //this.ID_TemeljnicaVr = gridformated.ID_TemeljnicaVr;
            //this.ID_GlavnaKnjiga = gridformated.ID_GlavnaKnjiga;
            //this.ID_KontniPlan = gridformated.ID_KontniPlan;
            this.Konto = gridformated.Konto;
            this.SaldoKonti = gridformated.SaldoKonti;
            this.Zapis = gridformated.Zapis;
            this.Subjekt = gridformated.Subjekt;
            this.Objekt = gridformated.Objekt;
            this.Davanje = gridformated.Davanje;
            this.AnalitikaOd = gridformated.AnalitikaOd;
        }

        #endregion
    }
}
