﻿
namespace InLine.UI.Web.T4.FormFormattedTemplate.View
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
    using InLine.UI.Web.T4.FormFormattedTemplate;
    using InLine.UI.Web.Helper;


    public partial class KontniPlanStDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ID_KontniPlanSt.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ID_KontniPlanSt.DisplayName)]
        public long ID_KontniPlanSt { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ID_KontniPlan.DisplayName)]
        public long ID_KontniPlan { get; set; }

        [RegularExpression("^[0-9]*", ErrorMessage = "Samo unos brojeva!")]
        [StringLength(30, ErrorMessage = AtributClass.KontniPlanStDetalj.Konto.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.Konto.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.Konto.DisplayName)]
        public string Konto { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KontniPlanStDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.Naziv.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KontniPlanStDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.KontniPlanStDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KontniPlanStDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KontniPlanStDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.KontniPlanStDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KontniPlanStDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.SaldoKonti.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.SaldoKonti.DisplayName)]
        public bool SaldoKonti { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ZapisDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ZapisDopusteno.DisplayName)]
        public bool ZapisDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ZapisObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ZapisObavezno.DisplayName)]
        public bool ZapisObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.SubjektDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.SubjektDopusteno.DisplayName)]
        public bool SubjektDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.SubjektObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.SubjektObavezno.DisplayName)]
        public bool SubjektObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ObjektDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ObjektDopusteno.DisplayName)]
        public bool ObjektDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.ObjektObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.ObjektObavezno.DisplayName)]
        public bool ObjektObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.DavanjeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.DavanjeDopusteno.DisplayName)]
        public bool DavanjeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.DavanjeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.DavanjeObavezno.DisplayName)]
        public bool DavanjeObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.DugujeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.DugujeDopusteno.DisplayName)]
        public bool DugujeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.DugujeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.DugujeObavezno.DisplayName)]
        public bool DugujeObavezno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.PotrazujeDopusteno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.PotrazujeDopusteno.DisplayName)]
        public bool PotrazujeDopusteno { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanStDetalj.PotrazujeObavezno.Required)]
        [DisplayName(AtributClass.KontniPlanStDetalj.PotrazujeObavezno.DisplayName)]
        public bool PotrazujeObavezno { get; set; }


        // Rucno dodana pomocna polja

        public int AnalitikaOd { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Unos iznosa")]
        public int UnosIznos { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Unos dugovne strane")]
        public int UnosDuguje { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Unos potražne strane")]
        public int UnosPotrazuje { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Unos poslovnog partnera")]
        public int? UnosSubjekt { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Unos dokumenta")]
        public int? UnosZapis { get; set; }

        //[Required(ErrorMessage = "*")]
        //[DisplayName("Unos objekta")]
        //public int? UnosObjekt { get; set; }

        ////[Required(ErrorMessage = "*")]
        //[DisplayName("Unos davanja")]
        //public int? UnosDavanje { get; set; }


        public string KriterijKriterijStList { get; set; }
        public string KriterijObaveznoList { get; set; }
        public int TemeljnicaStImaOvajKonto { get; set; }

        #endregion


        #region Constructor

        public KontniPlanStDetaljFormFormatted()
        { }

        public KontniPlanStDetaljFormFormatted(Model.Data.View.KontniPlanStDetalj formformated)
        {
            this.ID_KontniPlanSt = formformated.ID_KontniPlanSt;
            this.ID_KontniPlan = formformated.ID_KontniPlan;
            this.Konto = formformated.Konto;
            this.Naziv = formformated.Naziv;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
            this.SaldoKonti = formformated.SaldoKonti;
            this.ZapisDopusteno = formformated.ZapisDopusteno;
            this.ZapisObavezno = formformated.ZapisObavezno;
            this.SubjektDopusteno = formformated.SubjektDopusteno;
            this.SubjektObavezno = formformated.SubjektObavezno;
            this.ObjektDopusteno = formformated.ObjektDopusteno;
            this.ObjektObavezno = formformated.ObjektObavezno;
            this.DavanjeDopusteno = formformated.DavanjeDopusteno;
            this.DavanjeObavezno = formformated.DavanjeObavezno;
            this.DugujeDopusteno = formformated.DugujeDopusteno;
            this.DugujeObavezno = formformated.DugujeObavezno;
            this.PotrazujeDopusteno = formformated.PotrazujeDopusteno;
            this.PotrazujeObavezno = formformated.PotrazujeObavezno;
        }


        #endregion

    }
}
