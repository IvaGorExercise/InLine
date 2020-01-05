using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib.Web.Mvc.JQuery.JqGrid;
using System.Text;
using InLine.UI.Web.Models.ViewModelCustom;
using InLine.UI.Web.T4.GridFormattedTemplate.View;
using InLine.UI.Web.T4.FormFormattedTemplate;
using InLine.Model.Admin;
using InLine.UI.Web.Helper;
using System.Web.UI;
using System.Threading.Tasks;
using System.Threading;
using System.Transactions;
using InLine.Repository.Data.Helper;


namespace InLine.UI.Web.Controllers
{
    public class OtkupStanovaController : InLine.UI.Web.Controllers.View.UgovorStanOtkupKupacNositeljViewController
    {
        # region Konstruktor
        Service.Data.IValuta _serviceValuta;

        Service.Data.View.IDokumentGr _serviceViewDokumentGr;

        Service.Data.IDokumentVr _serviceDokumentVr;
        Service.Data.View.IDokumentVr _serviceViewDokumentVr;
        Service.Data.View.IDokumentVrDetalj _serviceViewDokumentVrDetalj;

        Service.Data.View.UgovorStanOtkup _serviceViewUgovorStanOtkup;
        Service.Data.IUgovorStanOtkup _serviceUgovorStanOtkup;
        Service.Data.View.IUgovorStanOtkupDetalj _serviceViewUgovorStanOtkupDetalj;

        Service.Data.IUgovorStanOtkupAneks _serviceUgovorStanOtkupAneks;
        Service.Data.View.IUgovorStanOtkupAneksDetalj _serviceViewUgovorStanOtkupAneksDetalj;

        Service.Data.IZgrada _serviceZgrada;

        Service.Data.IStan _serviceStan;
        Service.Data.View.IStan _serviceViewStan;
        Service.Data.View.IStanDetalj _serviceViewStanDetalj;

        Service.Data.IPosta _servicePosta;

        Service.Data.View.IOpomena _serviceViewOpomena;
        Service.Data.View.IOpomenaDetalj _serviceViewOpomenaDetalj;
        Service.Data.Opomena _serviceOpomena;

        Service.Data.View.IUgovorStanOtkupOpomena _serviceViewUgovorStanOtkupOpomena;

        Service.Data.View.IKupacDetalj _serviceViewKupacDetalj;
        Service.Data.IKupac _serviceKupac;
        Service.Data.View.IKupac _serviceViewKupac;


        Service.Data.IUgovorStanOtkupKupac _serviceUgovorStanOtkupKupac;
        Service.Data.View.IUgovorStanOtkupKupacDetalj _serviceViewUgovorStanOtkupKupacDetalj;

        Service.Data.IUgovorStanOtkupObrok _serviceUgovorStanOtkupObrok;

        Service.Data.IUgovorStanOtkupMoratorij _serviceUgovorStanOtkupMoratorij;
        Service.Data.View.IUgovorStanOtkupMoratorijDetalj _serviceViewUgovorStanOtkupMoratorijDetalj;

        Service.Data.IUgovorStanOtkupMoratorijMjesec _serviceUgovorStanOtkupMoratorijMjesec;
        Service.Data.View.IUgovorStanOtkupMoratorijMjesecDetalj _serviceViewUgovorStanOtkupMoratorijMjesecDetalj;

        Service.Data.View.IUgovorStanOtkupZavrsetak _serviceViewUgovorStanOtkupZavrsetak;

        Service.Data.Subjekt _serviceSubjekt;

        Service.Data.IOsoba _serviceOsoba;

        Service.Data.View.IUgovorStanOtkupObrokIznos _serviceViewUgovorStanOtkupObrokIznos;


        Service.Data.ITecajLista _serviceTecajLista;
        Service.Data.ITecajListaSt _serviceTecajListaSt;
        Service.Data.ITecaj _serviceTecaj;
        Service.Data.IBanka _serviceBanka;

        CancellationTokenSource cTokenSource = new CancellationTokenSource();
        # endregion


        #region View

        public ActionResult FormiranjeObroka(UI.Web.Models.ViewModelCustom.ObrociGrad modelReceive)
        {
            int Mjesec = DateTime.Now.Month;
            int Godina = DateTime.Now.Year;

            int BrojUgovorMin = 191;
            int BrojUgovorMax = 310;

            //_serviceValuta = new Service.Data.Valuta(korisnik_data);
            //List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            //IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            //ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            UI.Web.Models.ViewModelCustom.ObrociGrad model = new UI.Web.Models.ViewModelCustom.ObrociGrad();


            if (modelReceive.Mjesec == 0)
            {
                model.Mjesec = Mjesec;
                model.Godina = Godina;
                model.UvjetRevalorizacije = Convert.ToDecimal(10.00);
                model.BrojUgovorMin = BrojUgovorMin;
                model.BrojUgovorMax = BrojUgovorMax;
                model.BrojUgovorMinString = String.Empty;
                model.BrojUgovorMaxString = String.Empty;
                model.Unaprijed = false;
                model.Preplata = false;
                model.Kamata = false;
                model.FormiranjePocelo = 0;
            }

            else
            {
                model.Mjesec = modelReceive.Mjesec;
                model.Godina = modelReceive.Godina;
                model.UvjetRevalorizacije = modelReceive.UvjetRevalorizacije;
                model.BrojUgovorMin = modelReceive.BrojUgovorMin;
                model.BrojUgovorMax = modelReceive.BrojUgovorMax;
                model.BrojUgovorMinString = modelReceive.BrojUgovorMinString;
                model.BrojUgovorMaxString = modelReceive.BrojUgovorMaxString;
                model.Unaprijed = modelReceive.Unaprijed;
                model.Preplata = modelReceive.Preplata;
                model.Kamata = modelReceive.Kamata;
                model.FormiranjePocelo = modelReceive.FormiranjePocelo;
            }

     
            return View(model);
        }


        public ActionResult Ugovori()
        {
            return View();
        }

        public ActionResult Dokumenti()
        {
            return View();
        }

        public ActionResult Opomene()
        {
            return View();
        }

        public ActionResult Kupci()
        {
            return View();
        }

        #endregion


        # region FormiranjeObroka

        [HttpGet]
        public PartialViewResult Obrada(UI.Web.Models.ViewModelCustom.ObrociGradObrada modelReceive)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<SelectListItem> rezult = new List<SelectListItem>();

            UI.Web.Models.ViewModelCustom.ObrociGradObrada model = new UI.Web.Models.ViewModelCustom.ObrociGradObrada();

            try
            {
                if (modelReceive.Ugovor == 0)
                {
                    model.UgovoriZaObradu = String.Empty;
                    model.Ugovor = 0;
                    model.ObrokUgovora = 0;
                    model.FormiranoObroka = 0;
                    model.TecajValutaRevalorizacije = "0,000000";
                    model.TecajValutaRevalorizacijeDEM = "0,000000";
                    model.VrijemePocetak = String.Empty;
                    model.VrijemeTrenutno = String.Empty;
                    model.VrijemeKraj = String.Empty;
                    model.TrajanjeDoSada = String.Empty;
                    model.TrajanjeDoKraja = String.Empty;
                    model.TrajanjeUkupno = String.Empty;
                    model.UgovoriObradjeni = String.Empty;
                    model.UgovoriZaObradu = String.Empty;
                    model.UgovoriUkupno = String.Empty;
                    model.VrstaObrocniOtvoreni = String.Empty;
                    model.VrstaObrocniZatvoreni = String.Empty;
                    model.VrstaObrocniUkupno = String.Empty;
                    model.VrstaJednokratno = String.Empty;
                    model.VrstaUkupno = String.Empty;
                    model.FormiranjeZavrseno = 0;
                    model.Status = 0;

                }
                else
                {
                    model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
                    model.Ugovor = modelReceive. Ugovor;
                    model.ObrokUgovora = modelReceive. ObrokUgovora;
                    model.FormiranoObroka = modelReceive.FormiranoObroka;
                    model.TecajValutaRevalorizacije = modelReceive.TecajValutaRevalorizacije;
                    model.TecajValutaRevalorizacijeDEM = modelReceive.TecajValutaRevalorizacijeDEM;
                    model.VrijemePocetak = modelReceive.VrijemePocetak;
                    model.VrijemeTrenutno = modelReceive.VrijemeTrenutno;
                    model.VrijemeKraj = modelReceive.VrijemeKraj;
                    model.TrajanjeDoSada = modelReceive.TrajanjeDoSada;
                    model.TrajanjeDoKraja = modelReceive.TrajanjeDoKraja;
                    model.TrajanjeUkupno = modelReceive.TrajanjeUkupno;
                    model.UgovoriObradjeni = modelReceive.UgovoriObradjeni;
                    model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
                    model.UgovoriUkupno = modelReceive.UgovoriUkupno;
                    model.VrstaObrocniOtvoreni = modelReceive.VrstaObrocniOtvoreni;
                    model.VrstaObrocniZatvoreni = modelReceive.VrstaObrocniZatvoreni;
                    model.VrstaObrocniUkupno = modelReceive.VrstaObrocniUkupno;
                    model.VrstaJednokratno = modelReceive.VrstaJednokratno;
                    model.VrstaUkupno = modelReceive.VrstaUkupno;
                    model.FormiranjeZavrseno = modelReceive.FormiranjeZavrseno;
                    model.Status = modelReceive.Status;
                }

                ModelState.Clear();
      
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return PartialView(model);
        }

        //[HttpPost]
        //public PartialViewResult Obrada(UI.Web.Models.ViewModelCustom.ObrociGradObrada modelReceive, string tekst)
        //{
        //    List<Model.Admin.StatusPoruka> poruke = null;
        //    List<SelectListItem> rezult = new List<SelectListItem>();

        //    UI.Web.Models.ViewModelCustom.ObrociGradObrada model = new UI.Web.Models.ViewModelCustom.ObrociGradObrada();

        //    try
        //    {
        //        if (modelReceive.Ugovor == 0)
        //        {
        //            model.UgovoriZaObradu = String.Empty;
        //            model.Ugovor = 0;
        //            model.ObrokUgovora = 0;
        //            model.FormiranoObroka = 0;
        //            model.TecajValutaRevalorizacije = 0;
        //            model.VrijemePocetak = String.Empty;
        //            model.VrijemeTrenutno = String.Empty;
        //            model.VrijemeKraj = String.Empty;
        //            model.TrajanjeDoSada = String.Empty;
        //            model.TrajanjeDoKraja = String.Empty;
        //            model.TrajanjeUkupno = String.Empty;
        //            model.UgovoriObradjeni = String.Empty;
        //            model.UgovoriZaObradu = String.Empty;
        //            model.UgovoriUkupno = String.Empty;
        //            model.VrstaObrocniOtvoreni = String.Empty;
        //            model.VrstaObrocniZatvoreni = String.Empty;
        //            model.VrstaObrocniUkupno = String.Empty;
        //            model.VrstaJednokratno = String.Empty;
        //            model.VrstaUkupno = String.Empty;
        //            model.FormiranjeZavrseno = 0;

        //        }
        //        else
        //        {
        //            model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
        //            model.Ugovor = modelReceive.Ugovor;
        //            model.ObrokUgovora = modelReceive.ObrokUgovora;
        //            model.FormiranoObroka = modelReceive.FormiranoObroka;
        //            model.TecajValutaRevalorizacije = modelReceive.TecajValutaRevalorizacije;
        //            model.VrijemePocetak = modelReceive.VrijemePocetak;
        //            model.VrijemeTrenutno = modelReceive.VrijemeTrenutno;
        //            model.VrijemeKraj = modelReceive.VrijemeKraj;
        //            model.TrajanjeDoSada = modelReceive.TrajanjeDoSada;
        //            model.TrajanjeDoKraja = modelReceive.TrajanjeDoKraja;
        //            model.TrajanjeUkupno = modelReceive.TrajanjeUkupno;
        //            model.UgovoriObradjeni = modelReceive.UgovoriObradjeni;
        //            model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
        //            model.UgovoriUkupno = modelReceive.UgovoriUkupno;
        //            model.VrstaObrocniOtvoreni = modelReceive.VrstaObrocniOtvoreni;
        //            model.VrstaObrocniZatvoreni = modelReceive.VrstaObrocniZatvoreni;
        //            model.VrstaObrocniUkupno = modelReceive.VrstaObrocniUkupno;
        //            model.VrstaJednokratno = modelReceive.VrstaJednokratno;
        //            model.VrstaUkupno = modelReceive.VrstaUkupno;
        //            model.FormiranjeZavrseno = model.FormiranjeZavrseno;
        //        }

        //        ModelState.Clear();

        //    }

        //    catch (Exception ex)
        //    {
        //        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        //        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        //        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

        //    }

        //    return PartialView(model);
        //}


        //public ActionResult ObradaObroka()
        //{
        //    List<Model.Admin.StatusPoruka> poruke = null;
        //    List<SelectListItem> rezult = new List<SelectListItem>();

        //    UI.Web.Models.ViewModelCustom.ObrociGradObrada model = new UI.Web.Models.ViewModelCustom.ObrociGradObrada();

        //    try
        //    {
        //        model.UgovoriZaObradu = "123";
        //        model.Ugovor = 14;
        //        model.ObrokUgovora = 2321;
        //        model.FormiranoObroka = 23213;
        //        model.TecajValutaRevalorizacije = 10;
        //        model.VrijemePocetak = "01:00:00";
        //        model.VrijemeTrenutno = "02:00:00";
        //        model.VrijemeKraj = "03:00:00";
        //        model.TrajanjeDoSada = "04:00:00";
        //        model.TrajanjeDoKraja = "05:00:00";
        //        model.TrajanjeUkupno = "06:00:00"; ;
        //        model.UgovoriObradjeni = "07:00:00";
        //        model.UgovoriZaObradu = String.Empty;
        //        model.UgovoriUkupno = String.Empty;
        //        model.VrstaObrocniOtvoreni = String.Empty;
        //        model.VrstaObrocniZatvoreni = String.Empty;
        //        model.VrstaObrocniUkupno = String.Empty;
        //        model.VrstaJednokratno = String.Empty;
        //        model.VrstaUkupno = "100";
        //        model.VrstaUkupno = "100";
        //        model.FormiranjeZavrseno = 1;
        //        model.Status = 100;

        //        //ModelState.Clear();
        //    }

        //    catch (Exception ex)
        //    {
        //        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        //        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        //        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

        //    }

        //    return PartialView("Obrada", model);
        //    //return RedirectToAction("Obrada", model);
        //}

      

        //[HttpPost]
        //public ActionResult ObrokFormiraj(UI.Web.Models.ViewModelCustom.ObrociGrad model)
        //{

        //    int Mjesec = DateTime.Now.Month;
        //    int Godina = DateTime.Now.Year;

        //    int BrojUgovorMin = 7;
        //    int BrojUgovorMax = 9;

        //    _serviceValuta = new Service.Data.Valuta(korisnik_data);
        //    List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
        //    IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
        //    ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

        //    model.Mjesec = Mjesec;
        //    model.Godina = Godina;

        //    model.UvjetRevalorizacije = Convert.ToDecimal(10.00);
        //    model.BrojUgovorMin = BrojUgovorMin;
        //    model.BrojUgovorMax = BrojUgovorMax;
        //    model.Unaprijed = true;
        //    model.Preplata = true;
        //    model.Kamata = true;
        //    model.FormiranjePocelo = 1;

        //    ModelState.Clear();

        //    return View("FormiranjeObroka", model);
        //    //return RedirectToAction("FormiranjeObroka", model);

        //}

