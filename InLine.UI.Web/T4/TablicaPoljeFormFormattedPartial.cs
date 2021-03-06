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
    
    
    public partial class TablicaPoljeFormFormattedBase
    {
    	#region Properities
    
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPolje.TablicaShema.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPolje.TablicaShema.Required)]
    	[DisplayName(AtributClass.TablicaPolje.TablicaShema.DisplayName)]
       	public string TablicaShema { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPolje.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPolje.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.TablicaPolje.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.TablicaPolje.TablicaPoljeNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TablicaPolje.TablicaPoljeNaziv.Required)]
    	[DisplayName(AtributClass.TablicaPolje.TablicaPoljeNaziv.DisplayName)]
       	public string TablicaPoljeNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.TablicaPolje.Labela.StringLength)]
    	[DisplayName(AtributClass.TablicaPolje.Labela.DisplayName)]
       	public string Labela { get; set; }
    
    	
        [StringLength(2000, ErrorMessage = AtributClass.TablicaPolje.Opis.StringLength)]
    	[DisplayName(AtributClass.TablicaPolje.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public TablicaPoljeFormFormattedBase()
        { }
    	
    	public TablicaPoljeFormFormattedBase(Model.Data.TablicaPolje formformated)
    	{
    	    this.TablicaShema = formformated.TablicaShema;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	    this.TablicaPoljeNaziv = formformated.TablicaPoljeNaziv;
    	    this.Labela = formformated.Labela;
    	    this.Opis = formformated.Opis;
    	}
    
    	/*
    	    mymodel.TablicaShema = model.TablicaShema;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.TablicaPoljeNaziv = model.TablicaPoljeNaziv;
    	    mymodel.Labela = model.Labela;
    	    mymodel.Opis = model.Opis;
    		
    	*/
    
    		#endregion
    	
    }
}
