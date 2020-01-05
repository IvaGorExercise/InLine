using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Transactions;
using System.Data.Objects;
using FileHelpers;
using FileHelpers.DataLink;
using Stimulsoft.Report;
using System.Web.Routing;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Export;
using Stimulsoft.Report.Web;
using System.IO;
using System.Text;
using Filters.Infrastructure;
using Stimulsoft.Report.Components;
using System.Threading.Tasks;
using System.Threading;
using InLine.UI.Web.Helper;
using System.Text.RegularExpressions;
using InLine;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;



namespace InLine.UI.Web.Controllers
{
    public partial class HUB2013AController : Controller
    {
        Service.Data.IHUBNamjena2013A _serviceHUBNamjena2013A;
        Service.Data.View.IHUB2013A _serviceHUB2013AView;
        Service.Data.IHUBImport _serviceHUBImport;
        CancellationTokenSource cTokenSource = new CancellationTokenSource();
        FileStream fs;
        Service.Data.HUBImportHUB _serviceHUBImportHUB;


        public static IEnumerable<Repository.Data.Helper.CustomListItem> GetPrinters()
        {
            List<Repository.Data.Helper.CustomListItem> items = new List<Repository.Data.Helper.CustomListItem>();
            Repository.Data.Helper.CustomListItem item = new Repository.Data.Helper.CustomListItem();
            items.Add(new Repository.Data.Helper.CustomListItem { Id = 1, PrinterNaziv = KeyWord.HUB.Printeri.GradHP500 });
            items.Add(new Repository.Data.Helper.CustomListItem { Id = 2, PrinterNaziv = KeyWord.HUB.Printeri.FortiusHP });
            return items;
        }



        [HttpGet]
        public ActionResult HUBKreirajGrad(string poruka)
        {
            _serviceHUBNamjena2013A = new Service.Data.HUBNamjena2013A(korisnik_data);

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string Constring = korisnik_data.ConnStringNoMetadata;
            int Mjesec = DateTime.Now.Month;
            int Godina = DateTime.Now.Year;
            int pdfPage = KeyWord.HUB.BrojcaneVrijednosti.PdfPage;
            //int ukupno = 100;
            //int pdfBroj = (ukupno / pdfPage) + 1;
            string pdfIme = "ReportHUB.pdf";
            string putanja = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.Putanja);
            Model.Admin.StatusPoruka statusporuka = new Model.Admin.StatusPoruka();
            statusporuka.PorukaTekst = String.Empty;
            statusporuka.StatusTekst = String.Empty;
            int pokreniPonovo = 0;
            int ukupno = 0;
            int pdfBroj = 0;
            int BrojUgovorMin = KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin;
            int BrojUgovorMax = KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax;

            var IDHUBNamjena2013A = _serviceHUBNamjena2013A.SelectResult(null).Select(c => new Repository.Data.Helper.CustomListItem { IDHUBNamjena2013A = c.IDHUBNamjena2013A, OznakaNaziv = c.Oznaka + " " + c.Naziv }).ToList();
            ViewBag.IDHUBNamjena2013A = new SelectList(IDHUBNamjena2013A.AsEnumerable(), "IDHUBNamjena2013A", "OznakaNaziv");

            var Printer = GetPrinters();
            ViewBag.Printer = new SelectList(Printer.AsEnumerable(), "Id", "PrinterNaziv");

            UI.Web.Models.ViewModelCustom.HUB2013AGrad model = new UI.Web.Models.ViewModelCustom.HUB2013AGrad();
            Model.Admin.StatusPoruka statusPoruka = new Model.Admin.StatusPoruka();
            statusPoruka.PorukaTekst = String.Empty;
            statusPoruka.StatusTekst = String.Empty;
            model.StatusPoruka = statusPoruka;
            model.PdfBroj = pdfBroj;
            model.PdfPage = pdfPage;
            model.Ukupno = ukupno;
            model.Barkod = true;
            model.Mjesec = Mjesec;
            model.Godina = Godina;
            model.PdfIme = pdfIme;
            model.Putanja = putanja;
            model.Top = 30000;
            model.Poruka = poruka;
            model.StatusPoruka = statusporuka;
            model.PokreniPonovi = pokreniPonovo;
            model.Ponovo = false;
            model.BrojUgovorMin = BrojUgovorMin;
            model.BrojUgovorMax = BrojUgovorMax;
            model.BezDatoteke = true;

            return View(model);

        }


        [MultipleButton(Name = "action", Argument = "HUBKreirajGrad")]
        public ActionResult HUBKreirajGrad(UI.Web.Models.ViewModelCustom.HUB2013AGrad model)
        {
            _serviceHUBNamjena2013A = new Service.Data.HUBNamjena2013A(korisnik_data);

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string Constring = korisnik_data.ConnStringNoMetadata;
            int barkod = 1;
            int pdfPage = 1;
            int ukupno = 1;
            int pdfBroj = 1;
            int vrsta = 1;
            int zadnji = 1;
            string pdfIme = "ReportHUB.pdf";
            StringBuilder sb = new StringBuilder();
            string path = String.Empty;
            string currentyear = DateTime.Now.Year.ToString();
            bool RasponBrojUgovor = false;

            var IDHUBNamjena2013A = _serviceHUBNamjena2013A.SelectResult(null).Select(c => new Repository.Data.Helper.CustomListItem { IDHUBNamjena2013A = c.IDHUBNamjena2013A, OznakaNaziv = c.Oznaka + " " + c.Naziv }).ToList();
            ViewBag.IDHUBNamjena2013A = new SelectList(IDHUBNamjena2013A.AsEnumerable(), "IDHUBNamjena2013A", "OznakaNaziv");

            var Printer = GetPrinters();
            ViewBag.Printer = new SelectList(Printer.AsEnumerable(), "Id", "PrinterNaziv");

            string putanja = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.Putanja);

            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Prazno;

            if (model.BezDatoteke == false)
            {
                // Spoji i procisti datoteke
                string allText = String.Empty;
                string DocZaImportSpoji = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
                string putanjaspajanje = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
                StringBuilder sbspajanje = new StringBuilder();
                System.IO.DirectoryInfo directoryspoji = new System.IO.DirectoryInfo(putanjaspajanje);
                Char[] ReplacementChars = new[] { (char)12, (char)12, (char)12, (char)12 };
                string priv = ((char)12).ToString();
                foreach (FileInfo doc in directoryspoji.GetFiles())
                {
                    if (doc.Name.Length != 0)
                    {
                        if (doc.Name != DocZaImportSpoji)
                        {

                            sbspajanje.Append(Regex.Replace(System.IO.File.ReadAllText(putanjaspajanje + "\\" + doc.Name).Replace(priv, ""), @"^\s+$[\r\n]*", "", RegexOptions.Multiline));
                        }
                    }

                }
                allText = sbspajanje.ToString().TrimEnd((char)10, (char)13);

                if (allText != String.Empty)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(putanjaspajanje + "\\" + DocZaImportSpoji, false))
                    {
                        file.WriteLine(allText);
                    }

