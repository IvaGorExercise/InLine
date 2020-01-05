
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


    public partial class Izvod2012ADetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.Izvod2012ADetalj.ID_Izvod2012A.Required)]
        [DisplayName(AtributClass.Izvod2012ADetalj.ID_Izvod2012A.DisplayName)]
        public long ID_Izvod2012A { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.ID_Izvod.DisplayName)]
        public Nullable<long> ID_Izvod { get; set; }


        [StringLength(7, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaVBDI.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.BankaVBDI.DisplayName)]
        public string BankaVBDI { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaNaziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.BankaNaziv.DisplayName)]
        public string BankaNaziv { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaOIB.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.BankaOIB.DisplayName)]
        public string BankaOIB { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.IzvadakVr.DisplayName)]
        public Nullable<int> IzvadakVr { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012ADetalj.DatumObrada.DisplayName)]
        public Nullable<System.DateTime> DatumObrada { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.BankaBIC.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.BankaBIC.DisplayName)]
        public string BankaBIC { get; set; }


        [StringLength(21, ErrorMessage = AtributClass.Izvod2012ADetalj.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.Racun.DisplayName)]
        public string Racun { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012ADetalj.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012ADetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012ADetalj.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.Sjediste.DisplayName)]
        public string Sjediste { get; set; }


        [StringLength(8, ErrorMessage = AtributClass.Izvod2012ADetalj.MaticniBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.MaticniBroj.DisplayName)]
        public string MaticniBroj { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012ADetalj.OIB.StringLength)]
        [DisplayName(AtributClass.Izvod2012ADetalj.OIB.DisplayName)]
        public string OIB { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.RedniBrojIzvadak.DisplayName)]
        public Nullable<int> RedniBrojIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.PodbrojIzvadak.DisplayName)]
        public Nullable<int> PodbrojIzvadak { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012ADetalj.DatumIzvadak.DisplayName)]
        public Nullable<System.DateTime> DatumIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.RedniBrojGrupa.DisplayName)]
        public Nullable<int> RedniBrojGrupa { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.VrstaIzvadak.DisplayName)]
        public Nullable<int> VrstaIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.ID_Zapis.DisplayName)]
        public Nullable<long> ID_Zapis { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012ADetalj.IDIzvodVerzija.Required)]
        [DisplayName(AtributClass.Izvod2012ADetalj.IDIzvodVerzija.DisplayName)]
        public int IDIzvodVerzija { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.Saldostaro.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Saldostaro { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.SaldoNovo.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SaldoNovo { get; set; }

        [DisplayName(AtributClass.Izvod2012ADetalj.ID_SubjektRacun.DisplayName)]
        public Nullable<long> ID_SubjektRacun { get; set; }

        #endregion

        #region Constructor

        public Izvod2012ADetaljFormFormatted()
        { }

        public Izvod2012ADetaljFormFormatted(Model.Data.View.Izvod2012ADetalj formformated)
        {
            this.ID_Izvod2012A = formformated.ID_Izvod2012A;
            this.ID_Izvod = formformated.ID_Izvod;
            this.BankaVBDI = formformated.BankaVBDI;
            this.BankaNaziv = formformated.BankaNaziv;
            this.BankaOIB = formformated.BankaOIB;
            this.IzvadakVr = formformated.IzvadakVr;
            this.DatumObrada = formformated.DatumObrada;
            this.BankaBIC = formformated.BankaBIC;
            this.Racun = formformated.Racun;
            this.IDValuta = formformated.IDValuta;
            this.Naziv = formformated.Naziv;
            this.Sjediste = formformated.Sjediste;
            this.MaticniBroj = formformated.MaticniBroj;
            this.OIB = formformated.OIB;
            this.RedniBrojIzvadak = formformated.RedniBrojIzvadak;
            this.PodbrojIzvadak = formformated.PodbrojIzvadak;
            this.DatumIzvadak = formformated.DatumIzvadak;
            this.RedniBrojGrupa = formformated.RedniBrojGrupa;
            this.VrstaIzvadak = formformated.VrstaIzvadak;
            this.ID_Zapis = formformated.ID_Zapis;
            this.IDIzvodVerzija = formformated.IDIzvodVerzija;
            this.IznosDuguje = formformated.IznosDuguje;
            this.IznosPotrazuje = formformated.IznosPotrazuje;
            this.Saldostaro = formformated.Saldostaro;
            this.SaldoNovo = formformated.SaldoNovo;
            this.ID_SubjektRacun = formformated.ID_SubjektRacun;
        }


        #endregion

    }
}
