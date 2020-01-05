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
    
    
    public partial class ObrazacPoljeFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacPolje.ID_ObrazacPolje.Required)]
    	[DisplayName(AtributClass.ObrazacPolje.ID_ObrazacPolje.DisplayName)]
        	public long ID_ObrazacPolje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPolje.ID_Obrazac.Required)]
    	[DisplayName(AtributClass.ObrazacPolje.ID_Obrazac.DisplayName)]
       	public long ID_Obrazac { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPolje.Redak.Required)]
    	[DisplayName(AtributClass.ObrazacPolje.Redak.DisplayName)]
       	public int Redak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPolje.ID_ObrazacVrPolje.Required)]
    	[DisplayName(AtributClass.ObrazacPolje.ID_ObrazacVrPolje.DisplayName)]
       	public long ID_ObrazacVrPolje { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPolje.ValueBit.DisplayName)]
       	public Nullable<bool> ValueBit { get; set; }
    
    	
        [StringLength(4000, ErrorMessage = AtributClass.ObrazacPolje.ValueString.StringLength)]
    	[DisplayName(AtributClass.ObrazacPolje.ValueString.DisplayName)]
       	public string ValueString { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPolje.ValueInt.DisplayName)]
       	public Nullable<int> ValueInt { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPolje.ValueMoney.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> ValueMoney { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ObrazacPolje.ValueDate.DisplayName)]
       	public Nullable<System.DateTime> ValueDate { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPolje.ValueTime.DisplayName)]
       	public Nullable<System.TimeSpan> ValueTime { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ObrazacPolje.ValueDateTime.DisplayName)]
       	public Nullable<System.DateTime> ValueDateTime { get; set; }
    
    	[DisplayName(AtributClass.ObrazacPolje.ValueDecimal.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> ValueDecimal { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacPoljeFormFormattedBase()
        { }
    	
    	public ObrazacPoljeFormFormattedBase(Model.Data.ObrazacPolje formformated)
    	{
    	    this.ID_ObrazacPolje = formformated.ID_ObrazacPolje;
    	    this.ID_Obrazac = formformated.ID_Obrazac;
    	    this.Redak = formformated.Redak;
    	    this.ID_ObrazacVrPolje = formformated.ID_ObrazacVrPolje;
    	    this.ValueBit = formformated.ValueBit;
    	    this.ValueString = formformated.ValueString;
    	    this.ValueInt = formformated.ValueInt;
    	    this.ValueMoney = formformated.ValueMoney;
    	    this.ValueDate = formformated.ValueDate;
    	    this.ValueTime = formformated.ValueTime;
    	    this.ValueDateTime = formformated.ValueDateTime;
    	    this.ValueDecimal = formformated.ValueDecimal;
    	}
    
    	/*
    	    mymodel.ID_ObrazacPolje = model.ID_ObrazacPolje;
    	    mymodel.ID_Obrazac = model.ID_Obrazac;
    	    mymodel.Redak = model.Redak;
    	    mymodel.ID_ObrazacVrPolje = model.ID_ObrazacVrPolje;
    	    mymodel.ValueBit = model.ValueBit;
    	    mymodel.ValueString = model.ValueString;
    	    mymodel.ValueInt = model.ValueInt;
    	    mymodel.ValueMoney = model.ValueMoney;
    	    mymodel.ValueDate = model.ValueDate;
    	    mymodel.ValueTime = model.ValueTime;
    	    mymodel.ValueDateTime = model.ValueDateTime;
    	    mymodel.ValueDecimal = model.ValueDecimal;
    		
    	*/
    
    		#endregion
    	
    }
}