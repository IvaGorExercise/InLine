//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate
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
    
    
    public partial class UgovorStanOtkupObrokFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.DisplayName)]
        	public long ID_UgovorStanOtkupObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupMoratorij.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojObrok.DisplayName)]
       	public int BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.Godina.DisplayName)]
       	public Nullable<int> Godina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.Mjesec.DisplayName)]
       	public Nullable<int> Mjesec { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.GodinaGeneriranja.DisplayName)]
       	public Nullable<int> GodinaGeneriranja { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.MjesecGeneriranja.DisplayName)]
       	public Nullable<int> MjesecGeneriranja { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosJednokratno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosJednokratno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosUcesce.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosPopust.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosPopust.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPopust { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKredit.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKreditRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKamata.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKamataRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKreditOstatakRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKreditOstatakRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditOstatakRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosKamataOstatakRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosKamataOstatakRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataOstatakRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosMoratorij.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosMoratorij.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosMoratorij { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrok.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IDValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosValuta.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosValuta { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.DatumDospijece.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijece { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.TecajObrok.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.TecajObrok.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal TecajObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.TecajUgovor.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.TecajUgovor.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal TecajUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.Placen.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.Placen.DisplayName)]
       	public bool Placen { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IzPreplate.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IzPreplate.DisplayName)]
       	public bool IzPreplate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupAneks.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupAneks { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrok.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrok.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosObveza.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosObveza { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.IznosPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPlaceno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojMoratorij.DisplayName)]
       	public Nullable<int> BrojMoratorij { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupObrokFormFormattedBase()
        { }
    	
    	public UgovorStanOtkupObrokFormFormattedBase(Model.Data.UgovorStanOtkupObrok formformated)
    	{
    	    this.ID_UgovorStanOtkupObrok = formformated.ID_UgovorStanOtkupObrok;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.ID_UgovorStanOtkupMoratorij = formformated.ID_UgovorStanOtkupMoratorij;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.Godina = formformated.Godina;
    	    this.Mjesec = formformated.Mjesec;
    	    this.GodinaGeneriranja = formformated.GodinaGeneriranja;
    	    this.MjesecGeneriranja = formformated.MjesecGeneriranja;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosPopust = formformated.IznosPopust;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKreditOstatakRevalorizacija = formformated.IznosKreditOstatakRevalorizacija;
    	    this.IznosKamataOstatakRevalorizacija = formformated.IznosKamataOstatakRevalorizacija;
    	    this.IznosMoratorij = formformated.IznosMoratorij;
    	    this.IDValuta = formformated.IDValuta;
    	    this.IznosValuta = formformated.IznosValuta;
    	    this.DatumDospijece = formformated.DatumDospijece;
    	    this.TecajObrok = formformated.TecajObrok;
    	    this.TecajUgovor = formformated.TecajUgovor;
    	    this.Placen = formformated.Placen;
    	    this.IzPreplate = formformated.IzPreplate;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.ID_UgovorStanOtkupAneks = formformated.ID_UgovorStanOtkupAneks;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.IznosZateznaKamata = formformated.IznosZateznaKamata;
    	    this.IznosObveza = formformated.IznosObveza;
    	    this.IznosPlaceno = formformated.IznosPlaceno;
    	    this.BrojMoratorij = formformated.BrojMoratorij;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.GodinaGeneriranja = model.GodinaGeneriranja;
    	    mymodel.MjesecGeneriranja = model.MjesecGeneriranja;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosPopust = model.IznosPopust;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKreditOstatakRevalorizacija = model.IznosKreditOstatakRevalorizacija;
    	    mymodel.IznosKamataOstatakRevalorizacija = model.IznosKamataOstatakRevalorizacija;
    	    mymodel.IznosMoratorij = model.IznosMoratorij;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.IznosValuta = model.IznosValuta;
    	    mymodel.DatumDospijece = model.DatumDospijece;
    	    mymodel.TecajObrok = model.TecajObrok;
    	    mymodel.TecajUgovor = model.TecajUgovor;
    	    mymodel.Placen = model.Placen;
    	    mymodel.IzPreplate = model.IzPreplate;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
    	    mymodel.IznosObveza = model.IznosObveza;
    	    mymodel.IznosPlaceno = model.IznosPlaceno;
    	    mymodel.BrojMoratorij = model.BrojMoratorij;
    		
    	*/
    
    		#endregion
    	
    }
}