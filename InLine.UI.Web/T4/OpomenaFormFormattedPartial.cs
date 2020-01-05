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
    
    
    public partial class OpomenaFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.Opomena.ID_Opomena.Required)]
    	[DisplayName(AtributClass.Opomena.ID_Opomena.DisplayName)]
        	public long ID_Opomena { get; set; }
    
    	[DisplayName(AtributClass.Opomena.ID_Zapis.DisplayName)]
       	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.Opomena.BrojOpomena.Required)]
    	[DisplayName(AtributClass.Opomena.BrojOpomena.DisplayName)]
       	public int BrojOpomena { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Opomena.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.Opomena.BrojNeplaceniObrokMin.DisplayName)]
       	public Nullable<int> BrojNeplaceniObrokMin { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Opomena.DatumDospijeceDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceDo { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Opomena.DatumDospijeceOd.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Opomena.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.Opomena.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.Opomena.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.Opomena.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.Opomena.OpomenaIznosMin.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> OpomenaIznosMin { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Opomena.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.Opomena.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.Opomena.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.Opomena.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public OpomenaFormFormattedBase()
        { }
    	
    	public OpomenaFormFormattedBase(Model.Data.Opomena formformated)
    	{
    	    this.ID_Opomena = formformated.ID_Opomena;
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.BrojOpomena = formformated.BrojOpomena;
    	    this.Datum = formformated.Datum;
    	    this.BrojNeplaceniObrokMin = formformated.BrojNeplaceniObrokMin;
    	    this.DatumDospijeceDo = formformated.DatumDospijeceDo;
    	    this.DatumDospijeceOd = formformated.DatumDospijeceOd;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.OpomenaIznosMin = formformated.OpomenaIznosMin;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	}
    
    	/*
    	    mymodel.ID_Opomena = model.ID_Opomena;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.BrojOpomena = model.BrojOpomena;
    	    mymodel.Datum = model.Datum;
    	    mymodel.BrojNeplaceniObrokMin = model.BrojNeplaceniObrokMin;
    	    mymodel.DatumDospijeceDo = model.DatumDospijeceDo;
    	    mymodel.DatumDospijeceOd = model.DatumDospijeceOd;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.OpomenaIznosMin = model.OpomenaIznosMin;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    		
    	*/
    
    		#endregion
    	
    }
}
