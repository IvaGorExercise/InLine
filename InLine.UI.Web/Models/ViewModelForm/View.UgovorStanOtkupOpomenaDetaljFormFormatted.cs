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


namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{


    public partial class UgovorStanOtkupOpomenaDetaljFormFormatted
    {
       	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkupOpomena.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkupOpomena.DisplayName)]
        	public long ID_UgovorStanOtkupOpomena { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_Opomena.DisplayName)]
       	public Nullable<long> ID_Opomena { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.BrojOpomena.DisplayName)]
       	public Nullable<int> BrojOpomena { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.BrojUgovor.DisplayName)]
       	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.IznosDug.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosDug { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.IznosZateznaKamataDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumInsertUSOO.DisplayName)]
       	public Nullable<System.DateTime> DatumInsertUSOO { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaInsertUSOO.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaInsertUSOO.DisplayName)]
       	public string OsobaInsertUSOO { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumUpdateUSOO.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdateUSOO { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaUpdateUSOO.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaUpdateUSOO.DisplayName)]
       	public string OsobaUpdateUSOO { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_OsobaInsertUSOO.DisplayName)]
       	public Nullable<long> ID_OsobaInsertUSOO { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_OsobaUpdateUSOO.DisplayName)]
       	public Nullable<long> ID_OsobaUpdateUSOO { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.Ispis.DisplayName)]
       	public Nullable<bool> Ispis { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.BrojNeplaceniObrokMin.DisplayName)]
       	public Nullable<int> BrojNeplaceniObrokMin { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumDospijeceDo.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceDo { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumDospijeceOd.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceOd { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.OpomenaIznosMin.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> OpomenaIznosMin { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupOpomenaDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupOpomenaDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupOpomenaDetaljFormFormatted(Model.Data.View.UgovorStanOtkupOpomenaDetalj formformated)
    	{
    	    this.ID_UgovorStanOtkupOpomena = formformated.ID_UgovorStanOtkupOpomena;
    	    this.ID_Opomena = formformated.ID_Opomena;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.BrojOpomena = formformated.BrojOpomena;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.IznosDug = formformated.IznosDug;
    	    this.IznosZateznaKamata = formformated.IznosZateznaKamata;
    	    this.IznosZateznaKamataDugOstatak = formformated.IznosZateznaKamataDugOstatak;
    	    this.DatumInsertUSOO = formformated.DatumInsertUSOO;
    	    this.OsobaInsertUSOO = formformated.OsobaInsertUSOO;
    	    this.DatumUpdateUSOO = formformated.DatumUpdateUSOO;
    	    this.OsobaUpdateUSOO = formformated.OsobaUpdateUSOO;
    	    this.ID_OsobaInsertUSOO = formformated.ID_OsobaInsertUSOO;
    	    this.ID_OsobaUpdateUSOO = formformated.ID_OsobaUpdateUSOO;
    	    this.Ispis = formformated.Ispis;
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
    	    mymodel.ID_UgovorStanOtkupOpomena = model.ID_UgovorStanOtkupOpomena;
    	    mymodel.ID_Opomena = model.ID_Opomena;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojOpomena = model.BrojOpomena;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.IznosDug = model.IznosDug;
    	    mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
    	    mymodel.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
    	    mymodel.DatumInsertUSOO = model.DatumInsertUSOO;
    	    mymodel.OsobaInsertUSOO = model.OsobaInsertUSOO;
    	    mymodel.DatumUpdateUSOO = model.DatumUpdateUSOO;
    	    mymodel.OsobaUpdateUSOO = model.OsobaUpdateUSOO;
    	    mymodel.ID_OsobaInsertUSOO = model.ID_OsobaInsertUSOO;
    	    mymodel.ID_OsobaUpdateUSOO = model.ID_OsobaUpdateUSOO;
    	    mymodel.Ispis = model.Ispis;
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
