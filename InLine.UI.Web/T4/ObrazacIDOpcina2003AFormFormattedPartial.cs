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
    
    
    public partial class ObrazacIDOpcina2003AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.ID_ObrazacIDOpcina2003A.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.ID_ObrazacIDOpcina2003A.DisplayName)]
        	public long ID_ObrazacIDOpcina2003A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.ID_ObrazacID.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.ID_ObrazacID.DisplayName)]
       	public long ID_ObrazacID { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.ID_Opcina.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.RedniBroj.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.RedniBroj.DisplayName)]
       	public int RedniBroj { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ObrazacIDOpcina2003A.SifraOpcina.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.SifraOpcina.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.SifraOpcina.DisplayName)]
       	public string SifraOpcina { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ObrazacIDOpcina2003A.NazivOpcina.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.NazivOpcina.Required)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.NazivOpcina.DisplayName)]
       	public string NazivOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.IznosPorez.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.IznosPorez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPorez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.IznosPrirez.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.IznosPrirez.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPrirez { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacIDOpcina2003A.IznosUkupno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ObrazacIDOpcina2003A.IznosUkupno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUkupno { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ObrazacIDOpcina2003AFormFormattedBase()
        { }
    	
    	public ObrazacIDOpcina2003AFormFormattedBase(Model.Data.ObrazacIDOpcina2003A formformated)
    	{
    	    this.ID_ObrazacIDOpcina2003A = formformated.ID_ObrazacIDOpcina2003A;
    	    this.ID_ObrazacID = formformated.ID_ObrazacID;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.RedniBroj = formformated.RedniBroj;
    	    this.SifraOpcina = formformated.SifraOpcina;
    	    this.NazivOpcina = formformated.NazivOpcina;
    	    this.IznosPorez = formformated.IznosPorez;
    	    this.IznosPrirez = formformated.IznosPrirez;
    	    this.IznosUkupno = formformated.IznosUkupno;
    	}
    
    	/*
    	    mymodel.ID_ObrazacIDOpcina2003A = model.ID_ObrazacIDOpcina2003A;
    	    mymodel.ID_ObrazacID = model.ID_ObrazacID;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.RedniBroj = model.RedniBroj;
    	    mymodel.SifraOpcina = model.SifraOpcina;
    	    mymodel.NazivOpcina = model.NazivOpcina;
    	    mymodel.IznosPorez = model.IznosPorez;
    	    mymodel.IznosPrirez = model.IznosPrirez;
    	    mymodel.IznosUkupno = model.IznosUkupno;
    		
    	*/
    
    		#endregion
    	
    }
}
