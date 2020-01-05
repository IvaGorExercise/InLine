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
    
    
    public partial class ObrazacIPMjesec2011AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.ID_ObrazacIPMjesec2011A.Required)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.ID_ObrazacIPMjesec2011A.DisplayName)]
        	public long ID_ObrazacIPMjesec2011A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.ID_ObrazacIP.Required)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.ID_ObrazacIP.DisplayName)]
       	public long ID_ObrazacIP { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.Mjesec.Required)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.Mjesec.DisplayName)]
       	public int Mjesec { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.ID_Opcina.Required)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ObrazacIPMjesec2011A.SifraOpcina.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.SifraOpcina.Required)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.SifraOpcina.DisplayName)]
       	public string SifraOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosIsplata.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosIsplata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosIsplata { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosUplataDoprinosIz.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosUplataDoprinosIz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUplataDoprinosIz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosDohodak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosDohodak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosDohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosOsobniOdbitak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosOsobniOdbitak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosOsobniOdbitak { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosPorezOsnova.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosPorezOsnova.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorezOsnova { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosUplataPorezPrirez.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosUplataPorezPrirez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUplataPorezPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIPMjesec2011A.IznosIsplataNeto.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIPMjesec2011A.IznosIsplataNeto.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosIsplataNeto { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacIPMjesec2011AFormFormattedBase()
        { }
    	
    	public ObrazacIPMjesec2011AFormFormattedBase(Model.Data.ObrazacIPMjesec2011A formformated)
    	{
    	    this.ID_ObrazacIPMjesec2011A = formformated.ID_ObrazacIPMjesec2011A;
    	    this.ID_ObrazacIP = formformated.ID_ObrazacIP;
    	    this.Mjesec = formformated.Mjesec;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.SifraOpcina = formformated.SifraOpcina;
    	    this.IznosIsplata = formformated.IznosIsplata;
    	    this.IznosUplataDoprinosIz = formformated.IznosUplataDoprinosIz;
    	    this.IznosDohodak = formformated.IznosDohodak;
    	    this.IznosOsobniOdbitak = formformated.IznosOsobniOdbitak;
    	    this.IznosPorezOsnova = formformated.IznosPorezOsnova;
    	    this.IznosUplataPorezPrirez = formformated.IznosUplataPorezPrirez;
    	    this.IznosIsplataNeto = formformated.IznosIsplataNeto;
    	}
    
    	/*
    	    mymodel.ID_ObrazacIPMjesec2011A = model.ID_ObrazacIPMjesec2011A;
    	    mymodel.ID_ObrazacIP = model.ID_ObrazacIP;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.SifraOpcina = model.SifraOpcina;
    	    mymodel.IznosIsplata = model.IznosIsplata;
    	    mymodel.IznosUplataDoprinosIz = model.IznosUplataDoprinosIz;
    	    mymodel.IznosDohodak = model.IznosDohodak;
    	    mymodel.IznosOsobniOdbitak = model.IznosOsobniOdbitak;
    	    mymodel.IznosPorezOsnova = model.IznosPorezOsnova;
    	    mymodel.IznosUplataPorezPrirez = model.IznosUplataPorezPrirez;
    	    mymodel.IznosIsplataNeto = model.IznosIsplataNeto;
    		
    	*/
    
    		#endregion
    	
    }
}
