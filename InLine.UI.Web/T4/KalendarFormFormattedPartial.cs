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
    
    
    public partial class KalendarFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Kalendar.IDDatum.Required)]
    	[DisplayName(AtributClass.Kalendar.IDDatum.DisplayName)]
       	public int IDDatum { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.RBR.DisplayName)]
       	public Nullable<int> RBR { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Kalendar.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.Godina.DisplayName)]
       	public Nullable<int> Godina { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.Mjesec.DisplayName)]
       	public Nullable<int> Mjesec { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.Dan.DisplayName)]
       	public Nullable<int> Dan { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.Tromjesecje.DisplayName)]
       	public Nullable<int> Tromjesecje { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.TjedanUGodini.DisplayName)]
       	public Nullable<int> TjedanUGodini { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.DanUGodini.DisplayName)]
       	public Nullable<int> DanUGodini { get; set; }
    
    	[DisplayName(AtributClass.Kalendar.DanUTjednu.DisplayName)]
       	public Nullable<int> DanUTjednu { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public KalendarFormFormattedBase()
        { }
    	
    	public KalendarFormFormattedBase(Model.Data.Kalendar formformated)
    	{
    	    this.IDDatum = formformated.IDDatum;
    	    this.RBR = formformated.RBR;
    	    this.Datum = formformated.Datum;
    	    this.Godina = formformated.Godina;
    	    this.Mjesec = formformated.Mjesec;
    	    this.Dan = formformated.Dan;
    	    this.Tromjesecje = formformated.Tromjesecje;
    	    this.TjedanUGodini = formformated.TjedanUGodini;
    	    this.DanUGodini = formformated.DanUGodini;
    	    this.DanUTjednu = formformated.DanUTjednu;
    	}
    
    	/*
    	    mymodel.IDDatum = model.IDDatum;
    	    mymodel.RBR = model.RBR;
    	    mymodel.Datum = model.Datum;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.Dan = model.Dan;
    	    mymodel.Tromjesecje = model.Tromjesecje;
    	    mymodel.TjedanUGodini = model.TjedanUGodini;
    	    mymodel.DanUGodini = model.DanUGodini;
    	    mymodel.DanUTjednu = model.DanUTjednu;
    		
    	*/
    
    		#endregion
    	
    }
}
