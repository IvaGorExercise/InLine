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
    
    
    public partial class PosebanPorezDohodakVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.ID_PosebanPorezDohodakVr.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.ID_PosebanPorezDohodakVr.DisplayName)]
        	public long ID_PosebanPorezDohodakVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.PosebanPorezDohodakVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.Oznaka.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.PosebanPorezDohodakVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.Naziv.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.PosebanPorezDohodakVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.NazivKr.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.PosebanPorezDohodakVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.Kratica.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PosebanPorezDohodakVr.DatumOd.Required)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.NNGodina.DisplayName)]
       	public Nullable<int> NNGodina { get; set; }
    
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.NNBroj.DisplayName)]
       	public Nullable<int> NNBroj { get; set; }
    
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.NNClanak.DisplayName)]
       	public Nullable<int> NNClanak { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.PosebanPorezDohodakVr.NNDatum.DisplayName)]
       	public Nullable<System.DateTime> NNDatum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public PosebanPorezDohodakVrFormFormattedBase()
        { }
    	
    	public PosebanPorezDohodakVrFormFormattedBase(Model.Data.PosebanPorezDohodakVr formformated)
    	{
    	    this.ID_PosebanPorezDohodakVr = formformated.ID_PosebanPorezDohodakVr;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Kratica = formformated.Kratica;
    	    this.DatumOd = formformated.DatumOd;
    	    this.DatumDo = formformated.DatumDo;
    	    this.NNGodina = formformated.NNGodina;
    	    this.NNBroj = formformated.NNBroj;
    	    this.NNClanak = formformated.NNClanak;
    	    this.NNDatum = formformated.NNDatum;
    	}
    
    	/*
    	    mymodel.ID_PosebanPorezDohodakVr = model.ID_PosebanPorezDohodakVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.NNGodina = model.NNGodina;
    	    mymodel.NNBroj = model.NNBroj;
    	    mymodel.NNClanak = model.NNClanak;
    	    mymodel.NNDatum = model.NNDatum;
    		
    	*/
    
    		#endregion
    	
    }
}
