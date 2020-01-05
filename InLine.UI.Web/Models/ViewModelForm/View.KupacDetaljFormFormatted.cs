

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


    public partial class KupacDetaljFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.KupacDetalj.ID_Kupac.Required)]
        [DisplayName(AtributClass.KupacDetalj.ID_Kupac.DisplayName)]
        public long ID_Kupac { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.KupacDetalj.Oznaka.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.Oznaka.DisplayName)]
        public string Oznaka { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Naziv.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.Naziv.DisplayName)]
        public string Naziv { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(13, ErrorMessage = AtributClass.KupacDetalj.JMBG.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.JMBG.DisplayName)]
        public string JMBG { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Ulica.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.Ulica.DisplayName)]
        public string Ulica { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.KupacDetalj.KucniBroj.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.KucniBroj.DisplayName)]
        public string KucniBroj { get; set; }


        [StringLength(2, ErrorMessage = AtributClass.KupacDetalj.KucniBrojDodatak.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.KucniBrojDodatak.DisplayName)]
        public string KucniBrojDodatak { get; set; }


        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(11, ErrorMessage = AtributClass.KupacDetalj.OIB.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.OIB.DisplayName)]
        public string OIB { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Posta.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.Posta.DisplayName)]
        public string Posta { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(5, ErrorMessage = AtributClass.KupacDetalj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.KupacDetalj.PostanskiBroj.DisplayName)]
        public string PostanskiBroj { get; set; }

        [DisplayName(AtributClass.KupacDetalj.ID_Posta.DisplayName)]
        public Nullable<long> ID_Posta { get; set; }

        [DisplayName(AtributClass.KupacDetalj.ID_Subjekt.DisplayName)]
        public Nullable<long> ID_Subjekt { get; set; }





        // Rucno dodana pomocna polja
        public long ID_UgovorStanOtkupKupac { get; set; }
        public bool Nositelj { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Oznaka.StringLength)]
        public String ImeKupac { get; set; }


        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = AtributClass.KupacDetalj.Oznaka.StringLength)]
        public String PrezimeKupac { get; set; }

        public string OznakaKupac
        {
            get { return Oznaka; }
            set { Oznaka = value; }
        }


        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(13, ErrorMessage = AtributClass.KupacDetalj.JMBG.StringLength)]
        public string JMBGKupac
        {
            get { return JMBG; }
            set { JMBG = value; }
        }


        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(11, ErrorMessage = AtributClass.KupacDetalj.JMBG.StringLength)]
        public string OIBKupac
        {
            get { return OIB; }
            set { OIB = value; }
        }


        [Required(ErrorMessage = "*")]
        public string UlicaKupac
        {
            get { return Ulica; }
            set { Ulica = value; }
        }

        public string KucniBrojKupac
        {
            get { return KucniBroj; }
            set { KucniBroj = value; }
        }

        public string KucniBrojDodatakKupac
        {
            get { return KucniBrojDodatak; }
            set { KucniBrojDodatak = value; }
        }

        [Required(ErrorMessage = "*")]
        public string PostaKupac
        {
            get { return Posta; }
            set { Posta = value; }
        }

        public string PostanskiBrojKupac
        {
            get { return PostanskiBroj; }
            set { PostanskiBroj = value; }
        }


        public Nullable<long> ID_PostaKupac
        {
            get { return ID_Posta; }
            set { ID_Posta = value; }
        }
      

     

        #endregion

        #region Constructor

        public KupacDetaljFormFormatted()
        { }

        public KupacDetaljFormFormatted(Model.Data.View.KupacDetalj formformated)
        {
            this.ID_Kupac = formformated.ID_Kupac;
            this.Oznaka = formformated.Oznaka;
            this.Naziv = formformated.Naziv;
            this.JMBG = formformated.JMBG;
            this.Ulica = formformated.Ulica;
            this.KucniBroj = formformated.KucniBroj;
            this.KucniBrojDodatak = formformated.KucniBrojDodatak;
            this.OIB = formformated.OIB;
            this.Posta = formformated.Posta;
            this.PostanskiBroj = formformated.PostanskiBroj;
            this.ID_Posta = formformated.ID_Posta;
            this.ID_Subjekt = formformated.ID_Subjekt;

        }

        #endregion

    }
}
