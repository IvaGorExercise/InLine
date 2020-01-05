//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate.View
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
    using InLine.UI.Web.T4.GridFormattedTemplate;
    using InLine.UI.Web.Helper;
    
    
    public partial class StanDetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.StanDetalj.ID_Stan.Required)]
    	[DisplayName(AtributClass.StanDetalj.ID_Stan.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.ID_Stan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.ID_Stan.Sortable)]
    	public long ID_Stan { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.ID_Objekt.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.ID_Objekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.ID_Objekt.Sortable)]
    	public Nullable<long> ID_Objekt { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Oznaka.Required)]
    	[DisplayName(AtributClass.StanDetalj.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.StanDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Naziv.Required)]
    	[DisplayName(AtributClass.StanDetalj.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.NazivKr.Required)]
    	[DisplayName(AtributClass.StanDetalj.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Kratica.Required)]
    	[DisplayName(AtributClass.StanDetalj.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.Povrsina.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Povrsina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Povrsina.Sortable)]
    	public Nullable<decimal> Povrsina { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.BrojSoba.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.BrojSoba.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.BrojSoba.Sortable)]
    	public Nullable<decimal> BrojSoba { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Broj.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.Broj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Broj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Broj.Sortable)]
    	public string Broj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Ulica.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.Ulica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Ulica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Ulica.Sortable)]
    	public string Ulica { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBrojDodatak.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.KucniBrojDodatak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.KucniBrojDodatak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.KucniBrojDodatak.Sortable)]
    	public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.KucniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.KucniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.KucniBroj.Sortable)]
    	public string KucniBroj { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kat.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.Kat.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Kat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Kat.Sortable)]
    	public string Kat { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.ID_Zgrada.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.ID_Zgrada.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.ID_Zgrada.Sortable)]
    	public Nullable<long> ID_Zgrada { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.Opis.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCestica.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.KatastarskaCestica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.KatastarskaCestica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.KatastarskaCestica.Sortable)]
    	public string KatastarskaCestica { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCesticaOpcina.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.KatastarskaCesticaOpcina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.KatastarskaCesticaOpcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.KatastarskaCesticaOpcina.Sortable)]
    	public string KatastarskaCesticaOpcina { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.ID_Adresa.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.ID_Adresa.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.ID_Adresa.Sortable)]
    	public Nullable<long> ID_Adresa { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.BrojUgovor.Sortable)]
    	public Nullable<int> BrojUgovor { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.StanDetalj.PostanskiBroj.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.PostanskiBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.PostanskiBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.PostanskiBroj.Sortable)]
    	public string PostanskiBroj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Posta.StringLength)]
    	[DisplayName(AtributClass.StanDetalj.Posta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.Posta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.Posta.Sortable)]
    	public string Posta { get; set; }
    
    	[DisplayName(AtributClass.StanDetalj.ID_Posta.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.StanDetalj.ID_Posta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.StanDetalj.ID_Posta.Sortable)]
    	public Nullable<long> ID_Posta { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public StanDetaljGridFormattedBase()
        { }
    	
    	public StanDetaljGridFormattedBase(Model.Data.View.StanDetalj gridformated)
    	{
    	    this.ID_Stan = gridformated.ID_Stan;
    	    this.ID_Objekt = gridformated.ID_Objekt;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Povrsina = gridformated.Povrsina;
    	    this.BrojSoba = gridformated.BrojSoba;
    	    this.Broj = gridformated.Broj;
    	    this.Ulica = gridformated.Ulica;
    	    this.KucniBrojDodatak = gridformated.KucniBrojDodatak;
    	    this.KucniBroj = gridformated.KucniBroj;
    	    this.Kat = gridformated.Kat;
    	    this.ID_Zgrada = gridformated.ID_Zgrada;
    	    this.Opis = gridformated.Opis;
    	    this.KatastarskaCestica = gridformated.KatastarskaCestica;
    	    this.KatastarskaCesticaOpcina = gridformated.KatastarskaCesticaOpcina;
    	    this.ID_Adresa = gridformated.ID_Adresa;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.PostanskiBroj = gridformated.PostanskiBroj;
    	    this.Posta = gridformated.Posta;
    	    this.ID_Posta = gridformated.ID_Posta;
    	}
    
    	/*
    	    mymodel.ID_Stan = model.ID_Stan;
    	    mymodel.ID_Objekt = model.ID_Objekt;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Povrsina = model.Povrsina;
    	    mymodel.BrojSoba = model.BrojSoba;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Ulica = model.Ulica;
    	    mymodel.KucniBrojDodatak = model.KucniBrojDodatak;
    	    mymodel.KucniBroj = model.KucniBroj;
    	    mymodel.Kat = model.Kat;
    	    mymodel.ID_Zgrada = model.ID_Zgrada;
    	    mymodel.Opis = model.Opis;
    	    mymodel.KatastarskaCestica = model.KatastarskaCestica;
    	    mymodel.KatastarskaCesticaOpcina = model.KatastarskaCesticaOpcina;
    	    mymodel.ID_Adresa = model.ID_Adresa;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.PostanskiBroj = model.PostanskiBroj;
    	    mymodel.Posta = model.Posta;
    	    mymodel.ID_Posta = model.ID_Posta;
    		
    	*/
    
    		#endregion
    }
}