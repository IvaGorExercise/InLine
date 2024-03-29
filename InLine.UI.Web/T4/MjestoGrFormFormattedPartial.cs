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
    
    
    public partial class MjestoGrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.MjestoGr.ID_MjestoGr.Required)]
    	[DisplayName(AtributClass.MjestoGr.ID_MjestoGr.DisplayName)]
        	public long ID_MjestoGr { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoGr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGr.Naziv.Required)]
    	[DisplayName(AtributClass.MjestoGr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjestoGr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGr.Oznaka.Required)]
    	[DisplayName(AtributClass.MjestoGr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MjestoGr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGr.NazivKr.Required)]
    	[DisplayName(AtributClass.MjestoGr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MjestoGr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGr.Kratica.Required)]
    	[DisplayName(AtributClass.MjestoGr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoGr.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoGr.Opis.Required)]
    	[DisplayName(AtributClass.MjestoGr.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.MjestoGr.ID_MjestoGrTip.DisplayName)]
       	public Nullable<long> ID_MjestoGrTip { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public MjestoGrFormFormattedBase()
        { }
    	
    	public MjestoGrFormFormattedBase(Model.Data.MjestoGr formformated)
    	{
    	    this.ID_MjestoGr = formformated.ID_MjestoGr;
    	    this.Naziv = formformated.Naziv;
    	    this.Oznaka = formformated.Oznaka;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Opis = formformated.Opis;
    	    this.ID_MjestoGrTip = formformated.ID_MjestoGrTip;
    	}
    
    	/*
    	    mymodel.ID_MjestoGr = model.ID_MjestoGr;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.ID_MjestoGrTip = model.ID_MjestoGrTip;
    		
    	*/
    
    		#endregion
    	
    }
}
