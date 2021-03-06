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
    
    
    public partial class ObrazacRSmB2005AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ID_ObrazacRSmB2005A.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ID_ObrazacRSmB2005A.DisplayName)]
        	public long ID_ObrazacRSmB2005A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ID_ObrazacRSm.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ID_ObrazacRSm.DisplayName)]
       	public long ID_ObrazacRSm { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.RedniBroj.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.RedniBroj.DisplayName)]
       	public int RedniBroj { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ID_Osoba.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikIdentifikacijskiBroj.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikIdentifikacijskiBroj.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.OsiguranikIdentifikacijskiBroj.DisplayName)]
       	public string OsiguranikIdentifikacijskiBroj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikPrezime.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikPrezime.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.OsiguranikPrezime.DisplayName)]
       	public string OsiguranikPrezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikIme.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.OsiguranikIme.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.OsiguranikIme.DisplayName)]
       	public string OsiguranikIme { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ID_Opcina.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObrazacRSmB2005A.SifraOpcina.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.SifraOpcina.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.SifraOpcina.DisplayName)]
       	public string SifraOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ObrazacRSm2005OsnovaOsiguranja.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ObrazacRSm2005OsnovaOsiguranja.DisplayName)]
       	public int ObrazacRSm2005OsnovaOsiguranja { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmB2005A.OsnovaOsiguranja.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.OsnovaOsiguranja.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.OsnovaOsiguranja.DisplayName)]
       	public string OsnovaOsiguranja { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.ObrazacRSm2005StazSPovecanimTrajanjem.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.ObrazacRSm2005StazSPovecanimTrajanjem.DisplayName)]
       	public int ObrazacRSm2005StazSPovecanimTrajanjem { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.ObrazacRSmB2005A.StazSPovecanimTrajanjem.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.StazSPovecanimTrajanjem.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.StazSPovecanimTrajanjem.DisplayName)]
       	public string StazSPovecanimTrajanjem { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmB2005A.RazdobljeOd.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.RazdobljeOd.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.RazdobljeOd.DisplayName)]
       	public string RazdobljeOd { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmB2005A.RazdobljeDo.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmB2005A.RazdobljeDo.Required)]
    	[DisplayName(AtributClass.ObrazacRSmB2005A.RazdobljeDo.DisplayName)]
       	public string RazdobljeDo { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmB2005A.IznosObracunDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosObracunDohodak { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmB2005A.IznosDoprinosOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosOsnova { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmB2005A.IznosDoprinosMIO1.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosMIO1 { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmB2005A.IznosDoprinosMIO2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosMIO2 { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmB2005A.IznosIsplataDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosIsplataDohodak { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacRSmB2005AFormFormattedBase()
        { }
    	
    	public ObrazacRSmB2005AFormFormattedBase(Model.Data.ObrazacRSmB2005A formformated)
    	{
    	    this.ID_ObrazacRSmB2005A = formformated.ID_ObrazacRSmB2005A;
    	    this.ID_ObrazacRSm = formformated.ID_ObrazacRSm;
    	    this.RedniBroj = formformated.RedniBroj;
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.OsiguranikIdentifikacijskiBroj = formformated.OsiguranikIdentifikacijskiBroj;
    	    this.OsiguranikPrezime = formformated.OsiguranikPrezime;
    	    this.OsiguranikIme = formformated.OsiguranikIme;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.SifraOpcina = formformated.SifraOpcina;
    	    this.ObrazacRSm2005OsnovaOsiguranja = formformated.ObrazacRSm2005OsnovaOsiguranja;
    	    this.OsnovaOsiguranja = formformated.OsnovaOsiguranja;
    	    this.ObrazacRSm2005StazSPovecanimTrajanjem = formformated.ObrazacRSm2005StazSPovecanimTrajanjem;
    	    this.StazSPovecanimTrajanjem = formformated.StazSPovecanimTrajanjem;
    	    this.RazdobljeOd = formformated.RazdobljeOd;
    	    this.RazdobljeDo = formformated.RazdobljeDo;
    	    this.IznosObracunDohodak = formformated.IznosObracunDohodak;
    	    this.IznosDoprinosOsnova = formformated.IznosDoprinosOsnova;
    	    this.IznosDoprinosMIO1 = formformated.IznosDoprinosMIO1;
    	    this.IznosDoprinosMIO2 = formformated.IznosDoprinosMIO2;
    	    this.IznosIsplataDohodak = formformated.IznosIsplataDohodak;
    	}
    
    	/*
    	    mymodel.ID_ObrazacRSmB2005A = model.ID_ObrazacRSmB2005A;
    	    mymodel.ID_ObrazacRSm = model.ID_ObrazacRSm;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.OsiguranikIdentifikacijskiBroj = model.OsiguranikIdentifikacijskiBroj;
    	    mymodel.OsiguranikPrezime = model.OsiguranikPrezime;
    	    mymodel.OsiguranikIme = model.OsiguranikIme;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.SifraOpcina = model.SifraOpcina;
    	    mymodel.ObrazacRSm2005OsnovaOsiguranja = model.ObrazacRSm2005OsnovaOsiguranja;
    	    mymodel.OsnovaOsiguranja = model.OsnovaOsiguranja;
    	    mymodel.ObrazacRSm2005StazSPovecanimTrajanjem = model.ObrazacRSm2005StazSPovecanimTrajanjem;
    	    mymodel.StazSPovecanimTrajanjem = model.StazSPovecanimTrajanjem;
    	    mymodel.RazdobljeOd = model.RazdobljeOd;
    	    mymodel.RazdobljeDo = model.RazdobljeDo;
    	    mymodel.IznosObracunDohodak = model.IznosObracunDohodak;
    	    mymodel.IznosDoprinosOsnova = model.IznosDoprinosOsnova;
    	    mymodel.IznosDoprinosMIO1 = model.IznosDoprinosMIO1;
    	    mymodel.IznosDoprinosMIO2 = model.IznosDoprinosMIO2;
    	    mymodel.IznosIsplataDohodak = model.IznosIsplataDohodak;
    		
    	*/
    
    		#endregion
    	
    }
}
