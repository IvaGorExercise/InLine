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
    
    
    public partial class OsobaDetaljFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OsobaDetalj.ID_Osoba.Required)]
    	[DisplayName(AtributClass.OsobaDetalj.ID_Osoba.DisplayName)]
        	public long ID_Osoba { get; set; }
    
    	[DisplayName(AtributClass.OsobaDetalj.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.OsobaDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.OsobaDetalj.Oznaka.Required)]
    	[DisplayName(AtributClass.OsobaDetalj.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.OsobaDetalj.Prezime.Required)]
    	[DisplayName(AtributClass.OsobaDetalj.Prezime.DisplayName)]
       	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.OsobaDetalj.Ime.Required)]
    	[DisplayName(AtributClass.OsobaDetalj.Ime.DisplayName)]
       	public string Ime { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OsobaDetalj.DatumRodenja.Required)]
    	[DisplayName(AtributClass.OsobaDetalj.DatumRodenja.DisplayName)]
       	public System.DateTime DatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OsobaDetalj.MjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.MjestoRodenja.DisplayName)]
       	public string MjestoRodenja { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.OtacPrezime.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.OtacPrezime.DisplayName)]
       	public string OtacPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.OtacIme.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.OtacIme.DisplayName)]
       	public string OtacIme { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaDetalj.OtacDatumRodenja.DisplayName)]
       	public Nullable<System.DateTime> OtacDatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OsobaDetalj.OtacMjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.OtacMjestoRodenja.DisplayName)]
       	public string OtacMjestoRodenja { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.MajkaPrezime.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.MajkaPrezime.DisplayName)]
       	public string MajkaPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.MajkaIme.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.MajkaIme.DisplayName)]
       	public string MajkaIme { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.MajkaPrezimeDjevojacko.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.MajkaPrezimeDjevojacko.DisplayName)]
       	public string MajkaPrezimeDjevojacko { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaDetalj.MajkaDatumRodenja.DisplayName)]
       	public Nullable<System.DateTime> MajkaDatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OsobaDetalj.MajkaMjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.MajkaMjestoRodenja.DisplayName)]
       	public string MajkaMjestoRodenja { get; set; }
    
    	[DisplayName(AtributClass.OsobaDetalj.ID_Narodnost.DisplayName)]
       	public Nullable<long> ID_Narodnost { get; set; }
    
    	[DisplayName(AtributClass.OsobaDetalj.ID_Drzavljanstvo.DisplayName)]
       	public Nullable<long> ID_Drzavljanstvo { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaDetalj.DatumSmrti.DisplayName)]
       	public Nullable<System.DateTime> DatumSmrti { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.OIB.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.OsobaDetalj.OIBHR.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.OIBHR.DisplayName)]
       	public string OIBHR { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.OsobaDetalj.JMBG.StringLength)]
    	[DisplayName(AtributClass.OsobaDetalj.JMBG.DisplayName)]
       	public string JMBG { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OsobaDetaljFormFormattedBase()
        { }
    	
    	public OsobaDetaljFormFormattedBase(Model.Data.View.OsobaDetalj formformated)
    	{
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Prezime = formformated.Prezime;
    	    this.Ime = formformated.Ime;
    	    this.DatumRodenja = formformated.DatumRodenja;
    	    this.MjestoRodenja = formformated.MjestoRodenja;
    	    this.OtacPrezime = formformated.OtacPrezime;
    	    this.OtacIme = formformated.OtacIme;
    	    this.OtacDatumRodenja = formformated.OtacDatumRodenja;
    	    this.OtacMjestoRodenja = formformated.OtacMjestoRodenja;
    	    this.MajkaPrezime = formformated.MajkaPrezime;
    	    this.MajkaIme = formformated.MajkaIme;
    	    this.MajkaPrezimeDjevojacko = formformated.MajkaPrezimeDjevojacko;
    	    this.MajkaDatumRodenja = formformated.MajkaDatumRodenja;
    	    this.MajkaMjestoRodenja = formformated.MajkaMjestoRodenja;
    	    this.ID_Narodnost = formformated.ID_Narodnost;
    	    this.ID_Drzavljanstvo = formformated.ID_Drzavljanstvo;
    	    this.DatumSmrti = formformated.DatumSmrti;
    	    this.OIB = formformated.OIB;
    	    this.OIBHR = formformated.OIBHR;
    	    this.JMBG = formformated.JMBG;
    	}
    
    	/*
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Prezime = model.Prezime;
    	    mymodel.Ime = model.Ime;
    	    mymodel.DatumRodenja = model.DatumRodenja;
    	    mymodel.MjestoRodenja = model.MjestoRodenja;
    	    mymodel.OtacPrezime = model.OtacPrezime;
    	    mymodel.OtacIme = model.OtacIme;
    	    mymodel.OtacDatumRodenja = model.OtacDatumRodenja;
    	    mymodel.OtacMjestoRodenja = model.OtacMjestoRodenja;
    	    mymodel.MajkaPrezime = model.MajkaPrezime;
    	    mymodel.MajkaIme = model.MajkaIme;
    	    mymodel.MajkaPrezimeDjevojacko = model.MajkaPrezimeDjevojacko;
    	    mymodel.MajkaDatumRodenja = model.MajkaDatumRodenja;
    	    mymodel.MajkaMjestoRodenja = model.MajkaMjestoRodenja;
    	    mymodel.ID_Narodnost = model.ID_Narodnost;
    	    mymodel.ID_Drzavljanstvo = model.ID_Drzavljanstvo;
    	    mymodel.DatumSmrti = model.DatumSmrti;
    	    mymodel.OIB = model.OIB;
    	    mymodel.OIBHR = model.OIBHR;
    	    mymodel.JMBG = model.JMBG;
    		
    	*/
    
    		#endregion
    	
    }
}
