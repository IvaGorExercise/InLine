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
    using InLine.Repository.Data.Helper;


    public partial class Izvod2012AStOtkupGridFormatted
    {
        public InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
        Service.Data.UgovorStanOtkup _serviceUgovorStanOtkup;
        Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
    


        #region Properities
        [Required(ErrorMessage = AtributClass.Izvod2012AStOtkup.ID_IzvodSt.Required)]
        [DisplayName(AtributClass.Izvod2012AStOtkup.ID_IzvodSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.ID_IzvodSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.ID_IzvodSt.Sortable)]
        public long ID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.ID_Izvod.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.ID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.ID_Izvod.Sortable)]
        public Nullable<long> ID_Izvod { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IznosValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IznosValuta.Sortable)]
        public Nullable<decimal> IznosValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Iznos.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Iznos.Sortable)]
        public Nullable<decimal> Iznos { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IznosDuguje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IznosDuguje.Sortable)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IznosPotrazuje.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IznosPotrazuje.Sortable)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.Izvod2012AStOtkup.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkup.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IDValuta.Sortable)]
        public string IDValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IznosDugujeValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IznosDugujeValuta.Sortable)]
        public Nullable<decimal> IznosDugujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IznosPotrazujeValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IznosPotrazujeValuta.Sortable)]
        public Nullable<decimal> IznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.ID_Subjekt.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.ID_Subjekt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.ID_Subjekt.Sortable)]
        public Nullable<long> ID_Subjekt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.ID_Izvod2012ASt.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.ID_Izvod2012ASt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.ID_Izvod2012ASt.Sortable)]
        public Nullable<long> ID_Izvod2012ASt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.Izvod2012AStID_IzvodSt.DisplayName)]
        [JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Izvod2012AStID_IzvodSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Izvod2012AStID_IzvodSt.Sortable)]
        public Nullable<long> Izvod2012AStID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkup.IDIzvod2012ATransakcijaVr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IDIzvod2012ATransakcijaVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IDIzvod2012ATransakcijaVr.Sortable)]
        public Nullable<int> IDIzvod2012ATransakcijaVr { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStOtkup.PlatiteljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkup.PlatiteljPozivNaBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.PlatiteljPozivNaBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.PlatiteljPozivNaBroj.Sortable)]
        public string PlatiteljPozivNaBroj { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStOtkup.PrimateljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkup.PrimateljPozivNaBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.PrimateljPozivNaBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.PrimateljPozivNaBroj.Sortable)]
        public string PrimateljPozivNaBroj { get; set; }

        [StringLength(34, ErrorMessage = AtributClass.Izvod2012AStOtkup.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkup.Racun.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Racun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Racun.Sortable)]
        public string Racun { get; set; }


        //[StringLength(70, ErrorMessage = AtributClass.Izvod2012AStOtkup.Naziv.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.Naziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Naziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Naziv.Sortable)]
        //public string Naziv { get; set; }


        //[StringLength(35, ErrorMessage = AtributClass.Izvod2012AStOtkup.Adresa.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.Adresa.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Adresa.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Adresa.Sortable)]
        //public string Adresa { get; set; }


        //[StringLength(35, ErrorMessage = AtributClass.Izvod2012AStOtkup.Sjediste.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.Sjediste.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Sjediste.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Sjediste.Sortable)]
        //public string Sjediste { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.DatumValuta.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.DatumValuta.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.DatumValuta.Sortable)]
        //public Nullable<System.DateTime> DatumValuta { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.DatumIzvrsenje.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.DatumIzvrsenje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.DatumIzvrsenje.Sortable)]
        //public Nullable<System.DateTime> DatumIzvrsenje { get; set; }


        [DisplayName(AtributClass.Izvod2012AStOtkup.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Tecaj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Tecaj.Sortable)]
        public Nullable<decimal> Tecaj { get; set; }


        //[DisplayName(AtributClass.Izvod2012AStOtkup.IDHUBNamjena2013A.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IDHUBNamjena2013A.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IDHUBNamjena2013A.Sortable)]
        //public Nullable<int> IDHUBNamjena2013A { get; set; }


        //[StringLength(255, ErrorMessage = AtributClass.Izvod2012AStOtkup.OpisPlacanje.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.OpisPlacanje.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.OpisPlacanje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.OpisPlacanje.Sortable)]
        //public string OpisPlacanje { get; set; }


        //[StringLength(42, ErrorMessage = AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcijeFINA.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcijeFINA.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcijeFINA.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcijeFINA.Sortable)]
        //public string IdentifikatorTransakcijeFINA { get; set; }


        //[StringLength(38, ErrorMessage = AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcije.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcije.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcije.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.IdentifikatorTransakcije.Sortable)]
        //public string IdentifikatorTransakcije { get; set; }


        //[StringLength(255, ErrorMessage = AtributClass.Izvod2012AStOtkup.Izvod2012ATransakcijaVrNaziv.StringLength)]
        //[Required(ErrorMessage = AtributClass.Izvod2012AStOtkup.Izvod2012ATransakcijaVrNaziv.Required)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.Izvod2012ATransakcijaVrNaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.Izvod2012ATransakcijaVrNaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.Izvod2012ATransakcijaVrNaziv.Sortable)]
        //public string Izvod2012ATransakcijaVrNaziv { get; set; }


        //[StringLength(20, ErrorMessage = AtributClass.Izvod2012AStOtkup.HUBNamjena2013AOznaka.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.HUBNamjena2013AOznaka.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.HUBNamjena2013AOznaka.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.HUBNamjena2013AOznaka.Sortable)]
        //public string HUBNamjena2013AOznaka { get; set; }


        //[StringLength(255, ErrorMessage = AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANaziv.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANaziv.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANaziv.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANaziv.Sortable)]
        //public string HUBNamjena2013ANaziv { get; set; }


        //[StringLength(30, ErrorMessage = AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANazivKr.StringLength)]
        //[DisplayName(AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANazivKr.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANazivKr.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012AStOtkup.HUBNamjena2013ANazivKr.Sortable)]
        //public string HUBNamjena2013ANazivKr { get; set; }

        [JqGridColumnSearchable(false)]
        public string DokumentGrupa { get; set; }

        [JqGridColumnSearchable(false)]
        public string DokumentVrsta { get; set; }

        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnSearchable(false)]
        public string BrojUgovor { get; set; }

        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnSearchable(false)]
        public string BrojObrok { get; set; }


        #endregion


        #region Constructor

        public Izvod2012AStOtkupGridFormatted()
        { }

        public Izvod2012AStOtkupGridFormatted(Model.Data.View.Izvod2012AStOtkup gridformated)
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

            if(this.IDIzvod2012ATransakcijaVr == 10)
            {
                this.IznosDuguje = gridformated.Iznos;
                this.IznosDugujeValuta = gridformated.IznosValuta;
            }
            else
            {
                this.IznosPotrazuje = gridformated.Iznos;
                this.IznosPotrazujeValuta = gridformated.IznosValuta;
            }

            this.Racun = gridformated.Racun;
            //this.Naziv = gridformated.Naziv;
            //this.Adresa = gridformated.Adresa;
            //this.Sjediste = gridformated.Sjediste;
            //this.DatumValuta = gridformated.DatumValuta;
            //this.DatumIzvrsenje = gridformated.DatumIzvrsenje;
            this.IDValuta = gridformated.IDValuta;
            this.Tecaj = gridformated.Tecaj;
            this.IznosValuta = gridformated.IznosValuta;
            this.Iznos = gridformated.Iznos;
            this.PlatiteljPozivNaBroj = gridformated.PlatiteljPozivNaBroj;
            this.PrimateljPozivNaBroj = gridformated.PrimateljPozivNaBroj;
         

            if (this.IDIzvod2012ATransakcijaVr == 20)
            {
                this.BrojUgovor = BrojUgovorIzPozivnaBrojPrimatelj(gridformated.PrimateljPozivNaBroj);
                this.BrojObrok = BrojObrokIzPozivnaBrojPrimatelj(gridformated.PrimateljPozivNaBroj);
            }

            int number;
            bool result = Int32.TryParse(this.BrojUgovor, out number);

            if (result && this.IDIzvod2012ATransakcijaVr == 20)
            {
                DajUgovor(number);
            }
            //this.IDHUBNamjena2013A = gridformated.IDHUBNamjena2013A;
            //this.OpisPlacanje = gridformated.OpisPlacanje;
            //this.IdentifikatorTransakcijeFINA = gridformated.IdentifikatorTransakcijeFINA;
            //this.IdentifikatorTransakcije = gridformated.IdentifikatorTransakcije;
            //this.Izvod2012ATransakcijaVrNaziv = gridformated.Izvod2012ATransakcijaVrNaziv;
            //this.HUBNamjena2013AOznaka = gridformated.HUBNamjena2013AOznaka;
            //this.HUBNamjena2013ANaziv = gridformated.HUBNamjena2013ANaziv;
            //this.HUBNamjena2013ANazivKr = gridformated.HUBNamjena2013ANazivKr;
        }

        /*
            mymodel.ID_IzvodSt = model.ID_IzvodSt;
            mymodel.ID_Izvod = model.ID_Izvod;
            mymodel.IznosDuguje = model.IznosDuguje;
            mymodel.IznosPotrazuje = model.IznosPotrazuje;
            mymodel.IznosDugujeValuta = model.IznosDugujeValuta;
            mymodel.IznosPotrazujeValuta = model.IznosPotrazujeValuta;
            mymodel.ID_Subjekt = model.ID_Subjekt;
            mymodel.ID_Izvod2012ASt = model.ID_Izvod2012ASt;
            mymodel.Izvod2012AStID_IzvodSt = model.Izvod2012AStID_IzvodSt;
            mymodel.IDIzvod2012ATransakcijaVr = model.IDIzvod2012ATransakcijaVr;
            mymodel.Racun = model.Racun;
            mymodel.Naziv = model.Naziv;
            mymodel.Adresa = model.Adresa;
            mymodel.Sjediste = model.Sjediste;
            mymodel.DatumValuta = model.DatumValuta;
            mymodel.DatumIzvrsenje = model.DatumIzvrsenje;
            mymodel.IDValuta = model.IDValuta;
            mymodel.Tecaj = model.Tecaj;
            mymodel.IznosValuta = model.IznosValuta;
            mymodel.Iznos = model.Iznos;
            mymodel.PlatiteljPozivNaBroj = model.PlatiteljPozivNaBroj;
            mymodel.PrimateljPozivNaBroj = model.PrimateljPozivNaBroj;
            mymodel.IDHUBNamjena2013A = model.IDHUBNamjena2013A;
            mymodel.OpisPlacanje = model.OpisPlacanje;
            mymodel.IdentifikatorTransakcijeFINA = model.IdentifikatorTransakcijeFINA;
            mymodel.IdentifikatorTransakcije = model.IdentifikatorTransakcije;
            mymodel.Izvod2012ATransakcijaVrNaziv = model.Izvod2012ATransakcijaVrNaziv;
            mymodel.HUBNamjena2013AOznaka = model.HUBNamjena2013AOznaka;
            mymodel.HUBNamjena2013ANaziv = model.HUBNamjena2013ANaziv;
            mymodel.HUBNamjena2013ANazivKr = model.HUBNamjena2013ANazivKr;
    		
        */

        #endregion

        #region Metods

        String BrojUgovorIzPozivnaBrojPrimatelj(string PozivNaBroj)
        {
            String rezult = String.Empty;

            if (!String.IsNullOrEmpty(PozivNaBroj))
            {
                if (PozivNaBroj.Length >= 6)
                {
                    string query = String.Empty;
                    string[] separator = new string[] { CommonFunctions.KeyWord.Crtica };
                    string[] dijelovi;
                 
                    dijelovi = PozivNaBroj.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string privremena = String.Empty;

                    if (dijelovi.Count() > 0)
                    {
                        string BrojUgovor = String.Empty;
                        BrojUgovor = dijelovi.ElementAt(0).ToString().Trim();
                        BrojUgovor = BrojUgovor.TrimStart('0');
                        BrojUgovor = BrojUgovor.Remove(BrojUgovor.Length - 1);
                        rezult = BrojUgovor;
                    }
                }
            }

            return rezult;
        }


        String BrojObrokIzPozivnaBrojPrimatelj(string PozivNaBroj)
        {
            String rezult = String.Empty;

            if (!String.IsNullOrEmpty(PozivNaBroj))
            {
                if (PozivNaBroj.Length >= 6)
                {
                    string query = String.Empty;
                    string[] separator = new string[] { CommonFunctions.KeyWord.Crtica };
                    string[] dijelovi;

                    dijelovi = PozivNaBroj.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string privremena = String.Empty;

                    string BrojObrok = String.Empty;

                    if(dijelovi.Count() > 1)
                    {
                        BrojObrok = dijelovi.ElementAt(1).ToString().Trim();
                        rezult = BrojObrok;
                    }
                  
                }
            }

            return rezult;
        }

        void DajUgovor(int BrojUgovor)
        {
            korisnik_data = _korisnikDataFromSession.GetKorisnikDataFromSession();
            if (korisnik_data != null)
            {
                _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);

                List<InLine.Model.Data.Field.UgovorStanOtkup> field = new List<InLine.Model.Data.Field.UgovorStanOtkup>();
                List<InLine.Model.Data.Filter.UgovorStanOtkup> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkup>();
                List<InLine.Model.Data.Sort.UgovorStanOtkup> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkup>();
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkup { Field = InLine.Model.Data.Field.UgovorStanOtkup.ID_UgovorStanOtkup, Value = Convert.ToInt64(BrojUgovor) });
                InLine.Model.Data.UgovorStanOtkup item = _serviceUgovorStanOtkup.GetData(field, filter, sort).FirstOrDefault();

                if (item != null)
                {
                    this.DokumentGrupa = "0" + item.DokumentGrupa.ToString();
                    this.DokumentVrsta = "0" + item.DokumentVrsta.ToString();
                }
            }
      
        }

        #endregion
    }
}
