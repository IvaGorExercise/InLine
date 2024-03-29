﻿using System;
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

    public partial class KontniPlanStGridFormatted
    {

        #region Properities

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ID_KontniPlanSt.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ID_KontniPlanSt.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.ID_KontniPlanSt.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ID_KontniPlanSt.Sortable)]
        public long ID_KontniPlanSt { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ID_KontniPlan.DisplayName)]
        [ScaffoldColumn(false)]
        [JqGridColumnSearchable(false)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Right)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.ID_KontniPlan.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ID_KontniPlan.Sortable)]
        public long ID_KontniPlan { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KontniPlanSt.Konto.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSt.Konto.Required)]
        [DisplayName(AtributClass.KontniPlanSt.Konto.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.Konto.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.Konto.Sortable)]
        public string Konto { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KontniPlanSt.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSt.Naziv.Required)]
        [DisplayName(AtributClass.KontniPlanSt.Naziv.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.Naziv.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.Naziv.Sortable)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KontniPlanSt.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSt.NazivKr.Required)]
        [DisplayName(AtributClass.KontniPlanSt.NazivKr.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.NazivKr.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.NazivKr.Sortable)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KontniPlanSt.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanSt.Kratica.Required)]
        [DisplayName(AtributClass.KontniPlanSt.Kratica.DisplayName)]
        [JqGridColumnSearchable(true, SearchType = JqGridColumnSearchTypes.Text, SearchOperators = JqGridSearchOperators.TextOperators)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Left)]
        [JqGridColumnFormatter(AtributClass.KontniPlanSt.Kratica.Formatter)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.Kratica.Sortable)]
        public string Kratica { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.SaldoKonti.Required)]
        [DisplayName(AtributClass.KontniPlanSt.SaldoKonti.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.SaldoKonti.Sortable)]
        public bool SaldoKonti { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.SubjektDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.SubjektDopusteno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.SubjektDopusteno.Sortable)]
        public bool SubjektDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.SubjektObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.SubjektObavezno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.SubjektObavezno.Sortable)]
        public bool SubjektObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ZapisDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ZapisDopusteno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ZapisDopusteno.Sortable)]
        public bool ZapisDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ZapisObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ZapisObavezno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ZapisObavezno.Sortable)]
        public bool ZapisObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ObjektDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ObjektDopusteno.DisplayName)]
        [JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ObjektDopusteno.Sortable)]
        public bool ObjektDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.ObjektObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.ObjektObavezno.DisplayName)]
        [JqGridColumnSearchable(false, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.ObjektObavezno.Sortable)]
        public bool ObjektObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.DavanjeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.DavanjeDopusteno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.DavanjeDopusteno.Sortable)]
        public bool DavanjeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.DavanjeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.DavanjeObavezno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.DavanjeObavezno.Sortable)]
        public bool DavanjeObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.DugujeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.DugujeDopusteno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.DugujeDopusteno.Sortable)]
        public bool DugujeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.DugujeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.DugujeObavezno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.DugujeObavezno.Sortable)]
        public bool DugujeObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.PotrazujeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.PotrazujeDopusteno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.PotrazujeDopusteno.Sortable)]
        public bool PotrazujeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanSt.PotrazujeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanSt.PotrazujeObavezno.DisplayName)]
        [JqGridColumnSearchable(true, KeyWord.FilterGridFormat.BoolFilterDaNe, KeyWord.KontrolerFilteriGridFormat.Filter, SearchType = JqGridColumnSearchTypes.Select, SearchOperators = JqGridSearchOperators.Eq | JqGridSearchOperators.Ne)]
        [JqGridColumnLayout(Alignment = JqGridAlignments.Center)]
        [JqGridColumnFormatter(JqGridColumnPredefinedFormatters.CheckBox)]
        [JqGridColumnSortable(true, Index = AtributClass.KontniPlanSt.PotrazujeObavezno.Sortable)]
        public bool PotrazujeObavezno { get; set; }

        #endregion

        #region Constructor

        public KontniPlanStGridFormatted()
        { }

        public KontniPlanStGridFormatted(Model.Data.View.KontniPlanSt gridformated)
        {
            this.ID_KontniPlanSt = gridformated.ID_KontniPlanSt;
            this.ID_KontniPlan = gridformated.ID_KontniPlan;
            this.Konto = gridformated.Konto;
            this.Naziv = gridformated.Naziv;
            this.NazivKr = gridformated.NazivKr;
            this.Kratica = gridformated.Kratica;
            this.SaldoKonti = gridformated.SaldoKonti;
            this.ZapisDopusteno = gridformated.ZapisDopusteno;
            this.ZapisObavezno = gridformated.ZapisObavezno;
            this.SubjektDopusteno = gridformated.SubjektDopusteno;
            this.SubjektObavezno = gridformated.SubjektObavezno;
            this.ObjektDopusteno = gridformated.ObjektDopusteno;
            this.ObjektObavezno = gridformated.ObjektObavezno;
            this.DavanjeDopusteno = gridformated.DavanjeDopusteno;
            this.DavanjeObavezno = gridformated.DavanjeObavezno;
            this.DugujeDopusteno = gridformated.DugujeDopusteno;
            this.DugujeObavezno = gridformated.DugujeObavezno;
            this.PotrazujeDopusteno = gridformated.PotrazujeDopusteno;
            this.PotrazujeObavezno = gridformated.PotrazujeObavezno;
        }

        #endregion
    }
}
