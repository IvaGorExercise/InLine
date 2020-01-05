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
    
    
    public partial class RabatFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Rabat.ID_Rabat.Required)]
    	[DisplayName(AtributClass.Rabat.ID_Rabat.DisplayName)]
        	public long ID_Rabat { get; set; }
    
        [Required(ErrorMessage = AtributClass.Rabat.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.Rabat.ID_PoslovniSubjekt.DisplayName)]
       	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.Rabat.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.Rabat.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.Rabat.StopaRabat.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.Rabat.StopaRabat.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal StopaRabat { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public RabatFormFormattedBase()
        { }
    	
    	public RabatFormFormattedBase(Model.Data.Rabat formformated)
    	{
    	    this.ID_Rabat = formformated.ID_Rabat;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.StopaRabat = formformated.StopaRabat;
    	}
    
    	/*
    	    mymodel.ID_Rabat = model.ID_Rabat;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.StopaRabat = model.StopaRabat;
    		
    	*/
    
    		#endregion
    	
    }
}
