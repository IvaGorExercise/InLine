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
using InLine.UI.Web.T4.FormFormattedTemplate.View;

namespace InLine.UI.Web.Controllers
{
    public class ZapisSviController : InLine.UI.Web.Controllers.View.ZapisViewController
    {
        #region Konstruktor

        Service.Data.View.IZapis _serviceViewZapis;
        Service.Data.ZapisVr _serviceZapisVr;

        Service.Data.View.IKontniPlanAnalitikaZapisVr _serviceViewKontniPlanAnalitikaZapisVr;

        Service.Data.IRacunUlaz _serviceRacunUlaz;
        Service.Data.View.ZapisRacunUlaz _serviceViewZapisRacunUlaz;

        Service.Data.UgovorStanOtkupAneks _serviceUgovorStanOtkupAneks;
        Service.Data.View.ZapisUgovorStanOtkupAneks _serviceViewZapisUgovorStanOtkupAneks;

        Service.Data.View.ZapisUgovorStanOtkup _serviceViewZapisUgovorStanOtkup;


        public ZapisSviController()
        {
        
        }


        public ZapisSviController(Model.Admin.KorisnikData korisnik_data)   
        {
            this.korisnik_data = korisnik_data;
    	}


  
        # endregion




        #region Zapis

        public PartialViewResult Dokument(long ID_KontniPlan)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<SelectListItem> rezult = new List<SelectListItem>();

