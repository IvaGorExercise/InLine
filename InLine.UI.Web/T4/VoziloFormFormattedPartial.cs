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
    
    
    public partial class VoziloFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Vozilo.ID_Vozilo.Required)]
    	[DisplayName(AtributClass.Vozilo.ID_Vozilo.DisplayName)]
        	public long ID_Vozilo { get; set; }
    
    	[DisplayName(AtributClass.Vozilo.ID_Objekt.DisplayName)]
       	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Vozilo.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Oznaka.Required)]
    	[DisplayName(AtributClass.Vozilo.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Vozilo.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Naziv.Required)]
    	[DisplayName(AtributClass.Vozilo.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Vozilo.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.NazivKr.Required)]
    	[DisplayName(AtributClass.Vozilo.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Vozilo.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Kratica.Required)]
    	[DisplayName(AtributClass.Vozilo.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.Vozilo.Registracija.StringLength)]
        [Required(ErrorMessage = AtributClass.Vozilo.Registracija.Required)]
    	[DisplayName(AtributClass.Vozilo.Registracija.DisplayName)]
       	public string Registracija { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public VoziloFormFormattedBase()
        { }
    	
    	public VoziloFormFormattedBase(Model.Data.Vozilo formformated)
    	{
    	    this.ID_Vozilo = formformated.ID_Vozilo;
    	    this.ID_Objekt = formformated.ID_Objekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Registracija = formformated.Registracija;
    	}
    
    	/*
    	    mymodel.ID_Vozilo = model.ID_Vozilo;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Registracija = model.Registracija;
    		
    	*/
    
    		#endregion
    	
    }
}