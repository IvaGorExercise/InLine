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
    
    
    public partial class OsobaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Osoba.ID_Osoba.Required)]
    	[DisplayName(AtributClass.Osoba.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Prezime.Required)]
    	[DisplayName(AtributClass.Osoba.Prezime.DisplayName)]
       	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Ime.Required)]
    	[DisplayName(AtributClass.Osoba.Ime.DisplayName)]
       	public string Ime { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Osoba.DatumRodenja.Required)]
    	[DisplayName(AtributClass.Osoba.DatumRodenja.DisplayName)]
       	public System.DateTime DatumRodenja { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.MjestoRodenja.StringLength)]
    	[DisplayName(AtributClass.Osoba.MjestoRodenja.DisplayName)]
       	public string MjestoRodenja { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Narodnost.DisplayName)]
       	public Nullable<long> ID_Narodnost { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_Drzavljanstvo.DisplayName)]
       	public Nullable<long> ID_Drzavljanstvo { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIB.StringLength)]
    	[DisplayName(AtributClass.Osoba.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OIBHR.StringLength)]
    	[DisplayName(AtributClass.Osoba.OIBHR.DisplayName)]
       	public string OIBHR { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.OtacIme.StringLength)]
    	[DisplayName(AtributClass.Osoba.OtacIme.DisplayName)]
       	public string OtacIme { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezime.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaPrezime.DisplayName)]
       	public string MajkaPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaIme.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaIme.DisplayName)]
       	public string MajkaIme { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Osoba.MajkaPrezimeDjevojacko.StringLength)]
    	[DisplayName(AtributClass.Osoba.MajkaPrezimeDjevojacko.DisplayName)]
       	public string MajkaPrezimeDjevojacko { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.NazivDrzavljanstvo.StringLength)]
    	[DisplayName(AtributClass.Osoba.NazivDrzavljanstvo.DisplayName)]
       	public string NazivDrzavljanstvo { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Osoba.NazivNarodnost.StringLength)]
    	[DisplayName(AtributClass.Osoba.NazivNarodnost.DisplayName)]
       	public string NazivNarodnost { get; set; }
    
    	[DisplayName(AtributClass.Osoba.ID_PoslovniSubjekt.DisplayName)]
       	public Nullable<long> ID_PoslovniSubjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Osoba.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Osoba.Oznaka.Required)]
    	[DisplayName(AtributClass.Osoba.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.Osoba.JMBG.StringLength)]
    	[DisplayName(AtributClass.Osoba.JMBG.DisplayName)]
       	public string JMBG { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OsobaFormFormattedBase()
        { }
    	
    	public OsobaFormFormattedBase(Model.Data.View.Osoba formformated)
    	{
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.Prezime = formformated.Prezime;
    	    this.Ime = formformated.Ime;
    	    this.DatumRodenja = formformated.DatumRodenja;
    	    this.MjestoRodenja = formformated.MjestoRodenja;
    	    this.ID_Narodnost = formformated.ID_Narodnost;
    	    this.ID_Drzavljanstvo = formformated.ID_Drzavljanstvo;
    	    this.OIB = formformated.OIB;
    	    this.OIBHR = formformated.OIBHR;
    	    this.OtacIme = formformated.OtacIme;
    	    this.MajkaPrezime = formformated.MajkaPrezime;
    	    this.MajkaIme = formformated.MajkaIme;
    	    this.MajkaPrezimeDjevojacko = formformated.MajkaPrezimeDjevojacko;
    	    this.NazivDrzavljanstvo = formformated.NazivDrzavljanstvo;
    	    this.NazivNarodnost = formformated.NazivNarodnost;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.JMBG = formformated.JMBG;
    	}
    
    	/*
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Prezime = model.Prezime;
    	    mymodel.Ime = model.Ime;
    	    mymodel.DatumRodenja = model.DatumRodenja;
    	    mymodel.MjestoRodenja = model.MjestoRodenja;
    	    mymodel.ID_Narodnost = model.ID_Narodnost;
    	    mymodel.ID_Drzavljanstvo = model.ID_Drzavljanstvo;
    	    mymodel.OIB = model.OIB;
    	    mymodel.OIBHR = model.OIBHR;
    	    mymodel.OtacIme = model.OtacIme;
    	    mymodel.MajkaPrezime = model.MajkaPrezime;
    	    mymodel.MajkaIme = model.MajkaIme;
    	    mymodel.MajkaPrezimeDjevojacko = model.MajkaPrezimeDjevojacko;
    	    mymodel.NazivDrzavljanstvo = model.NazivDrzavljanstvo;
    	    mymodel.NazivNarodnost = model.NazivNarodnost;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.JMBG = model.JMBG;
    		
    	*/
    
    		#endregion
    	
    }
}
