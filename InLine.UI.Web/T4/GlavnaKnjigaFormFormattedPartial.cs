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
    
    
    public partial class GlavnaKnjigaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjiga.ID_GlavnaKnjiga.Required)]
    	[DisplayName(AtributClass.GlavnaKnjiga.ID_GlavnaKnjiga.DisplayName)]
        	public long ID_GlavnaKnjiga { get; set; }
    
        [Required(ErrorMessage = AtributClass.GlavnaKnjiga.ID_KontniPlan.Required)]
    	[DisplayName(AtributClass.GlavnaKnjiga.ID_KontniPlan.DisplayName)]
       	public long ID_KontniPlan { get; set; }
    
    	[DisplayName(AtributClass.GlavnaKnjiga.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public GlavnaKnjigaFormFormattedBase()
        { }
    	
    	public GlavnaKnjigaFormFormattedBase(Model.Data.GlavnaKnjiga formformated)
    	{
    	    this.ID_GlavnaKnjiga = formformated.ID_GlavnaKnjiga;
    	    this.ID_KontniPlan = formformated.ID_KontniPlan;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	}
    
    	/*
    	    mymodel.ID_GlavnaKnjiga = model.ID_GlavnaKnjiga;
    	    mymodel.ID_KontniPlan = model.ID_KontniPlan;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    		
    	*/
    
    		#endregion
    	
    }
}