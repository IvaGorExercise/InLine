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
    
    
    public partial class UslugaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Usluga.ID_Usluga.Required)]
    	[DisplayName(AtributClass.Usluga.ID_Usluga.DisplayName)]
        	public long ID_Usluga { get; set; }
    
    	[DisplayName(AtributClass.Usluga.ID_Objekt.DisplayName)]
       	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.Usluga.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Oznaka.Required)]
    	[DisplayName(AtributClass.Usluga.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Usluga.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Naziv.Required)]
    	[DisplayName(AtributClass.Usluga.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.Usluga.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.NazivKr.Required)]
    	[DisplayName(AtributClass.Usluga.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.Usluga.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.Usluga.Kratica.Required)]
    	[DisplayName(AtributClass.Usluga.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UslugaFormFormattedBase()
        { }
    	
    	public UslugaFormFormattedBase(Model.Data.Usluga formformated)
    	{
    	    this.ID_Usluga = formformated.ID_Usluga;
    	    this.ID_Objekt = formformated.ID_Objekt;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_Usluga = model.ID_Usluga;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