        [HttpPost]
        public ActionResult FormiranjeObroka(UI.Web.Models.ViewModelCustom.ObrociGrad model, string labela)
        {
            int BrojUgovorMin = 191;
            int BrojUgovorMax = 310;
            int BrojKoraka = 119;
            int DodajMinute = 4;

            if (!String.IsNullOrEmpty(model.BrojUgovorMinString))
            {
                BrojUgovorMin = Convert.ToInt32(model.BrojUgovorMinString);
            }
            else
            {
                BrojUgovorMin = model.BrojUgovorMin;
            }


            if (!String.IsNullOrEmpty(model.BrojUgovorMaxString))
            {
                BrojUgovorMax = Convert.ToInt32(model.BrojUgovorMaxString);
            }
            else
            {
                BrojUgovorMax = model.BrojUgovorMax;
            }


            BrojKoraka = BrojUgovorMax - BrojUgovorMin;


            if (BrojKoraka <= 120)
            {
                DodajMinute = 4;
            }

            else if (120 < BrojKoraka && BrojKoraka <= 220)
            {
                DodajMinute = 7;
            }

            else if (220 < BrojKoraka && BrojKoraka <= 320)
            {
                DodajMinute = 10;
            }

            else if (320 < BrojKoraka && BrojKoraka <= 420)
            {
                DodajMinute = 14;
            }

            else if (420 < BrojKoraka && BrojKoraka <= 520)
            {
                DodajMinute = 18;
            }

            else if (520 < BrojKoraka)
            {
                DodajMinute = 23;
            }


            int BrojUgovora = BrojUgovorMax - BrojUgovorMin ;
            int Korak = (BrojUgovorMax - BrojUgovorMin)/100;

            DateTime VrijemePocetak = DateTime.Now;
            DateTime VrijemeKraj = DateTime.Now.AddMinutes(DodajMinute);

            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            model.Mjesec = model.Mjesec;
            model.Godina = model.Godina;
            model.UvjetRevalorizacije = model.UvjetRevalorizacije;
            model.BrojUgovorMin = BrojUgovorMin;
            model.BrojUgovorMax = BrojUgovorMax;
            model.Unaprijed = model.Unaprijed;
            model.Preplata = model.Preplata;
            model.Kamata = model.Kamata;
            model.FormiranjePocelo = 1;

            ModelState.Clear();

            var cToken = cTokenSource.Token;

            var task = Task.Factory.StartNew(() =>
            {
         

                for (int i = 0; i <= BrojKoraka; i++)
                {
                    System.Threading.Thread.Sleep(2000);

                    UI.Web.Models.ViewModelCustom.ObrociGradObrada model2 = new UI.Web.Models.ViewModelCustom.ObrociGradObrada();
                    TimeSpan TrajanjeDoSadaSpan = DateTime.Now.Subtract(VrijemePocetak);
                    TimeSpan TrajanjeDoKrajaSpan = VrijemeKraj.Subtract(DateTime.Now);

                    model2.UgovoriZaObradu = (model.BrojUgovorMax - model.BrojUgovorMin).ToString();
                    model2.Ugovor = BrojUgovorMin + i;
                    model2.ObrokUgovora = i + 120;
                    model2.FormiranoObroka = i + 17;
                    model2.TecajValutaRevalorizacije = "7.123654";
                    model2.TecajValutaRevalorizacijeDEM = "3.642266";

                    model2.VrijemePocetak = VrijemePocetak.ToString();
                    model2.VrijemeTrenutno = DateTime.Now.ToString();
                    model2.VrijemeKraj = VrijemeKraj.ToString();

                    int Sati = TrajanjeDoSadaSpan.Hours;

                    model2.TrajanjeDoSada = DodajVodecuNulu(TrajanjeDoSadaSpan.Hours) + ":" + DodajVodecuNulu(TrajanjeDoSadaSpan.Minutes) + ":" + DodajVodecuNulu(TrajanjeDoSadaSpan.Seconds);
                    model2.TrajanjeDoKraja = DodajVodecuNulu(TrajanjeDoKrajaSpan.Hours) + ":" + DodajVodecuNulu(TrajanjeDoKrajaSpan.Minutes) + ":" + DodajVodecuNulu(TrajanjeDoKrajaSpan.Seconds);
                    model2.TrajanjeUkupno = "00:" + DodajVodecuNulu(DodajMinute) + ":15";

                    model2.UgovoriObradjeni = (i).ToString();
                    model2.UgovoriZaObradu = (BrojUgovora - (i)).ToString(); ;
                    model2.UgovoriUkupno = (BrojUgovora).ToString();

                    int Ukupno = BrojUgovorMax - BrojUgovorMin;
                    int UkupnoObrocni = (Ukupno - (Ukupno/10));
                    int UkupnoJednokratni = (Ukupno - UkupnoObrocni);

                    model2.VrstaObrocniOtvoreni = (UkupnoObrocni - (UkupnoObrocni / 5)).ToString();
                    model2.VrstaObrocniZatvoreni = (UkupnoObrocni - (UkupnoObrocni - (UkupnoObrocni / 5))).ToString();
                    model2.VrstaObrocniUkupno = UkupnoObrocni.ToString();
                    model2.VrstaJednokratno = UkupnoJednokratni.ToString();
                    model2.VrstaUkupno = Ukupno.ToString();

                    if (i == BrojKoraka)
                    {
                        model2.FormiranjeZavrseno = 1;
                        model2.Status = 100;
                    }

                    else
                    {
                        model2.FormiranjeZavrseno = 0;

                        if(i/Korak >= 100)
                        {
                            model2.Status = 99;
                        }
                        else{
                            model2.Status = i / Korak;
                        }
         
                    }
                
                    HttpContext.Application["GenerirajLazneObroke"] = model2;
                }

            }, cToken);

            return RedirectToAction("FormiranjeObroka", model);

        }

        public string DodajVodecuNulu(int Broj)
        {
            String result = "0";

            if (Broj < 10)
            {
                result = "0" + Broj.ToString();
            }

            else
            {
                result = Broj.ToString();
            }
            

            return result;

        }

        //[OutputCache(NoStore = true, Location = OutputCacheLocation.Client, Duration = 3)]
        public ActionResult ObradaObroka()
        {
         
            List<Model.Admin.StatusPoruka> poruke = null;
            List<SelectListItem> rezult = new List<SelectListItem>();

            UI.Web.Models.ViewModelCustom.ObrociGradObrada model = new UI.Web.Models.ViewModelCustom.ObrociGradObrada();

            //UI.Web.Models.ViewModelCustom.ObrociGradObrada modelReceive = TempData["GenerirajLazneObroke"] as UI.Web.Models.ViewModelCustom.ObrociGradObrada;
            UI.Web.Models.ViewModelCustom.ObrociGradObrada modelReceive = HttpContext.Application["GenerirajLazneObroke"] as UI.Web.Models.ViewModelCustom.ObrociGradObrada;

   

            try
            {

                //model.UgovoriZaObradu = "123";
                //model.Ugovor = 123;
                //model.ObrokUgovora = 2321;
                //model.FormiranoObroka = 23213;
                //model.TecajValutaRevalorizacije = 10;
                //model.VrijemePocetak = "01:00:00";
                //model.VrijemeTrenutno = "02:00:00";
                //model.VrijemeKraj = "03:00:00";
                //model.TrajanjeDoSada = "04:00:00";
                //model.TrajanjeDoKraja = "05:00:00";
                //model.TrajanjeUkupno = "06:00:00"; ;
                //model.UgovoriObradjeni = "07:00:00";
                //model.UgovoriZaObradu = String.Empty;
                //model.UgovoriUkupno = String.Empty;
                //model.VrstaObrocniOtvoreni = String.Empty;
                //model.VrstaObrocniZatvoreni = String.Empty;
                //model.VrstaObrocniUkupno = String.Empty;
                //model.VrstaJednokratno = String.Empty;
                //model.VrstaUkupno = "100";
                //model.VrstaUkupno = "100";
                //model.FormiranjeZavrseno = 1;
                //model.Status = 100;



                if (model != null)
                {
                    model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
                    model.Ugovor = modelReceive.Ugovor;
                    model.ObrokUgovora = modelReceive.ObrokUgovora;
                    model.FormiranoObroka = modelReceive.FormiranoObroka;
                    model.TecajValutaRevalorizacije = modelReceive.TecajValutaRevalorizacije;
                    model.TecajValutaRevalorizacijeDEM = modelReceive.TecajValutaRevalorizacijeDEM;
                    model.VrijemePocetak = modelReceive.VrijemePocetak;
                    model.VrijemeTrenutno = modelReceive.VrijemeTrenutno;
                    model.VrijemeKraj = modelReceive.VrijemeKraj;
                    model.TrajanjeDoSada = modelReceive.TrajanjeDoSada;
                    model.TrajanjeDoKraja = modelReceive.TrajanjeDoKraja;
                    model.TrajanjeUkupno = modelReceive.TrajanjeUkupno;
                    model.UgovoriObradjeni = modelReceive.UgovoriObradjeni;
                    model.UgovoriZaObradu = modelReceive.UgovoriZaObradu;
                    model.UgovoriUkupno = modelReceive.UgovoriUkupno;
                    model.VrstaObrocniOtvoreni = modelReceive.VrstaObrocniOtvoreni;
                    model.VrstaObrocniZatvoreni = modelReceive.VrstaObrocniZatvoreni;
                    model.VrstaObrocniUkupno = modelReceive.VrstaObrocniUkupno;
                    model.VrstaJednokratno = modelReceive.VrstaJednokratno;
                    model.VrstaUkupno = modelReceive.VrstaUkupno;
                    model.FormiranjeZavrseno = modelReceive.FormiranjeZavrseno;
                    model.Status = modelReceive.Status;
                }

                //ModelState.Clear();
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return PartialView("Obrada", model);
            //return RedirectToAction("Obrada", model);
        }

        # endregion



        #region DokumentGr

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DokumentGrGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewDokumentGr = new Service.Data.View.DokumentGr(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.DokumentGrViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.DokumentGrViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewDokumentGr.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewDokumentGr.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<DokumentGrGridFormatted>(Convert.ToString(item.IDDokumentGr), new DokumentGrGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }

        # endregion



        #region DokumentVr

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DokumentVrGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewDokumentVr = new Service.Data.View.DokumentVr(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.DokumentVrViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.DokumentVrViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewDokumentVr.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewDokumentVr.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<DokumentVrGridFormatted>(Convert.ToString(item.ID_DokumentVr), new DokumentVrGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }

        public ActionResult DokumentVrDetalj(long? Id, long? IdMaster)
        {
            _serviceViewDokumentVrDetalj = new Service.Data.View.DokumentVrDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.DokumentVrDetaljFormFormatted rezult;

            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.DokumentVrDetalj> field = new List<InLine.Model.Data.Field.View.DokumentVrDetalj>();
                List<InLine.Model.Data.Filter.View.DokumentVrDetalj> filter = new List<InLine.Model.Data.Filter.View.DokumentVrDetalj>();
                List<InLine.Model.Data.Sort.View.DokumentVrDetalj> sort = new List<InLine.Model.Data.Sort.View.DokumentVrDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.DokumentVrDetalj { Field = InLine.Model.Data.Field.View.DokumentVrDetalj.ID_DokumentVr, Value = Convert.ToInt64(Id)});
                var item = _serviceViewDokumentVrDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.DokumentVrDetaljFormFormatted(item);

   
                if (rezult.Obrocni == true)
                {
                    rezult.ObrocniJednokratni = 1;
                }
                else if (rezult.Jednokratni == true)
                {
                    rezult.ObrocniJednokratni = 2;
                }
                else
                {
                    rezult.ObrocniJednokratni = 0;
                }



                if (rezult.Kupac == true)
                {
                    rezult.KupacPartner = 1;
                }

                else if (rezult.Partner == true)
                {
                    rezult.KupacPartner = 2;
                }
                else
                {
                    rezult.KupacPartner = 0;
                }


                if (rezult.Ugovor == true)
                {
                    rezult.UgovorFakturaNalog = 1;
                }

                else if (rezult.Faktura == true)
                {
                    rezult.UgovorFakturaNalog = 2;
                }

                else if (rezult.Nalog == true)
                {
                    rezult.UgovorFakturaNalog = 3;
                }
                else
                {
                    rezult.UgovorFakturaNalog = 0;
                }


             
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.DokumentVrDetaljFormFormatted();
                rezult.ID_DokumentVr = -1;
                rezult.ObrocniJednokratni = 0;
                rezult.KupacPartner = 0;
                rezult.UgovorFakturaNalog = 0;

                if (IdMaster != null)
                {
                    rezult.IDDokumentGr = Convert.ToInt32(IdMaster);
                    _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);
                    List<InLine.Model.Data.Field.DokumentVr> field = new List<InLine.Model.Data.Field.DokumentVr>();
                    List<InLine.Model.Data.Filter.DokumentVr> filter = new List<InLine.Model.Data.Filter.DokumentVr>();
                    List<InLine.Model.Data.Sort.DokumentVr> sort = new List<InLine.Model.Data.Sort.DokumentVr>();
                    filter.Add(new InLine.Model.Data.Filter.DokumentVr { Field = InLine.Model.Data.Field.DokumentVr.IDDokumentGr, Value = Convert.ToInt64(IdMaster) });
                    String itemOznaka = _serviceDokumentVr.GetData(field, filter, sort).Select(p => p.Oznaka).Max();
                    String Prefiks = String.Empty;
                    int Grupa = Convert.ToInt32(IdMaster);
                    String PrefiksString = DodajVodecuNulu(Grupa);

                    if (!String.IsNullOrEmpty(itemOznaka))
                    {
                        if (itemOznaka.Length == 4)
                        {
                            itemOznaka = itemOznaka.Substring(2, 2);
                            int RedniBroj = Convert.ToInt32(itemOznaka);
                            RedniBroj = RedniBroj + 1;
                            String Sufiks = DodajVodecuNulu(RedniBroj);
                            rezult.Oznaka = Sufiks;
                        }
               
                    }
                    else
                    {
                        rezult.Oznaka = "01";
                    }

        
                }
              
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult DokumentVrInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.DokumentVrDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);


                if (viewmodel.ID_DokumentVr == -1)
                {
                    Model.Data.Item.DokumentVrItem item = new Model.Data.Item.DokumentVrItem(viewmodel);
                    item.IDDokumentGr = viewmodel.IDDokumentGr;
                    String Grupa = DodajVodecuNulu(viewmodel.IDDokumentGr);
                    item.Oznaka = Grupa + viewmodel.Oznaka;

                    switch (viewmodel.ObrocniJednokratni)
                    {
                        case 1:
                            item.Obrocni = true;
                            item.Jednokratni = false;
                            break;
                        case 2:
                            item.Obrocni = false;
                            item.Jednokratni = true;
                            break;
                    }

                    switch (viewmodel.KupacPartner)
                    {
                        case 1:
                            item.Kupac = true;
                            item.Partner = false;
                            break;
                        case 2:
                            item.Kupac = false;
                            item.Partner = true;
                            break;
                    }


                    switch (viewmodel.UgovorFakturaNalog)
                    {
                       case 1:
                            item.Ugovor = true;
                            item.Faktura = false;
                            item.Nalog = false;
                            break;
                        case 2:
                            item.Ugovor = false;
                            item.Faktura = true;
                            item.Nalog = false;
                            break;
                        case 3:
                            item.Ugovor = false;
                            item.Faktura = false;
                            item.Nalog = true;
                            break;
                    }

                    Model.Data.DokumentVr insert = _serviceDokumentVr.InsertResult(item);
                }
                else
                {
                    Model.Data.DokumentVr model = _serviceDokumentVr.FindID(viewmodel.ID_DokumentVr);

                    if (model != null)
                    {
                        Model.Data.Item.DokumentVrItem item = new Model.Data.Item.DokumentVrItem(viewmodel);

                        switch (viewmodel.ObrocniJednokratni)
                        {
                            case 1:
                                item.Obrocni = true;
                                item.Jednokratni = false;
                                break;
                            case 2:
                                item.Obrocni = false;
                                item.Jednokratni = true;
                                break;
                        }

                        switch (viewmodel.KupacPartner)
                        {
                            case 1:
                                item.Kupac = true;
                                item.Partner = false;
                                break;
                            case 2:
                                item.Kupac = false;
                                item.Partner = true;
                                break;
                        }


                        switch (viewmodel.UgovorFakturaNalog)
                        {
                            case 1:
                                item.Ugovor = true;
                                item.Faktura = false;
                                item.Nalog = false;
                                break;
                            case 2:
                                item.Ugovor = false;
                                item.Faktura = true;
                                item.Nalog = false;
                                break;
                            case 3:
                                item.Ugovor = false;
                                item.Faktura = false;
                                item.Nalog = true;
                                break;
                        }

                        Model.Data.DokumentVr update = _serviceDokumentVr.UpdateResult(item);
                    }
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        public ActionResult DokumentVrDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.DokumentVrDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);

                if (viewmodel.ID_DokumentVr != -1)
                {
                    Model.Data.Item.DokumentVrItem item = new Model.Data.Item.DokumentVrItem();
                    if (id != null)
                    {
                        item.ID_DokumentVr = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_DokumentVr = viewmodel.ID_DokumentVr;
                    }

                    int delete = _serviceDokumentVr.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        # endregion



        #region UnosUgovora

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewUgovorStanOtkup = new Service.Data.View.UgovorStanOtkup(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.UgovorStanOtkupViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.UgovorStanOtkupViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewUgovorStanOtkup.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewUgovorStanOtkup.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<UgovorStanOtkupGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkup), new UgovorStanOtkupGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }


        [HttpGet]
        public virtual ActionResult GetDokumentVrZaDropDown(int Vrsta, int Dokument)
        {
            //// Dokument
            //1 - Ugovori
            //2- Aneks

            _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);
            List<SelectListItem> DokumentVrstaCombo = new List<SelectListItem>();

            switch (Dokument)
            {
                case 1:
                    switch (Vrsta)
                    {
                        case 1:
                            DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 1 && p.Obrocni == true).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
                            break;

                        case 2:
                            DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 1 && p.Jednokratni == true).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
                            break;
                    }
                    break;

