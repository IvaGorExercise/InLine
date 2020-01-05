
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


    public partial class StanDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.StanDetalj.ID_Stan.Required)]
        [DisplayName(AtributClass.StanDetalj.ID_Stan.DisplayName)]
        public long ID_Stan { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Objekt.DisplayName)]
        public Nullable<long> ID_Objekt { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Oznaka.Required)]
        [DisplayName(AtributClass.StanDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.StanDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Naziv.Required)]
        [DisplayName(AtributClass.StanDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.NazivKr.Required)]
        [DisplayName(AtributClass.StanDetalj.NazivKr.DisplayName)]
        public string NazivKr { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Kratica.Required)]
        [DisplayName(AtributClass.StanDetalj.Kratica.DisplayName)]
        public string Kratica { get; set; }

        [DisplayName(AtributClass.StanDetalj.Povrsina.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> Povrsina { get; set; }

        [DisplayName(AtributClass.StanDetalj.BrojSoba.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> BrojSoba { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Broj.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Broj.DisplayName)]
        public string Broj { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Ulica.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Ulica.DisplayName)]
        public string Ulica { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBrojDodatak.StringLength)]
        [DisplayName(AtributClass.StanDetalj.KucniBrojDodatak.DisplayName)]
        public string KucniBrojDodatak { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBroj.StringLength)]
        [DisplayName(AtributClass.StanDetalj.KucniBroj.DisplayName)]
        public string KucniBroj { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kat.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Kat.DisplayName)]
        public string Kat { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Zgrada.DisplayName)]
        public Nullable<long> ID_Zgrada { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.Opis.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Opis.DisplayName)]
        public string Opis { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCestica.StringLength)]
        [DisplayName(AtributClass.StanDetalj.KatastarskaCestica.DisplayName)]
        public string KatastarskaCestica { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCesticaOpcina.StringLength)]
        [DisplayName(AtributClass.StanDetalj.KatastarskaCesticaOpcina.DisplayName)]
        public string KatastarskaCesticaOpcina { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Adresa.DisplayName)]
        public Nullable<long> ID_Adresa { get; set; }

        [DisplayName(AtributClass.StanDetalj.BrojUgovor.DisplayName)]
        public Nullable<int> BrojUgovor { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.StanDetalj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.StanDetalj.PostanskiBroj.DisplayName)]
        public string PostanskiBroj { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Posta.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Posta.DisplayName)]
        public string Posta { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Posta.DisplayName)]
        public Nullable<long> ID_Posta { get; set; }

        #endregion

        #region Constructor

        public StanDetaljFormFormatted()
        { }

        public StanDetaljFormFormatted(Model.Data.View.StanDetalj formformated)
        {
            this.ID_Stan = formformated.ID_Stan;
            this.ID_Objekt = formformated.ID_Objekt;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.NazivKr = formformated.NazivKr;
            this.Kratica = formformated.Kratica;
            this.Povrsina = formformated.Povrsina;
            this.BrojSoba = formformated.BrojSoba;
            this.Broj = formformated.Broj;
            this.Ulica = formformated.Ulica;
            this.KucniBrojDodatak = formformated.KucniBrojDodatak;
            this.KucniBroj = formformated.KucniBroj;
            this.Kat = formformated.Kat;
            this.ID_Zgrada = formformated.ID_Zgrada;
            this.Opis = formformated.Opis;
            this.KatastarskaCestica = formformated.KatastarskaCestica;
            this.KatastarskaCesticaOpcina = formformated.KatastarskaCesticaOpcina;
            this.ID_Adresa = formformated.ID_Adresa;
            this.BrojUgovor = formformated.BrojUgovor;
            this.PostanskiBroj = formformated.PostanskiBroj;
            this.Posta = formformated.Posta;
            this.ID_Posta = formformated.ID_Posta;
        }

        #endregion

    }
}
