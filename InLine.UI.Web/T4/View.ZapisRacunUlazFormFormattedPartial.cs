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
    
    
    public partial class ZapisRacunUlazFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_Zapis.DisplayName)]
       	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.IDZapisTablica.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.IDZapisTablica.DisplayName)]
       	public int IDZapisTablica { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.IDZapisVr.DisplayName)]
       	public Nullable<int> IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.IDZapis.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.IDZapis.DisplayName)]
       	public long IDZapis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.VrijemeUpis.DisplayName)]
       	public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisRacunUlaz.UrudzbeniBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.UrudzbeniBroj.DisplayName)]
       	public string UrudzbeniBroj { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisRacunUlaz.Predmet.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.Predmet.DisplayName)]
       	public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_SubjektUpis.DisplayName)]
       	public Nullable<long> ID_SubjektUpis { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisRacunUlaz.Broj.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.Vrijeme.DisplayName)]
       	public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZapisRacunUlaz.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisRacunUlaz.Naziv.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisRacunUlaz.NazivKr.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.Odabir.DisplayName)]
       	public Nullable<bool> Odabir { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ZapisRacunUlaz.DatumGodina.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.DatumGodina.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.DatumGodina.DisplayName)]
       	public string DatumGodina { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisRacunUlaz.VrijemeUpisString.StringLength)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.VrijemeUpisString.DisplayName)]
       	public string VrijemeUpisString { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisRacunUlaz.DatumString.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.DatumString.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.DatumString.DisplayName)]
       	public string DatumString { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.ID_RacunUlaz.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_RacunUlaz.DisplayName)]
       	public long ID_RacunUlaz { get; set; }
    
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_ZapisRacunUlaz.DisplayName)]
       	public Nullable<long> ID_ZapisRacunUlaz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisRacunUlaz.ID_SubjektRacunUlaz.Required)]
    	[DisplayName(AtributClass.ZapisRacunUlaz.ID_SubjektRacunUlaz.DisplayName)]
       	public long ID_SubjektRacunUlaz { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisRacunUlazFormFormattedBase()
        { }
    	
    	public ZapisRacunUlazFormFormattedBase(Model.Data.View.ZapisRacunUlaz formformated)
    	{
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.IDZapisTablica = formformated.IDZapisTablica;
    	    this.IDZapisVr = formformated.IDZapisVr;
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
    	    this.ID_RacunUlaz = formformated.ID_RacunUlaz;
    	    this.ID_ZapisRacunUlaz = formformated.ID_ZapisRacunUlaz;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_SubjektRacunUlaz = formformated.ID_SubjektRacunUlaz;
    	}
    
    	/*
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDZapisTablica = model.IDZapisTablica;
    	    mymodel.IDZapisVr = model.IDZapisVr;
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
    	    mymodel.ID_RacunUlaz = model.ID_RacunUlaz;
    	    mymodel.ID_ZapisRacunUlaz = model.ID_ZapisRacunUlaz;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_SubjektRacunUlaz = model.ID_SubjektRacunUlaz;
    		
    	*/
    
    		#endregion
    	
    }
}