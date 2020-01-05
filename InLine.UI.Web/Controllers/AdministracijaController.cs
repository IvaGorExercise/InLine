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
using InLine.UI.Web.Helper;
using InLine.Repository.Data.Helper;

namespace InLine.UI.Web.Controllers
{
    public class AdministracijaController : InLine.UI.Web.Controllers.View.KontniPlanViewController
    {

        #region Fields

        InLineConnectionStringKonstruktor conectioKonstructor = new InLineConnectionStringKonstruktor();
        String connectionString;
        String connectionStringNoMetadata;


        Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
       // public InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
   


        #endregion

        #region Konstruktor

        Service.Data.View.PoslovniSubjektSubjekt _serviceViewPoslovniSubjektSubjekt;
        InLine.Service.Admin.ILogin _serviceLogin;

        
        public AdministracijaController()
            : this(new Login())
        { }

        public AdministracijaController(ILogin serviceLogin)
        {
            _serviceLogin = serviceLogin;

        }

        #endregion


        public ActionResult AdministrativniPodaci(InLine.Model.Admin.Korisnik korisnik)
        { 

            List<SelectListItem> BazaKorisnikCombo = new List<SelectListItem>();
            InLine.Model.Admin.KorisnikData korisnikData = new InLine.Model.Admin.KorisnikData();
            korisnikData.KorisnikID = korisnik.ID_Korisnik;
            korisnikData.Login = korisnik.Login;
            korisnikData.LoginPassword = korisnik.Lozinka;
            korisnikData.KorisnikIme = korisnik.Ime;
            korisnikData.KorisnikPrezime = korisnik.Prezime;
            korisnikData.Godina = 0;

            //BazaKorisnikCombo = _serviceLogin.GetUserDataPartialLogin(korisnik.ID_Korisnik).Select(c => new SelectListItem() { Value = c.ID_Database.ToString(), Text = c.DatabaseName }).ToList();
             BazaKorisnikCombo = _serviceLogin.GetUserDataPartialLoginVIEW(korisnik.ID_Korisnik).Select(c => new SelectListItem() { Value = c.ID_Baza.ToString(), Text = c.BazaNaziv }).ToList();


            if (BazaKorisnikCombo.Count() > 1)
            {
                BazaKorisnikCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = "" });
            }

            ViewBag.BazaKorisnik = new SelectList(BazaKorisnikCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            return View(korisnikData);
        }

        public ActionResult AdministrativniPodaciPromjena()
        {
            korisnik_data = _korisnikDataFromSession.GetKorisnikDataFromSession();
            if (korisnik_data != null)
            {
                List<SelectListItem> BazaKorisnikCombo = new List<SelectListItem>();
                InLine.Model.Admin.KorisnikData korisnikData = new InLine.Model.Admin.KorisnikData();
                korisnikData.KorisnikID = korisnik_data.KorisnikID;
                korisnikData.Login = korisnik_data.Login;
                korisnikData.LoginPassword = korisnik_data.LoginPassword;
                korisnikData.KorisnikIme = korisnik_data.KorisnikIme;
                korisnikData.KorisnikPrezime = korisnik_data.KorisnikPrezime;
                korisnikData.Godina = 0;

                //BazaKorisnikCombo = _serviceLogin.GetUserDataPartialLogin(korisnik.ID_Korisnik).Select(c => new SelectListItem() { Value = c.ID_Database.ToString(), Text = c.DatabaseName }).ToList();
                BazaKorisnikCombo = _serviceLogin.GetUserDataPartialLoginVIEW(korisnik_data.KorisnikID).Select(c => new SelectListItem() { Value = c.ID_Baza.ToString(), Text = c.BazaNaziv }).ToList();


                if (BazaKorisnikCombo.Count() > 1)
                {
                    BazaKorisnikCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = "" });
                }

                ViewBag.BazaKorisnik = new SelectList(BazaKorisnikCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

                return View("AdministrativniPodaci", korisnikData);
            }
            else
            {
                return RedirectToAction(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
            }

          
        }


