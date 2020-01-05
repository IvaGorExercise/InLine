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
    
    
    public partial class RacunIzlazFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.RacunIzlaz.ID_RacunIzlaz.Required)]
    	[DisplayName(AtributClass.RacunIzlaz.ID_RacunIzlaz.DisplayName)]
        	public long ID_RacunIzlaz { get; set; }
    
    	[DisplayName(AtributClass.RacunIzlaz.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunIzlaz.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.RacunIzlaz.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunIzlaz.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.RacunIzlaz.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RacunIzlazFormFormattedBase()
        { }
    	
    	public RacunIzlazFormFormattedBase(Model.Data.RacunIzlaz formformated)
    	{
    	    this.ID_RacunIzlaz = formformated.ID_RacunIzlaz;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	}
    
    	/*
    	    mymodel.ID_RacunIzlaz = model.ID_RacunIzlaz;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    		
    	*/
    
    		#endregion
    	
    }
}