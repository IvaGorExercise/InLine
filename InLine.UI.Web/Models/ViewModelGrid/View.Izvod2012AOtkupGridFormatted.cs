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


    public partial class Izvod2012AOtkupGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Izvod2012AOtkup.ID_Izvod.Required)]
        [DisplayName(AtributClass.Izvod2012AOtkup.ID_Izvod.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.ID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.ID_Izvod.Sortable)]
        public long ID_Izvod { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012AOtkup.ID_Izvod2012A.Required)]
        [DisplayName(AtributClass.Izvod2012AOtkup.ID_Izvod2012A.DisplayName)]
        //[ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.ID_Izvod2012A.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.ID_Izvod2012A.Sortable)]
        public long ID_Izvod2012A { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.ID_Zapis.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.ID_Zapis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.ID_Zapis.Sortable)]
        public Nullable<long> ID_Zapis { get; set; }


        [DisplayName(AtributClass.Izvod2012AOtkup.RedniBrojIzvadak.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.RedniBrojIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.RedniBrojIzvadak.Sortable)]
        public Nullable<int> RedniBrojIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.PodbrojIzvadak.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.PodbrojIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.PodbrojIzvadak.Sortable)]
        public Nullable<int> PodbrojIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.RedniBrojGrupa.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.RedniBrojGrupa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.RedniBrojGrupa.Sortable)]
        public Nullable<int> RedniBrojGrupa { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AOtkup.DatumIzvadak.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.DatumIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.DatumIzvadak.Sortable)]
        public Nullable<System.DateTime> DatumIzvadak { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AOtkup.DatumObrada.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.DatumObrada.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.DatumObrada.Sortable)]
        public Nullable<System.DateTime> DatumObrada { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.Izvod2012AOtkup.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkup.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        //[Required(ErrorMessage = AtributClass.Izvod2012AOtkup.IDIzvodVerzija.Required)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.IDIzvodVerzija.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.IDIzvodVerzija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.IDIzvodVerzija.Sortable)]
        //public int IDIzvodVerzija { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.SaldoStaro.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.SaldoStaro.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.SaldoStaro.Sortable)]
        public Nullable<decimal> SaldoStaro { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.SaldoNovo.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.SaldoNovo.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.SaldoNovo.Sortable)]
        public Nullable<decimal> SaldoNovo { get; set; }


        [DisplayName(AtributClass.Izvod2012AOtkup.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.IznosDuguje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.IznosDuguje.Sortable)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.IznosPotrazuje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.IznosPotrazuje.Sortable)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.ID_SubjektRacun.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.ID_SubjektRacun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.ID_SubjektRacun.Sortable)]
        public Nullable<long> ID_SubjektRacun { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.Izvod2012AID_Izvod.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.Izvod2012AID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.Izvod2012AID_Izvod.Sortable)]
        public Nullable<long> Izvod2012AID_Izvod { get; set; }


        //[StringLength(7, ErrorMessage = AtributClass.Izvod2012AOtkup.BankaVBDI.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.BankaVBDI.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.BankaVBDI.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.BankaVBDI.Sortable)]
        //public string BankaVBDI { get; set; }


        //[StringLength(50, ErrorMessage = AtributClass.Izvod2012AOtkup.BankaNaziv.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.BankaNaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.BankaNaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.BankaNaziv.Sortable)]
        //public string BankaNaziv { get; set; }


        //[StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkup.BankaOIB.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.BankaOIB.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.BankaOIB.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.BankaOIB.Sortable)]
        //public string BankaOIB { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkup.IzvadakVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.IzvadakVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.IzvadakVr.Sortable)]
        public Nullable<int> IzvadakVr { get; set; }


        //[StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkup.BankaBIC.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.BankaBIC.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.BankaBIC.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.BankaBIC.Sortable)]
        //public string BankaBIC { get; set; }


        [StringLength(21, ErrorMessage = AtributClass.Izvod2012AOtkup.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkup.Racun.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.Racun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.Racun.Sortable)]
        public string Racun { get; set; }


        //[StringLength(70, ErrorMessage = AtributClass.Izvod2012AOtkup.Naziv.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.Naziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.Naziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.Naziv.Sortable)]
        //public string Naziv { get; set; }


        //[StringLength(35, ErrorMessage = AtributClass.Izvod2012AOtkup.Sjediste.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.Sjediste.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.Sjediste.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.Sjediste.Sortable)]
        //public string Sjediste { get; set; }


        //[StringLength(8, ErrorMessage = AtributClass.Izvod2012AOtkup.MaticniBroj.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.MaticniBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.MaticniBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.MaticniBroj.Sortable)]
        //public string MaticniBroj { get; set; }


        //[StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkup.OIB.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AOtkup.OIB.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.OIB.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.OIB.Sortable)]
        //public string OIB { get; set; }


        [DisplayName(AtributClass.Izvod2012AOtkup.VrstaIzvadak.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AOtkup.VrstaIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AOtkup.VrstaIzvadak.Sortable)]
        public Nullable<int> VrstaIzvadak { get; set; }

        #endregion


        #region Constructor

        public Izvod2012AOtkupGridFormatted()
        { }

        public Izvod2012AOtkupGridFormatted(Model.Data.View.Izvod2012AOtkup gridformated)
        {
            this.ID_Izvod = gridformated.ID_Izvod;
            this.ID_Izvod2012A = gridformated.ID_Izvod2012A;
            this.ID_Zapis = gridformated.ID_Zapis;
            //this.IDIzvodVerzija = gridformated.IDIzvodVerzija;
            this.IznosDuguje = gridformated.IznosDuguje;
            this.IznosPotrazuje = gridformated.IznosPotrazuje;
            this.SaldoStaro = gridformated.SaldoStaro;
            this.SaldoNovo = gridformated.SaldoNovo;
            this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
            this.Izvod2012AID_Izvod = gridformated.Izvod2012AID_Izvod;
            //this.BankaVBDI = gridformated.BankaVBDI;
            //this.BankaNaziv = gridformated.BankaNaziv;
            //this.BankaOIB = gridformated.BankaOIB;
            this.IzvadakVr = gridformated.IzvadakVr;
            this.DatumObrada = gridformated.DatumObrada;
            //this.BankaBIC = gridformated.BankaBIC;
            this.Racun = gridformated.Racun;
            this.IDValuta = gridformated.IDValuta;
            //this.Naziv = gridformated.Naziv;
            //this.Sjediste = gridformated.Sjediste;
            //this.MaticniBroj = gridformated.MaticniBroj;
            //this.OIB = gridformated.OIB;
            this.RedniBrojIzvadak = gridformated.RedniBrojIzvadak;
            this.PodbrojIzvadak = gridformated.PodbrojIzvadak;
            this.DatumIzvadak = gridformated.DatumIzvadak;
            this.RedniBrojGrupa = gridformated.RedniBrojGrupa;
            this.VrstaIzvadak = gridformated.VrstaIzvadak;
        }

        /*
            mymodel.ID_Izvod = model.ID_Izvod;
            mymodel.ID_Izvod2012A = model.ID_Izvod2012A;
            mymodel.ID_Zapis = model.ID_Zapis;
            mymodel.IDIzvodVerzija = model.IDIzvodVerzija;
            mymodel.IznosDuguje = model.IznosDuguje;
            mymodel.IznosPotrazuje = model.IznosPotrazuje;
            mymodel.SaldoStaro = model.SaldoStaro;
            mymodel.SaldoNovo = model.SaldoNovo;
            mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
            mymodel.Izvod2012AID_Izvod = model.Izvod2012AID_Izvod;
            mymodel.BankaVBDI = model.BankaVBDI;
            mymodel.BankaNaziv = model.BankaNaziv;
            mymodel.BankaOIB = model.BankaOIB;
            mymodel.IzvadakVr = model.IzvadakVr;
            mymodel.DatumObrada = model.DatumObrada;
            mymodel.BankaBIC = model.BankaBIC;
            mymodel.Racun = model.Racun;
            mymodel.IDValuta = model.IDValuta;
            mymodel.Naziv = model.Naziv;
            mymodel.Sjediste = model.Sjediste;
            mymodel.MaticniBroj = model.MaticniBroj;
            mymodel.OIB = model.OIB;
            mymodel.RedniBrojIzvadak = model.RedniBrojIzvadak;
            mymodel.PodbrojIzvadak = model.PodbrojIzvadak;
            mymodel.DatumIzvadak = model.DatumIzvadak;
            mymodel.RedniBrojGrupa = model.RedniBrojGrupa;
            mymodel.VrstaIzvadak = model.VrstaIzvadak;
    		
        */

        #endregion
    }
}
