
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


    public partial class PoslovnaGodinaPoslovniSubjektGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Sortable)]
        public long ID_PoslovnaGodina { get; set; }

        //[Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Required)]
        //[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.Sortable)]
        //public long ID_PoslovniSubjekt { get; set; }

        //[Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_Subjekt.Required)]
        //[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_Subjekt.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_Subjekt.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_Subjekt.Sortable)]
        //public long ID_Subjekt { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.StringLength)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.Sortable)]
        public string Oznaka { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.StringLength)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.Sortable)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.Sortable)]
        public int Godina { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.Sortable)]
        public System.DateTime DatumOd { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.Sortable)]
        public System.DateTime DatumDo { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.Sortable)]
        public string IDValuta { get; set; }


        // Rucno dodano polje
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        public string GodinaKrozGodina { get; set; }

        #endregion


        #region Constructor

        public PoslovnaGodinaPoslovniSubjektGridFormatted()
        { }

        public PoslovnaGodinaPoslovniSubjektGridFormatted(Model.Data.View.PoslovnaGodinaPoslovniSubjekt gridformated)
        {
            this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
            //this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
            //this.ID_Subjekt = gridformated.ID_Subjekt;
            this.Naziv = gridformated.Naziv;
            this.Godina = gridformated.Godina;
            this.DatumOd = gridformated.DatumOd;
            this.DatumDo = gridformated.DatumDo;
            this.IDValuta = gridformated.IDValuta;
            this.Oznaka = gridformated.Oznaka;
            this.GodinaKrozGodina = gridformated.DatumOd.Year.ToString() + "/" + gridformated.DatumDo.Year.ToString();
        }


        #endregion
    }
}
