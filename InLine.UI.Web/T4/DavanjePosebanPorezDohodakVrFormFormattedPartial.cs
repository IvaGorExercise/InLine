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
    
    
    public partial class DavanjePosebanPorezDohodakVrFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.DisplayName)]
       	public int IDDavanjePosebanPorezDohodakVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Naziv.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Kratica.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Kratica.DisplayName)]
       	public string Kratica { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.DisplayName)]
       	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.DatumDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNGodina.DisplayName)]
       	public Nullable<int> NNGodina { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNBroj.DisplayName)]
       	public Nullable<int> NNBroj { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNClanak.DisplayName)]
       	public Nullable<int> NNClanak { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNDatum.DisplayName)]
       	public Nullable<System.DateTime> NNDatum { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public DavanjePosebanPorezDohodakVrFormFormattedBase()
        { }
    	
    	public DavanjePosebanPorezDohodakVrFormFormattedBase(Model.Data.DavanjePosebanPorezDohodakVr formformated)
    	{
    	    this.IDDavanjePosebanPorezDohodakVr = formformated.IDDavanjePosebanPorezDohodakVr;
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
    	    mymodel.IDDavanjePosebanPorezDohodakVr = model.IDDavanjePosebanPorezDohodakVr;
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
