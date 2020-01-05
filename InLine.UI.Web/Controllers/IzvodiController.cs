using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lib.Web.Mvc.JQuery.JqGrid;
using System.Text;
using InLine.Repository.Data.Helper;
using InLine.UI.Web.Models.ViewModelCustom;
using InLine.UI.Web.T4.GridFormattedTemplate.View;
using InLine.UI.Web.T4.FormFormattedTemplate;
using InLine.Model.Admin;
using InLine.UI.Web.Helper;
using InLine.UI.Web.T4.FormFormattedTemplate.View;
using System.IO;
using FileHelpers;
using FileHelpers.MasterDetail;
using FileHelpers.DataLink;
using MasterDetails = FileHelpers.MasterDetail.MasterDetails<object, object>;
using System.Globalization;
using System.Transactions;

namespace InLine.UI.Web.Controllers
{
    public class IzvodiController : InLine.UI.Web.Controllers.Izvod2012AController
    {	
        
        
        #region Fields

        public Izvod.Labela izvodLabela = new Izvod.Labela();
        public List<String> porukaIzvod = new List<String>();

        #endregion


        #region Konstruktor

        Service.Data.View.IGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt;

        Service.Data.View.ISubjektRacunBanka _serviceViewSubjektRacunBanka;

        Service.Data.View.IIzvod2012A _serviceViewIzvod2012A;
        Service.Data.View.IIzvod2012AOtkup _serviceViewIzvod2012AOtkup;
        Service.Data.View.IIzvod2012ADetalj _serviceViewIzvod2012ADetalj;
        Service.Data.View.IIzvod2012AOtkupDetalj _serviceViewIzvod2012AOtkupDetalj;

        Service.Data.IIzvod _serviceIzvod;
        Service.Data.IIzvod2012A _serviceIzvod2012A;

        Service.Data.View.IIzvod2012ASt _serviceViewIzvod2012ASt;
        Service.Data.View.IIzvod2012AStOtkup _serviceViewIzvod2012AStOtkup;
        Service.Data.View.IIzvod2012AStDetalj _serviceViewIzvod2012AStDetalj;
        Service.Data.View.IIzvod2012AStOtkupDetalj _serviceViewIzvod2012AStOtkupDetalj;
        Service.Data.IIzvodSt _serviceIzvodSt;
        Service.Data.IIzvod2012ASt _serviceIzvod2012ASt;

        Service.Data.View.IUgovorStanOtkupObrokUplata _serviceViewUgovorStanOtkupObrokUplata;
        Service.Data.View.IUgovorStanOtkupObrokPreplata _serviceViewUgovorStanOtkupObrokPreplata;

        Service.Data.ISubjektRacun _serviceSubjektRacun;

        Service.Data.IPoslovnaGodina _servicePoslovnaGodina;



        public IzvodiController()
        {
        
        }


        public IzvodiController(Model.Admin.KorisnikData korisnik_data)   
        {
            this.korisnik_data = korisnik_data;
    	}


        # endregion


        #region View

        public ActionResult Izvodi()
        {
            return View();
        }

        public ActionResult IzvodiPregled()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektComboFormatted();

