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
    
    
    public partial class KontniPlanStKriterijFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KontniPlanStKriterij.ID_KontniPlanStKriterij.Required)]
    	[DisplayName(AtributClass.KontniPlanStKriterij.ID_KontniPlanStKriterij.DisplayName)]
        	public long ID_KontniPlanStKriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanStKriterij.ID_KontniPlanSt.Required)]
    	[DisplayName(AtributClass.KontniPlanStKriterij.ID_KontniPlanSt.DisplayName)]
       	public long ID_KontniPlanSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanStKriterij.ID_Kriterij.Required)]
    	[DisplayName(AtributClass.KontniPlanStKriterij.ID_Kriterij.DisplayName)]
       	public long ID_Kriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanStKriterij.ID_KriterijSt.Required)]
    	[DisplayName(AtributClass.KontniPlanStKriterij.ID_KriterijSt.DisplayName)]
       	public long ID_KriterijSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlanStKriterij.Obavezno.Required)]
    	[DisplayName(AtributClass.KontniPlanStKriterij.Obavezno.DisplayName)]
       	public bool Obavezno { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KontniPlanStKriterijFormFormattedBase()
        { }
    	
    	public KontniPlanStKriterijFormFormattedBase(Model.Data.KontniPlanStKriterij formformated)
    	{
    	    this.ID_KontniPlanStKriterij = formformated.ID_KontniPlanStKriterij;
    	    this.ID_KontniPlanSt = formformated.ID_KontniPlanSt;
    	    this.ID_Kriterij = formformated.ID_Kriterij;
    	    this.ID_KriterijSt = formformated.ID_KriterijSt;
    	    this.Obavezno = formformated.Obavezno;
    	}
    
    	/*
    	    mymodel.ID_KontniPlanStKriterij = model.ID_KontniPlanStKriterij;
    	    mymodel.ID_KontniPlanSt = model.ID_KontniPlanSt;
    	    mymodel.ID_Kriterij = model.ID_Kriterij;
    	    mymodel.ID_KriterijSt = model.ID_KriterijSt;
    	    mymodel.Obavezno = model.Obavezno;
    		
    	*/
    
    		#endregion
    	
    }
}
