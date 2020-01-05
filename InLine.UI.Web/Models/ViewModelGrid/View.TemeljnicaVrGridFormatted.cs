
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


    public partial class TemeljnicaVrGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.TemeljnicaVr.ID_TemeljnicaVr.Required)]
        [DisplayName(AtributClass.TemeljnicaVr.ID_TemeljnicaVr.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.ID_TemeljnicaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.ID_TemeljnicaVr.Sortable)]
        public long ID_TemeljnicaVr { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaVr.ID_GlavnaKnjiga.Required)]
        [DisplayName(AtributClass.TemeljnicaVr.ID_GlavnaKnjiga.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.ID_GlavnaKnjiga.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.ID_GlavnaKnjiga.Sortable)]
        public long ID_GlavnaKnjiga { get; set; }

        [StringLength(20, ErrorMessage = AtributClass.TemeljnicaVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVr.Oznaka.Required)]
        [DisplayName(AtributClass.TemeljnicaVr.Oznaka.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.Oznaka.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.Oznaka.Sortable)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVr.Naziv.Required)]
        [DisplayName(AtributClass.TemeljnicaVr.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.Naziv.Sortable)]
        public string Naziv { get; set; }


        //[StringLength(30, ErrorMessage = AtributClass.TemeljnicaVr.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaVr.NazivKr.Required)]
        //[DisplayName(AtributClass.TemeljnicaVr.NazivKr.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaVr.NazivKr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.NazivKr.Sortable)]
        //public string NazivKr { get; set; }


        //[StringLength(10, ErrorMessage = AtributClass.TemeljnicaVr.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaVr.Kratica.Required)]
        //[DisplayName(AtributClass.TemeljnicaVr.Kratica.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaVr.Kratica.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.Kratica.Sortable)]
        //public string Kratica { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaVr.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVr.IDValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaVr.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        //[Required(ErrorMessage = AtributClass.TemeljnicaVr.Tecaj.Required)]
        //[DisplayName(AtributClass.TemeljnicaVr.Tecaj.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.TemeljnicaVr.Tecaj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.Tecaj.Sortable)]
        //public decimal Tecaj { get; set; }

        [DisplayName(AtributClass.TemeljnicaVr.Opis.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.TemeljnicaVr.Opis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.TemeljnicaVr.Opis.Sortable)]
        public string Opis { get; set; }

        #endregion


        #region Constructor

        public TemeljnicaVrGridFormatted()
        { }

        public TemeljnicaVrGridFormatted(Model.Data.View.TemeljnicaVr gridformated)
        {
            this.ID_TemeljnicaVr = gridformated.ID_TemeljnicaVr;
            this.ID_GlavnaKnjiga = gridformated.ID_GlavnaKnjiga;
            this.Oznaka = gridformated.Oznaka;
            this.Naziv = gridformated.Naziv;
            //this.NazivKr = gridformated.NazivKr;
            //this.Kratica = gridformated.Kratica;
            this.IDValuta = gridformated.IDValuta;
            //this.Tecaj = gridformated.Tecaj;
            this.Opis = gridformated.Opis;
        }



        #endregion
    }
}
