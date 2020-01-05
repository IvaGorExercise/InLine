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
    
    
    public partial class DohodakPrimateljIsplataRacunFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimateljIsplataRacun.DisplayName)]
        	public long ID_DohodakPrimateljIsplataRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_DohodakPrimatelj.DisplayName)]
       	public long ID_DohodakPrimatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.ID_SubjektRacun.DisplayName)]
       	public long ID_SubjektRacun { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataRacun.Iznos.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataRacun.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Iznos { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DohodakPrimateljIsplataRacunFormFormattedBase()
        { }
    	
    	public DohodakPrimateljIsplataRacunFormFormattedBase(Model.Data.DohodakPrimateljIsplataRacun formformated)
    	{
    	    this.ID_DohodakPrimateljIsplataRacun = formformated.ID_DohodakPrimateljIsplataRacun;
    	    this.ID_DohodakPrimatelj = formformated.ID_DohodakPrimatelj;
    	    this.ID_SubjektRacun = formformated.ID_SubjektRacun;
    	    this.Iznos = formformated.Iznos;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljIsplataRacun = model.ID_DohodakPrimateljIsplataRacun;
    	    mymodel.ID_DohodakPrimatelj = model.ID_DohodakPrimatelj;
    	    mymodel.ID_SubjektRacun = model.ID_SubjektRacun;
    	    mymodel.Iznos = model.Iznos;
    		
    	*/
    
    		#endregion
    	
    }
}
