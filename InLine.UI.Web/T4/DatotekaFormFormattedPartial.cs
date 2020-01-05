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
    
    
    public partial class DatotekaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Datoteka.ID_Datoteka.Required)]
    	[DisplayName(AtributClass.Datoteka.ID_Datoteka.DisplayName)]
        	public long ID_Datoteka { get; set; }
    
        [Required(ErrorMessage = AtributClass.Datoteka.ID_Zapis.Required)]
    	[DisplayName(AtributClass.Datoteka.ID_Zapis.DisplayName)]
       	public long ID_Zapis { get; set; }
    
    	[DisplayName(AtributClass.Datoteka.ID_ZapisIzvor.DisplayName)]
       	public Nullable<long> ID_ZapisIzvor { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.Datoteka.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.Datoteka.Naziv.Required)]
    	[DisplayName(AtributClass.Datoteka.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
        [Required(ErrorMessage = AtributClass.Datoteka.Sadrzaj.Required)]
    	[DisplayName(AtributClass.Datoteka.Sadrzaj.DisplayName)]
       	public string Sadrzaj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.Datoteka.Datum.Required)]
    	[DisplayName(AtributClass.Datoteka.Datum.DisplayName)]
       	public System.DateTime Datum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DatotekaFormFormattedBase()
        { }
    	
    	public DatotekaFormFormattedBase(Model.Data.Datoteka formformated)
    	{
    	    this.ID_Datoteka = formformated.ID_Datoteka;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.ID_ZapisIzvor = formformated.ID_ZapisIzvor;
    	    this.Naziv = formformated.Naziv;
    	    this.Sadrzaj = formformated.Sadrzaj;
    	    this.Datum = formformated.Datum;
    	}
    
    	/*
    	    mymodel.ID_Datoteka = model.ID_Datoteka;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_ZapisIzvor = model.ID_ZapisIzvor;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Sadrzaj = model.Sadrzaj;
    	    mymodel.Datum = model.Datum;
    		
    	*/
    
    		#endregion
    	
    }
}
