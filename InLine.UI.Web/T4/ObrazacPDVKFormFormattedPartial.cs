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
    
    
    public partial class ObrazacPDVKFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacPDVK.ID_ObrazacPDVK.Required)]
    	[DisplayName(AtributClass.ObrazacPDVK.ID_ObrazacPDVK.DisplayName)]
        	public long ID_ObrazacPDVK { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPDVK.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDVK.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.ObrazacPDVK.ID_PoslovnaGodina.DisplayName)]
       	public long ID_PoslovnaGodina { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacPDVKFormFormattedBase()
        { }
    	
    	public ObrazacPDVKFormFormattedBase(Model.Data.ObrazacPDVK formformated)
    	{
    	    this.ID_ObrazacPDVK = formformated.ID_ObrazacPDVK;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
    	}
    
    	/*
    	    mymodel.ID_ObrazacPDVK = model.ID_ObrazacPDVK;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    		
    	*/
    
    		#endregion
    	
    }
}
