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
    
    
    public partial class MjestoOpcinaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.MjestoOpcina.ID_MjestoOpcina.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.ID_MjestoOpcina.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.ID_MjestoOpcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.ID_MjestoOpcina.Sortable)]
    	public long ID_MjestoOpcina { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.ID_Mjesto.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.ID_Mjesto.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.ID_Mjesto.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.ID_Mjesto.Sortable)]
    	public long ID_Mjesto { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.ID_MjestoDio.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.ID_MjestoDio.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.ID_MjestoDio.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.ID_MjestoDio.Sortable)]
    	public long ID_MjestoDio { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.MjestoOpcina.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.DatumOd.Sortable)]
    	public Nullable<System.DateTime> DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.MjestoOpcina.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.AktivU.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.AktivU.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.AktivU.Sortable)]
    	public bool AktivU { get; set; }
    
    	[DisplayName(AtributClass.MjestoOpcina.ID_Opcina.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.ID_Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.ID_Opcina.Sortable)]
    	public Nullable<long> ID_Opcina { get; set; }
    
    	[DisplayName(AtributClass.MjestoOpcina.ID_MjestoDioTip.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.ID_MjestoDioTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.ID_MjestoDioTip.Sortable)]
    	public Nullable<long> ID_MjestoDioTip { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjestoOpcina.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.Oznaka.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.Naziv.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.MjestoOpcina.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.NazivKr.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.MjestoOpcina.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.Kratica.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.Opis.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.Opis.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.Opis.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Opis.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Opis.Sortable)]
    	public string Opis { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.NazivAlt.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.NazivAlt.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.NazivAlt.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.NazivAlt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.NazivAlt.Sortable)]
    	public string NazivAlt { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.NazivHPT.StringLength)]
        [Required(ErrorMessage = AtributClass.MjestoOpcina.NazivHPT.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.NazivHPT.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.NazivHPT.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.NazivHPT.Sortable)]
    	public string NazivHPT { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.NeOK.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.NeOK.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.NeOK.Sortable)]
    	public bool NeOK { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.VisePosta.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.VisePosta.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.VisePosta.Sortable)]
    	public bool VisePosta { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.MjestoOpcina.StsMjesto.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.StsMjesto.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.StsMjesto.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.StsMjesto.Sortable)]
    	public string StsMjesto { get; set; }
    
        [Required(ErrorMessage = AtributClass.MjestoOpcina.IzborMjesto.Required)]
    	[DisplayName(AtributClass.MjestoOpcina.IzborMjesto.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.IzborMjesto.Sortable)]
    	public bool IzborMjesto { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.MjestoOpcina.MBr.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.MBr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.MBr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.MBr.Sortable)]
    	public string MBr { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.PathSlika.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.PathSlika.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.PathSlika.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.PathSlika.Sortable)]
    	public string PathSlika { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.PathPlan.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.PathPlan.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.PathPlan.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.PathPlan.Sortable)]
    	public string PathPlan { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.PathSlika2.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.PathSlika2.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.PathSlika2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.PathSlika2.Sortable)]
    	public string PathSlika2 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.Opcina.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.Opcina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Opcina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Opcina.Sortable)]
    	public string Opcina { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.MjestoOpcina.Zupanija.StringLength)]
    	[DisplayName(AtributClass.MjestoOpcina.Zupanija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.MjestoOpcina.Zupanija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.MjestoOpcina.Zupanija.Sortable)]
    	public string Zupanija { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public MjestoOpcinaGridFormattedBase()
        { }
    	
    	public MjestoOpcinaGridFormattedBase(Model.Data.MjestoOpcina gridformated)
    	{
    	    this.ID_MjestoOpcina = gridformated.ID_MjestoOpcina;
    	    this.ID_Mjesto = gridformated.ID_Mjesto;
    	    this.ID_MjestoDio = gridformated.ID_MjestoDio;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.AktivU = gridformated.AktivU;
    	    this.ID_Opcina = gridformated.ID_Opcina;
    	    this.ID_MjestoDioTip = gridformated.ID_MjestoDioTip;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.Opis = gridformated.Opis;
    	    this.NazivAlt = gridformated.NazivAlt;
    	    this.NazivHPT = gridformated.NazivHPT;
    	    this.NeOK = gridformated.NeOK;
    	    this.VisePosta = gridformated.VisePosta;
    	    this.StsMjesto = gridformated.StsMjesto;
    	    this.IzborMjesto = gridformated.IzborMjesto;
    	    this.MBr = gridformated.MBr;
    	    this.PathSlika = gridformated.PathSlika;
    	    this.PathPlan = gridformated.PathPlan;
    	    this.PathSlika2 = gridformated.PathSlika2;
    	    this.Opcina = gridformated.Opcina;
    	    this.Zupanija = gridformated.Zupanija;
    	}
    
    	/*
    	    mymodel.ID_MjestoOpcina = model.ID_MjestoOpcina;
    	    mymodel.ID_Mjesto = model.ID_Mjesto;
    	    mymodel.ID_MjestoDio = model.ID_MjestoDio;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.AktivU = model.AktivU;
    	    mymodel.ID_Opcina = model.ID_Opcina;
    	    mymodel.ID_MjestoDioTip = model.ID_MjestoDioTip;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.Opis = model.Opis;
    	    mymodel.NazivAlt = model.NazivAlt;
    	    mymodel.NazivHPT = model.NazivHPT;
    	    mymodel.NeOK = model.NeOK;
    	    mymodel.VisePosta = model.VisePosta;
    	    mymodel.StsMjesto = model.StsMjesto;
    	    mymodel.IzborMjesto = model.IzborMjesto;
    	    mymodel.MBr = model.MBr;
    	    mymodel.PathSlika = model.PathSlika;
    	    mymodel.PathPlan = model.PathPlan;
    	    mymodel.PathSlika2 = model.PathSlika2;
    	    mymodel.Opcina = model.Opcina;
    	    mymodel.Zupanija = model.Zupanija;
    		
    	*/
    
    		#endregion
    }
}
