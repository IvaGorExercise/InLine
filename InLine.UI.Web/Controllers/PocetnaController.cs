using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Hosting;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.Objects;

namespace InLine.UI.Web.Controllers
{
    public class PocetnaController : InLine.UI.Web.Controllers.TecajListaController
    {

          # region Konstruktor


        Service.Data.IDrzava _serviceDrzava;
        Service.Data.IValuta _serviceValuta;
        Service.Data.IDrzavaValuta _serviceDrzavaValuta;

        Service.Data.IBanka _serviceBanka;

        Service.Data.View.ITecajLista _serviceViewTecajLista;
        Service.Data.ITecajLista _serviceTecajLista;
        Service.Data.View.ITecajListaDetalj _serviceViewTecajListaDetalj;

        Service.Data.ITecajVr _serviceTecajVr;

        Service.Data.View.ITecajListaSt _serviceViewTecajListaSt;
        Service.Data.View.ITecajListaStDetalj _serviceViewTecajListaStDetalj;
        Service.Data.ITecajListaSt _serviceTecajListaSt;

        Service.Data.ITecaj _serviceTecaj;


        #endregion


        public ActionResult Index()
        {
            try
            {
                string podaci = InLine.UI.Web.Helper.LogiraniKorisnikData.ShowLoiraniKorisnik();

                if (!String.IsNullOrEmpty(podaci))
                {
                    ViewData["LoiraniKorisnik"] = podaci;

                    if (!DaLiPostojiTecajnaListaNaDanasnjiDan())
                    {
                        UcitajTecajHNB();
                    }
              
                }
                else
                {
                    RedirectToAction("LogOn", "Home");
                }

            }
            catch(Exception e)
            {
                RedirectToAction("LogOn", "Home");
            }

            return View();

        }

        public bool DaLiPostojiTecajnaListaNaDanasnjiDan()
        {
            bool rezult = false;
            String BankaNaziv = "Narodna banka Hrvatske";

            _serviceBanka = new Service.Data.Banka(korisnik_data);
            InLine.Model.Data.Banka bank = _serviceBanka.SelectResult(null).Where(p => p.Naziv.Trim().ToUpper().Contains(BankaNaziv.Trim().ToUpper())).FirstOrDefault();

            if (bank != null)
            {
                _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                Model.Data.TecajLista tl = _serviceTecajLista.SelectResult(null).Where(p => p.ID_Banka == bank.ID_Banka && p.Datum == DateTime.Now.Date).FirstOrDefault();

                if(tl != null)
                {
                    rezult = true;
                }
            }

            return rezult;
        }

        public void UcitajTecajHNB()
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            List<InLine.Model.Data.Tecaj> rezult = new List<InLine.Model.Data.Tecaj>();
            String Url = "http://www.hnb.hr/tecajn/";
            String  Mapa = HostingEnvironment.MapPath("~/TMP/"); 

            try
            {
                _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                DateTime TodayDate = DateTime.Now.Date;
                String FName = "f" + TodayDate.ToString("ddMMyy") + ".dat";
                String UrlFile = Url + FName;
                String MapaFile = Mapa + FName;
                Download(UrlFile, MapaFile);
           
            }
            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

        }

        public void Download(String UrlFile, String MapaFile)
        {
            WebClient downloader = new WebClient();
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
            downloader.DownloadFileAsync(new Uri(UrlFile), MapaFile, MapaFile);
        }



        void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string FName = (string)e.UserState;
            String BankaNaziv = "Narodna banka Hrvatske";
            

