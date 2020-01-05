using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InLine;


namespace InLine.UI.Web.Helper
{
    public class LogiraniKorisnikData
    {
        public static string korisnik;
        public static string server;
        public static string baza;
        public static string constring;
        public static string korisnikime;
        public static string korisnikprezime;
        public static string korisnikgodina;


        public static string ShowLoiraniKorisnik()
        {
            string logirani_korisnik;

            Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
            InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
            korisnik_data = _korisnikDataFromSession.GetKorisnikDataFromSession();

            korisnik = korisnik_data.KorisnikID.ToString();
            server = korisnik_data.ServerName;
            baza = korisnik_data.DatabaseName;
            constring = korisnik_data.ConnString;
            korisnikime = korisnik_data.KorisnikIme;
            korisnikprezime = korisnik_data.KorisnikPrezime;
            korisnikgodina = korisnik_data.Godina.ToString();

            //return logirani_korisnik = "KORISNIK: " + korisnik + " <br /> " + "SERVER: " + server + "<br />" + "BAZA: " + baza + " " + "- CONSTRING: " + constring;
            return logirani_korisnik = korisnik + "X" + server + "X" + baza + "X" + constring + "X" + korisnikime + "X" + korisnikprezime + "X" + korisnikgodina;
        }  

 
    }
}