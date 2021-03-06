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
    
    
    public partial class ObrazacPDV2012AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.ID_ObrazacPDV2012A.Required)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.ID_ObrazacPDV2012A.DisplayName)]
        	public long ID_ObrazacPDV2012A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.ID_ObrazacPDV.Required)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.ID_ObrazacPDV.DisplayName)]
       	public long ID_ObrazacPDV { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacPDV2012A.PorezniObveznikNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.PorezniObveznikNaziv.Required)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.PorezniObveznikNaziv.DisplayName)]
       	public string PorezniObveznikNaziv { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacPDV2012A.PorezniObveznikAdresa.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.PorezniObveznikAdresa.Required)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.PorezniObveznikAdresa.DisplayName)]
       	public string PorezniObveznikAdresa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostNeoporezivo.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostNeoporezivo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostNeoporezivo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostOslobodenoIzvoz.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostOslobodenoIzvoz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostOslobodenoIzvoz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostOslobodenoIsporuka.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostOslobodenoIsporuka.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostOslobodenoIsporuka { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostOslobodenoTuzemstvo.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostOslobodenoTuzemstvo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostOslobodenoTuzemstvo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostOslobodenoOstalo.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostOslobodenoOstalo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostOslobodenoOstalo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPorez0.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPorez0.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPorez0 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPorez10.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPorez10.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPorez10 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPorez10.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPorez10.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorez10 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPorez22.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPorez22.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPorez22 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPorez22.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPorez22.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorez22 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPorez23.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPorez23.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPorez23 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPorez23.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPorez23.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorez23 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPorez25.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPorez25.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPorez25 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPorez25.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPorez25.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorez25 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez10.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez10.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez10 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez10.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez10.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez10 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez22.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez22.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez22 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez22.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez22.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez22 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez23.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez23.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez23 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez23.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez23.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez23 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez25.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez25.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez25 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez25.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez25.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez25 { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporezUvoz.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporezUvoz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporezUvoz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporezUvoz.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporezUvoz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporezUvoz { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez10OdbitakNe.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez10OdbitakNe.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez10OdbitakNe { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez10OdbitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez10OdbitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez10OdbitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez10ObitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez10ObitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez10ObitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez22OdbitakNe.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez22OdbitakNe.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez22OdbitakNe { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez22OdbitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez22OdbitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez22OdbitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez22ObitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez22ObitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez22ObitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez23OdbitakNe.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez23OdbitakNe.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez23OdbitakNe { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez23OdbitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez23OdbitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez23OdbitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez23ObitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez23ObitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez23ObitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez25OdbitakNe.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez25OdbitakNe.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez25OdbitakNe { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.VrijednostPretporez25OdbitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.VrijednostPretporez25OdbitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal VrijednostPretporez25OdbitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporez25ObitakDa.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporez25ObitakDa.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporez25ObitakDa { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacPDV2012A.IznosPretporezIspravak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacPDV2012A.IznosPretporezIspravak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPretporezIspravak { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacPDV2012AFormFormattedBase()
        { }
    	
    	public ObrazacPDV2012AFormFormattedBase(Model.Data.ObrazacPDV2012A formformated)
    	{
    	    this.ID_ObrazacPDV2012A = formformated.ID_ObrazacPDV2012A;
    	    this.ID_ObrazacPDV = formformated.ID_ObrazacPDV;
    	    this.PorezniObveznikNaziv = formformated.PorezniObveznikNaziv;
    	    this.PorezniObveznikAdresa = formformated.PorezniObveznikAdresa;
    	    this.VrijednostNeoporezivo = formformated.VrijednostNeoporezivo;
    	    this.VrijednostOslobodenoIzvoz = formformated.VrijednostOslobodenoIzvoz;
    	    this.VrijednostOslobodenoIsporuka = formformated.VrijednostOslobodenoIsporuka;
    	    this.VrijednostOslobodenoTuzemstvo = formformated.VrijednostOslobodenoTuzemstvo;
    	    this.VrijednostOslobodenoOstalo = formformated.VrijednostOslobodenoOstalo;
    	    this.VrijednostPorez0 = formformated.VrijednostPorez0;
    	    this.VrijednostPorez10 = formformated.VrijednostPorez10;
    	    this.IznosPorez10 = formformated.IznosPorez10;
    	    this.VrijednostPorez22 = formformated.VrijednostPorez22;
    	    this.IznosPorez22 = formformated.IznosPorez22;
    	    this.VrijednostPorez23 = formformated.VrijednostPorez23;
    	    this.IznosPorez23 = formformated.IznosPorez23;
    	    this.VrijednostPorez25 = formformated.VrijednostPorez25;
    	    this.IznosPorez25 = formformated.IznosPorez25;
    	    this.VrijednostPretporez10 = formformated.VrijednostPretporez10;
    	    this.IznosPretporez10 = formformated.IznosPretporez10;
    	    this.VrijednostPretporez22 = formformated.VrijednostPretporez22;
    	    this.IznosPretporez22 = formformated.IznosPretporez22;
    	    this.VrijednostPretporez23 = formformated.VrijednostPretporez23;
    	    this.IznosPretporez23 = formformated.IznosPretporez23;
    	    this.VrijednostPretporez25 = formformated.VrijednostPretporez25;
    	    this.IznosPretporez25 = formformated.IznosPretporez25;
    	    this.VrijednostPretporezUvoz = formformated.VrijednostPretporezUvoz;
    	    this.IznosPretporezUvoz = formformated.IznosPretporezUvoz;
    	    this.VrijednostPretporez10OdbitakNe = formformated.VrijednostPretporez10OdbitakNe;
    	    this.VrijednostPretporez10OdbitakDa = formformated.VrijednostPretporez10OdbitakDa;
    	    this.IznosPretporez10ObitakDa = formformated.IznosPretporez10ObitakDa;
    	    this.VrijednostPretporez22OdbitakNe = formformated.VrijednostPretporez22OdbitakNe;
    	    this.VrijednostPretporez22OdbitakDa = formformated.VrijednostPretporez22OdbitakDa;
    	    this.IznosPretporez22ObitakDa = formformated.IznosPretporez22ObitakDa;
    	    this.VrijednostPretporez23OdbitakNe = formformated.VrijednostPretporez23OdbitakNe;
    	    this.VrijednostPretporez23OdbitakDa = formformated.VrijednostPretporez23OdbitakDa;
    	    this.IznosPretporez23ObitakDa = formformated.IznosPretporez23ObitakDa;
    	    this.VrijednostPretporez25OdbitakNe = formformated.VrijednostPretporez25OdbitakNe;
    	    this.VrijednostPretporez25OdbitakDa = formformated.VrijednostPretporez25OdbitakDa;
    	    this.IznosPretporez25ObitakDa = formformated.IznosPretporez25ObitakDa;
    	    this.IznosPretporezIspravak = formformated.IznosPretporezIspravak;
    	}
    
    	/*
    	    mymodel.ID_ObrazacPDV2012A = model.ID_ObrazacPDV2012A;
    	    mymodel.ID_ObrazacPDV = model.ID_ObrazacPDV;
    	    mymodel.PorezniObveznikNaziv = model.PorezniObveznikNaziv;
    	    mymodel.PorezniObveznikAdresa = model.PorezniObveznikAdresa;
    	    mymodel.VrijednostNeoporezivo = model.VrijednostNeoporezivo;
    	    mymodel.VrijednostOslobodenoIzvoz = model.VrijednostOslobodenoIzvoz;
    	    mymodel.VrijednostOslobodenoIsporuka = model.VrijednostOslobodenoIsporuka;
    	    mymodel.VrijednostOslobodenoTuzemstvo = model.VrijednostOslobodenoTuzemstvo;
    	    mymodel.VrijednostOslobodenoOstalo = model.VrijednostOslobodenoOstalo;
    	    mymodel.VrijednostPorez0 = model.VrijednostPorez0;
    	    mymodel.VrijednostPorez10 = model.VrijednostPorez10;
    	    mymodel.IznosPorez10 = model.IznosPorez10;
    	    mymodel.VrijednostPorez22 = model.VrijednostPorez22;
    	    mymodel.IznosPorez22 = model.IznosPorez22;
    	    mymodel.VrijednostPorez23 = model.VrijednostPorez23;
    	    mymodel.IznosPorez23 = model.IznosPorez23;
    	    mymodel.VrijednostPorez25 = model.VrijednostPorez25;
    	    mymodel.IznosPorez25 = model.IznosPorez25;
    	    mymodel.VrijednostPretporez10 = model.VrijednostPretporez10;
    	    mymodel.IznosPretporez10 = model.IznosPretporez10;
    	    mymodel.VrijednostPretporez22 = model.VrijednostPretporez22;
    	    mymodel.IznosPretporez22 = model.IznosPretporez22;
    	    mymodel.VrijednostPretporez23 = model.VrijednostPretporez23;
    	    mymodel.IznosPretporez23 = model.IznosPretporez23;
    	    mymodel.VrijednostPretporez25 = model.VrijednostPretporez25;
    	    mymodel.IznosPretporez25 = model.IznosPretporez25;
    	    mymodel.VrijednostPretporezUvoz = model.VrijednostPretporezUvoz;
    	    mymodel.IznosPretporezUvoz = model.IznosPretporezUvoz;
    	    mymodel.VrijednostPretporez10OdbitakNe = model.VrijednostPretporez10OdbitakNe;
    	    mymodel.VrijednostPretporez10OdbitakDa = model.VrijednostPretporez10OdbitakDa;
    	    mymodel.IznosPretporez10ObitakDa = model.IznosPretporez10ObitakDa;
    	    mymodel.VrijednostPretporez22OdbitakNe = model.VrijednostPretporez22OdbitakNe;
    	    mymodel.VrijednostPretporez22OdbitakDa = model.VrijednostPretporez22OdbitakDa;
    	    mymodel.IznosPretporez22ObitakDa = model.IznosPretporez22ObitakDa;
    	    mymodel.VrijednostPretporez23OdbitakNe = model.VrijednostPretporez23OdbitakNe;
    	    mymodel.VrijednostPretporez23OdbitakDa = model.VrijednostPretporez23OdbitakDa;
    	    mymodel.IznosPretporez23ObitakDa = model.IznosPretporez23ObitakDa;
    	    mymodel.VrijednostPretporez25OdbitakNe = model.VrijednostPretporez25OdbitakNe;
    	    mymodel.VrijednostPretporez25OdbitakDa = model.VrijednostPretporez25OdbitakDa;
    	    mymodel.IznosPretporez25ObitakDa = model.IznosPretporez25ObitakDa;
    	    mymodel.IznosPretporezIspravak = model.IznosPretporezIspravak;
    		
    	*/
    
    		#endregion
    	
    }
}
