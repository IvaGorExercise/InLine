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

    public partial class KontniPlanGridFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KontniPlan.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlan.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_KontniPlan.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.ID_KontniPlan.Formatter)]
        public long ID_KontniPlan { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovnaGodina.Required)]
        [DisplayName(AtributClass.KontniPlan.ID_PoslovnaGodina.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_PoslovnaGodina.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.ID_PoslovnaGodina.Formatter)]
        public long ID_PoslovnaGodina { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlan.Godina.Required)]
        [DisplayName(AtributClass.KontniPlan.Godina.DisplayName)]
        [JqGridColumnSearchable(true)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.Godina.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.Godina.Formatter)]
        public int Godina { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumOd.Required)]
        [DisplayName(AtributClass.KontniPlan.DatumOd.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.DatumOd.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.DatumOd.Formatter)]
        public System.DateTime DatumOd { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.KontniPlan.DatumDo.Required)]
        [DisplayName(AtributClass.KontniPlan.DatumDo.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.DatumDo.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.DatumDo.Formatter)]
        public System.DateTime DatumDo { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.KontniPlan.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.Naziv.Required)]
        [DisplayName(AtributClass.KontniPlan.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.Naziv.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.Naziv.Formatter)]
        public string Naziv { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.KontniPlan.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlan.IDValuta.Required)]
        [DisplayName(AtributClass.KontniPlan.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.IDValuta.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.IDValuta.Formatter)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlan.AnalitikaOd.Required)]
        [DisplayName(AtributClass.KontniPlan.AnalitikaOd.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlan.AnalitikaOd.Sortable)]
        [JqGridColumnFormatter(AtributClass.KontniPlan.AnalitikaOd.Formatter)]
        public int AnalitikaOd { get; set; }

        //[Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovniSubjekt.Required)]
        //[DisplayName(AtributClass.KontniPlan.ID_PoslovniSubjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_PoslovniSubjekt.Sortable)]
        //[JqGridColumnFormatter(AtributClass.KontniPlan.ID_PoslovniSubjekt.Formatter)]
        //public long ID_PoslovniSubjekt { get; set; }

        //[Required(ErrorMessage = AtributClass.KontniPlan.ID_Subjekt.Required)]
        //[DisplayName(AtributClass.KontniPlan.ID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnSortable(true, Index = AtributClass.KontniPlan.ID_Subjekt.Sortable)]
        //[JqGridColumnFormatter(AtributClass.KontniPlan.ID_Subjekt.Formatter)]
        //public long ID_Subjekt { get; set; }




        #endregion


        #region Constructor

        public KontniPlanGridFormatted()
        { }

        public KontniPlanGridFormatted(Model.Data.View.KontniPlan gridformated)
        {
            this.AnalitikaOd = gridformated.AnalitikaOd;
            this.ID_KontniPlan = gridformated.ID_KontniPlan;
            this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
            this.Godina = gridformated.Godina;
            this.DatumOd = gridformated.DatumOd;
            this.DatumDo = gridformated.DatumDo;
            this.IDValuta = gridformated.IDValuta;
            //this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
            //this.ID_Subjekt = gridformated.ID_Subjekt;
            this.Naziv = gridformated.Naziv;
        }


        #endregion
    }


    public partial class KontniPlanComboFormatted
    {
        public long ID_KontniPlan { get; set; }
        public int Godina { get; set; }
        public string Naziv { get; set; }
    }
}
