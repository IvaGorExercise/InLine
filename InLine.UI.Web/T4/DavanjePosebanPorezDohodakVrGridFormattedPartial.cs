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
    
    
    public partial class DavanjePosebanPorezDohodakVrGridFormattedBase
    {
    	#region Properities
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.IDDavanjePosebanPorezDohodakVr.Sortable)]
    	public int IDDavanjePosebanPorezDohodakVr { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.Oznaka.Sortable)]
    	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Naziv.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Naziv.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.Naziv.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.Naziv.Sortable)]
    	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.NazivKr.Sortable)]
    	public string NazivKr { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.Kratica.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.Kratica.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.Kratica.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.Kratica.Sortable)]
    	public string Kratica { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.Required)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.DatumOd.Sortable)]
    	public System.DateTime DatumOd { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.DatumDo.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.DatumDo.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.DatumDo.Sortable)]
    	public Nullable<System.DateTime> DatumDo { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNGodina.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.NNGodina.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.NNGodina.Sortable)]
    	public Nullable<int> NNGodina { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNBroj.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.NNBroj.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.NNBroj.Sortable)]
    	public Nullable<int> NNBroj { get; set; }
    
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNClanak.DisplayName)]
       	[JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.NNClanak.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.NNClanak.Sortable)]
    	public Nullable<int> NNClanak { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.DavanjePosebanPorezDohodakVr.NNDatum.DisplayName)]
       	 [JqGridColumnSearchable(false)]
    	[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	[JqGridColumnFormatter(AtributClass.DavanjePosebanPorezDohodakVr.NNDatum.Formatter)]
    	[JqGridColumnSortable(true, Index = AtributClass.DavanjePosebanPorezDohodakVr.NNDatum.Sortable)]
    	public Nullable<System.DateTime> NNDatum { get; set; }
    
    	#endregion
    	
    	
    	#region Constructor
    	
    	public DavanjePosebanPorezDohodakVrGridFormattedBase()
        { }
    	
    	public DavanjePosebanPorezDohodakVrGridFormattedBase(Model.Data.DavanjePosebanPorezDohodakVr gridformated)
    	{
    	    this.IDDavanjePosebanPorezDohodakVr = gridformated.IDDavanjePosebanPorezDohodakVr;
    	    this.Oznaka = gridformated.Oznaka;
    	    this.Naziv = gridformated.Naziv;
    	    this.NazivKr = gridformated.NazivKr;
    	    this.Kratica = gridformated.Kratica;
    	    this.DatumOd = gridformated.DatumOd;
    	    this.DatumDo = gridformated.DatumDo;
    	    this.NNGodina = gridformated.NNGodina;
    	    this.NNBroj = gridformated.NNBroj;
    	    this.NNClanak = gridformated.NNClanak;
    	    this.NNDatum = gridformated.NNDatum;
    	}
    
    	/*
    	    mymodel.IDDavanjePosebanPorezDohodakVr = model.IDDavanjePosebanPorezDohodakVr;
    	    mymodel.Oznaka = model.Oznaka;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Kratica = model.Kratica;
    	    mymodel.DatumOd = model.DatumOd;
    	    mymodel.DatumDo = model.DatumDo;
    	    mymodel.NNGodina = model.NNGodina;
    	    mymodel.NNBroj = model.NNBroj;
    	    mymodel.NNClanak = model.NNClanak;
    	    mymodel.NNDatum = model.NNDatum;
    		
    	*/
    
    		#endregion
    }
}
