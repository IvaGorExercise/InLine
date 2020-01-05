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
    
    
    public partial class DavanjeDoprinosDohodakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DavanjeDoprinosDohodak.IDDavanjeDoprinosDohodak.Required)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.IDDavanjeDoprinosDohodak.DisplayName)]
       	public int IDDavanjeDoprinosDohodak { get; set; }
    
        [Required(ErrorMessage = AtributClass.DavanjeDoprinosDohodak.IDDavanjeDoprinosDohodakVr.Required)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.IDDavanjeDoprinosDohodakVr.DisplayName)]
       	public int IDDavanjeDoprinosDohodakVr { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.DavanjeDoprinosDohodak.DatumOd.Required)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.DavanjeDoprinosDohodak.Stopa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.Stopa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Stopa { get; set; }
    
        [Required(ErrorMessage = AtributClass.DavanjeDoprinosDohodak.IzBruto.Required)]
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.IzBruto.DisplayName)]
       	public bool IzBruto { get; set; }
    
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.IDMirovinskiStup.DisplayName)]
       	public Nullable<int> IDMirovinskiStup { get; set; }
    
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.IDPoticanjeZaposljavanja.DisplayName)]
       	public Nullable<int> IDPoticanjeZaposljavanja { get; set; }
    
    	[DisplayName(AtributClass.DavanjeDoprinosDohodak.PrvoZaposlenje.DisplayName)]
       	public Nullable<bool> PrvoZaposlenje { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DavanjeDoprinosDohodakFormFormattedBase()
        { }
    	
    	public DavanjeDoprinosDohodakFormFormattedBase(Model.Data.DavanjeDoprinosDohodak formformated)
    	{
    	    this.IDDavanjeDoprinosDohodak = formformated.IDDavanjeDoprinosDohodak;
    	    this.IDDavanjeDoprinosDohodakVr = formformated.IDDavanjeDoprinosDohodakVr;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.Stopa = formformated.Stopa;
    	    this.IzBruto = formformated.IzBruto;
    	    this.IDMirovinskiStup = formformated.IDMirovinskiStup;
    	    this.IDPoticanjeZaposljavanja = formformated.IDPoticanjeZaposljavanja;
    	    this.PrvoZaposlenje = formformated.PrvoZaposlenje;
    	}
    
    	/*
    	    mymodel.IDDavanjeDoprinosDohodak = model.IDDavanjeDoprinosDohodak;
    	    mymodel.IDDavanjeDoprinosDohodakVr = model.IDDavanjeDoprinosDohodakVr;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.Stopa = model.Stopa;
    	    mymodel.IzBruto = model.IzBruto;
    	    mymodel.IDMirovinskiStup = model.IDMirovinskiStup;
    	    mymodel.IDPoticanjeZaposljavanja = model.IDPoticanjeZaposljavanja;
    	    mymodel.PrvoZaposlenje = model.PrvoZaposlenje;
    		
    	*/
    
    		#endregion
    	
    }
}
