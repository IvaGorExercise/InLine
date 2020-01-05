using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;


namespace InLine.Repository.Admin
{
    public class KorisnikData : Repository.Admin.IKorisnikData
    {
        Model.Admin.Context _context = new Model.Admin.Context();


        public Model.Admin.Baza GetBaza(long bazaID)
        {
            //return _context.Baza.Find(bazaID);

            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();

            querybilder.Append("SELECT * FROM adm.Baza");
            querybilder.Append(" WHERE ID_Baza=" + bazaID.ToString());

            query = querybilder.ToString();
            return _context.Database.SqlQuery<Model.Admin.Baza>(query).SingleOrDefault();
        }

        public Model.Admin.View.BazaKorisnikKorisnik GetBaza(long bazaID, long korisnikID)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();

            querybilder.Append("SELECT * FROM adm.VIEW_BazaKorisnikKorisnik");
            querybilder.Append(" WHERE ID_Baza=" + bazaID.ToString());
            querybilder.Append(" AND ID_Korisnik=" + korisnikID.ToString());

            query = querybilder.ToString();
            return _context.Database.SqlQuery<Model.Admin.View.BazaKorisnikKorisnik>(query).SingleOrDefault();
        }


        public IEnumerable<Model.Admin.KorisnikData> GetUserDataPartialLogin(long korisnikID)
        {
            var kor = from bk in _context.BazaKorisnik
                      join ko in _context.Korisnik on bk.ID_Korisnik equals ko.ID_Korisnik
                      join ba in _context.Baza on bk.ID_Baza equals ba.ID_Baza
                      where bk.ID_Korisnik == korisnikID
                      select new Model.Admin.KorisnikData
                      {
                          KorisnikID = ko.ID_Korisnik,
                          Korisnik = bk.Korisnik,
                          Password = bk.Lozinka,
                          ID_Database = ba.ID_Baza,
                          DatabaseName = ba.BazaNaziv,
                          ServerName = ba.Server,
                          KorisnikIme = ko.Ime,
                          KorisnikPrezime = ko.Prezime,

                      };

            if (kor.Any())
            {
                return kor.ToList();
            }
            else
            {
                return null;
            }
        }


        public IEnumerable<Model.Admin.View.BazaKorisnikKorisnikBaza> GetUserDataPartialLoginVIEW(long korisnikID)
        {
            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();

            querybilder.Append("SELECT * FROM adm.VIEW_BazaKorisnikKorisnikBaza");
            querybilder.Append(" WHERE ID_Korisnik=" + korisnikID);
        
            query = querybilder.ToString();
            return _context.Database.SqlQuery<Model.Admin.View.BazaKorisnikKorisnikBaza>(query);

        }



        public Model.Admin.Korisnik GetKorisnik(string ulaz_korisnik, string ulaz_lozinka)
        {
            //Model.Admin.Korisnik kor = _context.Korisnik.Where(p=> p.Login == ulaz_korisnik.Trim() && p.Lozinka == ulaz_lozinka.Trim()).SingleOrDefault();
                     
            //if (kor != null)
            //{
            //    return kor;
            //}
            //else
            //{
            //    return null;
            //}

            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();

            querybilder.Append("SELECT * FROM adm.Korisnik");
            querybilder.Append(" WHERE Login='" + ulaz_korisnik.Trim() + "'");
            querybilder.Append(" AND Lozinka='" + ulaz_lozinka.Trim() + "'");

            query = querybilder.ToString();
            return _context.Database.SqlQuery<Model.Admin.Korisnik>(query).SingleOrDefault();
        }



        public Model.Admin.KorisnikData GetUserData(string ulaz_korisnik, string ulaz_lozinka)
        {
              var  kor = from bk in _context.BazaKorisnik
                          join ko in _context.Korisnik on bk.ID_Korisnik equals ko.ID_Korisnik
                          join ba in _context.Baza on bk.ID_Baza equals ba.ID_Baza
                          where ko.Login == ulaz_korisnik && ko.Lozinka == ulaz_lozinka
                          select new Model.Admin.KorisnikData
                          {
                              KorisnikID = ko.ID_Korisnik,
                              Korisnik = bk.Korisnik,
                              Password = bk.Lozinka,
                              ID_Database = ba.ID_Baza,
                              DatabaseName = ba.BazaNaziv,
                              ServerName = ba.Server,
                              KorisnikIme = ko.Ime,
                              KorisnikPrezime = ko.Prezime,

                          };

               if (kor.Any())
               {
                   return kor.SingleOrDefault();
               }
               else
               {
                   return null;
               }          
        }