            _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
            List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina, Value = korisnik_data.ID_PoslovnaGodina });
            sort.Add(new InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga, Descending = true });
            var item = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).FirstOrDefault();

            if (item != null)
            {
                rezult.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
                rezult.ID_KontniPlan = Convert.ToInt64(item.ID_KontniPlan);
                rezult.ID_Subjekt = Convert.ToInt64(item.ID_Subjekt);
                rezult.Godina = Convert.ToInt32(item.Godina);
                rezult.Naziv = item.Naziv;
                rezult.DatumOd = item.DatumOd;
                rezult.DatumDo = item.DatumDo;
                rezult.ID_PoslovnaGodina = item.ID_PoslovnaGodina;

                var rez = GetSubjektRacunOne(rezult.ID_Subjekt);
                if (rez != null)
                {
                    rezult.ID_SubjektRacun = rez.ID_SubjektRacun;
                    rezult.RacunBroj = rez.Broj.Trim();
                    rezult.RacunNaziv = rez.Naziv.Trim();
                }

                else
                {
                    rezult.ID_SubjektRacun = -1;
                }
            }

            else
            {
                rezult.ID_GlavnaKnjiga = 0;
                rezult.ID_KontniPlan = 0;
                rezult.ID_Subjekt = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
                rezult.DatumOd = item.DatumOd;
                rezult.DatumDo = item.DatumDo;
                rezult.ID_SubjektRacun = 0;
                rezult.ID_PoslovnaGodina = 0;
            }

            return View(rezult);
        }


        public ActionResult IzvodiPregledGrad()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektComboFormatted();

            _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
            List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina, Value = korisnik_data.ID_PoslovnaGodina });
            sort.Add(new InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga, Descending = true });
            var item = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).FirstOrDefault();

            if (item != null)
            {
                rezult.ID_GlavnaKnjiga = item.ID_GlavnaKnjiga;
                rezult.ID_KontniPlan = Convert.ToInt64(item.ID_KontniPlan);
                rezult.ID_Subjekt = Convert.ToInt64(item.ID_Subjekt);
                rezult.Godina = Convert.ToInt32(item.Godina);
                rezult.Naziv = item.Naziv;
                rezult.DatumOd = item.DatumOd;
                rezult.DatumDo = item.DatumDo;
                rezult.ID_PoslovnaGodina = item.ID_PoslovnaGodina;

                var rez = GetSubjektRacunOne(rezult.ID_Subjekt);
                if (rez != null)
                {
                    rezult.ID_SubjektRacun = rez.ID_SubjektRacun;
                    rezult.RacunBroj = rez.Broj.Trim();
                    rezult.RacunNaziv = rez.Naziv.Trim();
                }

                else
                {
                    rezult.ID_SubjektRacun = -1;
                }
            }

            else
            {
                rezult.ID_GlavnaKnjiga = 0;
                rezult.ID_KontniPlan = 0;
                rezult.ID_Subjekt = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
                rezult.DatumOd = item.DatumOd;
                rezult.DatumDo = item.DatumDo;
                rezult.ID_SubjektRacun = 0;
                rezult.ID_PoslovnaGodina = 0;
            }

            return View(rezult);
        }

        public ActionResult Datoteka()
        {
            return View();
        }

        # endregion

        # region SubjektRacunBanka

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SubjektRacunBankaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewSubjektRacunBanka = new Service.Data.View.SubjektRacunBanka(korisnik_data);

                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.SubjektRacunBankaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.SubjektRacunBankaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }


                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewSubjektRacunBanka.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewSubjektRacunBanka.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<SubjektRacunBankaGridFormatted>(Convert.ToString(item.ID_SubjektRacun), new SubjektRacunBankaGridFormatted(item)));

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


        public ActionResult GetSubjektRacun(string query, long idSubjekt,  long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.SubjektRacunBanka> rezult = new List<InLine.Model.Data.View.SubjektRacunBanka>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceViewSubjektRacunBanka = new Service.Data.View.SubjektRacunBanka(korisnik_data);
                List<InLine.Model.Data.Field.View.SubjektRacunBanka> field = new List<InLine.Model.Data.Field.View.SubjektRacunBanka>();
                List<InLine.Model.Data.Filter.View.SubjektRacunBanka> filter = new List<InLine.Model.Data.Filter.View.SubjektRacunBanka>();
                filter.Add(new InLine.Model.Data.Filter.View.SubjektRacunBanka { Field = InLine.Model.Data.Field.View.SubjektRacunBanka.ID_Subjekt, Value = Convert.ToInt64(idSubjekt)});
                List<InLine.Model.Data.Sort.View.SubjektRacunBanka> sort = new List<InLine.Model.Data.Sort.View.SubjektRacunBanka>();
                sort.Add(new InLine.Model.Data.Sort.View.SubjektRacunBanka { Field = InLine.Model.Data.Field.View.SubjektRacunBanka.Broj, Descending = false });
                rezult = _serviceViewSubjektRacunBanka.GetData(field, filter, sort).Where(p => p.Broj.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.BankaNaziv.ToString().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();     
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


        public InLine.Model.Data.View.SubjektRacunBanka GetSubjektRacunOne(long idSubjekt)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.SubjektRacunBanka rezult = new InLine.Model.Data.View.SubjektRacunBanka();

            try
            {
                _serviceViewSubjektRacunBanka = new Service.Data.View.SubjektRacunBanka(korisnik_data);
                List<InLine.Model.Data.Field.View.SubjektRacunBanka> field = new List<InLine.Model.Data.Field.View.SubjektRacunBanka>();
                List<InLine.Model.Data.Filter.View.SubjektRacunBanka> filter = new List<InLine.Model.Data.Filter.View.SubjektRacunBanka>();
                filter.Add(new InLine.Model.Data.Filter.View.SubjektRacunBanka { Field = InLine.Model.Data.Field.View.SubjektRacunBanka.ID_Subjekt, Value = Convert.ToInt64(idSubjekt) });
                List<InLine.Model.Data.Sort.View.SubjektRacunBanka> sort = new List<InLine.Model.Data.Sort.View.SubjektRacunBanka>();
                sort.Add(new InLine.Model.Data.Sort.View.SubjektRacunBanka { Field = InLine.Model.Data.Field.View.SubjektRacunBanka.Broj, Descending = false });
                rezult = _serviceViewSubjektRacunBanka.GetData(field, filter, sort).Where(p => p.Broj.Trim() == "1500076927").FirstOrDefault();
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

        public ActionResult GetSubjektRacunDefault(long idSubjekt)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.SubjektRacunBanka rezult = new InLine.Model.Data.View.SubjektRacunBanka();

            try
            {
                rezult = GetSubjektRacunOne(idSubjekt);
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


        # region Izvod

        public ActionResult Izvod2012AGrid(JqGridRequest request, string key, string value, string datumOd, string datumDo, int vrsta)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewIzvod2012A = new Service.Data.View.Izvod2012A(korisnik_data);

                string filterExpression = String.Empty;

                bool customsearch = false;

                DateTime DatumOd = DateTime.ParseExact(datumOd, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime DatumDo = DateTime.ParseExact(datumDo, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.Izvod2012AViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.Izvod2012AViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }


                string sortingName = request.SortingName;

                long totalRecordsCount = -1;

                switch (vrsta)
                {
                     case 1:
                           totalRecordsCount = _serviceViewIzvod2012A.GetCount("DatumIzvadak IS NOT NULL AND ( DatumIzvadak >= " + "'" + DatumOd.Date.ToString("yyyy-MM-dd") + "'" + " AND DatumIzvadak <=  " + "'" + DatumDo.Date.ToString("yyyy-MM-dd") + "' )", key, value, customsearch);
                            response = new JqGridResponse()
                            {
                                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                                PageIndex = request.PageIndex,
                                TotalRecordsCount = totalRecordsCount

                            };
                            response.Records.AddRange(from item in _serviceViewIzvod2012A.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch).Where((p => p.DatumIzvadak != null && (p.DatumIzvadak.Value.Date >= DatumOd && p.DatumIzvadak.Value.Date <= DatumDo)))
                                                        select new JqGridRecord<Izvod2012AGridFormatted>(Convert.ToString(item.ID_Izvod2012A), new Izvod2012AGridFormatted(item)));
                        break;

                    case 2:
                        totalRecordsCount = _serviceViewIzvod2012A.GetCount(filterExpression, key, value, customsearch);

                        response = new JqGridResponse()
                        {
                            TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                            PageIndex = request.PageIndex,
                            TotalRecordsCount = totalRecordsCount

                        };
                        response.Records.AddRange(from item in _serviceViewIzvod2012A.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                                  select new JqGridRecord<Izvod2012AGridFormatted>(Convert.ToString(item.ID_Izvod), new Izvod2012AGridFormatted(item)));
                        break;
                    default:
                        totalRecordsCount = _serviceViewIzvod2012A.GetCount("DatumIzvadak IS NOT NULL AND ( DatumIzvadak >= " + "'" + DatumOd.Date.ToString("yyyy-MM-dd") + "'" + " AND DatumIzvadak <=  " + "'" + DatumDo.Date.ToString("yyyy-MM-dd") + "' )", key, value, customsearch);

                        response = new JqGridResponse()
                        {
                            TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                            PageIndex = request.PageIndex,
                            TotalRecordsCount = totalRecordsCount

                        };
                        response.Records.AddRange(from item in _serviceViewIzvod2012A.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch).Where((p => p.DatumIzvadak != null && (p.DatumIzvadak.Value.Date >= DatumOd && p.DatumIzvadak.Value.Date <= DatumDo)))
                                                  select new JqGridRecord<Izvod2012AGridFormatted>(Convert.ToString(item.ID_Izvod2012A), new Izvod2012AGridFormatted(item)));
                        break;
                }


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

        public ActionResult Izvod2012ADetalj(long? Id, long? IdMaster)
        {
            _serviceViewIzvod2012ADetalj = new Service.Data.View.Izvod2012ADetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012ADetaljFormFormatted rezult;



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.Izvod2012ADetalj> field = new List<InLine.Model.Data.Field.View.Izvod2012ADetalj>();
                List<InLine.Model.Data.Filter.View.Izvod2012ADetalj> filter = new List<InLine.Model.Data.Filter.View.Izvod2012ADetalj>();
                List<InLine.Model.Data.Sort.View.Izvod2012ADetalj> sort = new List<InLine.Model.Data.Sort.View.Izvod2012ADetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.Izvod2012ADetalj { Field = InLine.Model.Data.Field.View.Izvod2012ADetalj.ID_Izvod2012A, Value = Convert.ToInt64(Id) });
                var item = _serviceViewIzvod2012ADetalj.GetData(field, filter, sort).FirstOrDefault();
                if (item != null)
                {
                    rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012ADetaljFormFormatted(item);
                }

                else
                {
                    rezult = null;
                }
         
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012ADetaljFormFormatted();
        
            }

            return PartialView(rezult);
        }

        # endregion

        # region IzvodOtkup


        public ActionResult Izvod2012AOtkupGrid(JqGridRequest request, string key, string value, string datumOd, string datumDo)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewIzvod2012AOtkup = new Service.Data.View.Izvod2012AOtkup(korisnik_data);

                string filterExpression = String.Empty;

                bool customsearch = false;

                DateTime DatumOd = DateTime.ParseExact(datumOd, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime DatumDo = DateTime.ParseExact(datumDo, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.Izvod2012AOtkupViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.Izvod2012AOtkupViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;
                long totalRecordsCount = -1;

                totalRecordsCount = _serviceViewIzvod2012AOtkup.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                    {
                            TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                            PageIndex = request.PageIndex,
                            TotalRecordsCount = totalRecordsCount

                    };
                response.Records.AddRange(from item in _serviceViewIzvod2012AOtkup.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                                  select new JqGridRecord<Izvod2012AOtkupGridFormatted>(Convert.ToString(item.ID_Izvod), new Izvod2012AOtkupGridFormatted(item)));

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

        public ActionResult Izvod2012AOtkupDetalj(long? Id, long? IdMaster)
        {
            _serviceViewIzvod2012AOtkupDetalj = new Service.Data.View.Izvod2012AOtkupDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AOtkupDetaljFormFormatted rezult;



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.Izvod2012AOtkupDetalj> field = new List<InLine.Model.Data.Field.View.Izvod2012AOtkupDetalj>();
                List<InLine.Model.Data.Filter.View.Izvod2012AOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.Izvod2012AOtkupDetalj>();
                List<InLine.Model.Data.Sort.View.Izvod2012AOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.Izvod2012AOtkupDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.Izvod2012AOtkupDetalj { Field = InLine.Model.Data.Field.View.Izvod2012AOtkupDetalj.ID_Izvod2012A, Value = Convert.ToInt64(Id) });
                var item = _serviceViewIzvod2012AOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();
                if (item != null)
                {
                    rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AOtkupDetaljFormFormatted(item);
                }

                else
                {
                    rezult = null;
                }

            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AOtkupDetaljFormFormatted();

            }

            return PartialView(rezult);
        }

        # endregion


        # region IzvodSt

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Izvod2012AStGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewIzvod2012ASt = new Service.Data.View.Izvod2012ASt(korisnik_data);

                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.Izvod2012AStViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.Izvod2012AStViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }


                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewIzvod2012ASt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewIzvod2012ASt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<Izvod2012AStGridFormatted>(Convert.ToString(item.ID_Izvod2012ASt), new Izvod2012AStGridFormatted(item)));

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

        public ActionResult Izvod2012AStDetalj(long? Id, long? IdMaster)
        {
            _serviceViewIzvod2012AStDetalj = new Service.Data.View.Izvod2012AStDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStDetaljFormFormatted rezult;



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.Izvod2012AStDetalj> field = new List<InLine.Model.Data.Field.View.Izvod2012AStDetalj>();
                List<InLine.Model.Data.Filter.View.Izvod2012AStDetalj> filter = new List<InLine.Model.Data.Filter.View.Izvod2012AStDetalj>();
                List<InLine.Model.Data.Sort.View.Izvod2012AStDetalj> sort = new List<InLine.Model.Data.Sort.View.Izvod2012AStDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.Izvod2012AStDetalj { Field = InLine.Model.Data.Field.View.Izvod2012AStDetalj.ID_Izvod2012ASt, Value = Convert.ToInt64(Id) });
                var item = _serviceViewIzvod2012AStDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStDetaljFormFormatted();
            }

            return PartialView(rezult);
        }

        # endregion

        # region IzvodStOtkup

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Izvod2012AStOtkupGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewIzvod2012AStOtkup = new Service.Data.View.Izvod2012AStOtkup(korisnik_data);

                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.Izvod2012AStOtkupViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.Izvod2012AStOtkupViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }


                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewIzvod2012AStOtkup.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewIzvod2012AStOtkup.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<Izvod2012AStOtkupGridFormatted>(Convert.ToString(item.ID_Izvod2012ASt), new Izvod2012AStOtkupGridFormatted(item)));

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

        public ActionResult Izvod2012AStOtkupDetalj(long? Id, long? IdMaster)
        {
            _serviceViewIzvod2012AStOtkupDetalj = new Service.Data.View.Izvod2012AStOtkupDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStOtkupDetaljFormFormatted rezult;



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.Izvod2012AStOtkupDetalj> field = new List<InLine.Model.Data.Field.View.Izvod2012AStOtkupDetalj>();
                List<InLine.Model.Data.Filter.View.Izvod2012AStOtkupDetalj> filter = new List<InLine.Model.Data.Filter.View.Izvod2012AStOtkupDetalj>();
                List<InLine.Model.Data.Sort.View.Izvod2012AStOtkupDetalj> sort = new List<InLine.Model.Data.Sort.View.Izvod2012AStOtkupDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.Izvod2012AStOtkupDetalj { Field = InLine.Model.Data.Field.View.Izvod2012AStOtkupDetalj.ID_Izvod2012ASt, Value = Convert.ToInt64(Id) });
                var item = _serviceViewIzvod2012AStOtkupDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStOtkupDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.Izvod2012AStOtkupDetaljFormFormatted();
            }

            return PartialView(rezult);
        }

        # endregion


        # region Uplata

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UplataGrid(JqGridRequest request, string key, string value, string key2, string value2)
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


            if (!String.IsNullOrEmpty(value2))
            {
                int BrojObrok = 0;
                BrojObrok = Convert.ToInt32(value2);
                filterExpression = "BrojObrok = " + BrojObrok + " ";
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

        # endregion

        # region Preplata

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PreplataGrid(JqGridRequest request, string key, string value, string key2, string value2)
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

  
            if (!String.IsNullOrEmpty(value2))
            {
                int BrojObrok = 0;
                BrojObrok = Convert.ToInt32(value2);
                filterExpression = "BrojObrok = " + BrojObrok + " ";
            }
  

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
        # endregion


        # region Datoteka

        [HttpPost]
        public ActionResult UploadDatoteka(HttpPostedFileBase file, string idOdabraniRacun, string datumOdUpload, string datumDoUpload, string kojaPoslovaGodina)
        {
            try
            {
                string putanja = Server.MapPath("~/Izvod/temp/");
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(putanja);

                foreach (FileInfo doc in directory.GetFiles())
                {
                    string[] separator = new string[] { "_" };
                    string[] dijelovi;
                    dijelovi = doc.Name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string kojaBaza = dijelovi.ElementAt(0).ToString().Trim();

                    if (kojaBaza == korisnik_data.ID_Database.ToString())
                    {
                        doc.Delete();
                    }
                }


                if (file != null)
                {
                    if (!Directory.Exists(putanja))
                    {
                        Directory.CreateDirectory(putanja);
                    }

                    var fileName = Path.GetFileName(file.FileName);
                    string FileExtension = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();

                    if (FileExtension == "txt")
                    {
                        String DatumUploadDatoteka = ConvertDatumUStringYYYYMMDD(DateTime.Now.Date);
                        fileName = korisnik_data.ID_Database + "_" + DatumUploadDatoteka + "_" + fileName;
                        var path = Path.Combine(putanja, fileName);
                        file.SaveAs(path);

                        RunTimeRecords(idOdabraniRacun, kojaPoslovaGodina);

                    }

                    else
                    {
                        porukaIzvod.Add("Izabrana datoteka nije datoteka izvoda.");
                        return Json(porukaIzvod, JsonRequestBehavior.AllowGet);
                    }


                }

                if (porukaIzvod.Count() == 0)
                {
                    porukaIzvod.Add("Učitavanje izvoda završeno.");
                }
        
                return Json(porukaIzvod, JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
                Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
                List<Model.Admin.StatusPoruka> poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                //return Json(poruke, JsonRequestBehavior.AllowGet);
                porukaIzvod.Add("Greška");
                return Json(porukaIzvod, JsonRequestBehavior.AllowGet);
            }

        }


   

        String ConvertDatumUStringYYYYMMDD(DateTime datum)
        {
            String rezult = String.Empty;
            int godina = datum.Year;
            int mjesec = datum.Month;
            int dan = datum.Day;
            string mjesecString = mjesec.ToString();
            string danString = dan.ToString();

            if (mjesec < 10)
            {
                mjesecString = "0" + mjesecString;
            }

            if (dan < 10)
            {
                danString = "0" + danString;
            }

            rezult = godina.ToString() + mjesecString + danString;

            return rezult;
        }


     

        public static DateTime ConvertStringUDatum(string datum)
        {
            DateTime rezult = DateTime.Now;
            string godinaString = datum.Substring(0, 4);
            string mjesecString = datum.Substring(4, 2);
            string danString = datum.Substring(6, 2);
            datum = godinaString + "-" + mjesecString + "-" + danString;

            rezult = DateTime.Parse(datum);

            return rezult;
        }

        public static String ConvertStringUDatumString(string datum)
        {
            String rezult = String.Empty;
            string godinaString = datum.Substring(0, 4);
            string mjesecString = datum.Substring(4, 2);
            string danString = datum.Substring(6, 2);
            datum = godinaString + "-" + mjesecString + "-" + danString;

            rezult = datum;

            return rezult;
        }

        # endregion

        #region FileHelper


        //RecordAction ExampleSelector(string record)
        //{
          

        //    string a = record.Substring(record.Length - 3);

        //    if (record.Substring(record.Length - 3) == "907" || record.Substring(record.Length - 3) == "909" || record.Substring(record.Length - 3) == "999")
        //    {
        //        string v = record;
        //        return RecordAction.Skip;
        //    }

        //    else if (record.Substring(record.Length - 3) == "900")
        //    {
        //        izvodLabela.BankaVBDI = record.Substring(0, 7);
        //        izvodLabela.BankaNaziv = record.Substring(7, 50);
        //        izvodLabela.BankaOIB = record.Substring(57, 11);
        //        izvodLabela.DatumObrada = record.Substring(72, 8);
        //    }

        //    else if (record.Substring(record.Length - 3) == "903")
        //    {
        //        return RecordAction.Master;
        //    }

        //    else if (record.Substring(record.Length - 3) == "905")
        //    {
        //        return RecordAction.Detail;
        //    }


        //    else if (record.StartsWith(""))
        //    {
        //        return RecordAction.Skip;
        //    }

        //    return RecordAction.Skip;
        //}


        //RecordAction ExampleSelector(string record)
        //{

        //    string a = record.Substring(record.Length - 3);

        //    if (record.Substring(record.Length - 3) == "907" || record.Substring(record.Length - 3) == "909" || record.Substring(record.Length - 3) == "999")
        //    {
        //        string v = record;
        //        return RecordAction.Skip;
        //    }

        //    else if (record.Substring(record.Length - 3) == "900")
        //    {
        //        izvodLabela.BankaVBDI = record.Substring(0, 7);
        //        izvodLabela.BankaNaziv = record.Substring(7, 50);
        //        izvodLabela.BankaOIB = record.Substring(57, 11);
        //        izvodLabela.DatumObrada = record.Substring(72, 8);
        //    }

        //    else if (record.Substring(record.Length - 3) == "903")
        //    {
        //        if (!String.IsNullOrEmpty(izvodLabela.RacunPojedinacnoUcitavanje))
        //        {
        //            String racun = record.Substring(22, 17);

        //            if (racun == izvodLabela.RacunPojedinacnoUcitavanje)
        //            {
        //                return RecordAction.Master;
        //            }
        //            else
        //            {
        //                return RecordAction.Skip;
        //            }

        //        }

        //        else
        //        {
        //              return RecordAction.Master;
        //        }

        //    }

        //    else if (record.Substring(record.Length - 3) == "905")
        //    {
        //        return RecordAction.Detail;
        //    }


        //    else if (record.StartsWith(""))
        //    {
        //        return RecordAction.Skip;
        //    }

        //    return RecordAction.Skip;
        //}


        RecordAction ExampleSelector(string record)
        {
         
            string a = record.Substring(record.Length - 3);

            if (record.Substring(record.Length - 3) == "907" || record.Substring(record.Length - 3) == "909" || record.Substring(record.Length - 3) == "999")
            {
                string v = record;
                return RecordAction.Skip;
            }

            else if (record.Substring(record.Length - 3) == "900")
            {
                izvodLabela.BankaVBDI = record.Substring(0, 7);
                izvodLabela.BankaNaziv = record.Substring(7, 50);
                izvodLabela.BankaOIB = record.Substring(57, 11);
                izvodLabela.DatumObrada = record.Substring(72, 8);
            }

            else if (record.Substring(record.Length - 3) == "903")
            {
               
                if (!String.IsNullOrEmpty(izvodLabela.RacunPojedinacnoUcitavanje))
                {
                     String racun = record.Substring(22, 17);

                    if (racun == izvodLabela.RacunPojedinacnoUcitavanje)
                    {
                        izvodLabela.RacunGlobal = racun;
                        return RecordAction.Master;
                    }
                    else
                    {
                        izvodLabela.RacunGlobal = racun;
                        return RecordAction.Skip;
                    }

                }

                else
                {
                    return RecordAction.Master;
                }

            }

            else if (record.Substring(record.Length - 3) == "905")
            {
                if (!String.IsNullOrEmpty(izvodLabela.RacunPojedinacnoUcitavanje))
                {
                    if (izvodLabela.RacunGlobal == izvodLabela.RacunPojedinacnoUcitavanje)
                    {
                        return RecordAction.Detail;
                    }
                    else
                    {
                        return RecordAction.Skip;
                    }
                    
                }

                return RecordAction.Detail;
            }


            else if (record.StartsWith(""))
            {
                return RecordAction.Skip;
            }

            return RecordAction.Skip;
        }


        public void RunTimeRecords(string idOdabraniRacun, string kojaPoslovaGodina)
        {
            String imeDatotekeIzvoda = String.Empty;
            MasterDetailEngine engine = new MasterDetailEngine(typeof(Izvod.Glava), typeof(Izvod.Stavka), new MasterDetailSelector(ExampleSelector));

            string putanjaspajanje = Server.MapPath("~/Izvod/temp/");
            System.IO.DirectoryInfo directoryspoji = new System.IO.DirectoryInfo(putanjaspajanje);

            string[] separator = new string[] { "_" };
            string[] dijelovi;

            foreach (FileInfo doc in directoryspoji.GetFiles())
            {
                dijelovi = doc.Name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string kojaBaza = dijelovi.ElementAt(0).ToString().Trim();
                string brojIzvoda = dijelovi.ElementAt(2).ToString().Trim();
                string kojiDatum = dijelovi.ElementAt(3).ToString().Trim();


                if (kojaBaza == korisnik_data.ID_Database.ToString())
                {
                    if(!String.IsNullOrEmpty(idOdabraniRacun))
                    {
                        long ID_SubjektRacun = Convert.ToInt64(idOdabraniRacun);

                        _serviceSubjektRacun = new Service.Data.SubjektRacun(korisnik_data);
                        Model.Data.SubjektRacun subjektRacun = _serviceSubjektRacun.FindID(ID_SubjektRacun);
                        if (subjektRacun != null)
                        {
                            //izvodLabela.RacunPojedinacnoUcitavanje = subjektRacun.IBAN;
                            izvodLabela.RacunPojedinacnoUcitavanje = subjektRacun.VBDI + subjektRacun.Broj;

                        }
                    }

                    if (!String.IsNullOrEmpty(kojaPoslovaGodina))
                    {

                        _servicePoslovnaGodina = new Service.Data.PoslovnaGodina(korisnik_data);
                        Model.Data.PoslovnaGodina poslovnaGodina = _servicePoslovnaGodina.FindID(Convert.ToInt64(kojaPoslovaGodina));

                        if (poslovnaGodina != null)
                        {
                            izvodLabela.DatumOd = poslovnaGodina.DatumOd;
                            izvodLabela.DatumDo = poslovnaGodina.DatumDo;

                        }
                    }


                        imeDatotekeIzvoda = doc.Name;
                        MasterDetails[] res = engine.ReadFile(putanjaspajanje + imeDatotekeIzvoda);
                        Boolean Obavi = UcitavanjeIzvodaUBazu(res);
              
                }
            }

        }

     

        //public bool CustomerOrdersWrite4(MasterDetails[] res)
        //{
        //   string a =  izvodLabela.BankaVBDI;
        //   string b = izvodLabela.BankaNaziv;
        //   string c = izvodLabela.BankaOIB;

        //   porukaIzvod.Add("CustomerOrdersWrite4");

        //   InLine.Repository.Data.Helper.Labela labHelper = new InLine.Repository.Data.Helper.Labela(izvodLabela);

        //    for (int i = 0; i < res.Count(); i++)
        //    {
        //        Izvod.Glava glMaster = (Izvod.Glava)res[i].Master;
        //        Izvod.GlavaProsirena gl = new Izvod.GlavaProsirena(glMaster);
        //        InLine.Repository.Data.Helper.Glava glHelper = new InLine.Repository.Data.Helper.Glava(gl);
        //        _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //        Model.Data.Izvod glavaInserted = _serviceIzvod.InsertIzvodIzvod2012A(glHelper, labHelper);

        //        if (glavaInserted != null)
        //        {
        //            foreach (var det in res[i].Details)
        //            {
        //                Izvod.Stavka stMaster = (Izvod.Stavka)det;
        //                Izvod.StavkaProsirena st = new Izvod.StavkaProsirena(stMaster);
        //                st.ID_Izvod = glavaInserted.ID_Izvod.ToString();
        //                InLine.Repository.Data.Helper.Stavka stHelper = new InLine.Repository.Data.Helper.Stavka(st);
        //                _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //                Model.Data.IzvodSt stavkaInserted = _serviceIzvod.InsertIzvodStIzvod2012ASt(stHelper);
        //            }

        //        }


        //    }

        //    return true;
        //}


        //public bool UcitavanjeIzvodaUBazu(MasterDetails[] res)
        //{
        //    string a = izvodLabela.BankaVBDI;
        //    string b = izvodLabela.BankaNaziv;
        //    string c = izvodLabela.BankaOIB;
        //    string d = izvodLabela.RacunPojedinacnoUcitavanje;

        //    InLine.Repository.Data.Helper.Labela labHelper = new InLine.Repository.Data.Helper.Labela(izvodLabela);
            

        //    for (int i = 0; i < res.Count(); i++)
        //    {
               
        //            Izvod.Glava glMaster = (Izvod.Glava)res[i].Master;
        //            Izvod.GlavaProsirena gl = new Izvod.GlavaProsirena(glMaster);
        //            InLine.Repository.Data.Helper.Glava glHelper = new InLine.Repository.Data.Helper.Glava(gl);
        //            DateTime DatumIzvadka = new DateTime(Convert.ToInt32(gl.DatumIzvadka.Substring(0, 4)), Convert.ToInt32(gl.DatumIzvadka.Substring(4, 2)), Convert.ToInt32(gl.DatumIzvadka.Substring(6, 2)));

        //                if (DatumIzvadka < izvodLabela.DatumOd || DatumIzvadka > izvodLabela.DatumDo)
        //                {

        //                    if (!porukaIzvod.Contains("Datum izvoda nije u granicama odabrane poslovne godine"))
        //                    {
        //                        porukaIzvod.Add("Datum izvoda nije u granicama odabrane poslovne godine");
        //                    }
                            
        //                }

        //                else
        //                {
        //                    if (!String.IsNullOrEmpty(izvodLabela.RacunPojedinacnoUcitavanje))
        //                    {
        //                        InLine.Model.Data.Izvod2012A PostojiIzvod = DaLiPostojiIzvodDatumRacunValutaRedniBroj(ConvertStringUDatumString(gl.DatumIzvadka), ConvertStringUDatumString(izvodLabela.DatumObrada), gl.TransakcijskiRacunKlijenta, gl.ValutaTransakcijskogRacuna, Convert.ToInt32(gl.RedniBrojIzvadka), Convert.ToInt32(gl.RedniBrojGrupePaketa));
        //                        if (PostojiIzvod != null && !String.IsNullOrEmpty(izvodLabela.RacunPojedinacnoUcitavanje) && gl.TransakcijskiRacunKlijenta.Substring(4, (gl.TransakcijskiRacunKlijenta.Length - 4)) == izvodLabela.RacunPojedinacnoUcitavanje)
        //                        {
        //                            porukaIzvod.Add(" Izvod broj: " + gl.RedniBrojIzvadka + " grupa: " + gl.RedniBrojGrupePaketa + " datum: " + gl.DatumIzvadka + " račun: " + gl.TransakcijskiRacunKlijenta + " valuta: " + gl.ValutaTransakcijskogRacuna + " je već učitan");
        //                        }

        //                        else
        //                        {
        //                            if (gl.TransakcijskiRacunKlijenta.Substring(4, (gl.TransakcijskiRacunKlijenta.Length - 4)) == izvodLabela.RacunPojedinacnoUcitavanje)
        //                            {
        //                                _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //                                Model.Data.Izvod glavaInserted = _serviceIzvod.InsertIzvodIzvod2012A(glHelper, labHelper);

        //                                if (glavaInserted != null)
        //                                {
        //                                    foreach (var det in res[i].Details)
        //                                    {
        //                                        Izvod.Stavka stMaster = (Izvod.Stavka)det;
        //                                        Izvod.StavkaProsirena st = new Izvod.StavkaProsirena(stMaster);
        //                                        st.ID_Izvod = glavaInserted.ID_Izvod.ToString();
        //                                        InLine.Repository.Data.Helper.Stavka stHelper = new InLine.Repository.Data.Helper.Stavka(st);
        //                                        _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //                                        Model.Data.IzvodSt stavkaInserted = _serviceIzvod.InsertIzvodStIzvod2012ASt(stHelper);
        //                                    }

        //                                }
        //                            }
        //                        }
                               
        //                    }

        //                    else
        //                    {

        //                        IEnumerable<InLine.Model.Data.Izvod2012A> PostojiIzvod = DaLiPostojiIzvod(ConvertStringUDatumString(gl.DatumIzvadka), ConvertStringUDatumString(izvodLabela.DatumObrada), gl.TransakcijskiRacunKlijenta, Convert.ToInt32(gl.RedniBrojIzvadka));
        //                        if (PostojiIzvod.Count() > 0)
        //                        {
        //                            porukaIzvod.Add(" Izvod broj: " + gl.RedniBrojIzvadka + " datum: " + gl.DatumIzvadka + " račun: " + gl.TransakcijskiRacunKlijenta + " je već učitan");
        //                        }

        //                        else
        //                        {
        //                            _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //                            Model.Data.Izvod glavaInserted = _serviceIzvod.InsertIzvodIzvod2012A(glHelper, labHelper);


        //                            if (glavaInserted != null)
        //                            {
        //                                foreach (var det in res[i].Details)
        //                                {
        //                                    Izvod.Stavka stMaster = (Izvod.Stavka)det;
        //                                    Izvod.StavkaProsirena st = new Izvod.StavkaProsirena(stMaster);
        //                                    st.ID_Izvod = glavaInserted.ID_Izvod.ToString();
        //                                    InLine.Repository.Data.Helper.Stavka stHelper = new InLine.Repository.Data.Helper.Stavka(st);
        //                                    _serviceIzvod = new Service.Data.Izvod(korisnik_data);
        //                                    Model.Data.IzvodSt stavkaInserted = _serviceIzvod.InsertIzvodStIzvod2012ASt(stHelper);
        //                                }

        //                            }
        //                        }
        //                    }

        //                }
                   

        //    }

        //    return true;
        //}



        public bool UcitavanjeIzvodaUBazu(MasterDetails[] res)
        {
            string a = izvodLabela.BankaVBDI;
            string b = izvodLabela.BankaNaziv;
            string c = izvodLabela.BankaOIB;
            string d = izvodLabela.RacunPojedinacnoUcitavanje;

            InLine.Repository.Data.Helper.Labela labHelper = new InLine.Repository.Data.Helper.Labela(izvodLabela);

            IEnumerable<InLine.Model.Data.Izvod2012A> PostojiIzvodLista = new List<InLine.Model.Data.Izvod2012A>();
            InLine.Model.Data.Izvod2012A PostojiIzvod = new InLine.Model.Data.Izvod2012A();



            for (int i = 0; i < res.Count(); i++)
            {

                Izvod.Glava glMaster = (Izvod.Glava)res[i].Master;
                Izvod.GlavaProsirena gl = new Izvod.GlavaProsirena(glMaster);
                InLine.Repository.Data.Helper.Glava glHelper = new InLine.Repository.Data.Helper.Glava(gl);
                DateTime DatumIzvadka = new DateTime(Convert.ToInt32(glHelper.DatumIzvadka.Substring(0, 4)), Convert.ToInt32(glHelper.DatumIzvadka.Substring(4, 2)), Convert.ToInt32(glHelper.DatumIzvadka.Substring(6, 2)));

                if (res.Count() > 1)
                {
                    PostojiIzvodLista = DaLiPostojiIzvod(ConvertStringUDatumString(glHelper.DatumIzvadka), ConvertStringUDatumString(izvodLabela.DatumObrada), glHelper.TransakcijskiRacunKlijenta, Convert.ToInt32(glHelper.RedniBrojIzvadka));
                }

                else
                {
                    PostojiIzvod = DaLiPostojiIzvodDatumRacunValutaRedniBroj(ConvertStringUDatumString(glHelper.DatumIzvadka), ConvertStringUDatumString(izvodLabela.DatumObrada), glHelper.TransakcijskiRacunKlijenta, glHelper.ValutaTransakcijskogRacuna, Convert.ToInt32(glHelper.RedniBrojIzvadka), Convert.ToInt32(glHelper.RedniBrojGrupePaketa));

                    if (PostojiIzvod == null)
                    {
                       PostojiIzvod = new InLine.Model.Data.Izvod2012A();
                    }
                }


                if (DatumIzvadka < izvodLabela.DatumOd || DatumIzvadka > izvodLabela.DatumDo)
                {

                    if (!porukaIzvod.Contains("Datum izvoda nije u granicama odabrane poslovne godine"))
                    {
                        porukaIzvod.Add("Datum izvoda nije u granicama odabrane poslovne godine");
                    }

                }

                else
                {

                    if (PostojiIzvodLista.Count() > 0 || PostojiIzvod.ID_Izvod2012A > 0)
                    {
                        if (PostojiIzvodLista.Count() > 0 && (PostojiIzvod.ID_Izvod2012A >= 0))
                        {
                            porukaIzvod.Add(" Izvod broj: " + glHelper.RedniBrojIzvadka + " datum: " + glHelper.DatumIzvadka + " račun: " + glHelper.TransakcijskiRacunKlijenta + " je već učitan");
                        }
                        else
                        {
                            if (PostojiIzvodLista.Count() == 0 && PostojiIzvod.ID_Izvod2012A > 0)
                            {
                                porukaIzvod.Add(" Izvod broj: " + glHelper.RedniBrojIzvadka + " grupa: " + glHelper.RedniBrojGrupePaketa + " datum: " + glHelper.DatumIzvadka + " račun: " + glHelper.TransakcijskiRacunKlijenta + " valuta: " + glHelper.ValutaTransakcijskogRacuna + " je već učitan");
                            }
                        }
                    }

                    else
                    {
                        try
                        {
                            using (TransactionScope tran = new TransactionScope())
                            {

                                _serviceIzvod = new Service.Data.Izvod(korisnik_data);
                                Model.Data.Izvod glavaInserted = _serviceIzvod.InsertIzvodIzvod2012A(glHelper, labHelper);

                                if (glavaInserted != null)
                                {
                                    foreach (var det in res[i].Details)
                                    {
                                        Izvod.Stavka stMaster = (Izvod.Stavka)det;
                                        Izvod.StavkaProsirena st = new Izvod.StavkaProsirena(stMaster);
                                        st.ID_Izvod = glavaInserted.ID_Izvod.ToString();
                                        InLine.Repository.Data.Helper.Stavka stHelper = new InLine.Repository.Data.Helper.Stavka(st);
                                        _serviceIzvod = new Service.Data.Izvod(korisnik_data);
                                        Model.Data.IzvodSt stavkaInserted = _serviceIzvod.InsertIzvodStIzvod2012ASt(stHelper);
                                    }

                                }

                                tran.Complete();
                            }
                        }

                        catch (Exception ex)
                        {
                            porukaIzvod.Add("GREŠKA KOD UČITAVANJA: Izvod broj: " + glHelper.RedniBrojIzvadka + " datum: " + glHelper.DatumIzvadka + " račun: " + glHelper.TransakcijskiRacunKlijenta + " "  + ex.Message.ToString());

                            ////IList<InLine.Model.Data.Izvod2012ASt> IzvodStLista = new List<InLine.Model.Data.Izvod2012ASt>();
                            //PostojiIzvodLista = DaLiPostojiIzvod(ConvertStringUDatumString(glHelper.DatumIzvadka), ConvertStringUDatumString(izvodLabela.DatumObrada), glHelper.TransakcijskiRacunKlijenta, Convert.ToInt32(glHelper.RedniBrojIzvadka));
                            //List<long> IDIzvod = new List<long>();
                            //List<long> IDIzvodSt = new List<long>();
                            ////List<InLine.Model.Data.IzvodSt> IzvodStLista = new List<Model.Data.IzvodSt>();
                            //List<long> IzvodStListaLong = new List<long>();

                            //StringBuilder Upit = new StringBuilder();
                            //StringBuilder InUvjetIzvod = new StringBuilder();
                            //StringBuilder InUvjetIzvodSt = new StringBuilder();

                            //List<InLine.Model.Data.Field.IzvodSt> fieldIzvodSt = new List<InLine.Model.Data.Field.IzvodSt>();
                            //List<InLine.Model.Data.Filter.IzvodSt> filterIzvodSt = new List<InLine.Model.Data.Filter.IzvodSt>();
                            //List<InLine.Model.Data.Sort.IzvodSt> sortIzvodSt = new List<InLine.Model.Data.Sort.IzvodSt>();
                            //_serviceIzvodSt = new Service.Data.IzvodSt(korisnik_data);
                            //List<InLine.Model.Data.IzvodSt> IzvodStSve = _serviceIzvodSt.GetData(fieldIzvodSt, filterIzvodSt, sortIzvodSt).ToList();


                            //if (PostojiIzvodLista.Count() > 0)
                            //{
                            //    InUvjetIzvod.Append(" IN ( ");

                            //    foreach (var Izvod in PostojiIzvodLista)
                            //    {
                            //        IDIzvod.Add(Convert.ToInt64(Izvod.ID_Izvod));
                            //        InUvjetIzvod.Append(Convert.ToInt64(Izvod.ID_Izvod) + ", ");
                            //    }

                            //    InUvjetIzvod.Append(" ) ");
                            //}

                            //if (IDIzvod.Count() > 0)
                            //{
                            //    IzvodStListaLong = IzvodStSve.Where(x => IDIzvod.Contains(Convert.ToInt64(x.ID_Izvod))).Select(p => p.ID_IzvodSt).ToList();
                            //}


                            //if (IzvodStListaLong.Count() > 0)
                            //{
                            //    InUvjetIzvodSt.Append(" IN ( ");

                            //    foreach(var id in IzvodStListaLong )
                            //    {
                            //        InUvjetIzvodSt.Append(id + ", ");
                            //    }

                            //    InUvjetIzvodSt.Append(" ) ");
                            //}


                            //Upit.Append(" DELETE FROM hub.Izvod2012ASt WHERE ID_IzvodSt " + InUvjetIzvodSt.ToString());
                            //Upit.Append(" DELETE FROM hub.IzvodSt WHERE ID_IzvodSt " + InUvjetIzvodSt.ToString());
                            //Upit.Append(" DELETE FROM hub.Izvod2012A WHERE ID_Izvod " + InUvjetIzvod.ToString());
                            //Upit.Append(" DELETE FROM hub.Izvod WHERE ID_Izvod " + InUvjetIzvod.ToString());

                            //String UpitGotov = Upit.ToString();
                        }

                  
                    }
                 
                    
                }


            }

            return true;
        }



        public InLine.Model.Data.Izvod2012A DaLiPostojiIzvodDatumRacunValutaRedniBroj(String DatumIzvadak, String DatumObrada, String Racun, String IDValuta, int RedniBrojIzvadak, int RedniBrojGrupa)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.Izvod2012A rezult = new InLine.Model.Data.Izvod2012A();

            try
            {
                _serviceIzvod2012A = new Service.Data.Izvod2012A(korisnik_data);
                List<InLine.Model.Data.Field.Izvod2012A> field = new List<InLine.Model.Data.Field.Izvod2012A>();
                List<InLine.Model.Data.Filter.Izvod2012A> filter = new List<InLine.Model.Data.Filter.Izvod2012A>();
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.DatumObrada, Value = DatumObrada, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.DatumIzvadak, Value = DatumIzvadak, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.Racun, Value = Racun, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.IDValuta, Value = IDValuta, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.RedniBrojIzvadak, Value = RedniBrojIzvadak });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.RedniBrojGrupa, Value = RedniBrojGrupa });
                List<InLine.Model.Data.Sort.Izvod2012A> sort = new List<InLine.Model.Data.Sort.Izvod2012A>();
                rezult = _serviceIzvod2012A.GetData(field, filter, sort).FirstOrDefault();
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


        public IEnumerable<InLine.Model.Data.Izvod2012A> DaLiPostojiIzvod(String DatumIzvadak, String DatumObrada, String Racun, int RedniBrojIzvadak)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            IEnumerable<InLine.Model.Data.Izvod2012A> rezult = new List<InLine.Model.Data.Izvod2012A>();

            try
            {
                _serviceIzvod2012A = new Service.Data.Izvod2012A(korisnik_data);
                List<InLine.Model.Data.Field.Izvod2012A> field = new List<InLine.Model.Data.Field.Izvod2012A>();
                List<InLine.Model.Data.Filter.Izvod2012A> filter = new List<InLine.Model.Data.Filter.Izvod2012A>();
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.DatumObrada, Value = DatumObrada, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.DatumIzvadak, Value = DatumIzvadak, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.Racun, Value = Racun, Tip = true });
                filter.Add(new InLine.Model.Data.Filter.Izvod2012A { Field = InLine.Model.Data.Field.Izvod2012A.RedniBrojIzvadak, Value = RedniBrojIzvadak });
 
                List<InLine.Model.Data.Sort.Izvod2012A> sort = new List<InLine.Model.Data.Sort.Izvod2012A>();
                rezult = _serviceIzvod2012A.GetData(field, filter, sort).ToList();
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

    }

}
