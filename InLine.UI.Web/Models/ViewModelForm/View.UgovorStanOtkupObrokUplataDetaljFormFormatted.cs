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

    public partial class UgovorStanOtkupObrokUplataDetaljFormFormatted
    {
       #region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_UgovorStanOtkupObrokUplata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_UgovorStanOtkupObrokUplata.DisplayName)]
       	public long ID_UgovorStanOtkupObrokUplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_UgovorStanOtkupObrok.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosZateznaKamataUplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamataUplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosValutaUgovor.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosValutaUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosZateznaKamataPrije.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamataPrije { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosTecajnaRazlika.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosTecajnaRazlika { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKredit { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKreditRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamataRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKreditMoratorij.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKreditMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKamataMoratorij.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamataMoratorij { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKreditMoratorijRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKreditMoratorijRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosKamataMoratorijRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosKamataMoratorijRevalorizacija { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosJednokratno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosUcesce { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosPreplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosPreplata { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.IDValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.DokumentGrupa.DisplayName)]
       	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.DokumentVrsta.DisplayName)]
       	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.OsnovicaZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> OsnovicaZateznaKamata { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.DatumZateznaKamata.DisplayName)]
       	public Nullable<System.DateTime> DatumZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosObrokDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosObrokDugOstatak { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.IznosZateznaKamataDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojUgovor.DisplayName)]
       	public Nullable<int> BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojAneks.DisplayName)]
       	public Nullable<int> BrojAneks { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojStorno.DisplayName)]
       	public Nullable<int> BrojStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojObrok.DisplayName)]
       	public Nullable<int> BrojObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_UgovorStanOtkupObrokZateznaKamata.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupObrokZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojObrokZateznaKamata.DisplayName)]
       	public Nullable<int> BrojObrokZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.BrojPreplata.DisplayName)]
       	public Nullable<int> BrojPreplata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_Racun.DisplayName)]
       	public Nullable<long> ID_Racun { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_PlacanjeVr.DisplayName)]
       	public Nullable<long> ID_PlacanjeVr { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.NeZateznaKamata.DisplayName)]
       	public Nullable<bool> NeZateznaKamata { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.PlacanjeVrOznaka.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.PlacanjeVrOznaka.DisplayName)]
       	public string PlacanjeVrOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplataDetalj.PlacanjeVrNaziv.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.PlacanjeVrNaziv.DisplayName)]
       	public string PlacanjeVrNaziv { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrokUplataDetalj.GodinaUplata.DisplayName)]
       	public Nullable<int> GodinaUplata { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupObrokUplataDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupObrokUplataDetaljFormFormatted(Model.Data.View.UgovorStanOtkupObrokUplataDetalj formformated)
    	{
    	    this.ID_UgovorStanOtkupObrokUplata = formformated.ID_UgovorStanOtkupObrokUplata;
    	    this.ID_UgovorStanOtkupObrok = formformated.ID_UgovorStanOtkupObrok;
    	    this.Datum = formformated.Datum;
    	    this.IznosZateznaKamataUplata = formformated.IznosZateznaKamataUplata;
    	    this.IznosValuta = formformated.IznosValuta;
    	    this.IznosValutaUgovor = formformated.IznosValutaUgovor;
    	    this.IznosZateznaKamataPrije = formformated.IznosZateznaKamataPrije;
    	    this.IznosTecajnaRazlika = formformated.IznosTecajnaRazlika;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKreditMoratorij = formformated.IznosKreditMoratorij;
    	    this.IznosKamataMoratorij = formformated.IznosKamataMoratorij;
    	    this.IznosKreditMoratorijRevalorizacija = formformated.IznosKreditMoratorijRevalorizacija;
    	    this.IznosKamataMoratorijRevalorizacija = formformated.IznosKamataMoratorijRevalorizacija;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosPreplata = formformated.IznosPreplata;
    	    this.IDValuta = formformated.IDValuta;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.DokumentGrupa = formformated.DokumentGrupa;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.DokumentVrsta = formformated.DokumentVrsta;
    	    this.OsnovicaZateznaKamata = formformated.OsnovicaZateznaKamata;
    	    this.DatumZateznaKamata = formformated.DatumZateznaKamata;
    	    this.IznosZateznaKamata = formformated.IznosZateznaKamata;
    	    this.IznosObrokDugOstatak = formformated.IznosObrokDugOstatak;
    	    this.IznosZateznaKamataDugOstatak = formformated.IznosZateznaKamataDugOstatak;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.ID_UgovorStanOtkupObrokZateznaKamata = formformated.ID_UgovorStanOtkupObrokZateznaKamata;
    	    this.BrojObrokZateznaKamata = formformated.BrojObrokZateznaKamata;
    	    this.BrojPreplata = formformated.BrojPreplata;
    	    this.ID_Racun = formformated.ID_Racun;
    	    this.ID_PlacanjeVr = formformated.ID_PlacanjeVr;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.NeZateznaKamata = formformated.NeZateznaKamata;
    	    this.PlacanjeVrOznaka = formformated.PlacanjeVrOznaka;
    	    this.PlacanjeVrNaziv = formformated.PlacanjeVrNaziv;
    	    this.GodinaUplata = formformated.GodinaUplata;
    	}
    
    	/*
    	    mymodel.ID_UgovorStanOtkupObrokUplata = model.ID_UgovorStanOtkupObrokUplata;
    	    mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
    	    mymodel.Datum = model.Datum;
    	    mymodel.IznosZateznaKamataUplata = model.IznosZateznaKamataUplata;
    	    mymodel.IznosValuta = model.IznosValuta;
    	    mymodel.IznosValutaUgovor = model.IznosValutaUgovor;
    	    mymodel.IznosZateznaKamataPrije = model.IznosZateznaKamataPrije;
    	    mymodel.IznosTecajnaRazlika = model.IznosTecajnaRazlika;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKreditMoratorij = model.IznosKreditMoratorij;
    	    mymodel.IznosKamataMoratorij = model.IznosKamataMoratorij;
    	    mymodel.IznosKreditMoratorijRevalorizacija = model.IznosKreditMoratorijRevalorizacija;
    	    mymodel.IznosKamataMoratorijRevalorizacija = model.IznosKamataMoratorijRevalorizacija;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosPreplata = model.IznosPreplata;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.OsnovicaZateznaKamata = model.OsnovicaZateznaKamata;
    	    mymodel.DatumZateznaKamata = model.DatumZateznaKamata;
    	    mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
    	    mymodel.IznosObrokDugOstatak = model.IznosObrokDugOstatak;
    	    mymodel.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.ID_UgovorStanOtkupObrokZateznaKamata = model.ID_UgovorStanOtkupObrokZateznaKamata;
    	    mymodel.BrojObrokZateznaKamata = model.BrojObrokZateznaKamata;
    	    mymodel.BrojPreplata = model.BrojPreplata;
    	    mymodel.ID_Racun = model.ID_Racun;
    	    mymodel.ID_PlacanjeVr = model.ID_PlacanjeVr;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.NeZateznaKamata = model.NeZateznaKamata;
    	    mymodel.PlacanjeVrOznaka = model.PlacanjeVrOznaka;
    	    mymodel.PlacanjeVrNaziv = model.PlacanjeVrNaziv;
    	    mymodel.GodinaUplata = model.GodinaUplata;
    		
    	*/
    
    		#endregion

    }
}