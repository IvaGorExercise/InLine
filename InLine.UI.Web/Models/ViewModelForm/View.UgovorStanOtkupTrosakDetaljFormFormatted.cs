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


    public partial class UgovorStanOtkupTrosakDetaljFormFormatted
    {
        	#region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupTrosakDetalj.ID_UgovorStanOtkupTrosak.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.ID_UgovorStanOtkupTrosak.DisplayName)]
        	public long ID_UgovorStanOtkupTrosak { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.Iznos.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> Iznos { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.BrojUgovor.DisplayName)]
       	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.Godina.DisplayName)]
       	public Nullable<int> Godina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.BrojIzvod.DisplayName)]
       	public Nullable<int> BrojIzvod { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.BrojStavka.DisplayName)]
       	public Nullable<int> BrojStavka { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupTrosakDetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupTrosakDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupTrosakDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupTrosakDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupTrosakDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupTrosakDetaljFormFormatted(Model.Data.View.UgovorStanOtkupTrosakDetalj formformated)
    	{
    	    this.ID_UgovorStanOtkupTrosak = formformated.ID_UgovorStanOtkupTrosak;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.Datum = formformated.Datum;
    	    this.Iznos = formformated.Iznos;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.Godina = formformated.Godina;
    	    this.BrojIzvod = formformated.BrojIzvod;
    	    this.BrojStavka = formformated.BrojStavka;
    	    this.IDValuta = formformated.IDValuta;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupTrosak = model.ID_UgovorStanOtkupTrosak;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.Datum = model.Datum;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.Godina = model.Godina;
    	    mymodel.BrojIzvod = model.BrojIzvod;
    	    mymodel.BrojStavka = model.BrojStavka;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    		
    	*/
    
    		#endregion

    }
}
