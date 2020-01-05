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
    
    
    public partial class DavanjeTablicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DavanjeTablica.IDDavanjeTablica.Required)]
    	[DisplayName(AtributClass.DavanjeTablica.IDDavanjeTablica.DisplayName)]
       	public int IDDavanjeTablica { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.DavanjeTablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeTablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.DavanjeTablica.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.DavanjeTablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjeTablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.DavanjeTablica.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DavanjeTablicaFormFormattedBase()
        { }
    	
    	public DavanjeTablicaFormFormattedBase(Model.Data.DavanjeTablica formformated)
    	{
    	    this.IDDavanjeTablica = formformated.IDDavanjeTablica;
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	}
    
    	/*
    	    mymodel.IDDavanjeTablica = model.IDDavanjeTablica;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    		
    	*/
    
    		#endregion
    	
    }
}