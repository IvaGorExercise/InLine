
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


    public partial class KriterijStKriterijStKriterijStGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijSt.Sortable)]
        public long ID_KriterijSt { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_Kriterij.Sortable)]
        public long ID_Kriterij { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Naziv.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.Naziv.Sortable)]
        public string Naziv { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Oznaka.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.NazivKr.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.NazivKr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.NazivKr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.NazivKr.Sortable)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.Kratica.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Kratica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.Kratica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.Kratica.Sortable)]
        public string Kratica { get; set; }


        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKriterijSt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKriterijSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKriterijSt.Sortable)]
        public Nullable<long> ID_KriterijStKriterijSt { get; set; }

        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.Required)]
        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijKSKS.Sortable)]
        //public long ID_KriterijKSKS { get; set; }

        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.Required)]
        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStKSKS.Sortable)]
        //public long ID_KriterijStKSKS { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.ID_KriterijStNad.Sortable)]
        public long ID_KriterijStNad { get; set; }

        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Nivo.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.Nivo.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.Nivo.Sortable)]
        //public Nullable<int> Nivo { get; set; }

        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.Put.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.Put.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.Put.Sortable)]
        //public string Put { get; set; }

        //[StringLength(255, ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.StringLength)]
        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.Required)]
        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.KriterijNaziv.Sortable)]
        //public string KriterijNaziv { get; set; }

        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijSt.RedniBroj.Required)]
        //[DisplayName(AtributClass.KriterijStKriterijStKriterijSt.RedniBroj.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.KriterijStKriterijStKriterijSt.RedniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.KriterijStKriterijStKriterijSt.RedniBroj.Sortable)]
        //public int RedniBroj { get; set; }



        #endregion


        #region Constructor

        public KriterijStKriterijStKriterijStGridFormatted()
        { }

        public KriterijStKriterijStKriterijStGridFormatted(Model.Data.View.KriterijStKriterijStKriterijSt gridformated)
        {
            this.ID_KriterijSt = gridformated.ID_KriterijSt;
            this.ID_Kriterij = gridformated.ID_Kriterij;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            this.NazivKr = gridformated.NazivKr;
            this.Kratica = gridformated.Kratica;
            this.ID_KriterijStKriterijSt = gridformated.ID_KriterijStKriterijSt;
            //this.ID_KriterijKSKS = gridformated.ID_KriterijKSKS;
            //this.ID_KriterijStKSKS = gridformated.ID_KriterijStKSKS;
            this.ID_KriterijStNad = gridformated.ID_KriterijStNad;
            //this.Nivo = gridformated.Nivo;
            //this.Put = gridformated.Put;
            //this.KriterijNaziv = gridformated.KriterijNaziv;
            //this.RedniBroj = gridformated.RedniBroj;
        }

        #endregion
    }
}
