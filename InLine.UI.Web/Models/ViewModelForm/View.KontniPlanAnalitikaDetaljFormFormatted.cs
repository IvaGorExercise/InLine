
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


    public partial class KontniPlanAnalitikaDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.ID_KontniPlanAnalitika.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.ID_KontniPlanAnalitika.DisplayName)]
        public long ID_KontniPlanAnalitika { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.ID_KontniPlan.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.ID_KontniPlan.DisplayName)]
        public long ID_KontniPlan { get; set; }

        [Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.IDZapisVr.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.IDZapisVr.DisplayName)]
        public int IDZapisVr { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Naziv.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.NazivKr.StringLength)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        //[Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.NazivKr.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Kratica.StringLength)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        //[Required(ErrorMessage = AtributClass.KontniPlanAnalitikaDetalj.Kratica.Required)]
        [DisplayName(AtributClass.KontniPlanAnalitikaDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        #endregion

        #region Constructor

        public KontniPlanAnalitikaDetaljFormFormatted()
        { }

        public KontniPlanAnalitikaDetaljFormFormatted(Model.Data.View.KontniPlanAnalitikaDetalj formformated)
        {
            this.ID_KontniPlanAnalitika = formformated.ID_KontniPlanAnalitika;
            this.ID_KontniPlan = formformated.ID_KontniPlan;
            this.IDZapisVr = formformated.IDZapisVr;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
        }

        #endregion

    }
}
