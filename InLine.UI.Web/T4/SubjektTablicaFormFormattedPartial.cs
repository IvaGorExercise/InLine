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
    
    
    public partial class SubjektTablicaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.SubjektTablica.IDSubjektTablica.Required)]
    	[DisplayName(AtributClass.SubjektTablica.IDSubjektTablica.DisplayName)]
       	public int IDSubjektTablica { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.SubjektTablica.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektTablica.TablicaShema.Required)]
    	[DisplayName(AtributClass.SubjektTablica.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.SubjektTablica.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.SubjektTablica.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.SubjektTablica.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public SubjektTablicaFormFormattedBase()
        { }
    	
    	public SubjektTablicaFormFormattedBase(Model.Data.SubjektTablica formformated)
    	{
    	    this.IDSubjektTablica = formformated.IDSubjektTablica;
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	}
    
    	/*
    	    mymodel.IDSubjektTablica = model.IDSubjektTablica;
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    		
    	*/
    
    		#endregion
    	
    }
}
