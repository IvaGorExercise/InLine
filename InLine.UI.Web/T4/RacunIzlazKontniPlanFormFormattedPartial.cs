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
    
    
    public partial class RacunIzlazKontniPlanFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.RacunIzlazKontniPlan.ID_RacunIzlazKontniPlan.Required)]
    	[DisplayName(AtributClass.RacunIzlazKontniPlan.ID_RacunIzlazKontniPlan.DisplayName)]
        	public long ID_RacunIzlazKontniPlan { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunIzlazKontniPlan.ID_RacunIzlaz.Required)]
    	[DisplayName(AtributClass.RacunIzlazKontniPlan.ID_RacunIzlaz.DisplayName)]
       	public long ID_RacunIzlaz { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunIzlazKontniPlan.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.RacunIzlazKontniPlan.ID_KontniPlan.DisplayName)]
       	public long ID_KontniPlan { get; set; }
    
    	[DisplayName(AtributClass.RacunIzlazKontniPlan.ID_Shema.DisplayName)]
       	public Nullable<long> ID_Shema { get; set; }
    
    	[DisplayName(AtributClass.RacunIzlazKontniPlan.ID_KontniPlanAnalitika.DisplayName)]
       	public Nullable<long> ID_KontniPlanAnalitika { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RacunIzlazKontniPlanFormFormattedBase()
        { }
    	
    	public RacunIzlazKontniPlanFormFormattedBase(Model.Data.RacunIzlazKontniPlan formformated)
    	{
    	    this.ID_RacunIzlazKontniPlan = formformated.ID_RacunIzlazKontniPlan;
    	    this.ID_RacunIzlaz = formformated.ID_RacunIzlaz;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.ID_Shema = formformated.ID_Shema;
    	    this.ID_KontniPlanAnalitika = formformated.ID_KontniPlanAnalitika;
    	}
    
    	/*
    	    mymodel.ID_RacunIzlazKontniPlan = model.ID_RacunIzlazKontniPlan;
    	    mymodel.ID_RacunIzlaz = model.ID_RacunIzlaz;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_Shema = model.ID_Shema;
    	    mymodel.ID_KontniPlanAnalitika = model.ID_KontniPlanAnalitika;
    		
    	*/
    
    		#endregion
    	
    }
}
