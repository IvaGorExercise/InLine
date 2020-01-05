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
    
    
    public partial class ShemaStPoljeUvjetFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ShemaStPoljeUvjet.ID_ShemaStPoljeUvjet.Required)]
    	[DisplayName(AtributClass.ShemaStPoljeUvjet.ID_ShemaStPoljeUvjet.DisplayName)]
        	public long ID_ShemaStPoljeUvjet { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPoljeUvjet.ID_ShemaStPolje.Required)]
    	[DisplayName(AtributClass.ShemaStPoljeUvjet.ID_ShemaStPolje.DisplayName)]
       	public long ID_ShemaStPolje { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ShemaStPoljeUvjet.LogickiOperator.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPoljeUvjet.LogickiOperator.Required)]
    	[DisplayName(AtributClass.ShemaStPoljeUvjet.LogickiOperator.DisplayName)]
       	public string LogickiOperator { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPoljeUvjet.Operand.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ShemaStPoljeUvjet.Operand.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Operand { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPoljeUvjet.Negacija.Required)]
    	[DisplayName(AtributClass.ShemaStPoljeUvjet.Negacija.DisplayName)]
       	public bool Negacija { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ShemaStPoljeUvjetFormFormattedBase()
        { }
    	
    	public ShemaStPoljeUvjetFormFormattedBase(Model.Data.ShemaStPoljeUvjet formformated)
    	{
    	    this.ID_ShemaStPoljeUvjet = formformated.ID_ShemaStPoljeUvjet;
    	    this.ID_ShemaStPolje = formformated.ID_ShemaStPolje;
    	    this.LogickiOperator = formformated.LogickiOperator;
    	    this.Operand = formformated.Operand;
    	    this.Negacija = formformated.Negacija;
    	}
    
    	/*
    	    mymodel.ID_ShemaStPoljeUvjet = model.ID_ShemaStPoljeUvjet;
    	    mymodel.ID_ShemaStPolje = model.ID_ShemaStPolje;
    	    mymodel.LogickiOperator = model.LogickiOperator;
    	    mymodel.Operand = model.Operand;
    	    mymodel.Negacija = model.Negacija;
    		
    	*/
    
    		#endregion
    	
    }
}