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


    public partial class UgovorStanOtkupAneksDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.ID_UgovorStanOtkupAneks.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_UgovorStanOtkupAneks.DisplayName)]
        public long ID_UgovorStanOtkupAneks { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_Zapis.DisplayName)]
        public Nullable<long> ID_Zapis { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_UgovorStanOtkup.DisplayName)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojUgovor.DisplayName)]
        public int BrojUgovor { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.BrojAneks.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojAneks.DisplayName)]
        [Range(1, 1000, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        public int BrojAneks { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.BrojStorno.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojStorno.DisplayName)]
        public int BrojStorno { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.Datum.DisplayName)]
        public Nullable<System.DateTime> Datum { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosUcesce.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosUcesce { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosUcescePlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosUcescePlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosUcescePlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosUcesceNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosUcesceNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosUcesceNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKredit.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKredit { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditPlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacija.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditRevalorizacija { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacijaPlaceno.Required)]
        //[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacijaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditRevalorizacijaPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacijaNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditRevalorizacijaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamata.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamata { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataPlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacija.Required)]
        //[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataRevalorizacija { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacijaPlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacijaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataRevalorizacijaPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacijaNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataRevalorizacijaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoPlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratnoPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratnoNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValuta.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratnoValuta { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValutaPlaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValutaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratnoValutaPlaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValutaNeplaceno.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosJednokratnoValutaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosJednokratnoValutaNeplaceno { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditObrok.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKreditObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKreditObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataObrok.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosKamataObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKamataObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosUkupnoObrok.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosUkupnoObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosUkupnoObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosTrosakSud.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosTrosakSud.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosTrosakSud { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosPovrat.Required)]
        [Range(0.000, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IznosPovrat.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosPovrat { get; set; }

        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IDValuta.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosPovrat.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.TecajDM.DisplayName)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        public Nullable<decimal> TecajDM { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosUcesce.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojObrok.DisplayName)]
        public Nullable<int> BrojObrok { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojObrokDospjelo.DisplayName)]
        public Nullable<int> BrojObrokDospjelo { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.NadstojnickiAdaptiran.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.NadstojnickiAdaptiran.DisplayName)]
        public bool NadstojnickiAdaptiran { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.TemeljnicaGodina.DisplayName)]
        public Nullable<int> TemeljnicaGodina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.TemeljnicaVrsta.DisplayName)]
        public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.TemeljnicaBroj.DisplayName)]
        public Nullable<int> TemeljnicaBroj { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.DokumentGrupa.DisplayName)]
        public Nullable<int> DokumentGrupa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.DokumentVrsta.DisplayName)]
        public Nullable<int> DokumentVrsta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.DatumInsert.DisplayName)]
        public Nullable<System.DateTime> DatumInsert { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.OsobaInsert.DisplayName)]
        public string OsobaInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.DatumUpdate.DisplayName)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.OsobaUpdate.DisplayName)]
        public string OsobaUpdate { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_OsobaInsert.DisplayName)]
        public Nullable<long> ID_OsobaInsert { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_OsobaUpdate.DisplayName)]
        public Nullable<long> ID_OsobaUpdate { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.BrojObrokOd.DisplayName)]
        public Nullable<int> BrojObrokOd { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.IznosPovrat.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.ID_DokumentVr.DisplayName)]
        public Nullable<long> ID_DokumentVr { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.Godina.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.Godina.DisplayName)]
        public int Godina { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupAneksDetalj.Mjesec.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupAneksDetalj.Mjesec.DisplayName)]
        public int Mjesec { get; set; }


        // rucno dodana polja
        public Nullable<System.DateTime> DatumAneks
        {
            get { return Datum; }
            set { Datum = value; }
        }

        [DisplayName("Kontrolni broj")]
        public int KontrolniBroj { get; set; }

        [DisplayName("Obročni")]
        public int ObrocniAneks { get; set; }

        [DisplayName("Jednokratni")]
        public int JednokratniAneks { get; set; }

        [DisplayName("Vrsta ugovora")]
        public int VrstaUgovoraAneks { get; set; }

        [DisplayName("Jednokratni")]
        public string VrstaUgovoraNazivAneks { get; set; }

        public String DokumentVrstaOznakaAneks { get; set; }


        #endregion

        #region Constructor

        public UgovorStanOtkupAneksDetaljFormFormatted()
        { }

        public UgovorStanOtkupAneksDetaljFormFormatted(Model.Data.View.UgovorStanOtkupAneksDetalj formformated)
        {
            this.ID_UgovorStanOtkupAneks = formformated.ID_UgovorStanOtkupAneks;
            this.ID_Zapis = formformated.ID_Zapis;
            this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
            this.BrojUgovor = formformated.BrojUgovor;
            this.BrojAneks = formformated.BrojAneks;
            this.BrojStorno = formformated.BrojStorno;
            this.Datum = formformated.Datum;
            this.IznosUcesce = formformated.IznosUcesce;
            this.IznosUcescePlaceno = formformated.IznosUcescePlaceno;
            this.IznosUcesceNeplaceno = formformated.IznosUcesceNeplaceno;
            this.IznosKredit = formformated.IznosKredit;
            this.IznosKreditPlaceno = formformated.IznosKreditPlaceno;
            this.IznosKreditNeplaceno = formformated.IznosKreditNeplaceno;
            this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
            this.IznosKreditRevalorizacijaPlaceno = formformated.IznosKreditRevalorizacijaPlaceno;
            this.IznosKreditRevalorizacijaNeplaceno = formformated.IznosKreditRevalorizacijaNeplaceno;
            this.IznosKamata = formformated.IznosKamata;
            this.IznosKamataPlaceno = formformated.IznosKamataPlaceno;
            this.IznosKamataNeplaceno = formformated.IznosKamataNeplaceno;
            this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
            this.IznosKamataRevalorizacijaPlaceno = formformated.IznosKamataRevalorizacijaPlaceno;
            this.IznosKamataRevalorizacijaNeplaceno = formformated.IznosKamataRevalorizacijaNeplaceno;
            this.IznosJednokratno = formformated.IznosJednokratno;
            this.IznosJednokratnoPlaceno = formformated.IznosJednokratnoPlaceno;
            this.IznosJednokratnoNeplaceno = formformated.IznosJednokratnoNeplaceno;
            this.IznosJednokratnoValuta = formformated.IznosJednokratnoValuta;
            this.IznosJednokratnoValutaPlaceno = formformated.IznosJednokratnoValutaPlaceno;
            this.IznosJednokratnoValutaNeplaceno = formformated.IznosJednokratnoValutaNeplaceno;
            this.IznosKreditObrok = formformated.IznosKreditObrok;
            this.IznosKamataObrok = formformated.IznosKamataObrok;
            this.IznosUkupnoObrok = formformated.IznosUkupnoObrok;
            this.IznosTrosakSud = formformated.IznosTrosakSud;
            this.IznosPovrat = formformated.IznosPovrat;
            this.IDValuta = formformated.IDValuta;
            this.TecajDM = formformated.TecajDM;
            this.BrojObrok = formformated.BrojObrok;
            this.BrojObrokDospjelo = formformated.BrojObrokDospjelo;
            this.NadstojnickiAdaptiran = formformated.NadstojnickiAdaptiran;
            this.TemeljnicaGodina = formformated.TemeljnicaGodina;
            this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
            this.TemeljnicaBroj = formformated.TemeljnicaBroj;
            this.DokumentGrupa = formformated.DokumentGrupa;
            this.DokumentVrsta = formformated.DokumentVrsta;
            this.DatumInsert = formformated.DatumInsert;
            this.OsobaInsert = formformated.OsobaInsert;
            this.DatumUpdate = formformated.DatumUpdate;
            this.OsobaUpdate = formformated.OsobaUpdate;
            this.ID_OsobaInsert = formformated.ID_OsobaInsert;
            this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
            this.BrojObrokOd = formformated.BrojObrokOd;
            this.ID_DokumentVr = formformated.ID_DokumentVr;
            this.Godina = formformated.Godina;
            this.Mjesec = formformated.Mjesec;
        }

        /*
            mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
            mymodel.ID_Zapis = model.ID_Zapis;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.BrojAneks = model.BrojAneks;
            mymodel.BrojStorno = model.BrojStorno;
            mymodel.Datum = model.Datum;
            mymodel.IznosUcesce = model.IznosUcesce;
            mymodel.IznosUcescePlaceno = model.IznosUcescePlaceno;
            mymodel.IznosUcesceNeplaceno = model.IznosUcesceNeplaceno;
            mymodel.IznosKredit = model.IznosKredit;
            mymodel.IznosKreditPlaceno = model.IznosKreditPlaceno;
            mymodel.IznosKreditNeplaceno = model.IznosKreditNeplaceno;
            mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
            mymodel.IznosKreditRevalorizacijaPlaceno = model.IznosKreditRevalorizacijaPlaceno;
            mymodel.IznosKreditRevalorizacijaNeplaceno = model.IznosKreditRevalorizacijaNeplaceno;
            mymodel.IznosKamata = model.IznosKamata;
            mymodel.IznosKamataPlaceno = model.IznosKamataPlaceno;
            mymodel.IznosKamataNeplaceno = model.IznosKamataNeplaceno;
            mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
            mymodel.IznosKamataRevalorizacijaPlaceno = model.IznosKamataRevalorizacijaPlaceno;
            mymodel.IznosKamataRevalorizacijaNeplaceno = model.IznosKamataRevalorizacijaNeplaceno;
            mymodel.IznosJednokratno = model.IznosJednokratno;
            mymodel.IznosJednokratnoPlaceno = model.IznosJednokratnoPlaceno;
            mymodel.IznosJednokratnoNeplaceno = model.IznosJednokratnoNeplaceno;
            mymodel.IznosJednokratnoValuta = model.IznosJednokratnoValuta;
            mymodel.IznosJednokratnoValutaPlaceno = model.IznosJednokratnoValutaPlaceno;
            mymodel.IznosJednokratnoValutaNeplaceno = model.IznosJednokratnoValutaNeplaceno;
            mymodel.IznosKreditObrok = model.IznosKreditObrok;
            mymodel.IznosKamataObrok = model.IznosKamataObrok;
            mymodel.IznosUkupnoObrok = model.IznosUkupnoObrok;
            mymodel.IznosTrosakSud = model.IznosTrosakSud;
            mymodel.IznosPovrat = model.IznosPovrat;
            mymodel.IDValuta = model.IDValuta;
            mymodel.TecajDM = model.TecajDM;
            mymodel.BrojObrok = model.BrojObrok;
            mymodel.BrojObrokDospjelo = model.BrojObrokDospjelo;
            mymodel.NadstojnickiAdaptiran = model.NadstojnickiAdaptiran;
            mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
            mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
            mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
            mymodel.DokumentGrupa = model.DokumentGrupa;
            mymodel.DokumentVrsta = model.DokumentVrsta;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.OsobaUpdate = model.OsobaUpdate;
            mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
            mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
            mymodel.BrojObrokOd = model.BrojObrokOd;
            mymodel.ID_DokumentVr = model.ID_DokumentVr;
    		
        */

        #endregion

    }
}
