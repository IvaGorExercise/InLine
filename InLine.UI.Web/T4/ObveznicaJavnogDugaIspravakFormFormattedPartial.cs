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
    
    
    public partial class ObveznicaJavnogDugaIspravakFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.ID_ObveznicaJavnogDugaIspravak.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.ID_ObveznicaJavnogDugaIspravak.DisplayName)]
        	public long ID_ObveznicaJavnogDugaIspravak { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.GodinaIzvod.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.GodinaIzvod.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.GodinaIzvod.DisplayName)]
       	public string GodinaIzvod { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.RacunIzvod.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.RacunIzvod.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.RacunIzvod.DisplayName)]
       	public string RacunIzvod { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.RacunVrIzvod.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.RacunVrIzvod.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.RacunVrIzvod.DisplayName)]
       	public string RacunVrIzvod { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvod.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvod.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvod.DisplayName)]
       	public string BrojIzvod { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvodSt.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvodSt.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.BrojIzvodSt.DisplayName)]
       	public string BrojIzvodSt { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.IDValuta.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.ID_ObveznicaJavnogDuga.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.ID_ObveznicaJavnogDuga.DisplayName)]
       	public long ID_ObveznicaJavnogDuga { get; set; }
    
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.RedniBroj.DisplayName)]
       	public Nullable<int> RedniBroj { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.Aktivno.Required)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.Aktivno.DisplayName)]
       	public bool Aktivno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.Iznos.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Iznos { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObveznicaJavnogDugaIspravak.IznosValuta.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObveznicaJavnogDugaIspravak.IznosValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosValuta { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObveznicaJavnogDugaIspravakFormFormattedBase()
        { }
    	
    	public ObveznicaJavnogDugaIspravakFormFormattedBase(Model.Data.ObveznicaJavnogDugaIspravak formformated)
    	{
    	    this.ID_ObveznicaJavnogDugaIspravak = formformated.ID_ObveznicaJavnogDugaIspravak;
    	    this.GodinaIzvod = formformated.GodinaIzvod;
    	    this.RacunIzvod = formformated.RacunIzvod;
    	    this.RacunVrIzvod = formformated.RacunVrIzvod;
    	    this.BrojIzvod = formformated.BrojIzvod;
    	    this.BrojIzvodSt = formformated.BrojIzvodSt;
    	    this.IDValuta = formformated.IDValuta;
    	    this.ID_ObveznicaJavnogDuga = formformated.ID_ObveznicaJavnogDuga;
    	    this.RedniBroj = formformated.RedniBroj;
    	    this.Aktivno = formformated.Aktivno;
    	    this.Iznos = formformated.Iznos;
    	    this.IznosValuta = formformated.IznosValuta;
    	}
    
    	/*
    	    mymodel.ID_ObveznicaJavnogDugaIspravak = model.ID_ObveznicaJavnogDugaIspravak;
    	    mymodel.GodinaIzvod = model.GodinaIzvod;
    	    mymodel.RacunIzvod = model.RacunIzvod;
    	    mymodel.RacunVrIzvod = model.RacunVrIzvod;
    	    mymodel.BrojIzvod = model.BrojIzvod;
    	    mymodel.BrojIzvodSt = model.BrojIzvodSt;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.ID_ObveznicaJavnogDuga = model.ID_ObveznicaJavnogDuga;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.Aktivno = model.Aktivno;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.IznosValuta = model.IznosValuta;
    		
    	*/
    
    		#endregion
    	
    }
}
