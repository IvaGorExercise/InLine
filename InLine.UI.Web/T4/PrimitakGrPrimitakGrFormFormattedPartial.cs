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
    
    
    public partial class PrimitakGrPrimitakGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGrPrimitakGr.Required)]
    	[DisplayName(AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGrPrimitakGr.DisplayName)]
        	public long ID_PrimitakGrPrimitakGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGr.Required)]
    	[DisplayName(AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGr.DisplayName)]
       	public long ID_PrimitakGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGrNad.Required)]
    	[DisplayName(AtributClass.PrimitakGrPrimitakGr.ID_PrimitakGrNad.DisplayName)]
       	public long ID_PrimitakGrNad { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PrimitakGrPrimitakGrFormFormattedBase()
        { }
    	
    	public PrimitakGrPrimitakGrFormFormattedBase(Model.Data.PrimitakGrPrimitakGr formformated)
    	{
    	    this.ID_PrimitakGrPrimitakGr = formformated.ID_PrimitakGrPrimitakGr;
    	    this.ID_PrimitakGr = formformated.ID_PrimitakGr;
    	    this.ID_PrimitakGrNad = formformated.ID_PrimitakGrNad;
    	}
    
    	/*
    	    mymodel.ID_PrimitakGrPrimitakGr = model.ID_PrimitakGrPrimitakGr;
    	    mymodel.ID_PrimitakGr = model.ID_PrimitakGr;
    	    mymodel.ID_PrimitakGrNad = model.ID_PrimitakGrNad;
    		
    	*/
    
    		#endregion
    	
    }
}
