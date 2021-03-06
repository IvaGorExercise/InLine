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
    
    
    public partial class ZbrojniNalogVerzijaTablicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.IDZbrojniNalogVerzija.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzijaTablica.IDZbrojniNalogVerzija.DisplayName)]
       	public int IDZbrojniNalogVerzija { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.IDZbrojniNalogVerzijaTablica.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzijaTablica.IDZbrojniNalogVerzijaTablica.DisplayName)]
       	public int IDZbrojniNalogVerzijaTablica { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzijaTablica.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalogVerzijaTablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ZbrojniNalogVerzijaTablica.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZbrojniNalogVerzijaTablicaFormFormattedBase()
        { }
    	
    	public ZbrojniNalogVerzijaTablicaFormFormattedBase(Model.Data.ZbrojniNalogVerzijaTablica formformated)
    	{
    	    this.IDZbrojniNalogVerzija = formformated.IDZbrojniNalogVerzija;
    	    this.IDZbrojniNalogVerzijaTablica = formformated.IDZbrojniNalogVerzijaTablica;
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	}
    
    	/*
    	    mymodel.IDZbrojniNalogVerzija = model.IDZbrojniNalogVerzija;
    	    mymodel.IDZbrojniNalogVerzijaTablica = model.IDZbrojniNalogVerzijaTablica;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    		
    	*/
    
    		#endregion
    	
    }
}
