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
    
    
    public partial class UgovorStanOtkupObrokIznosFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokIznos.ID_UgovorStanOtkup.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.ID_UgovorStanOtkup.DisplayName)]
       	public long ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKredit { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKreditRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamataRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKreditOstatakRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKreditOstatakRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosKamataOstatakRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamataOstatakRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosUcesce { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokIznos.BrojObrokMax.DisplayName)]
       	public Nullable<int> BrojObrokMax { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupObrokIznosFormFormattedBase()
        { }
    	
    	public UgovorStanOtkupObrokIznosFormFormattedBase(Model.Data.View.UgovorStanOtkupObrokIznos formformated)
    	{
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKreditOstatakRevalorizacija = formformated.IznosKreditOstatakRevalorizacija;
    	    this.IznosKamataOstatakRevalorizacija = formformated.IznosKamataOstatakRevalorizacija;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.BrojObrokMax = formformated.BrojObrokMax;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKreditOstatakRevalorizacija = model.IznosKreditOstatakRevalorizacija;
    	    mymodel.IznosKamataOstatakRevalorizacija = model.IznosKamataOstatakRevalorizacija;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.BrojObrokMax = model.BrojObrokMax;
    		
    	*/
    
    		#endregion
    	
    }
}
