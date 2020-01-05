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

namespace InLine.UI.Web.Controllers
{
    public partial class PregledUgovoraController : InLine.UI.Web.Controllers.View.UgovorStanOtkupKupacNositeljViewController
    {
        Service.Data.View.IUgovorStanOtkupObrok _serviceViweUgovorStanOtkupObrok;
        Service.Data.View.IUgovorStanOtkupObrokDetalj _serviceViweUgovorStanOtkupObrokDetalj;
        Service.Data.View.IUgovorStanOtkupObrokUplata _serviceViewUgovorStanOtkupObrokUplata;
        Service.Data.View.IUgovorStanOtkupObrokPreplata _serviceViewUgovorStanOtkupObrokPreplata;
        Service.Data.View.IUgovorStanOtkupNalog _serviceViewUgovorStanOtkupNalog;
        Service.Data.View.IUgovorStanOtkupObrokUplataDetalj _serviceViewUgovorStanOtkupObrokUplataDetalj;
        Service.Data.View.IUgovorStanOtkupKupacNositelj _serviceViewUgovorStanOtkupKupacNositelj;
        Service.Data.View.IUgovorStanOtkupKupac _serviceViewUgovorStanOtkupKupac;
        Service.Data.View.IUgovorStanOtkupDetalj _serviceViewUgovorStanOtkupDetalj;
        Service.Data.View.IUgovorStanOtkupOpomena _serviceViewUgovorStanOtkupOpomena;
        Service.Data.View.IUgovorStanOtkupTrosak _serviceViewUgovorStanOtkupTrosak;
        Service.Data.View.IUgovorStanOtkupAneks _serviceViewUgovorStanOtkupAneks;
        Service.Data.View.IUgovorStanOtkupNalogDetalj _serviceViewUgovorStanOtkupNalogDetalj;
        Service.Data.View.IUgovorStanOtkupObrokPreplataDetalj _serviceViewUgovorStanOtkupObrokPreplataDetalj;
        Service.Data.View.IUgovorStanOtkupOpomenaDetalj _serviceViewUgovorStanOtkupOpomenaDetalj;
        Service.Data.View.IUgovorStanOtkupTrosakDetalj _serviceViewUgovorStanOtkupTrosakDetalj;
        Service.Data.View.IUgovorStanOtkupMoratorij _serviceViewUgovorStanOtkupMoratorij;
        Service.Data.View.IUgovorStanOtkupMoratorijMjesec _serviceViewUgovorStanOtkupMoratorijMjesec;
        Service.Data.View.IUgovorStanOtkupMoratorijMjesecDetalj _serviceViewUgovorStanOtkupMoratorijMjesecDetalj;
        Service.Data.View.KupacDetalj _serviceViewKupacDetalj;
        Service.Data.IKupac _serviceKupac;
        Service.Data.UgovorStanOtkup _serviceUgovorStanOtkup;
        Service.Data.UgovorStanOtkupOpomena _serviceUgovorStanOtkupOpomena;
        Service.Data.UgovorStanOtkupMoratorij _serviceUgovorStanOtkupMoratorij;
        Service.Data.IUgovorStanOtkupKupac _serviceUgovorStanOtkupKupac;
        Service.Data.IPosta _servicePosta;


        public ActionResult PregledUgovoraModul()
        {
            return View();
        }

