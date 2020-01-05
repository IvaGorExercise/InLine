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


namespace InLine.UI.Web.T4.FormFormattedTemplate
{

    public partial class UgovorStanOtkupObrokUplataFormFormatted
    {
        #region Properities

        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokUplata.DisplayName)]
        public long ID_UgovorStanOtkupObrokUplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrok.DisplayName)]
        public Nullable<long> ID_UgovorStanOtkupObrok { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.Datum.DisplayName)]
        public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataUplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosZateznaKamataUplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosValuta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosValutaUgovor.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosValutaUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosTecajnaRazlika.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosTecajnaRazlika { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataPrije.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosZateznaKamataPrije { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKredit { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKreditRevalorizacija { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKamataRevalorizacija { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKreditMoratorij.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKreditMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKamataMoratorij.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKamataMoratorij { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKreditMoratorijRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKreditMoratorijRevalorizacija { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosKamataMoratorijRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosKamataMoratorijRevalorizacija { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosJednokratno { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosUcesce { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosPreplata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosPreplata { get; set; }


        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.IDValuta.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.IDValuta.Required)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IDValuta.DisplayName)]
        public string IDValuta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.TemeljnicaGodina.DisplayName)]
        public Nullable<int> TemeljnicaGodina { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.TemeljnicaVrsta.DisplayName)]
        public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.TemeljnicaBroj.DisplayName)]
        public Nullable<int> TemeljnicaBroj { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.DokumentGrupa.DisplayName)]
        public Nullable<int> DokumentGrupa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.DokumentVrsta.DisplayName)]
        public Nullable<int> DokumentVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.OsnovicaZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> OsnovicaZateznaKamata { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.DatumZateznaKamata.DisplayName)]
        public Nullable<System.DateTime> DatumZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosZateznaKamataDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosZateznaKamataDugOstatak { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.IznosObrokDugOstatak.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> IznosObrokDugOstatak { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojUgovor.DisplayName)]
        public Nullable<int> BrojUgovor { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojAneks.DisplayName)]
        public Nullable<int> BrojAneks { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojStorno.DisplayName)]
        public Nullable<int> BrojStorno { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojObrok.DisplayName)]
        public Nullable<int> BrojObrok { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_UgovorStanOtkupObrokZateznaKamata.DisplayName)]
        public Nullable<long> ID_UgovorStanOtkupObrokZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojObrokZateznaKamata.DisplayName)]
        public Nullable<int> BrojObrokZateznaKamata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.BrojPreplata.DisplayName)]
        public Nullable<int> BrojPreplata { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_Racun.DisplayName)]
        public Nullable<long> ID_Racun { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_PlacanjeVr.DisplayName)]
        public Nullable<long> ID_PlacanjeVr { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_Temeljnica.DisplayName)]
        public Nullable<long> ID_Temeljnica { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.DatumInsert.DisplayName)]
        public Nullable<System.DateTime> DatumInsert { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.OsobaInsert.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.OsobaInsert.DisplayName)]
        public string OsobaInsert { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.DatumUpdate.DisplayName)]
        public Nullable<System.DateTime> DatumUpdate { get; set; }


        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupObrokUplata.OsobaUpdate.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.OsobaUpdate.DisplayName)]
        public string OsobaUpdate { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_OsobaInsert.DisplayName)]
        public Nullable<long> ID_OsobaInsert { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.ID_OsobaUpdate.DisplayName)]
        public Nullable<long> ID_OsobaUpdate { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupObrokUplata.NeZateznaKamata.DisplayName)]
        public Nullable<bool> NeZateznaKamata { get; set; }

        #endregion



        #region Constructor

        public UgovorStanOtkupObrokUplataFormFormatted()
        { }

        public UgovorStanOtkupObrokUplataFormFormatted(Model.Data.UgovorStanOtkupObrokUplata formformated)
        {
            this.ID_UgovorStanOtkupObrokUplata = formformated.ID_UgovorStanOtkupObrokUplata;
            this.ID_UgovorStanOtkupObrok = formformated.ID_UgovorStanOtkupObrok;
            this.Datum = formformated.Datum;
            this.IznosZateznaKamataUplata = formformated.IznosZateznaKamataUplata;
            this.IznosValuta = formformated.IznosValuta;
            this.IznosValutaUgovor = formformated.IznosValutaUgovor;
            this.IznosTecajnaRazlika = formformated.IznosTecajnaRazlika;
            this.IznosZateznaKamataPrije = formformated.IznosZateznaKamataPrije;
            this.IznosKredit = formformated.IznosKredit;
            this.IznosKamata = formformated.IznosKamata;
            this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
            this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
            this.IznosKreditMoratorij = formformated.IznosKreditMoratorij;
            this.IznosKamataMoratorij = formformated.IznosKamataMoratorij;
            this.IznosKreditMoratorijRevalorizacija = formformated.IznosKreditMoratorijRevalorizacija;
            this.IznosKamataMoratorijRevalorizacija = formformated.IznosKamataMoratorijRevalorizacija;
            this.IznosJednokratno = formformated.IznosJednokratno;
            this.IznosUcesce = formformated.IznosUcesce;
            this.IznosPreplata = formformated.IznosPreplata;
            this.IDValuta = formformated.IDValuta;
            this.TemeljnicaGodina = formformated.TemeljnicaGodina;
            this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
            this.TemeljnicaBroj = formformated.TemeljnicaBroj;
            this.DokumentGrupa = formformated.DokumentGrupa;
            this.DokumentVrsta = formformated.DokumentVrsta;
            this.OsnovicaZateznaKamata = formformated.OsnovicaZateznaKamata;
            this.DatumZateznaKamata = formformated.DatumZateznaKamata;
            this.IznosZateznaKamata = formformated.IznosZateznaKamata;
            this.IznosZateznaKamataDugOstatak = formformated.IznosZateznaKamataDugOstatak;
            this.IznosObrokDugOstatak = formformated.IznosObrokDugOstatak;
            this.BrojUgovor = formformated.BrojUgovor;
            this.BrojAneks = formformated.BrojAneks;
            this.BrojStorno = formformated.BrojStorno;
            this.BrojObrok = formformated.BrojObrok;
            this.ID_UgovorStanOtkupObrokZateznaKamata = formformated.ID_UgovorStanOtkupObrokZateznaKamata;
            this.BrojObrokZateznaKamata = formformated.BrojObrokZateznaKamata;
            this.BrojPreplata = formformated.BrojPreplata;
            this.ID_Racun = formformated.ID_Racun;
            this.ID_PlacanjeVr = formformated.ID_PlacanjeVr;
            this.ID_Temeljnica = formformated.ID_Temeljnica;
            this.DatumInsert = formformated.DatumInsert;
            this.OsobaInsert = formformated.OsobaInsert;
            this.DatumUpdate = formformated.DatumUpdate;
            this.OsobaUpdate = formformated.OsobaUpdate;
            this.ID_OsobaInsert = formformated.ID_OsobaInsert;
            this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
            this.NeZateznaKamata = formformated.NeZateznaKamata;

        }

        /*
            mymodel.ID_UgovorStanOtkupObrokUplata = model.ID_UgovorStanOtkupObrokUplata;
            mymodel.ID_UgovorStanOtkupObrok = model.ID_UgovorStanOtkupObrok;
            mymodel.Datum = model.Datum;
            mymodel.IznosZateznaKamataUplata = model.IznosZateznaKamataUplata;
            mymodel.IznosValuta = model.IznosValuta;
            mymodel.IznosValutaUgovor = model.IznosValutaUgovor;
            mymodel.IznosTecajnaRazlika = model.IznosTecajnaRazlika;
            mymodel.IznosZateznaKamataPrije = model.IznosZateznaKamataPrije;
            mymodel.IznosKredit = model.IznosKredit;
            mymodel.IznosKamata = model.IznosKamata;
            mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
            mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
            mymodel.IznosKreditMoratorij = model.IznosKreditMoratorij;
            mymodel.IznosKamataMoratorij = model.IznosKamataMoratorij;
            mymodel.IznosKreditMoratorijRevalorizacija = model.IznosKreditMoratorijRevalorizacija;
            mymodel.IznosKamataMoratorijRevalorizacija = model.IznosKamataMoratorijRevalorizacija;
            mymodel.IznosJednokratno = model.IznosJednokratno;
            mymodel.IznosUcesce = model.IznosUcesce;
            mymodel.IznosPreplata = model.IznosPreplata;
            mymodel.IDValuta = model.IDValuta;
            mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
            mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
            mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
            mymodel.DokumentGrupa = model.DokumentGrupa;
            mymodel.DokumentVrsta = model.DokumentVrsta;
            mymodel.OsnovicaZateznaKamata = model.OsnovicaZateznaKamata;
            mymodel.DatumZateznaKamata = model.DatumZateznaKamata;
            mymodel.IznosZateznaKamata = model.IznosZateznaKamata;
            mymodel.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
            mymodel.IznosObrokDugOstatak = model.IznosObrokDugOstatak;
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.BrojAneks = model.BrojAneks;
            mymodel.BrojStorno = model.BrojStorno;
            mymodel.BrojObrok = model.BrojObrok;
            mymodel.ID_UgovorStanOtkupObrokZateznaKamata = model.ID_UgovorStanOtkupObrokZateznaKamata;
            mymodel.BrojObrokZateznaKamata = model.BrojObrokZateznaKamata;
            mymodel.BrojPreplata = model.BrojPreplata;
            mymodel.ID_Racun = model.ID_Racun;
            mymodel.ID_PlacanjeVr = model.ID_PlacanjeVr;
            mymodel.ID_Temeljnica = model.ID_Temeljnica;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.OsobaUpdate = model.OsobaUpdate;
            mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
            mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
            mymodel.NeZateznaKamata = model.NeZateznaKamata;
    		
        */

        #endregion

    }
}
