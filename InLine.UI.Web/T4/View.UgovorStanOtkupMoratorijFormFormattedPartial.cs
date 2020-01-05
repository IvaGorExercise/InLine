//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
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
    
    
    public partial class UgovorStanOtkupMoratorijFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkupMoratorij.DisplayName)]
        	public long ID_UgovorStanOtkupMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojMoratorij.DisplayName)]
       	public int BrojMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.BrojUgovor.DisplayName)]
       	public Nullable<int> BrojUgovor { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupMoratorij.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupMoratorijFormFormattedBase()
        { }
    	
    	public UgovorStanOtkupMoratorijFormFormattedBase(Model.Data.View.UgovorStanOtkupMoratorij formformated)
    	{
    	    this.ID_UgovorStanOtkupMoratorij = formformated.ID_UgovorStanOtkupMoratorij;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.BrojMoratorij = formformated.BrojMoratorij;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.Datum = formformated.Datum;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojMoratorij = model.BrojMoratorij;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.Datum = model.Datum;
    		
    	*/
    
    		#endregion
    	
    }
}