﻿namespace InLine.UI.Web.T4.FormFormattedTemplate.View
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


    public partial class UgovorStanOtkupKupacDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.ID_Kupac.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.ID_Kupac.DisplayName)]
        public long ID_Kupac { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.Oznaka.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.JMBG.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.JMBG.DisplayName)]
        public string JMBG { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.Ulica.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.Ulica.DisplayName)]
        public string Ulica { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.KucniBroj.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.KucniBroj.DisplayName)]
        public string KucniBroj { get; set; }


        [StringLength(2, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.KucniBrojDodatak.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.KucniBrojDodatak.DisplayName)]
        public string KucniBrojDodatak { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.PostanskiBroj.DisplayName)]
        public string PostanskiBroj { get; set; }


        [StringLength(13, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.OIB.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.OIB.DisplayName)]
        public string OIB { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.Posta.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.Posta.DisplayName)]
        public string Posta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.ID_Posta.DisplayName)]
        public Nullable<long> ID_Posta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.ID_Subjekt.DisplayName)]
        public Nullable<long> ID_Subjekt { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.ID_UgovorStanOtkupKupac.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.ID_UgovorStanOtkupKupac.DisplayName)]
        public long ID_UgovorStanOtkupKupac { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.Nositelj.DisplayName)]
        public Nullable<bool> Nositelj { get; set; }

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupKupacDetalj.ID_UgovorStanOtkup.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupKupacDetalj.ID_UgovorStanOtkup.DisplayName)]
        public long ID_UgovorStanOtkup { get; set; }


        // Rucno dodana pomocna polja


        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Oznaka.StringLength)]
        public String ImeUgovorStanOtkupKupac { get; set; }


        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Oznaka.StringLength)]
        public String PrezimeUgovorStanOtkupKupac { get; set; }

        #endregion

        #region Constructor

        public UgovorStanOtkupKupacDetaljFormFormatted()
        { }

        public UgovorStanOtkupKupacDetaljFormFormatted(Model.Data.View.UgovorStanOtkupKupacDetalj formformated)
        {
            this.ID_Kupac = formformated.ID_Kupac;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.JMBG = formformated.JMBG;
            this.Ulica = formformated.Ulica;
            this.KucniBroj = formformated.KucniBroj;
            this.KucniBrojDodatak = formformated.KucniBrojDodatak;
            this.PostanskiBroj = formformated.PostanskiBroj;
            this.OIB = formformated.OIB;
            this.Posta = formformated.Posta;
            this.ID_Posta = formformated.ID_Posta;
            this.ID_Subjekt = formformated.ID_Subjekt;
            this.ID_UgovorStanOtkupKupac = formformated.ID_UgovorStanOtkupKupac;
            this.Nositelj = formformated.Nositelj;
            this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
        }

        #endregion

    }
}
