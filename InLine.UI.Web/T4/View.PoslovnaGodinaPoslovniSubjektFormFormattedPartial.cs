//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
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
    
    
    public partial class PoslovnaGodinaPoslovniSubjektFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina.DisplayName)]
       	public long ID_PoslovnaGodina { get; set; }
    
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_PoslovniSubjekt.DisplayName)]
       	public Nullable<long> ID_PoslovniSubjekt { get; set; }
    
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.StringLength)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Godina.DisplayName)]
       	public int Godina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.DatumDo.DisplayName)]
       	public System.DateTime DatumDo { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.StringLength)]
    	[DisplayName(AtributClass.PoslovnaGodinaPoslovniSubjekt.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PoslovnaGodinaPoslovniSubjektFormFormattedBase()
        { }
    	
    	public PoslovnaGodinaPoslovniSubjektFormFormattedBase(Model.Data.View.PoslovnaGodinaPoslovniSubjekt formformated)
    	{
    	    this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
    	    this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.Naziv = formformated.Naziv;
    	    this.Godina = formformated.Godina;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.IDValuta = formformated.IDValuta;
    	    this.Oznaka = formformated.Oznaka;
    	}
    
    	/*
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.Godina = model.Godina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.Oznaka = model.Oznaka;
    		
    	*/
    
    		#endregion
    	
    }
}