                case 2:
                    switch (Vrsta)
                    {
                        case 1:
                            DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 2).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
                            break;
                    }

                    break;
            }



            var result = from i in DokumentVrstaCombo
                         select new
                         {
                             Value = i.Value,
                             Text = i.Text,
                         };

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult UgovorStanOtkupDetalj(long? Id, long? IdMaster)
        {
            _serviceViewUgovorStanOtkupDetalj = new Service.Data.View.UgovorStanOtkupDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom rezult =  null;
            int BrojUgovora = 0;
   
            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            _servicePosta = new Service.Data.Posta(korisnik_data);
            List<SelectListItem> IDPostaCombo = new List<SelectListItem>();
            IDPostaCombo = _servicePosta.SelectResult(null).Select(c => new SelectListItem() { Value = c.ID_Posta.ToString(), Text = c.Oznaka + " " + c.Naziv }).ToList();
            IDPostaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
            ViewBag.IDPosta = new SelectList(IDPostaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);
            List<SelectListItem> DokumentVrstaCombo = new List<SelectListItem>();
            //DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 1 && (p.Obrocni == true || p.Jednokratni == true)).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
            DokumentVrstaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
            ViewBag.DokumentVrsta = new SelectList(DokumentVrstaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupDetalj.ID_UgovorStanOtkup, Value = Convert.ToInt64(Id) });
                InLine.Model.Data.View.UgovorStanOtkupDetalj item = _serviceViewUgovorStanOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom();

                if (item != null)
                {
                    rezult.ID_UgovorStanOtkup = item.ID_UgovorStanOtkup;
                    rezult.BrojUgovor = item.BrojUgovor;
                    rezult.KontrolniBroj = FNS_KontrolniBroj05(rezult.BrojUgovor);

                    if (item.ID_DokumentVr != null)
                    {
                        rezult.ID_DokumentVr = item.ID_DokumentVr;
              
                        Model.Data.DokumentVr modelDokumentVr = _serviceDokumentVr.FindID(Convert.ToInt64(item.ID_DokumentVr));
                        if(modelDokumentVr != null)
                        {
                            rezult.DokumentVrstaOznaka = modelDokumentVr.Oznaka;

                            if(modelDokumentVr.Obrocni == true)
                            {
                                rezult.VrstaUgovora = 1;
                                DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 1 && p.Obrocni == true).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();

                            }
                            else if (modelDokumentVr.Jednokratni == true)
                            {
                                rezult.VrstaUgovora = 2;
                                DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 1 && p.Jednokratni == true).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
                            }
                        }

                    }

                    DokumentVrstaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
                    ViewBag.DokumentVrsta = new SelectList(DokumentVrstaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
                    rezult.DokumentGrupa = item.DokumentGrupa;
                    rezult.DatumUgovora = item.Datum;
                    rezult.DatumDospijeceUcesce = item.DatumDospijeceUcesce;
                    rezult.TecajPoUgovoru = item.TecajDM;
                    rezult.NadstojnickiIliAdaptirani = item.NadstojnickiAdaptiran;
                    rezult.TuzeniPoOpomeni = item.UgovorTuzen.HasValue ? item.UgovorTuzen.Value : false;
                    rezult.NeZateznaKamata = item.NeZateznaKamata.HasValue ? item.NeZateznaKamata.Value : false;
                    rezult.IznosUcesce = item.IznosUcesce;
                    rezult.IznosKredit = item.IznosKredit;
                    rezult.IznosKamata = item.IznosKamata;
                    rezult.BrojObrok = Convert.ToInt32(item.BrojObrok);
                    rezult.IznosKreditObrok = item.IznosKreditObrok;
                    rezult.IznosKamataObrok = item.IznosKamataObrok;
                    rezult.IznosUkupnoObrok = item.IznosUkupnoObrok;;
                    rezult.Razlika = (rezult.IznosKredit + rezult.IznosKamata) - (rezult.BrojObrok * rezult.IznosUkupnoObrok);
                    rezult.DospijeloObroka = 0;
                    rezult.DatumDospijeceObrok = item.DatumDospijeceObrok;
                    rezult.IDValuta = item.IDValuta;
                    rezult.IznosJednokratnoValuta = item.IznosJednokratnoValuta;
                    rezult.IznosJednokratno = item.IznosJednokratno;
                    rezult.DatumDospijeceJednokratno = item.DatumDospijeceJednokratno;
                    rezult.Napomena = item.Napomena;
                    rezult.OsobaInsert = item.OsobaInsert;
                    rezult.DatumInsert = item.DatumInsert;
                    rezult.ID_OsobaInsert = item.ID_OsobaInsert;
                    rezult.OsobaUpdate = item.OsobaUpdate;
                    rezult.DatumUpdate = item.DatumUpdate;
                    rezult.ID_OsobaUpdate= item.ID_OsobaUpdate;

                    rezult.IzPretvorbe = item.Pretvorba;
                    rezult.StanID_Stan = Convert.ToInt64(item.ID_Stan);
                    rezult.UlicaStan = item.Ulica;
                    rezult.KucniBrojStan = item.KucniBroj;
                    rezult.KucniBrojDodatakStan = item.KucniBrojDodatak;
                    rezult.StanID_Posta = item.ID_Posta;

                    if (!String.IsNullOrEmpty(item.Oznaka))
                    {
                        rezult.OznakaStan = item.Oznaka.Trim();
                    }

                    else
                    {
                        rezult.OznakaStan = item.Oznaka;
                    }

                    rezult.NazivStan = item.Naziv;
                    rezult.KatStan = item.Kat;
                    rezult.BrojSobaStan = item.BrojSoba;
                    rezult.PovrsinaStan = item.Povrsina;
                    rezult.KatastarskaCesticaStan = item.KatastarskaCestica;
                    rezult.KatastarskaCesticaOpcinaStan = item.KatastarskaCesticaOpcina;

                    if (item.Opis != null)
                    {
                        if (item.Opis.Length > 0)
                        {
                            rezult.OpisStan = item.Opis.Trim();
                        }
                    }

                    else
                    {
                        rezult.OpisStan = item.Opis;
                    }
               
                    rezult.StanID_Zgrada = item.ID_Zgrada;

                    if (!String.IsNullOrEmpty(item.ZgradaOznaka))
                    {
                        rezult.OznakaZgrada = item.ZgradaOznaka.Trim();
                    }

                    else
                    {
                        rezult.OznakaZgrada = item.ZgradaOznaka;
                    }
           
                    rezult.NazivZgrada = item.ZgradaNaziv;

                }
            }

            else
            {
                _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                List<InLine.Model.Data.Field.UgovorStanOtkup> field = new List<InLine.Model.Data.Field.UgovorStanOtkup>();
                List<InLine.Model.Data.Filter.UgovorStanOtkup> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkup>();
                List<InLine.Model.Data.Sort.UgovorStanOtkup> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkup>();
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkup { Field = InLine.Model.Data.Field.UgovorStanOtkup.BrojStorno, Value = 0 });
                var item = _serviceUgovorStanOtkup.GetData(field, filter, sort).Select(p => p.BrojUgovor).Max();
                BrojUgovora = item;
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom();
                rezult.ID_UgovorStanOtkup = -1;
                //rezult.BrojUgovor = BrojUgovora + 1;
                //rezult.KontrolniBroj = FNS_KontrolniBroj05(rezult.BrojUgovor);
                rezult.OpisStan = String.Empty;

            }

            return PartialView("UgovorStanOtkupUnos", rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            try
            {
                _serviceZgrada = new Service.Data.Zgrada(korisnik_data);
                _serviceStan = new Service.Data.Stan(korisnik_data);
                _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                _serviceUgovorStanOtkupObrok = new Service.Data.UgovorStanOtkupObrok(korisnik_data);

                // Update ugovora
                if (viewmodel.ID_UgovorStanOtkup == -1)
                {
                    using (TransactionScope tran = new TransactionScope())
                    {
               
                        Model.Data.Item.ZgradaItem itemZgrada = new Model.Data.Item.ZgradaItem();
                        itemZgrada.BrojUgovor = viewmodel.BrojUgovor;
                        itemZgrada.Oznaka = viewmodel.OznakaZgrada.Trim();
                        itemZgrada.Naziv = "Zgrada broj " + viewmodel.OznakaZgrada;
                        itemZgrada.NazivKr = String.Empty;
                        itemZgrada.Kratica = String.Empty;
                        Model.Data.Zgrada insertZgrada = _serviceZgrada.InsertResult(itemZgrada);

                        if (insertZgrada != null)
                        {
                            if (insertZgrada.ID_Zgrada > -1)
                            {
             
                                Model.Data.Item.StanItem itemStan = new Model.Data.Item.StanItem();
                                itemStan.BrojUgovor = viewmodel.BrojUgovor;
                                itemStan.ID_Zgrada = insertZgrada.ID_Zgrada;
                                itemStan.Oznaka = viewmodel.OznakaStan.Trim();
                                itemStan.Naziv = "Stan broj " + viewmodel.OznakaStan;
                                itemStan.NazivKr = String.Empty;
                                itemStan.Kratica = String.Empty;
                                itemStan.Ulica = viewmodel.UlicaStan;
                                itemStan.KucniBroj = viewmodel.KucniBrojStan;
                                itemStan.KucniBrojDodatak = viewmodel.KucniBrojDodatakStan;
                                itemStan.ID_Posta = viewmodel.StanID_Posta;
                                itemStan.PostanskiBroj = viewmodel.StanID_Posta.ToString();
                                itemStan.Posta = viewmodel.PostaStan;
                                itemStan.Kat = viewmodel.KatStan;
                                itemStan.BrojSoba = viewmodel.BrojSobaStan;
                                itemStan.Povrsina = viewmodel.PovrsinaStan;
                                itemStan.KatastarskaCestica = viewmodel.KatastarskaCesticaStan;
                                itemStan.KatastarskaCesticaOpcina = viewmodel.KatastarskaCesticaOpcinaStan;
                                if (viewmodel.OpisStan != null)
                                {
                                    if (viewmodel.OpisStan.Length > 0)
                                    {
                                        itemStan.Opis = viewmodel.OpisStan.Trim();
                                    }
                                }
                       
                                Model.Data.Stan insertStan = _serviceStan.InsertResult(itemStan);


                                if (insertStan != null)
                                {
                                    if (insertStan.ID_Stan > -1)
                                    {
                                        Model.Data.Item.UgovorStanOtkupItem itemUgovorStanOtkup = new Model.Data.Item.UgovorStanOtkupItem();
                                        itemUgovorStanOtkup.BrojUgovor = viewmodel.BrojUgovor;
                                        itemUgovorStanOtkup.BrojAneks = 0;
                                        itemUgovorStanOtkup.BrojStorno = 0;
                                        itemUgovorStanOtkup.Datum = viewmodel.DatumUgovora;
                                        itemUgovorStanOtkup.ID_Stan = insertStan.ID_Stan;
                                        itemUgovorStanOtkup.IznosUcesce = viewmodel.IznosUcesce;
                                        itemUgovorStanOtkup.IznosUcescePlaceno = 0;
                                        itemUgovorStanOtkup.IznosUcesceNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosKredit = viewmodel.IznosKredit;
                                        itemUgovorStanOtkup.IznosKreditPlaceno = 0;
                                        itemUgovorStanOtkup.IznosKreditNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosKreditRevalorizacija = 0;
                                        itemUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno = 0;
                                        itemUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosKamata = viewmodel.IznosKamata;
                                        itemUgovorStanOtkup.IznosKamataPlaceno = 0;
                                        itemUgovorStanOtkup.IznosKamataNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosKamataRevalorizacija = 0;
                                        itemUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno = 0;
                                        itemUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosJednokratno = viewmodel.IznosJednokratno;
                                        itemUgovorStanOtkup.IznosJednokratnoPlaceno = 0;
                                        itemUgovorStanOtkup.IznosJednokratnoNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosJednokratnoValuta = viewmodel.IznosJednokratnoValuta;
                                        itemUgovorStanOtkup.IznosJednokratnoValutaPlaceno = 0;
                                        itemUgovorStanOtkup.IznosJednokratnoValutaNeplaceno = 0;
                                        itemUgovorStanOtkup.IznosKreditObrok = viewmodel.IznosKreditObrok;
                                        itemUgovorStanOtkup.IznosKamataObrok = viewmodel.IznosKamataObrok;
                                        itemUgovorStanOtkup.IznosUkupnoObrok = viewmodel.IznosUkupnoObrok;
                                        itemUgovorStanOtkup.IznosTrosakSud = 0;
                                        itemUgovorStanOtkup.IznosPovrat = 0;
                                        itemUgovorStanOtkup.IDValuta = viewmodel.IDValuta;
                                        itemUgovorStanOtkup.TecajDM = viewmodel.TecajPoUgovoru;
                                        itemUgovorStanOtkup.DatumDospijeceJednokratno = viewmodel.DatumDospijeceJednokratno;
                                        itemUgovorStanOtkup.DatumDospijeceUcesce = viewmodel.DatumDospijeceUcesce;
                                        itemUgovorStanOtkup.BrojObrok = viewmodel.BrojObrok;
                                        itemUgovorStanOtkup.BrojObrokDospjelo = viewmodel.DospijeloObroka;
                                        itemUgovorStanOtkup.DatumDospijeceObrok = viewmodel.DatumDospijeceObrok;
                                        itemUgovorStanOtkup.Pretvorba = viewmodel.IzPretvorbe;
                                        itemUgovorStanOtkup.Napomena = !String.IsNullOrEmpty(viewmodel.Napomena) ? viewmodel.Napomena : String.Empty;
                                        itemUgovorStanOtkup.NadstojnickiAdaptiran = viewmodel.NadstojnickiIliAdaptirani;
                                        itemUgovorStanOtkup.DokumentGrupa = viewmodel.DokumentGrupa;
                                        itemUgovorStanOtkup.DokumentVrsta = Convert.ToInt32(viewmodel.ID_DokumentVr);
                                        itemUgovorStanOtkup.DatumInsert = DateTime.Now;
                                        itemUgovorStanOtkup.OsobaInsert = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                                        itemUgovorStanOtkup.ID_OsobaInsert = korisnik_data.KorisnikID;
                                        itemUgovorStanOtkup.NeZateznaKamata = false;
                                        itemUgovorStanOtkup.UgovorTuzen = viewmodel.TuzeniPoOpomeni;
                                        itemUgovorStanOtkup.OtkupNadstojnicki = viewmodel.NadstojnickiIliAdaptirani;
                                        itemUgovorStanOtkup.ID_DokumentVr = viewmodel.ID_DokumentVr;
                                        Model.Data.UgovorStanOtkup insertUgovorStanOtkup = _serviceUgovorStanOtkup.InsertResult(itemUgovorStanOtkup);


                                        if (insertUgovorStanOtkup != null)
                                        {
                                            if (insertUgovorStanOtkup.ID_UgovorStanOtkup > -1)
                                            {
                                                Model.Data.Item.UgovorStanOtkupObrokItem itemUgovorStanOtkupObrok = new Model.Data.Item.UgovorStanOtkupObrokItem();
                                                itemUgovorStanOtkupObrok.ID_UgovorStanOtkup = insertUgovorStanOtkup.ID_UgovorStanOtkup;
                                                itemUgovorStanOtkupObrok.BrojUgovor = insertUgovorStanOtkup.BrojUgovor;
                                                itemUgovorStanOtkupObrok.BrojAneks = insertUgovorStanOtkup.BrojAneks;
                                                itemUgovorStanOtkupObrok.BrojStorno = insertUgovorStanOtkup.BrojStorno;

                                                if (insertUgovorStanOtkup.NadstojnickiAdaptiran == false)
                                                {
                                                    itemUgovorStanOtkupObrok.BrojObrok = 0;
                                                }
                                                else
                                                {
                                                    itemUgovorStanOtkupObrok.BrojObrok = 1;
                                                }
 

                                                if(viewmodel.VrstaUgovora == 1)
                                                {
                                                    itemUgovorStanOtkupObrok.Godina = insertUgovorStanOtkup.DatumDospijeceUcesce.Value.Year;
                                                    itemUgovorStanOtkupObrok.Mjesec = insertUgovorStanOtkup.DatumDospijeceUcesce.Value.Month;
                                                    itemUgovorStanOtkupObrok.GodinaGeneriranja = insertUgovorStanOtkup.DatumDospijeceUcesce.Value.Year;
                                                    itemUgovorStanOtkupObrok.MjesecGeneriranja = insertUgovorStanOtkup.DatumDospijeceUcesce.Value.Month;
                                                }

                                                else{

                                                    itemUgovorStanOtkupObrok.Godina = insertUgovorStanOtkup.DatumDospijeceJednokratno.Value.Year;
                                                    itemUgovorStanOtkupObrok.Mjesec = insertUgovorStanOtkup.DatumDospijeceJednokratno.Value.Month;
                                                    itemUgovorStanOtkupObrok.GodinaGeneriranja = insertUgovorStanOtkup.DatumDospijeceJednokratno.Value.Year;
                                                    itemUgovorStanOtkupObrok.MjesecGeneriranja = insertUgovorStanOtkup.DatumDospijeceJednokratno.Value.Month;
                                                }
                                       
                                                itemUgovorStanOtkupObrok.IznosJednokratno = insertUgovorStanOtkup.IznosJednokratno;
                                                itemUgovorStanOtkupObrok.IznosUcesce = insertUgovorStanOtkup.IznosUcesce;
                                                itemUgovorStanOtkupObrok.IznosPopust = 0;
                                                itemUgovorStanOtkupObrok.IznosKredit = insertUgovorStanOtkup.IznosKreditObrok;
                                                itemUgovorStanOtkupObrok.IznosKreditRevalorizacija = 0;
                                                itemUgovorStanOtkupObrok.IznosKamata = insertUgovorStanOtkup.IznosKamataObrok;
                                                itemUgovorStanOtkupObrok.IznosKamataRevalorizacija = 0;
                                                itemUgovorStanOtkupObrok.IznosKreditOstatakRevalorizacija = 0;
                                                itemUgovorStanOtkupObrok.IznosKamataOstatakRevalorizacija = 0;
                                                itemUgovorStanOtkupObrok.IznosMoratorij = 0;
                                                itemUgovorStanOtkupObrok.IDValuta = insertUgovorStanOtkup.IDValuta;
                                                itemUgovorStanOtkupObrok.IznosValuta = insertUgovorStanOtkup.IznosJednokratnoValuta;

                                                if (viewmodel.VrstaUgovora == 1)
                                                {
                                                    itemUgovorStanOtkupObrok.DatumDospijece = insertUgovorStanOtkup.DatumDospijeceObrok;
                                                }
                                                else
                                                {
                                                    itemUgovorStanOtkupObrok.DatumDospijece = insertUgovorStanOtkup.DatumDospijeceJednokratno;
                                                }

                                        
                                                itemUgovorStanOtkupObrok.TecajObrok = insertUgovorStanOtkup.TecajDM;
                                                itemUgovorStanOtkupObrok.TecajUgovor = insertUgovorStanOtkup.TecajDM;
                                                itemUgovorStanOtkupObrok.Placen = true;
                                                itemUgovorStanOtkupObrok.IzPreplate = false;
                                                itemUgovorStanOtkupObrok.DatumInsert = DateTime.Now;
                                                itemUgovorStanOtkupObrok.OsobaInsert = insertUgovorStanOtkup.OsobaInsert.Trim();
                                                itemUgovorStanOtkupObrok.ID_OsobaInsert = insertUgovorStanOtkup.ID_OsobaInsert;
                                                itemUgovorStanOtkupObrok.IznosZateznaKamata = 0;
                                                itemUgovorStanOtkupObrok.IznosObveza = 0;
                                                itemUgovorStanOtkupObrok.IznosPlaceno = 0;
                                                itemUgovorStanOtkupObrok.BrojMoratorij = 0;
                                                Model.Data.UgovorStanOtkupObrok insertUgovorStanOtkupObrok = _serviceUgovorStanOtkupObrok.InsertResult(itemUgovorStanOtkupObrok);

                                                if (insertUgovorStanOtkupObrok == null)
                                                {
                                                    Model.Data.UgovorStanOtkup modelUgovorStanOtkup = _serviceUgovorStanOtkup.FindID(insertUgovorStanOtkup.ID_UgovorStanOtkup);
                                                    if (modelUgovorStanOtkup != null)
                                                    {
                                                        Model.Data.Item.UgovorStanOtkupItem itemDeletUgovorStanOtkup = new Model.Data.Item.UgovorStanOtkupItem();
                                                        itemDeletUgovorStanOtkup.ID_UgovorStanOtkup = modelUgovorStanOtkup.ID_UgovorStanOtkup;
                                                        int deleteUgovorStanOtkup = _serviceUgovorStanOtkup.DeleteResult(itemDeletUgovorStanOtkup);

                                                        if (deleteUgovorStanOtkup > 0)
                                                        {
                                                            Model.Data.Stan modelStan = _serviceStan.FindID(insertStan.ID_Stan);
                                                            if (modelStan != null)
                                                            {
                                                                Model.Data.Item.StanItem itemDeletStan = new Model.Data.Item.StanItem();
                                                                itemDeletStan.ID_Stan = modelStan.ID_Stan;
                                                                int deleteStan = _serviceStan.DeleteResult(itemDeletStan);

                                                                if (deleteStan > 0)
                                                                {
                                                                    Model.Data.Zgrada modelZgrada = _serviceZgrada.FindID(insertZgrada.ID_Zgrada);
                                                                    if (modelZgrada != null)
                                                                    {
                                                                        Model.Data.Item.ZgradaItem itemDeletZgrada = new Model.Data.Item.ZgradaItem();
                                                                        itemDeletZgrada.ID_Zgrada = modelZgrada.ID_Zgrada;
                                                                        int deleteZgrada = _serviceZgrada.DeleteResult(itemDeletZgrada);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                
                                        
                                }

                
                                else
                                {
                                    Model.Data.Zgrada modelZgrada = _serviceZgrada.FindID(insertZgrada.ID_Zgrada);
                                    if (modelZgrada != null)
                                    {
                                        Model.Data.Item.ZgradaItem itemDeletZgrada = new Model.Data.Item.ZgradaItem();
                                        itemDeletZgrada.ID_Zgrada = modelZgrada.ID_Zgrada;
                                        int deleteZgrada = _serviceZgrada.DeleteResult(itemDeletZgrada);
                                    }
                                }
                            }
                        }

                        tran.Complete();

                      
                    }
                 
                }

                // Update ugovora
                else
                {
                    return RedirectToAction("UgovorStanOtkupEdit", viewmodel);
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        public ActionResult UgovorStanOtkupEdit(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;


            if (viewmodel.ID_UgovorStanOtkup > -1)
            {
                try
                {
                    _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                    Model.Data.UgovorStanOtkup modelUgovorStanOtkup = _serviceUgovorStanOtkup.FindID(viewmodel.ID_UgovorStanOtkup);
                    if (modelUgovorStanOtkup != null)
                    {
                        Model.Data.Item.UgovorStanOtkupItem itemEditUgovorStanOtkup = new Model.Data.Item.UgovorStanOtkupItem();
                        itemEditUgovorStanOtkup.ID_UgovorStanOtkup = modelUgovorStanOtkup.ID_UgovorStanOtkup;
                        itemEditUgovorStanOtkup.ID_Zapis = modelUgovorStanOtkup.ID_Zapis;
                        itemEditUgovorStanOtkup.BrojUgovor = viewmodel.BrojUgovor;
                        itemEditUgovorStanOtkup.BrojAneks = modelUgovorStanOtkup.BrojAneks;
                        itemEditUgovorStanOtkup.BrojStorno = modelUgovorStanOtkup.BrojStorno;
                        itemEditUgovorStanOtkup.Datum = viewmodel.DatumUgovora;
                        itemEditUgovorStanOtkup.ID_Stan = viewmodel.StanID_Stan;
                        itemEditUgovorStanOtkup.IznosUcesce = viewmodel.IznosUcesce;
                        itemEditUgovorStanOtkup.IznosUcescePlaceno = modelUgovorStanOtkup.IznosUcescePlaceno;
                        itemEditUgovorStanOtkup.IznosUcesceNeplaceno = modelUgovorStanOtkup.IznosUcesceNeplaceno;
                        itemEditUgovorStanOtkup.IznosKredit = viewmodel.IznosKredit;
                        itemEditUgovorStanOtkup.IznosKreditPlaceno = modelUgovorStanOtkup.IznosKreditPlaceno;
                        itemEditUgovorStanOtkup.IznosKreditNeplaceno = modelUgovorStanOtkup.IznosKreditNeplaceno;
                        itemEditUgovorStanOtkup.IznosKreditRevalorizacija = modelUgovorStanOtkup.IznosKreditRevalorizacija;
                        itemEditUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno = modelUgovorStanOtkup.IznosKreditRevalorizacijaPlaceno;
                        itemEditUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno = modelUgovorStanOtkup.IznosKreditRevalorizacijaNeplaceno;
                        itemEditUgovorStanOtkup.IznosKamata = viewmodel.IznosKamata;
                        itemEditUgovorStanOtkup.IznosKamataPlaceno = modelUgovorStanOtkup.IznosKamataPlaceno;
                        itemEditUgovorStanOtkup.IznosKamataNeplaceno = modelUgovorStanOtkup.IznosKamataNeplaceno;
                        itemEditUgovorStanOtkup.IznosKamataRevalorizacija = modelUgovorStanOtkup.IznosKamataRevalorizacija;
                        itemEditUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno = modelUgovorStanOtkup.IznosKamataRevalorizacijaPlaceno;
                        itemEditUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno = modelUgovorStanOtkup.IznosKamataRevalorizacijaNeplaceno;
                        itemEditUgovorStanOtkup.IznosJednokratno = viewmodel.IznosJednokratno;
                        itemEditUgovorStanOtkup.IznosJednokratnoPlaceno = modelUgovorStanOtkup.IznosJednokratnoPlaceno;
                        itemEditUgovorStanOtkup.IznosJednokratnoNeplaceno = modelUgovorStanOtkup.IznosJednokratnoNeplaceno;
                        itemEditUgovorStanOtkup.IznosJednokratnoValuta = viewmodel.IznosJednokratnoValuta;
                        itemEditUgovorStanOtkup.IznosJednokratnoValutaPlaceno = modelUgovorStanOtkup.IznosJednokratnoValutaPlaceno;
                        itemEditUgovorStanOtkup.IznosJednokratnoValutaNeplaceno = modelUgovorStanOtkup.IznosJednokratnoValutaNeplaceno;
                        itemEditUgovorStanOtkup.IznosKreditObrok = viewmodel.IznosKreditObrok;
                        itemEditUgovorStanOtkup.IznosKamataObrok = viewmodel.IznosKamataObrok;
                        itemEditUgovorStanOtkup.IznosUkupnoObrok = viewmodel.IznosUkupnoObrok;
                        itemEditUgovorStanOtkup.IznosTrosakSud = modelUgovorStanOtkup.IznosTrosakSud;
                        itemEditUgovorStanOtkup.IznosPovrat = modelUgovorStanOtkup.IznosPovrat;
                        itemEditUgovorStanOtkup.IDValuta = viewmodel.IDValuta;
                        itemEditUgovorStanOtkup.TecajDM = viewmodel.TecajPoUgovoru;
                        itemEditUgovorStanOtkup.DatumDospijeceJednokratno = viewmodel.DatumDospijeceJednokratno;
                        itemEditUgovorStanOtkup.DatumDospijeceUcesce = viewmodel.DatumDospijeceUcesce;
                        itemEditUgovorStanOtkup.BrojObrok = viewmodel.BrojObrok;
                        itemEditUgovorStanOtkup.BrojObrokDospjelo = viewmodel.DospijeloObroka;
                        itemEditUgovorStanOtkup.DatumDospijeceObrok = viewmodel.DatumDospijeceObrok;
                        itemEditUgovorStanOtkup.Pretvorba = viewmodel.IzPretvorbe;
                        itemEditUgovorStanOtkup.Napomena = !String.IsNullOrEmpty(viewmodel.Napomena) ? viewmodel.Napomena : String.Empty;
                        itemEditUgovorStanOtkup.NadstojnickiAdaptiran = viewmodel.NadstojnickiIliAdaptirani;
                        itemEditUgovorStanOtkup.DokumentGrupa = viewmodel.DokumentGrupa;
                        itemEditUgovorStanOtkup.DokumentVrsta = Convert.ToInt32(viewmodel.ID_DokumentVr);
                        itemEditUgovorStanOtkup.DatumInsert = modelUgovorStanOtkup.DatumInsert;
                        itemEditUgovorStanOtkup.OsobaInsert = modelUgovorStanOtkup.OsobaInsert;
                        itemEditUgovorStanOtkup.ID_OsobaInsert = modelUgovorStanOtkup.ID_OsobaInsert;
                        itemEditUgovorStanOtkup.DatumUpdate = DateTime.Now;
                        itemEditUgovorStanOtkup.OsobaUpdate = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                        itemEditUgovorStanOtkup.ID_OsobaUpdate = korisnik_data.KorisnikID;
                        itemEditUgovorStanOtkup.NeZateznaKamata = false;
                        itemEditUgovorStanOtkup.UgovorTuzen = viewmodel.TuzeniPoOpomeni;
                        itemEditUgovorStanOtkup.OtkupNadstojnicki = viewmodel.NadstojnickiIliAdaptirani;
                        itemEditUgovorStanOtkup.ID_DokumentVr = viewmodel.ID_DokumentVr;

                        Model.Data.UgovorStanOtkup updateUgovorStanOtkup = _serviceUgovorStanOtkup.UpdateResult(itemEditUgovorStanOtkup);

                        if (updateUgovorStanOtkup != null)
                        {
                            _serviceStan = new Service.Data.Stan(korisnik_data);
                            Model.Data.Stan modelStan = _serviceStan.FindID(viewmodel.StanID_Stan);
                            if (modelStan != null)
                            {
                                Model.Data.Item.StanItem itemEditStan = new Model.Data.Item.StanItem();
                                itemEditStan.ID_Stan = modelStan.ID_Stan;
                                itemEditStan.BrojUgovor = viewmodel.BrojUgovor;
                                itemEditStan.ID_Zgrada = viewmodel.StanID_Zgrada;
                                itemEditStan.Oznaka = viewmodel.OznakaStan;
                                itemEditStan.Naziv = viewmodel.NazivStan;
                                itemEditStan.NazivKr = String.Empty;
                                itemEditStan.Kratica = String.Empty;
                                itemEditStan.Ulica = viewmodel.UlicaStan;
                                itemEditStan.KucniBroj = viewmodel.KucniBrojStan;
                                itemEditStan.KucniBrojDodatak = viewmodel.KucniBrojDodatakStan;
                                itemEditStan.ID_Posta = viewmodel.StanID_Posta;
                                itemEditStan.PostanskiBroj = viewmodel.StanID_Posta.ToString();
                                itemEditStan.Posta = viewmodel.PostaStan;
                                itemEditStan.Kat = viewmodel.KatStan;
                                itemEditStan.BrojSoba = viewmodel.BrojSobaStan;
                                itemEditStan.Povrsina = viewmodel.PovrsinaStan;
                                itemEditStan.KatastarskaCestica = viewmodel.KatastarskaCesticaStan;
                                itemEditStan.KatastarskaCesticaOpcina = viewmodel.KatastarskaCesticaOpcinaStan;

                                if (viewmodel.OpisStan != null)
                                {
                                    if (viewmodel.OpisStan.Length > 0)
                                    {
                                        itemEditStan.Opis = viewmodel.OpisStan.Trim();
                                    }
                                }

                                Model.Data.Stan updateStan = _serviceStan.UpdateResult(itemEditStan);

                                if (updateStan != null)
                                {
                                    _serviceZgrada = new Service.Data.Zgrada(korisnik_data);
                                    Model.Data.Zgrada modelZgrada = _serviceZgrada.FindID(Convert.ToInt64(viewmodel.StanID_Zgrada));
                                    if (modelZgrada != null)
                                    {
                                        Model.Data.Item.ZgradaItem itemEditZgrada = new Model.Data.Item.ZgradaItem();
                                        itemEditZgrada.ID_Zgrada = modelZgrada.ID_Zgrada;
                                        itemEditZgrada.BrojUgovor = viewmodel.BrojUgovor;
                                        itemEditZgrada.Oznaka = viewmodel.OznakaZgrada;
                                        itemEditZgrada.Naziv = viewmodel.NazivZgrada;
                                        itemEditZgrada.NazivKr = String.Empty;
                                        itemEditZgrada.Kratica = String.Empty;

                                        Model.Data.Zgrada updateZgrada = _serviceZgrada.UpdateResult(itemEditZgrada);
                                    }
                                }
                            }
                        }
                    }
                  
                }

                catch (Exception ex)
                {
                    Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                    Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                    InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                    poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                    return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
                }

            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        public ActionResult UgovorStanOtkupDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljCustom viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            _serviceZgrada = new Service.Data.Zgrada(korisnik_data);
            _serviceStan = new Service.Data.Stan(korisnik_data);
            _serviceUgovorStanOtkupObrok = new Service.Data.UgovorStanOtkupObrok(korisnik_data);
            _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
            long Stan = 0;
            long Zgrada = 0;


            try
            {

                if (viewmodel.ID_UgovorStanOtkup != -1)
                {
                    Model.Data.Item.ZgradaItem itemZgrada = new Model.Data.Item.ZgradaItem();
                    Model.Data.Item.StanItem itemStan = new Model.Data.Item.StanItem();
                    Model.Data.Item.UgovorStanOtkupObrokItem itemUgovorStanOtkupObrok = new Model.Data.Item.UgovorStanOtkupObrokItem();
                    Model.Data.Item.UgovorStanOtkupItem itemUgovorStanOtkup = new Model.Data.Item.UgovorStanOtkupItem();

                    if (id != null)
                    {
                        itemUgovorStanOtkup.ID_UgovorStanOtkup = Convert.ToInt64(id);

                        _serviceViewUgovorStanOtkupDetalj = new Service.Data.View.UgovorStanOtkupDetalj(korisnik_data);
                        List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj>();
                        List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj>();
                        List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj>();
                        filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupDetalj.ID_UgovorStanOtkup, Value = itemUgovorStanOtkup.ID_UgovorStanOtkup });
                        InLine.Model.Data.View.UgovorStanOtkupDetalj itemKojiUgovor = _serviceViewUgovorStanOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();

                        if (itemKojiUgovor != null)
                        {
                            Stan = Convert.ToInt64(itemKojiUgovor.ID_Stan);
                            Zgrada = Convert.ToInt64(itemKojiUgovor.ID_Zgrada);
                        }

                      
                    }
                    else
                    {
                        itemUgovorStanOtkup.ID_UgovorStanOtkup = viewmodel.ID_UgovorStanOtkup;
                        Stan = viewmodel.StanID_Stan;
                        Zgrada = Convert.ToInt64(viewmodel.StanID_Zgrada);
                    }


                    using (TransactionScope tran = new TransactionScope())
                    {
                        _serviceUgovorStanOtkupObrok = new Service.Data.UgovorStanOtkupObrok(korisnik_data);
                        List<InLine.Model.Data.Field.UgovorStanOtkupObrok> field = new List<InLine.Model.Data.Field.UgovorStanOtkupObrok>();
                        List<InLine.Model.Data.Filter.UgovorStanOtkupObrok> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupObrok>();
                        List<InLine.Model.Data.Sort.UgovorStanOtkupObrok> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupObrok>();
                        filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupObrok { Field = InLine.Model.Data.Field.UgovorStanOtkupObrok.ID_UgovorStanOtkup, Value = itemUgovorStanOtkup.ID_UgovorStanOtkup });
                        List<InLine.Model.Data.UgovorStanOtkupObrok> itemKojiUgovorStanOtkupObrok = _serviceUgovorStanOtkupObrok.GetData(field, filter, sort).ToList();

                        if (itemKojiUgovorStanOtkupObrok != null)
                        {
                            if (itemKojiUgovorStanOtkupObrok.Count == 1)
                            {
                                itemUgovorStanOtkupObrok.ID_UgovorStanOtkupObrok = itemKojiUgovorStanOtkupObrok.ElementAt(0).ID_UgovorStanOtkupObrok;
                                int deleteUgovorStanOtkupObrok = _serviceUgovorStanOtkupObrok.DeleteResult(itemUgovorStanOtkupObrok);

                                if (deleteUgovorStanOtkupObrok > 0)
                                {
                                    int deleteUgovorStanOtkup = _serviceUgovorStanOtkup.DeleteResult(itemUgovorStanOtkup);

                                    if (deleteUgovorStanOtkup > 0 && Stan > 0)
                                    {
                                        itemStan.ID_Stan = Stan;
                                        int deleteStan = _serviceStan.DeleteResult(itemStan);

                                        if (deleteStan > 0 && Zgrada > 0)
                                        {
                                            itemZgrada.ID_Zgrada = Zgrada;
                                            int deleteZgrada = _serviceZgrada.DeleteResult(itemZgrada);
                                        }

                                    }
                                }
                            }
                        }
                        
                        tran.Complete();
                    }


                }


            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetDokumentVr(long idDokumentVr)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            InLine.Model.Data.DokumentVr item = new InLine.Model.Data.DokumentVr();
            InLine.Model.Data.DokumentVr rezult = new InLine.Model.Data.DokumentVr();


            try
            {
               _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);
               item = _serviceDokumentVr.FindID(idDokumentVr);

               rezult = new InLine.Model.Data.DokumentVr()
               {
                     ID_DokumentVr = item.ID_DokumentVr,
                     Oznaka = item.Oznaka,
                     Naziv = item.Naziv,
                     NazivKr = item.NazivKr,
                     Kratica = item.Kratica,
                     Opis = item.Opis,
                     IDDokumentGr = item.IDDokumentGr,
                     Obrocni = item.Obrocni,
                     Jednokratni = item.Jednokratni,
                     Kupac = item.Kupac,
                     Partner = item.Partner,
                     Ugovor = item.Ugovor,
                     Faktura = item.Faktura,
                     Nalog = item.Nalog

               };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetBrojUgovor(int BrojUgovor)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            IEnumerable <InLine.Model.Data.UgovorStanOtkup> rezult = new List<InLine.Model.Data.UgovorStanOtkup>();

            try
            {
                _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);

                List<InLine.Model.Data.Field.UgovorStanOtkup> field = new List<InLine.Model.Data.Field.UgovorStanOtkup>();
                List<InLine.Model.Data.Filter.UgovorStanOtkup> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkup>();
                List<InLine.Model.Data.Sort.UgovorStanOtkup> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkup>();
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkup { Field = InLine.Model.Data.Field.UgovorStanOtkup.BrojUgovor, Value = BrojUgovor});
                rezult = _serviceUgovorStanOtkup.GetData(field, filter, sort).ToList();
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return Json(rezult.Count(), JsonRequestBehavior.AllowGet);

        }

        public int FNS_KontrolniBroj05(int Broj)
        {
            int KontrolniBroj = 0;
            long Umnozak = 0;
	        int Ostatak = 0;
	        int Mnozitelj = 2;

            while (Broj != 0)
            {
                Umnozak = Umnozak + (Broj % 10) * Mnozitelj;
                Broj = Broj / 10;
                Mnozitelj = Mnozitelj + 1;
            }

            Ostatak = (int)Umnozak % 11;
            KontrolniBroj = 11 - Ostatak;

            if((KontrolniBroj == 10) || (KontrolniBroj == 11))
            {
                 KontrolniBroj = 0;
            }


	        return KontrolniBroj;
        }

        # endregion



        # region Aneks

        public ActionResult UgovorStanOtkupAneksDetalj(long? Id, long? IdMaster)
        {
            _serviceViewUgovorStanOtkupAneksDetalj = new Service.Data.View.UgovorStanOtkupAneksDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupAneksDetaljFormFormatted rezult = null;
            int BrojUgovora = 0;


            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            _serviceDokumentVr = new Service.Data.DokumentVr(korisnik_data);
            List<SelectListItem> DokumentVrstaCombo = new List<SelectListItem>();
            DokumentVrstaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
            ViewBag.DokumentVrsta = new SelectList(DokumentVrstaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.UgovorStanOtkupAneksDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupAneksDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupAneksDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupAneksDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupAneksDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupAneksDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupAneksDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupAneksDetalj.ID_UgovorStanOtkupAneks, Value = Convert.ToInt64(Id) });
                InLine.Model.Data.View.UgovorStanOtkupAneksDetalj item = _serviceViewUgovorStanOtkupAneksDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupAneksDetaljFormFormatted(item);

                if (item != null)
                {
                    if (IdMaster != null)
                    {
                        _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                        var modelUgovor = _serviceUgovorStanOtkup.FindID(Convert.ToInt64(IdMaster));

                        if (modelUgovor != null)
                        {

                            if (modelUgovor.ID_DokumentVr != null)
                            {
    
                                Model.Data.DokumentVr modelDokumentVr = _serviceDokumentVr.FindID(Convert.ToInt64(modelUgovor.ID_DokumentVr));
                                if (modelDokumentVr != null)
                                {
                                    rezult.DokumentVrstaOznakaAneks = modelDokumentVr.Oznaka;

                                    if (modelDokumentVr.Obrocni == true)
                                    {
                                        rezult.VrstaUgovoraAneks = 1;
                                    }

                                    else
                                    {
                                        rezult.VrstaUgovoraAneks = 2;
                                    }

                                    DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 2).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();

                                }

                            }

                        }
                    }


                    DokumentVrstaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
                    ViewBag.DokumentVrstaAneks = new SelectList(DokumentVrstaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
                }
            }

            else
            {
                _serviceViewUgovorStanOtkupAneksDetalj = new Service.Data.View.UgovorStanOtkupAneksDetalj(korisnik_data);
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupAneksDetaljFormFormatted();
                rezult.ID_UgovorStanOtkupAneks = -1;
                long IznosKreditPlaceno = 0;

     
                if (IdMaster != null)
                {
                    _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                    var model = _serviceUgovorStanOtkup.FindID(Convert.ToInt64(IdMaster));

                    if(model != null)
                    {
                        rezult.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
                        rezult.KontrolniBroj = FNS_KontrolniBroj05(model.BrojUgovor);
                        rezult.BrojUgovor = model.BrojUgovor;
                        rezult.IznosTrosakSud = model.IznosTrosakSud;
                        rezult.NadstojnickiAdaptiran = model.NadstojnickiAdaptiran;
                        rezult.Mjesec = DateTime.Now.Month;
                        rezult.Godina = DateTime.Now.Year;
                        rezult.DatumAneks = DateTime.Now;


                        if (model.ID_DokumentVr != null)
                        {
                            Model.Data.DokumentVr modelDokumentVr = _serviceDokumentVr.FindID(Convert.ToInt64(model.ID_DokumentVr));
                            if (modelDokumentVr != null)
                            {
                                rezult.DokumentVrstaOznakaAneks = modelDokumentVr.Oznaka;

                                if (modelDokumentVr.Obrocni == true)
                                {
                                    rezult.VrstaUgovoraAneks = 1;
                                }

                                else
                                {
                                    rezult.VrstaUgovoraAneks = 2;
                                }


                                DokumentVrstaCombo = _serviceDokumentVr.SelectResult(null).Where(p => p.IDDokumentGr == 2).Select(c => new SelectListItem() { Value = c.ID_DokumentVr.ToString(), Text = c.Naziv }).ToList();
                                DokumentVrstaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
                                ViewBag.DokumentVrstaAneks = new SelectList(DokumentVrstaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
                            }

                        }


                         // izračunata polja:
                         InLine.Model.Data.View.UgovorStanOtkupObrokIznos izracunatiIznosi  = AneksIznosi(Convert.ToInt64(IdMaster));

                        if (izracunatiIznosi != null)
                        {
                            rezult.IznosKreditPlaceno = Convert.ToDecimal(izracunatiIznosi.IznosKredit);
                            rezult.IznosKamataPlaceno = Convert.ToDecimal(izracunatiIznosi.IznosKamata);
                            rezult.IznosKreditRevalorizacijaPlaceno = Convert.ToInt64(izracunatiIznosi.IznosKreditRevalorizacija);
                            rezult.IznosKamataRevalorizacijaPlaceno = Convert.ToInt64(izracunatiIznosi.IznosKamataRevalorizacija);
                            rezult.IznosUcescePlaceno = Convert.ToDecimal(izracunatiIznosi.IznosUcesce);

                            rezult.IznosKreditNeplaceno = model.IznosKredit - rezult.IznosKreditPlaceno;
                            rezult.IznosKamataNeplaceno = model.IznosKamata - rezult.IznosKamataPlaceno;
                            rezult.IznosUcesceNeplaceno = model.IznosUcesce - rezult.IznosUcescePlaceno;
                            rezult.BrojObrokDospjelo = izracunatiIznosi.BrojObrokMax;
                            rezult.BrojObrokOd = izracunatiIznosi.BrojObrokMax + 1;

                        }

                        _serviceUgovorStanOtkupAneks = new Service.Data.UgovorStanOtkupAneks(korisnik_data);
                        List<InLine.Model.Data.Field.UgovorStanOtkupAneks> field = new List<InLine.Model.Data.Field.UgovorStanOtkupAneks>();
                        List<InLine.Model.Data.Filter.UgovorStanOtkupAneks> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupAneks>();
                        List<InLine.Model.Data.Sort.UgovorStanOtkupAneks> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupAneks>();
                        filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupAneks { Field = InLine.Model.Data.Field.UgovorStanOtkupAneks.ID_UgovorStanOtkup, Value = Convert.ToInt64(IdMaster) });
                        int itemBrojAneksMax = _serviceUgovorStanOtkupAneks.GetData(field, filter, sort).ToList().Select(p => p.BrojAneks).DefaultIfEmpty().Max();
                        rezult.BrojAneks = itemBrojAneksMax + 1;



                        List<InLine.Model.Data.Tecaj> TecajPoDanu = DohvatiTecajHNB();

                        if (TecajPoDanu.Count() > 0)
                        {
                            InLine.Model.Data.Tecaj TecajST = TecajPoDanu.Where(p => p.ID_TecajVr == 1).FirstOrDefault();
                            rezult.TecajDM = Convert.ToDecimal(TecajST.Tecaj6);
                        }
                    }
                }
            }

            return PartialView(rezult);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupAneksInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupAneksDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupAneks = new Service.Data.UgovorStanOtkupAneks(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupAneks == -1)
                {
                    Model.Data.Item.UgovorStanOtkupAneksItem item = new Model.Data.Item.UgovorStanOtkupAneksItem(viewmodel);

                    item.DatumInsert = DateTime.Now;
                    item.OsobaInsert = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                    item.ID_OsobaInsert = korisnik_data.KorisnikID;

                    if (!String.IsNullOrEmpty(viewmodel.DokumentVrstaOznakaAneks))
                    {
                        if(viewmodel.DokumentVrstaOznakaAneks.Length >= 2)
                        {
                            String DokVrsta = viewmodel.DokumentVrstaOznakaAneks;
                            DokVrsta = DokVrsta.Substring(DokVrsta.Length - 2);
                            DokVrsta = DokVrsta.TrimStart('0');
                            item.DokumentVrsta = Convert.ToInt32(DokVrsta);
                        }
                 
                    }
              
                    Model.Data.UgovorStanOtkupAneks insert = _serviceUgovorStanOtkupAneks.InsertResult(item);
                }
                else
                {
                    Model.Data.UgovorStanOtkupAneks model = _serviceUgovorStanOtkupAneks.FindID(viewmodel.ID_UgovorStanOtkupAneks);

                    if (model != null)
                    {
                        Model.Data.Item.UgovorStanOtkupAneksItem item = new Model.Data.Item.UgovorStanOtkupAneksItem(viewmodel);
                        item.DatumInsert = viewmodel.DatumInsert;
                        item.OsobaInsert = viewmodel.OsobaInsert;
                        item.DatumUpdate = DateTime.Now;
                        item.OsobaUpdate = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                        item.ID_OsobaUpdate = korisnik_data.KorisnikID;

                        if (viewmodel.DokumentVrstaOznakaAneks.Length >= 2)
                        {
                            String DokVrsta = viewmodel.DokumentVrstaOznakaAneks;
                            DokVrsta = DokVrsta.Substring(DokVrsta.Length - 2);
                            DokVrsta = DokVrsta.TrimStart('0');
                            item.DokumentVrsta = Convert.ToInt32(DokVrsta);
                        }

                        Model.Data.UgovorStanOtkupAneks update = _serviceUgovorStanOtkupAneks.UpdateResult(item);
                    }
                }
            }



            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public ActionResult UgovorStanOtkupAneksDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupAneksDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupAneks = new Service.Data.UgovorStanOtkupAneks(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupAneks != -1)
                {
                    Model.Data.Item.UgovorStanOtkupAneksItem item = new Model.Data.Item.UgovorStanOtkupAneksItem();
                    if (id != null)
                    {
                        item.ID_UgovorStanOtkupAneks = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_UgovorStanOtkupAneks = viewmodel.ID_UgovorStanOtkupAneks;
                    }

                    int delete = _serviceUgovorStanOtkupAneks.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public InLine.Model.Data.View.UgovorStanOtkupObrokIznos AneksIznosi(long Id)
        {
            _serviceViewUgovorStanOtkupObrokIznos = new Service.Data.View.UgovorStanOtkupObrokIznos(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokIznos> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokIznos>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos { Field = InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos.ID_UgovorStanOtkup, Value = Convert.ToInt64(Id) });
            var item = _serviceViewUgovorStanOtkupObrokIznos.GetData(field, filter, sort).FirstOrDefault();
            return item;
        }


        public ActionResult AneksIznosiSaTecaj(long idUgovorStanOtkup, decimal iznosTecaj)
        {

            _serviceViewUgovorStanOtkupObrokIznos = new Service.Data.View.UgovorStanOtkupObrokIznos(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokIznos> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokIznos>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupObrokIznos { Field = InLine.Model.Data.Field.View.UgovorStanOtkupObrokIznos.ID_UgovorStanOtkup, Value = Convert.ToInt64(idUgovorStanOtkup) });
            var rezult = _serviceViewUgovorStanOtkupObrokIznos.GetData(field, filter, sort).FirstOrDefault();


            _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
            var model = _serviceUgovorStanOtkup.FindID(Convert.ToInt64(idUgovorStanOtkup));

            if (model != null)
            {
                if (model.TecajDM > 0)
                {
                    decimal a = Convert.ToDecimal((model.IznosKredit / model.TecajDM));
                    decimal b = a * CommonFunctions.OtkupStanovaVrijednosti.KoeficijentDemEur;
                    decimal c = b * Convert.ToDecimal(iznosTecaj);
                    decimal d = c - Convert.ToDecimal(rezult.IznosKredit);


                    rezult.IznosKreditRevalorizacija = (Convert.ToDecimal((model.IznosKredit / model.TecajDM) * CommonFunctions.OtkupStanovaVrijednosti.KoeficijentDemEur) *  Convert.ToDecimal(iznosTecaj) - rezult.IznosKredit);
                    rezult.IznosKamataRevalorizacija = (Convert.ToDecimal((model.IznosKamata / model.TecajDM)) * CommonFunctions.OtkupStanovaVrijednosti.KoeficijentDemEur) * Convert.ToDecimal(iznosTecaj) - rezult.IznosKamata;
                    rezult.IznosKreditRevalorizacija = decimal.Round(Convert.ToDecimal(rezult.IznosKreditRevalorizacija), 2, MidpointRounding.AwayFromZero);
                    rezult.IznosKamataRevalorizacija = decimal.Round(Convert.ToDecimal(rezult.IznosKamataRevalorizacija), 2, MidpointRounding.AwayFromZero);
                }
            }

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }


        public List<InLine.Model.Data.Tecaj> DohvatiTecajHNB()
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            List<InLine.Model.Data.Tecaj> rezult = new List<InLine.Model.Data.Tecaj>();
            String BankaNaziv= "Narodna banka Hrvatske";

            try
            {
                _serviceBanka= new Service.Data.Banka(korisnik_data);
                InLine.Model.Data.Banka bank = _serviceBanka.SelectResult(null).Where(p => p.Naziv.Trim().ToUpper().Contains(BankaNaziv.Trim().ToUpper())).FirstOrDefault();

                if(bank != null)
                {
                    _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                    InLine.Model.Data.TecajLista tl = _serviceTecajLista.SelectResult(null).Where(p => p.Datum == DateTime.Now.Date && p.ID_Banka == bank.ID_Banka).OrderByDescending(p => p.RedniBroj).FirstOrDefault();

                    if (tl != null)
                    {
                        _serviceTecajListaSt = new Service.Data.TecajListaSt(korisnik_data);
                        InLine.Model.Data.TecajListaSt tlSt = _serviceTecajListaSt.SelectResult(null).Where(p => p.ID_TecajLista == tl.ID_TecajLista && p.IDValutaIz.Equals("EUR") && p.IDValutaU.Equals("HRK")).FirstOrDefault();

                        if (tlSt != null)
                        {
                            _serviceTecaj = new Service.Data.Tecaj(korisnik_data);
                            List<InLine.Model.Data.Tecaj> t = _serviceTecaj.SelectResult(null).Where(p => p.ID_TecajListaSt == tlSt.ID_TecajListaSt).ToList();
                            rezult = t;
                        }
                    }
                }
                   
            }
            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }


            return rezult;

        }

           

        # endregion


        #region Stan

        public ActionResult StanDetalj(long? Id, long? IdMaster)
        {
            _serviceViewStanDetalj = new Service.Data.View.StanDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.StanDetaljFormFormatted rezult;


            _servicePosta = new Service.Data.Posta(korisnik_data);
            List<SelectListItem> IDPostaCombo = new List<SelectListItem>();
            IDPostaCombo = _servicePosta.SelectResult(null).Select(c => new SelectListItem() { Value = c.ID_Posta.ToString(), Text = c.Oznaka + " " + c.Naziv }).ToList();
            IDPostaCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
            ViewBag.IDPosta = new SelectList(IDPostaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            if (Id != null)
            {
                _serviceViewStanDetalj = new Service.Data.View.StanDetalj(korisnik_data);
                List<InLine.Model.Data.Field.View.StanDetalj> field = new List<InLine.Model.Data.Field.View.StanDetalj>();
                List<InLine.Model.Data.Filter.View.StanDetalj> filter = new List<InLine.Model.Data.Filter.View.StanDetalj>();
                List<InLine.Model.Data.Sort.View.StanDetalj> sort = new List<InLine.Model.Data.Sort.View.StanDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.StanDetalj { Field = InLine.Model.Data.Field.View.StanDetalj.ID_Stan, Value = Convert.ToInt64(Id) });
                var item = _serviceViewStanDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.StanDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.StanDetaljFormFormatted();
            }

            return PartialView(rezult);
        }

        #endregion


        #region Kupac

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KupacGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKupac = new Service.Data.View.Kupac(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.KupacViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.KupacViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewKupac.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKupac.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KupacGridFormatted>(Convert.ToString(item.ID_Kupac), new KupacGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }

        public ActionResult KupacDetalj(long? Id, long? IdMaster)
        {
            _serviceViewKupacDetalj = new Service.Data.View.KupacDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted rezult;


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.KupacDetalj> field = new List<InLine.Model.Data.Field.View.KupacDetalj>();
                List<InLine.Model.Data.Filter.View.KupacDetalj> filter = new List<InLine.Model.Data.Filter.View.KupacDetalj>();
                List<InLine.Model.Data.Sort.View.KupacDetalj> sort = new List<InLine.Model.Data.Sort.View.KupacDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KupacDetalj { Field = InLine.Model.Data.Field.View.KupacDetalj.ID_Kupac, Value = Convert.ToInt64(Id) });
                var item = _serviceViewKupacDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted(item);
                rezult.OznakaKupac = item.Oznaka;
                rezult.JMBGKupac = item.JMBG;
                rezult.UlicaKupac = item.Ulica;
                rezult.KucniBrojKupac = item.KucniBroj;
                rezult.KucniBrojDodatakKupac = item.KucniBrojDodatak;
                rezult.PostanskiBrojKupac = item.PostanskiBroj;
                rezult.PostaKupac = item.Posta;
                rezult.OIBKupac = item.OIB;


                if (item.Naziv.Length > 0)
                {
                    String NazivTrimani = item.Naziv.Trim();
                    int prviSpace = NazivTrimani.IndexOf(" ");
                    string[] ImeIPrezime = NazivTrimani.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (ImeIPrezime.Count() >= 2)
                    {
                        rezult.PrezimeKupac = ImeIPrezime.ElementAt(0);
                        rezult.ImeKupac = ImeIPrezime.ElementAt(1);
                    }

                }
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted();
                _serviceSubjekt = new Service.Data.Subjekt(korisnik_data);
                List<InLine.Model.Data.Field.Subjekt> field = new List<InLine.Model.Data.Field.Subjekt>();
                List<InLine.Model.Data.Filter.Subjekt> filter = new List<InLine.Model.Data.Filter.Subjekt>();
                List<InLine.Model.Data.Sort.Subjekt> sort = new List<InLine.Model.Data.Sort.Subjekt>();
                int itemOznaka = _serviceSubjekt.GetData(field, filter, sort).Select(p => Convert.ToInt32(p.Oznaka)).Max();
                itemOznaka = itemOznaka + 1;
                rezult.OznakaKupac = itemOznaka.ToString();
                rezult.ID_Kupac = -1;

                if (IdMaster != null)
                {
                    rezult.ID_UgovorStanOtkupKupac = Convert.ToInt64(IdMaster);
                }

            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KupacInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
         
                if (viewmodel.ID_Kupac == -1)
                {

                      _serviceOsoba = new Service.Data.Osoba(korisnik_data);

                        Model.Data.Item.OsobaItem itemOsoba = new Model.Data.Item.OsobaItem();
                        itemOsoba.Oznaka = viewmodel.OznakaKupac;
                        itemOsoba.Prezime = viewmodel.PrezimeKupac;
                        itemOsoba.Ime = viewmodel.ImeKupac;
                        itemOsoba.DatumRodenja = DateTime.MinValue;
                        itemOsoba.OIB = viewmodel.OIBKupac;
                        itemOsoba.JMBG = viewmodel.JMBGKupac;

                        Model.Data.Osoba insertOsoba = _serviceOsoba.InsertResult(itemOsoba);

                        if (insertOsoba != null)
                        {
                            _serviceKupac = new Service.Data.Kupac(korisnik_data);

                            Model.Data.Item.KupacItem itemKupac = new Model.Data.Item.KupacItem();
                            itemKupac.Oznaka = viewmodel.OznakaKupac;
                            itemKupac.Naziv = viewmodel.PrezimeKupac + " " + viewmodel.ImeKupac;
                            itemKupac.OIB = viewmodel.OIBKupac;
                            itemKupac.JMBG = viewmodel.JMBGKupac;
                            itemKupac.Ulica = viewmodel.UlicaKupac;
                            itemKupac.KucniBroj = viewmodel.KucniBrojKupac;
                            itemKupac.KucniBrojDodatak = viewmodel.KucniBrojDodatakKupac;
                            itemKupac.PostanskiBroj = viewmodel.PostanskiBrojKupac;
                            itemKupac.Posta = viewmodel.PostaKupac;
                            itemKupac.ID_Posta = viewmodel.ID_PostaKupac;
                            itemKupac.ID_Subjekt = insertOsoba.ID_Subjekt;

                            Model.Data.Kupac insertKupac = _serviceKupac.InsertResult(itemKupac);

                            if (insertKupac == null)
                            {
                                //Model.Data.Osoba modelOsoba = _serviceOsoba.FindID(insertOsoba.ID_Osoba);

                                Model.Data.Item.OsobaItem itemDeletOsoba = new Model.Data.Item.OsobaItem();
                                itemDeletOsoba.ID_Osoba = insertOsoba.ID_Osoba;
                                int deleteOsoba = _serviceOsoba.DeleteResult(itemDeletOsoba);

                            }

                            else
                            {
                                Model.Admin.StatusPoruka porukaID_unesen = new Model.Admin.StatusPoruka();
                                porukaID_unesen.PorukaTekst = "XKupac_" + insertKupac.ID_Kupac.ToString();
                                porukaID_unesen.StatusTekst = "3";

                                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(porukaID_unesen, korisnik_data);
                            }

                    }

                }
                else
                {
                    _serviceKupac = new Service.Data.Kupac(korisnik_data);
                    Model.Data.Kupac modelKupac = _serviceKupac.FindID(viewmodel.ID_Kupac);

                    if (modelKupac != null)
                    {
                        Model.Data.Item.KupacItem itemKupac = new Model.Data.Item.KupacItem(viewmodel);
                        itemKupac.Oznaka = viewmodel.OznakaKupac;
                        itemKupac.Naziv = viewmodel.PrezimeKupac + " " + viewmodel.ImeKupac;
                        itemKupac.JMBG = viewmodel.JMBGKupac;
                        itemKupac.Ulica = viewmodel.UlicaKupac;
                        itemKupac.KucniBroj = viewmodel.KucniBrojKupac;
                        itemKupac.KucniBrojDodatak = viewmodel.KucniBrojDodatakKupac;
                        itemKupac.PostanskiBroj = viewmodel.PostanskiBrojKupac;
                        itemKupac.Posta = viewmodel.PostaKupac;
                        itemKupac.ID_Posta = viewmodel.ID_PostaKupac;
                        itemKupac.ID_Subjekt = modelKupac.ID_Subjekt;
                      
                        Model.Data.Kupac updateKupac = _serviceKupac.UpdateResult(itemKupac);

                        if (updateKupac != null)
                        {
                            if (modelKupac.ID_Subjekt != null)
                            {
                                _serviceOsoba = new Service.Data.Osoba(korisnik_data);

                                List<InLine.Model.Data.Field.Osoba> field = new List<InLine.Model.Data.Field.Osoba>();
                                List<InLine.Model.Data.Filter.Osoba> filter = new List<InLine.Model.Data.Filter.Osoba>();
                                List<InLine.Model.Data.Sort.Osoba> sort = new List<InLine.Model.Data.Sort.Osoba>();
                                filter.Add(new InLine.Model.Data.Filter.Osoba { Field = InLine.Model.Data.Field.Osoba.ID_Subjekt, Value = Convert.ToInt64(modelKupac.ID_Subjekt)});
                                var item = _serviceOsoba.GetData(field, filter, sort).FirstOrDefault();

                                if (item != null)
                                {
                                    Model.Data.Item.OsobaItem itemOsoba = new Model.Data.Item.OsobaItem();
                                    itemOsoba.ID_Osoba = item.ID_Osoba;
                                    itemOsoba.ID_Subjekt = item.ID_Subjekt;
                                    itemOsoba.Oznaka = item.Oznaka;
                                    itemOsoba.Prezime = viewmodel.PrezimeKupac;
                                    itemOsoba.Ime = viewmodel.ImeKupac;
                                    itemOsoba.DatumRodenja = item.DatumRodenja;
                                    Model.Data.Osoba updateOsoba = _serviceOsoba.UpdateResult(itemOsoba);
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public ActionResult KupacDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                //_serviceKupac = new Service.Data.Kupac(korisnik_data);
                //_serviceOsoba= new Service.Data.Osoba(korisnik_data);

                if (viewmodel.ID_Kupac != -1)
                {
                    Model.Data.Item.KupacItem itemKupac = new Model.Data.Item.KupacItem();
                    if (id != null)
                    {
                        itemKupac.ID_Kupac = Convert.ToInt64(id);
                    }
                    else
                    {
                        itemKupac.ID_Kupac = viewmodel.ID_Kupac;
                    }

                     _serviceKupac = new Service.Data.Kupac(korisnik_data);
                     Model.Data.Kupac modelKupac = new Model.Data.Kupac();
                     modelKupac = _serviceKupac.FindID(Convert.ToInt32(itemKupac.ID_Kupac));

                     if (modelKupac != null)
                     {
                         if (modelKupac.ID_Subjekt != null)
                         {
                             _serviceOsoba = new Service.Data.Osoba(korisnik_data);
                             List<InLine.Model.Data.Field.Osoba> field = new List<InLine.Model.Data.Field.Osoba>();
                             List<InLine.Model.Data.Filter.Osoba> filter = new List<InLine.Model.Data.Filter.Osoba>();
                             List<InLine.Model.Data.Sort.Osoba> sort = new List<InLine.Model.Data.Sort.Osoba>();
                             filter.Add(new InLine.Model.Data.Filter.Osoba { Field = InLine.Model.Data.Field.Osoba.ID_Subjekt, Value = Convert.ToInt64(modelKupac.ID_Subjekt) });
                             Model.Data.Osoba modelOsoba = _serviceOsoba.GetData(field, filter, sort).FirstOrDefault();

                             if (modelOsoba != null)
                             {
                                 _serviceKupac = new Service.Data.Kupac(korisnik_data);
                                  int deleteKupac = _serviceKupac.DeleteResult(itemKupac);


                                 if (deleteKupac > 0)
                                 {
                                     Model.Data.Item.OsobaItem itemOsoba = new Model.Data.Item.OsobaItem();
                                     itemOsoba.ID_Osoba = modelOsoba.ID_Osoba;
                                     int deleteOsoba = _serviceOsoba.DeleteResult(itemOsoba);
                                 }
                             }
                         }
                     }
 
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);
        }


        public ActionResult UgovorStanOtkupKupacDetalj(long? Id, long? IdMaster)
        {
            _serviceViewUgovorStanOtkupKupacDetalj = new Service.Data.View.UgovorStanOtkupKupacDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupKupacDetaljFormFormatted rezult;


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.UgovorStanOtkupKupacDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupKupacDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupKupacDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupKupacDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupKupacDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupKupacDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupKupacDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupKupacDetalj.ID_UgovorStanOtkupKupac, Value = Convert.ToInt64(Id) });
                var item = _serviceViewUgovorStanOtkupKupacDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupKupacDetaljFormFormatted(item);

                if (item != null)
                {
                    if (item.Naziv.Length > 0)
                    {
                        String NazivTrimani = item.Naziv.Trim();
                        int prviSpace = NazivTrimani.IndexOf(" ");
                        string[] ImeIPrezime = NazivTrimani.Split(new char[] {' '}, 2, StringSplitOptions.RemoveEmptyEntries);
                        if (ImeIPrezime.Count() >= 2)
                        {
                            rezult.PrezimeUgovorStanOtkupKupac = ImeIPrezime.ElementAt(0);
                            rezult.ImeUgovorStanOtkupKupac = ImeIPrezime.ElementAt(1);
                        }

                    }
                }
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupKupacDetaljFormFormatted();
                rezult.ID_UgovorStanOtkupKupac = -1;

                if (IdMaster != null)
                {
                    rezult.ID_UgovorStanOtkup = Convert.ToInt64(IdMaster);
                }

            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupKupacInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupKupacDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupKupac = new Service.Data.UgovorStanOtkupKupac(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupKupac == -1)
                {

                    Model.Data.Item.UgovorStanOtkupKupacItem itemUgovorStanOtkupKupac = new Model.Data.Item.UgovorStanOtkupKupacItem();
                    itemUgovorStanOtkupKupac.ID_UgovorStanOtkup = viewmodel.ID_UgovorStanOtkup;
                    itemUgovorStanOtkupKupac.ID_Kupac = viewmodel.ID_Kupac;

                    if (viewmodel.Nositelj == true)
                    {
                        int nemaNositelja = PonistiNositelj(viewmodel.ID_UgovorStanOtkup);

                        if (nemaNositelja == 0)
                        {
                            itemUgovorStanOtkupKupac.Nositelj = true;
                        }

                        else
                        {
                            itemUgovorStanOtkupKupac.Nositelj = false;
                        }
                 
                    }
                    else
                    {
                        itemUgovorStanOtkupKupac.Nositelj = false;
                    }


                    Model.Data.UgovorStanOtkupKupac insertUgovorStanOtkupKupac = _serviceUgovorStanOtkupKupac.InsertResult(itemUgovorStanOtkupKupac);

                }
                else
                {
                    Model.Data.UgovorStanOtkupKupac modelUgovorStanOtkupKupac = _serviceUgovorStanOtkupKupac.FindID(viewmodel.ID_UgovorStanOtkupKupac);

                    if (modelUgovorStanOtkupKupac != null)
                    {
                        Model.Data.Item.UgovorStanOtkupKupacItem itemUgovorStanOtkupKupac = new Model.Data.Item.UgovorStanOtkupKupacItem(viewmodel);
                        itemUgovorStanOtkupKupac.ID_UgovorStanOtkupKupac = itemUgovorStanOtkupKupac.ID_UgovorStanOtkupKupac;
                        itemUgovorStanOtkupKupac.ID_UgovorStanOtkup = viewmodel.ID_UgovorStanOtkup;
                        itemUgovorStanOtkupKupac.ID_Kupac = viewmodel.ID_Kupac;

                        if (viewmodel.Nositelj != itemUgovorStanOtkupKupac.Nositelj)
                        {
                            if (viewmodel.Nositelj == true)
                            {
                                int nemaNositelja = PonistiNositelj(viewmodel.ID_UgovorStanOtkup);

                                if (nemaNositelja == 0)
                                {
                                    itemUgovorStanOtkupKupac.Nositelj = true;
                                }

                                else
                                {
                                    itemUgovorStanOtkupKupac.Nositelj = false;
                                }

                            }
                            else
                            {
                                itemUgovorStanOtkupKupac.Nositelj = false;
                            }
                        }
                        else
                        {
                           itemUgovorStanOtkupKupac.Nositelj = viewmodel.Nositelj;
                        }

                        Model.Data.UgovorStanOtkupKupac updateUgovorStanOtkupKupac = _serviceUgovorStanOtkupKupac.UpdateResult(itemUgovorStanOtkupKupac);
                    }


                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public ActionResult UgovorStanOtkupKupacDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupKupacDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupKupac = new Service.Data.UgovorStanOtkupKupac(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupKupac != -1)
                {
                    Model.Data.Item.UgovorStanOtkupKupacItem item = new Model.Data.Item.UgovorStanOtkupKupacItem();
                    if (id != null)
                    {
                        item.ID_UgovorStanOtkupKupac = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_UgovorStanOtkupKupac = viewmodel.ID_UgovorStanOtkupKupac;
                    }

                    int delete = _serviceUgovorStanOtkupKupac.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public int PonistiNositelj(long id)
        {
            _serviceUgovorStanOtkupKupac = new Service.Data.UgovorStanOtkupKupac(korisnik_data);

            int rezult = 0;

            try
            {

                List<InLine.Model.Data.Field.UgovorStanOtkupKupac> field = new List<InLine.Model.Data.Field.UgovorStanOtkupKupac>();
                List<InLine.Model.Data.Filter.UgovorStanOtkupKupac> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupKupac>();
                List<InLine.Model.Data.Sort.UgovorStanOtkupKupac> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupKupac>();
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupKupac { Field = InLine.Model.Data.Field.UgovorStanOtkupKupac.ID_UgovorStanOtkup, Value = id });
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupKupac { Field = InLine.Model.Data.Field.UgovorStanOtkupKupac.Nositelj, Value = 1 });
                List<InLine.Model.Data.UgovorStanOtkupKupac> itemNositelj = _serviceUgovorStanOtkupKupac.GetData(field, filter, sort).ToList();


                if (itemNositelj.Count() > 0)
                {
                    rezult = itemNositelj.Count();
                    foreach (InLine.Model.Data.UgovorStanOtkupKupac it in itemNositelj)
                    {
                        it.Nositelj = false;
                        Model.Data.Item.UgovorStanOtkupKupacItem item = new Model.Data.Item.UgovorStanOtkupKupacItem(it);
                        Model.Data.UgovorStanOtkupKupac update = _serviceUgovorStanOtkupKupac.UpdateResult(item);
                    }

                    List<InLine.Model.Data.UgovorStanOtkupKupac> itemNositeljNakonPonistenja = _serviceUgovorStanOtkupKupac.GetData(field, filter, sort).ToList();

                    if (itemNositeljNakonPonistenja.Count() > 0)
                    {
                        rezult = itemNositeljNakonPonistenja.Count();
                    }

                    else
                    {
                        rezult = 0;
                    }

                }

                else
                {
                    rezult = 0;
                }
     
            }
            catch (Exception ex)
            {
                rezult = 1;
            }
               
            return rezult;

        }
       


        public ActionResult GetKupac(string query, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.Kupac> rezult = new List<InLine.Model.Data.View.Kupac>();

            //query = query.Replace(" ", "");

            query = query.TrimStart();

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {

                _serviceViewKupac = new Service.Data.View.Kupac(korisnik_data);
                List<InLine.Model.Data.Field.View.Kupac> field = new List<InLine.Model.Data.Field.View.Kupac>();
                List<InLine.Model.Data.Filter.View.Kupac> filter = new List<InLine.Model.Data.Filter.View.Kupac>();
                List<InLine.Model.Data.Sort.View.Kupac> sort = new List<InLine.Model.Data.Sort.View.Kupac>();
                rezult = _serviceViewKupac.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Ulica.ToUpper().Trim().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();


            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }


        public ActionResult GetKupacDetalj(long idKupac)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            var rezult = new InLine.Model.Data.Kupac();

            try
            {
                _serviceKupac = new Service.Data.Kupac(korisnik_data);
                Model.Data.Kupac model = _serviceKupac.FindID(idKupac);

                if (model != null)
                {
                    rezult = new InLine.Model.Data.Kupac()
                    {
                        ID_Kupac = model.ID_Kupac,
                        Oznaka = model.Oznaka,
                        Naziv = model.Naziv,
                        JMBG = model.JMBG,
                        Ulica = model.Ulica,
                        KucniBroj = model.KucniBroj,
                        KucniBrojDodatak = model.KucniBrojDodatak,
                        PostanskiBroj = model.PostanskiBroj,
                        OIB = model.OIB,
                        Posta = model.Posta,
                        ID_Posta = model.ID_Posta,
                        ID_Subjekt = model.ID_Subjekt

                    };
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

    

        # endregion


        #region UgovorStanOtkupZavrsetak

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupZavrsetakGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewUgovorStanOtkupZavrsetak = new Service.Data.View.UgovorStanOtkupZavrsetak(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.UgovorStanOtkupZavrsetakViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.UgovorStanOtkupZavrsetakViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewUgovorStanOtkupZavrsetak.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewUgovorStanOtkupZavrsetak.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<UgovorStanOtkupZavrsetakGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupZavrsetak), new UgovorStanOtkupZavrsetakGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }

        #endregion


        #region UgovorStanOtkupMoratorij

        public ActionResult UgovorStanOtkupMoratorijDetalj(long? Id, long? IdMaster)
        {
            _serviceViewUgovorStanOtkupMoratorijDetalj = new Service.Data.View.UgovorStanOtkupMoratorijDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijDetaljFormFormatted rezult;
            int BrojUgovorVM = 0;

            if (IdMaster != null)
            {
                _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
                Model.Data.UgovorStanOtkup item = _serviceUgovorStanOtkup.FindID(Convert.ToInt64(IdMaster));
                if (item != null)
                {
                    BrojUgovorVM = item.BrojUgovor;
                }
            }
           


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijDetalj.ID_UgovorStanOtkupMoratorij, Value = Convert.ToInt64(Id) });
                var item = _serviceViewUgovorStanOtkupMoratorijDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijDetaljFormFormatted();
                rezult.ID_UgovorStanOtkupMoratorij = -1;

                if (IdMaster != null)
                {
                    rezult.ID_UgovorStanOtkup = Convert.ToInt64(IdMaster);

                    _serviceUgovorStanOtkupMoratorij = new Service.Data.UgovorStanOtkupMoratorij(korisnik_data);

                    List<InLine.Model.Data.Field.UgovorStanOtkupMoratorij> field = new List<InLine.Model.Data.Field.UgovorStanOtkupMoratorij>();
                    List<InLine.Model.Data.Filter.UgovorStanOtkupMoratorij> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupMoratorij>();
                    List<InLine.Model.Data.Sort.UgovorStanOtkupMoratorij> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupMoratorij>();
                    filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupMoratorij { Field = InLine.Model.Data.Field.UgovorStanOtkupMoratorij.ID_UgovorStanOtkup, Value = Convert.ToInt64(IdMaster)});
                    var item = _serviceUgovorStanOtkupMoratorij.GetData(field, filter, sort).ToList();


                    if (item.Count() > 0)
                    {
                        int BM = item.Select(p => p.BrojMoratorij).Max();
                        rezult.BrojMoratorij = BM + 1;
                    }

                    else
                    {
                        rezult.BrojMoratorij = 1;
                    }
                
                }

                rezult.BrojUgovor = BrojUgovorVM;
                rezult.Datum = DateTime.Now;

            }

            return PartialView(rezult);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupMoratorijInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupMoratorij = new Service.Data.UgovorStanOtkupMoratorij(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupMoratorij == -1)
                {
                    Model.Data.Item.UgovorStanOtkupMoratorijItem item = new Model.Data.Item.UgovorStanOtkupMoratorijItem(viewmodel);
                    item.DatumInsert = DateTime.Now;
                    item.OsobaInsert = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                    Model.Data.UgovorStanOtkupMoratorij insert = _serviceUgovorStanOtkupMoratorij.InsertResult(item);
                }
                else
                {
                    Model.Data.UgovorStanOtkupMoratorij model = _serviceUgovorStanOtkupMoratorij.FindID(viewmodel.ID_UgovorStanOtkupMoratorij);

                    if (model != null)
                    {
                        Model.Data.Item.UgovorStanOtkupMoratorijItem item = new Model.Data.Item.UgovorStanOtkupMoratorijItem(viewmodel);
                        item.DatumInsert = viewmodel.DatumInsert;
                        item.OsobaInsert = viewmodel.OsobaInsert;
                        item.DatumUpdate = DateTime.Now;
                        item.OsobaUpdate = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                        Model.Data.UgovorStanOtkupMoratorij update = _serviceUgovorStanOtkupMoratorij.UpdateResult(item);
                    }
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public ActionResult UgovorStanOtkupMoratorijDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupMoratorij = new Service.Data.UgovorStanOtkupMoratorij(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupMoratorij != -1)
                {
                    Model.Data.Item.UgovorStanOtkupMoratorijItem item = new Model.Data.Item.UgovorStanOtkupMoratorijItem();
                    if (id != null)
                    {
                        item.ID_UgovorStanOtkupMoratorij = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_UgovorStanOtkupMoratorij = viewmodel.ID_UgovorStanOtkupMoratorij;
                    }

                    int delete = _serviceUgovorStanOtkupMoratorij.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        #endregion


        #region UgovorStanOtkupMoratorijMjesec

        public ActionResult UgovorStanOtkupMoratorijMjesecDetalj(long? Id, long? IdMaster)
        {
            _serviceViewUgovorStanOtkupMoratorijMjesecDetalj = new Service.Data.View.UgovorStanOtkupMoratorijMjesecDetalj(korisnik_data);
            
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted rezult;
            int BrojUgovorVM = 0;
            int BrojMoratorijVM = 0;

            if (IdMaster != null)
            {

                _serviceUgovorStanOtkupMoratorij = new Service.Data.UgovorStanOtkupMoratorij(korisnik_data);
                Model.Data.UgovorStanOtkupMoratorij item = _serviceUgovorStanOtkupMoratorij.FindID(Convert.ToInt64(IdMaster));

                if (item != null)
                {
                    BrojUgovorVM = Convert.ToInt32(item.BrojUgovor);
                    BrojMoratorijVM = item.BrojMoratorij;
                }
            }



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijMjesecDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijMjesecDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj.ID_UgovorStanOtkupMoratorijMjesec, Value = Convert.ToInt64(Id) });
                var item = _serviceViewUgovorStanOtkupMoratorijMjesecDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted();
                rezult.ID_UgovorStanOtkupMoratorijMjesec = -1;
                rezult.ID_UgovorStanOtkupMoratorij = Convert.ToInt64(IdMaster);
                rezult.Mjesec = DateTime.Now.Month;
                rezult.Godina = DateTime.Now.Year;
                rezult.BrojUgovor = BrojUgovorVM;
                rezult.BrojMoratorij = BrojMoratorijVM;
            }

            return PartialView(rezult);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupMoratorijMjesecInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupMoratorijMjesec = new Service.Data.UgovorStanOtkupMoratorijMjesec(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupMoratorijMjesec == -1)
                {
                    Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem item = new Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem(viewmodel);
                    item.DatumInsert = DateTime.Now;
                    item.OsobaInsert = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                    Model.Data.UgovorStanOtkupMoratorijMjesec insert = _serviceUgovorStanOtkupMoratorijMjesec.InsertResult(item);
                }
                else
                {
                    Model.Data.UgovorStanOtkupMoratorijMjesec model = _serviceUgovorStanOtkupMoratorijMjesec.FindID(viewmodel.ID_UgovorStanOtkupMoratorijMjesec);

                    if (model != null)
                    {
                        Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem item = new Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem(viewmodel);
                        item.DatumInsert = viewmodel.DatumInsert;
                        item.OsobaInsert = viewmodel.OsobaInsert;
                        item.DatumUpdate = DateTime.Now;
                        item.OsobaUpdate = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                        Model.Data.UgovorStanOtkupMoratorijMjesec update = _serviceUgovorStanOtkupMoratorijMjesec.UpdateResult(item);
                    }
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }


        public ActionResult UgovorStanOtkupMoratorijMjesecDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceUgovorStanOtkupMoratorijMjesec = new Service.Data.UgovorStanOtkupMoratorijMjesec(korisnik_data);

                if (viewmodel.ID_UgovorStanOtkupMoratorijMjesec != -1)
                {
                    Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem item = new Model.Data.Item.UgovorStanOtkupMoratorijMjesecItem();
                    if (id != null)
                    {
                        item.ID_UgovorStanOtkupMoratorijMjesec = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_UgovorStanOtkupMoratorijMjesec = viewmodel.ID_UgovorStanOtkupMoratorijMjesec;
                    }

                    int delete = _serviceUgovorStanOtkupMoratorijMjesec.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        #endregion


        # region Opomena

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OpomenaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewOpomena = new Service.Data.View.Opomena(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.OpomenaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.OpomenaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewOpomena.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewOpomena.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<OpomenaGridFormatted>(Convert.ToString(item.ID_Opomena), new OpomenaGridFormatted(item)));



                return new JqGridJsonResult() { Data = response };
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);

            }
        }

        public ActionResult OpomenaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewOpomenaDetalj = new Service.Data.View.OpomenaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted rezult;



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.OpomenaDetalj> field = new List<InLine.Model.Data.Field.View.OpomenaDetalj>();
                List<InLine.Model.Data.Filter.View.OpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.OpomenaDetalj>();
                List<InLine.Model.Data.Sort.View.OpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.OpomenaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.OpomenaDetalj { Field = InLine.Model.Data.Field.View.OpomenaDetalj.ID_Opomena, Value = Convert.ToInt64(Id) });
                var item = _serviceViewOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted(item);

            }

            else
            {
                _serviceOpomena = new Service.Data.Opomena(korisnik_data);
                List<InLine.Model.Data.Field.Opomena> field = new List<InLine.Model.Data.Field.Opomena>();
                List<InLine.Model.Data.Filter.Opomena> filter = new List<InLine.Model.Data.Filter.Opomena>();
                List<InLine.Model.Data.Sort.Opomena> sort = new List<InLine.Model.Data.Sort.Opomena>();
                //int itemBrojOpomena = _serviceOpomena.GetData(field, filter, sort).Select(p => p.BrojOpomena).Max();
                int itemBrojOpomena = _serviceOpomena.GetData(field, filter, sort).Select(p => p.BrojOpomena).DefaultIfEmpty().Max();

                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted();
                rezult.ID_Opomena = -1;
                rezult.BrojOpomena = itemBrojOpomena + 1;
                rezult.Datum = DateTime.Now.Date;
                rezult.DatumDospijeceOd = new DateTime(1992,1,1);
            }

            return PartialView(rezult);

        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OpomenaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            try
            {
                _serviceOpomena = new Service.Data.Opomena(korisnik_data);


                if (viewmodel.ID_Opomena == -1)
                {
                    Model.Data.Item.OpomenaItem item = new Model.Data.Item.OpomenaItem(viewmodel);
                    item.DatumInsert = DateTime.Now;
                    item.OsobaInsert = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                    item.ID_OsobaInsert = korisnik_data.KorisnikID;
                    Model.Data.Opomena insert = _serviceOpomena.InsertResult(item);
                }
                else
                {
                    Model.Data.Opomena model = _serviceOpomena.FindID(viewmodel.ID_Opomena);

                    if (model != null)
                    {
                        Model.Data.Item.OpomenaItem item = new Model.Data.Item.OpomenaItem(viewmodel);
                        item.DatumUpdate = DateTime.Now;
                        item.OsobaUpdate = korisnik_data.KorisnikPrezime + " " + korisnik_data.KorisnikIme;
                        item.ID_OsobaUpdate = korisnik_data.KorisnikID;
                        Model.Data.Opomena update = _serviceOpomena.UpdateResult(item);
                    }
                }
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }




        public ActionResult OpomenaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceOpomena = new Service.Data.Opomena(korisnik_data);

                if (viewmodel.ID_Opomena != -1)
                {
                    Model.Data.Item.OpomenaItem item = new Model.Data.Item.OpomenaItem();
                    if (id != null)
                    {
                        item.ID_Opomena = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_Opomena = viewmodel.ID_Opomena;
                    }

                    int delete = _serviceOpomena.DeleteResult(item);
                }

            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorStanOtkupOpomenaGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupOpomena = new Service.Data.View.UgovorStanOtkupOpomena(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = InLine.UI.Web.Controllers.View.UgovorStanOtkupOpomenaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.UgovorStanOtkupOpomenaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupOpomena.GetCount(filterExpression, key, value, customsearch);

            var IznosDug = _serviceViewUgovorStanOtkupOpomena.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosDug);
            var IznosZateznaKamata = _serviceViewUgovorStanOtkupOpomena.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosZateznaKamata);
            var SumaIznosDugZateznaKamata = _serviceViewUgovorStanOtkupOpomena.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.SumaIznosDugZateznaKamata);


            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,

                UserData = new
                {

                    Datum = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDug + IznosZateznaKamata),
                    IznosDug = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDug),
                    IznosZateznaKamata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosZateznaKamata),
                    SumaIznosDugZateznaKamata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaIznosDugZateznaKamata)
                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupOpomena.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupOpomenaGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupOpomena), new UgovorStanOtkupOpomenaGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }


 

        #endregion


        # region Metode

        public static string UgovorStanOtkupGetFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
        {

            string searchingOperatorString = String.Empty;

            switch (searchingOperator)
            {
                case JqGridSearchOperators.Eq:
                    searchingOperatorString = "=";
                    break;
                case JqGridSearchOperators.Ne:
                    searchingOperatorString = "!=";
                    break;
                case JqGridSearchOperators.Lt:
                    searchingOperatorString = "<";
                    break;
                case JqGridSearchOperators.Le:
                    searchingOperatorString = "<=";
                    break;
                case JqGridSearchOperators.Gt:
                    searchingOperatorString = ">";
                    break;
                case JqGridSearchOperators.Ge:
                    searchingOperatorString = ">=";
                    break;
            }

            if (searchingName == "ID_UgovorStanOtkup")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }

            if (searchingName == "BrojUgovor")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }

            if (searchingName == "IznosUcesce")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosUcescePlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosUcesceNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKredit")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditRevalorizacija")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditRevalorizacijaPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditRevalorizacijaNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamata")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataRevalorizacija")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataRevalorizacijaPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataRevalorizacijaNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratnoPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratnoNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratnoValuta")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratnoValutaPlaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosJednokratnoValutaNeplaceno")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKreditObrok")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosKamataObrok")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosUkupnoObrok")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosTrosakSud")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }
            if (searchingName == "IznosPovrat")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }

            if (searchingName == "TecajDM")
            {
                String Vrijednost = ProvjeraDecimalFiltera(searchingValue);

                if (!String.IsNullOrEmpty(Vrijednost))
                {
                    return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, Vrijednost);
                }

                else
                {
                    return String.Empty;
                }
            }


            if (searchingName == "Pretvorba")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }
            if (searchingName == "NadstojnickiAdaptiran")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }
            if (searchingName == "NeZateznaKamata")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }
            if (searchingName == "UgovorTuzen")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }
            if (searchingName == "OtkupNadstojnicki")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }


            if (searchingName == "IDValuta")
            {

                switch (searchingOperator)
                {
                    case JqGridSearchOperators.Bw:
                        return String.Format("{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Bn:
                        return String.Format("!{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Ew:
                        return String.Format("{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.En:
                        return String.Format("!{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Cn:
                        return String.Format("{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Nc:
                        return String.Format("!{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    default:
                        return String.Format("{0} {1} \"{2}\"", searchingName, searchingOperatorString, searchingValue);
                }
            }
            if (searchingName == "Napomena")
            {

                switch (searchingOperator)
                {
                    case JqGridSearchOperators.Bw:
                        return String.Format("{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Bn:
                        return String.Format("!{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Ew:
                        return String.Format("{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.En:
                        return String.Format("!{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Cn:
                        return String.Format("{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Nc:
                        return String.Format("!{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    default:
                        return String.Format("{0} {1} \"{2}\"", searchingName, searchingOperatorString, searchingValue);
                }
            }
            if (searchingName == "OsobaInsert")
            {

                switch (searchingOperator)
                {
                    case JqGridSearchOperators.Bw:
                        return String.Format("{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Bn:
                        return String.Format("!{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Ew:
                        return String.Format("{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.En:
                        return String.Format("!{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Cn:
                        return String.Format("{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Nc:
                        return String.Format("!{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    default:
                        return String.Format("{0} {1} \"{2}\"", searchingName, searchingOperatorString, searchingValue);
                }
            }
            if (searchingName == "OsobaUpdate")
            {

                switch (searchingOperator)
                {
                    case JqGridSearchOperators.Bw:
                        return String.Format("{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Bn:
                        return String.Format("!{0}.StartsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Ew:
                        return String.Format("{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.En:
                        return String.Format("!{0}.EndsWith(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Cn:
                        return String.Format("{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    case JqGridSearchOperators.Nc:
                        return String.Format("!{0}.Contains(\"{1}\")", searchingName, searchingValue);
                    default:
                        return String.Format("{0} {1} \"{2}\"", searchingName, searchingOperatorString, searchingValue);
                }
            }

            return String.Empty;
        }

        private static String ProvjeraDecimalFiltera(String searchingValue)
        {
            String rezultat = String.Empty;
            String prviZnak = String.Empty;
            char znakMinus = (char)45;

            if (searchingValue.Length > 0)
            {
                prviZnak = searchingValue.Substring(0, 1);

                if (prviZnak == znakMinus.ToString())
                {
                    searchingValue = searchingValue.Substring(1, (searchingValue.Length - 1));
                }

                string searchingValueReplaceTest = searchingValue.Replace(",", "");
                searchingValueReplaceTest = searchingValueReplaceTest.Replace(".", "");
                searchingValueReplaceTest = searchingValueReplaceTest.Replace(" ", "");
                bool NemaSlovo = true;

                foreach (char c in searchingValueReplaceTest)
                {
                    if (c < '0' || c > '9')
                    {
                        NemaSlovo = false;
                    }
                }

                if (NemaSlovo)
                {
                    string searchingValueReplace = searchingValue.Replace(",", ".");
                    searchingValueReplace = searchingValueReplace.Replace(" ", ".");

                    string[] separator = new string[] { "." };
                    string[] dijelovi;

                    dijelovi = searchingValueReplace.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    if (dijelovi.Count() > 0)
                    {
                        string PovratnaVrijednost = String.Empty;

                        for (int i = 0; i <= dijelovi.Length - 1; i++)
                        {
                            if (i != dijelovi.Length - 1)
                            {
                                PovratnaVrijednost += dijelovi[i];
                            }
                            else
                            {
                                if (dijelovi.Count() == 1)
                                {
                                    PovratnaVrijednost += dijelovi[i];
                                }
                                else
                                {
                                    PovratnaVrijednost = PovratnaVrijednost + "." + dijelovi[i];
                                }

                            }

                        }

                        rezultat = PovratnaVrijednost;
                    }
                    else
                    {
                        rezultat = searchingValue;
                    }
                }

                if (prviZnak == znakMinus.ToString())
                {
                    rezultat = znakMinus + rezultat;
                }
            }

            return rezultat;
        }
    # endregion

    }
}
