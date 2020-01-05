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
    
    
    public partial class HUBImportFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUBImport.ID_HUBImport.Required)]
    	[DisplayName(AtributClass.HUBImport.ID_HUBImport.DisplayName)]
        	public long ID_HUBImport { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.Godina.Required)]
    	[DisplayName(AtributClass.HUBImport.Godina.DisplayName)]
       	public int Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.Mjesec.Required)]
    	[DisplayName(AtributClass.HUBImport.Mjesec.DisplayName)]
       	public int Mjesec { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.HUBImport.ImportStatus.StringLength)]
        [Required(ErrorMessage = AtributClass.HUBImport.ImportStatus.Required)]
    	[DisplayName(AtributClass.HUBImport.ImportStatus.DisplayName)]
       	public string ImportStatus { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.RBImport.Required)]
    	[DisplayName(AtributClass.HUBImport.RBImport.DisplayName)]
       	public int RBImport { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.DokumentUpload.Required)]
    	[DisplayName(AtributClass.HUBImport.DokumentUpload.DisplayName)]
       	public bool DokumentUpload { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.RBDokumentUpload.Required)]
    	[DisplayName(AtributClass.HUBImport.RBDokumentUpload.DisplayName)]
       	public int RBDokumentUpload { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.Pdf.Required)]
    	[DisplayName(AtributClass.HUBImport.Pdf.DisplayName)]
       	public bool Pdf { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUBImport.RBPdf.Required)]
    	[DisplayName(AtributClass.HUBImport.RBPdf.DisplayName)]
       	public int RBPdf { get; set; }
    
    	[DisplayName(AtributClass.HUBImport.ErrorNumber.DisplayName)]
       	public Nullable<int> ErrorNumber { get; set; }
    
    	[DisplayName(AtributClass.HUBImport.ErrorSeverity.DisplayName)]
       	public Nullable<int> ErrorSeverity { get; set; }
    
    	[DisplayName(AtributClass.HUBImport.ErrorState.DisplayName)]
       	public Nullable<int> ErrorState { get; set; }
    
    	
        [StringLength(126, ErrorMessage = AtributClass.HUBImport.ErrorProcedure.StringLength)]
    	[DisplayName(AtributClass.HUBImport.ErrorProcedure.DisplayName)]
       	public string ErrorProcedure { get; set; }
    
    	[DisplayName(AtributClass.HUBImport.ErrorLine.DisplayName)]
       	public Nullable<int> ErrorLine { get; set; }
    
    	
        [StringLength(2048, ErrorMessage = AtributClass.HUBImport.ErrorMessage.StringLength)]
    	[DisplayName(AtributClass.HUBImport.ErrorMessage.DisplayName)]
       	public string ErrorMessage { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUBImportFormFormattedBase()
        { }
    	
    	public HUBImportFormFormattedBase(Model.Data.HUBImport formformated)
    	{
    	    this.ID_HUBImport = formformated.ID_HUBImport;
    	    this.Godina = formformated.Godina;
    	    this.Mjesec = formformated.Mjesec;
    	    this.ImportStatus = formformated.ImportStatus;
    	    this.RBImport = formformated.RBImport;
    	    this.DokumentUpload = formformated.DokumentUpload;
    	    this.RBDokumentUpload = formformated.RBDokumentUpload;
    	    this.Pdf = formformated.Pdf;
    	    this.RBPdf = formformated.RBPdf;
    	    this.ErrorNumber = formformated.ErrorNumber;
    	    this.ErrorSeverity = formformated.ErrorSeverity;
    	    this.ErrorState = formformated.ErrorState;
    	    this.ErrorProcedure = formformated.ErrorProcedure;
    	    this.ErrorLine = formformated.ErrorLine;
    	    this.ErrorMessage = formformated.ErrorMessage;
    	}
    
    	/*
    	    mymodel.ID_HUBImport = model.ID_HUBImport;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.ImportStatus = model.ImportStatus;
    	    mymodel.RBImport = model.RBImport;
    	    mymodel.DokumentUpload = model.DokumentUpload;
    	    mymodel.RBDokumentUpload = model.RBDokumentUpload;
    	    mymodel.Pdf = model.Pdf;
    	    mymodel.RBPdf = model.RBPdf;
    	    mymodel.ErrorNumber = model.ErrorNumber;
    	    mymodel.ErrorSeverity = model.ErrorSeverity;
    	    mymodel.ErrorState = model.ErrorState;
    	    mymodel.ErrorProcedure = model.ErrorProcedure;
    	    mymodel.ErrorLine = model.ErrorLine;
    	    mymodel.ErrorMessage = model.ErrorMessage;
    		
    	*/
    
    		#endregion
    	
    }
}