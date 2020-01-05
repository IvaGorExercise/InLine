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
    
    
    public partial class OpcinaGrTipFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.ID_OpcinaGrTip.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.ID_OpcinaGrTip.DisplayName)]
        	public long ID_OpcinaGrTip { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.OpcinaGrTip.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.Oznaka.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrTip.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.Naziv.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OpcinaGrTip.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.NazivKr.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OpcinaGrTip.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.Kratica.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrTip.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrTip.Opis.Required)]
    	[DisplayName(AtributClass.OpcinaGrTip.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.OpcinaGrTip.StsOpcinaGrTip.StringLength)]
    	[DisplayName(AtributClass.OpcinaGrTip.StsOpcinaGrTip.DisplayName)]
       	public string StsOpcinaGrTip { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OpcinaGrTipFormFormattedBase()
        { }
    	
    	public OpcinaGrTipFormFormattedBase(Model.Data.OpcinaGrTip formformated)
    	{
    	    this.ID_OpcinaGrTip = formformated.ID_OpcinaGrTip;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Opis = formformated.Opis;
    	    this.StsOpcinaGrTip = formformated.StsOpcinaGrTip;
    	}
    
    	/*
    	    mymodel.ID_OpcinaGrTip = model.ID_OpcinaGrTip;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.StsOpcinaGrTip = model.StsOpcinaGrTip;
    		
    	*/
    
    		#endregion
    	
    }
}
