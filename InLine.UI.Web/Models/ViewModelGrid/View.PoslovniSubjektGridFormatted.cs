
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


    public partial class PoslovniSubjektGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.PoslovniSubjekt.ID_PoslovniSubjekt.Required)]
        [DisplayName(AtributClass.PoslovniSubjekt.ID_PoslovniSubjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.PoslovniSubjekt.ID_PoslovniSubjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovniSubjekt.ID_PoslovniSubjekt.Sortable)]
        public long ID_PoslovniSubjekt { get; set; }

        [Required(ErrorMessage = AtributClass.PoslovniSubjekt.ID_Subjekt.Required)]
        [DisplayName(AtributClass.PoslovniSubjekt.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.PoslovniSubjekt.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovniSubjekt.ID_Subjekt.Sortable)]
        public long ID_Subjekt { get; set; }

        [Required(ErrorMessage = AtributClass.PoslovniSubjekt.IDSubjekt.Required)]
        [DisplayName(AtributClass.PoslovniSubjekt.IDSubjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.PoslovniSubjekt.IDSubjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovniSubjekt.IDSubjekt.Sortable)]
        public long IDSubjekt { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.PoslovniSubjekt.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovniSubjekt.Oznaka.Required)]
        [DisplayName(AtributClass.PoslovniSubjekt.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.PoslovniSubjekt.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovniSubjekt.Oznaka.Sortable)]
        public string Oznaka { get; set; }

        [StringLength(255, ErrorMessage = AtributClass.PoslovniSubjekt.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovniSubjekt.Naziv.Required)]
        [DisplayName(AtributClass.PoslovniSubjekt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.PoslovniSubjekt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.PoslovniSubjekt.Naziv.Sortable)]
        public string Naziv { get; set; }


        #endregion


        #region Constructor

        public PoslovniSubjektGridFormatted()
        { }

        public PoslovniSubjektGridFormatted(Model.Data.View.PoslovniSubjekt gridformated)
        {
            this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            this.IDSubjekt = gridformated.IDSubjekt;
            this.Naziv = gridformated.Naziv;
            this.Oznaka = gridformated.Oznaka;
        }

        #endregion
    }
}