            if (System.IO.File.Exists(FName))
            {
                String Sve = System.IO.File.ReadAllText(FName);

                if (Sve.Length > 0)
                {
                    IList<string> lines = Sve.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                    if (lines.Count() > 0)
                    {
                        String prvi = lines[0];

                        _serviceBanka = new Service.Data.Banka(korisnik_data);
                        InLine.Model.Data.Banka bank = _serviceBanka.SelectResult(null).Where(p => p.Naziv.Trim().ToUpper().Contains(BankaNaziv.Trim().ToUpper())).FirstOrDefault();

                        if (bank != null)
                        {
                            _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                            Model.Data.TecajLista  tl = _serviceTecajLista.SelectResult(null).Where(p => p.ID_Banka == bank.ID_Banka && p.Datum == DateTime.Now.Date).FirstOrDefault();

                            if(tl == null)
                            {
                                string TecajSt = "TecajSt";
                                string Kod = "Kod";
                                string IDValutaIz = "IDValutaIz";
                                string BrojJedinica = "BrojJedinica";
                                string TecajVrOznaka = "TecajVrOznaka";
                                string Tecaj6 = "Tecaj6";

                                Model.Data.TecajLista item = new Model.Data.TecajLista();
                                item.ID_Banka = bank.ID_Banka;
                                string Godina = prvi.Substring(15, 4);
                                string Mjesec = prvi.Substring(13, 2).TrimStart('0');
                                string Dan = prvi.Substring(11, 2).TrimStart('0');
                                item.Datum = new DateTime(Convert.ToInt32(Godina), Convert.ToInt32(Mjesec), Convert.ToInt32(Dan));
                                item.RedniBroj = 1;
                                item.Godina = item.Datum.Year;
                                item.GodinaRedniBroj = Convert.ToInt32(prvi.Substring(0, 3).TrimStart('0'));

                                XDocument listaTecaj = new XDocument();
                                lines.RemoveAt(0);
                                lines.RemoveAt(lines.Count-1);

                                XDocument xdoc = new XDocument
                                (
                                    new XElement("TecajeviLista",
                                        from line in lines
                                        select
                                        new XElement("TecajeviSt",
                                              new XElement(TecajSt,
                                                    new XElement(Kod, line.Substring(0, 3).TrimStart('0')),
                                                    new XElement(IDValutaIz, line.Substring(3, 3)),
                                                    new XElement(BrojJedinica, line.Substring(6, 3).TrimStart('0')),
                                                    new XElement(TecajVrOznaka, "KD"),
                                                    new XElement(Tecaj6, line.Substring(15,9).Replace(',', '.').Trim())
                                            ),
                                               new XElement(TecajSt,
                                                    new XElement(Kod, line.Substring(0, 3).TrimStart('0')),
                                                    new XElement(IDValutaIz, line.Substring(3, 3)),
                                                    new XElement(BrojJedinica, line.Substring(6, 3).TrimStart('0')),
                                                    new XElement(TecajVrOznaka, "SD"),
                                                    new XElement(Tecaj6, line.Substring(30, 9).Replace(',', '.').Trim())
                                            ),
                                               new XElement(TecajSt,
                                                    new XElement(Kod, line.Substring(0, 3).TrimStart('0')),
                                                    new XElement(IDValutaIz, line.Substring(3, 3)),
                                                    new XElement(BrojJedinica, line.Substring(6, 3).TrimStart('0')),
                                                    new XElement(TecajVrOznaka, "PD"),
                                                    new XElement(Tecaj6, line.Substring(45, 9).Replace(',', '.').Trim())
                                            ),
                                               new XElement(TecajSt,
                                                    new XElement(Kod, line.Substring(0, 3).TrimStart('0')),
                                                    new XElement(IDValutaIz, line.Substring(3, 3)),
                                                    new XElement(BrojJedinica, line.Substring(6, 3).TrimStart('0')),
                                                    new XElement(TecajVrOznaka, "KE"),
                                                    new XElement(Tecaj6, "1.000000")
                                            ),
                                               new XElement(TecajSt,
                                                    new XElement(Kod, line.Substring(0, 3).TrimStart('0')),
                                                    new XElement(IDValutaIz, line.Substring(3, 3)),
                                                    new XElement(BrojJedinica, line.Substring(6, 3).TrimStart('0')),
                                                    new XElement(TecajVrOznaka, "PE"),
                                                    new XElement(Tecaj6, "1.000000")

                                             )
                                        )
                                    )

                                );

                                String data = xdoc.ToString();

                                _serviceTecajListaSt = new Service.Data.TecajListaSt(korisnik_data);
                                ObjectResult<Model.Data.TecajLista> insert = _serviceTecajListaSt.TecajnaListaDownloadInsert(item, data);

                            }

                        }
                    }
                }
            }
        }
    }
}
