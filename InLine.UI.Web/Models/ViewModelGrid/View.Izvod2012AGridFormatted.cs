
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


    public partial class Izvod2012AGridFormatted
    {
        #region Properities
        [Required(ErrorMessage = AtributClass.Izvod2012A.ID_Izvod.Required)]
        [DisplayName(AtributClass.Izvod2012A.ID_Izvod.DisplayName)]
        [ScaffoldColumn(true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.ID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.ID_Izvod.Sortable)]
        public long ID_Izvod { get; set; }

        [Required(ErrorMessage = AtributClass.Izvod2012A.ID_Izvod2012A.Required)]
        [DisplayName(AtributClass.Izvod2012A.ID_Izvod2012A.DisplayName)]
        //[ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.ID_Izvod2012A.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.ID_Izvod2012A.Sortable)]
        public long ID_Izvod2012A { get; set; }

        [DisplayName(AtributClass.Izvod2012A.ID_Zapis.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.ID_Zapis.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.ID_Zapis.Sortable)]
        public Nullable<long> ID_Zapis { get; set; }

        //[Required(ErrorMessage = AtributClass.Izvod2012A.IDIzvodVerzija.Required)]
        //[DisplayName(AtributClass.Izvod2012A.IDIzvodVerzija.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.IDIzvodVerzija.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.IDIzvodVerzija.Sortable)]
        //public int IDIzvodVerzija { get; set; }

        //[DisplayName(AtributClass.Izvod2012A.IznosDuguje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.IznosDuguje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.IznosDuguje.Sortable)]
        //public Nullable<decimal> IznosDuguje { get; set; }

        //[DisplayName(AtributClass.Izvod2012A.IznosPotrazuje.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.IznosPotrazuje.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.IznosPotrazuje.Sortable)]
        //public Nullable<decimal> IznosPotrazuje { get; set; }

        //[DisplayName(AtributClass.Izvod2012A.Saldostaro.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.Saldostaro.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.Saldostaro.Sortable)]
        //public Nullable<decimal> SaldoStaro { get; set; }

        //[DisplayName(AtributClass.Izvod2012A.SaldoNovo.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.SaldoNovo.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.SaldoNovo.Sortable)]
        //public Nullable<decimal> SaldoNovo { get; set; }

        [DisplayName(AtributClass.Izvod2012A.ID_SubjektRacun.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.ID_SubjektRacun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.ID_SubjektRacun.Sortable)]
        public Nullable<long> ID_SubjektRacun { get; set; }

        [DisplayName(AtributClass.Izvod2012A.Izvod2012AID_Izvod.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.Izvod2012AID_Izvod.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.Izvod2012AID_Izvod.Sortable)]
        public Nullable<long> Izvod2012AID_Izvod { get; set; }


        //[StringLength(7, ErrorMessage = AtributClass.Izvod2012A.BankaVBDI.StringLength)]
        //[DisplayName(AtributClass.Izvod2012A.BankaVBDI.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.BankaVBDI.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.BankaVBDI.Sortable)]
        //public string BankaVBDI { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.Izvod2012A.BankaNaziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.BankaNaziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.BankaNaziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.BankaNaziv.Sortable)]
        public string BankaNaziv { get; set; }


        //[StringLength(11, ErrorMessage = AtributClass.Izvod2012A.BankaOIB.StringLength)]
        //[DisplayName(AtributClass.Izvod2012A.BankaOIB.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.BankaOIB.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.BankaOIB.Sortable)]
        //public string BankaOIB { get; set; }

        [DisplayName(AtributClass.Izvod2012A.IzvadakVr.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.IzvadakVr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.IzvadakVr.Sortable)]
        public Nullable<int> IzvadakVr { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012A.DatumObrada.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.DatumObrada.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.DatumObrada.Sortable)]
        public Nullable<System.DateTime> DatumObrada { get; set; }


        //[StringLength(11, ErrorMessage = AtributClass.Izvod2012A.BankaBIC.StringLength)]
        //[DisplayName(AtributClass.Izvod2012A.BankaBIC.DisplayName)]
        //[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.BankaBIC.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.BankaBIC.Sortable)]
        //public string BankaBIC { get; set; }


        [StringLength(21, ErrorMessage = AtributClass.Izvod2012A.Racun.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.Racun.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.Racun.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.Racun.Sortable)]
        public string Racun { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.Izvod2012A.IDValuta.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.IDValuta.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.IDValuta.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.IDValuta.Sortable)]
        public string IDValuta { get; set; }


        [StringLength(70, ErrorMessage = AtributClass.Izvod2012A.Naziv.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(35, ErrorMessage = AtributClass.Izvod2012A.Sjediste.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.Sjediste.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.Sjediste.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.Sjediste.Sortable)]
        public string Sjediste { get; set; }


        [StringLength(8, ErrorMessage = AtributClass.Izvod2012A.MaticniBroj.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.MaticniBroj.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.MaticniBroj.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.MaticniBroj.Sortable)]
        public string MaticniBroj { get; set; }


        [StringLength(11, ErrorMessage = AtributClass.Izvod2012A.OIB.StringLength)]
        [DisplayName(AtributClass.Izvod2012A.OIB.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.OIB.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.OIB.Sortable)]
        public string OIB { get; set; }

        [DisplayName(AtributClass.Izvod2012A.RedniBrojIzvadak.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.RedniBrojIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.RedniBrojIzvadak.Sortable)]
        public Nullable<int> RedniBrojIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012A.PodbrojIzvadak.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.PodbrojIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.PodbrojIzvadak.Sortable)]
        public Nullable<int> PodbrojIzvadak { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.Izvod2012A.DatumIzvadak.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.DatumIzvadak.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.DatumIzvadak.Sortable)]
        public Nullable<System.DateTime> DatumIzvadak { get; set; }

        [DisplayName(AtributClass.Izvod2012A.RedniBrojGrupa.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.Izvod2012A.RedniBrojGrupa.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.RedniBrojGrupa.Sortable)]
        public Nullable<int> RedniBrojGrupa { get; set; }

        //[DisplayName(AtributClass.Izvod2012A.VrstaIzvadak.DisplayName)]
        //[JqGridColumnSearchable(false)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //[JqGridColumnFormatter(AtributClass.Izvod2012A.VrstaIzvadak.Formatter)]
        //[JqGridColumnSortable(true, Index = AtributClass.Izvod2012A.VrstaIzvadak.Sortable)]
        //public Nullable<int> VrstaIzvadak { get; set; }

        #endregion


        #region Constructor

        public Izvod2012AGridFormatted()
        { }

        public Izvod2012AGridFormatted(Model.Data.View.Izvod2012A gridformated)
        {
            this.ID_Izvod = gridformated.ID_Izvod;
            this.ID_Izvod2012A = gridformated.ID_Izvod2012A;
            this.ID_Zapis = gridformated.ID_Zapis;
            //this.IDIzvodVerzija = gridformated.IDIzvodVerzija;
            //this.IznosDuguje = gridformated.IznosDuguje;
            //this.IznosPotrazuje = gridformated.IznosPotrazuje;
            //this.SaldoStaro = gridformated.SaldoStaro;
            //this.SaldoNovo = gridformated.SaldoNovo;
            this.ID_SubjektRacun = gridformated.ID_SubjektRacun;
            this.Izvod2012AID_Izvod = gridformated.Izvod2012AID_Izvod;
            //this.BankaVBDI = gridformated.BankaVBDI;
            this.BankaNaziv = gridformated.BankaNaziv;
            //this.BankaOIB = gridformated.BankaOIB;
            this.IzvadakVr = gridformated.IzvadakVr;
            this.DatumObrada = gridformated.DatumObrada;
            //this.BankaBIC = gridformated.BankaBIC;
            this.Racun = gridformated.Racun;
            this.IDValuta = gridformated.IDValuta;
            this.Naziv = gridformated.Naziv;
            this.Sjediste = gridformated.Sjediste;
            this.MaticniBroj = gridformated.MaticniBroj;
            this.OIB = gridformated.OIB;
            this.RedniBrojIzvadak = gridformated.RedniBrojIzvadak;
            this.PodbrojIzvadak = gridformated.PodbrojIzvadak;
            this.DatumIzvadak = gridformated.DatumIzvadak;
            this.RedniBrojGrupa = gridformated.RedniBrojGrupa;
            //this.VrstaIzvadak = gridformated.VrstaIzvadak;
        }

        #endregion
    }
}
