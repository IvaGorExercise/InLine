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


    public partial class UgovorStanOtkupMoratorijDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij.DisplayName)]
        public long ID_UgovorStanOtkupMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkup.DisplayName)]
        public Nullable<long> ID_UgovorStanOtkup { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.Datum.DisplayName)]
        public Nullable<System.DateTime> Datum { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojMoratorij.DisplayName)]
        public int BrojMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.BrojUgovor.DisplayName)]
        public Nullable<int> BrojUgovor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumInsert.DisplayName)]
        public Nullable<System.DateTime> DatumInsert { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaInsert.DisplayName)]
        public string OsobaInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.DatumUpdate.DisplayName)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijDetalj.OsobaUpdate.DisplayName)]
        public string OsobaUpdate { get; set; }


        // rucno dodana polja
        public Nullable<System.DateTime> MoratorijDatum
        {
            get { return Datum; }
            set { Datum = value; }
        }

        #endregion

        #region Constructor

        public UgovorStanOtkupMoratorijDetaljFormFormatted()
        { }

        public UgovorStanOtkupMoratorijDetaljFormFormatted(Model.Data.View.UgovorStanOtkupMoratorijDetalj formformated)
        {
            this.ID_UgovorStanOtkupMoratorij = formformated.ID_UgovorStanOtkupMoratorij;
            this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
            this.Datum = formformated.Datum;
            this.BrojMoratorij = formformated.BrojMoratorij;
            this.BrojUgovor = formformated.BrojUgovor;
            this.DatumInsert = formformated.DatumInsert;
            this.OsobaInsert = formformated.OsobaInsert;
            this.DatumUpdate = formformated.DatumUpdate;
            this.OsobaUpdate = formformated.OsobaUpdate;
        }

        #endregion

    }
}
