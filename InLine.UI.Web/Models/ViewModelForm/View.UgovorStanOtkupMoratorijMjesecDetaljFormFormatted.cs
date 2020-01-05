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

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{
    public partial class UgovorStanOtkupMoratorijMjesecDetaljFormFormatted
    {
        #region Properities


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.OsobaUpdate.DisplayName)]
        public string OsobaUpdate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.DatumUpdate.DisplayName)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.OsobaInsert.DisplayName)]
        public string OsobaInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.DatumInsert.DisplayName)]
        public Nullable<System.DateTime> DatumInsert { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.BrojMoratorij.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.BrojMoratorij.DisplayName)]
        public int BrojMoratorij { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.BrojUgovor.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.BrojUgovor.DisplayName)]
        public int BrojUgovor { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.Mjesec.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.Mjesec.DisplayName)]
        public int Mjesec { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.Godina.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.Godina.DisplayName)]
        public int Godina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.ID_UgovorStanOtkupMoratorij.DisplayName)]
        public Nullable<long> ID_UgovorStanOtkupMoratorij { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.ID_UgovorStanOtkupMoratorijMjesec.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupMoratorijMjesecDetalj.ID_UgovorStanOtkupMoratorijMjesec.DisplayName)]
        public long ID_UgovorStanOtkupMoratorijMjesec { get; set; }

        #endregion

        #region Constructor

        public UgovorStanOtkupMoratorijMjesecDetaljFormFormatted()
        { }

        public UgovorStanOtkupMoratorijMjesecDetaljFormFormatted(Model.Data.View.UgovorStanOtkupMoratorijMjesecDetalj formformated)
        {
            this.OsobaUpdate = formformated.OsobaUpdate;
            this.DatumUpdate = formformated.DatumUpdate;
            this.OsobaInsert = formformated.OsobaInsert;
            this.DatumInsert = formformated.DatumInsert;
            this.BrojMoratorij = formformated.BrojMoratorij;
            this.BrojUgovor = formformated.BrojUgovor;
            this.Mjesec = formformated.Mjesec;
            this.Godina = formformated.Godina;
            this.ID_UgovorStanOtkupMoratorij = formformated.ID_UgovorStanOtkupMoratorij;
            this.ID_UgovorStanOtkupMoratorijMjesec = formformated.ID_UgovorStanOtkupMoratorijMjesec;
        }

        /*
            mymodel.OsobaUpdate = model.OsobaUpdate;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.BrojMoratorij = model.BrojMoratorij;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.Mjesec = model.Mjesec;
            mymodel.Godina = model.Godina;
            mymodel.ID_UgovorStanOtkupMoratorij = model.ID_UgovorStanOtkupMoratorij;
            mymodel.ID_UgovorStanOtkupMoratorijMjesec = model.ID_UgovorStanOtkupMoratorijMjesec;
    		
        */

        #endregion

    }
}