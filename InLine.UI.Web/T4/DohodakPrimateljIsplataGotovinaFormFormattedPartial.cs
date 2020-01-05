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
    
    
    public partial class DohodakPrimateljIsplataGotovinaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataGotovina.ID_DohodakPrimateljIsplataGotovina.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataGotovina.ID_DohodakPrimateljIsplataGotovina.DisplayName)]
        	public long ID_DohodakPrimateljIsplataGotovina { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataGotovina.ID_DohodakPrimatelj.Required)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataGotovina.ID_DohodakPrimatelj.DisplayName)]
       	public long ID_DohodakPrimatelj { get; set; }
    
        [Required(ErrorMessage = AtributClass.DohodakPrimateljIsplataGotovina.Iznos.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.DohodakPrimateljIsplataGotovina.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Iznos { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DohodakPrimateljIsplataGotovinaFormFormattedBase()
        { }
    	
    	public DohodakPrimateljIsplataGotovinaFormFormattedBase(Model.Data.DohodakPrimateljIsplataGotovina formformated)
    	{
    	    this.ID_DohodakPrimateljIsplataGotovina = formformated.ID_DohodakPrimateljIsplataGotovina;
    	    this.ID_DohodakPrimatelj = formformated.ID_DohodakPrimatelj;
    	    this.Iznos = formformated.Iznos;
    	}
    
    	/*
    	    mymodel.ID_DohodakPrimateljIsplataGotovina = model.ID_DohodakPrimateljIsplataGotovina;
    	    mymodel.ID_DohodakPrimatelj = model.ID_DohodakPrimatelj;
    	    mymodel.Iznos = model.Iznos;
    		
    	*/
    
    		#endregion
    	
    }
}