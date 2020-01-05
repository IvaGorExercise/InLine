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
    
    
    public partial class PoslovnaGodinaSubjektFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjekt.ID_PoslovnaGodinaSubjekt.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjekt.ID_PoslovnaGodinaSubjekt.DisplayName)]
        	public long ID_PoslovnaGodinaSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjekt.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjekt.ID_PoslovnaGodina.DisplayName)]
       	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaSubjekt.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaSubjekt.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PoslovnaGodinaSubjektFormFormattedBase()
        { }
    	
    	public PoslovnaGodinaSubjektFormFormattedBase(Model.Data.PoslovnaGodinaSubjekt formformated)
    	{
    	    this.ID_PoslovnaGodinaSubjekt = formformated.ID_PoslovnaGodinaSubjekt;
    	    this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	}
    
    	/*
    	    mymodel.ID_PoslovnaGodinaSubjekt = model.ID_PoslovnaGodinaSubjekt;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    		
    	*/
    
    		#endregion
    	
    }
}
