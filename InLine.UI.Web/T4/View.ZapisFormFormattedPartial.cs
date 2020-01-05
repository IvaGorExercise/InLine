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
    
    
    public partial class ZapisFormFormattedBase
    {
    	#region Properities
    
    	[DisplayName(AtributClass.Zapis.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapisTablica.DisplayName)]
       	public Nullable<int> IDZapisTablica { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapisVr.DisplayName)]
       	public Nullable<int> IDZapisVr { get; set; }
    
    	[DisplayName(AtributClass.Zapis.IDZapis.DisplayName)]
       	public Nullable<long> IDZapis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Zapis.VrijemeUpis.DisplayName)]
       	public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Zapis.UrudzbeniBroj.StringLength)]
    	[DisplayName(AtributClass.Zapis.UrudzbeniBroj.DisplayName)]
       	public string UrudzbeniBroj { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Zapis.Predmet.StringLength)]
    	[DisplayName(AtributClass.Zapis.Predmet.DisplayName)]
       	public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_SubjektUpis.DisplayName)]
       	public Nullable<long> ID_SubjektUpis { get; set; }
    
    	[DisplayName(AtributClass.Zapis.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Zapis.Broj.StringLength)]
    	[DisplayName(AtributClass.Zapis.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Zapis.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.Zapis.Vrijeme.DisplayName)]
       	public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.Zapis.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.Zapis.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Zapis.Naziv.StringLength)]
    	[DisplayName(AtributClass.Zapis.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.NazivKr.StringLength)]
    	[DisplayName(AtributClass.Zapis.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	[DisplayName(AtributClass.Zapis.Odabir.DisplayName)]
       	public Nullable<bool> Odabir { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Zapis.DatumGodina.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.DatumGodina.Required)]
    	[DisplayName(AtributClass.Zapis.DatumGodina.DisplayName)]
       	public string DatumGodina { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.VrijemeUpisString.StringLength)]
    	[DisplayName(AtributClass.Zapis.VrijemeUpisString.DisplayName)]
       	public string VrijemeUpisString { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Zapis.DatumString.StringLength)]
        [Required(ErrorMessage = AtributClass.Zapis.DatumString.Required)]
    	[DisplayName(AtributClass.Zapis.DatumString.DisplayName)]
       	public string DatumString { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisFormFormattedBase()
        { }
    	
    	public ZapisFormFormattedBase(Model.Data.View.Zapis formformated)
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
    		
    	*/
    
    		#endregion
    	
    }
}
