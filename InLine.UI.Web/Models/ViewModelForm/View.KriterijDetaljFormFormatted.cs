
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


    public partial class KriterijDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KriterijDetalj.RedniBroj.Required)]
        [DisplayName(AtributClass.KriterijDetalj.RedniBroj.DisplayName)]
        public int RedniBroj { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KriterijDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.KriterijDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KriterijDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KriterijDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijDetalj.Naziv.Required)]
        [DisplayName(AtributClass.KriterijDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KriterijDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.KriterijDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijDetalj.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KriterijDetalj.ID_KontniPlan.DisplayName)]
        public long ID_KontniPlan { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KriterijDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.KriterijDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KriterijDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijDetalj.ID_Kriterij.Required)]
        [DisplayName(AtributClass.KriterijDetalj.ID_Kriterij.DisplayName)]
        public long ID_Kriterij { get; set; }


        //Rucno dodano pomocno polje
        public int KriterijCount { get; set; }



        #endregion

        #region Constructor

        public KriterijDetaljFormFormatted()
        { }

        public KriterijDetaljFormFormatted(Model.Data.View.KriterijDetalj formformated)
        {
            this.RedniBroj = formformated.RedniBroj;
            this.Kratica = formformated.Kratica;
            this.Naziv = formformated.Naziv;
            this.Oznaka = formformated.Oznaka;
            this.ID_KontniPlan = formformated.ID_KontniPlan;
            this.NazivKr = formformated.NazivKr;
            this.ID_Kriterij = formformated.ID_Kriterij;
        }

        #endregion

    }
}
