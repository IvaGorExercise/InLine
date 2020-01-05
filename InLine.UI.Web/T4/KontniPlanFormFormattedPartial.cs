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
    
    
    public partial class KontniPlanFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_KontniPlan.DisplayName)]
        	public long ID_KontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.KontniPlan.ID_PoslovnaGodina.DisplayName)]
       	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.KontniPlan.AnalitikaOd.Required)]
    	[DisplayName(AtributClass.KontniPlan.AnalitikaOd.DisplayName)]
       	public int AnalitikaOd { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KontniPlanFormFormattedBase()
        { }
    	
    	public KontniPlanFormFormattedBase(Model.Data.KontniPlan formformated)
    	{
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
    	    this.AnalitikaOd = formformated.AnalitikaOd;
    	}
    
    	/*
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.AnalitikaOd = model.AnalitikaOd;
    		
    	*/
    
    		#endregion
    	
    }
}
