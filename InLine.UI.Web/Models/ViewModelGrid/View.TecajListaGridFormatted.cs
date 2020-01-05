
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


    public partial class TecajListaGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.TecajLista.ID_TecajLista.Required)]
        [DisplayName(AtributClass.TecajLista.ID_TecajLista.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajLista.ID_TecajLista.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.ID_TecajLista.Sortable)]
        public long ID_TecajLista { get; set; }

        [Required(ErrorMessage = AtributClass.TecajLista.ID_Banka.Required)]
        [DisplayName(AtributClass.TecajLista.ID_Banka.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajLista.ID_Banka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.ID_Banka.Sortable)]
        public long ID_Banka { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TecajLista.Datum.Required)]
        [DisplayName(AtributClass.TecajLista.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.TecajLista.Datum.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.Datum.Sortable)]
        public System.DateTime Datum { get; set; }

        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 70)]
        public Nullable<int> Dan { get; set; }

        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 70)]
        public Nullable<int> Mjesec { get; set; }

        [DisplayName(AtributClass.TecajLista.Godina.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 100)]
        [JqGridColumnFormatter(AtributClass.TecajLista.Godina.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.Godina.Sortable)]
        public Nullable<int> Godina { get; set; }

        [Required(ErrorMessage = AtributClass.TecajLista.RedniBroj.Required)]
        [DisplayName(AtributClass.TecajLista.RedniBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 100)]
        [JqGridColumnFormatter(AtributClass.TecajLista.RedniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.RedniBroj.Sortable)]
        public int RedniBroj { get; set; }

        [DisplayName(AtributClass.TecajLista.GodinaRedniBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right, Width = 100)]
        [JqGridColumnFormatter(AtributClass.TecajLista.GodinaRedniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajLista.GodinaRedniBroj.Sortable)]
        public Nullable<int> GodinaRedniBroj { get; set; }

        #endregion


        #region Constructor

        public TecajListaGridFormatted()
        { }

        public TecajListaGridFormatted(Model.Data.View.TecajLista gridformated)
        {
            this.ID_TecajLista = gridformated.ID_TecajLista;
            this.ID_Banka = gridformated.ID_Banka;
            this.Datum = gridformated.Datum;
            this.RedniBroj = gridformated.RedniBroj;
            this.Dan = gridformated.Datum.Day;
            this.Mjesec = gridformated.Datum.Month;
            this.Godina = gridformated.Godina;
            this.GodinaRedniBroj = gridformated.GodinaRedniBroj;
        }

        #endregion
    }

    public partial class TecajnaListaComboFormatted
    {
        public long? ID_Banka { get; set; }
    }
}
