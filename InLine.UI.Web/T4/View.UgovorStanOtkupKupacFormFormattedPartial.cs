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
    
    
    public partial class UgovorStanOtkupKupacFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_Kupac.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_Kupac.DisplayName)]
       	public long ID_Kupac { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupac.Naziv.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.DisplayName)]
       	public long ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupKupac { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.JMBG.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.JMBG.DisplayName)]
       	public string JMBG { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.OIB.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Nositelj.DisplayName)]
       	public Nullable<bool> Nositelj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupac.Ulica.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Ulica.DisplayName)]
       	public string Ulica { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupKupac.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.KucniBroj.DisplayName)]
       	public string KucniBroj { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.DisplayName)]
       	public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.UgovorStanOtkupKupac.PostanskiBroj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.PostanskiBroj.DisplayName)]
       	public string PostanskiBroj { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupKupacFormFormattedBase()
        { }
    	
    	public UgovorStanOtkupKupacFormFormattedBase(Model.Data.View.UgovorStanOtkupKupac formformated)
    	{
    	    this.ID_Kupac = formformated.ID_Kupac;
    	    this.Naziv = formformated.Naziv;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.ID_UgovorStanOtkupKupac = formformated.ID_UgovorStanOtkupKupac;
    	    this.JMBG = formformated.JMBG;
    	    this.OIB = formformated.OIB;
    	    this.Nositelj = formformated.Nositelj;
    	    this.Ulica = formformated.Ulica;
    	    this.KucniBroj = formformated.KucniBroj;
    	    this.KucniBrojDodatak = formformated.KucniBrojDodatak;
    	    this.PostanskiBroj = formformated.PostanskiBroj;
    	}
    
    	/*
    	    mymodel.ID_Kupac = model.ID_Kupac;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
    	    mymodel.JMBG = model.JMBG;
    	    mymodel.OIB = model.OIB;
    	    mymodel.Nositelj = model.Nositelj;
    	    mymodel.Ulica = model.Ulica;
    	    mymodel.KucniBroj = model.KucniBroj;
    	    mymodel.KucniBrojDodatak = model.KucniBrojDodatak;
    	    mymodel.PostanskiBroj = model.PostanskiBroj;
    		
    	*/
    
    		#endregion
    	
    }
}
