
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


    public partial class DokumentVrDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.ID_DokumentVr.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.ID_DokumentVr.DisplayName)]
        public long ID_DokumentVr { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.DokumentVrDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.DokumentVrDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Naziv.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.DokumentVrDetalj.NazivKr.StringLength)]
        //[Required(ErrorMessage = AtributClass.DokumentVrDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.DokumentVrDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.DokumentVrDetalj.Kratica.StringLength)]
        //[Required(ErrorMessage = AtributClass.DokumentVrDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.DokumentVrDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.DokumentVrDetalj.Opis.StringLength)]
        //[Required(ErrorMessage = AtributClass.DokumentVrDetalj.Opis.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.DokumentVrDetalj.Opis.DisplayName)]
        public string Opis { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.IDDokumentGr.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.IDDokumentGr.DisplayName)]
        public int IDDokumentGr { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Obrocni.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Obrocni.DisplayName)]
        public bool Obrocni { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Jednokratni.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Jednokratni.DisplayName)]
        public bool Jednokratni { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Kupac.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Kupac.DisplayName)]
        public bool Kupac { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Partner.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Partner.DisplayName)]
        public bool Partner { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Ugovor.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Ugovor.DisplayName)]
        public bool Ugovor { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Faktura.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Faktura.DisplayName)]
        public bool Faktura { get; set; }

        [Required(ErrorMessage = AtributClass.DokumentVrDetalj.Nalog.Required)]
        [DisplayName(AtributClass.DokumentVrDetalj.Nalog.DisplayName)]
        public bool Nalog { get; set; }

        // Rucno dodana polja

        public int ObrocniJednokratni { get; set; }

        public int? KupacPartner { get; set; }

        public int? UgovorFakturaNalog { get; set; }



        #endregion

        #region Constructor

        public DokumentVrDetaljFormFormatted()
        { }

        public DokumentVrDetaljFormFormatted(Model.Data.View.DokumentVrDetalj formformated)
        {
            this.ID_DokumentVr = formformated.ID_DokumentVr;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
            this.Opis = formformated.Opis;
            this.IDDokumentGr = formformated.IDDokumentGr;
            this.Obrocni = formformated.Obrocni;
            this.Jednokratni = formformated.Jednokratni;
            this.Kupac = formformated.Kupac;
            this.Partner = formformated.Partner;
            this.Ugovor = formformated.Ugovor;
            this.Faktura = formformated.Faktura;
            this.Nalog = formformated.Nalog;
        }


        #endregion

    }
}
