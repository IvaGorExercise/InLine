using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;

namespace InLine.Repository.Data.Helper
{
    public class CommonFunctions
    {
        public static string GetServerVersion()
        {
            string server_version = WebConfigurationManager.AppSettings["SqlServerVersion"];
            return server_version;
        }

        public static string GetMainMenu()
        {
            string mainmenu_version = WebConfigurationManager.AppSettings["AplikacijaVerzija"];
            return mainmenu_version;
        }

        public static class ServerInformation
        {
            public const string ServerVersion = "11";
            public const string offset_server_10 = "1";
            public const string fetch_server_10 = "100";
            public const string offset_server_11 = "0";
            public const string fetch_server_11 = "10000000";
        }

        public static class KeyWord
        {
            public const string And = "And";
            public const string Space = " ";
            public const string Empty = "";
            public const string Navodnik = "'";
            public const string DvostrukiNavodnik = "\"";
            public const string Zarez = ",";
            public const string TockaZarez = ";";
            public const string DvoTocka = ":";
            public const string String = "String";
            public const string Like = "LIKE";
            public const string Posto = "%";
            public const string Assembly = "InLine.Model.Data";
            public const string Crtica = "-";

        }

        public static class SessionKeyWord
        {
            public const string PorukaKorisnik = "Poruka_Korisnik_";

        }

        public static class ViewName
        {
            public const string StatusPoruka = "_StatusPoruka";
        }

        public static class PagingVrijednostiDefault
        {
            public const string Start = "0";
            public const string Count = "50";
            public const string CountMax = "100";
        }


        public static class OtkupStanovaVrijednosti
        {
            public static decimal KoeficijentDemEur = (decimal)3.642266;

        }


        public static void StaviPorukuUSession(Model.Admin.StatusPoruka poruka, Model.Admin.KorisnikData _korisnik_data)
        {
            IList<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            if ((IList<Model.Admin.StatusPoruka>)(HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()]) != null)
            {
                poruke = (IList<Model.Admin.StatusPoruka>)(HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()]);
                poruke.Add(poruka);
            }
            else
            {
                poruke.Add(poruka);
            }

            HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()] = poruke;
        }

        public static List<Model.Admin.StatusPoruka> IzvadiPorukuUSession(Model.Admin.KorisnikData _korisnik_data)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            if ((List<Model.Admin.StatusPoruka>)(HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()]) != null)
            {
                poruke = (List<Model.Admin.StatusPoruka>)(HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()]);
            }
    
            return poruke;
        }

        public static void OcistiPorukaSession(Model.Admin.KorisnikData _korisnik_data)
        {
            if ((HttpContext.Current.Session[InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString()]) != null)
            {
                HttpContext.Current.Session.Remove(InLine.Repository.Data.Helper.CommonFunctions.SessionKeyWord.PorukaKorisnik + _korisnik_data.KorisnikID.ToString());
            }
        }

    }

  

}

