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
    
    
    public partial class OdbitakGrOdbitakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitak.ID_OdbitakGrOdbitak.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitak.ID_OdbitakGrOdbitak.DisplayName)]
        	public long ID_OdbitakGrOdbitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitak.ID_OdbitakGr.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitak.ID_OdbitakGr.DisplayName)]
       	public long ID_OdbitakGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.OdbitakGrOdbitak.ID_Odbitak.Required)]
    	[DisplayName(AtributClass.OdbitakGrOdbitak.ID_Odbitak.DisplayName)]
       	public long ID_Odbitak { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OdbitakGrOdbitakFormFormattedBase()
        { }
    	
    	public OdbitakGrOdbitakFormFormattedBase(Model.Data.OdbitakGrOdbitak formformated)
    	{
    	    this.ID_OdbitakGrOdbitak = formformated.ID_OdbitakGrOdbitak;
    	    this.ID_OdbitakGr = formformated.ID_OdbitakGr;
    	    this.ID_Odbitak = formformated.ID_Odbitak;
    	}
    
    	/*
    	    mymodel.ID_OdbitakGrOdbitak = model.ID_OdbitakGrOdbitak;
    	    mymodel.ID_OdbitakGr = model.ID_OdbitakGr;
    	    mymodel.ID_Odbitak = model.ID_Odbitak;
    		
    	*/
    
    		#endregion
    	
    }
}