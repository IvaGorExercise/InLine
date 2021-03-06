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
    
    
    public partial class OpcinaGrOpcinaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_OpcinaGrOpcina.DisplayName)]
        	public long ID_OpcinaGrOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_OpcinaGr.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_OpcinaGr.DisplayName)]
       	public long ID_OpcinaGr { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.OpcinaGrOpcina.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Oznaka.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrOpcina.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Naziv.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.OpcinaGrOpcina.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.NazivKr.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.OpcinaGrOpcina.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Kratica.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaGrOpcina.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.OpcinaGrOpcina.Opis.Required)]
    	[DisplayName(AtributClass.OpcinaGrOpcina.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OpcinaGrOpcinaFormFormattedBase()
        { }
    	
    	public OpcinaGrOpcinaFormFormattedBase(Model.Data.OpcinaGrOpcina formformated)
    	{
    	    this.ID_OpcinaGrOpcina = formformated.ID_OpcinaGrOpcina;
    	    this.ID_OpcinaGr = formformated.ID_OpcinaGr;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.Opis = formformated.Opis;
    	}
    
    	/*
    	    mymodel.ID_OpcinaGrOpcina = model.ID_OpcinaGrOpcina;
    	    mymodel.ID_OpcinaGr = model.ID_OpcinaGr;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    	
    }
}
