//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Model.Admin.Item.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class BazaKorisnikKorisnikBazaItem : Model.Admin.View.BazaKorisnikKorisnikBaza
    {
    
    	public BazaKorisnikKorisnikBazaItem() {}
    	public BazaKorisnikKorisnikBazaItem(long id_BazaKorisnik, long id_Baza, long id_Korisnik, string korisnik, string lozinka, string prezime, string ime, string login, string korisnikLozinka, string server, string bazaNaziv, string oznaka, string naziv)
    	{
    		ID_BazaKorisnik = id_BazaKorisnik;
    		ID_Baza = id_Baza;
    		ID_Korisnik = id_Korisnik;
    		Korisnik = korisnik;
    		Lozinka = lozinka;
    		Prezime = prezime;
    		Ime = ime;
    		Login = login;
    		KorisnikLozinka = korisnikLozinka;
    		Server = server;
    		BazaNaziv = bazaNaziv;
    		Oznaka = oznaka;
    		Naziv = naziv;
    	}
        public long ID_BazaKorisnik { get; set; }
        public long ID_Baza { get; set; }
        public long ID_Korisnik { get; set; }
        public string Korisnik { get; set; }
        public string Lozinka { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Login { get; set; }
        public string KorisnikLozinka { get; set; }
        public string SessionId { get; set; }
        public DateTime? SessionTime { get; set; }
        public string Server { get; set; }
        public string BazaNaziv { get; set; }
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
    }
}
