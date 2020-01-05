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
    
    
    public partial class ZbrojniNalog2013AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.ID_ZbrojniNalog2013A.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.ID_ZbrojniNalog2013A.DisplayName)]
        	public long ID_ZbrojniNalog2013A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.ID_ZbrojniNalog.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.ID_ZbrojniNalog.DisplayName)]
       	public long ID_ZbrojniNalog { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalog2013A.IDHUBDokumentIzvor2013A.DisplayName)]
       	public Nullable<int> IDHUBDokumentIzvor2013A { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.IDHUBNalogVrsta2013A.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.IDHUBNalogVrsta2013A.DisplayName)]
       	public int IDHUBNalogVrsta2013A { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZbrojniNalog2013A.IDValutaPlacanje.StringLength)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.IDValutaPlacanje.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.IDValutaPlacanje.DisplayName)]
       	public string IDValutaPlacanje { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZbrojniNalog2013A.IDValutaNaknada.StringLength)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.IDValutaNaknada.DisplayName)]
       	public string IDValutaNaknada { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.DatumIzvrsenja.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.DatumIzvrsenja.DisplayName)]
       	public System.DateTime DatumIzvrsenja { get; set; }
    
    	
        [StringLength(21, ErrorMessage = AtributClass.ZbrojniNalog2013A.RacunPlatitelj.StringLength)]
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.RacunPlatitelj.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.RacunPlatitelj.DisplayName)]
       	public string RacunPlatitelj { get; set; }
    
    	
        [StringLength(21, ErrorMessage = AtributClass.ZbrojniNalog2013A.RacunNaknada.StringLength)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.RacunNaknada.DisplayName)]
       	public string RacunNaknada { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZbrojniNalog2013A.Predan.Required)]
    	[DisplayName(AtributClass.ZbrojniNalog2013A.Predan.DisplayName)]
       	public bool Predan { get; set; }
    
    	[DisplayName(AtributClass.ZbrojniNalog2013A.Izvrsen.DisplayName)]
       	public Nullable<bool> Izvrsen { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZbrojniNalog2013AFormFormattedBase()
        { }
    	
    	public ZbrojniNalog2013AFormFormattedBase(Model.Data.ZbrojniNalog2013A formformated)
    	{
    	    this.ID_ZbrojniNalog2013A = formformated.ID_ZbrojniNalog2013A;
    	    this.ID_ZbrojniNalog = formformated.ID_ZbrojniNalog;
    	    this.IDHUBDokumentIzvor2013A = formformated.IDHUBDokumentIzvor2013A;
    	    this.IDHUBNalogVrsta2013A = formformated.IDHUBNalogVrsta2013A;
    	    this.IDValutaPlacanje = formformated.IDValutaPlacanje;
    	    this.IDValutaNaknada = formformated.IDValutaNaknada;
    	    this.DatumIzvrsenja = formformated.DatumIzvrsenja;
    	    this.RacunPlatitelj = formformated.RacunPlatitelj;
    	    this.RacunNaknada = formformated.RacunNaknada;
    	    this.Predan = formformated.Predan;
    	    this.Izvrsen = formformated.Izvrsen;
    	}
    
    	/*
    	    mymodel.ID_ZbrojniNalog2013A = model.ID_ZbrojniNalog2013A;
    	    mymodel.ID_ZbrojniNalog = model.ID_ZbrojniNalog;
    	    mymodel.IDHUBDokumentIzvor2013A = model.IDHUBDokumentIzvor2013A;
    	    mymodel.IDHUBNalogVrsta2013A = model.IDHUBNalogVrsta2013A;
    	    mymodel.IDValutaPlacanje = model.IDValutaPlacanje;
    	    mymodel.IDValutaNaknada = model.IDValutaNaknada;
    	    mymodel.DatumIzvrsenja = model.DatumIzvrsenja;
    	    mymodel.RacunPlatitelj = model.RacunPlatitelj;
    	    mymodel.RacunNaknada = model.RacunNaknada;
    	    mymodel.Predan = model.Predan;
    	    mymodel.Izvrsen = model.Izvrsen;
    		
    	*/
    
    		#endregion
    	
    }
}
