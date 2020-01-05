
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


    public partial class KontniPlanDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlanDetalj.ID_KontniPlan.DisplayName)]
        public long ID_KontniPlan { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.Required)]
        [DisplayName(AtributClass.KontniPlanDetalj.ID_PoslovnaGodina.DisplayName)]
        [Range(0, long.MaxValue, ErrorMessage = "Odaberite poslovnu godinu")]
        public long ID_PoslovnaGodina { get; set; }

     
        [Required(ErrorMessage = AtributClass.KontniPlanDetalj.AnalitikaOd.Required)]
        [DisplayName(AtributClass.KontniPlanDetalj.AnalitikaOd.DisplayName)]
        [Range(3, 10, ErrorMessage = "Unesite broj veći od 3 i manji od 10")]
        public int AnalitikaOd { get; set; }

        #endregion

        #region Constructor

        public KontniPlanDetaljFormFormatted()
        { }

        public KontniPlanDetaljFormFormatted(Model.Data.View.KontniPlanDetalj formformated)
        {
            this.ID_KontniPlan = formformated.ID_KontniPlan;
            this.ID_PoslovnaGodina = formformated.ID_PoslovnaGodina;
            this.AnalitikaOd = formformated.AnalitikaOd;
        }


        #endregion

    }
}
