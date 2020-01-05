using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InLine;
using InLine.Model.Admin;
using InLine.Repository.Admin;
using InLine.Service.Admin;
using InLine.UI.Web.Models;


namespace InLine.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        ILogin _loginService;
        InLineConnectionStringKonstruktor conectioKonstructor = new InLineConnectionStringKonstruktor();
        String connectionString;
        String connectionStringNoMetadata;
        #endregion


        #region Konstruktori

        public HomeController()
            : this(new Login())
        { }

        public HomeController(ILogin loginService)
        {
            _loginService = loginService;

        }

        #endregion



        #region Actions

        public ActionResult LogOnParcijalni()
        {
            UserLoginModel model = new UserLoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult LogOnParcijalni(UserLoginModel model)
        {
            InLine.Model.Admin.Korisnik korisnik = new InLine.Model.Admin.Korisnik();
            KorisnikSession korisnikSessionID = new KorisnikSession();
            String poruka = String.Empty;
            try
            {
                korisnik = _loginService.GetKorisnik(model.Username, model.Password);


                if (korisnik != null)
                {

                    return RedirectToAction(ViewList.Administracija.ViewAdministrativniPodaci, T4.ControllerName.ControllerName.Administracija, korisnik);
                }
                else
                {
                    ViewBag.poruka = "Greška pri spajanju! Neispravno korisničko ime ili lozinka!";
                    return View();
                }
            }

            catch (Exception ex)
            {
                IDozvoleZabranePoruke insertinlog = new DozvoleZabranePoruke();
                insertinlog.AddExceptionInLogKodLogiranja("Greška kod logiranja pri provjeri korisničkog imena ili lozinke", ex.GetBaseException().ToString(), ex.StackTrace.ToString());
            }

            return View(ViewList.Administracija.ViewAdministrativniPodaci, T4.ControllerName.ControllerName.Administracija);
        }






        public ActionResult LogOff()
        {
            string poruka = String.Empty;
            InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();

            korisnik_data = _loginService.LogOff();

            if (korisnik_data != null)
            {
                Session.Abandon();
                _loginService.DeleteKorisnikSessionByIdKorisnikAndSessionId(korisnik_data.KorisnikID, HttpContext.Session.SessionID.ToString());
                ViewBag.poruka = "Uspješna odjava";
                return View("LogOnParcijalni");
            }

            else
            {
                return RedirectToAction(ViewList.Pocetna.ViewIndex, T4.ControllerName.ControllerName.Pocetna);
            }
        }

        #endregion

    }
}
