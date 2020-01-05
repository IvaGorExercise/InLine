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
    
    
    public partial class IzvodVerzijaTablicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.IzvodVerzijaTablica.IDIzvodVerzija.Required)]
    	[DisplayName(AtributClass.IzvodVerzijaTablica.IDIzvodVerzija.DisplayName)]
       	public int IDIzvodVerzija { get; set; }
    
        [Required(ErrorMessage = AtributClass.IzvodVerzijaTablica.IDIzvodVerzijaTablica.Required)]
    	[DisplayName(AtributClass.IzvodVerzijaTablica.IDIzvodVerzijaTablica.DisplayName)]
       	public int IDIzvodVerzijaTablica { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.IzvodVerzijaTablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.IzvodVerzijaTablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.IzvodVerzijaTablica.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.IzvodVerzijaTablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.IzvodVerzijaTablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.IzvodVerzijaTablica.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public IzvodVerzijaTablicaFormFormattedBase()
        { }
    	
    	public IzvodVerzijaTablicaFormFormattedBase(Model.Data.IzvodVerzijaTablica formformated)
    	{
    	    this.IDIzvodVerzija = formformated.IDIzvodVerzija;
    	    this.IDIzvodVerzijaTablica = formformated.IDIzvodVerzijaTablica;
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	}
    
    	/*
    	    mymodel.IDIzvodVerzija = model.IDIzvodVerzija;
    	    mymodel.IDIzvodVerzijaTablica = model.IDIzvodVerzijaTablica;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    		
    	*/
    
    		#endregion
    	
    }
}