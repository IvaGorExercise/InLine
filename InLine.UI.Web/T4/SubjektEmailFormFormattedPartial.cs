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
    
    
    public partial class SubjektEmailFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektEmail.ID_SubjektEmail.Required)]
    	[DisplayName(AtributClass.SubjektEmail.ID_SubjektEmail.DisplayName)]
        	public long ID_SubjektEmail { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektEmail.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.SubjektEmail.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	
        [StringLength(400, ErrorMessage = AtributClass.SubjektEmail.URL.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektEmail.URL.Required)]
    	[DisplayName(AtributClass.SubjektEmail.URL.DisplayName)]
       	public string URL { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.SubjektEmail.Opis.StringLength)]
    	[DisplayName(AtributClass.SubjektEmail.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektEmailFormFormattedBase()
        { }
    	
    	public SubjektEmailFormFormattedBase(Model.Data.SubjektEmail formformated)
    	{
    	    this.ID_SubjektEmail = formformated.ID_SubjektEmail;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.URL = formformated.URL;
    	    this.Opis = formformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_SubjektEmail = model.ID_SubjektEmail;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.URL = model.URL;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    	
    }
}
