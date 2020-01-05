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
    
    
    public partial class ObrazacVrPoljeGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.ID_ObrazacVrPolje.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.ID_ObrazacVrPolje.DisplayName)]
        [ScaffoldColumn(false)]
      	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.ID_ObrazacVrPolje.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.ID_ObrazacVrPolje.Sortable)]
    	public long ID_ObrazacVrPolje { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.ID_ObrazacVr.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.ID_ObrazacVr.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.ID_ObrazacVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.ID_ObrazacVr.Sortable)]
    	public long ID_ObrazacVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.ObrazacVrPolje.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.Oznaka.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ObrazacVrPolje.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.Naziv.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ObrazacVrPolje.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.NazivKr.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.ObrazacVrPolje.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.Kratica.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.DatumOd.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ObrazacVrPolje.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
        [Required(ErrorMessage = AtributClass.ObrazacVrPolje.ID_ObrazacVrPoljeTip.Required)]
    	[DisplayName(AtributClass.ObrazacVrPolje.ID_ObrazacVrPoljeTip.DisplayName)]
        [ScaffoldColumn(false)]
       	[JqGridColumnSearchable(false, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.ObrazacVrPolje.ID_ObrazacVrPoljeTip.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.ObrazacVrPolje.ID_ObrazacVrPoljeTip.Sortable)]
    	public long ID_ObrazacVrPoljeTip { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public ObrazacVrPoljeGridFormattedBase()
        { }
    	
    	public ObrazacVrPoljeGridFormattedBase(Model.Data.ObrazacVrPolje gridformated)
    	{
    	    this.ID_ObrazacVrPolje = gridformated.ID_ObrazacVrPolje;
    	    this.ID_ObrazacVr = gridformated.ID_ObrazacVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.ID_ObrazacVrPoljeTip = gridformated.ID_ObrazacVrPoljeTip;
    	}
    
    	/*
    	    mymodel.ID_ObrazacVrPolje = model.ID_ObrazacVrPolje;
    	    mymodel.ID_ObrazacVr = model.ID_ObrazacVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.ID_ObrazacVrPoljeTip = model.ID_ObrazacVrPoljeTip;
    		
    	*/
    
    		#endregion
    }
}