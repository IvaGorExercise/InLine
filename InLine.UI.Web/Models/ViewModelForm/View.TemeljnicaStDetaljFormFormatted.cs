
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


    public partial class TemeljnicaStDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_TemeljnicaSt.DisplayName)]
        public long ID_TemeljnicaSt { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_Temeljnica.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Temeljnica.DisplayName)]
        public long ID_Temeljnica { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.RedniBroj.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.RedniBroj.DisplayName)]
        public int RedniBroj { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.Datum.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.Datum.DisplayName)]
        public System.DateTime Datum { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_KontniPlanSt.DisplayName)]
        public long ID_KontniPlanSt { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Subjekt.DisplayName)]
        public Nullable<long> ID_Subjekt { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Objekt.DisplayName)]
        public Nullable<long> ID_Objekt { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Zapis.DisplayName)]
        public Nullable<long> ID_Zapis { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Davanje.DisplayName)]
        public Nullable<long> ID_Davanje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosDuguje.Required)]
        //[Range(0.0001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.IznosDuguje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosDuguje { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosPotrazuje.Required)]
        //[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.IznosPotrazuje.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosPotrazuje { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaStDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IDValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.Required)]
        //[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.IznosDugujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosDugujeValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.Required)]
        //[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.IznosPotrazujeValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosPotrazujeValuta { get; set; }
     
        [Required(ErrorMessage = AtributClass.TemeljnicaStDetalj.Tecaj.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal Tecaj { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_Tecaj.DisplayName)]
        public Nullable<long> ID_Tecaj { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.Opis.DisplayName)]
        public string Opis { get; set; }

        [DisplayName(AtributClass.TemeljnicaStDetalj.ID_KontniPlanAnalitika.DisplayName)]
        public Nullable<long> ID_KontniPlanAnalitika { get; set; }

        [StringLength(50, ErrorMessage = AtributClass.TemeljnicaStDetalj.ZapisOpis.StringLength)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.ZapisOpis.DisplayName)]
        public string ZapisOpis { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.TemeljnicaStDetalj.DatumDospijeca.DisplayName)]
        public Nullable<System.DateTime> DatumDospijeca { get; set; }

        // Rucno dodana pomocna polja
        public long ID_KontniPlan { get; set; }
        public string  KriterijKriterijStList { get; set; }
        public string Konto { get; set; }
        public string Naziv { get; set; }
        public int AnalitikaOd { get; set; }
        public string SubjektNaziv { get; set; }
        public string SubjektOznaka { get; set; }
        public string DocumentNaziv { get; set; }
        public Nullable<int> IDZapisVr { get; set; }
        public string IDKontniPlanAnalitikaIDZapisVr { get; set; }
        public int SubjektDopusteno  { get; set; }
        public int ZapisDopusteno { get; set; }

        #endregion

        #region Constructor

        public TemeljnicaStDetaljFormFormatted()
        { }

        public TemeljnicaStDetaljFormFormatted(Model.Data.View.TemeljnicaStDetalj formformated)
        {
            this.ID_TemeljnicaSt = formformated.ID_TemeljnicaSt;
            this.ID_Temeljnica = formformated.ID_Temeljnica;
            this.RedniBroj = formformated.RedniBroj;
            this.Datum = formformated.Datum;
            this.ID_KontniPlanSt = formformated.ID_KontniPlanSt;
            this.ID_Subjekt = formformated.ID_Subjekt;
            this.ID_Objekt = formformated.ID_Objekt;
            this.ID_Zapis = formformated.ID_Zapis;
            this.ID_Davanje = formformated.ID_Davanje;
            this.IznosDuguje = formformated.IznosDuguje;
            this.IznosPotrazuje = formformated.IznosPotrazuje;
            this.IDValuta = formformated.IDValuta;
            this.IznosDugujeValuta = formformated.IznosDugujeValuta;
            this.IznosPotrazujeValuta = formformated.IznosPotrazujeValuta;
            this.Tecaj = formformated.Tecaj;
            this.ID_Tecaj = formformated.ID_Tecaj;
            this.Opis = formformated.Opis;
            this.ID_KontniPlanAnalitika = formformated.ID_KontniPlanAnalitika;
            this.ZapisOpis = formformated.ZapisOpis;
            this.DatumDospijeca = formformated.DatumDospijeca;

        }

        #endregion

    }

    public class StvkaKriterij
    {
        public string Stavka { get; set; }
        public string Kriterij { get; set; }
    }
}
