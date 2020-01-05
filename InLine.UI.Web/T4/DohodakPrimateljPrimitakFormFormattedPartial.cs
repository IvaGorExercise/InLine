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
    
    
    public partial class DohodakPrimateljPrimitakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.ID_DohodakPrimateljPrimitak.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.ID_DohodakPrimateljPrimitak.DisplayName)]
        	public long ID_DohodakPrimateljPrimitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.ID_DohodakPrimatelj.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.ID_DohodakPrimatelj.DisplayName)]
       	public long ID_DohodakPrimatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.ID_Primitak.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.ID_Primitak.DisplayName)]
       	public long ID_Primitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.IznosBruto.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.IznosBruto.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosBruto { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.IznosDohodak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.IznosDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosDohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.IznosNeto.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.IznosNeto.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosNeto { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljPrimitak.IznosTrosak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljPrimitak.IznosTrosak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosTrosak { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DohodakPrimateljPrimitakFormFormattedBase()
        { }
    	
    	public DohodakPrimateljPrimitakFormFormattedBase(Model.Data.DohodakPrimateljPrimitak formformated)
    	{
    	    this.ID_DohodakPrimateljPrimitak = formformated.ID_DohodakPrimateljPrimitak;
    	    this.ID_DohodakPrimatelj = formformated.ID_DohodakPrimatelj;
    	    this.ID_Primitak = formformated.ID_Primitak;
    	    this.IznosBruto = formformated.IznosBruto;
    	    this.IznosDohodak = formformated.IznosDohodak;
    	    this.IznosNeto = formformated.IznosNeto;
    	    this.IznosTrosak = formformated.IznosTrosak;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljPrimitak = model.ID_DohodakPrimateljPrimitak;
    	    mymodel.ID_DohodakPrimatelj = model.ID_DohodakPrimatelj;
    	    mymodel.ID_Primitak = model.ID_Primitak;
    	    mymodel.IznosBruto = model.IznosBruto;
    	    mymodel.IznosDohodak = model.IznosDohodak;
    	    mymodel.IznosNeto = model.IznosNeto;
    	    mymodel.IznosTrosak = model.IznosTrosak;
    		
    	*/
    
    		#endregion
    	
    }
}