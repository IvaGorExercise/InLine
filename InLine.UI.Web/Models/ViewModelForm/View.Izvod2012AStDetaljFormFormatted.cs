﻿
namespace InLine.UI.Web.T4.FormFormattedTemplate.View
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
    using InLine.UI.Web.T4.FormFormattedTemplate;
    using InLine.UI.Web.Helper;


    public partial class Izvod2012AStDetaljFormFormatted
    {
        #region Properities

        [DisplayName(AtributClass.Izvod2012AStDetalj.ID_Izvod.DisplayName)]
        public Nullable<long> ID_Izvod { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012AStDetalj.ID_Izvod2012ASt.Required)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.ID_Izvod2012ASt.DisplayName)]
        public long ID_Izvod2012ASt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.ID_IzvodSt.DisplayName)]
        public Nullable<long> ID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IDIzvod2012ATransakcijaVr.DisplayName)]
        public Nullable<int> IDIzvod2012ATransakcijaVr { get; set; }


        [StringLength(34, ErrorMessage = AtributClass.Izvod2012AStDetalj.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.Racun.DisplayName)]
        public string Racun { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012AStDetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012AStDetalj.Adresa.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.Adresa.DisplayName)]
        public string Adresa { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012AStDetalj.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.Sjediste.DisplayName)]
        public string Sjediste { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.DatumValuta.DisplayName)]
        public Nullable<System.DateTime> DatumValuta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.DatumIzvrsenje.DisplayName)]
        public Nullable<System.DateTime> DatumIzvrsenje { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012AStDetalj.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Tecaj { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Iznos { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStDetalj.PlatiteljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.PlatiteljPozivNaBroj.DisplayName)]
        public string PlatiteljPozivNaBroj { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStDetalj.PrimateljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.PrimateljPozivNaBroj.DisplayName)]
        public string PrimateljPozivNaBroj { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IDHUBNamjena2013A.DisplayName)]
        public Nullable<int> IDHUBNamjena2013A { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Izvod2012AStDetalj.OpisPlacanje.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.OpisPlacanje.DisplayName)]
        public string OpisPlacanje { get; set; }


        [StringLength(42, ErrorMessage = AtributClass.Izvod2012AStDetalj.IdentifikatorTransakcijeFINA.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.IdentifikatorTransakcijeFINA.DisplayName)]
        public string IdentifikatorTransakcijeFINA { get; set; }


        [StringLength(38, ErrorMessage = AtributClass.Izvod2012AStDetalj.IdentifikatorTransakcije.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStDetalj.IdentifikatorTransakcije.DisplayName)]
        public string IdentifikatorTransakcije { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDugujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.IznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStDetalj.ID_Subjekt.DisplayName)]
        public Nullable<long> ID_Subjekt { get; set; }

        #endregion

        #region Constructor

        public Izvod2012AStDetaljFormFormatted()
        { }

        public Izvod2012AStDetaljFormFormatted(Model.Data.View.Izvod2012AStDetalj formformated)
        {
            this.ID_Izvod = formformated.ID_Izvod;
            this.ID_Izvod2012ASt = formformated.ID_Izvod2012ASt;
            this.ID_IzvodSt = formformated.ID_IzvodSt;
            this.IDIzvod2012ATransakcijaVr = formformated.IDIzvod2012ATransakcijaVr;
            this.Racun = formformated.Racun;
            this.Naziv = formformated.Naziv;
            this.Adresa = formformated.Adresa;
            this.Sjediste = formformated.Sjediste;
            this.DatumValuta = formformated.DatumValuta;
            this.DatumIzvrsenje = formformated.DatumIzvrsenje;
            this.IDValuta = formformated.IDValuta;
            this.Tecaj = formformated.Tecaj;
            this.IznosValuta = formformated.IznosValuta;
            this.Iznos = formformated.Iznos;
            this.PlatiteljPozivNaBroj = formformated.PlatiteljPozivNaBroj;
            this.PrimateljPozivNaBroj = formformated.PrimateljPozivNaBroj;
            this.IDHUBNamjena2013A = formformated.IDHUBNamjena2013A;
            this.OpisPlacanje = formformated.OpisPlacanje;
            this.IdentifikatorTransakcijeFINA = formformated.IdentifikatorTransakcijeFINA;
            this.IdentifikatorTransakcije = formformated.IdentifikatorTransakcije;
            this.IznosDuguje = formformated.IznosDuguje;
            this.IznosPotrazuje = formformated.IznosPotrazuje;
            this.IznosDugujeValuta = formformated.IznosDugujeValuta;
            this.IznosPotrazujeValuta = formformated.IznosPotrazujeValuta;
            this.ID_Subjekt = formformated.ID_Subjekt;
        }

        #endregion

    }
}
