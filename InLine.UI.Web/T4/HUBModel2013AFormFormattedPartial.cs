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
    
    
    public partial class HUBModel2013AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUBModel2013A.IDHUBModel2013A.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.IDHUBModel2013A.DisplayName)]
       	public int IDHUBModel2013A { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUBModel2013A.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBModel2013A.Oznaka.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUBModel2013A.PredOznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBModel2013A.PredOznaka.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.PredOznaka.DisplayName)]
       	public string PredOznaka { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBModel2013A.Koristi.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.Koristi.DisplayName)]
       	public bool Koristi { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBModel2013A.BrojPodatakMin.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.BrojPodatakMin.DisplayName)]
       	public int BrojPodatakMin { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBModel2013A.BrojPodatakMax.Required)]
    	[DisplayName(AtributClass.HUBModel2013A.BrojPodatakMax.DisplayName)]
       	public int BrojPodatakMax { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUBModel2013AFormFormattedBase()
        { }
    	
    	public HUBModel2013AFormFormattedBase(Model.Data.HUBModel2013A formformated)
    	{
    	    this.IDHUBModel2013A = formformated.IDHUBModel2013A;
    	    this.Oznaka = formformated.Oznaka;
    	    this.PredOznaka = formformated.PredOznaka;
    	    this.Koristi = formformated.Koristi;
    	    this.BrojPodatakMin = formformated.BrojPodatakMin;
    	    this.BrojPodatakMax = formformated.BrojPodatakMax;
    	}
    
    	/*
    	    mymodel.IDHUBModel2013A = model.IDHUBModel2013A;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.PredOznaka = model.PredOznaka;
    	    mymodel.Koristi = model.Koristi;
    	    mymodel.BrojPodatakMin = model.BrojPodatakMin;
    	    mymodel.BrojPodatakMax = model.BrojPodatakMax;
    		
    	*/
    
    		#endregion
    	
    }
}
