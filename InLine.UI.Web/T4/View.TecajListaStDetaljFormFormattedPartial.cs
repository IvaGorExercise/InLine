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
    
    
    public partial class TecajListaStDetaljFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.ID_TecajListaSt.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajListaSt.DisplayName)]
        	public long ID_TecajListaSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.ID_TecajLista.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajLista.DisplayName)]
       	public long ID_TecajLista { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.TecajListaStDetalj.IDDrzavaIz.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.IDDrzavaIz.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.IDDrzavaIz.DisplayName)]
       	public string IDDrzavaIz { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.TecajListaStDetalj.IDDrzavaU.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.IDDrzavaU.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.IDDrzavaU.DisplayName)]
       	public string IDDrzavaU { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TecajListaStDetalj.IDValutaIz.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.IDValutaIz.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.IDValutaIz.DisplayName)]
       	public string IDValutaIz { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.TecajListaStDetalj.IDValutaU.StringLength)]
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.IDValutaU.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.IDValutaU.DisplayName)]
       	public string IDValutaU { get; set; }
    
        [Required(ErrorMessage = AtributClass.TecajListaStDetalj.BrojJedinica.Required)]
    	[DisplayName(AtributClass.TecajListaStDetalj.BrojJedinica.DisplayName)]
       	public int BrojJedinica { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajSD.DisplayName)]
       	public Nullable<long> ID_TecajSD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajVrSD.DisplayName)]
       	public Nullable<long> ID_TecajVrSD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.TecajSD.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajSD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajKD.DisplayName)]
       	public Nullable<long> ID_TecajKD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajVrKD.DisplayName)]
       	public Nullable<long> ID_TecajVrKD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.TecajKD.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajKD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajPD.DisplayName)]
       	public Nullable<long> ID_TecajPD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajVrPD.DisplayName)]
       	public Nullable<long> ID_TecajVrPD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.TecajPD.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajPD { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajKE.DisplayName)]
       	public Nullable<long> ID_TecajKE { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajVrKE.DisplayName)]
       	public Nullable<long> ID_TecajVrKE { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.TecajKE.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajKE { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajPE.DisplayName)]
       	public Nullable<long> ID_TecajPE { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.ID_TecajVrPE.DisplayName)]
       	public Nullable<long> ID_TecajVrPE { get; set; }
    
    	[DisplayName(AtributClass.TecajListaStDetalj.TecajPE.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajPE { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public TecajListaStDetaljFormFormattedBase()
        { }
    	
    	public TecajListaStDetaljFormFormattedBase(Model.Data.View.TecajListaStDetalj formformated)
    	{
    	    this.ID_TecajListaSt = formformated.ID_TecajListaSt;
    	    this.ID_TecajLista = formformated.ID_TecajLista;
    	    this.IDDrzavaIz = formformated.IDDrzavaIz;
    	    this.IDDrzavaU = formformated.IDDrzavaU;
    	    this.IDValutaIz = formformated.IDValutaIz;
    	    this.IDValutaU = formformated.IDValutaU;
    	    this.BrojJedinica = formformated.BrojJedinica;
    	    this.ID_TecajSD = formformated.ID_TecajSD;
    	    this.ID_TecajVrSD = formformated.ID_TecajVrSD;
    	    this.TecajSD = formformated.TecajSD;
    	    this.ID_TecajKD = formformated.ID_TecajKD;
    	    this.ID_TecajVrKD = formformated.ID_TecajVrKD;
    	    this.TecajKD = formformated.TecajKD;
    	    this.ID_TecajPD = formformated.ID_TecajPD;
    	    this.ID_TecajVrPD = formformated.ID_TecajVrPD;
    	    this.TecajPD = formformated.TecajPD;
    	    this.ID_TecajKE = formformated.ID_TecajKE;
    	    this.ID_TecajVrKE = formformated.ID_TecajVrKE;
    	    this.TecajKE = formformated.TecajKE;
    	    this.ID_TecajPE = formformated.ID_TecajPE;
    	    this.ID_TecajVrPE = formformated.ID_TecajVrPE;
    	    this.TecajPE = formformated.TecajPE;
    	}
    
    	/*
    	    mymodel.ID_TecajListaSt = model.ID_TecajListaSt;
    	    mymodel.ID_TecajLista = model.ID_TecajLista;
    	    mymodel.IDDrzavaIz = model.IDDrzavaIz;
    	    mymodel.IDDrzavaU = model.IDDrzavaU;
    	    mymodel.IDValutaIz = model.IDValutaIz;
    	    mymodel.IDValutaU = model.IDValutaU;
    	    mymodel.BrojJedinica = model.BrojJedinica;
    	    mymodel.ID_TecajSD = model.ID_TecajSD;
    	    mymodel.ID_TecajVrSD = model.ID_TecajVrSD;
    	    mymodel.TecajSD = model.TecajSD;
    	    mymodel.ID_TecajKD = model.ID_TecajKD;
    	    mymodel.ID_TecajVrKD = model.ID_TecajVrKD;
    	    mymodel.TecajKD = model.TecajKD;
    	    mymodel.ID_TecajPD = model.ID_TecajPD;
    	    mymodel.ID_TecajVrPD = model.ID_TecajVrPD;
    	    mymodel.TecajPD = model.TecajPD;
    	    mymodel.ID_TecajKE = model.ID_TecajKE;
    	    mymodel.ID_TecajVrKE = model.ID_TecajVrKE;
    	    mymodel.TecajKE = model.TecajKE;
    	    mymodel.ID_TecajPE = model.ID_TecajPE;
    	    mymodel.ID_TecajVrPE = model.ID_TecajVrPE;
    	    mymodel.TecajPE = model.TecajPE;
    		
    	*/
    
    		#endregion
    	
    }
}
