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


    public partial class Izvod2012AStOtkupDetaljFormFormatted
    {
        #region Properities

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.ID_Izvod.DisplayName)]
        public Nullable<long> ID_Izvod { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.ID_Izvod2012ASt.Required)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.ID_Izvod2012ASt.DisplayName)]
        public long ID_Izvod2012ASt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.ID_IzvodSt.DisplayName)]
        public Nullable<long> ID_IzvodSt { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IDIzvod2012ATransakcijaVr.DisplayName)]
        public Nullable<int> IDIzvod2012ATransakcijaVr { get; set; }


        [StringLength(34, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Racun.DisplayName)]
        public string Racun { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.Adresa.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Adresa.DisplayName)]
        public string Adresa { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Sjediste.DisplayName)]
        public string Sjediste { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.DatumValuta.DisplayName)]
        public Nullable<System.DateTime> DatumValuta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.DatumIzvrsenje.DisplayName)]
        public Nullable<System.DateTime> DatumIzvrsenje { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Tecaj { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Iznos { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.PlatiteljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.PlatiteljPozivNaBroj.DisplayName)]
        public string PlatiteljPozivNaBroj { get; set; }


        [StringLength(22, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.PrimateljPozivNaBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.PrimateljPozivNaBroj.DisplayName)]
        public string PrimateljPozivNaBroj { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IDHUBNamjena2013A.DisplayName)]
        public Nullable<int> IDHUBNamjena2013A { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.OpisPlacanje.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.OpisPlacanje.DisplayName)]
        public string OpisPlacanje { get; set; }


        [StringLength(42, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.IdentifikatorTransakcijeFINA.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IdentifikatorTransakcijeFINA.DisplayName)]
        public string IdentifikatorTransakcijeFINA { get; set; }


        [StringLength(38, ErrorMessage = AtributClass.Izvod2012AStOtkupDetalj.IdentifikatorTransakcije.StringLength)]
        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IdentifikatorTransakcije.DisplayName)]
        public string IdentifikatorTransakcije { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDugujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.IznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.Izvod2012AStOtkupDetalj.ID_Subjekt.DisplayName)]
        public Nullable<long> ID_Subjekt { get; set; }

        #endregion

        #region Constructor

        public Izvod2012AStOtkupDetaljFormFormatted()
        { }

        public Izvod2012AStOtkupDetaljFormFormatted(Model.Data.View.Izvod2012AStOtkupDetalj formformated)
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

        /*
            mymodel.ID_Izvod = model.ID_Izvod;
            mymodel.ID_Izvod2012ASt = model.ID_Izvod2012ASt;
            mymodel.ID_IzvodSt = model.ID_IzvodSt;
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
            mymodel.IznosDuguje = model.IznosDuguje;
            mymodel.IznosPotrazuje = model.IznosPotrazuje;
            mymodel.IznosDugujeValuta = model.IznosDugujeValuta;
            mymodel.IznosPotrazujeValuta = model.IznosPotrazujeValuta;
            mymodel.ID_Subjekt = model.ID_Subjekt;
    		
        */

        #endregion

    }
}
