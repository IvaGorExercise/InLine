
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


    public partial class KriterijStDetaljFormFormatted
    {
        #region Properities


        [StringLength(10, ErrorMessage = AtributClass.KriterijStDetalj.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStDetalj.Kratica.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KriterijStDetalj.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStDetalj.NazivKr.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KriterijStDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStDetalj.Naziv.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStDetalj.ID_Kriterij.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.ID_Kriterij.DisplayName)]
        public long ID_Kriterij { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KriterijStDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStDetalj.ID_KriterijSt.Required)]
        [DisplayName(AtributClass.KriterijStDetalj.ID_KriterijSt.DisplayName)]
        public long ID_KriterijSt { get; set; }

        #endregion

        #region Constructor

        public KriterijStDetaljFormFormatted()
        { }

        public KriterijStDetaljFormFormatted(Model.Data.View.KriterijStDetalj formformated)
        {
            this.Kratica = formformated.Kratica;
            this.NazivKr = formformated.NazivKr;
            this.Naziv = formformated.Naziv;
            this.ID_Kriterij = formformated.ID_Kriterij;
            this.Oznaka = formformated.Oznaka;
            this.ID_KriterijSt = formformated.ID_KriterijSt;
        }


        #endregion

    }
}
