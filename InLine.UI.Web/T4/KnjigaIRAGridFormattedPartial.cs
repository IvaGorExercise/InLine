//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.UI.Web.T4.GridFormattedTemplate
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
    
    
    public partial class KnjigaIRAGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.KnjigaIRA.ID_KnjigaIRA.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.ID_KnjigaIRA.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.ID_KnjigaIRA.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.ID_KnjigaIRA.Sortable)]
    	public long ID_KnjigaIRA { get; set; }
    
    	[DisplayName(AtributClass.KnjigaIRA.ID_Zapis.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.ID_Zapis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.ID_Zapis.Sortable)]
    	public Nullable<long> ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.ID_PoslovnaGodina.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.ID_PoslovnaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.ID_PoslovnaGodina.Sortable)]
    	public long ID_PoslovnaGodina { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.KnjigaIRA.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KnjigaIRA.Oznaka.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.KnjigaIRA.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KnjigaIRA.Naziv.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.KnjigaIRA.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KnjigaIRA.NazivKr.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.KnjigaIRA.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KnjigaIRA.Kratica.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.ID_RacunIzlaz.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.ID_RacunIzlaz.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.ID_RacunIzlaz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.ID_RacunIzlaz.Sortable)]
    	public long ID_RacunIzlaz { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosProlaznaSt.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosProlaznaSt.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosProlaznaSt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosProlaznaSt.Sortable)]
    	public decimal IznosProlaznaSt { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosNeoporezivo.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosNeoporezivo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosNeoporezivo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosNeoporezivo.Sortable)]
    	public decimal IznosNeoporezivo { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosIzvoz.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosIzvoz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosIzvoz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosIzvoz.Sortable)]
    	public decimal IznosIzvoz { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosMedunarodniPrijevoz.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosMedunarodniPrijevoz.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosMedunarodniPrijevoz.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosMedunarodniPrijevoz.Sortable)]
    	public decimal IznosMedunarodniPrijevoz { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosTuzemstvo.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosTuzemstvo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosTuzemstvo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosTuzemstvo.Sortable)]
    	public decimal IznosTuzemstvo { get; set; }
    
        [Required(ErrorMessage = AtributClass.KnjigaIRA.IznosOstalo.Required)]
    	[DisplayName(AtributClass.KnjigaIRA.IznosOstalo.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.KnjigaIRA.IznosOstalo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.KnjigaIRA.IznosOstalo.Sortable)]
    	public decimal IznosOstalo { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public KnjigaIRAGridFormattedBase()
        { }
    	
    	public KnjigaIRAGridFormattedBase(Model.Data.KnjigaIRA gridformated)
    	{
    	    this.ID_KnjigaIRA = gridformated.ID_KnjigaIRA;
    	    this.ID_Zapis = gridformated.ID_Zapis;
    	    this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.ID_RacunIzlaz = gridformated.ID_RacunIzlaz;
    	    this.IznosProlaznaSt = gridformated.IznosProlaznaSt;
    	    this.IznosNeoporezivo = gridformated.IznosNeoporezivo;
    	    this.IznosIzvoz = gridformated.IznosIzvoz;
    	    this.IznosMedunarodniPrijevoz = gridformated.IznosMedunarodniPrijevoz;
    	    this.IznosTuzemstvo = gridformated.IznosTuzemstvo;
    	    this.IznosOstalo = gridformated.IznosOstalo;
    	}
    
    	/*
    	    mymodel.ID_KnjigaIRA = model.ID_KnjigaIRA;
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.ID_RacunIzlaz = model.ID_RacunIzlaz;
    	    mymodel.IznosProlaznaSt = model.IznosProlaznaSt;
    	    mymodel.IznosNeoporezivo = model.IznosNeoporezivo;
    	    mymodel.IznosIzvoz = model.IznosIzvoz;
    	    mymodel.IznosMedunarodniPrijevoz = model.IznosMedunarodniPrijevoz;
    	    mymodel.IznosTuzemstvo = model.IznosTuzemstvo;
    	    mymodel.IznosOstalo = model.IznosOstalo;
    		
    	*/
    
    		#endregion
    }
}