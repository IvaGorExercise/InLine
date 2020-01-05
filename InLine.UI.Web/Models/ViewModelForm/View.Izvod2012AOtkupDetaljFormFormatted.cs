
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


    public partial class Izvod2012AOtkupDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.ID_Izvod2012A.Required)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.ID_Izvod2012A.DisplayName)]
        public long ID_Izvod2012A { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.ID_Izvod.DisplayName)]
        public Nullable<long> ID_Izvod { get; set; }


        [StringLength(7, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.BankaVBDI.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.BankaVBDI.DisplayName)]
        public string BankaVBDI { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.BankaNaziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.BankaNaziv.DisplayName)]
        public string BankaNaziv { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.BankaOIB.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.BankaOIB.DisplayName)]
        public string BankaOIB { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.IzvadakVr.DisplayName)]
        public Nullable<int> IzvadakVr { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.DatumObrada.DisplayName)]
        public Nullable<System.DateTime> DatumObrada { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.BankaBIC.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.BankaBIC.DisplayName)]
        public string BankaBIC { get; set; }


        [StringLength(21, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.Racun.DisplayName)]
        public string Racun { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.Sjediste.DisplayName)]
        public string Sjediste { get; set; }


        [StringLength(8, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.MaticniBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.MaticniBroj.DisplayName)]
        public string MaticniBroj { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.OIB.StringLength)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.OIB.DisplayName)]
        public string OIB { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.RedniBrojIzvadak.DisplayName)]
        public Nullable<int> RedniBrojIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.PodbrojIzvadak.DisplayName)]
        public Nullable<int> PodbrojIzvadak { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.DatumIzvadak.DisplayName)]
        public Nullable<System.DateTime> DatumIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.RedniBrojGrupa.DisplayName)]
        public Nullable<int> RedniBrojGrupa { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.VrstaIzvadak.DisplayName)]
        public Nullable<int> VrstaIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.ID_Zapis.DisplayName)]
        public Nullable<long> ID_Zapis { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012AOtkupDetalj.IDIzvodVerzija.Required)]
        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.IDIzvodVerzija.DisplayName)]
        public int IDIzvodVerzija { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosDuguje { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPotrazuje { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.SaldoStaro.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SaldoStaro { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.SaldoNovo.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SaldoNovo { get; set; }

        [DisplayName(AtributClass.Izvod2012AOtkupDetalj.ID_SubjektRacun.DisplayName)]
        public Nullable<long> ID_SubjektRacun { get; set; }

        #endregion

        #region Constructor

        public Izvod2012AOtkupDetaljFormFormatted()
        { }

        public Izvod2012AOtkupDetaljFormFormatted(Model.Data.View.Izvod2012AOtkupDetalj formformated)
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
            this.SaldoStaro = formformated.SaldoStaro;
            this.SaldoNovo = formformated.SaldoNovo;
            this.ID_SubjektRacun = formformated.ID_SubjektRacun;
        }

        /*
            mymodel.ID_Izvod2012A = model.ID_Izvod2012A;
            mymodel.ID_Izvod = model.ID_Izvod;
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
            mymodel.ID_Zapis = model.ID_Zapis;
            mymodel.IDIzvodVerzija = model.IDIzvodVerzija;
            mymodel.IznosDuguje = model.IznosDuguje;
            mymodel.IznosPotrazuje = model.IznosPotrazuje;
            mymodel.SaldoStaro = model.SaldoStaro;
            mymodel.SaldoNovo = model.SaldoNovo;
            mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    		
        */

        #endregion

    }
}
