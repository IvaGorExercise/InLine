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
    
    
    public partial class RacunUlazKontniPlanKriterijFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.RacunUlazKontniPlanKriterij.ID_RacunUlazKontniPlanKriterij.Required)]
    	[DisplayName(AtributClass.RacunUlazKontniPlanKriterij.ID_RacunUlazKontniPlanKriterij.DisplayName)]
        	public long ID_RacunUlazKontniPlanKriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazKontniPlanKriterij.ID_RacunUlazKontniPlan.Required)]
    	[DisplayName(AtributClass.RacunUlazKontniPlanKriterij.ID_RacunUlazKontniPlan.DisplayName)]
       	public long ID_RacunUlazKontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazKontniPlanKriterij.ID_Kriterij.Required)]
    	[DisplayName(AtributClass.RacunUlazKontniPlanKriterij.ID_Kriterij.DisplayName)]
       	public long ID_Kriterij { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlazKontniPlanKriterij.ID_KriterijSt.Required)]
    	[DisplayName(AtributClass.RacunUlazKontniPlanKriterij.ID_KriterijSt.DisplayName)]
       	public long ID_KriterijSt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RacunUlazKontniPlanKriterijFormFormattedBase()
        { }
    	
    	public RacunUlazKontniPlanKriterijFormFormattedBase(Model.Data.RacunUlazKontniPlanKriterij formformated)
    	{
    	    this.ID_RacunUlazKontniPlanKriterij = formformated.ID_RacunUlazKontniPlanKriterij;
    	    this.ID_RacunUlazKontniPlan = formformated.ID_RacunUlazKontniPlan;
    	    this.ID_Kriterij = formformated.ID_Kriterij;
    	    this.ID_KriterijSt = formformated.ID_KriterijSt;
    	}
    
    	/*
    	    mymodel.ID_RacunUlazKontniPlanKriterij = model.ID_RacunUlazKontniPlanKriterij;
    	    mymodel.ID_RacunUlazKontniPlan = model.ID_RacunUlazKontniPlan;
    	    mymodel.ID_Kriterij = model.ID_Kriterij;
    	    mymodel.ID_KriterijSt = model.ID_KriterijSt;
    		
    	*/
    
    		#endregion
    	
    }
}