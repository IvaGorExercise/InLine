
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


    public partial class TemeljnicaDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.ID_Temeljnica.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.ID_Temeljnica.DisplayName)]
        public long ID_Temeljnica { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.ID_TemeljnicaVr.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.ID_TemeljnicaVr.DisplayName)]
        public long ID_TemeljnicaVr { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Naziv.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Datum.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Datum.DisplayName)]
        public System.DateTime Datum { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.IDValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Knjizeno.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Knjizeno.DisplayName)]
        public bool Knjizeno { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Storno.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Storno.DisplayName)]
        public bool Storno { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.PocetnoStanje.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.PocetnoStanje.DisplayName)]
        public bool PocetnoStanje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.ZavrsnoKnjizenje.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.ZavrsnoKnjizenje.DisplayName)]
        public bool ZavrsnoKnjizenje { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(20, ErrorMessage = AtributClass.TemeljnicaDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.TemeljnicaDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.TemeljnicaDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.TemeljnicaDetalj.DatumKnjizenje.DisplayName)]
        public Nullable<System.DateTime> DatumKnjizenje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaDetalj.Tecaj.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaDetalj.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal Tecaj { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.Opis.DisplayName)]
        public string Opis { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.SumIznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SumIznosDuguje { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.SumIznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SumIznosPotrazuje { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.SumIznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SumIznosDugujeValuta { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.SumIznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SumIznosPotrazujeValuta { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.Saldo.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Saldo { get; set; }

        [DisplayName(AtributClass.TemeljnicaDetalj.SaldoValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> SaldoValuta { get; set; }


        // rucno dodana polja
        public System.DateTime TemeljnicaDatum 
        {
            get { return Datum; }
            set { Datum = value; }
        }


        #endregion

        #region Constructor

        public TemeljnicaDetaljFormFormatted()
        { }

        public TemeljnicaDetaljFormFormatted(Model.Data.View.TemeljnicaDetalj formformated)
        {
            this.ID_Temeljnica = formformated.ID_Temeljnica;
            this.ID_TemeljnicaVr = formformated.ID_TemeljnicaVr;
            this.Naziv = formformated.Naziv;
            this.Datum = formformated.Datum;
            this.IDValuta = formformated.IDValuta;
            this.Knjizeno = formformated.Knjizeno;
            this.Storno = formformated.Storno;
            this.PocetnoStanje = formformated.PocetnoStanje;
            this.ZavrsnoKnjizenje = formformated.ZavrsnoKnjizenje;
            this.Oznaka = formformated.Oznaka;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
            this.DatumKnjizenje = formformated.DatumKnjizenje;
            this.Tecaj = formformated.Tecaj;
            this.Opis = formformated.Opis;
            this.SumIznosDuguje = formformated.SumIznosDuguje;
            this.SumIznosPotrazuje = formformated.SumIznosPotrazuje;
            this.SumIznosDugujeValuta = formformated.SumIznosDugujeValuta;
            this.SumIznosPotrazujeValuta = formformated.SumIznosPotrazujeValuta;
            this.Saldo = formformated.Saldo;
            this.SaldoValuta = formformated.SaldoValuta;
        }

        #endregion

    }
}
