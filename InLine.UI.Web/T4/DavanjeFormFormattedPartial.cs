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
    
    
    public partial class DavanjeFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Davanje.ID_Davanje.Required)]
    	[DisplayName(AtributClass.Davanje.ID_Davanje.DisplayName)]
        	public long ID_Davanje { get; set; }
    
        [Required(ErrorMessage = AtributClass.Davanje.IDDavanjeTablica.Required)]
    	[DisplayName(AtributClass.Davanje.IDDavanjeTablica.DisplayName)]
       	public int IDDavanjeTablica { get; set; }
    
        [Required(ErrorMessage = AtributClass.Davanje.IDDavanje.Required)]
    	[DisplayName(AtributClass.Davanje.IDDavanje.DisplayName)]
       	public long IDDavanje { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Davanje.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Davanje.Naziv.Required)]
    	[DisplayName(AtributClass.Davanje.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	[DisplayName(AtributClass.Davanje.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> Stopa { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Davanje.DatumOd.DisplayName)]
       	public Nullable<System.DateTime> DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Davanje.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.Davanje.IznosOd.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosOd { get; set; }
    
    	[DisplayName(AtributClass.Davanje.IznosDo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDo { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DavanjeFormFormattedBase()
        { }
    	
    	public DavanjeFormFormattedBase(Model.Data.Davanje formformated)
    	{
    	    this.ID_Davanje = formformated.ID_Davanje;
    	    this.IDDavanjeTablica = formformated.IDDavanjeTablica;
    	    this.IDDavanje = formformated.IDDavanje;
    	    this.Naziv = formformated.Naziv;
    	    this.Stopa = formformated.Stopa;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.IznosOd = formformated.IznosOd;
    	    this.IznosDo = formformated.IznosDo;
    	}
    
    	/*
    	    mymodel.ID_Davanje = model.ID_Davanje;
    	    mymodel.IDDavanjeTablica = model.IDDavanjeTablica;
    	    mymodel.IDDavanje = model.IDDavanje;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Stopa = model.Stopa;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.IznosOd = model.IznosOd;
    	    mymodel.IznosDo = model.IznosDo;
    		
    	*/
    
    		#endregion
    	
    }
}
