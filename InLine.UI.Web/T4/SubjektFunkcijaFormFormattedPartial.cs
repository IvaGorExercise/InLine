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
    
    
    public partial class SubjektFunkcijaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektFunkcija.IDSubjektFunkcija.Required)]
    	[DisplayName(AtributClass.SubjektFunkcija.IDSubjektFunkcija.DisplayName)]
       	public int IDSubjektFunkcija { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.SubjektFunkcija.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektFunkcija.Oznaka.Required)]
    	[DisplayName(AtributClass.SubjektFunkcija.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektFunkcija.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektFunkcija.Naziv.Required)]
    	[DisplayName(AtributClass.SubjektFunkcija.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektFunkcijaFormFormattedBase()
        { }
    	
    	public SubjektFunkcijaFormFormattedBase(Model.Data.SubjektFunkcija formformated)
    	{
    	    this.IDSubjektFunkcija = formformated.IDSubjektFunkcija;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	}
    
    	/*
    	    mymodel.IDSubjektFunkcija = model.IDSubjektFunkcija;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    		
    	*/
    
    		#endregion
    	
    }
}
