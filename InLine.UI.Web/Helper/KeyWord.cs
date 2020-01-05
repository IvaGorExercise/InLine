using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InLine.UI.Web.Helper
{
    public class KeyWord
    {
        public static class HUB
        {
      
            public static class ServerAndDirectoryInfo
            {
                public const string Putanja = "~/HUB/";
                public const string ReportDirectorij  = "~/Content/Reporti";
            }

            public static class StiReportVariable
            {
                public const string Top = "top";
                public const string Barkod = "barkod";
                public const string Vrsta = "vrsta";
                public const string Godina = "Godina";
                public const string Mjesec = "Mjesec";
                public const string BrojUgovorMin = "BrojUgovorMin";
                public const string BrojUgovorMax = "BrojUgovorMax";
                public const string Upit = "Upit";
            }

            public static class ReportName
            {
              public const string HUB2013AGrad = "\\HUB2013A.mrt";
              public const string HUB2013AGradRasponUgovor = "\\HUB2013ARaspoUgovor.mrt";
              public const string HUB2013AGradRasponUgovorUZORAK = "\\HUB2013ARaspoUgovorUZORAK.mrt";
            }

            public static class ReportHUB2013AGradFields
            {
                public const string Platitelj = "Platitelj";
                public const string Primatelj = "Primatelj";
                public const string Hitno = "Hitno";
                public const string ValutaPlacanja = "ValutaPlacanja";
                public const string IznosCijelo = "IznosCijelo";
                public const string IznosDecimala = "IznosDecimala";
                public const string TalonValuta = "TalonValuta";
                public const string TalonIznos = "TalonIznos";
                public const string PrimateljRacun = "PrimateljRacun";
                public const string PrimateljModel = "PrimateljModel";
                public const string PrimateljPozivNaBroj = "PrimateljPozivNaBroj";
                public const string SifraNamjena = "SifraNamjena";
                public const string DatumIzvrsenja = "DatumIzvrsenja";
                public const string OpisPlacanje = "OpisPlacanje";
                public const string TalonPlatitelja = "TalonPlatitelja";
                public const string TalonRacun = "TalonRacun";
                public const string TalonModel = "TalonModel";
                public const string TalonOpis = "TalonOpis";
                public const string Napomena = "Napomena";
                public const string InfoPdf = "InfoPdf";
                public const string InfoHUB = "InfoHUB";
            }

            public static class StiDataSource
            {
                public const string Ds = "ds";
            }

            public static class Messages
            {
                public const string Molim = " Molimo za strpljenje, proces generiranja pdf dokumenata je u tijeku. </br> Proces može potrajati do 60 minuta. </br> ";
                public const string Popis = " Popis generiranih dokumenta:  </br> ";
                public const string Zauzeto = "Zauzeto";
                public const string Kraj = "KRAJ </br> ";
                public const string Prazno = " ";
               
            }

            public static class ErrorMessages
            {
                public const string Import = " Dogodila se greška prilikom pokušaja Importa podataka.";
                public const string HUBGreska = " Dogodila se greška u procesu i izrada HUB-ova je prekinuta. Molimo probajte ponovo.";
                public const string DokumentZauzet = " Lokacija za spremanje je zauzeta. Molimo zatvorite sve otvorene PDF dokumente i pokušajte ponovo";
                public const string ImportTraje = " Proces importa podataka i generiranja HUB-ova je već u tijeku.";
                public const string VecPostoji = " Za odabrani mjesec PDF dokumenti su već generirani. Ako želite ponoviti postupak označite kućicu Ponovi postupak i ponovo pritisnite gumb Kreiranje HUB-ova";
                public const string UploadUspio = "Datoteke uspješno uploadane.";
                public const string UploadZabranjen = "Proces izrade HUB-ova je pokrenut. Upload datoteke nije dozvoljen";
                public const string UploadGreska = "Dogodila se greška prilikom uploada.";
            }

            public static class ErrorStatus
            {
                public const string Jedan = "1";
                public const string Dva = "2";
                public const string Tri = "3";
            }

            public static class Notification
            {
                public const string NotificationGradHUB = "NotificationGradHUB";
                public const string Priprema = "Priprema";
                public const string NotificationUzorak = "NotificationUzorak";

            }

            public static class DokumentInfo
            {
                public const string Putanja = "~/Dokument/";
            }

            public static class Printeri
            {
                public const string FortiusHP = "FORTIUS - HP LaserJet";
                public const string GradHP500 = "GRAD - HP Laser 5000";
            }

            public static class ImportStatus
            {
                public const string Zavrsio = "Z";
                public const string Greska = "G";
                public const string Poceo = "P";
            }

            public static class ParameterValue
            {
                public const string True = "true";
                public const string False = "false";
            }

             // Brojcane vrijednosti

            public static class BrojcaneVrijednosti
            {
                public static int BrojUgovorMin = 1;
                public static int BrojUgovorMax = 10000000;
                public static int PdfPage = 500;
            }

        }

        public static class FormaterRazno
        {
            // Formati decimalnih vrijednosti
            public static class DecimalFormat
            {
                public const string TockaZarez = "{0:#,0.00}";
                public const string TockaZarez6Decimala = "{0:#,0.000000}";
                public const string TockaZarezPovrsina = "{0:#,0.0}";
            }

            // Formati hrvatskog datuma vrijednosti
            public static class DatumFormat
            {
                public const string ddMMyyyy = "{0:dd.MM.yyyy}";
            }
  

            // Formati vodecih nula
            public static class VodeceNule
            {
                public const string VodeceNule7 = "D7";

            }

            public static class GridFooterMessage
            {
                public const string Suma = "S=";
            }

            public static class StringFormat
            {
                public const string Prvi = " {0} ";
                public const string PrviDrugi = "{0} {1}";
                public const string PrviDrugiTreci = "{0} {1} {2}";
            }

            public static class RangeErrorPoruka
            {
                public const string RangeRequired = "*";

            }

            public static class ConstraintPoruka
            {
                public const string ConstraintUnosBrojevi = "^[0-9]*";
                public const string SamoUnosBrojeva = "Samo unos brojeva!";

            }
        }

        public static class DataTypeErrorMessage
        {
            public const string Currency = "Nije dozvoljen unos teksta!";
        }

        public static class FilterGridFormat
        {
            public const string BoolFilterDaNe = "BoolFilter";
            public const string DrzavljanstvoFilter = "DrzavljanstvoFilter";
            public const string NarodnostFilter = "NarodnostFilter";
        }

        public static class KontrolerFilteriGridFormat
        {
            public const string Filter = "Filter";
        }

        public static class TipAkcija
        {
            public const string Insert = "Insert";
            public const string Edit = "Edit";
            public const string Delete = "Delete";
        }

        public static class Forma
        {
            public static class Akcija
            {
                public const string Insert = "Insert";
            }

            public static class Rijec
            {
                public const string Forma = "Form";
                public const string ID_ValutaPomoc = "ID_ValutaPomoc";
                public const string Datepicker = "datepicker";
                public const string Chosen = "chosen";
                public const string Autocomplete = "autocomplete";
                public const string Odaberite = "--Odaberite--";
                public const string Pomoc = "Pomoc";
                public const string FormClass = "form_class";
                public const string FormBackground = "form_background";
            }

        }

        public static class Combo
        {
            public static class Rijec
            {
                public const string Text = "Text";
                public const string Value = "Value";
            }

        }

        public static class JqGridAtributi
        {
            public const string JqGridTitle = " .ui-jqgrid-title";
            public const string gview_ = "#gview_";
            public const string selrow = "selrow";
            public const string getGridParam = "getGridParam";
            public const string setGridParam = "setGridParam";
            public const string reloadGrid = "reloadGrid";
            public const string clearGridData = "clearGridData";
            public const string gridUnload = "GridUnload";
            public const string getCell = "getCell";
            public const string gbox = "#gbox_";
            public const string combo = "#combo";
            public const string comboTable = "#combo-table";
        }

        public static class JQueryRijec
        {
            public const string Form = "form";
            public const string cButton = "#cButton";
            public const string sButton = "#sButton";
            public const string Input = "input";
            public const string InputTypeSubmit = "input[type=submit]";
            public const string Hash = "#";

        }

        public static class PorukeKontroler
        {
            public const string NemaNadredjenaStavka = "Nema nadređene stavke.";

        }

        public static class Valuta
        {
            public const string ValutaDomaca = "HRK";

        }


    }


}