        [HttpPost]
        public ActionResult LogOn(InLine.Model.Admin.KorisnikData korisnikData)
        {
            InLine.Model.Admin.KorisnikData korisnik = new InLine.Model.Admin.KorisnikData();
            KorisnikSession korisnikSessionID = new KorisnikSession();
            String poruka = String.Empty;
    
            try
            {
                if (korisnikData != null)
                 {

                     InLine.Model.Admin.View.BazaKorisnikKorisnik baza = _serviceLogin.GetBaza(korisnikData.ID_Database, korisnikData.KorisnikID);

                    if (baza != null)
                    {
                        korisnikData.DatabaseName = baza.BazaNaziv;
                        korisnikData.ServerName = baza.Server;
                        korisnikData.Korisnik = baza.Korisnik;
                        korisnikData.Password = baza.Lozinka;
                    }

                    connectionString = _serviceLogin.GetConnectionString(korisnikData);
                    connectionStringNoMetadata = _serviceLogin.GetConnectionStringNoMetadata(korisnikData);

                     if (!String.IsNullOrEmpty(connectionString))
                     {
                         //korisnik.Korisnik = korisnikData.Korisnik;
                         //korisnik.Password = korisnikData.Password;
                         //korisnik.Login = korisnikData.Login;
                         //korisnik.LoginPassword = korisnikData.LoginPassword;
                         //korisnik.ConnString = connectionString;
                         //korisnik.ConnStringNoMetadata = connectionStringNoMetadata;
                         //korisnik.ID_PoslovnaGodina = korisnikData.ID_PoslovnaGodina;
                         //korisnik.Godina = korisnikData.Godina;
                         korisnikData.ConnString = connectionString;
                         korisnikData.ConnStringNoMetadata = connectionStringNoMetadata;
                         Session["KorisnikID"] = korisnikData.KorisnikID.ToString();
                         Session["Korisnik" + Session["KorisnikID"]] = korisnikData;
                         korisnikSessionID.ID_Korisnik = korisnikData.KorisnikID;
                         korisnikSessionID.SessionID = HttpContext.Session.SessionID;
                         korisnikSessionID.SessionDatum = DateTime.Now;
                         poruka = _serviceLogin.DeleteAllKorisnikSessionByIdKorisnik(korisnikData.KorisnikID);
                         poruka = _serviceLogin.AddKorisniSession(korisnikSessionID);

                         //string mainmenu_version = "1";
                         //mainmenu_version = CommonFunctions.GetMainMenu();
                         //string kojimainView = ViewList.Pocetna.ViewIndex;

                         //switch (mainmenu_version)
                         //{
                         //    case "2":
                         //        kojimainView = ViewList.Pocetna.ViewIndexGrad;
                         //        break;
                         //    default:
                         //        kojimainView = ViewList.Pocetna.ViewIndex;
                         //        break;
                         //}

                         return RedirectToAction(ViewList.Pocetna.ViewIndex, T4.ControllerName.ControllerName.Pocetna);
                     }
                     else
                     {
                         ViewBag.poruka = "ConnectionString je null ili empty";
                         return View(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
                     }
                 }
                 else
                 {
                     ViewBag.poruka = "GrKorisnik je null";
                     return View(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
                 }
            }

            catch (Exception ex)
            {
                IDozvoleZabranePoruke insertinlog = new DozvoleZabranePoruke();
                insertinlog.AddExceptionInLogKodLogiranja("Greška kod logiranja pri stavljanju korisničkih podataka u Session", ex.GetBaseException().ToString(), ex.StackTrace.ToString());
            }

            ViewBag.poruka = "Greška pri spajanju! Neispravno korisničko ime ili lozinka!";
            return View(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
        }



        public ActionResult PoslovniSubjekt(long idKorisnik, long idBaza)
        {
            InLine.Model.Admin.KorisnikData korisnik = new InLine.Model.Admin.KorisnikData();
            KorisnikSession korisnikSessionID = new KorisnikSession();
            String poruka = String.Empty;

            try
            {
                korisnik = _serviceLogin.GetUserData(idKorisnik, idBaza);

                if (korisnik != null)
                {
                    connectionString = _serviceLogin.GetConnectionString(korisnik);
                    connectionStringNoMetadata = _serviceLogin.GetConnectionStringNoMetadata(korisnik);

                    if (!String.IsNullOrEmpty(connectionString))
                    {
                        korisnik.ConnString = connectionString;
                        korisnik.ConnStringNoMetadata = connectionStringNoMetadata;
                        korisnik.ID_PoslovnaGodina = null;
                        Session["KorisnikID"] = korisnik.KorisnikID.ToString();
                        Session["Korisnik" + Session["KorisnikID"]] = korisnik;
                        korisnikSessionID.ID_Korisnik = korisnik.KorisnikID;
                        korisnikSessionID.SessionID = HttpContext.Session.SessionID;
                        korisnikSessionID.SessionDatum = DateTime.Now;
                        poruka = _serviceLogin.DeleteAllKorisnikSessionByIdKorisnik(korisnik.KorisnikID);
                        poruka = _serviceLogin.AddKorisniSession(korisnikSessionID);

                        _serviceViewPoslovniSubjektSubjekt = new Service.Data.View.PoslovniSubjektSubjekt(korisnik);
                        List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt> field = new List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt>();
                        List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt> filter = new List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt>();
                        List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt> sort = new List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt>();

                        List<SelectListItem> PoslovniSubjektCombo = new List<SelectListItem>();
                        PoslovniSubjektCombo = _serviceViewPoslovniSubjektSubjekt.GetData(field, filter, sort).Select(c => new SelectListItem() { Value = c.ID_PoslovniSubjekt.ToString(), Text = c.Naziv }).ToList();

                        if (PoslovniSubjektCombo.Count() > 1)
                        {
                            PoslovniSubjektCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = "" });
                        }

                        ViewBag.PoslovniSubjekt = new SelectList(PoslovniSubjektCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
                    }

                    else
                    {
                        ViewBag.poruka = "ConnectionString je null or empty! ";
                        return View(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
                    }
                }
                else
                {
                    ViewBag.poruka = "Korisnik je null!";
                    return View(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
                }

            }

            catch (Exception ex)
            {
                IDozvoleZabranePoruke insertinlog = new DozvoleZabranePoruke();
                insertinlog.AddExceptionInLogKodLogiranja("Greška kod dohvata PoslovniSubjekt za odabranu bazu za logiranog korisnika", ex.GetBaseException().ToString(), ex.StackTrace.ToString());
            }

            return PartialView(korisnik);
        }

        public ActionResult PoslovnaGodina(long idPoslovniSubjekt)
        {
           InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
           Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
           Service.Data.IPoslovnaGodina _servicePoslovnaGodina;
           List<SelectListItem> PoslovnaGodinaCombo = new List<SelectListItem>();
           long KorisnikID;

            korisnik_data = _korisnikDataFromSession.GetKorisnikDataFromSession();
            if (korisnik_data != null)
            {
                KorisnikID = korisnik_data.KorisnikID;
                _servicePoslovnaGodina = new Service.Data.PoslovnaGodina(korisnik_data);

                List<InLine.Model.Data.Field.PoslovnaGodina> field = new List<InLine.Model.Data.Field.PoslovnaGodina>();
                List<InLine.Model.Data.Filter.PoslovnaGodina> filter = new List<InLine.Model.Data.Filter.PoslovnaGodina>();
                filter.Add(new InLine.Model.Data.Filter.PoslovnaGodina { Field = InLine.Model.Data.Field.PoslovnaGodina.ID_PoslovniSubjekt, Value = idPoslovniSubjekt });
                List<InLine.Model.Data.Sort.PoslovnaGodina> sort = new List<InLine.Model.Data.Sort.PoslovnaGodina>();

                PoslovnaGodinaCombo = _servicePoslovnaGodina.GetData(field, filter, sort).Select(c => new SelectListItem() { Value = c.ID_PoslovnaGodina.ToString(), Text = c.Godina.ToString() }).ToList();
                ViewBag.PoslovnaGodina = new SelectList(PoslovnaGodinaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
            }
            else
            {
                RedirectToAction(ViewList.Home.ViewLogOnParcijalni, T4.ControllerName.ControllerName.Home);
            }

    

            return PartialView();
        }


    }
    
}
