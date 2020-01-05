﻿using System;
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

    public partial class UgovorStanOtkupObrokPreplataDetaljFormFormatted
    {
        #region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_UgovorStanOtkupObrokPreplata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_UgovorStanOtkupObrokPreplata.DisplayName)]
        public long ID_UgovorStanOtkupObrokPreplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_UgovorStanOtkupObrok.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.IznosPreplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPreplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojUgovor.DisplayName)]
       	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.Broj.DisplayName)]
       	public Nullable<int> Broj { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplataDetalj.Aktivno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.Aktivno.DisplayName)]
       	public bool Aktivno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojAneks.DisplayName)]
       	public Nullable<int> BrojAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojStorno.DisplayName)]
       	public Nullable<int> BrojStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojObrok.DisplayName)]
       	public Nullable<int> BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.IznosPreplataValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPreplataValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojPreplata.DisplayName)]
       	public Nullable<int> BrojPreplata { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplataDetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplataDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokPreplataDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.GodinaObrokFormiranje.DisplayName)]
       	public Nullable<int> GodinaObrokFormiranje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.MjesecObrokFormiranje.DisplayName)]
       	public Nullable<int> MjesecObrokFormiranje { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_PlacanjeVr.DisplayName)]
       	public Nullable<long> ID_PlacanjeVr { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.BrojObveznica.DisplayName)]
       	public Nullable<int> BrojObveznica { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.NeZateznaKamata.DisplayName)]
       	public Nullable<bool> NeZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokPreplataDetalj.ID_Racun.DisplayName)]
       	public Nullable<long> ID_Racun { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupObrokPreplataDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupObrokPreplataDetaljFormFormatted(Model.Data.View.UgovorStanOtkupObrokPreplataDetalj formformated)
    	{
    	    this.ID_UgovorStanOtkupObrokPreplata = formformated.ID_UgovorStanOtkupObrokPreplata;
    	    this.ID_UgovorStanOtkupObrok = formformated.ID_UgovorStanOtkupObrok;
    	    this.Datum = formformated.Datum;
    	    this.IznosPreplata = formformated.IznosPreplata;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.Broj = formformated.Broj;
    	    this.Aktivno = formformated.Aktivno;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.IznosPreplataValuta = formformated.IznosPreplataValuta;
    	    this.BrojPreplata = formformated.BrojPreplata;
    	    this.IDValuta = formformated.IDValuta;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.GodinaObrokFormiranje = formformated.GodinaObrokFormiranje;
    	    this.MjesecObrokFormiranje = formformated.MjesecObrokFormiranje;
    	    this.ID_PlacanjeVr = formformated.ID_PlacanjeVr;
    	    this.BrojObveznica = formformated.BrojObveznica;
    	    this.NeZateznaKamata = formformated.NeZateznaKamata;
    	    this.ID_Racun = formformated.ID_Racun;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupObrokPreplata = model.ID_UgovorStanOtkupObrokPreplata;
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.Datum = model.Datum;
    	    mymodel.IznosPreplata = model.IznosPreplata;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Aktivno = model.Aktivno;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.IznosPreplataValuta = model.IznosPreplataValuta;
    	    mymodel.BrojPreplata = model.BrojPreplata;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.GodinaObrokFormiranje = model.GodinaObrokFormiranje;
    	    mymodel.MjesecObrokFormiranje = model.MjesecObrokFormiranje;
    	    mymodel.ID_PlacanjeVr = model.ID_PlacanjeVr;
    	    mymodel.BrojObveznica = model.BrojObveznica;
    	    mymodel.NeZateznaKamata = model.NeZateznaKamata;
    	    mymodel.ID_Racun = model.ID_Racun;
    		
    	*/
    
    		#endregion

    }
}