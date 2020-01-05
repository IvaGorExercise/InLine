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
    
    
    public partial class PosebanPorezDohodakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodak.ID_PosebanPorezDohodak.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodak.ID_PosebanPorezDohodak.DisplayName)]
        	public long ID_PosebanPorezDohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodak.ID_PosebanPorezDohodakVr.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodak.ID_PosebanPorezDohodakVr.DisplayName)]
       	public long ID_PosebanPorezDohodakVr { get; set; }
    
    	[DisplayName(AtributClass.PosebanPorezDohodak.ID_Davanje.DisplayName)]
       	public Nullable<long> ID_Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodak.Stopa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.PosebanPorezDohodak.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Stopa { get; set; }
    
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodak.IznosOsnovaOd.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.PosebanPorezDohodak.IznosOsnovaOd.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosOsnovaOd { get; set; }
    
    	[DisplayName(AtributClass.PosebanPorezDohodak.IznosOsnovaDo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosOsnovaDo { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PosebanPorezDohodakFormFormattedBase()
        { }
    	
    	public PosebanPorezDohodakFormFormattedBase(Model.Data.PosebanPorezDohodak formformated)
    	{
    	    this.ID_PosebanPorezDohodak = formformated.ID_PosebanPorezDohodak;
    	    this.ID_PosebanPorezDohodakVr = formformated.ID_PosebanPorezDohodakVr;
    	    this.ID_Davanje = formformated.ID_Davanje;
    	    this.Stopa = formformated.Stopa;
    	    this.IznosOsnovaOd = formformated.IznosOsnovaOd;
    	    this.IznosOsnovaDo = formformated.IznosOsnovaDo;
    	}
    
    	/*
    	    mymodel.ID_PosebanPorezDohodak = model.ID_PosebanPorezDohodak;
    	    mymodel.ID_PosebanPorezDohodakVr = model.ID_PosebanPorezDohodakVr;
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.Stopa = model.Stopa;
    	    mymodel.IznosOsnovaOd = model.IznosOsnovaOd;
    	    mymodel.IznosOsnovaDo = model.IznosOsnovaDo;
    		
    	*/
    
    		#endregion
    	
    }
}