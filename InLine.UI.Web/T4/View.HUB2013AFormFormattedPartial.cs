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
    
    
    public partial class HUB2013AFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.HUB2013A.ID_HUB2013A.Required)]
    	[DisplayName(AtributClass.HUB2013A.ID_HUB2013A.DisplayName)]
       	public long ID_HUB2013A { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.ID_HUB.Required)]
    	[DisplayName(AtributClass.HUB2013A.ID_HUB.DisplayName)]
       	public long ID_HUB { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.IDHUBNalogVrsta2013A.Required)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBNalogVrsta2013A.DisplayName)]
       	public int IDHUBNalogVrsta2013A { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.IDHUBModel2013APlatitelj.DisplayName)]
       	public Nullable<int> IDHUBModel2013APlatitelj { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.IDHUBModel2013APrimatelj.DisplayName)]
       	public Nullable<int> IDHUBModel2013APrimatelj { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.HUB2013A.IDValutaPlacanje.StringLength)]
        [Required(ErrorMessage = AtributClass.HUB2013A.IDValutaPlacanje.Required)]
    	[DisplayName(AtributClass.HUB2013A.IDValutaPlacanje.DisplayName)]
       	public string IDValutaPlacanje { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.HUB2013A.IDValutaPokrice.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDValutaPokrice.DisplayName)]
       	public string IDValutaPokrice { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.IDHUBNamjena2013A.DisplayName)]
       	public Nullable<int> IDHUBNamjena2013A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUB2013A.IDHUBNamjena2013AOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBNamjena2013AOznaka.DisplayName)]
       	public string IDHUBNamjena2013AOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUB2013A.IDHUBNamjena2013ANaziv.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBNamjena2013ANaziv.DisplayName)]
       	public string IDHUBNamjena2013ANaziv { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.IDHUBPrimateljVrsta2013A.DisplayName)]
       	public Nullable<int> IDHUBPrimateljVrsta2013A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUB2013A.IDHUBPrimateljVrsta2013AOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBPrimateljVrsta2013AOznaka.DisplayName)]
       	public string IDHUBPrimateljVrsta2013AOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUB2013A.IDHUBPrimateljVrsta2013ANaziv.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBPrimateljVrsta2013ANaziv.DisplayName)]
       	public string IDHUBPrimateljVrsta2013ANaziv { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.IDHUBTroskoviOpcija2013A.DisplayName)]
       	public Nullable<int> IDHUBTroskoviOpcija2013A { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.HUB2013A.IDHUBTroskoviOpcija2013AOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBTroskoviOpcija2013AOznaka.DisplayName)]
       	public string IDHUBTroskoviOpcija2013AOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUB2013A.IDHUBTroskoviOpcija2013ANaziv.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDHUBTroskoviOpcija2013ANaziv.DisplayName)]
       	public string IDHUBTroskoviOpcija2013ANaziv { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.ID_StornoHUB2013A.DisplayName)]
       	public Nullable<long> ID_StornoHUB2013A { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.IDDrzavaPrimatelj.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDDrzavaPrimatelj.DisplayName)]
       	public string IDDrzavaPrimatelj { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.IDDrzavaBanka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.IDDrzavaBanka.DisplayName)]
       	public string IDDrzavaBanka { get; set; }
    
    	
        [StringLength(70, ErrorMessage = AtributClass.HUB2013A.PlatiteljNaziv.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PlatiteljNaziv.DisplayName)]
       	public string PlatiteljNaziv { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.PlatiteljAdresa.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PlatiteljAdresa.DisplayName)]
       	public string PlatiteljAdresa { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.PlatiteljSjediste.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PlatiteljSjediste.DisplayName)]
       	public string PlatiteljSjediste { get; set; }
    
    	
        [StringLength(34, ErrorMessage = AtributClass.HUB2013A.PlatiteljRacun.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PlatiteljRacun.DisplayName)]
       	public string PlatiteljRacun { get; set; }
    
    	
        [StringLength(22, ErrorMessage = AtributClass.HUB2013A.PlatiteljPozivNaBroj.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PlatiteljPozivNaBroj.DisplayName)]
       	public string PlatiteljPozivNaBroj { get; set; }
    
    	
        [StringLength(70, ErrorMessage = AtributClass.HUB2013A.PrimateljNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.HUB2013A.PrimateljNaziv.Required)]
    	[DisplayName(AtributClass.HUB2013A.PrimateljNaziv.DisplayName)]
       	public string PrimateljNaziv { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.PrimateljAdresa.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PrimateljAdresa.DisplayName)]
       	public string PrimateljAdresa { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.PrimateljSjediste.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PrimateljSjediste.DisplayName)]
       	public string PrimateljSjediste { get; set; }
    
    	
        [StringLength(34, ErrorMessage = AtributClass.HUB2013A.PrimateljRacun.StringLength)]
        [Required(ErrorMessage = AtributClass.HUB2013A.PrimateljRacun.Required)]
    	[DisplayName(AtributClass.HUB2013A.PrimateljRacun.DisplayName)]
       	public string PrimateljRacun { get; set; }
    
    	
        [StringLength(22, ErrorMessage = AtributClass.HUB2013A.PrimateljPozivNaBroj.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.PrimateljPozivNaBroj.DisplayName)]
       	public string PrimateljPozivNaBroj { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.Iznos.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.HUB2013A.Iznos.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal Iznos { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUB2013A.OpisPlacanje.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.OpisPlacanje.DisplayName)]
       	public string OpisPlacanje { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.HUB2013A.OpisPlacanjePlatitelj.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.OpisPlacanjePlatitelj.DisplayName)]
       	public string OpisPlacanjePlatitelj { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.Hitno.DisplayName)]
       	public Nullable<bool> Hitno { get; set; }
    
    	
        [StringLength(11, ErrorMessage = AtributClass.HUB2013A.SWIFT.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.SWIFT.DisplayName)]
       	public string SWIFT { get; set; }
    
    	
        [StringLength(70, ErrorMessage = AtributClass.HUB2013A.BankaNaziv.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.BankaNaziv.DisplayName)]
       	public string BankaNaziv { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.BankaAdresa.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.BankaAdresa.DisplayName)]
       	public string BankaAdresa { get; set; }
    
    	
        [StringLength(35, ErrorMessage = AtributClass.HUB2013A.BankaSjediste.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.BankaSjediste.DisplayName)]
       	public string BankaSjediste { get; set; }
    
    	[DisplayName(AtributClass.HUB2013A.Storno.DisplayName)]
       	public Nullable<bool> Storno { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.HUBModel2013APlatiteljOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.HUBModel2013APlatiteljOznaka.DisplayName)]
       	public string HUBModel2013APlatiteljOznaka { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.HUBModel2013APlatiteljPredOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.HUBModel2013APlatiteljPredOznaka.DisplayName)]
       	public string HUBModel2013APlatiteljPredOznaka { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.HUBModel2013APrimateljOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.HUBModel2013APrimateljOznaka.DisplayName)]
       	public string HUBModel2013APrimateljOznaka { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.HUB2013A.HUBModel2013APrimateljPredOznaka.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.HUBModel2013APrimateljPredOznaka.DisplayName)]
       	public string HUBModel2013APrimateljPredOznaka { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.HUB2013A.DrzavaPrimateljSif.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.DrzavaPrimateljSif.DisplayName)]
       	public string DrzavaPrimateljSif { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.HUB2013A.DrzavaBankaSif.StringLength)]
    	[DisplayName(AtributClass.HUB2013A.DrzavaBankaSif.DisplayName)]
       	public string DrzavaBankaSif { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.BrojUgovor.Required)]
    	[DisplayName(AtributClass.HUB2013A.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.BrojObrok.Required)]
    	[DisplayName(AtributClass.HUB2013A.BrojObrok.DisplayName)]
       	public int BrojObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.ID_HUBImportHUB.Required)]
    	[DisplayName(AtributClass.HUB2013A.ID_HUBImportHUB.DisplayName)]
       	public long ID_HUBImportHUB { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.Godina.Required)]
    	[DisplayName(AtributClass.HUB2013A.Godina.DisplayName)]
       	public int Godina { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.Mjesec.Required)]
    	[DisplayName(AtributClass.HUB2013A.Mjesec.DisplayName)]
       	public int Mjesec { get; set; }
    
        [Required(ErrorMessage = AtributClass.HUB2013A.ID_HUBImport.Required)]
    	[DisplayName(AtributClass.HUB2013A.ID_HUBImport.DisplayName)]
       	public long ID_HUBImport { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.HUB2013A.DatumIzvrsenje.DisplayName)]
       	public Nullable<System.DateTime> DatumIzvrsenje { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.HUB2013A.DatumDospijece.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijece { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public HUB2013AFormFormattedBase()
        { }
    	
    	public HUB2013AFormFormattedBase(Model.Data.View.HUB2013A formformated)
    	{
    	    this.ID_HUB2013A = formformated.ID_HUB2013A;
    	    this.ID_HUB = formformated.ID_HUB;
    	    this.IDHUBNalogVrsta2013A = formformated.IDHUBNalogVrsta2013A;
    	    this.IDHUBModel2013APlatitelj = formformated.IDHUBModel2013APlatitelj;
    	    this.IDHUBModel2013APrimatelj = formformated.IDHUBModel2013APrimatelj;
    	    this.IDValutaPlacanje = formformated.IDValutaPlacanje;
    	    this.IDValutaPokrice = formformated.IDValutaPokrice;
    	    this.IDHUBNamjena2013A = formformated.IDHUBNamjena2013A;
    	    this.IDHUBNamjena2013AOznaka = formformated.IDHUBNamjena2013AOznaka;
    	    this.IDHUBNamjena2013ANaziv = formformated.IDHUBNamjena2013ANaziv;
    	    this.IDHUBPrimateljVrsta2013A = formformated.IDHUBPrimateljVrsta2013A;
    	    this.IDHUBPrimateljVrsta2013AOznaka = formformated.IDHUBPrimateljVrsta2013AOznaka;
    	    this.IDHUBPrimateljVrsta2013ANaziv = formformated.IDHUBPrimateljVrsta2013ANaziv;
    	    this.IDHUBTroskoviOpcija2013A = formformated.IDHUBTroskoviOpcija2013A;
    	    this.IDHUBTroskoviOpcija2013AOznaka = formformated.IDHUBTroskoviOpcija2013AOznaka;
    	    this.IDHUBTroskoviOpcija2013ANaziv = formformated.IDHUBTroskoviOpcija2013ANaziv;
    	    this.ID_StornoHUB2013A = formformated.ID_StornoHUB2013A;
    	    this.IDDrzavaPrimatelj = formformated.IDDrzavaPrimatelj;
    	    this.IDDrzavaBanka = formformated.IDDrzavaBanka;
    	    this.PlatiteljNaziv = formformated.PlatiteljNaziv;
    	    this.PlatiteljAdresa = formformated.PlatiteljAdresa;
    	    this.PlatiteljSjediste = formformated.PlatiteljSjediste;
    	    this.PlatiteljRacun = formformated.PlatiteljRacun;
    	    this.PlatiteljPozivNaBroj = formformated.PlatiteljPozivNaBroj;
    	    this.PrimateljNaziv = formformated.PrimateljNaziv;
    	    this.PrimateljAdresa = formformated.PrimateljAdresa;
    	    this.PrimateljSjediste = formformated.PrimateljSjediste;
    	    this.PrimateljRacun = formformated.PrimateljRacun;
    	    this.PrimateljPozivNaBroj = formformated.PrimateljPozivNaBroj;
    	    this.Iznos = formformated.Iznos;
    	    this.OpisPlacanje = formformated.OpisPlacanje;
    	    this.OpisPlacanjePlatitelj = formformated.OpisPlacanjePlatitelj;
    	    this.Hitno = formformated.Hitno;
    	    this.SWIFT = formformated.SWIFT;
    	    this.BankaNaziv = formformated.BankaNaziv;
    	    this.BankaAdresa = formformated.BankaAdresa;
    	    this.BankaSjediste = formformated.BankaSjediste;
    	    this.Storno = formformated.Storno;
    	    this.HUBModel2013APlatiteljOznaka = formformated.HUBModel2013APlatiteljOznaka;
    	    this.HUBModel2013APlatiteljPredOznaka = formformated.HUBModel2013APlatiteljPredOznaka;
    	    this.HUBModel2013APrimateljOznaka = formformated.HUBModel2013APrimateljOznaka;
    	    this.HUBModel2013APrimateljPredOznaka = formformated.HUBModel2013APrimateljPredOznaka;
    	    this.DrzavaPrimateljSif = formformated.DrzavaPrimateljSif;
    	    this.DrzavaBankaSif = formformated.DrzavaBankaSif;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.ID_HUBImportHUB = formformated.ID_HUBImportHUB;
    	    this.Godina = formformated.Godina;
    	    this.Mjesec = formformated.Mjesec;
    	    this.ID_HUBImport = formformated.ID_HUBImport;
    	    this.DatumIzvrsenje = formformated.DatumIzvrsenje;
    	    this.DatumDospijece = formformated.DatumDospijece;
    	}
    
    	/*
    	    mymodel.ID_HUB2013A = model.ID_HUB2013A;
    	    mymodel.ID_HUB = model.ID_HUB;
    	    mymodel.IDHUBNalogVrsta2013A = model.IDHUBNalogVrsta2013A;
    	    mymodel.IDHUBModel2013APlatitelj = model.IDHUBModel2013APlatitelj;
    	    mymodel.IDHUBModel2013APrimatelj = model.IDHUBModel2013APrimatelj;
    	    mymodel.IDValutaPlacanje = model.IDValutaPlacanje;
    	    mymodel.IDValutaPokrice = model.IDValutaPokrice;
    	    mymodel.IDHUBNamjena2013A = model.IDHUBNamjena2013A;
    	    mymodel.IDHUBNamjena2013AOznaka = model.IDHUBNamjena2013AOznaka;
    	    mymodel.IDHUBNamjena2013ANaziv = model.IDHUBNamjena2013ANaziv;
    	    mymodel.IDHUBPrimateljVrsta2013A = model.IDHUBPrimateljVrsta2013A;
    	    mymodel.IDHUBPrimateljVrsta2013AOznaka = model.IDHUBPrimateljVrsta2013AOznaka;
    	    mymodel.IDHUBPrimateljVrsta2013ANaziv = model.IDHUBPrimateljVrsta2013ANaziv;
    	    mymodel.IDHUBTroskoviOpcija2013A = model.IDHUBTroskoviOpcija2013A;
    	    mymodel.IDHUBTroskoviOpcija2013AOznaka = model.IDHUBTroskoviOpcija2013AOznaka;
    	    mymodel.IDHUBTroskoviOpcija2013ANaziv = model.IDHUBTroskoviOpcija2013ANaziv;
    	    mymodel.ID_StornoHUB2013A = model.ID_StornoHUB2013A;
    	    mymodel.IDDrzavaPrimatelj = model.IDDrzavaPrimatelj;
    	    mymodel.IDDrzavaBanka = model.IDDrzavaBanka;
    	    mymodel.PlatiteljNaziv = model.PlatiteljNaziv;
    	    mymodel.PlatiteljAdresa = model.PlatiteljAdresa;
    	    mymodel.PlatiteljSjediste = model.PlatiteljSjediste;
    	    mymodel.PlatiteljRacun = model.PlatiteljRacun;
    	    mymodel.PlatiteljPozivNaBroj = model.PlatiteljPozivNaBroj;
    	    mymodel.PrimateljNaziv = model.PrimateljNaziv;
    	    mymodel.PrimateljAdresa = model.PrimateljAdresa;
    	    mymodel.PrimateljSjediste = model.PrimateljSjediste;
    	    mymodel.PrimateljRacun = model.PrimateljRacun;
    	    mymodel.PrimateljPozivNaBroj = model.PrimateljPozivNaBroj;
    	    mymodel.Iznos = model.Iznos;
    	    mymodel.OpisPlacanje = model.OpisPlacanje;
    	    mymodel.OpisPlacanjePlatitelj = model.OpisPlacanjePlatitelj;
    	    mymodel.Hitno = model.Hitno;
    	    mymodel.SWIFT = model.SWIFT;
    	    mymodel.BankaNaziv = model.BankaNaziv;
    	    mymodel.BankaAdresa = model.BankaAdresa;
    	    mymodel.BankaSjediste = model.BankaSjediste;
    	    mymodel.Storno = model.Storno;
    	    mymodel.HUBModel2013APlatiteljOznaka = model.HUBModel2013APlatiteljOznaka;
    	    mymodel.HUBModel2013APlatiteljPredOznaka = model.HUBModel2013APlatiteljPredOznaka;
    	    mymodel.HUBModel2013APrimateljOznaka = model.HUBModel2013APrimateljOznaka;
    	    mymodel.HUBModel2013APrimateljPredOznaka = model.HUBModel2013APrimateljPredOznaka;
    	    mymodel.DrzavaPrimateljSif = model.DrzavaPrimateljSif;
    	    mymodel.DrzavaBankaSif = model.DrzavaBankaSif;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.ID_HUBImportHUB = model.ID_HUBImportHUB;
    	    mymodel.Godina = model.Godina;
    	    mymodel.Mjesec = model.Mjesec;
    	    mymodel.ID_HUBImport = model.ID_HUBImport;
    	    mymodel.DatumIzvrsenje = model.DatumIzvrsenje;
    	    mymodel.DatumDospijece = model.DatumDospijece;
    		
    	*/
    
    		#endregion
    	
    }
}