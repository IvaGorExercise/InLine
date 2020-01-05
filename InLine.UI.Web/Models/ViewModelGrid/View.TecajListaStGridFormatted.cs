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


    public partial class TecajListaStGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.TecajListaSt.ID_TecajListaSt.Required)]
        [DisplayName(AtributClass.TecajListaSt.ID_TecajListaSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajListaSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajListaSt.Sortable)]
        public long ID_TecajListaSt { get; set; }

        [Required(ErrorMessage = AtributClass.TecajListaSt.ID_TecajLista.Required)]
        [DisplayName(AtributClass.TecajListaSt.ID_TecajLista.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajLista.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajLista.Sortable)]
        public long ID_TecajLista { get; set; }


        //[StringLength(2, ErrorMessage = AtributClass.TecajListaSt.IDDrzavaIz.StringLength)]
        //[Required(ErrorMessage = AtributClass.TecajListaSt.IDDrzavaIz.Required)]
        //[DisplayName(AtributClass.TecajListaSt.IDDrzavaIz.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.TecajListaSt.IDDrzavaIz.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDDrzavaIz.Sortable)]
        //public string IDDrzavaIz { get; set; }


        //[StringLength(2, ErrorMessage = AtributClass.TecajListaSt.IDDrzavaU.StringLength)]
        //[Required(ErrorMessage = AtributClass.TecajListaSt.IDDrzavaU.Required)]
        //[DisplayName(AtributClass.TecajListaSt.IDDrzavaU.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.TecajListaSt.IDDrzavaU.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDDrzavaU.Sortable)]
        //public string IDDrzavaU { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TecajListaSt.IDValutaIz.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDValutaIz.Required)]
        [DisplayName(AtributClass.TecajListaSt.IDValutaIz.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.IDValutaIz.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDValutaIz.Sortable)]
        public string IDValutaIz { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TecajListaSt.IDValutaU.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaSt.IDValutaU.Required)]
        [DisplayName(AtributClass.TecajListaSt.IDValutaU.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.IDValutaU.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.IDValutaU.Sortable)]
        public string IDValutaU { get; set; }

        [Required(ErrorMessage = AtributClass.TecajListaSt.BrojJedinica.Required)]
        [DisplayName(AtributClass.TecajListaSt.BrojJedinica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.BrojJedinica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.BrojJedinica.Sortable)]
        public int BrojJedinica { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajSD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajSD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajSD.Sortable)]
        public Nullable<long> ID_TecajSD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajVrSD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajVrSD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajVrSD.Sortable)]
        public Nullable<long> ID_TecajVrSD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.TecajSD.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.TecajSD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.TecajSD.Sortable)]
        public Nullable<decimal> TecajSD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajKD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajKD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajKD.Sortable)]
        public Nullable<long> ID_TecajKD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajVrKD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajVrKD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajVrKD.Sortable)]
        public Nullable<long> ID_TecajVrKD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.TecajKD.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.TecajKD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.TecajKD.Sortable)]
        public Nullable<decimal> TecajKD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajPD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajPD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajPD.Sortable)]
        public Nullable<long> ID_TecajPD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajVrPD.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajVrPD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajVrPD.Sortable)]
        public Nullable<long> ID_TecajVrPD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.TecajPD.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.TecajPD.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.TecajPD.Sortable)]
        public Nullable<decimal> TecajPD { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajKE.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajKE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajKE.Sortable)]
        public Nullable<long> ID_TecajKE { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajVrKE.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajVrKE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajVrKE.Sortable)]
        public Nullable<long> ID_TecajVrKE { get; set; }

        [DisplayName(AtributClass.TecajListaSt.TecajKE.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.TecajKE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.TecajKE.Sortable)]
        public Nullable<decimal> TecajKE { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajPE.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajPE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajPE.Sortable)]
        public Nullable<long> ID_TecajPE { get; set; }

        [DisplayName(AtributClass.TecajListaSt.ID_TecajVrPE.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.ID_TecajVrPE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.ID_TecajVrPE.Sortable)]
        public Nullable<long> ID_TecajVrPE { get; set; }

        [DisplayName(AtributClass.TecajListaSt.TecajPE.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TecajListaSt.TecajPE.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TecajListaSt.TecajPE.Sortable)]
        public Nullable<decimal> TecajPE { get; set; }

        #endregion


        #region Constructor

        public TecajListaStGridFormatted()
        { }

        public TecajListaStGridFormatted(Model.Data.View.TecajListaSt gridformated)
        {
            this.ID_TecajListaSt = gridformated.ID_TecajListaSt;
            this.ID_TecajLista = gridformated.ID_TecajLista;
            //this.IDDrzavaIz = gridformated.IDDrzavaIz;
            //this.IDDrzavaU = gridformated.IDDrzavaU;
            this.IDValutaIz = gridformated.IDValutaIz;
            this.IDValutaU = gridformated.IDValutaU;
            this.BrojJedinica = gridformated.BrojJedinica;
            this.ID_TecajSD = gridformated.ID_TecajSD;
            this.ID_TecajVrSD = gridformated.ID_TecajVrSD;
            this.TecajSD = gridformated.TecajSD;
            this.ID_TecajKD = gridformated.ID_TecajKD;
            this.ID_TecajVrKD = gridformated.ID_TecajVrKD;
            this.TecajKD = gridformated.TecajKD;
            this.ID_TecajPD = gridformated.ID_TecajPD;
            this.ID_TecajVrPD = gridformated.ID_TecajVrPD;
            this.TecajPD = gridformated.TecajPD;
            this.ID_TecajKE = gridformated.ID_TecajKE;
            this.ID_TecajVrKE = gridformated.ID_TecajVrKE;
            this.TecajKE = gridformated.TecajKE;
            this.ID_TecajPE = gridformated.ID_TecajPE;
            this.ID_TecajVrPE = gridformated.ID_TecajVrPE;
            this.TecajPE = gridformated.TecajPE;
        }

        #endregion
    }
}
