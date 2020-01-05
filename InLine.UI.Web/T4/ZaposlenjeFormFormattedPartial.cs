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
    
    
    public partial class ZaposlenjeFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.ID_Zaposlenje.Required)]
    	[DisplayName(AtributClass.Zaposlenje.ID_Zaposlenje.DisplayName)]
        	public long ID_Zaposlenje { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.ID_Osoba.Required)]
    	[DisplayName(AtributClass.Zaposlenje.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.ID_Subjekt.Required)]
    	[DisplayName(AtributClass.Zaposlenje.ID_Subjekt.DisplayName)]
       	public long ID_Subjekt { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Zaposlenje.DatumOd.Required)]
    	[DisplayName(AtributClass.Zaposlenje.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Zaposlenje.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.StazGodina.Required)]
    	[DisplayName(AtributClass.Zaposlenje.StazGodina.DisplayName)]
       	public int StazGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.StazMjesec.Required)]
    	[DisplayName(AtributClass.Zaposlenje.StazMjesec.DisplayName)]
       	public int StazMjesec { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.StazDan.Required)]
    	[DisplayName(AtributClass.Zaposlenje.StazDan.DisplayName)]
       	public int StazDan { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.IDMirovinskiStup.Required)]
    	[DisplayName(AtributClass.Zaposlenje.IDMirovinskiStup.DisplayName)]
       	public int IDMirovinskiStup { get; set; }
    
        [Required(ErrorMessage = AtributClass.Zaposlenje.PrvoZaposlenje.Required)]
    	[DisplayName(AtributClass.Zaposlenje.PrvoZaposlenje.DisplayName)]
       	public bool PrvoZaposlenje { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZaposlenjeFormFormattedBase()
        { }
    	
    	public ZaposlenjeFormFormattedBase(Model.Data.Zaposlenje formformated)
    	{
    	    this.ID_Zaposlenje = formformated.ID_Zaposlenje;
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.StazGodina = formformated.StazGodina;
    	    this.StazMjesec = formformated.StazMjesec;
    	    this.StazDan = formformated.StazDan;
    	    this.IDMirovinskiStup = formformated.IDMirovinskiStup;
    	    this.PrvoZaposlenje = formformated.PrvoZaposlenje;
    	}
    
    	/*
    	    mymodel.ID_Zaposlenje = model.ID_Zaposlenje;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.StazGodina = model.StazGodina;
    	    mymodel.StazMjesec = model.StazMjesec;
    	    mymodel.StazDan = model.StazDan;
    	    mymodel.IDMirovinskiStup = model.IDMirovinskiStup;
    	    mymodel.PrvoZaposlenje = model.PrvoZaposlenje;
    		
    	*/
    
    		#endregion
    	
    }
}
