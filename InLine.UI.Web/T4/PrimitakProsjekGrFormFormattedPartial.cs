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
    
    
    public partial class PrimitakProsjekGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.ID_PrimitakProsjekGr.DisplayName)]
        	public long ID_PrimitakProsjekGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PrimitakProsjekGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Oznaka.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PrimitakProsjekGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Naziv.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PrimitakProsjekGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.NazivKr.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PrimitakProsjekGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PrimitakProsjekGr.Kratica.Required)]
    	[DisplayName(AtributClass.PrimitakProsjekGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PrimitakProsjekGrFormFormattedBase()
        { }
    	
    	public PrimitakProsjekGrFormFormattedBase(Model.Data.PrimitakProsjekGr formformated)
    	{
    	    this.ID_PrimitakProsjekGr = formformated.ID_PrimitakProsjekGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_PrimitakProsjekGr = model.ID_PrimitakProsjekGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
