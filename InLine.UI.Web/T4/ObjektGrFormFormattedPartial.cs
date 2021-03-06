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
    
    
    public partial class ObjektGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObjektGr.ID_ObjektGr.Required)]
    	[DisplayName(AtributClass.ObjektGr.ID_ObjektGr.DisplayName)]
        	public long ID_ObjektGr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ObjektGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektGr.Oznaka.Required)]
    	[DisplayName(AtributClass.ObjektGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObjektGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektGr.Naziv.Required)]
    	[DisplayName(AtributClass.ObjektGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObjektGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektGr.NazivKr.Required)]
    	[DisplayName(AtributClass.ObjektGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObjektGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObjektGr.Kratica.Required)]
    	[DisplayName(AtributClass.ObjektGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObjektGrFormFormattedBase()
        { }
    	
    	public ObjektGrFormFormattedBase(Model.Data.ObjektGr formformated)
    	{
    	    this.ID_ObjektGr = formformated.ID_ObjektGr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	}
    
    	/*
    	    mymodel.ID_ObjektGr = model.ID_ObjektGr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    		
    	*/
    
    		#endregion
    	
    }
}
