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
    
    
    public partial class OsobaBoravisteFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_OsobaBoraviste.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_OsobaBoraviste.DisplayName)]
        	public long ID_OsobaBoraviste { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_Osoba.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OsobaBoraviste.DatumOd.Required)]
    	[DisplayName(AtributClass.OsobaBoraviste.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.OsobaBoraviste.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OsobaBoravisteFormFormattedBase()
        { }
    	
    	public OsobaBoravisteFormFormattedBase(Model.Data.OsobaBoraviste formformated)
    	{
    	    this.ID_OsobaBoraviste = formformated.ID_OsobaBoraviste;
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	}
    
    	/*
    	    mymodel.ID_OsobaBoraviste = model.ID_OsobaBoraviste;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    		
    	*/
    
    		#endregion
    	
    }
}
