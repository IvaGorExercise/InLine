using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;

namespace InLine.Service.Admin
{
    public partial interface ILogin
    {
        // Metode Model.Admin.KorisnikData
        Model.Admin.Baza GetBaza(long bazaID);
        Model.Admin.View.BazaKorisnikKorisnik GetBaza(long bazaID, long korisnikID);
        IEnumerable<Model.Admin.KorisnikData> GetUserDataPartialLogin(long korisnikID);
        IEnumerable<Model.Admin.View.BazaKorisnikKorisnikBaza> GetUserDataPartialLoginVIEW(long korisnikID);
        Model.Admin.Korisnik GetKorisnik(string ulaz_korisnik, string ulaz_lozinka);
        Model.Admin.KorisnikData GetUserData(string ulaz_korisnik, string ulaz_lozinka);
        Model.Admin.KorisnikData GetUserData(long idKorisnik, long idBaza);
        string GetConnectionString(Model.Admin.KorisnikData korisnik);
        string GetConnectionStringNoMetadata(Model.Admin.KorisnikData korisnik);
        string AddKorisniSession(Model.Admin.KorisnikSession kos);
        string DeleteAllKorisnikSessionByIdKorisnik(long korisnikID);
        string DeleteKorisnikSessionBySessionId(string sessionkey);
        string DeleteKorisnikSessionByIdKorisnikAndSessionId(long korisnikID, string sesionID);
        string DeleteKorisnikSessionByIdKorisnikOrSessionId(long korisnikID, string sesionID);

        // Metode KorisnikDataFromSession
        Model.Admin.KorisnikData GetKorisnikDataFromSession();
        Model.Admin.KorisnikData LogOff();
    }
}
