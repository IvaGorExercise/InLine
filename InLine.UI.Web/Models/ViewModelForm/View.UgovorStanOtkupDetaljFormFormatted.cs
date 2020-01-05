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

namespace InLine.UI.Web.T4.FormFormattedTemplate.View
{
    public partial class UgovorStanOtkupDetaljFormFormatted
    {
        
        #region Properities
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.BrojUgovor.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.BrojAneks.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.BrojStorno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_Stan.DisplayName)]
       	public Nullable<long> ID_Stan { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Oznaka.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Oznaka.DisplayName)]
       	public string Oznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Naziv.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Povrsina.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> Povrsina { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.KucniBrojDodatak.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.KucniBrojDodatak.DisplayName)]
       	public string KucniBrojDodatak { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.KucniBroj.DisplayName)]
       	public string KucniBroj { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Kat.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Kat.DisplayName)]
       	public string Kat { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_Zgrada.DisplayName)]
       	public Nullable<long> ID_Zgrada { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.KatastarskaCestica.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.KatastarskaCestica.DisplayName)]
       	public string KatastarskaCestica { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.KatastarskaCesticaOpcina.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.KatastarskaCesticaOpcina.DisplayName)]
       	public string KatastarskaCesticaOpcina { get; set; }
    
    	
        [StringLength(10, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Broj.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojSoba.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarezPovrsina, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> BrojSoba { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Ulica.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Ulica.DisplayName)]
       	public string Ulica { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Opis.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Opis.DisplayName)]
       	public string Opis { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValuta.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValuta.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValuta { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IDValuta.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.TecajDM.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez6Decimala, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajDM { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumDospijeceUcesce.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceUcesce { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumDospijeceJednokratno.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceJednokratno { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumDospijeceObrok.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosUkupnoObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosUkupnoObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUkupnoObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditObrok.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditObrok.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditObrok { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojObrok.DisplayName)]
       	public Nullable<int> BrojObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKredit.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKredit.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosUcesce.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosUcesce.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamata.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamata.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	
        [StringLength(20, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.ZgradaOznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.ZgradaOznaka.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ZgradaOznaka.DisplayName)]
       	public string ZgradaOznaka { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.ZgradaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.ZgradaNaziv.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ZgradaNaziv.DisplayName)]
       	public string ZgradaNaziv { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.ID_UgovorStanOtkup.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_UgovorStanOtkup.DisplayName)]
       	public long ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.UgovorTuzen.DisplayName)]
       	public Nullable<bool> UgovorTuzen { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.NadstojnickiAdaptiran.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.NadstojnickiAdaptiran.DisplayName)]
       	public bool NadstojnickiAdaptiran { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DokumentVrsta.DisplayName)]
       	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DokumentGrupa.DisplayName)]
       	public Nullable<int> DokumentGrupa { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosUcescePlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosUcescePlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcescePlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosUcesceNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosUcesceNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesceNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacijaPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacijaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacijaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacijaNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKreditRevalorizacijaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacija.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacija.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacijaPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacijaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacijaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacijaNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosKamataRevalorizacijaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValutaPlaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValutaPlaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValutaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValutaNeplaceno.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosJednokratnoValutaNeplaceno.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValutaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosTrosakSud.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosTrosakSud.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosTrosakSud { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.IznosPovrat.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.IznosPovrat.DisplayName)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPovrat { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumDospijeceTrosakSud.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceTrosakSud { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.BrojObrokDospjelo.DisplayName)]
       	public Nullable<int> BrojObrokDospjelo { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Pretvorba.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Pretvorba.DisplayName)]
       	public bool Pretvorba { get; set; }
    
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Napomena.Required)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.Napomena.DisplayName)]
       	public string Napomena { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_UgovorStanOtkupStorno.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupStorno { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.NeZateznaKamata.DisplayName)]
       	public Nullable<bool> NeZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.UgovorStanOtkupDetalj.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_DokumentVr.DisplayName)]
        public Nullable<long> ID_DokumentVr { get; set; }


        [DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_Adresa.DisplayName)]
        public Nullable<long> ID_Adresa { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupDetalj.StanBrojUgovora.DisplayName)]
        public Nullable<int> StanBrojUgovora { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupDetalj.PostanskiBroj.DisplayName)]
        public string PostanskiBroj { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.UgovorStanOtkupDetalj.Posta.StringLength)]
        [DisplayName(AtributClass.UgovorStanOtkupDetalj.Posta.DisplayName)]
        public string Posta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupDetalj.ID_Posta.DisplayName)]
        public Nullable<long> ID_Posta { get; set; }

        [DisplayName(AtributClass.UgovorStanOtkupDetalj.ZgradaBrojUgovora.DisplayName)]
        public Nullable<int> ZgradaBrojUgovora { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public UgovorStanOtkupDetaljFormFormatted()
        { }
    	
    	public UgovorStanOtkupDetaljFormFormatted(Model.Data.View.UgovorStanOtkupDetalj formformated)
    	{
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.ID_Stan = formformated.ID_Stan;
    	    this.Oznaka = formformated.Oznaka;
    	    this.Naziv = formformated.Naziv;
    	    this.Povrsina = formformated.Povrsina;
    	    this.KucniBrojDodatak = formformated.KucniBrojDodatak;
    	    this.KucniBroj = formformated.KucniBroj;
    	    this.Kat = formformated.Kat;
    	    this.ID_Zgrada = formformated.ID_Zgrada;
    	    this.KatastarskaCestica = formformated.KatastarskaCestica;
    	    this.KatastarskaCesticaOpcina = formformated.KatastarskaCesticaOpcina;
    	    this.Broj = formformated.Broj;
    	    this.BrojSoba = formformated.BrojSoba;
    	    this.Ulica = formformated.Ulica;
    	    this.Opis = formformated.Opis;
    	    this.IznosJednokratnoValuta = formformated.IznosJednokratnoValuta;
    	    this.IDValuta = formformated.IDValuta;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.TecajDM = formformated.TecajDM;
    	    this.DatumDospijeceUcesce = formformated.DatumDospijeceUcesce;
    	    this.DatumDospijeceJednokratno = formformated.DatumDospijeceJednokratno;
    	    this.DatumDospijeceObrok = formformated.DatumDospijeceObrok;
    	    this.IznosUkupnoObrok = formformated.IznosUkupnoObrok;
    	    this.IznosKamataObrok = formformated.IznosKamataObrok;
    	    this.IznosKreditObrok = formformated.IznosKreditObrok;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.Datum = formformated.Datum;
    	    this.ZgradaOznaka = formformated.ZgradaOznaka;
    	    this.ZgradaNaziv = formformated.ZgradaNaziv;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.UgovorTuzen = formformated.UgovorTuzen;
    	    this.NadstojnickiAdaptiran = formformated.NadstojnickiAdaptiran;
    	    this.DokumentVrsta = formformated.DokumentVrsta;
    	    this.DokumentGrupa = formformated.DokumentGrupa;
    	    this.IznosUcescePlaceno = formformated.IznosUcescePlaceno;
    	    this.IznosUcesceNeplaceno = formformated.IznosUcesceNeplaceno;
    	    this.IznosKreditPlaceno = formformated.IznosKreditPlaceno;
    	    this.IznosKreditNeplaceno = formformated.IznosKreditNeplaceno;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKreditRevalorizacijaPlaceno = formformated.IznosKreditRevalorizacijaPlaceno;
    	    this.IznosKreditRevalorizacijaNeplaceno = formformated.IznosKreditRevalorizacijaNeplaceno;
    	    this.IznosKamataPlaceno = formformated.IznosKamataPlaceno;
    	    this.IznosKamataNeplaceno = formformated.IznosKamataNeplaceno;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKamataRevalorizacijaPlaceno = formformated.IznosKamataRevalorizacijaPlaceno;
    	    this.IznosKamataRevalorizacijaNeplaceno = formformated.IznosKamataRevalorizacijaNeplaceno;
    	    this.IznosJednokratnoPlaceno = formformated.IznosJednokratnoPlaceno;
    	    this.IznosJednokratnoNeplaceno = formformated.IznosJednokratnoNeplaceno;
    	    this.IznosJednokratnoValutaPlaceno = formformated.IznosJednokratnoValutaPlaceno;
    	    this.IznosJednokratnoValutaNeplaceno = formformated.IznosJednokratnoValutaNeplaceno;
    	    this.IznosTrosakSud = formformated.IznosTrosakSud;
    	    this.IznosPovrat = formformated.IznosPovrat;
    	    this.DatumDospijeceTrosakSud = formformated.DatumDospijeceTrosakSud;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.BrojObrokDospjelo = formformated.BrojObrokDospjelo;
    	    this.Pretvorba = formformated.Pretvorba;
    	    this.Napomena = formformated.Napomena;
    	    this.ID_UgovorStanOtkupStorno = formformated.ID_UgovorStanOtkupStorno;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.NeZateznaKamata = formformated.NeZateznaKamata;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
            this.ID_DokumentVr = formformated.ID_DokumentVr;
            this.ID_Adresa = formformated.ID_Adresa;
            this.StanBrojUgovora = formformated.StanBrojUgovora;
            this.PostanskiBroj = formformated.PostanskiBroj;
            this.Posta = formformated.Posta;
            this.ID_Posta = formformated.ID_Posta;
            this.ZgradaBrojUgovora = formformated.ZgradaBrojUgovora;
    	}

        /*
            mymodel.BrojUgovor = model.BrojUgovor;
            mymodel.BrojAneks = model.BrojAneks;
            mymodel.BrojStorno = model.BrojStorno;
            mymodel.ID_Stan = model.ID_Stan;
            mymodel.Oznaka = model.Oznaka;
            mymodel.Naziv = model.Naziv;
            mymodel.Povrsina = model.Povrsina;
            mymodel.KucniBrojDodatak = model.KucniBrojDodatak;
            mymodel.KucniBroj = model.KucniBroj;
            mymodel.Kat = model.Kat;
            mymodel.ID_Zgrada = model.ID_Zgrada;
            mymodel.KatastarskaCestica = model.KatastarskaCestica;
            mymodel.KatastarskaCesticaOpcina = model.KatastarskaCesticaOpcina;
            mymodel.Broj = model.Broj;
            mymodel.BrojSoba = model.BrojSoba;
            mymodel.Ulica = model.Ulica;
            mymodel.Opis = model.Opis;
            mymodel.IznosJednokratnoValuta = model.IznosJednokratnoValuta;
            mymodel.IDValuta = model.IDValuta;
            mymodel.IznosJednokratno = model.IznosJednokratno;
            mymodel.TecajDM = model.TecajDM;
            mymodel.DatumDospijeceUcesce = model.DatumDospijeceUcesce;
            mymodel.DatumDospijeceJednokratno = model.DatumDospijeceJednokratno;
            mymodel.DatumDospijeceObrok = model.DatumDospijeceObrok;
            mymodel.IznosUkupnoObrok = model.IznosUkupnoObrok;
            mymodel.IznosKamataObrok = model.IznosKamataObrok;
            mymodel.IznosKreditObrok = model.IznosKreditObrok;
            mymodel.BrojObrok = model.BrojObrok;
            mymodel.IznosKredit = model.IznosKredit;
            mymodel.IznosUcesce = model.IznosUcesce;
            mymodel.IznosKamata = model.IznosKamata;
            mymodel.Datum = model.Datum;
            mymodel.ZgradaOznaka = model.ZgradaOznaka;
            mymodel.ZgradaNaziv = model.ZgradaNaziv;
            mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            mymodel.UgovorTuzen = model.UgovorTuzen;
            mymodel.NadstojnickiAdaptiran = model.NadstojnickiAdaptiran;
            mymodel.DokumentVrsta = model.DokumentVrsta;
            mymodel.DokumentGrupa = model.DokumentGrupa;
            mymodel.IznosUcescePlaceno = model.IznosUcescePlaceno;
            mymodel.IznosUcesceNeplaceno = model.IznosUcesceNeplaceno;
            mymodel.IznosKreditPlaceno = model.IznosKreditPlaceno;
            mymodel.IznosKreditNeplaceno = model.IznosKreditNeplaceno;
            mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
            mymodel.IznosKreditRevalorizacijaPlaceno = model.IznosKreditRevalorizacijaPlaceno;
            mymodel.IznosKreditRevalorizacijaNeplaceno = model.IznosKreditRevalorizacijaNeplaceno;
            mymodel.IznosKamataPlaceno = model.IznosKamataPlaceno;
            mymodel.IznosKamataNeplaceno = model.IznosKamataNeplaceno;
            mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
            mymodel.IznosKamataRevalorizacijaPlaceno = model.IznosKamataRevalorizacijaPlaceno;
            mymodel.IznosKamataRevalorizacijaNeplaceno = model.IznosKamataRevalorizacijaNeplaceno;
            mymodel.IznosJednokratnoPlaceno = model.IznosJednokratnoPlaceno;
            mymodel.IznosJednokratnoNeplaceno = model.IznosJednokratnoNeplaceno;
            mymodel.IznosJednokratnoValutaPlaceno = model.IznosJednokratnoValutaPlaceno;
            mymodel.IznosJednokratnoValutaNeplaceno = model.IznosJednokratnoValutaNeplaceno;
            mymodel.IznosTrosakSud = model.IznosTrosakSud;
            mymodel.IznosPovrat = model.IznosPovrat;
            mymodel.DatumDospijeceTrosakSud = model.DatumDospijeceTrosakSud;
            mymodel.ID_Subjekt = model.ID_Subjekt;
            mymodel.BrojObrokDospjelo = model.BrojObrokDospjelo;
            mymodel.Pretvorba = model.Pretvorba;
            mymodel.Napomena = model.Napomena;
            mymodel.ID_UgovorStanOtkupStorno = model.ID_UgovorStanOtkupStorno;
            mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
            mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
            mymodel.DatumInsert = model.DatumInsert;
            mymodel.OsobaInsert = model.OsobaInsert;
            mymodel.DatumUpdate = model.DatumUpdate;
            mymodel.OsobaUpdate = model.OsobaUpdate;
            mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
            mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
            mymodel.NeZateznaKamata = model.NeZateznaKamata;
            mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
            mymodel.OtkupNadstojnicki = model.OtkupNadstojnicki;
            mymodel.ID_DokumentVr = model.ID_DokumentVr;
            mymodel.ID_Adresa = model.ID_Adresa;
            mymodel.StanBrojUgovora = model.StanBrojUgovora;
            mymodel.PostanskiBroj = model.PostanskiBroj;
            mymodel.Posta = model.Posta;
            mymodel.ID_Posta = model.ID_Posta;
            mymodel.ZgradaBrojUgovora = model.ZgradaBrojUgovora;
    		
        */

        #endregion

    }

    public partial class UgovorStanOtkupDetaljCustom
    {
        public long ID_UgovorStanOtkup { get; set; }

        [DisplayName("Broj ugovora")]
        [Required(ErrorMessage = AtributClass.UgovorStanOtkupDetalj.BrojUgovor.Required)]
        public int BrojUgovor { get; set; }

        [DisplayName("Kontrolni broj")]
        //[Required(ErrorMessage = "*")]
        public int KontrolniBroj { get; set; }

        [DisplayName("Obročni")]
        public int Obrocni { get; set; }

        [DisplayName("Jednokratni")]
        public int Jednokratni { get; set; }

        [DisplayName("Vrsta ugovora")]
        public int VrstaUgovora { get; set; }

        public Nullable<long> ID_DokumentVr { get; set; }

        [DisplayName("Jednokratni")]
        public string VrstaUgovoraNaziv { get; set; }

        [DisplayName("Nadstojnički ili adaptirani")]
        public bool NadstojnickiIliAdaptirani { get; set; }

        [DisplayName("Tužen po opomeni")]
        public bool TuzeniPoOpomeni { get; set; }

        [DisplayName("Ne računati zateznu kamatu")]
        public bool NeZateznaKamata { get; set; }

        [DisplayName("Iz pretvorbe")]
        public bool IzPretvorbe { get; set; }

        [DisplayName("Datum ugovora")]
        public Nullable<System.DateTime> DatumUgovora { get; set; }

        [DisplayName("Datum dospijeća")]
        public Nullable<System.DateTime> DatumDospijece { get; set; }


        [DisplayName("Tečaj po ugovoru")]
        public Nullable<decimal> TecajPoUgovoru { get; set; }

        [DisplayName("Napomena po ugovoru")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public String Napomena { get; set; }

        [DisplayName("Vrsta dokumenta")]
        public int DokumentVrsta { get; set; }

        public String DokumentVrstaOznaka { get; set; }

        [DisplayName("Učešće/0.obrok")]
        //[RegularExpression(@"^\d+.\d{0,2}$")]
        //[RegularExpression(("^[0-9][\\.\\d]*(,\\d+)?$"), ErrorMessage = "Nije dozvoljen unos slova.")]
        //[Required(ErrorMessage = AtributClass.StanDetalj.Naziv.Required)]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosUcesce { get; set; }

        [DisplayName("Ukupan kredit")]
        //[RegularExpression(@"^\d+.\d{0,2}$")]
        //[RegularExpression(("^[0-9][\\.\\d]*(,\\d+)?$"), ErrorMessage = "Format iznosa nije dobar. Zarez smije biti samo za decimalna mjesta.")]
        //[DataType(DataType.Currency, ErrorMessage = "Nije dozvoljen unos teksta!")]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public decimal IznosKredit { get; set; }

        [DisplayName("Broj obroka")]
        public int BrojObrok { get; set; }

        [DisplayName("Ukupna kamata")]
        public decimal IznosKamata { get; set; }

        [DisplayName("Obrok kredita")]
        public decimal IznosKreditObrok { get; set; }

        [DisplayName("Obrok kamata")]
        public decimal IznosKamataObrok { get; set; }

        [DisplayName("Datum dospijeća učešća")]
        public Nullable<System.DateTime> DatumDospijeceUcesce { get; set; }

        [DisplayName("Obrok ukupno")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public decimal IznosUkupnoObrok { get; set; }

        [DisplayName("Razlika")]
        public decimal Razlika { get; set; }

        [DisplayName("Dospijelo obroka")]
        public int DospijeloObroka { get; set; }

        [DisplayName("Datum dospijeća obroka")]
        public Nullable<System.DateTime> DatumDospijeceObrok { get; set; }

        [DisplayName("Valuta plaćanje")]
        public String IDValuta { get; set; }

        [DisplayName("Iznos u valuti")]
        public decimal IznosJednokratnoValuta { get; set; }

        [DisplayName("Iznos u kunama")]
        public decimal IznosJednokratno { get; set; }

        [DisplayName("Datum dospijeća")]
        public Nullable<System.DateTime> DatumDospijeceJednokratno { get; set; }

        public long StanID_Stan { get; set; }

        public int BrojUgovorStan { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Oznaka.Required)]
        [DisplayName("Stan")]
        public string OznakaStan { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.StanDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Naziv.Required)]
        [DisplayName("Stan naziv")]
        public string NazivStan { get; set; }


        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.NazivKr.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.StanDetalj.NazivKr.DisplayName)]
        public string NazivKrStan { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kratica.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Kratica.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName(AtributClass.StanDetalj.Kratica.DisplayName)]
        public string KraticaStan { get; set; }

        [DisplayName("Površina")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> PovrsinaStan { get; set; }

        [DisplayName("Broj soba")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
        public Nullable<decimal> BrojSobaStan { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Broj.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Broj.DisplayName)]
        public string BrojStan { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Ulica.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Ulica.DisplayName)]
        public string UlicaStan { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBrojDodatak.StringLength)]
        [DisplayName("Kućni broj dodatak")]
        public string KucniBrojDodatakStan { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.KucniBroj.StringLength)]
        [DisplayName("Kućni broj")]
        public string KucniBrojStan { get; set; }


        [StringLength(10, ErrorMessage = AtributClass.StanDetalj.Kat.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Kat.DisplayName)]
        public string KatStan { get; set; }



        [StringLength(30, ErrorMessage = AtributClass.StanDetalj.Opis.StringLength)]
        [DisplayName(AtributClass.StanDetalj.Opis.DisplayName)]
        public string OpisStan { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCestica.StringLength)]
        [DisplayName("Kat. čestica")]
        public string KatastarskaCesticaStan { get; set; }


        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.KatastarskaCesticaOpcina.StringLength)]
        [DisplayName("Kat. čestica općina")]
        public string KatastarskaCesticaOpcinaStan { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Adresa.DisplayName)]
        public Nullable<long> StanID_Adresa { get; set; }


        [StringLength(5, ErrorMessage = AtributClass.StanDetalj.PostanskiBroj.StringLength)]
        [DisplayName(AtributClass.StanDetalj.PostanskiBroj.DisplayName)]
        public string PostanskiBrojStan { get; set; }


        [StringLength(50, ErrorMessage = AtributClass.StanDetalj.Posta.StringLength)]
        [DisplayName("Pošta")]
        public string PostaStan { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Posta.DisplayName)]
        public Nullable<long> StanID_Posta { get; set; }

        [DisplayName(AtributClass.StanDetalj.ID_Zgrada.DisplayName)]
        public Nullable<long> StanID_Zgrada { get; set; }

        [RegularExpression(KeyWord.FormaterRazno.ConstraintPoruka.ConstraintUnosBrojevi, ErrorMessage = KeyWord.FormaterRazno.ConstraintPoruka.SamoUnosBrojeva)]
        [StringLength(20, ErrorMessage = AtributClass.StanDetalj.Oznaka.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Oznaka.Required)]
        [DisplayName("Zgrada")]
        public string OznakaZgrada { get; set; }


        [StringLength(255, ErrorMessage = AtributClass.StanDetalj.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.StanDetalj.Naziv.Required)]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [DisplayName("Zgrada")]
        public string NazivZgrada { get; set; }

        public int BrojUgovorZgrada { get; set; }


        // Ostala polja UgovorStanOtkup

        public long? ID_Zapis { get; set; }
        public int BrojAneks { get; set; }
        public int BrojStorno { get; set; }
        public long? ID_Stan { get; set; }
        public decimal IznosUcescePlaceno { get; set; }
        public decimal IznosUcesceNeplaceno { get; set; }
        public decimal IznosKreditPlaceno { get; set; }
        public decimal IznosKreditNeplaceno { get; set; }
        public decimal IznosKreditRevalorizacija { get; set; }
        public decimal IznosKreditRevalorizacijaPlaceno { get; set; }
        public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }
        public decimal IznosKamataPlaceno { get; set; }
        public decimal IznosKamataNeplaceno { get; set; }
        public decimal IznosKamataRevalorizacija { get; set; }
        public decimal IznosKamataRevalorizacijaPlaceno { get; set; }
        public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }
        public decimal IznosJednokratnoPlaceno { get; set; }
        public decimal IznosJednokratnoNeplaceno { get; set; }
        public decimal IznosJednokratnoValutaPlaceno { get; set; }
        public decimal IznosJednokratnoValutaNeplaceno { get; set; }
        public decimal IznosTrosakSud { get; set; }
        public decimal IznosPovrat { get; set; }
        public long? ID_Subjekt { get; set; }
        public int? BrojObrokDospjelo { get; set; }
        public long? ID_UgovorStanOtkupStorno { get; set; }
        public int? TemeljnicaGodina { get; set; }
        public int? TemeljnicaVrsta { get; set; }
        public int? TemeljnicaBroj { get; set; }
        public int? DokumentGrupa { get; set; }
        [DisplayName("Datum unosa:")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        public DateTime? DatumInsert { get; set; }
        [DisplayName("Kreirao:")]
        public string OsobaInsert { get; set; }
        [DisplayName("Datum promjene:")]
        [DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        public DateTime? DatumUpdate { get; set; }
        [DisplayName("Promijenio:")]
        public string OsobaUpdate { get; set; }
        public long? ID_OsobaInsert { get; set; }
        public long? ID_OsobaUpdate { get; set; }
        public Nullable<bool> OtkupNadstojnicki { get; set; }


    }
}