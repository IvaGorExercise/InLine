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
    
    
    public partial class DavanjePorezDohodakVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.IDDavanjePorezDohodakVr.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.IDDavanjePorezDohodakVr.DisplayName)]
       	public int IDDavanjePorezDohodakVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DavanjePorezDohodakVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DavanjePorezDohodakVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.Naziv.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DavanjePorezDohodakVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DavanjePorezDohodakVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.Kratica.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.DatumOd.Required)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.DavanjePorezDohodakVr.OsobniOdbitak.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.OsobniOdbitak.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal OsobniOdbitak { get; set; }
    
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.NNGodina.DisplayName)]
       	public Nullable<int> NNGodina { get; set; }
    
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.NNBroj.DisplayName)]
       	public Nullable<int> NNBroj { get; set; }
    
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.NNClanak.DisplayName)]
       	public Nullable<int> NNClanak { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePorezDohodakVr.NNDatum.DisplayName)]
       	public Nullable<System.DateTime> NNDatum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DavanjePorezDohodakVrFormFormattedBase()
        { }
    	
    	public DavanjePorezDohodakVrFormFormattedBase(Model.Data.DavanjePorezDohodakVr formformated)
    	{
    	    this.IDDavanjePorezDohodakVr = formformated.IDDavanjePorezDohodakVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.OsobniOdbitak = formformated.OsobniOdbitak;
    	    this.NNGodina = formformated.NNGodina;
    	    this.NNBroj = formformated.NNBroj;
    	    this.NNClanak = formformated.NNClanak;
    	    this.NNDatum = formformated.NNDatum;
    	}
    
    	/*
    	    mymodel.IDDavanjePorezDohodakVr = model.IDDavanjePorezDohodakVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.OsobniOdbitak = model.OsobniOdbitak;
    	    mymodel.NNGodina = model.NNGodina;
    	    mymodel.NNBroj = model.NNBroj;
    	    mymodel.NNClanak = model.NNClanak;
    	    mymodel.NNDatum = model.NNDatum;
    		
    	*/
    
    		#endregion
    	
    }
}