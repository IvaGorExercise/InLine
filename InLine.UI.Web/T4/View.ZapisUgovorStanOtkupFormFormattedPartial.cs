//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class ZapisUgovorStanOtkupFormFormattedBase
    {
    	#region Properities
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Zapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Zapis.DisplayName)]
       	public long ID_Zapis { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapisTablica.DisplayName)]
       	public int IDZapisTablica { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapisVr.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapisVr.DisplayName)]
       	public int IDZapisVr { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDZapis.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDZapis.DisplayName)]
       	public long IDZapis { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.VrijemeUpis.DisplayName)]
       	public Nullable<System.DateTime> VrijemeUpis { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.UrudzbeniBroj.DisplayName)]
       	public string UrudzbeniBroj { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Predmet.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Predmet.DisplayName)]
       	public string Predmet { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Subjekt.DisplayName)]
       	public Nullable<long> ID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_SubjektUpis.DisplayName)]
       	public Nullable<long> ID_SubjektUpis { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Temeljnica.DisplayName)]
       	public Nullable<long> ID_Temeljnica { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Broj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Broj.DisplayName)]
       	public string Broj { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Datum.DisplayName)]
       	public Nullable<System.DateTime> Datum { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Vrijeme.DisplayName)]
       	public Nullable<System.TimeSpan> Vrijeme { get; set; }
    
    	
        [StringLength(128, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.TablicaNaziv.DisplayName)]
       	public string TablicaNaziv { get; set; }
    
    	
        [StringLength(255, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Naziv.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Naziv.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Naziv.DisplayName)]
       	public string Naziv { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NazivKr.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NazivKr.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.NazivKr.DisplayName)]
       	public string NazivKr { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Odabir.DisplayName)]
       	public Nullable<bool> Odabir { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumGodina.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumGodina.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumGodina.DisplayName)]
       	public string DatumGodina { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.VrijemeUpisString.DisplayName)]
       	public string VrijemeUpisString { get; set; }
    
    	
        [StringLength(30, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumString.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.DatumString.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumString.DisplayName)]
       	public string DatumString { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkup.DisplayName)]
       	public long ID_UgovorStanOtkup { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_ZapisUgovorStanOtkup.DisplayName)]
       	public Nullable<long> ID_ZapisUgovorStanOtkup { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojUgovor.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojUgovor.DisplayName)]
       	public int BrojUgovor { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojAneks.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojAneks.DisplayName)]
       	public int BrojAneks { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.BrojStorno.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojStorno.DisplayName)]
       	public int BrojStorno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupDatum.DisplayName)]
       	public Nullable<System.DateTime> UgovorStanOtkupDatum { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Stan.DisplayName)]
       	public Nullable<long> ID_Stan { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcesce.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcesce.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesce { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcescePlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcescePlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUcesceNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUcesceNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKredit.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKredit.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKredit { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacijaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditRevalorizacijaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamata.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamata.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamata { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacija.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacija { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacijaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataRevalorizacijaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValuta.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValuta { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaPlaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValutaPlaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosJednokratnoValutaNeplaceno.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosJednokratnoValutaNeplaceno { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKreditObrok.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKreditObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosKamataObrok.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosKamataObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosUkupnoObrok.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosUkupnoObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosTrosakSud.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosTrosakSud { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IznosPovrat.Required)]
    	[Range(0.001, int.MaxValue, ErrorMessage = KeyWord.FormaterRazno.RangeErrorPoruka.RangeRequired)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IznosPovrat.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public decimal IznosPovrat { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.IDValuta.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.IDValuta.DisplayName)]
       	public string IDValuta { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.TecajDM.DisplayName)]
       	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DecimalFormat.TockaZarez, ApplyFormatInEditMode = true)]
    	public Nullable<decimal> TecajDM { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceJednokratno.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceJednokratno { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceUcesce.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceUcesce { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojObrok.DisplayName)]
       	public Nullable<int> BrojObrok { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceTrosakSud.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceTrosakSud { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorStanOtkupID_Subjekt.DisplayName)]
       	public Nullable<long> UgovorStanOtkupID_Subjekt { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.BrojObrokDospjelo.DisplayName)]
       	public Nullable<int> BrojObrokDospjelo { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumDospijeceObrok.DisplayName)]
       	public Nullable<System.DateTime> DatumDospijeceObrok { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Pretvorba.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Pretvorba.DisplayName)]
       	public bool Pretvorba { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Napomena.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Napomena.DisplayName)]
       	public string Napomena { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.NadstojnickiAdaptiran.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.NadstojnickiAdaptiran.DisplayName)]
       	public bool NadstojnickiAdaptiran { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupStorno.DisplayName)]
       	public Nullable<long> ID_UgovorStanOtkupStorno { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaGodina.DisplayName)]
       	public Nullable<int> TemeljnicaGodina { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaVrsta.DisplayName)]
       	public Nullable<int> TemeljnicaVrsta { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.TemeljnicaBroj.DisplayName)]
       	public Nullable<int> TemeljnicaBroj { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DokumentGrupa.DisplayName)]
       	public Nullable<int> DokumentGrupa { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DokumentVrsta.DisplayName)]
       	public Nullable<int> DokumentVrsta { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumInsert.DisplayName)]
       	public Nullable<System.DateTime> DatumInsert { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OsobaInsert.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.OsobaInsert.DisplayName)]
       	public string OsobaInsert { get; set; }
    
    	[DataType(DataType.Date)]
    	[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.DatumUpdate.DisplayName)]
       	public Nullable<System.DateTime> DatumUpdate { get; set; }
    
    	
        [StringLength(4, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.OsobaUpdate.DisplayName)]
       	public string OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_OsobaInsert.DisplayName)]
       	public Nullable<long> ID_OsobaInsert { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_OsobaUpdate.DisplayName)]
       	public Nullable<long> ID_OsobaUpdate { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.NeZateznaKamata.DisplayName)]
       	public Nullable<bool> NeZateznaKamata { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.UgovorTuzen.DisplayName)]
       	public Nullable<bool> UgovorTuzen { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.OtkupNadstojnicki.DisplayName)]
       	public Nullable<bool> OtkupNadstojnicki { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Kupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Kupac.DisplayName)]
       	public long ID_Kupac { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.KupacNaziv.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.KupacNaziv.DisplayName)]
       	public string KupacNaziv { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ulica.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Ulica.DisplayName)]
       	public string Ulica { get; set; }
    
    	
        [StringLength(3, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.KucniBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.KucniBroj.DisplayName)]
       	public string KucniBroj { get; set; }
    
    	
        [StringLength(5, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.PostanskiBroj.DisplayName)]
       	public string PostanskiBroj { get; set; }
    
    	
        [StringLength(13, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.OIB.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.OIB.DisplayName)]
       	public string OIB { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Posta.StringLength)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Posta.DisplayName)]
       	public string Posta { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Posta.DisplayName)]
       	public Nullable<long> ID_Posta { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_Osoba.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_Osoba.DisplayName)]
       	public long ID_Osoba { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Prezime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Prezime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Prezime.DisplayName)]
       	public string Prezime { get; set; }
    
    	
        [StringLength(50, ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ime.StringLength)]
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.Ime.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.Ime.DisplayName)]
       	public string Ime { get; set; }
    
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.KupacID_Subjekt.DisplayName)]
       	public Nullable<long> KupacID_Subjekt { get; set; }
    
        [Required(ErrorMessage = AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.Required)]
    	[DisplayName(AtributClass.ZapisUgovorStanOtkup.ID_UgovorStanOtkupKupac.DisplayName)]
       	public long ID_UgovorStanOtkupKupac { get; set; }
    
    	#endregion
    
    	#region Constructor
    	
    	public ZapisUgovorStanOtkupFormFormattedBase()
        { }
    	
    	public ZapisUgovorStanOtkupFormFormattedBase(Model.Data.View.ZapisUgovorStanOtkup formformated)
    	{
    	    this.ID_Zapis = formformated.ID_Zapis;
    	    this.IDZapisTablica = formformated.IDZapisTablica;
    	    this.IDZapisVr = formformated.IDZapisVr;
    	    this.IDZapis = formformated.IDZapis;
    	    this.VrijemeUpis = formformated.VrijemeUpis;
    	    this.UrudzbeniBroj = formformated.UrudzbeniBroj;
    	    this.Predmet = formformated.Predmet;
    	    this.ID_Subjekt = formformated.ID_Subjekt;
    	    this.ID_SubjektUpis = formformated.ID_SubjektUpis;
    	    this.ID_Temeljnica = formformated.ID_Temeljnica;
    	    this.Broj = formformated.Broj;
    	    this.Datum = formformated.Datum;
    	    this.Vrijeme = formformated.Vrijeme;
    	    this.TablicaNaziv = formformated.TablicaNaziv;
    	    this.Naziv = formformated.Naziv;
    	    this.NazivKr = formformated.NazivKr;
    	    this.Odabir = formformated.Odabir;
    	    this.DatumGodina = formformated.DatumGodina;
    	    this.VrijemeUpisString = formformated.VrijemeUpisString;
    	    this.DatumString = formformated.DatumString;
    	    this.ID_UgovorStanOtkup = formformated.ID_UgovorStanOtkup;
    	    this.ID_ZapisUgovorStanOtkup = formformated.ID_ZapisUgovorStanOtkup;
    	    this.BrojUgovor = formformated.BrojUgovor;
    	    this.BrojAneks = formformated.BrojAneks;
    	    this.BrojStorno = formformated.BrojStorno;
    	    this.UgovorStanOtkupDatum = formformated.UgovorStanOtkupDatum;
    	    this.ID_Stan = formformated.ID_Stan;
    	    this.IznosUcesce = formformated.IznosUcesce;
    	    this.IznosUcescePlaceno = formformated.IznosUcescePlaceno;
    	    this.IznosUcesceNeplaceno = formformated.IznosUcesceNeplaceno;
    	    this.IznosKredit = formformated.IznosKredit;
    	    this.IznosKreditPlaceno = formformated.IznosKreditPlaceno;
    	    this.IznosKreditNeplaceno = formformated.IznosKreditNeplaceno;
    	    this.IznosKreditRevalorizacija = formformated.IznosKreditRevalorizacija;
    	    this.IznosKreditRevalorizacijaPlaceno = formformated.IznosKreditRevalorizacijaPlaceno;
    	    this.IznosKreditRevalorizacijaNeplaceno = formformated.IznosKreditRevalorizacijaNeplaceno;
    	    this.IznosKamata = formformated.IznosKamata;
    	    this.IznosKamataPlaceno = formformated.IznosKamataPlaceno;
    	    this.IznosKamataNeplaceno = formformated.IznosKamataNeplaceno;
    	    this.IznosKamataRevalorizacija = formformated.IznosKamataRevalorizacija;
    	    this.IznosKamataRevalorizacijaPlaceno = formformated.IznosKamataRevalorizacijaPlaceno;
    	    this.IznosKamataRevalorizacijaNeplaceno = formformated.IznosKamataRevalorizacijaNeplaceno;
    	    this.IznosJednokratno = formformated.IznosJednokratno;
    	    this.IznosJednokratnoPlaceno = formformated.IznosJednokratnoPlaceno;
    	    this.IznosJednokratnoNeplaceno = formformated.IznosJednokratnoNeplaceno;
    	    this.IznosJednokratnoValuta = formformated.IznosJednokratnoValuta;
    	    this.IznosJednokratnoValutaPlaceno = formformated.IznosJednokratnoValutaPlaceno;
    	    this.IznosJednokratnoValutaNeplaceno = formformated.IznosJednokratnoValutaNeplaceno;
    	    this.IznosKreditObrok = formformated.IznosKreditObrok;
    	    this.IznosKamataObrok = formformated.IznosKamataObrok;
    	    this.IznosUkupnoObrok = formformated.IznosUkupnoObrok;
    	    this.IznosTrosakSud = formformated.IznosTrosakSud;
    	    this.IznosPovrat = formformated.IznosPovrat;
    	    this.IDValuta = formformated.IDValuta;
    	    this.TecajDM = formformated.TecajDM;
    	    this.DatumDospijeceJednokratno = formformated.DatumDospijeceJednokratno;
    	    this.DatumDospijeceUcesce = formformated.DatumDospijeceUcesce;
    	    this.BrojObrok = formformated.BrojObrok;
    	    this.DatumDospijeceTrosakSud = formformated.DatumDospijeceTrosakSud;
    	    this.UgovorStanOtkupID_Subjekt = formformated.UgovorStanOtkupID_Subjekt;
    	    this.BrojObrokDospjelo = formformated.BrojObrokDospjelo;
    	    this.DatumDospijeceObrok = formformated.DatumDospijeceObrok;
    	    this.Pretvorba = formformated.Pretvorba;
    	    this.Napomena = formformated.Napomena;
    	    this.NadstojnickiAdaptiran = formformated.NadstojnickiAdaptiran;
    	    this.ID_UgovorStanOtkupStorno = formformated.ID_UgovorStanOtkupStorno;
    	    this.TemeljnicaGodina = formformated.TemeljnicaGodina;
    	    this.TemeljnicaVrsta = formformated.TemeljnicaVrsta;
    	    this.TemeljnicaBroj = formformated.TemeljnicaBroj;
    	    this.DokumentGrupa = formformated.DokumentGrupa;
    	    this.DokumentVrsta = formformated.DokumentVrsta;
    	    this.DatumInsert = formformated.DatumInsert;
    	    this.OsobaInsert = formformated.OsobaInsert;
    	    this.DatumUpdate = formformated.DatumUpdate;
    	    this.OsobaUpdate = formformated.OsobaUpdate;
    	    this.ID_OsobaInsert = formformated.ID_OsobaInsert;
    	    this.ID_OsobaUpdate = formformated.ID_OsobaUpdate;
    	    this.NeZateznaKamata = formformated.NeZateznaKamata;
    	    this.UgovorTuzen = formformated.UgovorTuzen;
    	    this.OtkupNadstojnicki = formformated.OtkupNadstojnicki;
    	    this.ID_Kupac = formformated.ID_Kupac;
    	    this.KupacNaziv = formformated.KupacNaziv;
    	    this.Ulica = formformated.Ulica;
    	    this.KucniBroj = formformated.KucniBroj;
    	    this.PostanskiBroj = formformated.PostanskiBroj;
    	    this.OIB = formformated.OIB;
    	    this.Posta = formformated.Posta;
    	    this.ID_Posta = formformated.ID_Posta;
    	    this.ID_Osoba = formformated.ID_Osoba;
    	    this.Prezime = formformated.Prezime;
    	    this.Ime = formformated.Ime;
    	    this.KupacID_Subjekt = formformated.KupacID_Subjekt;
    	    this.ID_UgovorStanOtkupKupac = formformated.ID_UgovorStanOtkupKupac;
    	}
    
    	/*
    	    mymodel.ID_Zapis = model.ID_Zapis;
    	    mymodel.IDZapisTablica = model.IDZapisTablica;
    	    mymodel.IDZapisVr = model.IDZapisVr;
    	    mymodel.IDZapis = model.IDZapis;
    	    mymodel.VrijemeUpis = model.VrijemeUpis;
    	    mymodel.UrudzbeniBroj = model.UrudzbeniBroj;
    	    mymodel.Predmet = model.Predmet;
    	    mymodel.ID_Subjekt = model.ID_Subjekt;
    	    mymodel.ID_SubjektUpis = model.ID_SubjektUpis;
    	    mymodel.ID_Temeljnica = model.ID_Temeljnica;
    	    mymodel.Broj = model.Broj;
    	    mymodel.Datum = model.Datum;
    	    mymodel.Vrijeme = model.Vrijeme;
    	    mymodel.TablicaNaziv = model.TablicaNaziv;
    	    mymodel.Naziv = model.Naziv;
    	    mymodel.NazivKr = model.NazivKr;
    	    mymodel.Odabir = model.Odabir;
    	    mymodel.DatumGodina = model.DatumGodina;
    	    mymodel.VrijemeUpisString = model.VrijemeUpisString;
    	    mymodel.DatumString = model.DatumString;
    	    mymodel.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
    	    mymodel.ID_ZapisUgovorStanOtkup = model.ID_ZapisUgovorStanOtkup;
    	    mymodel.BrojUgovor = model.BrojUgovor;
    	    mymodel.BrojAneks = model.BrojAneks;
    	    mymodel.BrojStorno = model.BrojStorno;
    	    mymodel.UgovorStanOtkupDatum = model.UgovorStanOtkupDatum;
    	    mymodel.ID_Stan = model.ID_Stan;
    	    mymodel.IznosUcesce = model.IznosUcesce;
    	    mymodel.IznosUcescePlaceno = model.IznosUcescePlaceno;
    	    mymodel.IznosUcesceNeplaceno = model.IznosUcesceNeplaceno;
    	    mymodel.IznosKredit = model.IznosKredit;
    	    mymodel.IznosKreditPlaceno = model.IznosKreditPlaceno;
    	    mymodel.IznosKreditNeplaceno = model.IznosKreditNeplaceno;
    	    mymodel.IznosKreditRevalorizacija = model.IznosKreditRevalorizacija;
    	    mymodel.IznosKreditRevalorizacijaPlaceno = model.IznosKreditRevalorizacijaPlaceno;
    	    mymodel.IznosKreditRevalorizacijaNeplaceno = model.IznosKreditRevalorizacijaNeplaceno;
    	    mymodel.IznosKamata = model.IznosKamata;
    	    mymodel.IznosKamataPlaceno = model.IznosKamataPlaceno;
    	    mymodel.IznosKamataNeplaceno = model.IznosKamataNeplaceno;
    	    mymodel.IznosKamataRevalorizacija = model.IznosKamataRevalorizacija;
    	    mymodel.IznosKamataRevalorizacijaPlaceno = model.IznosKamataRevalorizacijaPlaceno;
    	    mymodel.IznosKamataRevalorizacijaNeplaceno = model.IznosKamataRevalorizacijaNeplaceno;
    	    mymodel.IznosJednokratno = model.IznosJednokratno;
    	    mymodel.IznosJednokratnoPlaceno = model.IznosJednokratnoPlaceno;
    	    mymodel.IznosJednokratnoNeplaceno = model.IznosJednokratnoNeplaceno;
    	    mymodel.IznosJednokratnoValuta = model.IznosJednokratnoValuta;
    	    mymodel.IznosJednokratnoValutaPlaceno = model.IznosJednokratnoValutaPlaceno;
    	    mymodel.IznosJednokratnoValutaNeplaceno = model.IznosJednokratnoValutaNeplaceno;
    	    mymodel.IznosKreditObrok = model.IznosKreditObrok;
    	    mymodel.IznosKamataObrok = model.IznosKamataObrok;
    	    mymodel.IznosUkupnoObrok = model.IznosUkupnoObrok;
    	    mymodel.IznosTrosakSud = model.IznosTrosakSud;
    	    mymodel.IznosPovrat = model.IznosPovrat;
    	    mymodel.IDValuta = model.IDValuta;
    	    mymodel.TecajDM = model.TecajDM;
    	    mymodel.DatumDospijeceJednokratno = model.DatumDospijeceJednokratno;
    	    mymodel.DatumDospijeceUcesce = model.DatumDospijeceUcesce;
    	    mymodel.BrojObrok = model.BrojObrok;
    	    mymodel.DatumDospijeceTrosakSud = model.DatumDospijeceTrosakSud;
    	    mymodel.UgovorStanOtkupID_Subjekt = model.UgovorStanOtkupID_Subjekt;
    	    mymodel.BrojObrokDospjelo = model.BrojObrokDospjelo;
    	    mymodel.DatumDospijeceObrok = model.DatumDospijeceObrok;
    	    mymodel.Pretvorba = model.Pretvorba;
    	    mymodel.Napomena = model.Napomena;
    	    mymodel.NadstojnickiAdaptiran = model.NadstojnickiAdaptiran;
    	    mymodel.ID_UgovorStanOtkupStorno = model.ID_UgovorStanOtkupStorno;
    	    mymodel.TemeljnicaGodina = model.TemeljnicaGodina;
    	    mymodel.TemeljnicaVrsta = model.TemeljnicaVrsta;
    	    mymodel.TemeljnicaBroj = model.TemeljnicaBroj;
    	    mymodel.DokumentGrupa = model.DokumentGrupa;
    	    mymodel.DokumentVrsta = model.DokumentVrsta;
    	    mymodel.DatumInsert = model.DatumInsert;
    	    mymodel.OsobaInsert = model.OsobaInsert;
    	    mymodel.DatumUpdate = model.DatumUpdate;
    	    mymodel.OsobaUpdate = model.OsobaUpdate;
    	    mymodel.ID_OsobaInsert = model.ID_OsobaInsert;
    	    mymodel.ID_OsobaUpdate = model.ID_OsobaUpdate;
    	    mymodel.NeZateznaKamata = model.NeZateznaKamata;
    	    mymodel.UgovorTuzen = model.UgovorTuzen;
    	    mymodel.OtkupNadstojnicki = model.OtkupNadstojnicki;
    	    mymodel.ID_Kupac = model.ID_Kupac;
    	    mymodel.KupacNaziv = model.KupacNaziv;
    	    mymodel.Ulica = model.Ulica;
    	    mymodel.KucniBroj = model.KucniBroj;
    	    mymodel.PostanskiBroj = model.PostanskiBroj;
    	    mymodel.OIB = model.OIB;
    	    mymodel.Posta = model.Posta;
    	    mymodel.ID_Posta = model.ID_Posta;
    	    mymodel.ID_Osoba = model.ID_Osoba;
    	    mymodel.Prezime = model.Prezime;
    	    mymodel.Ime = model.Ime;
    	    mymodel.KupacID_Subjekt = model.KupacID_Subjekt;
    	    mymodel.ID_UgovorStanOtkupKupac = model.ID_UgovorStanOtkupKupac;
    		
    	*/
    
    		#endregion
    	
    }
}