            try
            {
                _serviceViewKontniPlanAnalitikaZapisVr = new Service.Data.View.KontniPlanAnalitikaZapisVr (korisnik_data);
                List<InLine.Model.Data.Field.View.KontniPlanAnalitikaZapisVr> field = new List<InLine.Model.Data.Field.View.KontniPlanAnalitikaZapisVr>();
                List<InLine.Model.Data.Filter.View.KontniPlanAnalitikaZapisVr> filter = new List<InLine.Model.Data.Filter.View.KontniPlanAnalitikaZapisVr>();
                List<InLine.Model.Data.Sort.View.KontniPlanAnalitikaZapisVr> sort = new List<InLine.Model.Data.Sort.View.KontniPlanAnalitikaZapisVr>();
                filter.Add(new InLine.Model.Data.Filter.View.KontniPlanAnalitikaZapisVr { Field = InLine.Model.Data.Field.View.KontniPlanAnalitikaZapisVr.ID_KontniPlan, Value = ID_KontniPlan });
                sort.Add(new InLine.Model.Data.Sort.View.KontniPlanAnalitikaZapisVr { Field = InLine.Model.Data.Field.View.KontniPlanAnalitikaZapisVr.Naziv });
                rezult = _serviceViewKontniPlanAnalitikaZapisVr.GetData(field, filter, sort).Select(c => new SelectListItem() { Value = c.ID_KontniPlanAnalitika + ":" + c.IDZapisVr.ToString(), Text =  c.NazivKontniPlanAnalitika + " - " + c.NazivKr + " " + c.OznakaKontniPlanAnalitika }).ToList();
                rezult.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
                ViewBag.ZapisVr = new SelectList(rezult.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return PartialView();
        }

        //public ActionResult GetDokument(string query, int vrsta)
        //{
        //    List<Model.Admin.StatusPoruka> poruke = null;
        //    List<InLine.Model.Data.View.Zapis> rezult = new List<InLine.Model.Data.View.Zapis>();

        //    query = query.Replace(" ", "");

        //    if (query.Length > 1)
        //    {
        //        int op = query.LastIndexOf(",");
        //        query = query.Substring(op + 1);
        //    }

        //    try
        //    {

        //        _serviceViewZapis = new Service.Data.View.Zapis(korisnik_data);
        //        List<InLine.Model.Data.Field.View.Zapis> field = new List<InLine.Model.Data.Field.View.Zapis>();
        //        List<InLine.Model.Data.Filter.View.Zapis> filter = new List<InLine.Model.Data.Filter.View.Zapis>();
        //        List<InLine.Model.Data.Sort.View.Zapis> sort = new List<InLine.Model.Data.Sort.View.Zapis>();
        //        filter.Add(new InLine.Model.Data.Filter.View.Zapis { Field = InLine.Model.Data.Field.View.Zapis.IDZapisVr, Value = vrsta });
        //        //rezult = _serviceViewZapis.GetData(field, filter, sort).Where(p => p.DatumGodina.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Predmet.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Broj.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
        //        //rezult = _serviceViewZapis.GetData(field, filter, sort).Take(10).ToList();
        //        //var x = rezult.Where(p => p.Broj.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
        //        //rezult = _serviceViewZapis.GetData(field, filter, sort).Where(p => p.DatumGodina.StartsWith(query.ToUpper()) || p.Predmet.StartsWith(query.ToUpper()) || p.Broj.StartsWith(query.ToUpper())).Take(5).ToList();
        //        rezult = _serviceViewZapis.GetData(field, filter, sort).Where(p => p.DatumGodina == query.ToUpper().Trim() || p.Broj.StartsWith(query.ToUpper())).Take(20).ToList();


        //    }

        //    catch (Exception ex)
        //    {
        //        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        //        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        //        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

        //    }

        //   // return Json(rezult, JsonRequestBehavior.AllowGet);

        //    var jsonResult = Json(rezult, JsonRequestBehavior.AllowGet);
        //    jsonResult.MaxJsonLength = int.MaxValue;
        //    return jsonResult;

        //}

        public InLine.Model.Data.View.Zapis GetZapis(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.Zapis rezult = new InLine.Model.Data.View.Zapis();


            try
            {
                _serviceViewZapis = new Service.Data.View.Zapis(korisnik_data);
                List<InLine.Model.Data.Field.View.Zapis> field = new List<InLine.Model.Data.Field.View.Zapis>();
                List<InLine.Model.Data.Filter.View.Zapis> filter = new List<InLine.Model.Data.Filter.View.Zapis>();
                List<InLine.Model.Data.Sort.View.Zapis> sort = new List<InLine.Model.Data.Sort.View.Zapis>();
                filter.Add(new InLine.Model.Data.Filter.View.Zapis { Field = InLine.Model.Data.Field.View.Zapis.ID_Zapis, Value = id });
                rezult = _serviceViewZapis.GetData(field, filter, sort).SingleOrDefault();


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

        #endregion



        #region Dokument Vrsta Analitika Za Temeljnica St 


        public ActionResult GetUlazniRacun(string query, long? kriterij, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.ZapisRacunUlaz> rezult = new List<InLine.Model.Data.View.ZapisRacunUlaz>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceViewZapisRacunUlaz = new Service.Data.View.ZapisRacunUlaz(korisnik_data);
                List<InLine.Model.Data.Field.View.ZapisRacunUlaz> field = new List<InLine.Model.Data.Field.View.ZapisRacunUlaz>();
                List<InLine.Model.Data.Filter.View.ZapisRacunUlaz> filter = new List<InLine.Model.Data.Filter.View.ZapisRacunUlaz>();
                List<InLine.Model.Data.Sort.View.ZapisRacunUlaz> sort = new List<InLine.Model.Data.Sort.View.ZapisRacunUlaz>();

       
                if (kriterij != null)
                {
                    rezult = _serviceViewZapisRacunUlaz.GetData(field, filter, sort).Where(p => p.ID_SubjektRacunUlaz == Convert.ToInt64(kriterij)).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
                }

                else
                {
                    rezult = _serviceViewZapisRacunUlaz.GetData(field, filter, sort).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
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

        public InLine.Model.Data.View.ZapisRacunUlaz GetZapisUlazniRacun(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.ZapisRacunUlaz rezult = new InLine.Model.Data.View.ZapisRacunUlaz();


            try
            {
                _serviceViewZapisRacunUlaz = new Service.Data.View.ZapisRacunUlaz(korisnik_data);
                List<InLine.Model.Data.Field.View.ZapisRacunUlaz> field = new List<InLine.Model.Data.Field.View.ZapisRacunUlaz>();
                List<InLine.Model.Data.Filter.View.ZapisRacunUlaz> filter = new List<InLine.Model.Data.Filter.View.ZapisRacunUlaz>();
                List<InLine.Model.Data.Sort.View.ZapisRacunUlaz> sort = new List<InLine.Model.Data.Sort.View.ZapisRacunUlaz>();
                filter.Add(new InLine.Model.Data.Filter.View.ZapisRacunUlaz { Field = InLine.Model.Data.Field.View.ZapisRacunUlaz.ID_Zapis, Value = id });
                rezult = _serviceViewZapisRacunUlaz.GetData(field, filter, sort).SingleOrDefault();


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

        public ActionResult GetUgovorStanOtkupAneks(string query, int kriterij, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.UgovorStanOtkupAneks> rezult = new List<InLine.Model.Data.UgovorStanOtkupAneks>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceUgovorStanOtkupAneks = new Service.Data.UgovorStanOtkupAneks(korisnik_data);
                List<InLine.Model.Data.Field.UgovorStanOtkupAneks> field = new List<InLine.Model.Data.Field.UgovorStanOtkupAneks>();
                List<InLine.Model.Data.Filter.UgovorStanOtkupAneks> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupAneks>();
                List<InLine.Model.Data.Sort.UgovorStanOtkupAneks> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupAneks>();
                rezult = _serviceUgovorStanOtkupAneks.GetData(field, filter, sort).Where(p => p.BrojUgovor.ToString().ToUpper().Trim().StartsWith(query.ToUpper()) || p.BrojStorno.ToString().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();

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

        public InLine.Model.Data.View.ZapisUgovorStanOtkupAneks GetZapisUgovorStanOtkupAneks(long id, long? idSubjekt)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.ZapisUgovorStanOtkupAneks rezult = new InLine.Model.Data.View.ZapisUgovorStanOtkupAneks();


            try
            {
                _serviceViewZapisUgovorStanOtkupAneks = new Service.Data.View.ZapisUgovorStanOtkupAneks(korisnik_data);
                List<InLine.Model.Data.Field.View.ZapisUgovorStanOtkupAneks> field = new List<InLine.Model.Data.Field.View.ZapisUgovorStanOtkupAneks>();
                List<InLine.Model.Data.Filter.View.ZapisUgovorStanOtkupAneks> filter = new List<InLine.Model.Data.Filter.View.ZapisUgovorStanOtkupAneks>();
                List<InLine.Model.Data.Sort.View.ZapisUgovorStanOtkupAneks> sort = new List<InLine.Model.Data.Sort.View.ZapisUgovorStanOtkupAneks>();
                filter.Add(new InLine.Model.Data.Filter.View.ZapisUgovorStanOtkupAneks { Field = InLine.Model.Data.Field.View.ZapisUgovorStanOtkupAneks.ID_ZapisUgovorStanOtkupAneks, Value = id });

                if (idSubjekt != null)
                {
                    filter.Add(new InLine.Model.Data.Filter.View.ZapisUgovorStanOtkupAneks { Field = InLine.Model.Data.Field.View.ZapisUgovorStanOtkupAneks.KupacID_Subjekt, Value = Convert.ToInt64(idSubjekt) });
                }

                rezult = _serviceViewZapisUgovorStanOtkupAneks.GetData(field, filter, sort).SingleOrDefault();


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

        public InLine.Model.Data.View.ZapisUgovorStanOtkup GetZapisUgovorStanOtkup(long id, long? idSubjekt)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.ZapisUgovorStanOtkup rezult = new InLine.Model.Data.View.ZapisUgovorStanOtkup();


            try
            {
                _serviceViewZapisUgovorStanOtkup = new Service.Data.View.ZapisUgovorStanOtkup(korisnik_data);
                List<InLine.Model.Data.Field.View.ZapisUgovorStanOtkup> field = new List<InLine.Model.Data.Field.View.ZapisUgovorStanOtkup>();
                List<InLine.Model.Data.Filter.View.ZapisUgovorStanOtkup> filter = new List<InLine.Model.Data.Filter.View.ZapisUgovorStanOtkup>();
                List<InLine.Model.Data.Sort.View.ZapisUgovorStanOtkup> sort = new List<InLine.Model.Data.Sort.View.ZapisUgovorStanOtkup>();
                filter.Add(new InLine.Model.Data.Filter.View.ZapisUgovorStanOtkup { Field = InLine.Model.Data.Field.View.ZapisUgovorStanOtkup.ID_ZapisUgovorStanOtkup, Value = id });

                if (idSubjekt != null)
                {
                    filter.Add(new InLine.Model.Data.Filter.View.ZapisUgovorStanOtkup { Field = InLine.Model.Data.Field.View.ZapisUgovorStanOtkup.KupacID_Subjekt, Value = Convert.ToInt64(idSubjekt) });
                }

                rezult = _serviceViewZapisUgovorStanOtkup.GetData(field, filter, sort).SingleOrDefault();


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

        public ActionResult ZapisUgovorStanOtkup(long? id)
        {
            if (id != null)
            {
                ViewBag.ID = id;
            }

            else
            {
                ViewBag.ID = -1;
            }

            return PartialView();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ZapisUgovorStanOtkupGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewZapisUgovorStanOtkup = new Service.Data.View.ZapisUgovorStanOtkup(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.ZapisUgovorStanOtkupViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.ZapisUgovorStanOtkupViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewZapisUgovorStanOtkup.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewZapisUgovorStanOtkup.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<ZapisUgovorStanOtkupGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupKupac), new ZapisUgovorStanOtkupGridFormatted(item)));



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

        public ActionResult ZapisUgovorStanOtkupAneks(long? id)
        {
            if (id != null)
            {
                ViewBag.ID = id;
            }

            else
            {
                ViewBag.ID = -1;
            }

            return PartialView();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ZapisUgovorStanOtkupAneksGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewZapisUgovorStanOtkupAneks = new Service.Data.View.ZapisUgovorStanOtkupAneks(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.ZapisUgovorStanOtkupAneksViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.ZapisUgovorStanOtkupAneksViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewZapisUgovorStanOtkupAneks.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewZapisUgovorStanOtkupAneks.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<ZapisUgovorStanOtkupAneksGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupKupac), new ZapisUgovorStanOtkupAneksGridFormatted(item)));



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

    }
}
