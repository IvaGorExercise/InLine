using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace InLine.UI.Web.Models.ViewModelCustom
{
    public class HUB2013AGrad
    {
       [DisplayName("Šifra namjene")]
       public int IDHUBNamjena2013A { get; set; }

       //[Required(ErrorMessage = "*")]
       //[DisplayName("Datum izvršenja")]
       //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
       //public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName("Barkod da ili ne ")]
        public bool Barkod { get; set; }

        [DisplayName("PDF stranica")]
        [Range(1, 2000, ErrorMessage = "1-2000")]
        public int PdfPage { get; set; }

        [DisplayName("Ukupno strana")]
        public int Ukupno { get; set; }

        [DisplayName("Broj pdf dokumenata nakon podjele")]
        public int PdfBroj { get; set; }

        //[DisplayName("Broj hubova po stranici")]
        //public int HubPoStranici { get; set; }

        [DisplayName("Ime dokumenta")]
        public string PdfIme { get; set; }

        [DisplayName("Putanja spremanja")]
        public string Putanja { get; set; }

        [DisplayName("Poruka")]
        [DataType(DataType.MultilineText)]
        public string Poruka { get; set; }

        [DisplayName("TOP za upit")]
        [Range(102, 50000, ErrorMessage = "102-50000")]
        public int Top { get; set; }

        [DisplayName("Printer")]
        public int Printer { get; set; }

        [DisplayName("Mjesec")]
        [Range(1, 12, ErrorMessage = "1-12")]
        [RegularExpression("^[0-9]*", ErrorMessage = "Numbers!")]
        public int Mjesec { get; set; }

        [DisplayName("Godina")]
        [Range(1990, 2030, ErrorMessage = "1990-2030")]
        public int Godina { get; set; }

        [DisplayName("Ponovi postupak")]
        public bool Ponovo { get; set; }

        public  InLine.Model.Admin.StatusPoruka StatusPoruka { get; set; }

        public int PokreniPonovi { get; set; }

        [DisplayName("Ugovor od")]
        public int BrojUgovorMin { get; set; }

        [DisplayName("Ugovor do")]
        public int BrojUgovorMax { get; set; }

        [DisplayName("Bez datoteke")]
        public bool BezDatoteke { get; set; }
    }

    public class HUB2013AGradTEST
    {
        [DisplayName("Šifra namjene")]
        public int IDHUBNamjena2013A { get; set; }

        //[Required(ErrorMessage = "*")]
        //[DisplayName("Datum izvršenja")]
        //[DisplayFormat(DataFormatString = KeyWord.FormaterRazno.DatumFormat.ddMMyyyy, ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> Datum { get; set; }

        [DisplayName("Server")]
        public string Server { get; set; }

        [DisplayName("Baza")]
        public string Baza { get; set; }

        [DisplayName("Barkod da ili ne ")]
        public bool Barkod { get; set; }

        [DisplayName("PDF stranica")]
        [Range(1, 2000, ErrorMessage = "1-2000")]
        public int PdfPage { get; set; }

        [DisplayName("Ukupno strana")]
        public int Ukupno { get; set; }

        [DisplayName("Broj pdf dokumenata nakon podjele")]
        public int PdfBroj { get; set; }

        //[DisplayName("Broj hubova po stranici")]
        //public int HubPoStranici { get; set; }

        [DisplayName("Ime dokumenta")]
        public string PdfIme { get; set; }

        [DisplayName("Putanja spremanja")]
        public string Putanja { get; set; }

        [DisplayName("Poruka")]
        [DataType(DataType.MultilineText)]
        public string Poruka { get; set; }

        [DisplayName("TOP za upit")]
        [Range(102, 50000, ErrorMessage = "102-50000")]
        public int Top { get; set; }

        [DisplayName("Printer")]
        public int Printer { get; set; }

        [DisplayName("Mjesec")]
        [Range(1, 12, ErrorMessage = "1-12")]
        [RegularExpression("^[0-9]*", ErrorMessage = "Numbers!")]
        public int Mjesec { get; set; }

        [DisplayName("Godina")]
        [Range(1990, 2030, ErrorMessage = "1990-2030")]
        public int Godina { get; set; }

        [DisplayName("Ponovi postupak")]
        public bool Ponovo { get; set; }

        public InLine.Model.Admin.StatusPoruka StatusPoruka { get; set; }

        public int PokreniPonovi { get; set; }

        [DisplayName("Ugovor od")]
        public int BrojUgovorMin { get; set; }

        [DisplayName("Ugovor do")]
        public int BrojUgovorMax { get; set; }


    }
}