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
    
    
    public partial class HUBFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUB.ID_HUB.Required)]
    	[DisplayName(AtributClass.HUB.ID_HUB.DisplayName)]
        	public long ID_HUB { get; set; }
    
    	[DisplayName(AtributClass.HUB.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB.IDHUBVerzija.Required)]
    	[DisplayName(AtributClass.HUB.IDHUBVerzija.DisplayName)]
       	public int IDHUBVerzija { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUBFormFormattedBase()
        { }
    	
    	public HUBFormFormattedBase(Model.Data.HUB formformated)
    	{
    	    this.ID_HUB = formformated.ID_HUB;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.IDHUBVerzija = formformated.IDHUBVerzija;
    	}
    
    	/*
    	    mymodel.ID_HUB = model.ID_HUB;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDHUBVerzija = model.IDHUBVerzija;
    		
    	*/
    
    		#endregion
    	
    }
}
