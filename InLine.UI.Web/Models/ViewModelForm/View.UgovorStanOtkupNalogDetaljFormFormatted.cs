﻿using System;
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


namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{

    public partial class UgovorStanOtkupNalogDetaljFormFormatted
    {
      #region Properities
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumPlacanje.DisplayName)]
       	public Nullable<System.DateTime> DatumPlacanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Iznos.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Iznos { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaNalog.DisplayName)]
       	public int GodinaNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojNalog.DisplayName)]
       	public int BrojNalog { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Nalog.DisplayName)]
        public long ID_Nalog { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosTecajnaRazlika { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IznosTecajnaRazlika2.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosTecajnaRazlika2 { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojObrok.DisplayName)]
       	public Nullable<int> BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojIzvod.DisplayName)]
       	public Nullable<int> BrojIzvod { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojObveznica.DisplayName)]
       	public Nullable<int> BrojObveznica { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DokumentGrupa.DisplayName)]
       	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DokumentVrsta.DisplayName)]
       	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_Racun.DisplayName)]
       	public Nullable<long> ID_Racun { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.ID_UgovorStanOtkupAneks.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaObracun.DisplayName)]
       	public Nullable<int> GodinaObracun { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SlovimaIznos.DisplayName)]
       	public string SlovimaIznos { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.GodinaRjesenje.DisplayName)]
       	public Nullable<int> GodinaRjesenje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.BrojRjesenje.DisplayName)]
       	public Nullable<int> BrojRjesenje { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Storno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Storno.DisplayName)]
       	public bool Storno { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.DatumRjesenje.DisplayName)]
       	public Nullable<System.DateTime> DatumRjesenje { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.OpisPovrat.DisplayName)]
       	public string OpisPovrat { get; set; }
    
    	
        [StringLength(6, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SifraSubjekt.DisplayName)]
       	public string SifraSubjekt { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.SifraRacun.DisplayName)]
       	public string SifraRacun { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.VeznaOznaka.DisplayName)]
       	public string VeznaOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Svrha.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Svrha.DisplayName)]
       	public string Svrha { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojZaduzenja.DisplayName)]
       	public string PozivNaBrojZaduzenja { get; set; }
    
    	
        [StringLength(24, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.PozivNaBrojOdobrenja.DisplayName)]
       	public string PozivNaBrojOdobrenja { get; set; }
    
    	
        [StringLength(18, ErrorMessage = AtributClass.UgovorStanOtkupNalogDetalj.Racun.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupNalogDetalj.Racun.DisplayName)]
       	public string Racun { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupNalogDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupNalogDetaljFormFormatted(Model.Data.View.UgovorStanOtkupNalogDetalj formformated)
    	{
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.DatumPlacanje = formformated.DatumPlacanje;
    	    this.Iznos = formformated.Iznos;
    	    this.GodinaNalog = formformated.GodinaNalog;
    	    this.BrojNalog = formformated.BrojNalog;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.ID_Nalog = formformated.ID_Nalog;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.IznosValuta = formformated.IznosValuta;
    	    this.IznosTecajnaRazlika = formformated.IznosTecajnaRazlika;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosTecajnaRazlika2 = formformated.IznosTecajnaRazlika2;
    	    this.IDValuta = formformated.IDValuta;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.BrojIzvod = formformated.BrojIzvod;
    	    this.BrojObveznica = formformated.BrojObveznica;
    	    this.DokumentGrupa = formformated.DokumentGrupa;
    	    this.DokumentVrsta = formformated.DokumentVrsta;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.ID_Racun = formformated.ID_Racun;
    	    this.ID_UgovorStanOtkupAneks = formformated.ID_UgovorStanOtkupAneks;
    	    this.GodinaObracun = formformated.GodinaObracun;
    	    this.SlovimaIznos = formformated.SlovimaIznos;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.GodinaRjesenje = formformated.GodinaRjesenje;
    	    this.BrojRjesenje = formformated.BrojRjesenje;
    	    this.Storno = formformated.Storno;
    	    this.DatumRjesenje = formformated.DatumRjesenje;
    	    this.OpisPovrat = formformated.OpisPovrat;
    	    this.SifraSubjekt = formformated.SifraSubjekt;
    	    this.SifraRacun = formformated.SifraRacun;
    	    this.VeznaOznaka = formformated.VeznaOznaka;
    	    this.Svrha = formformated.Svrha;
    	    this.PozivNaBrojZaduzenja = formformated.PozivNaBrojZaduzenja;
    	    this.PozivNaBrojOdobrenja = formformated.PozivNaBrojOdobrenja;
    	    this.Racun = formformated.Racun;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.DatumPlacanje = model.DatumPlacanje;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.GodinaNalog = model.GodinaNalog;
    	    mymodel.BrojNalog = model.BrojNalog;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.ID_Nalog = model.ID_Nalog;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.IznosValuta = model.IznosValuta;
    	    mymodel.IznosTecajnaRazlika = model.IznosTecajnaRazlika;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosTecajnaRazlika2 = model.IznosTecajnaRazlika2;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.BrojIzvod = model.BrojIzvod;
    	    mymodel.BrojObveznica = model.BrojObveznica;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_Racun = model.ID_Racun;
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.GodinaObracun = model.GodinaObracun;
    	    mymodel.SlovimaIznos = model.SlovimaIznos;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.GodinaRjesenje = model.GodinaRjesenje;
    	    mymodel.BrojRjesenje = model.BrojRjesenje;
    	    mymodel.Storno = model.Storno;
    	    mymodel.DatumRjesenje = model.DatumRjesenje;
    	    mymodel.OpisPovrat = model.OpisPovrat;
    	    mymodel.SifraSubjekt = model.SifraSubjekt;
    	    mymodel.SifraRacun = model.SifraRacun;
    	    mymodel.VeznaOznaka = model.VeznaOznaka;
    	    mymodel.Svrha = model.Svrha;
    	    mymodel.PozivNaBrojZaduzenja = model.PozivNaBrojZaduzenja;
    	    mymodel.PozivNaBrojOdobrenja = model.PozivNaBrojOdobrenja;
    	    mymodel.Racun = model.Racun;
    		
    	*/
    
    		#endregion

    }
}
