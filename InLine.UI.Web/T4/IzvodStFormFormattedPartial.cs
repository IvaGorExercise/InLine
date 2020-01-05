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
    
    
    public partial class IzvodStFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.IzvodSt.ID_IzvodSt.Required)]
    	[DisplayName(AtributClass.IzvodSt.ID_IzvodSt.DisplayName)]
        	public long ID_IzvodSt { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.ID_Izvod.DisplayName)]
       	public Nullable<long> ID_Izvod { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.IznosDuguje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDuguje { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.IznosPotrazuje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPotrazuje { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.IznosDugujeValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDugujeValuta { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.IznosPotrazujeValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPotrazujeValuta { get; set; }
    
    	[DisplayName(AtributClass.IzvodSt.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public IzvodStFormFormattedBase()
        { }
    	
    	public IzvodStFormFormattedBase(Model.Data.IzvodSt formformated)
    	{
    	    this.ID_IzvodSt = formformated.ID_IzvodSt;
    	    this.ID_Izvod = formformated.ID_Izvod;
    	    this.IznosDuguje = formformated.IznosDuguje;
    	    this.IznosPotrazuje = formformated.IznosPotrazuje;
    	    this.IznosDugujeValuta = formformated.IznosDugujeValuta;
    	    this.IznosPotrazujeValuta = formformated.IznosPotrazujeValuta;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	}
    
    	/*
    	    mymodel.ID_IzvodSt = model.ID_IzvodSt;
    	    mymodel.ID_Izvod = model.ID_Izvod;
    	    mymodel.IznosDuguje = model.IznosDuguje;
    	    mymodel.IznosPotrazuje = model.IznosPotrazuje;
    	    mymodel.IznosDugujeValuta = model.IznosDugujeValuta;
    	    mymodel.IznosPotrazujeValuta = model.IznosPotrazujeValuta;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    		
    	*/
    
    		#endregion
    	
    }
}