        public Model.Admin.KorisnikData GetUserData(long idKorisnik, long idBaza)
        {
            //var kor = from bk in _context.BazaKorisnik
            //          join ko in _context.Korisnik on bk.ID_Korisnik equals ko.ID_Korisnik
            //          join ba in _context.Baza on bk.ID_Baza equals ba.ID_Baza
            //          where bk.ID_Korisnik == idKorisnik && bk.ID_Baza == idBaza
            //          select new Model.Admin.KorisnikData
            //          {
            //              KorisnikID = ko.ID_Korisnik,
            //              Korisnik = bk.Korisnik,
            //              Password = bk.Lozinka,
            //              ID_Database = ba.ID_Baza,
            //              DatabaseName = ba.BazaNaziv,
            //              ServerName = ba.Server,
            //              KorisnikIme = ko.Ime,
            //              KorisnikPrezime = ko.Prezime,

            //          };

            //if (kor.Any())
            //{
            //    return kor.SingleOrDefault();
            //}
            //else
            //{
            //    return null;
            //}

            Model.Admin.KorisnikData result = new Model.Admin.KorisnikData();

            string query = String.Empty;
            StringBuilder querybilder = new StringBuilder();

            querybilder.Append("SELECT * FROM adm.VIEW_BazaKorisnikKorisnikBaza");
            querybilder.Append(" WHERE ID_Korisnik=" + idKorisnik);
            querybilder.Append(" AND ID_Baza=" + idBaza);

            query = querybilder.ToString();
            Model.Admin.View.BazaKorisnikKorisnikBaza dbResult = _context.Database.SqlQuery<Model.Admin.View.BazaKorisnikKorisnikBaza>(query).SingleOrDefault();

            if (dbResult != null)
            {
                result.KorisnikID = dbResult.ID_Korisnik;
                result.Korisnik = dbResult.Korisnik;
                result.Password = dbResult.Lozinka;
                result.ID_Database = dbResult.ID_Baza;
                result.DatabaseName = dbResult.BazaNaziv;
                result.ServerName = dbResult.Server;
                result.KorisnikIme = dbResult.Ime;
                result.KorisnikPrezime = dbResult.Prezime;
            }
          

            return result;

        }


        public string GetConnectionString(Model.Admin.KorisnikData korisnik)
        {
            return Model.Admin.InLineConnectionStringKonstruktor.GetConnectionString(korisnik);
        }

        public string GetConnectionStringNoMetadata(Model.Admin.KorisnikData korisnik)
        {
            return Model.Admin.InLineConnectionStringKonstruktor.GetConnectionStringNoMetadata(korisnik);
        }

        public void AddKorisniSession(Model.Admin.KorisnikSession kos)
        {
             _context.KorisnikSession.Add(kos);
             _context.SaveChanges();
        }


        public void DeleteKorisnikSessionBySessionId(string sessionkey)
        {
              _context.KorisnikSession.Remove(_context.KorisnikSession.First(p => p.SessionID == sessionkey));
              _context.SaveChanges();
        }


        public void DeleteAllKorisnikSessionByIdKorisnik(long korisnikID)
        {
            IEnumerable<Model.Admin.KorisnikSession> korisnikSessioni = _context.KorisnikSession.Where(p => p.ID_Korisnik == korisnikID);

            if (korisnikSessioni.Any())
            {
                foreach (Model.Admin.KorisnikSession korses in korisnikSessioni)
                {
                    _context.KorisnikSession.Remove(korses);
                }
                _context.SaveChanges();
            }
        }


        public bool  IsKorisnikInKorisnikSession(long korisnikID)
        {
            bool proof;
            IEnumerable<Model.Admin.KorisnikSession> korisnik = _context.KorisnikSession.Where(p => p.ID_Korisnik == korisnikID);

            if (korisnik.Any())
            {
                proof = true;
            }

            else
            {
                proof = false;
            }

            return proof;
        }


        public void DeleteKorisnikSessionByIdKorisnikAndSessionId(long korisnikID, string sesionID)
        {
            IEnumerable<Model.Admin.KorisnikSession> korisnikSessioni =_context.KorisnikSession.Where(p => p.ID_Korisnik== korisnikID && p.SessionID == sesionID );
          
            if (korisnikSessioni.Any())
            {
                foreach (Model.Admin.KorisnikSession korses in korisnikSessioni)
                {
                  _context.KorisnikSession.Remove(korses);
                }
                 _context.SaveChanges();
            }
  
        }


        public void DeleteKorisnikSessionByIdKorisnikOrSessionId(long korisnikID, string sesionID)
        {
            IEnumerable<Model.Admin.KorisnikSession> korisnikSessioni = _context.KorisnikSession.Where(p => p.ID_Korisnik == korisnikID || p.SessionID == sesionID);

            if (korisnikSessioni.Any())
            {
                foreach (Model.Admin.KorisnikSession korses in korisnikSessioni)
                {
                    _context.KorisnikSession.Remove(korses);
                }
                _context.SaveChanges();
            }

        }


        public IEnumerable<Model.Admin.KorisnikSession> FindKorisnikSessionByKorisnikID(long korisnikID)
        {
            return _context.KorisnikSession.Where(p => p.ID_Korisnik== korisnikID);
        }

    }
}
