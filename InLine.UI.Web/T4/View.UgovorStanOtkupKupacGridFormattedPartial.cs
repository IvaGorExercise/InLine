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
    
    
    public partial class UgovorStanOtkupKupacGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_Kupac.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_Kupac.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_Kupac.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_Kupac.Sortable)]
    	public long ID_Kupac { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupac.Naziv.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkup.Sortable)]
    	public long ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupac.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.BrojUgovor.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.BrojUgovor.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.BrojUgovor.Sortable)]
    	public int BrojUgovor { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.ID_UgovorStanOtkupKupac.Sortable)]
    	public Nullable<long> ID_UgovorStanOtkupKupac { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.JMBG.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.JMBG.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.JMBG.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.JMBG.Sortable)]
    	public string JMBG { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupac.OIB.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.OIB.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.OIB.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.OIB.Sortable)]
    	public string OIB { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Nositelj.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.Nositelj.Sortable)]
    	public Nullable<bool> Nositelj { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupac.Ulica.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.Ulica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.Ulica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.Ulica.Sortable)]
    	public string Ulica { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupKupac.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.KucniBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.KucniBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.KucniBroj.Sortable)]
    	public string KucniBroj { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.KucniBrojDodatak.Sortable)]
    	public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.UgovorStanOtkupKupac.PostanskiBroj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupKupac.PostanskiBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupKupac.PostanskiBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupKupac.PostanskiBroj.Sortable)]
    	public string PostanskiBroj { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupKupacGridFormattedBase()
        { }
    	
    	public UgovorStanOtkupKupacGridFormattedBase(Model.Data.View.UgovorStanOtkupKupac gridformated)
    	{
    	    this.ID_Kupac = gridformated.ID_Kupac;
    	    this.Naziv = gridformated.Naziv;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = gridformated.BrojUgovor;
    	    this.ID_UgovorStanOtkupKupac = gridformated.ID_UgovorStanOtkupKupac;
    	    this.JMBG = gridformated.JMBG;
    	    this.OIB = gridformated.OIB;
    	    this.Nositelj = gridformated.Nositelj;
    	    this.Ulica = gridformated.Ulica;
    	    this.KucniBroj = gridformated.KucniBroj;
    	    this.KucniBrojDodatak = gridformated.KucniBrojDodatak;
    	    this.PostanskiBroj = gridformated.PostanskiBroj;
    	}
    
    	/*
    	    mymodel.ID_Kupac = model.ID_Kupac;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
    	    mymodel.JMBG = model.JMBG;
    	    mymodel.OIB = model.OIB;
    	    mymodel.Nositelj = model.Nositelj;
    	    mymodel.Ulica = model.Ulica;
    	    mymodel.KucniBroj = model.KucniBroj;
    	    mymodel.KucniBrojDodatak = model.KucniBrojDodatak;
    	    mymodel.PostanskiBroj = model.PostanskiBroj;
    		
    	*/
    
    		#endregion
    }
}
