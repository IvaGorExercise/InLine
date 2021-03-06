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
    
    
    public partial class SubjektVezaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektVeza.ID_SubjektVeza.Required)]
    	[DisplayName(AtributClass.SubjektVeza.ID_SubjektVeza.DisplayName)]
        	public long ID_SubjektVeza { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektVeza.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.SubjektVeza.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.SubjektVeza.ID_SubjektNad.Required)]
    	[DisplayName(AtributClass.SubjektVeza.ID_SubjektNad.DisplayName)]
       	public long ID_SubjektNad { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.SubjektVeza.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektVezaFormFormattedBase()
        { }
    	
    	public SubjektVezaFormFormattedBase(Model.Data.SubjektVeza formformated)
    	{
    	    this.ID_SubjektVeza = formformated.ID_SubjektVeza;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.ID_SubjektNad = formformated.ID_SubjektNad;
    	    this.Datum = formformated.Datum;
    	}
    
    	/*
    	    mymodel.ID_SubjektVeza = model.ID_SubjektVeza;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_SubjektNad = model.ID_SubjektNad;
    	    mymodel.Datum = model.Datum;
    		
    	*/
    
    		#endregion
    	
    }
}
