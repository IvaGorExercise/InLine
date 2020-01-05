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
    
    
    public partial class ShemaStPoljeFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.ID_ShemaStPolje.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.ID_ShemaStPolje.DisplayName)]
        	public long ID_ShemaStPolje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.ID_ShemaSt.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.ID_ShemaSt.DisplayName)]
       	public long ID_ShemaSt { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaShema.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ShemaStPolje.TablicaPoljeNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ShemaStPolje.TablicaPoljeNaziv.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.TablicaPoljeNaziv.DisplayName)]
       	public string TablicaPoljeNaziv { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ShemaStPolje.AritmetickiOperator.StringLength)]
    	[DisplayName(AtributClass.ShemaStPolje.AritmetickiOperator.DisplayName)]
       	public string AritmetickiOperator { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.Operand.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ShemaStPolje.Operand.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Operand { get; set; }
    
        [Required(ErrorMessage = AtributClass.ShemaStPolje.Negativno.Required)]
    	[DisplayName(AtributClass.ShemaStPolje.Negativno.DisplayName)]
       	public bool Negativno { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ShemaStPoljeFormFormattedBase()
        { }
    	
    	public ShemaStPoljeFormFormattedBase(Model.Data.ShemaStPolje formformated)
    	{
    	    this.ID_ShemaStPolje = formformated.ID_ShemaStPolje;
    	    this.ID_ShemaSt = formformated.ID_ShemaSt;
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	    this.TablicaPoljeNaziv = formformated.TablicaPoljeNaziv;
    	    this.AritmetickiOperator = formformated.AritmetickiOperator;
    	    this.Operand = formformated.Operand;
    	    this.Negativno = formformated.Negativno;
    	}
    
    	/*
    	    mymodel.ID_ShemaStPolje = model.ID_ShemaStPolje;
    	    mymodel.ID_ShemaSt = model.ID_ShemaSt;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.TablicaPoljeNaziv = model.TablicaPoljeNaziv;
    	    mymodel.AritmetickiOperator = model.AritmetickiOperator;
    	    mymodel.Operand = model.Operand;
    	    mymodel.Negativno = model.Negativno;
    		
    	*/
    
    		#endregion
    	
    }
}