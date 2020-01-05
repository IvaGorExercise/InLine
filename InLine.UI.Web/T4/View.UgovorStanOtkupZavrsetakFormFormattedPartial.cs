//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class UgovorStanOtkupZavrsetakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorStanOtkupZavrsetak.DisplayName)]
        	public long ID_UgovorStanOtkupZavrsetak { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_UgovorstanOtkup.DisplayName)]
       	public long ID_UgovorstanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Datum.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.Datum.DisplayName)]
       	public System.DateTime Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.DokumentVrsta.DisplayName)]
       	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.DokumentGrupa.DisplayName)]
       	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_DokumentVr.DisplayName)]
       	public Nullable<long> ID_DokumentVr { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Razlog.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.Razlog.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.Razlog.DisplayName)]
       	public string Razlog { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosJednokratno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupZavrsetak.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupZavrsetakFormFormattedBase()
        { }
    	
    	public UgovorStanOtkupZavrsetakFormFormattedBase(Model.Data.View.UgovorStanOtkupZavrsetak formformated)
    	{
    	    this.ID_UgovorStanOtkupZavrsetak = formformated.ID_UgovorStanOtkupZavrsetak;
    	    this.ID_UgovorstanOtkup = formformated.ID_UgovorstanOtkup;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.Datum = formformated.Datum;
    	    this.DokumentVrsta = formformated.DokumentVrsta;
    	    this.DokumentGrupa = formformated.DokumentGrupa;
    	    this.ID_DokumentVr = formformated.ID_DokumentVr;
    	    this.Razlog = formformated.Razlog;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupZavrsetak = model.ID_UgovorStanOtkupZavrsetak;
    	    mymodel.ID_UgovorstanOtkup = model.ID_UgovorstanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.Datum = model.Datum;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.ID_DokumentVr = model.ID_DokumentVr;
    	    mymodel.Razlog = model.Razlog;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    		
    	*/
    
    		#endregion
    	
    }
}