                    FileInfo fi = new FileInfo(putanjaspajanje + "\\" + DocZaImportSpoji);
                    long velicinaDokumenta = fi.Length;
                    if (velicinaDokumenta < 3000)
                    {
                        RasponBrojUgovor = true;
                    }
                }

            }

            // Za raspon Ugovora bez datoteke
            else
            {
                if (model.BrojUgovorMin >= KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin && model.BrojUgovorMax != KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax)
                {
                    RasponBrojUgovor = true;
                }
            }


            //Import
            _serviceHUB2013AView = new Service.Data.View.HUB2013A(korisnik_data);
            string DocZaImport = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
            string putanjaImport = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
            string ime = putanjaImport + "\\" + DocZaImport;
            Repository.Data.Helper.HUB_IMPORT item = new Repository.Data.Helper.HUB_IMPORT();

            item.Godina = model.Godina;
            item.Mjesec = model.Mjesec;

            if (model.IDHUBNamjena2013A > 0)
                item.IDHUBNamjena2013A = model.IDHUBNamjena2013A;
            else
                item.IDHUBNamjena2013A = null;

            item.BrojUgovorMin = model.BrojUgovorMin;
            item.BrojUgovorMax = model.BrojUgovorMax;

            if (model.BezDatoteke == false)
            {
                item.Datoteka = ime;

            }
            else
            {
                item.Datoteka = null;
            }

            int storerez = _serviceHUB2013AView.HUB_IMPORT_Test(item);

            Model.Data.HUBImport import = HUBImport(model.Mjesec, model.Godina);

            if (import != null)
            {
                if ((import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false) || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true && model.Ponovo == true))
                {

                    if (!Directory.Exists(putanja))
                    {
                        Directory.CreateDirectory(putanja);
                    }

                    rep.Load(report_directorij + KeyWord.HUB.ReportName.HUB2013AGradRasponUgovor);

                    if (!String.IsNullOrEmpty(Constring))
                    {
                        rep.Dictionary.Databases.Clear();
                        rep.Dictionary.Databases.Add(new StiSqlDatabase(KeyWord.HUB.StiDataSource.Ds, Constring));
                    }


                    switch (model.Printer)
                    {
                        case 1:
                            {
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Platitelj) as StiText).Top = 9.3;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Primatelj) as StiText).Top = 36;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Hitno) as StiText).Top = 6.47;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.ValutaPlacanja) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.IznosCijelo) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.IznosDecimala) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljRacun) as StiText).Top = 26.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljModel) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljPozivNaBroj) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.SifraNamjena) as StiText).Top = 43.9;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.OpisPlacanje) as StiText).Top = 41;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonValuta) as StiText).Top = 6.76;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonIznos) as StiText).Top = 6.76;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonPlatitelja) as StiText).Top = 13.1;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonRacun) as StiText).Top = 26.9;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonModel) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonOpis) as StiText).Top = 42.3;
                            };
                            break;

                    }



                    if (model.Barkod == true)
                        barkod = 1;
                    else
                        barkod = 0;

                    if (model.Top != 0)
                    {
                        rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Top].ValueObject = model.Top;
                    }

                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Barkod].ValueObject = barkod;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Vrsta].ValueObject = vrsta;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Mjesec].ValueObject = model.Mjesec;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Godina].ValueObject = model.Godina;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMin].ValueObject = model.BrojUgovorMin;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMax].ValueObject = model.BrojUgovorMax;

                    rep.Compile();
                    rep.Render(true);

                    if (model.PdfPage != 0)
                        pdfPage = model.PdfPage;

                    ukupno = rep.RenderedPages.Count;
                    pdfBroj = ukupno / pdfPage;
                    zadnji = pdfBroj + 1;

                    int od = 1;
                    int privremena = pdfPage;
                    int dod = pdfPage;
                    int ostalostrana = ukupno - (pdfBroj * pdfPage);

                    string notification = String.Empty;

                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);
                    FileStream stream = null;

                    try
                    {
                        sb.Append("Kenerirano je " + zadnji.ToString() + " pdf dokumenata na lokaciji " + putanja + " .");
                        sb.Append(" <br/> ");

                        //var cTokenSource = new CancellationTokenSource();
                        var cToken = cTokenSource.Token;

                        try
                        {
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                stream = file.OpenWrite();
                                stream.Close();
                            }
                        }

                        catch (Exception ex)
                        {
                            cTokenSource.Cancel();
                            Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                            log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.DokumentZauzet, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                            Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                            poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.DokumentZauzet;
                            poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                            return View("Greska", poruka);

                        }


                        var task = Task.Factory.StartNew(() =>
                        {

                            foreach (FileInfo file in directory.GetFiles())
                            {
                                file.Delete();
                            }

                            if (RasponBrojUgovor == true && model.BrojUgovorMin >= KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin && model.BrojUgovorMax != KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax)
                            {
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + model.BrojUgovorMin.ToString() + "_" + model.BrojUgovorMax.ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPdfExportService service = new StiPdfExportService();
                                service.ExportPdf(rep, fs);
                                fs.Close();
                                fs.Dispose();
                                sb.Append(pdfIme);
                                sb.Append(" <br/> ");
                                notification = notification + " <br/> " + pdfIme;
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;

                            }

                            else
                            {

                                for (int i = 1; i <= pdfBroj; i++)
                                {

                                    pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + i + ".pdf";
                                    fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                    StiPagesRange pr = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                    StiPdfExportService service = new StiPdfExportService();
                                    service.ExportPdf(rep, fs, pr);
                                    fs.Close();
                                    fs.Dispose();
                                    sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                    sb.Append(" <br/> ");
                                    notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                    HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                                    od = dod + 1;
                                    dod = privremena * (i + 1);

                                }

                                dod = (pdfBroj * pdfPage) + ostalostrana;
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + (zadnji).ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPagesRange pro = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                StiPdfExportService serviceo = new StiPdfExportService();
                                serviceo.ExportPdf(rep, fs, pro);
                                fs.Close();
                                fs.Dispose();

                                sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                sb.Append(" <br/> ");

                                notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                            }


                            ViewData.ModelState.Clear();
                            model.Poruka = sb.ToString();
                            model.Ukupno = ukupno;

                            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Kraj + sb.ToString();

                            Model.Data.Item.HUBImportItem importitem = new Model.Data.Item.HUBImportItem();

                            importitem.ID_HUBImport = import.ID_HUBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.Godina = import.Godina;
                            importitem.Mjesec = import.Mjesec;
                            importitem.ImportStatus = import.ImportStatus;
                            importitem.RBImport = import.RBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.RBDokumentUpload = import.RBDokumentUpload;
                            importitem.Pdf = true;
                            importitem.RBPdf = import.RBPdf + 1;
                            importitem.ErrorNumber = import.ErrorNumber;
                            importitem.ErrorSeverity = import.ErrorSeverity;
                            importitem.ErrorState = import.ErrorState;
                            importitem.ErrorProcedure = import.ErrorProcedure;
                            importitem.ErrorLine = import.ErrorLine;
                            importitem.ErrorMessage = import.ErrorMessage;

                            Model.Data.HUBImport update = _serviceHUBImport.UpdateResult(importitem);


                        }, cToken);


                        model.Ukupno = ukupno;
                        model.Putanja = putanja;
                        model.Poruka = KeyWord.HUB.Notification.Priprema;
                        return View(model);

                    }

                    catch (System.Exception ex)
                    {
                        Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                        log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.Import, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                        Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                        poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.Import;
                        poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                        model.StatusPoruka = poruka;
                        return View("Greska", poruka);
                    }

                }


                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Poceo || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false))
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.ImportTraje;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                    model.StatusPoruka = poruka;
                    return View(model);
                }

                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true)
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.VecPostoji;
                    poruka.StatusTekst = poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View(model);
                }

                else
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.HUBGreska;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View(model);
                }
            }

            model.Ukupno = ukupno;
            model.Putanja = putanja;
            return View(model);

        }

        [MultipleButton(Name = "action", Argument = "HUBKreirajGradBezImport")]
        public ActionResult HUBKreirajGradBezImport(UI.Web.Models.ViewModelCustom.HUB2013AGrad model)
        {
            _serviceHUBNamjena2013A = new Service.Data.HUBNamjena2013A(korisnik_data);

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string Constring = korisnik_data.ConnStringNoMetadata;
            int barkod = 1;
            int pdfPage = 1;
            int ukupno = 1;
            int pdfBroj = 1;
            int vrsta = 1;
            int zadnji = 1;
            string pdfIme = "ReportHUB.pdf";
            StringBuilder sb = new StringBuilder();
            string path = String.Empty;
            string currentyear = DateTime.Now.Year.ToString();
            bool RasponBrojUgovor = false;

            var IDHUBNamjena2013A = _serviceHUBNamjena2013A.SelectResult(null).Select(c => new Repository.Data.Helper.CustomListItem { IDHUBNamjena2013A = c.IDHUBNamjena2013A, OznakaNaziv = c.Oznaka + " " + c.Naziv }).ToList();
            ViewBag.IDHUBNamjena2013A = new SelectList(IDHUBNamjena2013A.AsEnumerable(), "IDHUBNamjena2013A", "OznakaNaziv");

            var Printer = GetPrinters();
            ViewBag.Printer = new SelectList(Printer.AsEnumerable(), "Id", "PrinterNaziv");

            string putanja = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.Putanja);

            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Prazno;

            if (model.BezDatoteke == false)
            {
                // Spoji i procisti datoteke
                string allText = String.Empty;
                string DocZaImportSpoji = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
                string putanjaspajanje = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
                StringBuilder sbspajanje = new StringBuilder();
                System.IO.DirectoryInfo directoryspoji = new System.IO.DirectoryInfo(putanjaspajanje);
                Char[] ReplacementChars = new[] { (char)12, (char)12, (char)12, (char)12 };
                string priv = ((char)12).ToString();
                foreach (FileInfo doc in directoryspoji.GetFiles())
                {
                    if (doc.Name.Length != 0)
                    {
                        if (doc.Name != DocZaImportSpoji)
                        {

                            sbspajanje.Append(Regex.Replace(System.IO.File.ReadAllText(putanjaspajanje + "\\" + doc.Name).Replace(priv, ""), @"^\s+$[\r\n]*", "", RegexOptions.Multiline));
                        }
                    }

                }
                allText = sbspajanje.ToString().TrimEnd((char)10, (char)13);

                if (allText != String.Empty)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(putanjaspajanje + "\\" + DocZaImportSpoji, false))
                    {
                        file.WriteLine(allText);
                    }

                    FileInfo fi = new FileInfo(putanjaspajanje + "\\" + DocZaImportSpoji);
                    long velicinaDokumenta = fi.Length;
                    if (velicinaDokumenta < 3000)
                    {
                        RasponBrojUgovor = true;
                    }
                }

            }

            // Za raspon Ugovora bez datoteke
            else
            {
                if (model.BrojUgovorMin >= KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin && model.BrojUgovorMax != KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax)
                {
                    RasponBrojUgovor = true;
                }
            }


            //Import
            _serviceHUB2013AView = new Service.Data.View.HUB2013A(korisnik_data);
            string DocZaImport = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
            string putanjaImport = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
            string ime = putanjaImport + "\\" + DocZaImport;
            Repository.Data.Helper.HUB_IMPORT item = new Repository.Data.Helper.HUB_IMPORT();

            item.Godina = model.Godina;
            item.Mjesec = model.Mjesec;

            if (model.IDHUBNamjena2013A > 0)
                item.IDHUBNamjena2013A = model.IDHUBNamjena2013A;
            else
                item.IDHUBNamjena2013A = null;

            item.BrojUgovorMin = model.BrojUgovorMin;
            item.BrojUgovorMax = model.BrojUgovorMax;

            if (model.BezDatoteke == false)
            {
                item.Datoteka = ime;

            }
            else
            {
                item.Datoteka = null;
            }

            //int storerez = _serviceHUB2013AView.HUB_IMPORT_Test(item);

            Model.Data.HUBImport import = HUBImport(model.Mjesec, model.Godina);

            if (import != null)
            {
                if ((import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false) || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true && model.Ponovo == true))
                {

                    if (!Directory.Exists(putanja))
                    {
                        Directory.CreateDirectory(putanja);
                    }

                    rep.Load(report_directorij + KeyWord.HUB.ReportName.HUB2013AGradRasponUgovor);

                    if (!String.IsNullOrEmpty(Constring))
                    {
                        rep.Dictionary.Databases.Clear();
                        rep.Dictionary.Databases.Add(new StiSqlDatabase(KeyWord.HUB.StiDataSource.Ds, Constring));
                    }


                    switch (model.Printer)
                    {
                        case 1:
                            {
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Platitelj) as StiText).Top = 9.3;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Primatelj) as StiText).Top = 36;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.Hitno) as StiText).Top = 6.47;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.ValutaPlacanja) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.IznosCijelo) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.IznosDecimala) as StiText).Top = 6.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljRacun) as StiText).Top = 26.91;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljModel) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.PrimateljPozivNaBroj) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.SifraNamjena) as StiText).Top = 43.9;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.OpisPlacanje) as StiText).Top = 41;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonValuta) as StiText).Top = 6.76;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonIznos) as StiText).Top = 6.76;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonPlatitelja) as StiText).Top = 13.1;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonRacun) as StiText).Top = 26.9;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonModel) as StiText).Top = 35;
                                (rep.GetComponentByName(KeyWord.HUB.ReportHUB2013AGradFields.TalonOpis) as StiText).Top = 42.3;
                            };
                            break;

                    }



                    if (model.Barkod == true)
                        barkod = 1;
                    else
                        barkod = 0;

                    if (model.Top != 0)
                    {
                        rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Top].ValueObject = model.Top;
                    }

                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Barkod].ValueObject = barkod;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Vrsta].ValueObject = vrsta;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Mjesec].ValueObject = model.Mjesec;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Godina].ValueObject = model.Godina;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMin].ValueObject = model.BrojUgovorMin;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMax].ValueObject = model.BrojUgovorMax;

                    rep.Compile();
                    rep.Render(true);

                    if (model.PdfPage != 0)
                        pdfPage = model.PdfPage;

                    ukupno = rep.RenderedPages.Count;
                    pdfBroj = ukupno / pdfPage;
                    zadnji = pdfBroj + 1;

                    int od = 1;
                    int privremena = pdfPage;
                    int dod = pdfPage;
                    int ostalostrana = ukupno - (pdfBroj * pdfPage);

                    string notification = String.Empty;

                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);
                    FileStream stream = null;

                    try
                    {
                        sb.Append("Kenerirano je " + zadnji.ToString() + " pdf dokumenata na lokaciji " + putanja + " .");
                        sb.Append(" <br/> ");

                        //var cTokenSource = new CancellationTokenSource();
                        var cToken = cTokenSource.Token;

                        try
                        {
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                stream = file.OpenWrite();
                                stream.Close();
                            }
                        }

                        catch (Exception ex)
                        {
                            cTokenSource.Cancel();
                            Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                            log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.DokumentZauzet, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                            Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                            poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.DokumentZauzet;
                            poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                            return View("Greska", poruka);

                        }


                        var task = Task.Factory.StartNew(() =>
                        {

                            foreach (FileInfo file in directory.GetFiles())
                            {
                                file.Delete();
                            }

                            if (RasponBrojUgovor == true && model.BrojUgovorMin >= KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin && model.BrojUgovorMax != KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax)
                            {
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + model.BrojUgovorMin.ToString() + "_" + model.BrojUgovorMax.ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPdfExportService service = new StiPdfExportService();
                                service.ExportPdf(rep, fs);
                                fs.Close();
                                fs.Dispose();
                                sb.Append(pdfIme);
                                sb.Append(" <br/> ");
                                notification = notification + " <br/> " + pdfIme;
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;

                            }

                            else
                            {

                                for (int i = 1; i <= pdfBroj; i++)
                                {

                                    pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + i + ".pdf";
                                    fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                    StiPagesRange pr = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                    StiPdfExportService service = new StiPdfExportService();
                                    service.ExportPdf(rep, fs, pr);
                                    fs.Close();
                                    fs.Dispose();
                                    sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                    sb.Append(" <br/> ");
                                    notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                    HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                                    od = dod + 1;
                                    dod = privremena * (i + 1);

                                }

                                dod = (pdfBroj * pdfPage) + ostalostrana;
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + (zadnji).ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPagesRange pro = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                StiPdfExportService serviceo = new StiPdfExportService();
                                serviceo.ExportPdf(rep, fs, pro);
                                fs.Close();
                                fs.Dispose();

                                sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                sb.Append(" <br/> ");

                                notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                            }


                            ViewData.ModelState.Clear();
                            model.Poruka = sb.ToString();
                            model.Ukupno = ukupno;

                            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Kraj + sb.ToString();

                            Model.Data.Item.HUBImportItem importitem = new Model.Data.Item.HUBImportItem();

                            importitem.ID_HUBImport = import.ID_HUBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.Godina = import.Godina;
                            importitem.Mjesec = import.Mjesec;
                            importitem.ImportStatus = import.ImportStatus;
                            importitem.RBImport = import.RBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.RBDokumentUpload = import.RBDokumentUpload;
                            importitem.Pdf = true;
                            importitem.RBPdf = import.RBPdf + 1;
                            importitem.ErrorNumber = import.ErrorNumber;
                            importitem.ErrorSeverity = import.ErrorSeverity;
                            importitem.ErrorState = import.ErrorState;
                            importitem.ErrorProcedure = import.ErrorProcedure;
                            importitem.ErrorLine = import.ErrorLine;
                            importitem.ErrorMessage = import.ErrorMessage;

                            Model.Data.HUBImport update = _serviceHUBImport.UpdateResult(importitem);


                        }, cToken);


                        model.Ukupno = ukupno;
                        model.Putanja = putanja;
                        model.Poruka = KeyWord.HUB.Notification.Priprema;
                        return View("HUBKreirajGrad", model);

                    }

                    catch (System.Exception ex)
                    {
                        Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                        log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.Import, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                        Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                        poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.Import;
                        poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                        model.StatusPoruka = poruka;
                        return View("Greska", poruka);
                    }

                }


                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Poceo || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false))
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.ImportTraje;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                    model.StatusPoruka = poruka;
                    return View("HUBKreirajGrad", model);
                }

                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true)
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.VecPostoji;
                    poruka.StatusTekst = poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View("HUBKreirajGrad", model);
                }

                else
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.HUBGreska;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View("HUBKreirajGrad", model);
                }
            }

            model.Ukupno = ukupno;
            model.Putanja = putanja;
            return View("HUBKreirajGrad", model);

        }


        [HttpPost]
        public ActionResult UploadDokument(IEnumerable<HttpPostedFileBase> files)
        {
            try
            {

                bool izrada = DaLiIzradaUTijeku();

                if (izrada == true)
                {
                    return RedirectToAction("HUBKreirajGrad", new { poruka = KeyWord.HUB.ErrorMessages.UploadZabranjen });
                }

                string putanja = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);


                foreach (FileInfo doc in directory.GetFiles())
                {
                    doc.Delete();
                }

                foreach (HttpPostedFileBase file in files)
                {
                    if (file != null)
                    {

                        if (!Directory.Exists(putanja))
                        {
                            Directory.CreateDirectory(putanja);
                        }

                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(putanja, fileName);
                        file.SaveAs(path);
                    }
                }

                return RedirectToAction("HUBKreirajGrad", new { poruka = KeyWord.HUB.ErrorMessages.UploadUspio });
            }

            catch (Exception ex)
            {
                return RedirectToAction("HUBKreirajGrad", new { poruka = KeyWord.HUB.ErrorMessages.UploadGreska });
            }

        }

        public bool DaLiIzradaUTijeku()
        {
            bool rezultat = false;

            _serviceHUBImport = new Service.Data.HUBImport(korisnik_data);
            IEnumerable<Model.Data.HUBImport> import = _serviceHUBImport.SelectResult(null).Where(p => p.ImportStatus == KeyWord.HUB.ImportStatus.Poceo).ToList();

            if (import != null)
            {
                if (import.Count() != 0)
                {
                    rezultat = true;

                }

            }

            return rezultat;

        }

        public ActionResult Kraj(UI.Web.Models.ViewModelCustom.HUB2013AGrad model)
        {
            return View("HUBKreirajGrad", model);
        }

        public ActionResult Greska(Model.Admin.StatusPoruka poruka)
        {
            return View(poruka);
        }

        public Model.Data.HUBImport HUBImport(int mjesec, int godina)
        {
            List<InLine.Model.Data.Field.HUBImport> bf = new List<InLine.Model.Data.Field.HUBImport>();
            List<InLine.Model.Data.Filter.HUBImport> bff = new List<InLine.Model.Data.Filter.HUBImport>();
            bff.Add(new Model.Data.Filter.HUBImport { Field = Model.Data.Field.HUBImport.Mjesec, Value = mjesec });
            bff.Add(new Model.Data.Filter.HUBImport { Field = Model.Data.Field.HUBImport.Godina, Value = godina });
            List<InLine.Model.Data.Sort.HUBImport> bs = new List<InLine.Model.Data.Sort.HUBImport>();
            _serviceHUBImport = new Service.Data.HUBImport(korisnik_data);

            return _serviceHUBImport.GetData(bf, bff, bs).FirstOrDefault();
        }

        public string Provjera()
        {
            string notification = KeyWord.HUB.Messages.Molim;

            if (HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] != null)
            {
                if (HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB].ToString() == KeyWord.HUB.Messages.Zauzeto)
                {
                    notification = KeyWord.HUB.Messages.Zauzeto;
                }
                else if (HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB].ToString().Contains(KeyWord.HUB.Messages.Kraj))
                {
                    notification = HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB].ToString();
                }
                else
                {
                    notification = KeyWord.HUB.Messages.Molim + KeyWord.HUB.Messages.Popis;
                    notification = notification + HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB].ToString();
                }

            }

            return notification;

        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
        public class MultiButtonAttribute : ActionNameSelectorAttribute
        {
            public string MatchFormKey { get; set; }
            public string MatchFormValue { get; set; }

            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                return controllerContext.HttpContext.Request[MatchFormKey] != null &&
                    controllerContext.HttpContext.Request[MatchFormKey] == MatchFormValue;
            }
        }



        #region HUBOVI TEST KASNIJE ZA BRISANJE

        [HttpGet]
        public ActionResult HUBKreirajGradTEST(string poruka)
        {
            _serviceHUBNamjena2013A = new Service.Data.HUBNamjena2013A(korisnik_data);

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string Constring = korisnik_data.ConnStringNoMetadata;
            int Mjesec = DateTime.Now.Month;
            int Godina = DateTime.Now.Year;
            int pdfPage = KeyWord.HUB.BrojcaneVrijednosti.PdfPage;
            //int ukupno = 100;
            //int pdfBroj = (ukupno / pdfPage) + 1;
            string pdfIme = "ReportHUB.pdf";
            string putanja = Server.MapPath("~/HUB/HUBTest/");
            Model.Admin.StatusPoruka statusporuka = new Model.Admin.StatusPoruka();
            statusporuka.PorukaTekst = String.Empty;
            statusporuka.StatusTekst = String.Empty;
            int pokreniPonovo = 0;
            int ukupno = 0;
            int pdfBroj = 0;
            int BrojUgovorMin = KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin;
            int BrojUgovorMax = KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax;

            var IDHUBNamjena2013A = _serviceHUBNamjena2013A.SelectResult(null).Select(c => new Repository.Data.Helper.CustomListItem { IDHUBNamjena2013A = c.IDHUBNamjena2013A, OznakaNaziv = c.Oznaka + " " + c.Naziv }).ToList();
            ViewBag.IDHUBNamjena2013A = new SelectList(IDHUBNamjena2013A.AsEnumerable(), "IDHUBNamjena2013A", "OznakaNaziv");

            var Printer = GetPrinters();
            ViewBag.Printer = new SelectList(Printer.AsEnumerable(), "Id", "PrinterNaziv");

            UI.Web.Models.ViewModelCustom.HUB2013AGradTEST model = new UI.Web.Models.ViewModelCustom.HUB2013AGradTEST();
            Model.Admin.StatusPoruka statusPoruka = new Model.Admin.StatusPoruka();
            statusPoruka.PorukaTekst = String.Empty;
            statusPoruka.StatusTekst = String.Empty;
            model.StatusPoruka = statusPoruka;
            model.PdfBroj = pdfBroj;
            model.PdfPage = pdfPage;
            model.Ukupno = ukupno;
            model.Barkod = true;
            model.Mjesec = Mjesec;
            model.Godina = Godina;
            model.PdfIme = pdfIme;
            model.Putanja = putanja;
            model.Top = 30000;
            model.Poruka = poruka;
            model.StatusPoruka = statusporuka;
            model.PokreniPonovi = pokreniPonovo;
            model.Ponovo = false;
            model.BrojUgovorMin = BrojUgovorMin;
            model.BrojUgovorMax = BrojUgovorMax;
            model.Server = "SZGROS01\\STANOVI";
            model.Baza = "InLineDataTest";

            return View(model);

        }

        public ActionResult HUBKreirajGradTEST(UI.Web.Models.ViewModelCustom.HUB2013AGradTEST model)
        {
            korisnik_data.ServerName = model.Server;
            korisnik_data.DatabaseName = model.Baza;

            _serviceHUBNamjena2013A = new Service.Data.HUBNamjena2013A(korisnik_data);

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string Constring = korisnik_data.ConnStringNoMetadata;

            int len = Constring.Length;
            string NoviConstrinBazaServerZaReport = "Data Source=" + model.Server + ";Initial Catalog=" + model.Baza;

            int prvi = Constring.IndexOf(';');
            prvi = Constring.IndexOf(';', prvi + 1);

            string NoviConstrinZaReport = Constring.Substring(prvi, (Constring.Length - prvi));

            Constring = NoviConstrinBazaServerZaReport + NoviConstrinZaReport;


            int barkod = 1;
            int pdfPage = 1;
            int ukupno = 1;
            int pdfBroj = 1;
            int vrsta = 1;
            int zadnji = 1;
            string pdfIme = "ReportHUB.pdf";
            StringBuilder sb = new StringBuilder();
            string path = String.Empty;
            string currentyear = DateTime.Now.Year.ToString();
            bool RasponBrojUgovor = false;

            var IDHUBNamjena2013A = _serviceHUBNamjena2013A.SelectResult(null).Select(c => new Repository.Data.Helper.CustomListItem { IDHUBNamjena2013A = c.IDHUBNamjena2013A, OznakaNaziv = c.Oznaka + " " + c.Naziv }).ToList();
            ViewBag.IDHUBNamjena2013A = new SelectList(IDHUBNamjena2013A.AsEnumerable(), "IDHUBNamjena2013A", "OznakaNaziv");

            var Printer = GetPrinters();
            ViewBag.Printer = new SelectList(Printer.AsEnumerable(), "Id", "PrinterNaziv");

            string putanja = Server.MapPath("~/HUB/HUBTest/");

            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Prazno;


            // Spoji i procisti datoteke
            string allText = String.Empty;
            string DocZaImportSpoji = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
            string putanjaspajanje = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
            StringBuilder sbspajanje = new StringBuilder();
            System.IO.DirectoryInfo directoryspoji = new System.IO.DirectoryInfo(putanjaspajanje);
            Char[] ReplacementChars = new[] { (char)12, (char)12, (char)12, (char)12 };
            string priv = ((char)12).ToString();
            foreach (FileInfo doc in directoryspoji.GetFiles())
            {
                if (doc.Name.Length != 0)
                {
                    if (doc.Name != DocZaImportSpoji)
                    {

                        sbspajanje.Append(Regex.Replace(System.IO.File.ReadAllText(putanjaspajanje + "\\" + doc.Name).Replace(priv, ""), @"^\s+$[\r\n]*", "", RegexOptions.Multiline));
                    }
                }

            }
            allText = sbspajanje.ToString().TrimEnd((char)10, (char)13);

            if (allText != String.Empty)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(putanjaspajanje + "\\" + DocZaImportSpoji, false))
                {
                    file.WriteLine(allText);
                }

                FileInfo fi = new FileInfo(putanjaspajanje + "\\" + DocZaImportSpoji);
                long velicinaDokumenta = fi.Length;
                if (velicinaDokumenta < 3000)
                {
                    RasponBrojUgovor = true;
                }
            }

            //Import
            string test = korisnik_data.ConnString;
            korisnik_data.ConnString = "metadata=res://*/InLineData.csdl|res://*/InLineData.ssdl|res://*/InLineData.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=" + model.Server + ";Initial Catalog=" + model.Baza + ";User ID=" + korisnik_data.Korisnik + ";Password=" + korisnik_data.Password + ";MultipleActiveResultSets=True\"";
            string provjeriime = korisnik_data.ConnString;
            //korisnik_data.ConnString = "metadata=res://*/InLineData.csdl|res://*/InLineData.ssdl|res://*/InLineData.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=SZGROS01\\STANOVI;Initial Catalog=InLineDataTest;User ID=iva;Password=ivagoranovic;MultipleActiveResultSets=True\"";
            _serviceHUB2013AView = new Service.Data.View.HUB2013A(korisnik_data);
            string DocZaImport = model.Godina.ToString() + "_" + model.Mjesec.ToString() + ".txt";
            string putanjaImport = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
            string ime = putanjaImport + "\\" + DocZaImport;
            Repository.Data.Helper.HUB_IMPORT item = new Repository.Data.Helper.HUB_IMPORT();
            item.Datoteka = ime;

            item.Godina = model.Godina;
            item.Mjesec = model.Mjesec;

            if (model.IDHUBNamjena2013A > 0)
                item.IDHUBNamjena2013A = model.IDHUBNamjena2013A;
            else
                item.IDHUBNamjena2013A = null;

            item.BrojUgovorMin = model.BrojUgovorMin;
            item.BrojUgovorMax = model.BrojUgovorMax;



            int storerez = _serviceHUB2013AView.HUB_IMPORT_TestBrojUgovora(item);

            Model.Data.HUBImport import = HUBImport(model.Mjesec, model.Godina);

            if (import != null)
            {
                if ((import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false) || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true && model.Ponovo == true))
                {

                    if (!Directory.Exists(putanja))
                    {
                        Directory.CreateDirectory(putanja);
                    }

                    rep.Load(report_directorij + KeyWord.HUB.ReportName.HUB2013AGradRasponUgovor);

                    if (!String.IsNullOrEmpty(Constring))
                    {
                        rep.Dictionary.Databases.Clear();
                        rep.Dictionary.Databases.Add(new StiSqlDatabase(KeyWord.HUB.StiDataSource.Ds, Constring));
                    }


                    if (model.Barkod == true)
                        barkod = 1;
                    else
                        barkod = 0;

                    if (model.Top != 0)
                    {
                        rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Top].ValueObject = model.Top;
                    }

                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Barkod].ValueObject = barkod;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Vrsta].ValueObject = vrsta;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Mjesec].ValueObject = model.Mjesec;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Godina].ValueObject = model.Godina;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMin].ValueObject = model.BrojUgovorMin;
                    rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMax].ValueObject = model.BrojUgovorMax;

                    rep.Compile();
                    rep.Render(true);

                    if (model.PdfPage != 0)
                        pdfPage = model.PdfPage;

                    ukupno = rep.RenderedPages.Count;
                    pdfBroj = ukupno / pdfPage;
                    zadnji = pdfBroj + 1;

                    int od = 1;
                    int privremena = pdfPage;
                    int dod = pdfPage;
                    int ostalostrana = ukupno - (pdfBroj * pdfPage);

                    string notification = String.Empty;

                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);
                    FileStream stream = null;

                    try
                    {
                        sb.Append("Kenerirano je " + zadnji.ToString() + " pdf dokumenata na lokaciji " + putanja + " .");
                        sb.Append(" <br/> ");
                        var cToken = cTokenSource.Token;

                        try
                        {
                            foreach (FileInfo file in directory.GetFiles())
                            {
                                stream = file.OpenWrite();
                                stream.Close();
                            }
                        }

                        catch (Exception ex)
                        {
                            cTokenSource.Cancel();
                            Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                            log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.DokumentZauzet, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                            Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                            poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.DokumentZauzet;
                            poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                            return View("Greska", poruka);

                        }


                        var task = Task.Factory.StartNew(() =>
                        {

                            foreach (FileInfo file in directory.GetFiles())
                            {
                                file.Delete();
                            }

                            if (RasponBrojUgovor == true && model.BrojUgovorMin >= KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMin && model.BrojUgovorMax != KeyWord.HUB.BrojcaneVrijednosti.BrojUgovorMax)
                            {
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + model.BrojUgovorMin.ToString() + "_" + model.BrojUgovorMax.ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPdfExportService service = new StiPdfExportService();
                                service.ExportPdf(rep, fs);
                                fs.Close();
                                fs.Dispose();
                                sb.Append(pdfIme);
                                sb.Append(" <br/> ");
                                notification = notification + " <br/> " + pdfIme;
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;

                            }

                            else
                            {

                                for (int i = 1; i <= pdfBroj; i++)
                                {

                                    pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + i + ".pdf";
                                    fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                    StiPagesRange pr = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                    StiPdfExportService service = new StiPdfExportService();
                                    service.ExportPdf(rep, fs, pr);
                                    fs.Close();
                                    fs.Dispose();
                                    sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                    sb.Append(" <br/> ");
                                    notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                    HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                                    od = dod + 1;
                                    dod = privremena * (i + 1);

                                }

                                dod = (pdfBroj * pdfPage) + ostalostrana;
                                pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_" + (zadnji).ToString() + ".pdf";
                                fs = new FileStream(putanja + pdfIme, FileMode.Create);
                                StiPagesRange pro = new StiPagesRange(od.ToString() + "-" + dod.ToString());
                                StiPdfExportService serviceo = new StiPdfExportService();
                                serviceo.ExportPdf(rep, fs, pro);
                                fs.Close();
                                fs.Dispose();

                                sb.Append(pdfIme + " od " + od.ToString() + " do " + dod.ToString());
                                sb.Append(" <br/> ");

                                notification = notification + " <br/> " + pdfIme + " od " + od.ToString() + " do " + dod.ToString();
                                HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = notification;
                            }


                            ViewData.ModelState.Clear();
                            model.Poruka = sb.ToString();
                            model.Ukupno = ukupno;

                            HttpContext.Application[KeyWord.HUB.Notification.NotificationGradHUB] = KeyWord.HUB.Messages.Kraj + sb.ToString();

                            Model.Data.Item.HUBImportItem importitem = new Model.Data.Item.HUBImportItem();

                            importitem.ID_HUBImport = import.ID_HUBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.Godina = import.Godina;
                            importitem.Mjesec = import.Mjesec;
                            importitem.ImportStatus = import.ImportStatus;
                            importitem.RBImport = import.RBImport;
                            importitem.DokumentUpload = import.DokumentUpload;
                            importitem.RBDokumentUpload = import.RBDokumentUpload;
                            importitem.Pdf = true;
                            importitem.RBPdf = import.RBPdf + 1;
                            importitem.ErrorNumber = import.ErrorNumber;
                            importitem.ErrorSeverity = import.ErrorSeverity;
                            importitem.ErrorState = import.ErrorState;
                            importitem.ErrorProcedure = import.ErrorProcedure;
                            importitem.ErrorLine = import.ErrorLine;
                            importitem.ErrorMessage = import.ErrorMessage;

                            Model.Data.HUBImport update = _serviceHUBImport.UpdateResult(importitem);


                        }, cToken);


                        model.Ukupno = ukupno;
                        model.Putanja = putanja;
                        model.Poruka = KeyWord.HUB.Notification.Priprema;
                        return View(model);

                    }

                    catch (System.Exception ex)
                    {
                        Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                        log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.Import, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                        Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                        poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.Import;
                        poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                        model.StatusPoruka = poruka;
                        return View("Greska", poruka);
                    }

                }


                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Poceo || (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == false))
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.ImportTraje;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                    model.StatusPoruka = poruka;
                    return View(model);
                }

                else if (import.ImportStatus == KeyWord.HUB.ImportStatus.Zavrsio && import.Pdf == true)
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.VecPostoji;
                    poruka.StatusTekst = poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View(model);
                }

                else
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.HUBGreska;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Jedan;
                    model.StatusPoruka = poruka;
                    return View(model);
                }
            }

            model.Ukupno = ukupno;
            model.Putanja = putanja;
            return View(model);

        }

        [HttpPost]
        public ActionResult UploadDokumentTEST(IEnumerable<HttpPostedFileBase> files)
        {
            try
            {

                bool izrada = DaLiIzradaUTijeku();

                if (izrada == true)
                {
                    return RedirectToAction("HUBKreirajGrad", new { poruka = KeyWord.HUB.ErrorMessages.UploadZabranjen });
                }

                string putanja = Server.MapPath(KeyWord.HUB.DokumentInfo.Putanja);
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);


                foreach (FileInfo doc in directory.GetFiles())
                {
                    doc.Delete();
                }

                foreach (HttpPostedFileBase file in files)
                {
                    if (file != null)
                    {

                        if (!Directory.Exists(putanja))
                        {
                            Directory.CreateDirectory(putanja);
                        }

                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(putanja, fileName);
                        file.SaveAs(path);
                    }
                }

                return RedirectToAction("HUBKreirajGradTEST", new { poruka = KeyWord.HUB.ErrorMessages.UploadUspio });
            }

            catch (Exception ex)
            {
                return RedirectToAction("HUBKreirajGradTEST", new { poruka = KeyWord.HUB.ErrorMessages.UploadGreska });
            }

        }

        [HttpGet]
        public ActionResult Random()
        {
            HttpContext.Application.Remove(KeyWord.HUB.Notification.NotificationUzorak);
            Repository.Data.Helper.RANDOM_TEST model = new Repository.Data.Helper.RANDOM_TEST();
            model.Mjesec = DateTime.Now.Month;
            model.Godina = DateTime.Now.Year;
            model.Server = "SZGROS01\\STANOVI";
            model.Baza = "InLineDataTest";
            model.Take = 10;
            model.Stupaca = 10;

            return View(model);
        }

        [HttpPost]
        public ActionResult Random(Repository.Data.Helper.RANDOM_TEST model)
        {
            int barkod = 0;
            int Top = 100000;
            int ukupno = 1;
            int vrsta = 1;
            string pdfIme = "UzorakInLineData.pdf";
            StringBuilder sb = new StringBuilder();
            string path = String.Empty;
            string currentyear = DateTime.Now.Year.ToString();
            int BrojUgovorMin = 1;
            int BrojUgovorMax = 100000000;
            string Upit = String.Empty;
            StringBuilder sbUpit = new StringBuilder();
            int Take = 10;
            int Stupaca = 10;
            model.Poruka = "Priprema";
            model.Stupaca = model.Stupaca;

            if (model.Take != 0)
            {
                Take = model.Take;
            }

            if (model.Stupaca != 0)
            {
                model.Stupaca = model.Stupaca;
            }

            else
            {
                model.Stupaca =  Stupaca;
            }




            HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak] = String.Empty;

            _serviceHUB2013AView = new Service.Data.View.HUB2013A(korisnik_data);
            List<InLine.Model.Data.Field.View.HUB2013A> bf = new List<InLine.Model.Data.Field.View.HUB2013A>();
            List<InLine.Model.Data.Filter.View.HUB2013A> bff = new List<InLine.Model.Data.Filter.View.HUB2013A>();
            bff.Add(new InLine.Model.Data.Filter.View.HUB2013A { Field = Model.Data.Field.View.HUB2013A.Mjesec, Value = 10 });
            List<InLine.Model.Data.Sort.View.HUB2013A> bs = new List<InLine.Model.Data.Sort.View.HUB2013A>();
            List<int> KolekcijaBrojUgovor = _serviceHUB2013AView.GetData(bf, bff, bs).Select(p => p.BrojUgovor).OrderBy(x => Guid.NewGuid()).Take(Take).ToList();


            sbUpit.Append("hub.VIEW_HUB2013A.Mjesec = " + model.Mjesec + " AND hub.VIEW_HUB2013A.Godina = " + model.Godina + "  AND hub.VIEW_HUB2013A.BrojUgovor IN (");
            if (KolekcijaBrojUgovor.Count > 0)
            {
                foreach (int broj in KolekcijaBrojUgovor)
                {
                    sbUpit.Append(broj.ToString() + ", ");
                }
            }

            sbUpit.Remove(sbUpit.ToString().Length - 2, 2);
            sbUpit.Append(" )");
            Upit = sbUpit.ToString();

            //**************
            korisnik_data.ServerName = model.Server;
            korisnik_data.DatabaseName = model.Baza;

            string report_directorij = Server.MapPath(KeyWord.HUB.ServerAndDirectoryInfo.ReportDirectorij);
            StiReport rep = new StiReport();
            string ConstringInLineDataTest = korisnik_data.ConnStringNoMetadata;
            string Constring = korisnik_data.ConnStringNoMetadata;

            int len = ConstringInLineDataTest.Length;
            string NoviConstrinBazaServerZaReport = "Data Source=" + model.Server + ";Initial Catalog=" + model.Baza;
            int prvi = ConstringInLineDataTest.IndexOf(';');
            prvi = ConstringInLineDataTest.IndexOf(';', prvi + 1);
            string NoviConstrinZaReport = ConstringInLineDataTest.Substring(prvi, (ConstringInLineDataTest.Length - prvi));
            ConstringInLineDataTest = NoviConstrinBazaServerZaReport + NoviConstrinZaReport;

            string putanjaInLineData = Server.MapPath("~/HUB/HUBTest/UZORAKInLineData/");
            string putanjaInLineDataTest = Server.MapPath("~/HUB/HUBTest/UZORAKInLineDataTest/");

            if (!Directory.Exists(putanjaInLineData))
            {
                Directory.CreateDirectory(putanjaInLineData);
            }

            if (!Directory.Exists(putanjaInLineDataTest))
            {
                Directory.CreateDirectory(putanjaInLineDataTest);
            }

            rep.Load(report_directorij + KeyWord.HUB.ReportName.HUB2013AGradRasponUgovorUZORAK);




            // PDF za InLineData
            if (!String.IsNullOrEmpty(Constring))
            {
                rep.Dictionary.Databases.Clear();
                rep.Dictionary.Databases.Add(new StiSqlDatabase(KeyWord.HUB.StiDataSource.Ds, Constring));
            }

            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Top].ValueObject = Top;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Barkod].ValueObject = barkod;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Vrsta].ValueObject = vrsta;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Mjesec].ValueObject = model.Mjesec;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Godina].ValueObject = model.Godina;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMin].ValueObject = BrojUgovorMin;
            rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMax].ValueObject = BrojUgovorMax;
            rep.Compile();
            rep[KeyWord.HUB.StiReportVariable.Upit] = Upit;
            rep.Render(true);
            ukupno = rep.RenderedPages.Count;
            string notificationInLineData = String.Empty;
            System.IO.DirectoryInfo directoryInLineData = new System.IO.DirectoryInfo(putanjaInLineData);
            FileStream fsInLineData = null;
            FileStream fsInLineDataPDF = null;

                var cTokenInLineData = cTokenSource.Token;

                try
                {
                    foreach (FileInfo file in directoryInLineData.GetFiles())
                    {
                        fsInLineData = file.OpenWrite();
                        fsInLineData.Close();
                    }
                }

                catch (Exception ex)
                {
                    cTokenSource.Cancel();
                    Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                    log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.DokumentZauzet, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.DokumentZauzet;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                    return View("Greska", poruka);

                }

                var taskInLineData = Task.Factory.StartNew(() =>
                {

                    foreach (FileInfo file in directoryInLineData.GetFiles())
                    {
                        file.Delete();
                    }

                    pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_InLineDataUzorak" + ".pdf";
                    fsInLineDataPDF = new FileStream(putanjaInLineData + pdfIme, FileMode.Create);
                    StiPdfExportService service = new StiPdfExportService();
                    service.ExportPdf(rep, fsInLineDataPDF);
                    fsInLineDataPDF.Close();
                    fsInLineDataPDF.Dispose();
                    HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak] = "PDF ZA InLineData gotov";

                }, cTokenInLineData);



                // PDF za InLineDataTest
                if (!String.IsNullOrEmpty(ConstringInLineDataTest))
                {
                    rep.Dictionary.Databases.Clear();
                    rep.Dictionary.Databases.Add(new StiSqlDatabase(KeyWord.HUB.StiDataSource.Ds, ConstringInLineDataTest));
                }

                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Top].ValueObject = Top;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Barkod].ValueObject = barkod;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Vrsta].ValueObject = vrsta;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Mjesec].ValueObject = model.Mjesec;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.Godina].ValueObject = model.Godina;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMin].ValueObject = BrojUgovorMin;
                rep.Dictionary.Variables[KeyWord.HUB.StiReportVariable.BrojUgovorMax].ValueObject = BrojUgovorMax;
                rep.Compile();
                rep[KeyWord.HUB.StiReportVariable.Upit] = Upit;
                rep.Render(true);
                ukupno = rep.RenderedPages.Count;
                string notificationInLineDataTest = String.Empty;
                System.IO.DirectoryInfo directoryInLineDataTest = new System.IO.DirectoryInfo(putanjaInLineDataTest);
                FileStream fsInLineDataTest = null;
                FileStream fsInLineDataTestPDF = null;


                var cTokenInLineDataTest = cTokenSource.Token;

                try
                {
                    foreach (FileInfo file in directoryInLineDataTest.GetFiles())
                    {
                        fsInLineDataTest = file.OpenWrite();
                        fsInLineDataTest.Close();
                    }
                }

                catch (Exception ex)
                {
                    cTokenSource.Cancel();
                    Repository.Admin.IDozvoleZabranePoruke log = new Repository.Admin.DozvoleZabranePoruke();
                    log.AddExceptionInLog(KeyWord.HUB.ErrorMessages.DokumentZauzet, ex.GetBaseException().ToString(), ex.StackTrace.ToString(), korisnik_data);
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = KeyWord.HUB.ErrorMessages.DokumentZauzet;
                    poruka.StatusTekst = KeyWord.HUB.ErrorStatus.Dva;
                    return View("Greska", poruka);

                }

                var taskInLineDataTest = Task.Factory.StartNew(() =>
                {

                    foreach (FileInfo file in directoryInLineDataTest.GetFiles())
                    {
                        file.Delete();
                    }

                    pdfIme = model.Godina.ToString() + "_" + model.Mjesec.ToString() + "_InLineDataUzorakTest" + ".pdf";
                    fsInLineDataTestPDF = new FileStream(putanjaInLineDataTest + pdfIme, FileMode.Create);
                    StiPdfExportService service = new StiPdfExportService();
                    service.ExportPdf(rep, fsInLineDataTestPDF);
                    fsInLineDataTestPDF.Close();
                    fsInLineDataTestPDF.Dispose();
                    sb.Append(pdfIme);
                    sb.Append(" <br/> ");
                    HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak] = KeyWord.HUB.Messages.Kraj;

                }, cTokenInLineDataTest);

                model.KojiUgovori = KolekcijaBrojUgovor;
                model.KojiUgovori.Sort();

                return View(model);

          }

        public string ProvjeraTEST()
        {
            string notification = String.Empty;

            if (HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak] != null)
            {
               
                if(HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak].ToString().Contains(KeyWord.HUB.Messages.Kraj))
                {
                    notification = HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak].ToString();
                }
                else
                {
                    notification = notification + HttpContext.Application[KeyWord.HUB.Notification.NotificationUzorak].ToString();
                }

            }

            return notification;

        }


        # endregion
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class MultipleButtonAttribute : ActionNameSelectorAttribute
    {
        public string Name { get; set; }
        public string Argument { get; set; }

        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            var isValidName = false;
            var keyValue = string.Format("{0}:{1}", Name, Argument);
            var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

            if (value != null)
            {
                controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
                isValidName = true;
            }

            return isValidName;
        }
    }
}