        public ActionResult PregledUgovora()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KupacUgovorGrid(JqGridRequest request, KupacUgovorCustomSearch viewModel, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewUgovorStanOtkupKupacNositelj = new Service.Data.View.UgovorStanOtkupKupacNositelj(korisnik_data);
                //_serviceViweUgovorStanOtkupObrok = new Service.Data.View.UgovorStanOtkupObrok(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }
                    else if (viewModel != null)
                    {
                        filterExpression = viewModel.GetFilterExpression();
                        customsearch = true;
                    }
                }


                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewUgovorStanOtkupKupacNositelj.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewUgovorStanOtkupKupacNositelj.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<UgovorStanOtkupKupacNositeljGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupKupac), new UgovorStanOtkupKupacNositeljGridFormatted(item)));


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


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorKupci(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupKupac = new Service.Data.View.UgovorStanOtkupKupac(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupKupac.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupKupac.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupKupacGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupKupac), new UgovorStanOtkupKupacGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UgovorKupci3(int id)
        {
            _serviceViewUgovorStanOtkupKupac = new Service.Data.View.UgovorStanOtkupKupac(korisnik_data);
            string filterExpression = String.Empty;

            string key = "ID_UgovorStanOtkup";
            string value = id.ToString();

            bool customsearch = false;


            long totalRecordsCount = _serviceViewUgovorStanOtkupKupac.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse(true);
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupKupac.GetGridData(filterExpression, key, value, "Naziv", 0, 100, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupKupacGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupKupac), new UgovorStanOtkupKupacGridFormatted(item)));

            return new JqGridJsonResult() { Data = response };
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ObrokGrid(JqGridRequest request, string filter, string key, string value)
        {
            _serviceViweUgovorStanOtkupObrok = new Service.Data.View.UgovorStanOtkupObrok(korisnik_data);
            string filterExpression = String.Empty;

            bool customsearch = false;


            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetObrokFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetObrokFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

                if (filterExpression.Contains("3"))
                {

                    filterExpression = String.Empty;
                }

            }

            else
            {
                filterExpression = filter;
            }


            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViweUgovorStanOtkupObrok.GetCount(filterExpression, key, value, customsearch);

            var SumaObrok = _serviceViweUgovorStanOtkupObrok.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.SumaObrok);
            var IznosZateznaKamata = _serviceViweUgovorStanOtkupObrok.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosZateznaKamata);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,

                UserData = new
                {

                    BrojObrok = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaObrok + IznosZateznaKamata),
                    SumaObrok = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaObrok),
                    IznosZateznaKamata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosZateznaKamata)
                }

            };
            response.Records.AddRange(from item in _serviceViweUgovorStanOtkupObrok.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupObrokGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupObrok), new UgovorStanOtkupObrokGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UplataGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupObrokUplata = new Service.Data.View.UgovorStanOtkupObrokUplata(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupObrokUplata.GetCount(filterExpression, key, value, customsearch);

            var SumaUplata = _serviceViewUgovorStanOtkupObrokUplata.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.SumaUplata);
            var SumaZateznaKamata = _serviceViewUgovorStanOtkupObrokUplata.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.SumaZateznaKamata);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,

                UserData = new
                {

                    Datum = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaUplata + SumaZateznaKamata),
                    SumaUplata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaUplata),
                    SumaZateznaKamata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, SumaZateznaKamata)
                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupObrokUplata.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupObrokUplataGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupObrokUplata), new UgovorStanOtkupObrokUplataGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PreplataGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupObrokPreplata = new Service.Data.View.UgovorStanOtkupObrokPreplata(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupObrokPreplata.GetCount(filterExpression, key, value, customsearch);

            var IznosPreplata = _serviceViewUgovorStanOtkupObrokPreplata.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosPreplata);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,
                UserData = new
                {
                    IznosPreplata = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosPreplata),

                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupObrokPreplata.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupObrokPreplataGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupObrokPreplata), new UgovorStanOtkupObrokPreplataGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AneksGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupAneks = new Service.Data.View.UgovorStanOtkupAneks(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupAneks.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupAneks.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupAneksGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupAneks), new UgovorStanOtkupAneksGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OpomenaGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupOpomena = new Service.Data.View.UgovorStanOtkupOpomena(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
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


            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,

                UserData = new
                {

                    Datum = KeyWord.FormaterRazno.GridFooterMessage.Suma +  String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDug + IznosZateznaKamata),
                    IznosDug = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDug),
                    IznosZateznaKamata = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosZateznaKamata)
                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupOpomena.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupOpomenaGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupOpomena), new UgovorStanOtkupOpomenaGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TrosakGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupTrosak = new Service.Data.View.UgovorStanOtkupTrosak(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupTrosak.GetCount(filterExpression, key, value, customsearch);

            var Iznos = _serviceViewUgovorStanOtkupTrosak.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.Iznos);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,
                UserData = new
                {
                    Iznos = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, Iznos),

                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupTrosak.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupTrosakGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupTrosak), new UgovorStanOtkupTrosakGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        public ActionResult NalogGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupNalog = new Service.Data.View.UgovorStanOtkupNalog(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupNalog.GetCount(filterExpression, key, value, customsearch);


            var Iznos = _serviceViewUgovorStanOtkupNalog.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.Iznos);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,
                UserData = new
                {
                    Iznos = KeyWord.FormaterRazno.GridFooterMessage.Suma + String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, Iznos),

                }

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupNalog.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupNalogGridFormatted>(Convert.ToString(item.ID_Nalog), new UgovorStanOtkupNalogGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MoratorijGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupMoratorij = new Service.Data.View.UgovorStanOtkupMoratorij(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupMoratorij.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupMoratorij.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupMoratorijGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupMoratorij), new UgovorStanOtkupMoratorijGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MoratorijMjesecSubGrid(int id)
        {
            _serviceViewUgovorStanOtkupMoratorijMjesec = new Service.Data.View.UgovorStanOtkupMoratorijMjesec(korisnik_data);
            string filterExpression = String.Empty;

            string key = "ID_UgovorStanOtkupMoratorij";
            string value = id.ToString();

            bool customsearch = false;


            long totalRecordsCount = _serviceViewUgovorStanOtkupMoratorijMjesec.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse(true);
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupMoratorijMjesec.GetGridData(filterExpression, key, value, "Godina", 0, 100, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupMoratorijMjesecGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupMoratorijMjesec), new UgovorStanOtkupMoratorijMjesecGridFormatted(item)));

            return new JqGridJsonResult() { Data = response };
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MoratorijMjesecGrid(JqGridRequest request, string key, string value)
        {
            _serviceViewUgovorStanOtkupMoratorijMjesec = new Service.Data.View.UgovorStanOtkupMoratorijMjesec(korisnik_data);
            string filterExpression = String.Empty;


            bool customsearch = false;

            if (request.Searching)
            {
                if (request.SearchingFilter != null)
                    filterExpression = GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                else if (request.SearchingFilters != null)
                {
                    StringBuilder filterExpressionBuilder = new StringBuilder();
                    string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                    foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                    {
                        filterExpressionBuilder.Append(GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                        filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                    }
                    if (filterExpressionBuilder.Length > 0)
                        filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                    filterExpression = filterExpressionBuilder.ToString();
                }

            }

            string sortingName = request.SortingName;

            long totalRecordsCount = _serviceViewUgovorStanOtkupMoratorijMjesec.GetCount(filterExpression, key, value, customsearch);

            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount

            };
            response.Records.AddRange(from item in _serviceViewUgovorStanOtkupMoratorijMjesec.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                      select new JqGridRecord<UgovorStanOtkupMoratorijMjesecGridFormatted>(Convert.ToString(item.ID_UgovorStanOtkupMoratorijMjesec), new UgovorStanOtkupMoratorijMjesecGridFormatted(item)));



            return new JqGridJsonResult() { Data = response };
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult OrderDetailsSubgridAsGrid(int id, JqGridRequest request)
        //{
        //    IEnumerable<OrderDetail> details = _ordersRepository.FindDetails(id);
        //    int totalRecords = details.Count();

        //    JqGridResponse response = new JqGridResponse()
        //    {
        //        TotalPagesCount = (int)Math.Ceiling((float)totalRecords / (float)request.RecordsCount),
        //        PageIndex = request.PageIndex,
        //        TotalRecordsCount = totalRecords
        //    };

        //    response.Records.AddRange(from OrderDetail orderDetails in details.Skip(request.PageIndex * request.RecordsCount).Take(request.RecordsCount)
        //                              select new JqGridRecord<OrderDetailViewModel>(orderDetails.ProductId.ToString(), new OrderDetailViewModel(orderDetails)));

        //    return new JqGridJsonResult() { Data = response };
        //}


        public ActionResult ObrokDetail(long id)
        {
            _serviceViweUgovorStanOtkupObrokDetalj = new Service.Data.View.UgovorStanOtkupObrokDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupObrokDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupObrokDetalj.ID_UgovorStanOtkupObrok, Value = id });
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokDetalj>();
            var item = _serviceViweUgovorStanOtkupObrokDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokDetaljFormFormatted(item);

            _serviceUgovorStanOtkupMoratorij = new Service.Data.UgovorStanOtkupMoratorij(korisnik_data);

            if (item.ID_UgovorStanOtkupMoratorij != null)
            {
                var moratorij = _serviceUgovorStanOtkupMoratorij.FindID(Convert.ToInt64(item.ID_UgovorStanOtkupMoratorij));
                if (moratorij != null)
                    ViewBag.BrojMoratorij = moratorij.BrojMoratorij;
            }
  

            return PartialView(rezult);
        }

        public ActionResult ObrokUplataDetail(long id)
        {
            _serviceViewUgovorStanOtkupObrokUplataDetalj = new Service.Data.View.UgovorStanOtkupObrokUplataDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokUplataDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokUplataDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokUplataDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokUplataDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupObrokUplataDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupObrokUplataDetalj.ID_UgovorStanOtkupObrokUplata, Value = id });
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokUplataDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokUplataDetalj>();
            var item = _serviceViewUgovorStanOtkupObrokUplataDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokUplataDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokUplataDetaljFormFormatted(item);
            return PartialView(rezult);

        }

        public ActionResult UgovorDetail(long id)
        {
            _serviceViewUgovorStanOtkupDetalj = new Service.Data.View.UgovorStanOtkupDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupDetalj.ID_UgovorStanOtkup, Value = id });
            var item = _serviceViewUgovorStanOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult UgovorDetailKratki(long id)
        {
            _serviceViewUgovorStanOtkupDetalj = new Service.Data.View.UgovorStanOtkupDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupDetalj.ID_UgovorStanOtkup, Value = id });
            var item = _serviceViewUgovorStanOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult KupacDetail(long id, long? idUgovorKupac)
        {
            _serviceViewKupacDetalj = new Service.Data.View.KupacDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.KupacDetalj> field = new List<InLine.Model.Data.Field.View.KupacDetalj>();
            List<InLine.Model.Data.Filter.View.KupacDetalj> filter = new List<InLine.Model.Data.Filter.View.KupacDetalj>();
            List<InLine.Model.Data.Sort.View.KupacDetalj> sort = new List<InLine.Model.Data.Sort.View.KupacDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.KupacDetalj { Field = InLine.Model.Data.Field.View.KupacDetalj.ID_Kupac, Value = id });
            var item = _serviceViewKupacDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted(item);
            rezult.ID_UgovorStanOtkupKupac = Convert.ToInt64(idUgovorKupac);
            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KupacInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KupacDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            try
            {
                _serviceKupac = new Service.Data.Kupac(korisnik_data);


                if (viewmodel.ID_Kupac == -1)
                {
                    Model.Data.Item.KupacItem item = new Model.Data.Item.KupacItem(viewmodel);
                    Model.Data.Kupac insert = _serviceKupac.InsertResult(item);
                }
                else
                {
                    Model.Data.Kupac model = _serviceKupac.FindID(viewmodel.ID_Kupac);

                    if (model != null)
                    {
                        Model.Data.Item.KupacItem item = new Model.Data.Item.KupacItem(viewmodel);
                        Model.Data.Kupac update = _serviceKupac.UpdateResult(item);
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

        public ActionResult NalogDetail(long id)
        {
            _serviceViewUgovorStanOtkupNalogDetalj = new Service.Data.View.UgovorStanOtkupNalogDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupNalogDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupNalogDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupNalogDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupNalogDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupNalogDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupNalogDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupNalogDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupNalogDetalj.ID_Nalog, Value = id });
            var item = _serviceViewUgovorStanOtkupNalogDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupNalogDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupNalogDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult ObrokPreplataDetail(long id)
        {
            _serviceViewUgovorStanOtkupObrokPreplataDetalj = new Service.Data.View.UgovorStanOtkupObrokPreplataDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokPreplataDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupObrokPreplataDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokPreplataDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupObrokPreplataDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokPreplataDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupObrokPreplataDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupObrokPreplataDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupObrokPreplataDetalj.ID_UgovorStanOtkupObrokPreplata, Value = id });
            var item = _serviceViewUgovorStanOtkupObrokPreplataDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokPreplataDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupObrokPreplataDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult OpomenaUgovorDetail(long id)
        {
            _serviceViewUgovorStanOtkupOpomenaDetalj = new Service.Data.View.UgovorStanOtkupOpomenaDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkupOpomena, Value = id });
            var item = _serviceViewUgovorStanOtkupOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult TrosakDetail(long id)
        {
            _serviceViewUgovorStanOtkupTrosakDetalj = new Service.Data.View.UgovorStanOtkupTrosakDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupTrosakDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupTrosakDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupTrosakDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupTrosakDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupTrosakDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupTrosakDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupTrosakDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupTrosakDetalj.ID_UgovorStanOtkupTrosak, Value = id });
            var item = _serviceViewUgovorStanOtkupTrosakDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupTrosakDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupTrosakDetaljFormFormatted(item);
            return PartialView(rezult);
        }

        public ActionResult MoratorijMjesecDetail(long id)
        {
            _serviceViewUgovorStanOtkupMoratorijMjesecDetalj = new Service.Data.View.UgovorStanOtkupMoratorijMjesecDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijMjesecDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupMoratorijMjesecDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupMoratorijMjesecDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupMoratorijMjesecDetalj.ID_UgovorStanOtkupMoratorijMjesec, Value = id });
            var item = _serviceViewUgovorStanOtkupMoratorijMjesecDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupMoratorijMjesecDetaljFormFormatted(item);
            return PartialView(rezult);

        }

        public ActionResult OpomenaDetailTest(long id)
        {
            _serviceViewUgovorStanOtkupOpomenaDetalj = new Service.Data.View.UgovorStanOtkupOpomenaDetalj(korisnik_data);
            List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj>();
            List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj>();
            List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj>();
            filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkupOpomena, Value = id });
            var item = _serviceViewUgovorStanOtkupOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
            InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted(item);
            return PartialView(rezult);
        }


        //public ActionResult OpomenaDetail(long id)
        //{
        //    _serviceViewOpomenaDetalj = new Service.Data.View.OpomenaDetalj(korisnik_data);
        //    List<InLine.Model.Data.Field.View.OpomenaDetalj> field = new List<InLine.Model.Data.Field.View.OpomenaDetalj>();
        //    List<InLine.Model.Data.Filter.View.OpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.OpomenaDetalj>();
        //    List<InLine.Model.Data.Sort.View.OpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.OpomenaDetalj>();
        //    filter.Add(new InLine.Model.Data.Filter.View.OpomenaDetalj { Field = InLine.Model.Data.Field.View.OpomenaDetalj.ID_Opomena, Value = id });
        //    var item = _serviceViewOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
        //    InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted(item);
        //    return PartialView(rezult);
        //}


        // test unosa više formi
        //public ActionResult OpomenaDetailSpremi(InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted model)
        //{
        //    _serviceOpomena = new Service.Data.Opomena(korisnik_data);

        //    Model.Data.Item.OpomenaItem item = new Model.Data.Item.OpomenaItem();
        //    item.ID_Opomena = model.ID_Opomena;
        //    item.ID_Zapis = model.ID_Zapis;
        //    item.BrojOpomena = model.BrojOpomena;
        //    item.Datum = model.Datum;
        //    item.DatumDospijeceOd = model.DatumDospijeceOd;
        //    item.DatumDospijeceDo = model.DatumDospijeceDo;
        //    item.BrojNeplaceniObrokMin = model.BrojNeplaceniObrokMin;
        //    item.OpomenaIznosMin = model.OpomenaIznosMin;
        //    item.ID_OsobaUpdate = model.ID_OsobaUpdate;
        //    item.DatumUpdate = model.DatumUpdate;

        //    Model.Data.Opomena update = _serviceOpomena.UpdateResult(item);

        //    if (update != null)
        //    {
        //        _serviceViewOpomenaDetalj = new Service.Data.View.OpomenaDetalj(korisnik_data);
        //        List<InLine.Model.Data.Field.View.OpomenaDetalj> field = new List<InLine.Model.Data.Field.View.OpomenaDetalj>();
        //        List<InLine.Model.Data.Filter.View.OpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.OpomenaDetalj>();
        //        List<InLine.Model.Data.Sort.View.OpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.OpomenaDetalj>();
        //        filter.Add(new InLine.Model.Data.Filter.View.OpomenaDetalj { Field = InLine.Model.Data.Field.View.OpomenaDetalj.ID_Opomena, Value = update.ID_Opomena });
        //        var itemview = _serviceViewOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
        //        InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OpomenaDetaljFormFormatted(itemview);

        //        return Json("Spremljeno", JsonRequestBehavior.AllowGet);
        //    }
     

        //    return Json("Nema promjene", JsonRequestBehavior.AllowGet);
        //}

        public ActionResult OpomenaUgovorDetailSpremi(InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted model)
        {
            _serviceUgovorStanOtkupOpomena = new Service.Data.UgovorStanOtkupOpomena(korisnik_data);

            Model.Data.Item.UgovorStanOtkupOpomenaItem item = new Model.Data.Item.UgovorStanOtkupOpomenaItem();
            item.ID_UgovorStanOtkupOpomena = model.ID_UgovorStanOtkupOpomena;
            item.ID_UgovorStanOtkup = model.ID_UgovorStanOtkup;
            item.ID_Opomena = model.ID_Opomena;
            item.BrojUgovor = model.BrojUgovor;
            item.BrojOpomena = model.BrojOpomena;
            item.IznosDug = model.IznosDug;
            item.IznosZateznaKamata = model.IznosZateznaKamata;
            item.IznosZateznaKamataDugOstatak = model.IznosZateznaKamataDugOstatak;
            item.ID_OsobaInsert = model.ID_OsobaInsertUSOO;
            item.ID_OsobaUpdate = model.ID_OsobaUpdateUSOO;
            item.DatumInsert = model.DatumInsertUSOO;
            item.DatumUpdate = model.DatumUpdateUSOO;
            item.Ispis = model.Ispis;

            Model.Data.UgovorStanOtkupOpomena update = _serviceUgovorStanOtkupOpomena.UpdateResult(item);

            if (update != null)
            {
                _serviceViewUgovorStanOtkupOpomenaDetalj = new Service.Data.View.UgovorStanOtkupOpomenaDetalj(korisnik_data);
                List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj> field = new List<InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj>();
                List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj> filter = new List<InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj>();
                List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj> sort = new List<InLine.Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj { Field = InLine.Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj.ID_UgovorStanOtkupOpomena, Value = update.ID_UgovorStanOtkupOpomena });
                var itemview = _serviceViewUgovorStanOtkupOpomenaDetalj.GetData(field, filter, sort).FirstOrDefault();
                InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.UgovorStanOtkupOpomenaDetaljFormFormatted(itemview);

                return Json("Spremljeno", JsonRequestBehavior.AllowGet);
            }


            return Json("Nema promjene", JsonRequestBehavior.AllowGet);
        }


        public ActionResult NapomenaSpremi(long id, string napomena)
        {
            _serviceUgovorStanOtkup = new Service.Data.UgovorStanOtkup(korisnik_data);
            Model.Data.UgovorStanOtkup model = _serviceUgovorStanOtkup.FindID(id);

            if (model != null)
            {
                Model.Data.Item.UgovorStanOtkupItem item = new Model.Data.Item.UgovorStanOtkupItem(model);
                item.Napomena = napomena;
                Model.Data.UgovorStanOtkup update = _serviceUgovorStanOtkup.UpdateResult(item);


                return Json(update.Napomena, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Nositelj(long id)
        {

            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceUgovorStanOtkupKupac = new Service.Data.UgovorStanOtkupKupac(korisnik_data);
                Model.Data.UgovorStanOtkupKupac usok = _serviceUgovorStanOtkupKupac.FindID(Convert.ToInt64(id));
                return PartialView(usok);
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

        public ActionResult NositeljStatusPromjena(long id, long status)
        {
            _serviceUgovorStanOtkupKupac = new Service.Data.UgovorStanOtkupKupac(korisnik_data);
            Model.Data.UgovorStanOtkupKupac model = _serviceUgovorStanOtkupKupac.FindID(Convert.ToInt64(id));

            if (model != null)
            {
                List<InLine.Model.Data.Field.UgovorStanOtkupKupac> field = new List<InLine.Model.Data.Field.UgovorStanOtkupKupac>();
                List<InLine.Model.Data.Filter.UgovorStanOtkupKupac> filter = new List<InLine.Model.Data.Filter.UgovorStanOtkupKupac>();
                List<InLine.Model.Data.Sort.UgovorStanOtkupKupac> sort = new List<InLine.Model.Data.Sort.UgovorStanOtkupKupac>();
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupKupac { Field = InLine.Model.Data.Field.UgovorStanOtkupKupac.ID_UgovorStanOtkup, Value = model.ID_UgovorStanOtkup});
                filter.Add(new InLine.Model.Data.Filter.UgovorStanOtkupKupac { Field = InLine.Model.Data.Field.UgovorStanOtkupKupac.Nositelj, Value = 1 });
                List<InLine.Model.Data.UgovorStanOtkupKupac> itemNositelj = _serviceUgovorStanOtkupKupac.GetData(field, filter, sort).ToList();

                foreach (InLine.Model.Data.UgovorStanOtkupKupac it in itemNositelj)
                {
                    it.Nositelj = false;
                    Model.Data.Item.UgovorStanOtkupKupacItem item = new Model.Data.Item.UgovorStanOtkupKupacItem(it);
                    Model.Data.UgovorStanOtkupKupac update = _serviceUgovorStanOtkupKupac.UpdateResult(item);
                }

                if (status == 1)
                {
                    Model.Data.Item.UgovorStanOtkupKupacItem noviNositeljItem = new Model.Data.Item.UgovorStanOtkupKupacItem(model);
                    noviNositeljItem.Nositelj = true;
                    Model.Data.UgovorStanOtkupKupac update = _serviceUgovorStanOtkupKupac.UpdateResult(noviNositeljItem);
                    return Json(true, JsonRequestBehavior.AllowGet);

                }

                return Json(false, JsonRequestBehavior.AllowGet);
             
            }

            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
           
        }

        public ActionResult GetPosta(string query, int kriterij)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            //List<InLine.Model.Data.Posta> posta = new  List<InLine.Model.Data.Posta>();
            List<InLine.Model.Data.Posta> item = new  List<InLine.Model.Data.Posta>();
            var posta = new  List<InLine.Model.Data.Posta>();


            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _servicePosta = new Service.Data.Posta(korisnik_data);
                List<InLine.Model.Data.Field.Posta> field = new List<InLine.Model.Data.Field.Posta>();
                List<InLine.Model.Data.Filter.Posta> filter = new List<InLine.Model.Data.Filter.Posta>();
                List<InLine.Model.Data.Sort.Posta> sort = new List<InLine.Model.Data.Sort.Posta>();

                switch (kriterij)
                {
                    case 1:
                        item = _servicePosta.GetData(field, filter, sort).Where(p => p.ID_Posta.ToString().StartsWith(query.ToUpper())).ToList();

                        var postaitem1 = from i in item
                                     select new InLine.Model.Data.Posta 
                                     {
                                         ID_Posta = i.ID_Posta,
                                         IDDrzava = i.IDDrzava,
                                         Oznaka = i.Oznaka,
                                         Naziv = i.Naziv,
                                         NazivKr = i.NazivKr,
                                         Kratica = i.Kratica,
                                         StsPosta = i.StsPosta,
                                         IzborPosta = i.IzborPosta,
                                         ID_Zupanija = i.ID_Zupanija,
                                         Zupanija = i.Zupanija,
                                         PostanskiBroj = i.PostanskiBroj
                                     };

                        posta = postaitem1.ToList();
  
                        break;
                    case 2:
                        item = _servicePosta.GetData(field, filter, sort).Where(p => p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();

                            var postaitem2 = from i in item
                                     select new InLine.Model.Data.Posta 
                                     {
                                         ID_Posta = i.ID_Posta,
                                         IDDrzava = i.IDDrzava,
                                         Oznaka = i.Oznaka,
                                         Naziv = i.Naziv,
                                         NazivKr = i.NazivKr,
                                         Kratica = i.Kratica,
                                         StsPosta = i.StsPosta,
                                         IzborPosta = i.IzborPosta,
                                         ID_Zupanija = i.ID_Zupanija,
                                         Zupanija = i.Zupanija,
                                         PostanskiBroj = i.PostanskiBroj
                                     };

                        posta = postaitem2.ToList();

                        break;
   
                }
              
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

            }

            return Json(posta, JsonRequestBehavior.AllowGet);
           
        }

        
        

        # region ObrokPomocneFunkcije

        public ActionResult Placen()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            dict = PlacenDictionary();
            return PartialView("Select", dict);
        }

        public Dictionary<long, string> PlacenDictionary()
        {
            Dictionary<long, string> dict = new Dictionary<long, string>();
            dict.Add(0, "Neplaćeni");
            dict.Add(1, "Plaćeni");
            dict.Add(3, "Svi");


            return dict;
        }

        public string GetObrokFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
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

            if (searchingName == "ID_Kupac")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }
            if (searchingName == "ID_UgovorStanOtkup")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }

            if (searchingName == "Placen")
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }


            if (searchingName == "Naziv")
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
            if (searchingName == "UlicaKupac")
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
            if (searchingName == "UlicaStan")
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
            if (searchingName == "JMBG")
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
            if (searchingName == "OIB")
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

        # endregion


    }
}
