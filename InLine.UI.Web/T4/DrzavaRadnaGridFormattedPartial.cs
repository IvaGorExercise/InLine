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
    
    
    public partial class DrzavaRadnaGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DrzavaRadna.ID_Drzava.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.ID_Drzava.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ID_Drzava.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ID_Drzava.Sortable)]
    	public long ID_Drzava { get; set; }
    
    	
        [StringLength(2, ErrorMessage = AtributClass.DrzavaRadna.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DrzavaRadna.Oznaka.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DrzavaRadna.Naziv.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DrzavaRadna.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DrzavaRadna.NazivKr.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DrzavaRadna.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DrzavaRadna.Kratica.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivEn.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivEn.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivEn.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivEn.Sortable)]
    	public string NazivEn { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivFr.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivFr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivFr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivFr.Sortable)]
    	public string NazivFr { get; set; }
    
    	[DisplayName(AtributClass.DrzavaRadna.Kod.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Kod.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Kod.Sortable)]
    	public Nullable<int> Kod { get; set; }
    
        [Required(ErrorMessage = AtributClass.DrzavaRadna.Teritorij.Required)]
    	[DisplayName(AtributClass.DrzavaRadna.Teritorij.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Teritorij.Sortable)]
    	public bool Teritorij { get; set; }
    
    	[DisplayName(AtributClass.DrzavaRadna.ID_DrzavaNad.DisplayName)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ID_DrzavaNad.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ID_DrzavaNad.Sortable)]
    	public Nullable<long> ID_DrzavaNad { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.DrzavaRadna.SifDrzava.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.SifDrzava.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.SifDrzava.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.SifDrzava.Sortable)]
    	public string SifDrzava { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.OznDrzava.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.OznDrzava.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.OznDrzava.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.OznDrzava.Sortable)]
    	public string OznDrzava { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.ISO3166.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.ISO3166.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ISO3166.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ISO3166.Sortable)]
    	public string ISO3166 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.FIPS104.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.FIPS104.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.FIPS104.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.FIPS104.Sortable)]
    	public string FIPS104 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.Internet.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Internet.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Internet.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Internet.Sortable)]
    	public string Internet { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.DrzavaRadna.OznHr.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.OznHr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.OznHr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.OznHr.Sortable)]
    	public string OznHr { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.DrzavaRadna.OznEng.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.OznEng.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.OznEng.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.OznEng.Sortable)]
    	public string OznEng { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.DrzavaRadna.NazivHr.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivHr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivHr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivHr.Sortable)]
    	public string NazivHr { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivHrDugi.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivHrDugi.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivHrDugi.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivHrDugi.Sortable)]
    	public string NazivHrDugi { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivEng.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivEng.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivEng.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivEng.Sortable)]
    	public string NazivEng { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivEngDugi.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivEngDugi.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivEngDugi.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivEngDugi.Sortable)]
    	public string NazivEngDugi { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivLokal.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivLokal.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivLokal.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivLokal.Sortable)]
    	public string NazivLokal { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivLokalDugi.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivLokalDugi.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivLokalDugi.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivLokalDugi.Sortable)]
    	public string NazivLokalDugi { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivStariHr.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivStariHr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivStariHr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivStariHr.Sortable)]
    	public string NazivStariHr { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.NazivStariEng.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.NazivStariEng.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.NazivStariEng.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.NazivStariEng.Sortable)]
    	public string NazivStariEng { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DrzavaRadna.Kratica1.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Kratica1.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Kratica1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Kratica1.Sortable)]
    	public string Kratica1 { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.DrzavaRadna.Nacija.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Nacija.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Nacija.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Nacija.Sortable)]
    	public string Nacija { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.Obuhvat.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Obuhvat.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Obuhvat.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Obuhvat.Sortable)]
    	public string Obuhvat { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.Napomena.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Napomena.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Napomena.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Napomena.Sortable)]
    	public string Napomena { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.Komentar.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.Komentar.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.Komentar.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.Komentar.Sortable)]
    	public string Komentar { get; set; }
    
    	
        [StringLength(1, ErrorMessage = AtributClass.DrzavaRadna.StsDrzava.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.StsDrzava.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.StsDrzava.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.StsDrzava.Sortable)]
    	public string StsDrzava { get; set; }
    
    	[DisplayName(AtributClass.DrzavaRadna.IzborDrzava.DisplayName)]
       	[JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.IzborDrzava.Sortable)]
    	public Nullable<bool> IzborDrzava { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.ZastavaV.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.ZastavaV.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ZastavaV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ZastavaV.Sortable)]
    	public string ZastavaV { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.ZastavaM.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.ZastavaM.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ZastavaM.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ZastavaM.Sortable)]
    	public string ZastavaM { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.ZastavaMPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.ZastavaMPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ZastavaMPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ZastavaMPath.Sortable)]
    	public string ZastavaMPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.ZastavaVPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.ZastavaVPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.ZastavaVPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.ZastavaVPath.Sortable)]
    	public string ZastavaVPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.GrbV.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.GrbV.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.GrbV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.GrbV.Sortable)]
    	public string GrbV { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.GrbM.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.GrbM.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.GrbM.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.GrbM.Sortable)]
    	public string GrbM { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.GrbVPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.GrbVPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.GrbVPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.GrbVPath.Sortable)]
    	public string GrbVPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.GrbMPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.GrbMPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.GrbMPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.GrbMPath.Sortable)]
    	public string GrbMPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.KartaV.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.KartaV.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.KartaV.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.KartaV.Sortable)]
    	public string KartaV { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.KartaM.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.KartaM.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.KartaM.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.KartaM.Sortable)]
    	public string KartaM { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.KartaMPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.KartaMPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.KartaMPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.KartaMPath.Sortable)]
    	public string KartaMPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.KartaVPath.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.KartaVPath.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.KartaVPath.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.KartaVPath.Sortable)]
    	public string KartaVPath { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.DrzavaHtml1.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.DrzavaHtml1.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.DrzavaHtml1.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.DrzavaHtml1.Sortable)]
    	public string DrzavaHtml1 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.DrzavaHtml2.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.DrzavaHtml2.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.DrzavaHtml2.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.DrzavaHtml2.Sortable)]
    	public string DrzavaHtml2 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.DrzavaHtml3.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.DrzavaHtml3.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.DrzavaHtml3.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.DrzavaHtml3.Sortable)]
    	public string DrzavaHtml3 { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DrzavaRadna.DrzavaHtml4.StringLength)]
    	[DisplayName(AtributClass.DrzavaRadna.DrzavaHtml4.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DrzavaRadna.DrzavaHtml4.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DrzavaRadna.DrzavaHtml4.Sortable)]
    	public string DrzavaHtml4 { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DrzavaRadnaGridFormattedBase()
        { }
    	
    	public DrzavaRadnaGridFormattedBase(Model.Data.DrzavaRadna gridformated)
    	{
    	    this.ID_Drzava = gridformated.ID_Drzava;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.NazivEn = gridformated.NazivEn;
    	    this.NazivFr = gridformated.NazivFr;
    	    this.Kod = gridformated.Kod;
    	    this.Teritorij = gridformated.Teritorij;
    	    this.ID_DrzavaNad = gridformated.ID_DrzavaNad;
    	    this.SifDrzava = gridformated.SifDrzava;
    	    this.OznDrzava = gridformated.OznDrzava;
    	    this.ISO3166 = gridformated.ISO3166;
    	    this.FIPS104 = gridformated.FIPS104;
    	    this.Internet = gridformated.Internet;
    	    this.OznHr = gridformated.OznHr;
    	    this.OznEng = gridformated.OznEng;
    	    this.NazivHr = gridformated.NazivHr;
    	    this.NazivHrDugi = gridformated.NazivHrDugi;
    	    this.NazivEng = gridformated.NazivEng;
    	    this.NazivEngDugi = gridformated.NazivEngDugi;
    	    this.NazivLokal = gridformated.NazivLokal;
    	    this.NazivLokalDugi = gridformated.NazivLokalDugi;
    	    this.NazivStariHr = gridformated.NazivStariHr;
    	    this.NazivStariEng = gridformated.NazivStariEng;
    	    this.Kratica1 = gridformated.Kratica1;
    	    this.Nacija = gridformated.Nacija;
    	    this.Obuhvat = gridformated.Obuhvat;
    	    this.Napomena = gridformated.Napomena;
    	    this.Komentar = gridformated.Komentar;
    	    this.StsDrzava = gridformated.StsDrzava;
    	    this.IzborDrzava = gridformated.IzborDrzava;
    	    this.ZastavaV = gridformated.ZastavaV;
    	    this.ZastavaM = gridformated.ZastavaM;
    	    this.ZastavaMPath = gridformated.ZastavaMPath;
    	    this.ZastavaVPath = gridformated.ZastavaVPath;
    	    this.GrbV = gridformated.GrbV;
    	    this.GrbM = gridformated.GrbM;
    	    this.GrbVPath = gridformated.GrbVPath;
    	    this.GrbMPath = gridformated.GrbMPath;
    	    this.KartaV = gridformated.KartaV;
    	    this.KartaM = gridformated.KartaM;
    	    this.KartaMPath = gridformated.KartaMPath;
    	    this.KartaVPath = gridformated.KartaVPath;
    	    this.DrzavaHtml1 = gridformated.DrzavaHtml1;
    	    this.DrzavaHtml2 = gridformated.DrzavaHtml2;
    	    this.DrzavaHtml3 = gridformated.DrzavaHtml3;
    	    this.DrzavaHtml4 = gridformated.DrzavaHtml4;
    	}
    
    	/*
    	    mymodel.ID_Drzava = model.ID_Drzava;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.NazivEn = model.NazivEn;
    	    mymodel.NazivFr = model.NazivFr;
    	    mymodel.Kod = model.Kod;
    	    mymodel.Teritorij = model.Teritorij;
    	    mymodel.ID_DrzavaNad = model.ID_DrzavaNad;
    	    mymodel.SifDrzava = model.SifDrzava;
    	    mymodel.OznDrzava = model.OznDrzava;
    	    mymodel.ISO3166 = model.ISO3166;
    	    mymodel.FIPS104 = model.FIPS104;
    	    mymodel.Internet = model.Internet;
    	    mymodel.OznHr = model.OznHr;
    	    mymodel.OznEng = model.OznEng;
    	    mymodel.NazivHr = model.NazivHr;
    	    mymodel.NazivHrDugi = model.NazivHrDugi;
    	    mymodel.NazivEng = model.NazivEng;
    	    mymodel.NazivEngDugi = model.NazivEngDugi;
    	    mymodel.NazivLokal = model.NazivLokal;
    	    mymodel.NazivLokalDugi = model.NazivLokalDugi;
    	    mymodel.NazivStariHr = model.NazivStariHr;
    	    mymodel.NazivStariEng = model.NazivStariEng;
    	    mymodel.Kratica1 = model.Kratica1;
    	    mymodel.Nacija = model.Nacija;
    	    mymodel.Obuhvat = model.Obuhvat;
    	    mymodel.Napomena = model.Napomena;
    	    mymodel.Komentar = model.Komentar;
    	    mymodel.StsDrzava = model.StsDrzava;
    	    mymodel.IzborDrzava = model.IzborDrzava;
    	    mymodel.ZastavaV = model.ZastavaV;
    	    mymodel.ZastavaM = model.ZastavaM;
    	    mymodel.ZastavaMPath = model.ZastavaMPath;
    	    mymodel.ZastavaVPath = model.ZastavaVPath;
    	    mymodel.GrbV = model.GrbV;
    	    mymodel.GrbM = model.GrbM;
    	    mymodel.GrbVPath = model.GrbVPath;
    	    mymodel.GrbMPath = model.GrbMPath;
    	    mymodel.KartaV = model.KartaV;
    	    mymodel.KartaM = model.KartaM;
    	    mymodel.KartaMPath = model.KartaMPath;
    	    mymodel.KartaVPath = model.KartaVPath;
    	    mymodel.DrzavaHtml1 = model.DrzavaHtml1;
    	    mymodel.DrzavaHtml2 = model.DrzavaHtml2;
    	    mymodel.DrzavaHtml3 = model.DrzavaHtml3;
    	    mymodel.DrzavaHtml4 = model.DrzavaHtml4;
    		
    	*/
    
    		#endregion
    }
}
