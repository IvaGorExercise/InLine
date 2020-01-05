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


    public partial class Izvod2012AStGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Izvod2012ASt.ID_IzvodSt.Required)]
        [DisplayName(AtributClass.Izvod2012ASt.ID_IzvodSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.ID_IzvodSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.ID_IzvodSt.Sortable)]
        public long ID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.ID_Izvod.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.ID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.ID_Izvod.Sortable)]
        public Nullable<long> ID_Izvod { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.IznosDuguje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IznosDuguje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IznosDuguje.Sortable)]
        //public Nullable<decimal> IznosDuguje { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.IznosPotrazuje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IznosPotrazuje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IznosPotrazuje.Sortable)]
        //public Nullable<decimal> IznosPotrazuje { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.IznosDugujeValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IznosDugujeValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IznosDugujeValuta.Sortable)]
        //public Nullable<decimal> IznosDugujeValuta { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.IznosPotrazujeValuta.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IznosPotrazujeValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IznosPotrazujeValuta.Sortable)]
        //public Nullable<decimal> IznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.ID_Izvod2012ASt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.ID_Izvod2012ASt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.ID_Izvod2012ASt.Sortable)]
        public Nullable<long> ID_Izvod2012ASt { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.Izvod2012AStID_IzvodSt.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Izvod2012AStID_IzvodSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Izvod2012AStID_IzvodSt.Sortable)]
        public Nullable<long> Izvod2012AStID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.IDIzvod2012ATransakcijaVr.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.IDIzvod2012ATransakcijaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IDIzvod2012ATransakcijaVr.Sortable)]
        public Nullable<int> IDIzvod2012ATransakcijaVr { get; set; }


        [StringLength(34, ErrorMessage = AtributClass.Izvod2012ASt.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.Racun.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Racun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Racun.Sortable)]
        public string Racun { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012ASt.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012ASt.Adresa.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.Adresa.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Adresa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Adresa.Sortable)]
        public string Adresa { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012ASt.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.Sjediste.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Sjediste.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Sjediste.Sortable)]
        public string Sjediste { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012ASt.DatumValuta.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.DatumValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.DatumValuta.Sortable)]
        public Nullable<System.DateTime> DatumValuta { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.Izvod2012ASt.DatumIzvrsenje.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.DatumIzvrsenje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.DatumIzvrsenje.Sortable)]
        //public Nullable<System.DateTime> DatumIzvrsenje { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012ASt.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.Tecaj.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.Tecaj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Tecaj.Sortable)]
        //public Nullable<decimal> Tecaj { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.IznosValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IznosValuta.Sortable)]
        public Nullable<decimal> IznosValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012ASt.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Iznos.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Iznos.Sortable)]
        public Nullable<decimal> Iznos { get; set; }


        //[StringLength(22, ErrorMessage = AtributClass.Izvod2012ASt.PlatiteljPozivNaBroj.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.PlatiteljPozivNaBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.PlatiteljPozivNaBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.PlatiteljPozivNaBroj.Sortable)]
        //public string PlatiteljPozivNaBroj { get; set; }


        //[StringLength(22, ErrorMessage = AtributClass.Izvod2012ASt.PrimateljPozivNaBroj.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.PrimateljPozivNaBroj.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.PrimateljPozivNaBroj.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.PrimateljPozivNaBroj.Sortable)]
        //public string PrimateljPozivNaBroj { get; set; }

        //[DisplayName(AtributClass.Izvod2012ASt.IDHUBNamjena2013A.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IDHUBNamjena2013A.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IDHUBNamjena2013A.Sortable)]
        //public Nullable<int> IDHUBNamjena2013A { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Izvod2012ASt.OpisPlacanje.StringLength)]
        [DisplayName(AtributClass.Izvod2012ASt.OpisPlacanje.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.OpisPlacanje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.OpisPlacanje.Sortable)]
        public string OpisPlacanje { get; set; }


        //[StringLength(42, ErrorMessage = AtributClass.Izvod2012ASt.IdentifikatorTransakcijeFINA.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.IdentifikatorTransakcijeFINA.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IdentifikatorTransakcijeFINA.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IdentifikatorTransakcijeFINA.Sortable)]
        //public string IdentifikatorTransakcijeFINA { get; set; }


        //[StringLength(38, ErrorMessage = AtributClass.Izvod2012ASt.IdentifikatorTransakcije.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.IdentifikatorTransakcije.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.IdentifikatorTransakcije.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.IdentifikatorTransakcije.Sortable)]
        //public string IdentifikatorTransakcije { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Izvod2012ASt.Izvod2012ATransakcijaVrNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Izvod2012ASt.Izvod2012ATransakcijaVrNaziv.Required)]
        [DisplayName(AtributClass.Izvod2012ASt.Izvod2012ATransakcijaVrNaziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012ASt.Izvod2012ATransakcijaVrNaziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.Izvod2012ATransakcijaVrNaziv.Sortable)]
        public string Izvod2012ATransakcijaVrNaziv { get; set; }


        //[StringLength(20, ErrorMessage = AtributClass.Izvod2012ASt.HUBNamjena2013AOznaka.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.HUBNamjena2013AOznaka.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.HUBNamjena2013AOznaka.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.HUBNamjena2013AOznaka.Sortable)]
        //public string HUBNamjena2013AOznaka { get; set; }


        //[StringLength(255, ErrorMessage = AtributClass.Izvod2012ASt.HUBNamjena2013ANaziv.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.HUBNamjena2013ANaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.HUBNamjena2013ANaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.HUBNamjena2013ANaziv.Sortable)]
        //public string HUBNamjena2013ANaziv { get; set; }


        //[StringLength(30, ErrorMessage = AtributClass.Izvod2012ASt.HUBNamjena2013ANazivKr.StringLength)]
        //[DisplayName(AtributClass.Izvod2012ASt.HUBNamjena2013ANazivKr.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012ASt.HUBNamjena2013ANazivKr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012ASt.HUBNamjena2013ANazivKr.Sortable)]
        //public string HUBNamjena2013ANazivKr { get; set; }

        #endregion


        #region Constructor

        public Izvod2012AStGridFormatted()
        { }

        public Izvod2012AStGridFormatted(Model.Data.View.Izvod2012ASt gridformated)
        {
            this.ID_IzvodSt = gridformated.ID_IzvodSt;
            this.ID_Izvod = gridformated.ID_Izvod;
            //this.IznosDuguje = gridformated.IznosDuguje;
            //this.IznosPotrazuje = gridformated.IznosPotrazuje;
            //this.IznosDugujeValuta = gridformated.IznosDugujeValuta;
            //this.IznosPotrazujeValuta = gridformated.IznosPotrazujeValuta;
            this.ID_Subjekt = gridformated.ID_Subjekt;
            this.ID_Izvod2012ASt = gridformated.ID_Izvod2012ASt;
            this.Izvod2012AStID_IzvodSt = gridformated.Izvod2012AStID_IzvodSt;
            this.IDIzvod2012ATransakcijaVr = gridformated.IDIzvod2012ATransakcijaVr;
            this.Racun = gridformated.Racun;
            this.Naziv = gridformated.Naziv;
            this.Adresa = gridformated.Adresa;
            this.Sjediste = gridformated.Sjediste;
            this.DatumValuta = gridformated.DatumValuta;
            //this.DatumIzvrsenje = gridformated.DatumIzvrsenje;
            this.IDValuta = gridformated.IDValuta;
            //this.Tecaj = gridformated.Tecaj;
            this.IznosValuta = gridformated.IznosValuta;
            this.Iznos = gridformated.Iznos;
            //this.PlatiteljPozivNaBroj = gridformated.PlatiteljPozivNaBroj;
            //this.PrimateljPozivNaBroj = gridformated.PrimateljPozivNaBroj;
            //this.IDHUBNamjena2013A = gridformated.IDHUBNamjena2013A;
            this.OpisPlacanje = gridformated.OpisPlacanje;
            //this.IdentifikatorTransakcijeFINA = gridformated.IdentifikatorTransakcijeFINA;
            //this.IdentifikatorTransakcije = gridformated.IdentifikatorTransakcije;
            this.Izvod2012ATransakcijaVrNaziv = gridformated.Izvod2012ATransakcijaVrNaziv;
            //this.HUBNamjena2013AOznaka = gridformated.HUBNamjena2013AOznaka;
            //this.HUBNamjena2013ANaziv = gridformated.HUBNamjena2013ANaziv;
            //this.HUBNamjena2013ANazivKr = gridformated.HUBNamjena2013ANazivKr;
        }

        #endregion
    }
}
