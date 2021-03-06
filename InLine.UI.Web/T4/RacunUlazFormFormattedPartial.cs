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
    
    
    public partial class RacunUlazFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.RacunUlaz.ID_RacunUlaz.Required)]
    	[DisplayName(AtributClass.RacunUlaz.ID_RacunUlaz.DisplayName)]
        	public long ID_RacunUlaz { get; set; }
    
    	[DisplayName(AtributClass.RacunUlaz.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlaz.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.RacunUlaz.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.RacunUlaz.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.RacunUlaz.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RacunUlazFormFormattedBase()
        { }
    	
    	public RacunUlazFormFormattedBase(Model.Data.RacunUlaz formformated)
    	{
    	    this.ID_RacunUlaz = formformated.ID_RacunUlaz;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	}
    
    	/*
    	    mymodel.ID_RacunUlaz = model.ID_RacunUlaz;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    		
    	*/
    
    		#endregion
    	
    }
}
