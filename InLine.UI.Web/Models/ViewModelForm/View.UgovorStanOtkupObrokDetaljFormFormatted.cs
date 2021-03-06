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

    public partial class UgovorStanOtkupObrokDetaljFormFormatted
    {
        #region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.BrojObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.BrojObrok.DisplayName)]
       	public int BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.Godina.DisplayName)]
       	public Nullable<int> Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkupObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkupObrok.DisplayName)]
        public long ID_UgovorStanOtkupObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkupMoratorij.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.Mjesec.DisplayName)]
       	public Nullable<int> Mjesec { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.MjesecGeneriranja.DisplayName)]
       	public Nullable<int> MjesecGeneriranja { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosJednokratno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosUcesce.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.GodinaGeneriranja.DisplayName)]
       	public Nullable<int> GodinaGeneriranja { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosPopust.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosPopust.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPopust { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKredit.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKreditRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKamata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKamataRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKreditOstatakRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKreditOstatakRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditOstatakRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosKamataOstatakRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosKamataOstatakRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataOstatakRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosZateznaKamata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosZateznaKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosMoratorij.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosMoratorij { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IDValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IznosValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosValuta { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.DatumDospijece.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijece { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.TecajUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.TecajUgovor.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
    	public decimal TecajUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.TecajObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.TecajObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
    	public decimal TecajObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.Placen.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.Placen.DisplayName)]
       	public bool Placen { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.IzPreplate.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.IzPreplate.DisplayName)]
       	public bool IzPreplate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkupAneks.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupAneks { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokDetalj.SumaObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> SumaObrok { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupObrokDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupObrokDetaljFormFormatted(Model.Data.View.UgovorStanOtkupObrokDetalj formformated)
    	{
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.Godina = formformated.Godina;
    	    this.ID_UgovorStanOtkupObrok = formformated.ID_UgovorStanOtkupObrok;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.ID_UgovorStanOtkupMoratorij = formformated.ID_UgovorStanOtkupMoratorij;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.Mjesec = formformated.Mjesec;
    	    this.MjesecGeneriranja = formformated.MjesecGeneriranja;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.GodinaGeneriranja = formformated.GodinaGeneriranja;
    	    this.IznosPopust = formformated.IznosPopust;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKreditOstatakRevalorizacija = formformated.IznosKreditOstatakRevalorizacija;
    	    this.IznosKamataOstatakRevalorizacija = formformated.IznosKamataOstatakRevalorizacija;
    	    this.IznosZateznaKamata = formformated.IznosZateznaKamata;
    	    this.IznosMoratorij = formformated.IznosMoratorij;
    	    this.IDValuta = formformated.IDValuta;
    	    this.IznosValuta = formformated.IznosValuta;
    	    this.DatumDospijece = formformated.DatumDospijece;
    	    this.TecajUgovor = formformated.TecajUgovor;
    	    this.TecajObrok = formformated.TecajObrok;
    	    this.Placen = formformated.Placen;
    	    this.IzPreplate = formformated.IzPreplate;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.ID_UgovorStanOtkupAneks = formformated.ID_UgovorStanOtkupAneks;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.SumaObrok = formformated.SumaObrok;
    	}
    
    	/*
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.Godina = model.Godina;
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.MjesecGeneriranja = model.MjesecGeneriranja;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.GodinaGeneriranja = model.GodinaGeneriranja;
    	    mymodel.IznosPopust = model.IznosPopust;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKreditOstatakRevalorizacija = model.IznosKreditOstatakRevalorizacija;
    	    mymodel.IznosKamataOstatakRevalorizacija = model.IznosKamataOstatakRevalorizacija;
    	    mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
    	    mymodel.IznosMoratorij = model.IznosMoratorij;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.IznosValuta = model.IznosValuta;
    	    mymodel.DatumDospijece = model.DatumDospijece;
    	    mymodel.TecajUgovor = model.TecajUgovor;
    	    mymodel.TecajObrok = model.TecajObrok;
    	    mymodel.Placen = model.Placen;
    	    mymodel.IzPreplate = model.IzPreplate;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.SumaObrok = model.SumaObrok;
    		
    	*/
    
    		#endregion
    }
}
