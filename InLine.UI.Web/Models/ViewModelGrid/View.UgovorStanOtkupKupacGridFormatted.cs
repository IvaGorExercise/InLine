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


namespace InLine.UI.Web.T4.GridFormattedTemplate.View
{
    public partial class UgovorStanOtkupKupacGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_Kupac.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.ID_Kupac.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_Kupac.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_Kupac.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_Kupac { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupac.Naziv.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.Naziv.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.Naziv.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkup { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public int BrojUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkupKupac { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.JMBG.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.JMBG.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.JMBG.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.JMBG.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string JMBG { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.OIB.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupac.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.OIB.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.OIB.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string OIB { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkupKupac.Nositelj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.Nositelj.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.Nositelj.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<bool> Nositelj { get; set; }

        #endregion

        #region Constructor

        public UgovorStanOtkupKupacGridFormatted()
        { }

        public UgovorStanOtkupKupacGridFormatted(Model.Data.View.UgovorStanOtkupKupac gridformated)
        {
            this.ID_Kupac = gridformated.ID_Kupac;
            this.Naziv = gridformated.Naziv;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.BrojUgovor = gridformated.BrojUgovor;
            this.ID_UgovorStanOtkupKupac = gridformated.ID_UgovorStanOtkupKupac;
            this.JMBG = gridformated.JMBG;
            this.OIB = gridformated.OIB;
            this.Nositelj = gridformated.Nositelj;
        }

        /*
            mymodel.ID_Kupac = model.ID_Kupac;
            mymodel.Naziv = model.Naziv;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
            mymodel.JMBG = model.JMBG;
            mymodel.OIB = model.OIB;
            mymodel.Nositelj = model.Nositelj;
    		
        */

        #endregion
    }
}
