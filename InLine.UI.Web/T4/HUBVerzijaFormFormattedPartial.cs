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
    
    
    public partial class HUBVerzijaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUBVerzija.IDHUBVerzija.Required)]
    	[DisplayName(AtributClass.HUBVerzija.IDHUBVerzija.DisplayName)]
       	public int IDHUBVerzija { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.HUBVerzija.DatumOd.Required)]
    	[DisplayName(AtributClass.HUBVerzija.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.HUBVerzija.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.Napomena.DisplayName)]
       	public string Napomena { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.OpisHTML.DisplayName)]
       	public string OpisHTML { get; set; }
    
    	[DisplayName(AtributClass.HUBVerzija.NapomenaHTML.DisplayName)]
       	public string NapomenaHTML { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUBVerzijaFormFormattedBase()
        { }
    	
    	public HUBVerzijaFormFormattedBase(Model.Data.HUBVerzija formformated)
    	{
    	    this.IDHUBVerzija = formformated.IDHUBVerzija;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.Opis = formformated.Opis;
    	    this.Napomena = formformated.Napomena;
    	    this.OpisHTML = formformated.OpisHTML;
    	    this.NapomenaHTML = formformated.NapomenaHTML;
    	}
    
    	/*
    	    mymodel.IDHUBVerzija = model.IDHUBVerzija;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.Opis = model.Opis;
    	    mymodel.Napomena = model.Napomena;
    	    mymodel.OpisHTML = model.OpisHTML;
    	    mymodel.NapomenaHTML = model.NapomenaHTML;
    		
    	*/
    
    		#endregion
    	
    }
}
