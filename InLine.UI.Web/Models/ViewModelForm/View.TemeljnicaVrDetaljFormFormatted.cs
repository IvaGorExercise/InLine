
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


    public partial class TemeljnicaVrDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.ID_TemeljnicaVr.Required)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.ID_TemeljnicaVr.DisplayName)]
        public long ID_TemeljnicaVr { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.ID_GlavnaKnjiga.Required)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.ID_GlavnaKnjiga.DisplayName)]
        public long ID_GlavnaKnjiga { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.TemeljnicaVrDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.Naziv.Required)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.TemeljnicaVrDetalj.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.IDValuta.Required)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.Tecaj.Required)]
        [Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.Tecaj.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal Tecaj { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.TemeljnicaVrDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(20, ErrorMessage = AtributClass.TemeljnicaVrDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.TemeljnicaVrDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.TemeljnicaVrDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.TemeljnicaVrDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }

        [DisplayName(AtributClass.TemeljnicaVrDetalj.Opis.DisplayName)]
        public string Opis { get; set; }

        #endregion

        #region Constructor

        public TemeljnicaVrDetaljFormFormatted()
        { }

        public TemeljnicaVrDetaljFormFormatted(Model.Data.View.TemeljnicaVrDetalj formformated)
        {
            this.ID_TemeljnicaVr = formformated.ID_TemeljnicaVr;
            this.ID_GlavnaKnjiga = formformated.ID_GlavnaKnjiga;
            this.Naziv = formformated.Naziv;
            this.IDValuta = formformated.IDValuta;
            this.Tecaj = formformated.Tecaj;
            this.Kratica = formformated.Kratica;
            this.Oznaka = formformated.Oznaka;
            this.NazivKr = formformated.NazivKr;
            this.Opis = formformated.Opis;
        }

        #endregion

    }
}
