
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


    public partial class KriterijStKriterijStKriterijStDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijSt.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijSt.DisplayName)]
        public long ID_KriterijSt { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.ID_Kriterij.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_Kriterij.DisplayName)]
        public long ID_Kriterij { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(20, ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Naziv.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijStKriterijSt.DisplayName)]
        public Nullable<long> ID_KriterijStKriterijSt { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijKSKS.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijKSKS.DisplayName)]
        public long ID_KriterijKSKS { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijStKSKS.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijStKSKS.DisplayName)]
        public long ID_KriterijStKSKS { get; set; }

        [Required(ErrorMessage = AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijStNad.Required)]
        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.ID_KriterijStNad.DisplayName)]
        public long ID_KriterijStNad { get; set; }

        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.Nivo.DisplayName)]
        public Nullable<int> Nivo { get; set; }

        [DisplayName(AtributClass.KriterijStKriterijStKriterijStDetalj.Put.DisplayName)]
        public string Put { get; set; }

        #endregion

        #region Constructor

        public KriterijStKriterijStKriterijStDetaljFormFormatted()
        { }

        public KriterijStKriterijStKriterijStDetaljFormFormatted(Model.Data.View.KriterijStKriterijStKriterijStDetalj formformated)
        {
            this.ID_KriterijSt = formformated.ID_KriterijSt;
            this.ID_Kriterij = formformated.ID_Kriterij;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
            this.ID_KriterijStKriterijSt = formformated.ID_KriterijStKriterijSt;
            this.ID_KriterijKSKS = formformated.ID_KriterijKSKS;
            this.ID_KriterijStKSKS = formformated.ID_KriterijStKSKS;
            this.ID_KriterijStNad = formformated.ID_KriterijStNad;
            this.Nivo = formformated.Nivo;
            this.Put = formformated.Put;
        }

        #endregion

    }
}
