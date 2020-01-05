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
    
    
    public partial class IzvodTemeljnicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.Required)]
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_IzvodTemeljnica.DisplayName)]
        	public long ID_IzvodTemeljnica { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_Izvod.DisplayName)]
       	public Nullable<long> ID_Izvod { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.IznosDuguje.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.IzvodTemeljnica.IznosDuguje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosDuguje { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.IznosPotrazuje.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.IzvodTemeljnica.IznosPotrazuje.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPotrazuje { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.SaldoStaro.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.IzvodTemeljnica.SaldoStaro.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal SaldoStaro { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodTemeljnica.SaldoNovo.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.IzvodTemeljnica.SaldoNovo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal SaldoNovo { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.IzvodTemeljnica.TemeljnicaStatus.StringLength)]
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaStatus.DisplayName)]
       	public string TemeljnicaStatus { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.IzvodTemeljnica.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public IzvodTemeljnicaFormFormattedBase()
        { }
    	
    	public IzvodTemeljnicaFormFormattedBase(Model.Data.IzvodTemeljnica formformated)
    	{
    	    this.ID_IzvodTemeljnica = formformated.ID_IzvodTemeljnica;
    	    this.ID_Izvod = formformated.ID_Izvod;
    	    this.IznosDuguje = formformated.IznosDuguje;
    	    this.IznosPotrazuje = formformated.IznosPotrazuje;
    	    this.SaldoStaro = formformated.SaldoStaro;
    	    this.SaldoNovo = formformated.SaldoNovo;
    	    this.TemeljnicaStatus = formformated.TemeljnicaStatus;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	}
    
    	/*
    	    mymodel.ID_IzvodTemeljnica = model.ID_IzvodTemeljnica;
    	    mymodel.ID_Izvod = model.ID_Izvod;
    	    mymodel.IznosDuguje = model.IznosDuguje;
    	    mymodel.IznosPotrazuje = model.IznosPotrazuje;
    	    mymodel.SaldoStaro = model.SaldoStaro;
    	    mymodel.SaldoNovo = model.SaldoNovo;
    	    mymodel.TemeljnicaStatus = model.TemeljnicaStatus;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    		
    	*/
    
    		#endregion
    	
    }
}
