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
    
    
    public partial class SubjektGrSubjektGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektGrSubjektGr.ID_SubjektGrSubjektGr.Required)]
    	[DisplayName(AtributClass.SubjektGrSubjektGr.ID_SubjektGrSubjektGr.DisplayName)]
        	public long ID_SubjektGrSubjektGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektGrSubjektGr.ID_SubjektGr.Required)]
    	[DisplayName(AtributClass.SubjektGrSubjektGr.ID_SubjektGr.DisplayName)]
       	public long ID_SubjektGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektGrSubjektGr.ID_SubjektGrNad.Required)]
    	[DisplayName(AtributClass.SubjektGrSubjektGr.ID_SubjektGrNad.DisplayName)]
       	public long ID_SubjektGrNad { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektGrSubjektGrFormFormattedBase()
        { }
    	
    	public SubjektGrSubjektGrFormFormattedBase(Model.Data.SubjektGrSubjektGr formformated)
    	{
    	    this.ID_SubjektGrSubjektGr = formformated.ID_SubjektGrSubjektGr;
    	    this.ID_SubjektGr = formformated.ID_SubjektGr;
    	    this.ID_SubjektGrNad = formformated.ID_SubjektGrNad;
    	}
    
    	/*
    	    mymodel.ID_SubjektGrSubjektGr = model.ID_SubjektGrSubjektGr;
    	    mymodel.ID_SubjektGr = model.ID_SubjektGr;
    	    mymodel.ID_SubjektGrNad = model.ID_SubjektGrNad;
    		
    	*/
    
    		#endregion
    	
    }
}
