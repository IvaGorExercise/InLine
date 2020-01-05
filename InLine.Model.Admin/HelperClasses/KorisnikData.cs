using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Model.Admin
{
    public class KorisnikData
    {
        public long KorisnikID { get; set; }
        public string Login { get; set; }
        public string LoginPassword { get; set; }
        public string Korisnik { get; set; }
        public string Password { get; set; }
        public long ID_Database { get; set; }
        public string DatabaseName { get; set; }
        public string ServerName { get; set; }
        public string ConnString { get; set; }
        public string ConnStringNoMetadata { get; set; }
        public string KorisnikIme { get; set; }
        public string KorisnikPrezime { get; set; }
        public long? ID_PoslovnaGodina { get; set; }
        public int? Godina { get; set; }
    }
}
