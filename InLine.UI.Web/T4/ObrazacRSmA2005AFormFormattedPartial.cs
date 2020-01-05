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
    
    
    public partial class ObrazacRSmA2005AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ID_ObrazacRSmA2005A.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ID_ObrazacRSmA2005A.DisplayName)]
        	public long ID_ObrazacRSmA2005A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ID_ObrazacRSm.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ID_ObrazacRSm.DisplayName)]
       	public long ID_ObrazacRSm { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObrazacRSmA2005A.Identifikator.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.Identifikator.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.Identifikator.DisplayName)]
       	public string Identifikator { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmA2005A.Mjesec.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.Mjesec.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.Mjesec.DisplayName)]
       	public string Mjesec { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmA2005A.Godina.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.Godina.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.Godina.DisplayName)]
       	public string Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.BrojOsiguranika.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.BrojOsiguranika.DisplayName)]
       	public int BrojOsiguranika { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikNaziv.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ObveznikNaziv.DisplayName)]
       	public string ObveznikNaziv { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikAdresa.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikAdresa.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ObveznikAdresa.DisplayName)]
       	public string ObveznikAdresa { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikIdentifikacijskiBroj.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikIdentifikacijskiBroj.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ObveznikIdentifikacijskiBroj.DisplayName)]
       	public string ObveznikIdentifikacijskiBroj { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikVrsta.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacRSmA2005A.ObveznikVrsta.Required)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.ObveznikVrsta.DisplayName)]
       	public string ObveznikVrsta { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmA2005A.IznosObracunDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosObracunDohodak { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmA2005A.IznosDoprinosOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosOsnova { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmA2005A.IznosDoprinosMIO1.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosMIO1 { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmA2005A.IznosDoprinosMIO2.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDoprinosMIO2 { get; set; }
    
    	[DisplayName(AtributClass.ObrazacRSmA2005A.IznosIsplataDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosIsplataDohodak { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObrazacRSmA2005A.GodinaIsplataDohodak.StringLength)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.GodinaIsplataDohodak.DisplayName)]
       	public string GodinaIsplataDohodak { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObrazacRSmA2005A.MjesecIsplataDohodak.StringLength)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.MjesecIsplataDohodak.DisplayName)]
       	public string MjesecIsplataDohodak { get; set; }
    
    	
        [StringLength(40, ErrorMessage = AtributClass.ObrazacRSmA2005A.Hash.StringLength)]
    	[DisplayName(AtributClass.ObrazacRSmA2005A.Hash.DisplayName)]
       	public string Hash { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacRSmA2005AFormFormattedBase()
        { }
    	
    	public ObrazacRSmA2005AFormFormattedBase(Model.Data.ObrazacRSmA2005A formformated)
    	{
    	    this.ID_ObrazacRSmA2005A = formformated.ID_ObrazacRSmA2005A;
    	    this.ID_ObrazacRSm = formformated.ID_ObrazacRSm;
    	    this.Identifikator = formformated.Identifikator;
    	    this.Mjesec = formformated.Mjesec;
    	    this.Godina = formformated.Godina;
    	    this.BrojOsiguranika = formformated.BrojOsiguranika;
    	    this.ObveznikNaziv = formformated.ObveznikNaziv;
    	    this.ObveznikAdresa = formformated.ObveznikAdresa;
    	    this.ObveznikIdentifikacijskiBroj = formformated.ObveznikIdentifikacijskiBroj;
    	    this.ObveznikVrsta = formformated.ObveznikVrsta;
    	    this.IznosObracunDohodak = formformated.IznosObracunDohodak;
    	    this.IznosDoprinosOsnova = formformated.IznosDoprinosOsnova;
    	    this.IznosDoprinosMIO1 = formformated.IznosDoprinosMIO1;
    	    this.IznosDoprinosMIO2 = formformated.IznosDoprinosMIO2;
    	    this.IznosIsplataDohodak = formformated.IznosIsplataDohodak;
    	    this.GodinaIsplataDohodak = formformated.GodinaIsplataDohodak;
    	    this.MjesecIsplataDohodak = formformated.MjesecIsplataDohodak;
    	    this.Hash = formformated.Hash;
    	}
    
    	/*
    	    mymodel.ID_ObrazacRSmA2005A = model.ID_ObrazacRSmA2005A;
    	    mymodel.ID_ObrazacRSm = model.ID_ObrazacRSm;
    	    mymodel.Identifikator = model.Identifikator;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.Godina = model.Godina;
    	    mymodel.BrojOsiguranika = model.BrojOsiguranika;
    	    mymodel.ObveznikNaziv = model.ObveznikNaziv;
    	    mymodel.ObveznikAdresa = model.ObveznikAdresa;
    	    mymodel.ObveznikIdentifikacijskiBroj = model.ObveznikIdentifikacijskiBroj;
    	    mymodel.ObveznikVrsta = model.ObveznikVrsta;
    	    mymodel.IznosObracunDohodak = model.IznosObracunDohodak;
    	    mymodel.IznosDoprinosOsnova = model.IznosDoprinosOsnova;
    	    mymodel.IznosDoprinosMIO1 = model.IznosDoprinosMIO1;
    	    mymodel.IznosDoprinosMIO2 = model.IznosDoprinosMIO2;
    	    mymodel.IznosIsplataDohodak = model.IznosIsplataDohodak;
    	    mymodel.GodinaIsplataDohodak = model.GodinaIsplataDohodak;
    	    mymodel.MjesecIsplataDohodak = model.MjesecIsplataDohodak;
    	    mymodel.Hash = model.Hash;
    		
    	*/
    
    		#endregion
    	
    }
}
