using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using InLine;

namespace InLine.Service.Admin
{
    public class PocetnaSaVijestima : IPocetnaSaVijestima
    {
         #region Fields

        Repository.Admin.IKorisnikVijest _inLineKorisnikVijestRepository;
        Repository.Admin.IDozvoleZabranePoruke _dozvoleZabraneAkcijeRepository;
        
        #endregion


        #region Konstruktori

        public PocetnaSaVijestima(string connstring)
            : this(new Repository.Admin.KorisnikVijest(), new Repository.Admin.DozvoleZabranePoruke())
        { }

        public PocetnaSaVijestima(Repository.Admin.IKorisnikVijest inLineKorisnikVijestRepository, Repository.Admin.IDozvoleZabranePoruke dozvoleZabraneAkcijeRepository)
        {
            _inLineKorisnikVijestRepository = inLineKorisnikVijestRepository;
            _dozvoleZabraneAkcijeRepository = dozvoleZabraneAkcijeRepository;
        }
        #endregion



        #region Vijesti

        //public IEnumerable<Model.Admin.Vijest> GetVijestiForKorisnik(Model.Admin.KorisnikData korisnik_data)
        //{
        //    IEnumerable<Model.Admin.Vijest> rezultat;

        //    try
        //    {
        //        rezultat = _inLineKorisnikVijestRepository.GetVijestiForKorisnik(korisnik_data.KorisnikID);
        //    }

        //    catch (Exception ex)
        //    {
        //        Model.Admin.StatusPoruka poruka = _dozvoleZabraneAkcijeRepository.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        rezultat = null;
        //    }
        //    return rezultat;  
        //}

        #endregion
    }
}
