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
    
    
    public partial class ZapisUgovorStanOtkupAneksFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisTablica.DisplayName)]
       	public int IDZapisTablica { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapisVr.DisplayName)]
       	public Nullable<int> IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Zapis.DisplayName)]
       	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.IDZapis.DisplayName)]
       	public long IDZapis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpis.DisplayName)]
       	public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.UrudzbeniBroj.DisplayName)]
       	public string UrudzbeniBroj { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Predmet.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Predmet.DisplayName)]
       	public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_SubjektUpis.DisplayName)]
       	public Nullable<long> ID_SubjektUpis { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Broj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Vrijeme.DisplayName)]
       	public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Naziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Odabir.DisplayName)]
       	public Nullable<bool> Odabir { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.DatumGodina.DisplayName)]
       	public string DatumGodina { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.VrijemeUpisString.DisplayName)]
       	public string VrijemeUpisString { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumString.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.DatumString.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.DatumString.DisplayName)]
       	public string DatumString { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupAneks.DisplayName)]
       	public long ID_UgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_ZapisUgovorStanOtkupAneks.DisplayName)]
       	public Nullable<long> ID_ZapisUgovorStanOtkupAneks { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_UgovorStanOtkupKupac.DisplayName)]
       	public long ID_UgovorStanOtkupKupac { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Kupac.DisplayName)]
       	public long ID_Kupac { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KupacNaziv.DisplayName)]
       	public string KupacNaziv { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.JMBG.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.JMBG.DisplayName)]
       	public string JMBG { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ulica.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Ulica.DisplayName)]
       	public string Ulica { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KucniBroj.DisplayName)]
       	public string KucniBroj { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KucniBrojDodatak.DisplayName)]
       	public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OIB.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Posta.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Posta.DisplayName)]
       	public string Posta { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OsobaID_Subjekt.DisplayName)]
       	public Nullable<long> OsobaID_Subjekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.OsobaOznaka.DisplayName)]
       	public string OsobaOznaka { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Prezime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Prezime.DisplayName)]
       	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkupAneks.Ime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.Ime.DisplayName)]
       	public string Ime { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkupAneks.KupacID_Subjekt.DisplayName)]
       	public Nullable<long> KupacID_Subjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisUgovorStanOtkupAneksFormFormattedBase()
        { }
    	
    	public ZapisUgovorStanOtkupAneksFormFormattedBase(Model.Data.View.ZapisUgovorStanOtkupAneks formformated)
    	{
    	    this.IDZapisTablica = formformated.IDZapisTablica;
    	    this.IDZapisVr = formformated.IDZapisVr;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.IDZapis = formformated.IDZapis;
    	    this.VrijemeUpis = formformated.VrijemeUpis;
    	    this.UrudzbeniBroj = formformated.UrudzbeniBroj;
    	    this.Predmet = formformated.Predmet;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.ID_SubjektUpis = formformated.ID_SubjektUpis;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.Broj = formformated.Broj;
    	    this.Datum = formformated.Datum;
    	    this.Vrijeme = formformated.Vrijeme;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Odabir = formformated.Odabir;
    	    this.DatumGodina = formformated.DatumGodina;
    	    this.VrijemeUpisString = formformated.VrijemeUpisString;
    	    this.DatumString = formformated.DatumString;
    	    this.ID_UgovorStanOtkupAneks = formformated.ID_UgovorStanOtkupAneks;
    	    this.ID_ZapisUgovorStanOtkupAneks = formformated.ID_ZapisUgovorStanOtkupAneks;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.ID_UgovorStanOtkupKupac = formformated.ID_UgovorStanOtkupKupac;
    	    this.ID_Kupac = formformated.ID_Kupac;
    	    this.Oznaka = formformated.Oznaka;
    	    this.KupacNaziv = formformated.KupacNaziv;
    	    this.JMBG = formformated.JMBG;
    	    this.Ulica = formformated.Ulica;
    	    this.KucniBroj = formformated.KucniBroj;
    	    this.KucniBrojDodatak = formformated.KucniBrojDodatak;
    	    this.OIB = formformated.OIB;
    	    this.Posta = formformated.Posta;
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.OsobaID_Subjekt = formformated.OsobaID_Subjekt;
    	    this.OsobaOznaka = formformated.OsobaOznaka;
    	    this.Prezime = formformated.Prezime;
    	    this.Ime = formformated.Ime;
    	    this.KupacID_Subjekt = formformated.KupacID_Subjekt;
    	}
    
    	/*
    	    mymodel.IDZapisTablica = model.IDZapisTablica;
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDZapis = model.IDZapis;
    	    mymodel.VrijemeUpis = model.VrijemeUpis;
    	    mymodel.UrudzbeniBroj = model.UrudzbeniBroj;
    	    mymodel.Predmet = model.Predmet;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_SubjektUpis = model.ID_SubjektUpis;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Datum = model.Datum;
    	    mymodel.Vrijeme = model.Vrijeme;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Odabir = model.Odabir;
    	    mymodel.DatumGodina = model.DatumGodina;
    	    mymodel.VrijemeUpisString = model.VrijemeUpisString;
    	    mymodel.DatumString = model.DatumString;
    	    mymodel.ID_UgovorStanOtkupAneks = model.ID_UgovorStanOtkupAneks;
    	    mymodel.ID_ZapisUgovorStanOtkupAneks = model.ID_ZapisUgovorStanOtkupAneks;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
    	    mymodel.ID_Kupac = model.ID_Kupac;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.KupacNaziv = model.KupacNaziv;
    	    mymodel.JMBG = model.JMBG;
    	    mymodel.Ulica = model.Ulica;
    	    mymodel.KucniBroj = model.KucniBroj;
    	    mymodel.KucniBrojDodatak = model.KucniBrojDodatak;
    	    mymodel.OIB = model.OIB;
    	    mymodel.Posta = model.Posta;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.OsobaID_Subjekt = model.OsobaID_Subjekt;
    	    mymodel.OsobaOznaka = model.OsobaOznaka;
    	    mymodel.Prezime = model.Prezime;
    	    mymodel.Ime = model.Ime;
    	    mymodel.KupacID_Subjekt = model.KupacID_Subjekt;
    		
    	*/
    
    		#endregion
    	
    }
}
