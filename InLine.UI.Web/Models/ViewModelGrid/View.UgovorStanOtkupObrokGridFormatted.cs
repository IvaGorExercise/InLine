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


namespace InLine.UI.Web.T4.GridFormattedTemplate.View
{
    public partial class UgovorStanOtkupObrokGridFormatted
    {
     	#region Properities
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.DisplayName)]
        [ScaffoldColumn(false)]	[JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public long ID_UgovorStanOtkupObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkup.DisplayName)]
       	[JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkup.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkup.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public Nullable<long> ID_UgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupObrok.BrojUgovor.DisplayName)]
       	//[JqGridColumnSearchable(false)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.Eq)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.BrojUgovor.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.BrojUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.BrojObrok.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrok.BrojObrok.DisplayName)]
       		[JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.BrojObrok.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.BrojObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	public string BrojObrok { get; set; }
    
        //[DisplayName(AtributClass.UgovorStanOtkupObrok.Godina.DisplayName)]
        //    [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.Godina.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.Godina.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        //public Nullable<int> Godina { get; set; }

        // rucno dodani property
        // mje. god. kombinacija pojedinacnih propertija mjesec i godina koji su gore zakomentirani
        [DisplayName("Mj.God.")]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.Godina.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.Godina.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        public string MjeGod { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrok.SumaObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
       		[JqGridColumnSearchable(false)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.SumaObrok.Sortable)]
    	[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.SumaObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
    	public Nullable<decimal> SumaObrok { get; set; }
    
        //[DisplayName(AtributClass.UgovorStanOtkupObrok.Mjesec.DisplayName)]
        //    [JqGridColumnSearchable(false)]
        //[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.Mjesec.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.Mjesec.Formatter)]
        //[JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        //public Nullable<int> Mjesec { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
       	[JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.IznosZateznaKamata.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public decimal IznosZateznaKamata { get; set; }
    

    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.Placen.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrok.Placen.DisplayName)]
        [JqGridColumnSearchable(true, "Placen", "PregledUgovora", SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
    	[JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.Placen.Sortable)]
        //[JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.Placen.Formatter)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
    	public bool Placen { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.TecajObrok.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrok.TecajObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.TecajObrok.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.TecajObrok.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public decimal TecajObrok { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrok.TecajUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrok.TecajUgovor.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.TecajUgovor.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.TecajUgovor.Formatter)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        public decimal TecajUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupMoratorij.DisplayName)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnSortable(true, Index = AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupMoratorij.Sortable)]
        [JqGridColumnFormatter(AtributClass.UgovorStanOtkupObrok.ID_UgovorStanOtkupMoratorij.Formatter)]
        public Nullable<long> ID_UgovorStanOtkupMoratorij { get; set; }

    	#endregion
    	
    	
    	#region Constructor
    	
    	public UgovorStanOtkupObrokGridFormatted()
        { }
    	
    	public UgovorStanOtkupObrokGridFormatted(Model.Data.View.UgovorStanOtkupObrok gridformated)
    	{
    	    this.ID_UgovorStanOtkupObrok = gridformated.ID_UgovorStanOtkupObrok;
    	    this.ID_UgovorStanOtkup = gridformated.ID_UgovorStanOtkup;
    	    this.BrojUgovor = gridformated.BrojUgovor;
            this.BrojObrok = gridformated.BrojObrok.ToString("D3");
    	   // this.Godina = gridformated.Godina;
    	    this.SumaObrok = gridformated.SumaObrok;
    	   // this.Mjesec = gridformated.Mjesec;
            this.IznosZateznaKamata = gridformated.IznosZateznaKamata;
            this.Placen = gridformated.Placen;
    	    this.TecajObrok = gridformated.TecajObrok;
    	    this.TecajUgovor = gridformated.TecajUgovor;
            this.ID_UgovorStanOtkupMoratorij = gridformated.ID_UgovorStanOtkupMoratorij;

            // Rucno fgormatiranje propertija
            // Formatirani mjesec i godina
            if (gridformated.Mjesec < 10)
            {
                this.MjeGod = "0" + gridformated.Mjesec + "." + gridformated.Godina;
            }
            else
            {
                this.MjeGod = gridformated.Mjesec + "." + gridformated.Godina;
            }
       
    	    
    	}
    

    		#endregion
    }
}

