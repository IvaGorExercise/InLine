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
    
    
    public partial class ZupanijaGrZupanijaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGrZupanija.DisplayName)]
        	public long ID_ZupanijaGrZupanija { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_ZupanijaGr.DisplayName)]
       	public long ID_ZupanijaGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.ID_Zupanija.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.ID_Zupanija.DisplayName)]
       	public long ID_Zupanija { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ZupanijaGrZupanija.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Oznaka.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZupanijaGrZupanija.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Naziv.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZupanijaGrZupanija.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.NazivKr.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ZupanijaGrZupanija.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Kratica.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZupanijaGrZupanija.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.ZupanijaGrZupanija.Opis.Required)]
    	[DisplayName(AtributClass.ZupanijaGrZupanija.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZupanijaGrZupanijaFormFormattedBase()
        { }
    	
    	public ZupanijaGrZupanijaFormFormattedBase(Model.Data.ZupanijaGrZupanija formformated)
    	{
    	    this.ID_ZupanijaGrZupanija = formformated.ID_ZupanijaGrZupanija;
    	    this.ID_ZupanijaGr = formformated.ID_ZupanijaGr;
    	    this.ID_Zupanija = formformated.ID_Zupanija;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Opis = formformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_ZupanijaGrZupanija = model.ID_ZupanijaGrZupanija;
    	    mymodel.ID_ZupanijaGr = model.ID_ZupanijaGr;
    	    mymodel.ID_Zupanija = model.ID_Zupanija;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    	
    }
}
