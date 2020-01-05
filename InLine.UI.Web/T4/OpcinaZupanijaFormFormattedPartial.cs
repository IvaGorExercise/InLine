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
    
    
    public partial class OpcinaZupanijaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.ID_OpcinaZupanija.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.ID_OpcinaZupanija.DisplayName)]
        	public long ID_OpcinaZupanija { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.ID_Opcina.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.ID_Opcina.DisplayName)]
       	public long ID_Opcina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.DatOd.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.DatOd.DisplayName)]
       	public System.DateTime DatOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.DatDo.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.DatDo.DisplayName)]
       	public System.DateTime DatDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.AktivU.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.AktivU.DisplayName)]
       	public bool AktivU { get; set; }
    
        [Required(ErrorMessage = AtributClass.OpcinaZupanija.ID_Zupanija.Required)]
    	[DisplayName(AtributClass.OpcinaZupanija.ID_Zupanija.DisplayName)]
       	public long ID_Zupanija { get; set; }
    
    	[DisplayName(AtributClass.OpcinaZupanija.ID_OpcinaTip.DisplayName)]
       	public Nullable<long> ID_OpcinaTip { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaZupanija.Opis.StringLength)]
    	[DisplayName(AtributClass.OpcinaZupanija.Opis.DisplayName)]
       	public string Opis { get; set; }
    
    	[DisplayName(AtributClass.OpcinaZupanija.GrbSlika.DisplayName)]
       	public byte[] GrbSlika { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaZupanija.PathGrb.StringLength)]
    	[DisplayName(AtributClass.OpcinaZupanija.PathGrb.DisplayName)]
       	public string PathGrb { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaZupanija.SjedOpcina.StringLength)]
    	[DisplayName(AtributClass.OpcinaZupanija.SjedOpcina.DisplayName)]
       	public string SjedOpcina { get; set; }
    
    	[DisplayName(AtributClass.OpcinaZupanija.ID_MjestoPosta.DisplayName)]
       	public Nullable<long> ID_MjestoPosta { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaZupanija.NazivOpcina.StringLength)]
    	[DisplayName(AtributClass.OpcinaZupanija.NazivOpcina.DisplayName)]
       	public string NazivOpcina { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.OpcinaZupanija.TIP.StringLength)]
    	[DisplayName(AtributClass.OpcinaZupanija.TIP.DisplayName)]
       	public string TIP { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OpcinaZupanijaFormFormattedBase()
        { }
    	
    	public OpcinaZupanijaFormFormattedBase(Model.Data.OpcinaZupanija formformated)
    	{
    	    this.ID_OpcinaZupanija = formformated.ID_OpcinaZupanija;
    	    this.ID_Opcina = formformated.ID_Opcina;
    	    this.DatOd = formformated.DatOd;
    	    this.DatDo = formformated.DatDo;
    	    this.AktivU = formformated.AktivU;
    	    this.ID_Zupanija = formformated.ID_Zupanija;
    	    this.ID_OpcinaTip = formformated.ID_OpcinaTip;
    	    this.Opis = formformated.Opis;
    	    this.GrbSlika = formformated.GrbSlika;
    	    this.PathGrb = formformated.PathGrb;
    	    this.SjedOpcina = formformated.SjedOpcina;
    	    this.ID_MjestoPosta = formformated.ID_MjestoPosta;
    	    this.NazivOpcina = formformated.NazivOpcina;
    	    this.TIP = formformated.TIP;
    	}
    
    	/*
    	    mymodel.ID_OpcinaZupanija = model.ID_OpcinaZupanija;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.DatOd = model.DatOd;
    	    mymodel.DatDo = model.DatDo;
    	    mymodel.AktivU = model.AktivU;
    	    mymodel.ID_Zupanija = model.ID_Zupanija;
    	    mymodel.ID_OpcinaTip = model.ID_OpcinaTip;
    	    mymodel.Opis = model.Opis;
    	    mymodel.GrbSlika = model.GrbSlika;
    	    mymodel.PathGrb = model.PathGrb;
    	    mymodel.SjedOpcina = model.SjedOpcina;
    	    mymodel.ID_MjestoPosta = model.ID_MjestoPosta;
    	    mymodel.NazivOpcina = model.NazivOpcina;
    	    mymodel.TIP = model.TIP;
    		
    	*/
    
    		#endregion
    	
    }
}
