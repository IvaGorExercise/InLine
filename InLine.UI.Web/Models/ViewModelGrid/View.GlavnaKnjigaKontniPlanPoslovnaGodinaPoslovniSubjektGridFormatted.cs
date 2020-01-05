

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


    public partial class GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga.Required)]
        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga.Sortable)]
        public long ID_GlavnaKnjiga { get; set; }

        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_KontniPlan.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_KontniPlan.Sortable)]
        public Nullable<long> ID_KontniPlan { get; set; }

        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Sortable)]
        //public long ID_PoslovnaGodina { get; set; }

        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Sortable)]
        //public long ID_PoslovniSubjekt { get; set; }


        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }

        
        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Godina.DisplayName)]
        [JqGridColumnSearchable(true)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Godina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Godina.Sortable)]
        public Nullable<int> Godina { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Naziv.StringLength)]
        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.OIB.StringLength)]
        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.OIB.Sortable)]
        public string OIB { get; set; }

        //[StringLength(3, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.IDValuta.StringLength)]
        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.IDValuta.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.IDValuta.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.IDValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.IDValuta.Sortable)]
        //public string IDValuta { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumOd.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumOd.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumOd.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumOd.Sortable)]
        //public System.DateTime DatumOd { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumDo.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumDo.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumDo.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.DatumDo.Sortable)]
        //public System.DateTime DatumDo { get; set; }

        //[Required(ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.AnalitikaOd.Required)]
        //[DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.AnalitikaOd.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.AnalitikaOd.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.AnalitikaOd.Sortable)]
        //public int AnalitikaOd { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Oznaka.StringLength)]
        [DisplayName(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.Oznaka.Sortable)]
        public string Oznaka { get; set; }



        #endregion


        #region Constructor

        public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGridFormatted()
        { }

        public GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGridFormatted(Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt gridformated)
        {
            this.ID_GlavnaKnjiga = gridformated.ID_GlavnaKnjiga;
            this.ID_KontniPlan = gridformated.ID_KontniPlan;
            //this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
            //this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            this.Naziv = gridformated.Naziv;
            this.OIB = gridformated.OIB;
            this.Godina = gridformated.Godina;
            //this.IDValuta = gridformated.IDValuta;
            //this.DatumOd = gridformated.DatumOd;
            //this.DatumDo = gridformated.DatumDo;
            //this.AnalitikaOd = gridformated.AnalitikaOd;
            this.Oznaka = gridformated.Oznaka;
        }


        #endregion
    }

    public partial class GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektComboFormatted
    {
        public long? ID_PoslovnaGodina { get; set; }
        public long ID_GlavnaKnjiga { get; set; }
        public long ID_KontniPlan { get; set; }
        public long ID_Subjekt { get; set; }
        public int Godina { get; set; }
        public string Naziv { get; set; }
        public Nullable<System.DateTime> DatumOd { get; set; }
        public Nullable<System.DateTime> DatumDo { get; set; }
        public long? ID_SubjektRacun { get; set; }
        public string RacunBroj { get; set; }
        public string RacunNaziv { get; set; }
        public string RacunVBDI { get; set; }
    }
}
