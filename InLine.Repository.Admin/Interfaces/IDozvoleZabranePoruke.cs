using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;

namespace InLine.Repository.Admin
{
    public interface IDozvoleZabranePoruke
    {
        //Dozvole i Zabrane Akcije
        # region Dozvole i Zabrane Akcije
        bool GetDozvolaAkcija(long KorisnikID, int AkcijaID);
        bool GetZabranaAkcija(long KorisnikID, int AkcijaID);
        bool AkcijaImaDozvolu(long KorisnikID, int AkcijaID);
        bool GetDozvolaAkcijaOznaka(long KorisnikID, string AkcijaOznaka);
        bool GetZabranaAkcijaOznaka(long KorisnikID, string AkcijaOznaka);
        bool AkcijaImaDozvoluOznaka(long KorisnikID, string AkcijaOznaka);
        # endregion

        // ConstrainPoruke
        # region ConstrainPoruke
        //Model.Admin.StatusPoruka GetUserFrendlyPorukaConstraint(string originalporuka, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka GetUserFrendlyPorukaConstraint(string originalporuka, Model.Admin.KorisnikData KorisnikData);

        Model.Admin.StatusPoruka GetUserFrendlyPoruka(string originalporuka);
        Model.Admin.StatusPoruka AddLogGetException(string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        void AddLog(DateTime? vrijeme, long? ID_Korisnik, long? ID_Baza, string server, string baza, string korisnik, string poruka, string exception, string trace);
     
        # endregion

        // LogException
        # region LogException
        void UpdateLog(long? ID_Log, DateTime? vrijeme, long? ID_Korisnik, long? ID_Baza, string server, string baza, string korisnik, string poruka, string exception, string trace);
        void DeleteLog(long? ID_Log);
        Model.Admin.StatusPoruka AddLogGetPorukaConstraint(string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka AddLogGetPorukaConstraintIzTransakcije(string poruka, string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka GetPorukaConstraint(string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka AddLogGetPoruka(string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka GetPoruka(string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        Model.Admin.StatusPoruka NemaDozvolaAkcijaPoruka();
        Model.Admin.StatusPoruka RezulatatJeNull();
        void AddExceptionInLogInicijacijaServisa(string exception, string trace);
        void AddExceptionInLogInicijacijaRepositorijaUGridFormated(string exception, string trace);
        void AddExceptionInLogKodLogiranja(string poruka, string exception, string trace);
        string PorukeIzListeUString(IEnumerable<String> lista);
        Model.Admin.StatusPoruka NemaDozvolaAkcijaPorukaAdLog(string imefunkcije, Model.Admin.KorisnikData KorisnikData);
        void AddExceptionInLog(string poruka, string exception, string trace, Model.Admin.KorisnikData KorisnikData);
        # endregion
    }
}
