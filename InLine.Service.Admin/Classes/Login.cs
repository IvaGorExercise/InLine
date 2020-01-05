using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using InLine;


namespace InLine.Service.Admin
{
    public class Login : ILogin
    {
         #region Fields

        Repository.Admin.IKorisnikData _inLineKorisnikDataRepository;
        Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSessionRepository;
        
        #endregion



        #region Konstruktori

        public Login()
            : this(new Repository.Admin.KorisnikData(), new Repository.Admin.KorisnikDataFromSession())
        { }

        public Login(Repository.Admin.IKorisnikData inLineKorisnikDataRepository, Repository.Admin.IKorisnikDataFromSession korisnikDataFromSessionRepository)
        {
            _inLineKorisnikDataRepository = inLineKorisnikDataRepository;
            _korisnikDataFromSessionRepository = korisnikDataFromSessionRepository;
        }
        #endregion





        #region Metode


        public Model.Admin.Baza GetBaza(long bazaID)
        {
            return _inLineKorisnikDataRepository.GetBaza(bazaID);
        }

        public Model.Admin.View.BazaKorisnikKorisnik GetBaza(long bazaID, long korisnikID)
        {
            return _inLineKorisnikDataRepository.GetBaza(bazaID, korisnikID);
        }

        public IEnumerable<Model.Admin.KorisnikData> GetUserDataPartialLogin(long korisnikID)
        {
            return _inLineKorisnikDataRepository.GetUserDataPartialLogin(korisnikID);
        }

        public IEnumerable<Model.Admin.View.BazaKorisnikKorisnikBaza> GetUserDataPartialLoginVIEW(long korisnikID)
        {
            return _inLineKorisnikDataRepository.GetUserDataPartialLoginVIEW(korisnikID);
        }

        public Model.Admin.Korisnik GetKorisnik(string ulaz_korisnik, string ulaz_lozinka)
        {
            return _inLineKorisnikDataRepository.GetKorisnik(ulaz_korisnik, ulaz_lozinka);
        }

        // Metode Model.Admin.KorisnikData
        public Model.Admin.KorisnikData GetUserData(string ulaz_korisnik, string ulaz_lozinka)
        {
            return _inLineKorisnikDataRepository.GetUserData(ulaz_korisnik, ulaz_lozinka);
        }

        public Model.Admin.KorisnikData GetUserData(long idKorisnik, long idBaza)
        {
            return _inLineKorisnikDataRepository.GetUserData(idKorisnik, idBaza);
        }


        public string GetConnectionString(Model.Admin.KorisnikData korisnik)
        {
            return _inLineKorisnikDataRepository.GetConnectionString(korisnik);
        }

        public string GetConnectionStringNoMetadata(Model.Admin.KorisnikData korisnik)
        {
            return _inLineKorisnikDataRepository.GetConnectionStringNoMetadata(korisnik);
        }

        public string AddKorisniSession(Model.Admin.KorisnikSession kos)
        {
            string poruka = String.Empty;

            try
            {
                _inLineKorisnikDataRepository.AddKorisniSession(kos);
              
            }

            catch (Exception ex)
            {
                poruka = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
            }

            return poruka;
        }

        public string DeleteAllKorisnikSessionByIdKorisnik(long korisnikID)
        {
            string poruka = String.Empty;

            try
            {
                _inLineKorisnikDataRepository.DeleteAllKorisnikSessionByIdKorisnik(korisnikID);

            }

            catch (Exception ex)
            {
                poruka = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
            }

            return poruka;
        }

        public string DeleteKorisnikSessionBySessionId(string sessionkey)
        {
            string poruka = String.Empty;

            try
            {
                _inLineKorisnikDataRepository.DeleteKorisnikSessionBySessionId(sessionkey);

            }

            catch (Exception ex)
            {
                poruka = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
            }

            return poruka;
        }


        public string DeleteKorisnikSessionByIdKorisnikAndSessionId(long korisnikID, string sesionID)
        {
            string poruka = String.Empty;

            try
            {
                _inLineKorisnikDataRepository.DeleteKorisnikSessionByIdKorisnikAndSessionId(korisnikID, sesionID);

            }

            catch (Exception ex)
            {
                poruka = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
            }

            return poruka;
        }



        public string DeleteKorisnikSessionByIdKorisnikOrSessionId(long korisnikID, string sesionID)
        {
            string poruka = String.Empty;

            try
            {
                _inLineKorisnikDataRepository.DeleteKorisnikSessionByIdKorisnikOrSessionId(korisnikID, sesionID);
            }

            catch (Exception ex)
            {
                poruka = (ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString());
            }

            return poruka;
        }




        public Model.Admin.KorisnikData LogOff()
        {
            Model.Admin.KorisnikData korisnik_data = new Model.Admin.KorisnikData();
            korisnik_data = _korisnikDataFromSessionRepository.GetKorisnikDataFromSession();
            return korisnik_data;
        }




        // Metode KorisnikDataFromSession

        public Model.Admin.KorisnikData GetKorisnikDataFromSession()
        {
            return _korisnikDataFromSessionRepository.GetKorisnikDataFromSession();
        }

        #endregion
    }
}
