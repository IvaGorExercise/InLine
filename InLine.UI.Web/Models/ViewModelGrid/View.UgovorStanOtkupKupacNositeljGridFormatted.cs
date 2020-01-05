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

    public partial class UgovorStanOtkupKupacNositeljGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.ID_Kupac.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.ID_Kupac.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.ID_Kupac.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.ID_Kupac.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_Kupac { get; set; }


        // BrojUgovora pretvoren u string zbog vodecih nula
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.BrojUgovor.DisplayName)]
        [JqGridColumnSearchable(true)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.BrojUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string BrojUgovor { get; set; }

        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.Naziv.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.Naziv.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.Naziv.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string Naziv { get; set; }

        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.UlicaKupac.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.UlicaKupac.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.UlicaKupac.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.UlicaKupac.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string UlicaKupac { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkup.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkup.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkup.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public long ID_UgovorStanOtkup { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.UlicaStan.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.UlicaStan.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.UlicaStan.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.UlicaStan.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string UlicaStan { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.Datum.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.Datum.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.Datum.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkupKupac.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkupKupac.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.ID_UgovorStanOtkupKupac.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public Nullable<long> ID_UgovorStanOtkupKupac { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.Napomena.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.Napomena.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.Napomena.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.Napomena.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string Napomena { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.JMBG.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.JMBG.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.JMBG.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.JMBG.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string JMBG { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.OIB.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.OIB.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.OIB.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.OIB.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string OIB { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.Nositelj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.Nositelj.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.Nositelj.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public Nullable<bool> Nositelj { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.KontrolniBroj.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.KontrolniBroj.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.KontrolniBroj.Formatter)]
        public Nullable<byte> KontrolniBroj { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.UgovorStanOtkupKupacNositelj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacNositelj.PostanskiBroj.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupacNositelj.PostanskiBroj.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupacNositelj.PostanskiBroj.Formatter)]
        public string PostanskiBroj { get; set; }

        #endregion


        #region Constructor

        public UgovorStanOtkupKupacNositeljGridFormatted()
        { }

        public UgovorStanOtkupKupacNositeljGridFormatted(Model.Data.View.UgovorStanOtkupKupacNositelj gridformated)
        {
            this.ID_Kupac = gridformated.ID_Kupac;
            this.Naziv = gridformated.Naziv;
            this.UlicaKupac = gridformated.UlicaKupac;
            this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
            this.UlicaStan = gridformated.UlicaStan;
            this.BrojUgovor = gridformated.BrojUgovor.ToString(KeyWord.FormaterRazno.VodeceNule.VodeceNule7);
            this.Datum = gridformated.Datum;
            this.ID_UgovorStanOtkupKupac = gridformated.ID_UgovorStanOtkupKupac;
            this.Napomena = gridformated.Napomena;
            this.JMBG = gridformated.JMBG;
            this.OIB = gridformated.OIB;
            this.Nositelj = gridformated.Nositelj;
            this.KontrolniBroj = gridformated.KontrolniBroj;
            this.PostanskiBroj = gridformated.PostanskiBroj;
        }

        /*
            mymodel.ID_Kupac = model.ID_Kupac;
            mymodel.Naziv = model.Naziv;
            mymodel.UlicaKupac = model.UlicaKupac;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.UlicaStan = model.UlicaStan;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.Datum = model.Datum;
            mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
            mymodel.Napomena = model.Napomena;
            mymodel.JMBG = model.JMBG;
            mymodel.OIB = model.OIB;
            mymodel.Nositelj = model.Nositelj;
            mymodel.KontrolniBroj = model.KontrolniBroj;
    	    mymodel.PostanskiBroj = model.PostanskiBroj;
    		
        */

        #endregion
    }
}
