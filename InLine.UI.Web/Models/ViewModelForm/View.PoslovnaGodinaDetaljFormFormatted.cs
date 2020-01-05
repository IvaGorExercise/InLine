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


    public partial class PoslovnaGodinaDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.ID_PoslovnaGodina.DisplayName)]
        public long ID_PoslovnaGodina { get; set; }

        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.ID_PoslovniSubjekt.DisplayName)]
        public long ID_PoslovniSubjekt { get; set; }

        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.Godina.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.Godina.DisplayName)]
        public int Godina { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.DatumOd.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.DatumOd.DisplayName)]
        public System.DateTime DatumOd { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.DatumDo.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.DatumDo.DisplayName)]
        public System.DateTime DatumDo { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.PoslovnaGodinaDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.PoslovnaGodinaDetalj.IDValuta.Required)]
        [DisplayName(AtributClass.PoslovnaGodinaDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        #endregion

        #region Constructor

        public PoslovnaGodinaDetaljFormFormatted()
        { }

        public PoslovnaGodinaDetaljFormFormatted(Model.Data.View.PoslovnaGodinaDetalj formformated)
        {
            this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
            this.ID_PoslovniSubjekt = formformated.ID_PoslovniSubjekt;
            this.Godina = formformated.Godina;
            this.DatumOd = formformated.DatumOd;
            this.DatumDo = formformated.DatumDo;
            this.IDValuta = formformated.IDValuta;
        }

        #endregion

    }
}
