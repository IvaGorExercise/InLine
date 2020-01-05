using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;


namespace InLine.Repository.Admin
{
    public interface IKorisnikData
    {
        Model.Admin.Baza GetBaza(long bazaID);
        Model.Admin.View.BazaKorisnikKorisnik GetBaza(long bazaID, long korisnikID);
        IEnumerable<Model.Admin.KorisnikData> GetUserDataPartialLogin(long korisnikID);
        IEnumerable<Model.Admin.View.BazaKorisnikKorisnikBaza> GetUserDataPartialLoginVIEW(long korisnikID);
        Model.Admin.Korisnik GetKorisnik(string ulaz_korisnik, string ulaz_lozinka);
        Model.Admin.KorisnikData GetUserData(string ulaz_korisnik, string ulaz_lozinka);
        Model.Admin.KorisnikData GetUserData(long idKorisnik, long idBaza);
        string GetConnectionString(Model.Admin.KorisnikData korisnik);
        string GetConnectionStringNoMetadata(Model.Admin.KorisnikData korisnik);
        void AddKorisniSession(Model.Admin.KorisnikSession kos);
        void DeleteAllKorisnikSessionByIdKorisnik(long korisnikID);
        void DeleteKorisnikSessionBySessionId(string sessionkey);
        void DeleteKorisnikSessionByIdKorisnikAndSessionId(long korisnikID, string sesionID);
        void DeleteKorisnikSessionByIdKorisnikOrSessionId(long korisnikID, string sesionID);
        bool IsKorisnikInKorisnikSession(long korisnikID);
    }  

}
