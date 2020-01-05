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
    
    
    public partial class PoslovnaGodinaDetaljGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.Sortable)]
    	public long ID_PoslovnaGodina { get; set; }
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.Sortable)]
    	public long ID_PoslovniSubjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.Godina.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.Godina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.Godina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.Godina.Sortable)]
    	public int Godina { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.DatumOd.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.DatumDo.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.DatumDo.Sortable)]
    	public System.DateTime DatumDo { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.PoslovnaGodinaDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.IDValuta.Required)]
    	[DisplayName(AtributClass.PoslovnaGodinaDetalj.IDValuta.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.PoslovnaGodinaDetalj.IDValuta.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.PoslovnaGodinaDetalj.IDValuta.Sortable)]
    	public string IDValuta { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public PoslovnaGodinaDetaljGridFormattedBase()
        { }
    	
    	public PoslovnaGodinaDetaljGridFormattedBase(Model.Data.View.PoslovnaGodinaDetalj gridformated)
    	{
    	    this.ID_PoslovnaGodina = gridformated.ID_PoslovnaGodina;
    	    this.ID_PoslovniSubjekt = gridformated.ID_PoslovniSubjekt;
    	    this.Godina = gridformated.Godina;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.IDValuta = gridformated.IDValuta;
    	}
    
    	/*
    	    mymodel.ID_PoslovnaGodina = model.ID_PoslovnaGodina;
    	    mymodel.ID_PoslovniSubjekt = model.ID_PoslovniSubjekt;
    	    mymodel.Godina = model.Godina;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.IDValuta = model.IDValuta;
    		
    	*/
    
    		#endregion
    }
}