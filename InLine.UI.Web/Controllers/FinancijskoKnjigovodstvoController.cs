﻿using System;
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
using InLine.Repository.Data.Helper;
using System.Transactions;
using System.IO;
using InLine.UI.Web.Models;
using Stimulsoft.Report.MvcMobile;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;


namespace InLine.UI.Web.Controllers
{
    public partial class FinancijskoKnjigovodstvoController : InLine.UI.Web.Controllers.View.KontniPlanViewController
    {
        # region Konstruktor

        Service.Data.View.IGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt;

        Service.Data.IGlavnaKnjiga _serviceGlavnaKnjiga;

        Service.Data.View.IKontniPlan _serviceViewKontniPlan;
        Service.Data.View.IKontniPlanDetalj _serviceViewKontniPlanDetalj;
        Service.Data.IKontniPlan _serviceKontniPlan;

        Service.Data.View.IKontniPlanAnalitika _serviceViewKontniPlanAnalitika;
        Service.Data.View.IKontniPlanAnalitikaDetalj _serviceViewKontniPlanAnalitikaDetalj;
        Service.Data.IKontniPlanAnalitika _serviceKontniPlanAnalitika;

        Service.Data.View.IKontniPlanTemeljnicaVr _serviceViewKontniPlanTemeljnicaVr;

        Service.Data.View.IKontniPlanSt _serviceViewKontniPlanSt;
        Service.Data.View.IKontniPlanStDetalj _serviceViewKontniPlanStDetalj;
        Service.Data.IKontniPlanSt _serviceKontniPlanSt;
        Service.Data.IKontniPlanStKriterij _serviceKontniPlanStKriterij;

        Service.Data.View.ITemeljnicaTemeljnicaVrGlavnaKnjiga _serviceViewTemeljnicaTemeljnicaVrGlavnaKnjiga;
        Service.Data.View.ITemeljnicaVr _serviceViewTemeljnicaVr;
        Service.Data.View.ITemeljnicaVrDetalj _serviceViewTemeljnicaVrDetalj;
        Service.Data.ITemeljnicaVr _serviceTemeljnicaVr;

        Service.Data.View.ITemeljnica _serviceViewTemeljnica;
        Service.Data.View.ITemeljnicaDetalj _serviceViewTemeljnicaDetalj;
        Service.Data.ITemeljnica _serviceTemeljnica;

        Service.Data.View.ITemeljnicaSt _serviceViewTemeljnicaSt;
        Service.Data.View.ITemeljnicaStDetalj _serviceViewTemeljnicaStDetalj;
        Service.Data.ITemeljnicaSt _serviceTemeljnicaSt;
        Service.Data.ITemeljnicaStKriterij _serviceTemeljnicaStKriterij;
        Service.Data.View.ITemeljnicaStKriterij _serviceViewTemeljnicaStKriterij;

        Service.Data.View.ITemeljnicaStKontniPlanSt _serviceViewTemeljnicaStKontniPlanSt;

        Service.Data.View.IGlavnaKnjigaKontniPlanKontniPlanSt _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt;

        Service.Data.View.IKriterij _serviceViewKriterij;
        Service.Data.View.IKriterijDetalj _serviceViewKriterijDetalj;
        Service.Data.IKriterij _serviceKriterij;
        Service.Data.IKriterijSt _serviceKriterijSt;
        Service.Data.IKriterijStKriterijSt _serviceKriterijStKriterijSt;
        Service.Data.View.IKriterijStKriterijStKriterijSt _serviceViewKriterijStKriterijStKriterijSt;
        Service.Data.View.IKriterijStKriterijStKriterijStDetalj _serviceViewKriterijStKriterijStKriterijStDetalj;

        Service.Data.IValuta _serviceValuta;
        Service.Data.View.ZapisVrAnalitika _serviceViewZapisVrAnalitika;

        Service.Data.ITemeljnicaVrVr _serviceTemeljnicaVrVr;

        Service.Data.IKontniPlanTemeljnicaVr _serviceKontniPlanTemeljnicaVr;
        Service.Data.IZapisVr _serviceZapisVr;


        # endregion


        #region View

        public ActionResult FinancijskoKnjigovodstvo()
        {
            return View();
        }

        public ActionResult KontniPlan()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.KontniPlanComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.KontniPlanComboFormatted();

            _serviceViewKontniPlan = new Service.Data.View.KontniPlan(korisnik_data);
            List<InLine.Model.Data.Field.View.KontniPlan> field = new List<InLine.Model.Data.Field.View.KontniPlan>();
            List<InLine.Model.Data.Filter.View.KontniPlan> filter = new List<InLine.Model.Data.Filter.View.KontniPlan>();
            List<InLine.Model.Data.Sort.View.KontniPlan> sort = new List<InLine.Model.Data.Sort.View.KontniPlan>();
            filter.Add(new InLine.Model.Data.Filter.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_PoslovnaGodina, Value = korisnik_data.ID_PoslovnaGodina });
            sort.Add(new InLine.Model.Data.Sort.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_KontniPlan, Descending = true });
            var item = _serviceViewKontniPlan.GetData(field, filter, sort).FirstOrDefault();

            if (item != null)
            {
                rezult.ID_KontniPlan = item.ID_KontniPlan;
                rezult.Godina = item.Godina;
                rezult.Naziv = item.Naziv;
            }

            else
            {
                rezult.ID_KontniPlan = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
            }

            return View(rezult);
        }

        public ActionResult Temeljnica()
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
            }

            else
            {
                rezult.ID_GlavnaKnjiga = 0;
                rezult.ID_KontniPlan = 0;
                rezult.ID_Subjekt = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
            }

            return View(rezult);
        }

        public ActionResult Kriterij()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.KontniPlanComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.KontniPlanComboFormatted();

            _serviceViewKontniPlan = new Service.Data.View.KontniPlan(korisnik_data);
            List<InLine.Model.Data.Field.View.KontniPlan> field = new List<InLine.Model.Data.Field.View.KontniPlan>();
            List<InLine.Model.Data.Filter.View.KontniPlan> filter = new List<InLine.Model.Data.Filter.View.KontniPlan>();
            List<InLine.Model.Data.Sort.View.KontniPlan> sort = new List<InLine.Model.Data.Sort.View.KontniPlan>();
            filter.Add(new InLine.Model.Data.Filter.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_PoslovnaGodina, Value = korisnik_data.ID_PoslovnaGodina });
            sort.Add(new InLine.Model.Data.Sort.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_KontniPlan, Descending = true });
            var item = _serviceViewKontniPlan.GetData(field, filter, sort).FirstOrDefault();

            if (item != null)
            {
                rezult.ID_KontniPlan = item.ID_KontniPlan;
                rezult.Godina = item.Godina;
                rezult.Naziv = item.Naziv;
            }

            else
            {
                rezult.ID_KontniPlan = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
            }

            return View(rezult);
        }

        #endregion


        #region KontniPlan

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanGrid(JqGridRequest request, KontniPlanCustomSearch viewModel, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKontniPlan = new Service.Data.View.KontniPlan(korisnik_data);

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

                long totalRecordsCount = _serviceViewKontniPlan.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKontniPlan.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KontniPlanGridFormatted>(Convert.ToString(item.ID_KontniPlan), new KontniPlanGridFormatted(item)));

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

        public ActionResult KontniPlanDetalj(long? Id, long? IdMaster)
        {
            _serviceViewKontniPlanDetalj = new Service.Data.View.KontniPlanDetalj(korisnik_data);

            InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanDetaljFormFormatted rezult;

            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.KontniPlanDetalj> field = new List<InLine.Model.Data.Field.View.KontniPlanDetalj>();
                List<InLine.Model.Data.Filter.View.KontniPlanDetalj> filter = new List<InLine.Model.Data.Filter.View.KontniPlanDetalj>();
                List<InLine.Model.Data.Sort.View.KontniPlanDetalj> sort = new List<InLine.Model.Data.Sort.View.KontniPlanDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KontniPlanDetalj { Field = InLine.Model.Data.Field.View.KontniPlanDetalj.ID_KontniPlan, Value = Convert.ToInt64(Id) });
                var item = _serviceViewKontniPlanDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanDetaljFormFormatted();
                rezult.ID_KontniPlan = -1;
                rezult.ID_PoslovnaGodina = -1;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanInsert(InLine.Model.Data.KontniPlan viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKontniPlan = new Service.Data.KontniPlan(korisnik_data);

                if (viewmodel.ID_KontniPlan == -1)
                {
                    using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                    {

                        Model.Data.Item.KontniPlanItem item = new Model.Data.Item.KontniPlanItem(viewmodel);
                        Model.Data.KontniPlan insert = _serviceKontniPlan.InsertResult(item);

                        if (insert != null)
                        {
                            _serviceGlavnaKnjiga = new Service.Data.GlavnaKnjiga(korisnik_data);
                            Model.Data.Item.GlavnaKnjigaItem itemGlavnaKnjiga = new Model.Data.Item.GlavnaKnjigaItem();
                            itemGlavnaKnjiga.ID_KontniPlan = insert.ID_KontniPlan;
                            Model.Data.GlavnaKnjiga insertGlavnaKnjiga = _serviceGlavnaKnjiga.InsertResult(itemGlavnaKnjiga);
                        }

                        tran.Complete();
                    }

                }
                else
                {
                    Model.Data.KontniPlan model = _serviceKontniPlan.FindID(viewmodel.ID_KontniPlan);

                    if (model != null)
                    {
                        Model.Data.Item.KontniPlanItem item = new Model.Data.Item.KontniPlanItem(viewmodel);
                        Model.Data.KontniPlan update = _serviceKontniPlan.UpdateResult(item);
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

        public ActionResult KontniPlanDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {

                if (viewmodel.ID_KontniPlan != -1)
                {
                    using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                    {
                        _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
                        Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt GlavnaKnjigaKontniPlan = GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGetData(viewmodel.ID_KontniPlan, viewmodel.ID_PoslovnaGodina).FirstOrDefault();

                        if (GlavnaKnjigaKontniPlan != null)
                        {
                            _serviceGlavnaKnjiga = new Service.Data.GlavnaKnjiga(korisnik_data);
                            Model.Data.Item.GlavnaKnjigaItem itemGlavnaKnjiga = new Model.Data.Item.GlavnaKnjigaItem();
                            itemGlavnaKnjiga.ID_GlavnaKnjiga = GlavnaKnjigaKontniPlan.ID_GlavnaKnjiga;
                            int deleteGlavnaKnjiga = _serviceGlavnaKnjiga.DeleteResult(itemGlavnaKnjiga);

                            if (deleteGlavnaKnjiga > 0)
                            {
                                _serviceKontniPlan = new Service.Data.KontniPlan(korisnik_data);
                                Model.Data.Item.KontniPlanItem item = new Model.Data.Item.KontniPlanItem();
                                item.ID_KontniPlan = viewmodel.ID_KontniPlan;
                                int delete = _serviceKontniPlan.DeleteResult(item);
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

        public InLine.Model.Data.View.KontniPlan KontniPlanGetData()
        {
            _serviceViewKontniPlan = new Service.Data.View.KontniPlan(korisnik_data);
            List<InLine.Model.Data.Field.View.KontniPlan> field = new List<InLine.Model.Data.Field.View.KontniPlan>();
            List<InLine.Model.Data.Filter.View.KontniPlan> filter = new List<InLine.Model.Data.Filter.View.KontniPlan>();
            List<InLine.Model.Data.Sort.View.KontniPlan> sort = new List<InLine.Model.Data.Sort.View.KontniPlan>();
            sort.Add(new InLine.Model.Data.Sort.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_KontniPlan, Descending = true });
            filter.Add(new InLine.Model.Data.Filter.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.Godina, Value = DateTime.Now.Year });
            var item = _serviceViewKontniPlan.GetData(field, filter, sort).FirstOrDefault();
            return item;
        }

        public IEnumerable<InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGetData(long IdKontniPlan, long IdPoslovnaGodina)
        {
            _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
            List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
            filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_KontniPlan, Value = IdKontniPlan });
            filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_PoslovnaGodina, Value = IdPoslovnaGodina });
            var item = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort);
            return item;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanAnalitikaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKontniPlanAnalitika = new Service.Data.View.KontniPlanAnalitika(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.KontniPlanAnalitikaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.KontniPlanAnalitikaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewKontniPlanAnalitika.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKontniPlanAnalitika.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KontniPlanAnalitikaGridFormatted>(Convert.ToString(item.ID_KontniPlanAnalitika), new KontniPlanAnalitikaGridFormatted(item)));



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

        public ActionResult KontniPlanAnalitikaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewKontniPlanAnalitikaDetalj = new Service.Data.View.KontniPlanAnalitikaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanAnalitikaDetaljFormFormatted rezult;

            _serviceViewZapisVrAnalitika = new Service.Data.View.ZapisVrAnalitika(korisnik_data);
            List<SelectListItem> IDZapisVrCombo = new List<SelectListItem>();

            List<InLine.Model.Data.Field.View.ZapisVrAnalitika> fieldZapisVrAnalitika = new List<InLine.Model.Data.Field.View.ZapisVrAnalitika>();
            List<InLine.Model.Data.Filter.View.ZapisVrAnalitika> filterZapisVrAnalitika = new List<InLine.Model.Data.Filter.View.ZapisVrAnalitika>();
            List<InLine.Model.Data.Sort.View.ZapisVrAnalitika> sortZapisVrAnalitika = new List<InLine.Model.Data.Sort.View.ZapisVrAnalitika>();

            IDZapisVrCombo = _serviceViewZapisVrAnalitika.GetData(fieldZapisVrAnalitika, filterZapisVrAnalitika, sortZapisVrAnalitika).Select(c => new SelectListItem() { Value = c.IDZapisVr.ToString(), Text = c.Naziv }).ToList();
            IDZapisVrCombo.Insert(0, new SelectListItem() { Text = KeyWord.Forma.Rijec.Odaberite, Value = String.Empty });
            ViewBag.IDZapisVr = new SelectList(IDZapisVrCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.KontniPlanAnalitikaDetalj> field = new List<InLine.Model.Data.Field.View.KontniPlanAnalitikaDetalj>();
                List<InLine.Model.Data.Filter.View.KontniPlanAnalitikaDetalj> filter = new List<InLine.Model.Data.Filter.View.KontniPlanAnalitikaDetalj>();
                List<InLine.Model.Data.Sort.View.KontniPlanAnalitikaDetalj> sort = new List<InLine.Model.Data.Sort.View.KontniPlanAnalitikaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KontniPlanAnalitikaDetalj { Field = InLine.Model.Data.Field.View.KontniPlanAnalitikaDetalj.ID_KontniPlanAnalitika, Value = Convert.ToInt32(Id) });
                var item = _serviceViewKontniPlanAnalitikaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanAnalitikaDetaljFormFormatted(item);

            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanAnalitikaDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_KontniPlan = Convert.ToInt64(IdMaster);

                }
                rezult.ID_KontniPlanAnalitika = -1;

            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanAnalitikaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanAnalitikaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            try
            {
                _serviceKontniPlanAnalitika = new Service.Data.KontniPlanAnalitika(korisnik_data);


                if (viewmodel.ID_KontniPlanAnalitika == -1)
                {
                    Model.Data.Item.KontniPlanAnalitikaItem item = new Model.Data.Item.KontniPlanAnalitikaItem(viewmodel);
                    //item.ID_KontniPlan = viewmodel.ID_KontniPlan;
                    Model.Data.KontniPlanAnalitika insert = _serviceKontniPlanAnalitika.InsertResult(item);
                }
                else
                {
                    Model.Data.KontniPlanAnalitika model = _serviceKontniPlanAnalitika.FindID(viewmodel.ID_KontniPlanAnalitika);

                    if (model != null)
                    {
                        Model.Data.Item.KontniPlanAnalitikaItem item = new Model.Data.Item.KontniPlanAnalitikaItem(viewmodel);
                        Model.Data.KontniPlanAnalitika update = _serviceKontniPlanAnalitika.UpdateResult(item);
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

        public ActionResult KontniPlanAnalitikaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanAnalitikaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKontniPlanAnalitika = new Service.Data.KontniPlanAnalitika(korisnik_data);

                if (viewmodel.ID_KontniPlanAnalitika != -1)
                {
                    Model.Data.Item.KontniPlanAnalitikaItem item = new Model.Data.Item.KontniPlanAnalitikaItem();
                    if (id != null)
                    {
                        item.ID_KontniPlanAnalitika = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_KontniPlanAnalitika = viewmodel.ID_KontniPlanAnalitika;
                    }

                    int delete = _serviceKontniPlanAnalitika.DeleteResult(item);
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
        public ActionResult KontniPlanTemeljnicaVrGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKontniPlanTemeljnicaVr = new Service.Data.View.KontniPlanTemeljnicaVr(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.KontniPlanTemeljnicaVrViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.KontniPlanTemeljnicaVrViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewKontniPlanTemeljnicaVr.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKontniPlanTemeljnicaVr.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KontniPlanTemeljnicaVrGridFormatted>(Convert.ToString(item.ID_KontniPlanTemeljnicaVr), new KontniPlanTemeljnicaVrGridFormatted(item)));



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

        public ActionResult KontniPlanTemeljnicaVrDetalj(long? Id, long? IdMaster)
        {
            PosebnaTemeljnicaVr rezult = new PosebnaTemeljnicaVr();

            if (IdMaster != null)
            {
                _serviceGlavnaKnjiga = new Service.Data.GlavnaKnjiga(korisnik_data);
                List<InLine.Model.Data.Field.GlavnaKnjiga> fieldGlavnaKnjiga = new List<InLine.Model.Data.Field.GlavnaKnjiga>();
                List<InLine.Model.Data.Filter.GlavnaKnjiga> filterGlavnaKnjig = new List<InLine.Model.Data.Filter.GlavnaKnjiga>();
                List<InLine.Model.Data.Sort.GlavnaKnjiga> sortGlavnaKnjig = new List<InLine.Model.Data.Sort.GlavnaKnjiga>();
                filterGlavnaKnjig.Add(new InLine.Model.Data.Filter.GlavnaKnjiga { Field = InLine.Model.Data.Field.GlavnaKnjiga.ID_KontniPlan, Value = Convert.ToInt64(IdMaster) });
                InLine.Model.Data.GlavnaKnjiga GlavnaKnjiga = _serviceGlavnaKnjiga.GetData(fieldGlavnaKnjiga, filterGlavnaKnjig, sortGlavnaKnjig).SingleOrDefault();


                if (GlavnaKnjiga != null)
                {
                    _serviceTemeljnicaVrVr = new Service.Data.TemeljnicaVrVr(korisnik_data);
                    List<InLine.Model.Data.Field.TemeljnicaVrVr> field = new List<InLine.Model.Data.Field.TemeljnicaVrVr>();
                    List<InLine.Model.Data.Filter.TemeljnicaVrVr> filter = new List<InLine.Model.Data.Filter.TemeljnicaVrVr>();
                    List<InLine.Model.Data.Sort.TemeljnicaVrVr> sort = new List<InLine.Model.Data.Sort.TemeljnicaVrVr>();
                    sort.Add(new InLine.Model.Data.Sort.TemeljnicaVrVr { Field = InLine.Model.Data.Field.TemeljnicaVrVr.IDTemeljnicaVrVr, Descending = false });
                    List<InLine.Model.Data.TemeljnicaVrVr> VrsteVrstaTemeljnica = _serviceTemeljnicaVrVr.GetData(field, filter, sort).ToList();

                    _serviceTemeljnicaVr = new Service.Data.TemeljnicaVr(korisnik_data);
                    List<InLine.Model.Data.Field.TemeljnicaVr> fieldTemeljnicaVr = new List<InLine.Model.Data.Field.TemeljnicaVr>();
                    List<InLine.Model.Data.Filter.TemeljnicaVr> filterTemeljnicaVr = new List<InLine.Model.Data.Filter.TemeljnicaVr>();
                    filterTemeljnicaVr.Add(new InLine.Model.Data.Filter.TemeljnicaVr { Field = InLine.Model.Data.Field.TemeljnicaVr.ID_GlavnaKnjiga, Value = Convert.ToInt64(GlavnaKnjiga.ID_GlavnaKnjiga) });
                    List<InLine.Model.Data.Sort.TemeljnicaVr> sortTemeljnicaVr = new List<InLine.Model.Data.Sort.TemeljnicaVr>();
                    List<InLine.Model.Data.TemeljnicaVr> SveVrstaTemeljnica = _serviceTemeljnicaVr.GetData(fieldTemeljnicaVr, filterTemeljnicaVr, sortTemeljnicaVr).ToList();

                    rezult.ListaTemeljnicaVrVr = VrsteVrstaTemeljnica;
                    rezult.ListaSveTemeljnica = SveVrstaTemeljnica;
                    rezult.ID_GlavnaKnjiga = GlavnaKnjiga.ID_GlavnaKnjiga;
                    rezult.ID_KontniPlan = Convert.ToInt64(IdMaster);

                    _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);
                    List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr> fieldKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr>();
                    List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr> filterKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr>();
                    filterKontniPlanTemeljnicaVr.Add(new InLine.Model.Data.Filter.KontniPlanTemeljnicaVr { Field = InLine.Model.Data.Field.KontniPlanTemeljnicaVr.ID_KontniPlan, Value = Convert.ToInt64(IdMaster) });
                    List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr> sortKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr>();
                    List<InLine.Model.Data.KontniPlanTemeljnicaVr> PosebneVrstaTemeljnica = _serviceKontniPlanTemeljnicaVr.GetData(fieldKontniPlanTemeljnicaVr, filterKontniPlanTemeljnicaVr, sortKontniPlanTemeljnicaVr).ToList();


                    if (PosebneVrstaTemeljnica != null)
                    {
                        List<SelectedProperties> PosebneVrsta = new List<SelectedProperties>();

                        foreach (var it in SveVrstaTemeljnica)
                        {
                            SelectedProperties cbp = new SelectedProperties();
                            cbp.Vrsta = it.ID_TemeljnicaVr;
                            cbp.VrstaNaziv = it.Oznaka + " " + it.Naziv.Trim();
                            cbp.IsSelected = false;

                            if (PosebneVrstaTemeljnica != null)
                            {
                                foreach (var item in PosebneVrstaTemeljnica)
                                {
                                    if (item.ID_TemeljnicaVr == it.ID_TemeljnicaVr)
                                    {
                                        cbp.IsSelected = true;
                                        cbp.VrstaVrsta = item.IDTemeljnicaVrVr;
                                    }
                                }
                            }

                            PosebneVrsta.Add(cbp);

                        }

                        rezult.SelectedProperties = PosebneVrsta;
                    }

                }


            }
            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanTemeljnicaVrInsert(PosebnaTemeljnicaVr viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            IDictionary<int, long> KontniPlanTemeljnicaVrListUnos = null;


            if (viewmodel.SelectedProperties == null)
            {
                try
                {
                    if (!String.IsNullOrEmpty(viewmodel.KontniPlanTemeljnicaVrList))
                    {
                        KontniPlanTemeljnicaVrListUnos = SplitStringKontniPlanTemeljnicaVr(viewmodel.KontniPlanTemeljnicaVrList);
                    }

                    _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);

                    foreach (var kks in KontniPlanTemeljnicaVrListUnos)
                    {
                        Model.Data.Item.KontniPlanTemeljnicaVrItem item = new Model.Data.Item.KontniPlanTemeljnicaVrItem();
                        item.IDTemeljnicaVrVr = kks.Key;
                        item.ID_TemeljnicaVr = kks.Value;
                        item.ID_KontniPlan = viewmodel.ID_KontniPlan;
                        Model.Data.KontniPlanTemeljnicaVr temeljnicaStKriterijItemiInsert = _serviceKontniPlanTemeljnicaVr.InsertResult(item);

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

            else
            {
                TempData["KontniPlanTemeljnicaVrEdit"] = viewmodel;
                return RedirectToAction("KontniPlanTemeljnicaVrEdit");
            }

        }

        public ActionResult KontniPlanTemeljnicaVrEdit()
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            IDictionary<int, long> KontniPlanTemeljnicaVrListUnos = null;

            IDictionary<int, long> KontniPlanTemeljnicaVrListZaUnos = null;
            IDictionary<int, long> PostojeciKontniPlanTemeljnicaVr = new Dictionary<int, long>();
            IDictionary<int, long> KontniPlantemeljnicaVrZaBrisanje = new Dictionary<int, long>();
            IDictionary<int, long> KontniPlanTemeljnicaVrZaDodavanje = new Dictionary<int, long>();
            List<long> IdKontniPlanTemeljnicaVr = new List<long>();
            List<long> IdKontniPlantemeljnicaVrBrisanje = new List<long>();


            PosebnaTemeljnicaVr viewmodel = TempData["KontniPlanTemeljnicaVrEdit"] as PosebnaTemeljnicaVr;

            try
            {
                _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);
                List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr> fieldKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr>();
                List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr> filterKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr>();
                filterKontniPlanTemeljnicaVr.Add(new InLine.Model.Data.Filter.KontniPlanTemeljnicaVr { Field = InLine.Model.Data.Field.KontniPlanTemeljnicaVr.ID_KontniPlan, Value = Convert.ToInt64(viewmodel.ID_KontniPlan) });
                List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr> sortKontniPlanTemeljnicaVr = new List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr>();
                List<InLine.Model.Data.KontniPlanTemeljnicaVr> Postojeci = _serviceKontniPlanTemeljnicaVr.GetData(fieldKontniPlanTemeljnicaVr, filterKontniPlanTemeljnicaVr, sortKontniPlanTemeljnicaVr).ToList();

                if (Postojeci != null)
                {
                    foreach (var itemposojeci in Postojeci)
                    {
                        PostojeciKontniPlanTemeljnicaVr.Add(itemposojeci.IDTemeljnicaVrVr, itemposojeci.ID_TemeljnicaVr);
                        IdKontniPlanTemeljnicaVr.Add(itemposojeci.ID_KontniPlanTemeljnicaVr);
                    }
                }

                if (!String.IsNullOrEmpty(viewmodel.KontniPlanTemeljnicaVrList))
                {
                    KontniPlanTemeljnicaVrListZaUnos = SplitStringKontniPlanTemeljnicaVr(viewmodel.KontniPlanTemeljnicaVrList);

                    KontniPlanTemeljnicaVrZaDodavanje = KontniPlanTemeljnicaVrListZaUnos.ToDictionary(x => x.Key, x => x.Value);
                    KontniPlantemeljnicaVrZaBrisanje = PostojeciKontniPlanTemeljnicaVr.ToDictionary(x => x.Key, x => x.Value);
                }

                if (Postojeci != null && KontniPlantemeljnicaVrZaBrisanje != null)
                {
                    foreach (var itempostojeci in Postojeci)
                    {
                        var IdZaBrisanje = itempostojeci.ID_KontniPlanTemeljnicaVr;
                        IdKontniPlantemeljnicaVrBrisanje.Add(IdZaBrisanje);
                    }
                }


                if (KontniPlanTemeljnicaVrZaDodavanje != null || KontniPlantemeljnicaVrZaBrisanje != null)
                {
                    if (KontniPlantemeljnicaVrZaBrisanje.Count > 0)
                    {
                        _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);

                        foreach (long id in IdKontniPlantemeljnicaVrBrisanje)
                        {
                            Model.Data.Item.KontniPlanTemeljnicaVrItem kontniPlantemeljnicaVrItem = new Model.Data.Item.KontniPlanTemeljnicaVrItem();
                            kontniPlantemeljnicaVrItem.ID_KontniPlanTemeljnicaVr = id;
                            int delete = _serviceKontniPlanTemeljnicaVr.DeleteResult(kontniPlantemeljnicaVrItem);
                        }
                    }

                    if (KontniPlanTemeljnicaVrZaDodavanje.Count > 0)
                    {
                        _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);


                        foreach (var element in KontniPlanTemeljnicaVrZaDodavanje)
                        {
                            Model.Data.Item.KontniPlanTemeljnicaVrItem kontniPlantemeljnicaVrItem = new Model.Data.Item.KontniPlanTemeljnicaVrItem();
                            kontniPlantemeljnicaVrItem.ID_TemeljnicaVr = element.Value;
                            kontniPlantemeljnicaVrItem.IDTemeljnicaVrVr = element.Key;
                            kontniPlantemeljnicaVrItem.ID_KontniPlan = viewmodel.ID_KontniPlan;
                            Model.Data.KontniPlanTemeljnicaVr kontniPlanTemeljnicaVrItemiInsert = _serviceKontniPlanTemeljnicaVr.InsertResult(kontniPlantemeljnicaVrItem);

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

        public ActionResult KontniPlanTemeljnicaVrDelete(PosebnaTemeljnicaVr viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKontniPlanTemeljnicaVr = new Service.Data.KontniPlanTemeljnicaVr(korisnik_data);
                List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr> field = new List<InLine.Model.Data.Field.KontniPlanTemeljnicaVr>();
                List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr> filter = new List<InLine.Model.Data.Filter.KontniPlanTemeljnicaVr>();
                List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr> sort = new List<InLine.Model.Data.Sort.KontniPlanTemeljnicaVr>();

                if (id != null)
                {
                    filter.Add(new InLine.Model.Data.Filter.KontniPlanTemeljnicaVr { Field = InLine.Model.Data.Field.KontniPlanTemeljnicaVr.ID_KontniPlanTemeljnicaVr, Value = Convert.ToInt64(id) });
                }
                else
                {

                    filter.Add(new InLine.Model.Data.Filter.KontniPlanTemeljnicaVr { Field = InLine.Model.Data.Field.KontniPlanTemeljnicaVr.ID_KontniPlan, Value = Convert.ToInt64(viewmodel.ID_KontniPlan) });
                }


                var Postojeci = _serviceKontniPlanTemeljnicaVr.GetData(field, filter, sort).Select(p => p.ID_KontniPlanTemeljnicaVr).ToList();

                if (Postojeci.Count() > 0)
                {

                    foreach (long idPostojeci in Postojeci)
                    {
                        Model.Data.Item.KontniPlanTemeljnicaVrItem kontniPlanTemeljnicaVrItem = new Model.Data.Item.KontniPlanTemeljnicaVrItem();
                        kontniPlanTemeljnicaVrItem.ID_KontniPlanTemeljnicaVr = idPostojeci;
                        int delete = _serviceKontniPlanTemeljnicaVr.DeleteResult(kontniPlanTemeljnicaVrItem);
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

        public IDictionary<int, long> SplitStringKontniPlanTemeljnicaVr(string temeljnicaVrstaVrsta)
        {
            Dictionary<int, long> rezult = new Dictionary<int, long>();
            string[] stringseparator = new string[] { CommonFunctions.KeyWord.Zarez };
            string[] stringlista;

            stringlista = temeljnicaVrstaVrsta.Split(stringseparator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in stringlista)
            {
                int prvi = 0;
                long drugi = 0;
                string[] polja;
                string[] sep = new string[] { CommonFunctions.KeyWord.DvoTocka };
                polja = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                prvi = Convert.ToInt32(polja.ElementAt(0).ToString().Trim());
                drugi = Convert.ToInt64(polja.ElementAt(1).ToString().Trim());
                rezult.Add(prvi, drugi);
            }
            return rezult;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanStGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKontniPlanSt = new Service.Data.View.KontniPlanSt(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    InLine.Model.Data.View.KontniPlan item = KontniPlanGetData();

                    if (item != null)
                    {
                        value = item.ID_KontniPlan.ToString();
                    }

                }

                if (String.IsNullOrEmpty(key))
                {
                    key = InLine.Model.Data.FieldString.View.KontniPlan.ID_KontniPlan;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.KontniPlanStViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.KontniPlanStViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewKontniPlanSt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKontniPlanSt.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KontniPlanStGridFormatted>(Convert.ToString(item.ID_KontniPlanSt), new KontniPlanStGridFormatted(item)));



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

        public ActionResult KontniPlanStDetalj(long? Id, long? IdMaster)
        {
            _serviceViewKontniPlanStDetalj = new Service.Data.View.KontniPlanStDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted rezult;
            int AnalitikaOd = 0;

            if (IdMaster != null)
            {
                _serviceKontniPlan = new Service.Data.KontniPlan(korisnik_data);
                Model.Data.KontniPlan kp = _serviceKontniPlan.FindID(Convert.ToInt64(IdMaster));

                if (kp != null)
                {
                    AnalitikaOd = kp.AnalitikaOd;
                }
            }

            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.KontniPlanStDetalj> field = new List<InLine.Model.Data.Field.View.KontniPlanStDetalj>();
                List<InLine.Model.Data.Filter.View.KontniPlanStDetalj> filter = new List<InLine.Model.Data.Filter.View.KontniPlanStDetalj>();
                List<InLine.Model.Data.Sort.View.KontniPlanStDetalj> sort = new List<InLine.Model.Data.Sort.View.KontniPlanStDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KontniPlanStDetalj { Field = InLine.Model.Data.Field.View.KontniPlanStDetalj.ID_KontniPlanSt, Value = Convert.ToInt32(Id) });
                var item = _serviceViewKontniPlanStDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted(item);
                rezult.AnalitikaOd = AnalitikaOd;

                //Duguje
                if (rezult.DugujeDopusteno == true && rezult.DugujeObavezno == true)
                {
                    rezult.UnosDuguje = 1;
                }

                else if (rezult.DugujeDopusteno == true && rezult.DugujeObavezno == false)
                {
                    rezult.UnosDuguje = 2;
                }

                else if (rezult.DugujeDopusteno == false && rezult.DugujeObavezno == false)
                {
                    rezult.UnosDuguje = 3;
                }


                //Potrazuje
                if (rezult.PotrazujeDopusteno == true && rezult.PotrazujeObavezno == true)
                {
                    rezult.UnosPotrazuje = 1;
                }

                else if (rezult.PotrazujeDopusteno == true && rezult.PotrazujeObavezno == false)
                {
                    rezult.UnosPotrazuje = 2;
                }

                else if (rezult.PotrazujeDopusteno == false && rezult.PotrazujeObavezno == false)
                {
                    rezult.UnosPotrazuje = 3;
                }

                //Subjekt
                if (rezult.SubjektDopusteno == true && rezult.SubjektObavezno == true)
                {
                    rezult.UnosSubjekt = 1;
                }

                else if (rezult.SubjektDopusteno == true && rezult.SubjektObavezno == false)
                {
                    rezult.UnosSubjekt = 2;
                }

                else if (rezult.SubjektDopusteno == false && rezult.SubjektObavezno == false)
                {
                    rezult.UnosSubjekt = 3;
                }

                //Zapis
                if (rezult.ZapisDopusteno == true && rezult.ZapisObavezno == true)
                {
                    rezult.UnosZapis = 1;
                }

                else if (rezult.ZapisDopusteno == true && rezult.ZapisObavezno == false)
                {
                    rezult.UnosZapis = 2;
                }

                else if (rezult.ZapisDopusteno == false && rezult.ZapisObavezno == false)
                {
                    rezult.UnosZapis = 3;
                }


                rezult.TemeljnicaStImaOvajKonto = TemeljnicaStImaOvajKonto(Convert.ToInt64(Id));

            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_KontniPlan = Convert.ToInt64(IdMaster);
                    rezult.AnalitikaOd = AnalitikaOd;
                }
                rezult.ID_KontniPlanSt = -1;
                rezult.UnosDuguje = 2;
                rezult.UnosPotrazuje = 2;
                rezult.UnosSubjekt = 2;
                rezult.UnosZapis = 2;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KontniPlanStInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            IDictionary<long, long> KriterijKriterijStListZaUnos = null;
            List<long> KriterijObaveznoZaUnos = null;
            bool viseInsert = false;

            if (viewmodel.ID_KontniPlanSt == -1)
            {
                KriterijObaveznoZaUnos = SplitStringKriterijObavezno(viewmodel.KriterijObaveznoList);

                try
                {
                    _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);

                    Model.Data.Item.KontniPlanStItem item = new Model.Data.Item.KontniPlanStItem(viewmodel);
                    item.ID_KontniPlan = viewmodel.ID_KontniPlan;
                    Model.Data.KontniPlanSt insert = null;

                    switch (viewmodel.UnosDuguje)
                    {
                        case 1:
                            item.DugujeDopusteno = true;
                            item.DugujeObavezno = true;
                            break;
                        case 2:
                            item.DugujeDopusteno = true;
                            item.DugujeObavezno = false;
                            break;
                        case 3:
                            item.DugujeDopusteno = false;
                            item.DugujeObavezno = false;
                            break;
                    }

                    switch (viewmodel.UnosPotrazuje)
                    {
                        case 1:
                            item.PotrazujeDopusteno = true;
                            item.PotrazujeObavezno = true;
                            break;
                        case 2:
                            item.PotrazujeDopusteno = true;
                            item.PotrazujeObavezno = false;
                            break;
                        case 3:
                            item.PotrazujeDopusteno = false;
                            item.PotrazujeObavezno = false;
                            break;

                    }

                    switch (viewmodel.UnosSubjekt)
                    {
                        case 1:
                            item.SubjektDopusteno = true;
                            item.SubjektObavezno = true;
                            break;
                        case 2:
                            item.SubjektDopusteno = true;
                            item.SubjektObavezno = false;
                            break;
                        case 3:
                            item.SubjektDopusteno = false;
                            item.SubjektObavezno = false;
                            break;
                    }

                    switch (viewmodel.UnosZapis)
                    {
                        case 1:
                            item.ZapisDopusteno = true;
                            item.ZapisObavezno = true;
                            break;
                        case 2:
                            item.ZapisDopusteno = true;
                            item.ZapisObavezno = false;
                            break;
                        case 3:
                            item.ZapisDopusteno = false;
                            item.ZapisObavezno = false;
                            break;
                    }


                    if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                    {
                        KriterijKriterijStListZaUnos = SplitStringKriterijKriterijSt(viewmodel.KriterijKriterijStList);
                        viseInsert = true;
                    }


                    if (viseInsert)
                    {
                        using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                        {
                            insert = _serviceKontniPlanSt.InsertResult(item);

                            if (insert != null)
                            {
                                long kontniplanStInserted = insert.ID_KontniPlanSt;
                                if (kontniplanStInserted > -1)
                                {
                                    _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);

                                    foreach (var kks in KriterijKriterijStListZaUnos)
                                    {
                                        Model.Data.Item.KontniPlanStKriterijItem kontniplanStKriterijItem = new Model.Data.Item.KontniPlanStKriterijItem();
                                        kontniplanStKriterijItem.ID_Kriterij = kks.Value;
                                        kontniplanStKriterijItem.ID_KriterijSt = kks.Key;
                                        kontniplanStKriterijItem.ID_KontniPlanSt = kontniplanStInserted;

                                        if (KriterijObaveznoZaUnos.Count > 0)
                                        {
                                            if (KriterijObaveznoZaUnos.Contains(kks.Value))
                                            {
                                                kontniplanStKriterijItem.Obavezno = true;
                                            }
                                            else
                                            {
                                                kontniplanStKriterijItem.Obavezno = false;
                                            }
                                        }

                                        else
                                        {
                                            kontniplanStKriterijItem.Obavezno = false;
                                        }

                                        Model.Data.KontniPlanStKriterij temeljnicaStKriterijItemiInsert = _serviceKontniPlanStKriterij.InsertResult(kontniplanStKriterijItem);

                                    }
                                }

                            }

                            tran.Complete();
                        }

                    }
                    else
                    {
                        insert = _serviceKontniPlanSt.InsertResult(item);
                    }

                    poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                    InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
                    return Json(poruke, JsonRequestBehavior.AllowGet);
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

            else
            {

                //return RedirectToAction("KontniPlanStEdit", viewmodel);
                //InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted modelRedirect = viewmodel;
                TempData["KontniPlanStEdit"] = viewmodel;
                return RedirectToAction("KontniPlanStEdit");
            }

        }

        public ActionResult KontniPlanStEdit()
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            IDictionary<long, long> KriterijKriterijStListZaUnos = null;
            IDictionary<long, long> PostojeciKriterijIzBaze = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaBrisanje = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaDodavanje = new Dictionary<long, long>();
            List<long> IdKontniPlanStKriterijSt = new List<long>();
            List<long> IdKontniPlanStKriterijStZaBrisanje = new List<long>();
            List<long> KriterijObaveznoZaUnos = null;
            bool viseInsert = false;

            InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted viewmodel = TempData["KontniPlanStEdit"] as InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted;

            if (viewmodel.ID_KontniPlanSt > -1)
            {
                try
                {
                    KriterijObaveznoZaUnos = SplitStringKriterijObavezno(viewmodel.KriterijObaveznoList);

                    _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);
                    var Postojeci = _serviceKontniPlanStKriterij.SelectResult(null).Where(p => p.ID_KontniPlanSt == Convert.ToInt64(viewmodel.ID_KontniPlanSt)).ToList();


                    if (String.IsNullOrEmpty(viewmodel.KriterijKriterijStList) && String.IsNullOrEmpty(viewmodel.KriterijObaveznoList))
                    {
                        viseInsert = false;
                    }

                    else if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                    {
                        KriterijKriterijStListZaUnos = SplitStringKriterijKriterijSt(viewmodel.KriterijKriterijStList);
                        viseInsert = true;
                    }


                    if (Postojeci != null)
                    {
                        foreach (var itemposojeci in Postojeci)
                        {
                            PostojeciKriterijIzBaze.Add(itemposojeci.ID_KriterijSt, itemposojeci.ID_Kriterij);
                            IdKontniPlanStKriterijSt.Add(itemposojeci.ID_KontniPlanStKriterij);
                        }
                    }

                    if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                    {
                        KriterijZaDodavanje = KriterijKriterijStListZaUnos.ToDictionary(x => x.Key, x => x.Value);
                        KriterijZaBrisanje = PostojeciKriterijIzBaze.ToDictionary(x => x.Key, x => x.Value);
                    }


                    if (Postojeci != null && KriterijZaBrisanje != null)
                    {
                        foreach (var itempostojeci in Postojeci)
                        {
                            var IdZaBrisanje = itempostojeci.ID_KontniPlanStKriterij;
                            IdKontniPlanStKriterijStZaBrisanje.Add(IdZaBrisanje);
                        }
                    }

                    _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
                    Model.Data.KontniPlanSt model = _serviceKontniPlanSt.FindID(viewmodel.ID_KontniPlanSt);

                    if (model != null)
                    {

                        Model.Data.Item.KontniPlanStItem itemzaupdate = new Model.Data.Item.KontniPlanStItem(viewmodel);

                        switch (viewmodel.UnosDuguje)
                        {
                            case 1:
                                itemzaupdate.DugujeDopusteno = true;
                                itemzaupdate.DugujeObavezno = true;
                                break;
                            case 2:
                                itemzaupdate.DugujeDopusteno = true;
                                itemzaupdate.DugujeObavezno = false;
                                break;
                            case 3:
                                itemzaupdate.DugujeDopusteno = false;
                                itemzaupdate.DugujeObavezno = false;
                                break;
                        }

                        switch (viewmodel.UnosPotrazuje)
                        {
                            case 1:
                                itemzaupdate.PotrazujeDopusteno = true;
                                itemzaupdate.PotrazujeObavezno = true;
                                break;
                            case 2:
                                itemzaupdate.PotrazujeDopusteno = true;
                                itemzaupdate.PotrazujeObavezno = false;
                                break;
                            case 3:
                                itemzaupdate.PotrazujeDopusteno = false;
                                itemzaupdate.PotrazujeObavezno = false;
                                break;

                        }

                        switch (viewmodel.UnosSubjekt)
                        {
                            case 1:
                                itemzaupdate.SubjektDopusteno = true;
                                itemzaupdate.SubjektObavezno = true;
                                break;
                            case 2:
                                itemzaupdate.SubjektDopusteno = true;
                                itemzaupdate.SubjektObavezno = false;
                                break;
                            case 3:
                                itemzaupdate.SubjektDopusteno = false;
                                itemzaupdate.SubjektObavezno = false;
                                break;
                        }

                        switch (viewmodel.UnosZapis)
                        {
                            case 1:
                                itemzaupdate.ZapisDopusteno = true;
                                itemzaupdate.ZapisObavezno = true;
                                break;
                            case 2:
                                itemzaupdate.ZapisDopusteno = true;
                                itemzaupdate.ZapisObavezno = false;
                                break;
                            case 3:
                                itemzaupdate.ZapisDopusteno = false;
                                itemzaupdate.ZapisObavezno = false;
                                break;
                        }


                        if (viseInsert)
                        {
                            using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                            {

                                Model.Data.KontniPlanSt update = _serviceKontniPlanSt.UpdateResult(itemzaupdate);

                                if (KriterijZaDodavanje != null || KriterijZaBrisanje != null)
                                {
                                    if (KriterijZaBrisanje.Count > 0)
                                    {
                                        _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);

                                        foreach (long id in IdKontniPlanStKriterijStZaBrisanje)
                                        {
                                            Model.Data.Item.KontniPlanStKriterijItem kontniPlanStStKriterijItem = new Model.Data.Item.KontniPlanStKriterijItem();
                                            kontniPlanStStKriterijItem.ID_KontniPlanStKriterij = id;
                                            int delete = _serviceKontniPlanStKriterij.DeleteResult(kontniPlanStStKriterijItem);
                                        }
                                    }

                                    if (KriterijZaDodavanje.Count > 0)
                                    {
                                        _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);


                                        foreach (var element in KriterijZaDodavanje)
                                        {
                                            Model.Data.Item.KontniPlanStKriterijItem kontniPlanStKriterijItem = new Model.Data.Item.KontniPlanStKriterijItem();
                                            kontniPlanStKriterijItem.ID_Kriterij = element.Value;
                                            kontniPlanStKriterijItem.ID_KriterijSt = element.Key;
                                            kontniPlanStKriterijItem.ID_KontniPlanSt = update.ID_KontniPlanSt;

                                            if (KriterijObaveznoZaUnos.Count > 0)
                                            {
                                                if (KriterijObaveznoZaUnos.Contains(element.Value))
                                                {
                                                    kontniPlanStKriterijItem.Obavezno = true;
                                                }
                                                else
                                                {
                                                    kontniPlanStKriterijItem.Obavezno = false;
                                                }
                                            }

                                            else
                                            {
                                                kontniPlanStKriterijItem.Obavezno = false;
                                            }
                                            Model.Data.KontniPlanStKriterij kontniPlanStKriterijItemiInsert = _serviceKontniPlanStKriterij.InsertResult(kontniPlanStKriterijItem);

                                        }
                                    }
                                }

                                tran.Complete();
                            }
                        }

                        else
                        {
                            _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);

                            Model.Data.KontniPlanSt update = _serviceKontniPlanSt.UpdateResult(itemzaupdate);

                            int b = IdKontniPlanStKriterijSt.Count();

                            if ((viewmodel.KriterijObaveznoList != null) && IdKontniPlanStKriterijSt.Count() > 0)
                            {
                                _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);

                                foreach (long id in IdKontniPlanStKriterijSt)
                                {
                                    Model.Data.Item.KontniPlanStKriterijItem kontniPlanStKriterijItem = new Model.Data.Item.KontniPlanStKriterijItem();
                                    kontniPlanStKriterijItem.ID_KontniPlanStKriterij = id;
                                    int delete = _serviceKontniPlanStKriterij.DeleteResult(kontniPlanStKriterijItem);
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

            //else
            //{
            //    return RedirectToAction("KontniPlanStEdit", viewmodel);
            //}

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);
        }

        public ActionResult KontniPlanStDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KontniPlanStDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);
                List<InLine.Model.Data.Field.KontniPlanStKriterij> field = new List<InLine.Model.Data.Field.KontniPlanStKriterij>();
                List<InLine.Model.Data.Filter.KontniPlanStKriterij> filter = new List<InLine.Model.Data.Filter.KontniPlanStKriterij>();
                List<InLine.Model.Data.Sort.KontniPlanStKriterij> sort = new List<InLine.Model.Data.Sort.KontniPlanStKriterij>();

                if (id != null)
                {
                    filter.Add(new InLine.Model.Data.Filter.KontniPlanStKriterij { Field = InLine.Model.Data.Field.KontniPlanStKriterij.ID_KontniPlanSt, Value = Convert.ToInt64(id) });
                }
                else
                {

                    filter.Add(new InLine.Model.Data.Filter.KontniPlanStKriterij { Field = InLine.Model.Data.Field.KontniPlanStKriterij.ID_KontniPlanSt, Value = Convert.ToInt64(viewmodel.ID_KontniPlanSt) });
                }


                var Postojeci = _serviceKontniPlanStKriterij.GetData(field, filter, sort).Select(p => p.ID_KontniPlanStKriterij).ToList();

                if (Postojeci.Count() > 0)
                {
                    using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                    {
                        foreach (long idPostojeci in Postojeci)
                        {
                            Model.Data.Item.KontniPlanStKriterijItem kontniPlanStKriterijItem = new Model.Data.Item.KontniPlanStKriterijItem();
                            kontniPlanStKriterijItem.ID_KontniPlanStKriterij = idPostojeci;
                            int delete = _serviceKontniPlanStKriterij.DeleteResult(kontniPlanStKriterijItem);
                        }

                        _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
                        Model.Data.Item.KontniPlanStItem item = new Model.Data.Item.KontniPlanStItem();
                        if (id != null)
                        {
                            item.ID_KontniPlanSt = Convert.ToInt64(id);
                        }
                        else
                        {
                            item.ID_KontniPlanSt = viewmodel.ID_KontniPlanSt;
                        }

                        int deleteKontniPlanSt = _serviceKontniPlanSt.DeleteResult(item);

                        tran.Complete();
                    }
                }

                else
                {
                    if (viewmodel.ID_KontniPlanSt != -1)
                    {
                        _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
                        Model.Data.Item.KontniPlanStItem item = new Model.Data.Item.KontniPlanStItem();
                        if (id != null)
                        {
                            item.ID_KontniPlanSt = Convert.ToInt64(id);
                        }

                        else
                        {
                            item.ID_KontniPlanSt = viewmodel.ID_KontniPlanSt;
                        }


                        int delete = _serviceKontniPlanSt.DeleteResult(item);
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

        public ActionResult KontniPlanStOpis(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            string rezult = string.Empty;
            StringBuilder sb = new StringBuilder();
            String UnosObavezan = "OBAVEZAN UNOS: ";

            try
            {
                _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
                var item = _serviceKontniPlanSt.FindID(id);


                if (item != null)
                {

                    if (item.SaldoKonti == true)
                    {
                        sb.Append("poslovni partner, dokument, ");
                    }

                    if (item.SubjektObavezno == true && item.SaldoKonti == false)
                    {
                        sb.Append("poslovni partner, ");
                    }

                    if (item.ZapisObavezno == true && item.SaldoKonti == false)
                    {
                        sb.Append("dokument, ");
                    }

                    if (item.DugujeObavezno == true)
                    {
                        sb.Append("dugovna strana, ");
                    }

                    if (item.PotrazujeObavezno == true)
                    {
                        sb.Append("potražna strana, ");
                    }


                    if (sb.ToString() != "")
                    {
                        rezult = UnosObavezan + sb.Remove(sb.ToString().Length - 2, 2);
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

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetKontniPlan(string query, int kriterij)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            List<InLine.Model.Data.View.KontniPlan> rezult = new List<InLine.Model.Data.View.KontniPlan>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceViewKontniPlan = new Service.Data.View.KontniPlan(korisnik_data);
                List<InLine.Model.Data.Field.View.KontniPlan> field = new List<InLine.Model.Data.Field.View.KontniPlan>();
                List<InLine.Model.Data.Filter.View.KontniPlan> filter = new List<InLine.Model.Data.Filter.View.KontniPlan>();
                List<InLine.Model.Data.Sort.View.KontniPlan> sort = new List<InLine.Model.Data.Sort.View.KontniPlan>();
                sort.Add(new InLine.Model.Data.Sort.View.KontniPlan { Field = InLine.Model.Data.Field.View.KontniPlan.ID_KontniPlan, Descending = true });


                switch (kriterij)
                {
                    case 1:
                        rezult = _serviceViewKontniPlan.GetData(field, filter, sort).Where(p => p.Godina.ToString().Trim().StartsWith(query.ToUpper())).ToList();
                        break;
                    case 2:
                        rezult = _serviceViewKontniPlan.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
                        break;
                    case 3:
                        rezult = _serviceViewKontniPlan.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Godina.ToString().StartsWith(query.ToUpper())).ToList();
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

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

        ////public ActionResult GetKonto(string query, int kriterij, int analitikaod, long kontniplan)
        ////{
        ////    List<Model.Admin.StatusPoruka> poruke = null;
        ////    List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt> rezult = new List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt>();

        ////    query = query.Replace(" ", "");

        ////    if (query.Length > 1)
        ////    {
        ////        int op = query.LastIndexOf(",");
        ////        query = query.Substring(op + 1);
        ////    }

        ////    try
        ////    {
        ////        _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt = new Service.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt(korisnik_data);
        ////        List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt>();
        ////        List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt>();
        ////        filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt.ID_KontniPlan, Value = kontniplan });
        ////        List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanKontniPlanSt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanKontniPlanSt>();

        ////        switch (kriterij)
        ////        {
        ////            case 1:
        ////                rezult = _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt.GetData(field, filter, sort).Where(p => p.Konto.ToString().Trim().Length >= analitikaod && p.Konto.ToString().Trim().StartsWith(query.ToUpper())).ToList();
        ////                break;
        ////            case 2:
        ////                rezult = _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt.GetData(field, filter, sort).Where(p => p.Konto.ToString().Trim().Length >= analitikaod && p.Naziv.ToUpper().StartsWith(query.ToUpper())).ToList();
        ////                break;

        ////        }

        ////    }

        ////    catch (Exception ex)
        ////    {
        ////        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        ////        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        ////        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        ////        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

        ////    }

        ////    return Json(rezult, JsonRequestBehavior.AllowGet);

        ////}

        public ActionResult GetKonto(string query, int kriterij, int analitikaod, long kontniplan, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt> rezult = new List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt = new Service.Data.View.GlavnaKnjigaKontniPlanKontniPlanSt(korisnik_data);
                List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt>();
                List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt>();
                filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanKontniPlanSt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt.ID_KontniPlan, Value = kontniplan });
                List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanKontniPlanSt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanKontniPlanSt>();
                sort.Add(new InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanKontniPlanSt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanKontniPlanSt.Konto, Descending = false });

                switch (kriterij)
                {
                    case 1:
                        rezult = _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt.GetData(field, filter, sort).Where(p => p.Konto.ToString().Trim().Length >= analitikaod && p.Konto.ToString().Trim().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
                        break;
                    case 2:
                        rezult = _serviceViewGlavnaKnjigaKontniPlanKontniPlanSt.GetData(field, filter, sort).Where(p => p.Konto.ToString().Trim().Length >= analitikaod && p.Naziv.ToUpper().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
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

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }


        public int TemeljnicaStImaOvajKonto(long id)
        {
            int rezultat = 0;

            _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);
            List<InLine.Model.Data.Field.TemeljnicaSt> field = new List<InLine.Model.Data.Field.TemeljnicaSt>();
            List<InLine.Model.Data.Filter.TemeljnicaSt> filter = new List<InLine.Model.Data.Filter.TemeljnicaSt>();
            List<InLine.Model.Data.Sort.TemeljnicaSt> sort = new List<InLine.Model.Data.Sort.TemeljnicaSt>();
            filter.Add(new InLine.Model.Data.Filter.TemeljnicaSt { Field = InLine.Model.Data.Field.TemeljnicaSt.ID_KontniPlanSt, Value = id });
            var item = _serviceTemeljnicaSt.GetData(field, filter, sort);

            if (item != null)
            {
                rezultat = item.Count();
            }


            return rezultat;
        }


        #endregion


        #region Kriterij

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KriterijGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewKriterij = new Service.Data.View.Kriterij(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {


                }

                if (String.IsNullOrEmpty(key))
                {

                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.KriterijViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.KriterijViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewKriterij.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewKriterij.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<KriterijGridFormatted>(Convert.ToString(item.ID_Kriterij), new KriterijGridFormatted(item)));



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

        public ActionResult KriterijDetalj(long? Id, long? IdMaster)
        {
            _serviceViewKriterijDetalj = new Service.Data.View.KriterijDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijDetaljFormFormatted rezult;
            int kriterijCount = 0;


            if (IdMaster != null)
            {
                List<InLine.Model.Data.Field.View.KriterijDetalj> field = new List<InLine.Model.Data.Field.View.KriterijDetalj>();
                List<InLine.Model.Data.Filter.View.KriterijDetalj> filter = new List<InLine.Model.Data.Filter.View.KriterijDetalj>();
                List<InLine.Model.Data.Sort.View.KriterijDetalj> sort = new List<InLine.Model.Data.Sort.View.KriterijDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KriterijDetalj { Field = InLine.Model.Data.Field.View.KriterijDetalj.ID_KontniPlan, Value = Convert.ToInt64(IdMaster) });
                var itemCount = _serviceViewKriterijDetalj.GetData(field, filter, sort).ToList();

                if (itemCount != null)
                {
                    kriterijCount = itemCount.Count();
                }

            }


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.KriterijDetalj> field = new List<InLine.Model.Data.Field.View.KriterijDetalj>();
                List<InLine.Model.Data.Filter.View.KriterijDetalj> filter = new List<InLine.Model.Data.Filter.View.KriterijDetalj>();
                List<InLine.Model.Data.Sort.View.KriterijDetalj> sort = new List<InLine.Model.Data.Sort.View.KriterijDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KriterijDetalj { Field = InLine.Model.Data.Field.View.KriterijDetalj.ID_Kriterij, Value = Convert.ToInt64(Id) });
                var item = _serviceViewKriterijDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijDetaljFormFormatted(item);
                rezult.KriterijCount = kriterijCount;
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_KontniPlan = Convert.ToInt64(IdMaster);
                }
                rezult.ID_Kriterij = -1;
                rezult.KriterijCount = kriterijCount;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KriterijInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            int kriterijCount = 0;

            try
            {
                _serviceKriterij = new Service.Data.Kriterij(korisnik_data);



                if (viewmodel.ID_KontniPlan != 0 && viewmodel.ID_Kriterij == -1)
                {
                    _serviceViewKriterijDetalj = new Service.Data.View.KriterijDetalj(korisnik_data);

                    List<InLine.Model.Data.Field.View.KriterijDetalj> field = new List<InLine.Model.Data.Field.View.KriterijDetalj>();
                    List<InLine.Model.Data.Filter.View.KriterijDetalj> filter = new List<InLine.Model.Data.Filter.View.KriterijDetalj>();
                    List<InLine.Model.Data.Sort.View.KriterijDetalj> sort = new List<InLine.Model.Data.Sort.View.KriterijDetalj>();
                    filter.Add(new InLine.Model.Data.Filter.View.KriterijDetalj { Field = InLine.Model.Data.Field.View.KriterijDetalj.ID_KontniPlan, Value = Convert.ToInt64(viewmodel.ID_KontniPlan) });
                    var itemCount = _serviceViewKriterijDetalj.GetData(field, filter, sort).ToList();

                    if (itemCount != null)
                    {
                        kriterijCount = itemCount.Count();
                    }

                }

                if (kriterijCount < 6)
                {
                    if (viewmodel.ID_Kriterij == -1)
                    {
                        Model.Data.Item.KriterijItem item = new Model.Data.Item.KriterijItem(viewmodel);
                        item.ID_KontniPlan = viewmodel.ID_KontniPlan;
                        Model.Data.Kriterij insert = _serviceKriterij.InsertResult(item);
                    }
                    else
                    {
                        Model.Data.Kriterij model = _serviceKriterij.FindID(viewmodel.ID_Kriterij);

                        if (model != null)
                        {
                            Model.Data.Item.KriterijItem item = new Model.Data.Item.KriterijItem(viewmodel);
                            Model.Data.Kriterij update = _serviceKriterij.UpdateResult(item);
                        }
                    }
                }

                else
                {
                    Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();
                    poruka.PorukaTekst = StatusPorukaTekst.Poruka.KriterijMax6;
                    poruka.StatusTekst = StatusPorukaTekst.Status.Jedan;
                    InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);

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

        public ActionResult KriterijDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKriterij = new Service.Data.Kriterij(korisnik_data);

                if (viewmodel.ID_Kriterij != -1)
                {
                    Model.Data.Item.KriterijItem item = new Model.Data.Item.KriterijItem();
                    if (id != null)
                    {
                        item.ID_Kriterij = Convert.ToInt64(id);
                    }

                    else
                    {
                        item.ID_Kriterij = viewmodel.ID_Kriterij;
                    }

                    int delete = _serviceKriterij.DeleteResult(item);
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
        public ActionResult KriterijStKriterijStKriterijStGrid(int? nodeid, string value)
        {

            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);

            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> children;

            if (nodeid.HasValue)
            {
                children = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == nodeid && p.ID_Kriterij == Convert.ToInt64(value) && p.ID_KriterijSt != p.ID_KriterijStNad).ToList();
            }
            else
            {
                children = KriterijStKriterijStKriterijStGetData().Where(p => p.Nivo == 0 && p.ID_Kriterij == Convert.ToInt64(value)).ToList();
            }


            if (children != null)
            {
                JqGridResponse response = new JqGridResponse();
                response.Records.AddRange(from child in children
                                          select new JqGridAdjacencyTreeRecord<KriterijStKriterijStKriterijStGridFormatted>(Convert.ToString(child.ID_KriterijSt), new KriterijStKriterijStKriterijStGridFormatted(child), Convert.ToInt32(child.Nivo), Convert.ToInt32(child.Nivo) == 0 ? null : Convert.ToString(child.ID_KriterijStNad)) { Leaf = (KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == child.ID_KriterijSt).ToList().Count() < 2 && child.Nivo == 0 ? true : false) || (KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == child.ID_KriterijSt).ToList().Count() < 1 && child.Nivo != 0 ? true : false) });

                return new JqGridJsonResult() { Data = response };
            }
            else
                return new EmptyResult();
        }

        public ActionResult KriterijStKriterijStKriterijStDetalj(long? Id, long? IdMaster, long? IdNad)
        {
            _serviceViewKriterijStKriterijStKriterijStDetalj = new Service.Data.View.KriterijStKriterijStKriterijStDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijStKriterijStKriterijStDetaljFormFormatted rezult;

            _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);
            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);


            if (Id.HasValue)
            {
                List<InLine.Model.Data.Field.View.KriterijStKriterijStKriterijStDetalj> field = new List<InLine.Model.Data.Field.View.KriterijStKriterijStKriterijStDetalj>();
                List<InLine.Model.Data.Filter.View.KriterijStKriterijStKriterijStDetalj> filter = new List<InLine.Model.Data.Filter.View.KriterijStKriterijStKriterijStDetalj>();
                List<InLine.Model.Data.Sort.View.KriterijStKriterijStKriterijStDetalj> sort = new List<InLine.Model.Data.Sort.View.KriterijStKriterijStKriterijStDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.KriterijStKriterijStKriterijStDetalj { Field = InLine.Model.Data.Field.View.KriterijStKriterijStKriterijStDetalj.ID_KriterijSt, Value = Convert.ToInt64(Id) });
                var item = _serviceViewKriterijStKriterijStKriterijStDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijStKriterijStKriterijStDetaljFormFormatted(item);

                if (IdNad.HasValue)
                {
                    var NadId = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijSt == Id).Select(p => p.ID_KriterijStNad).FirstOrDefault();
                    var NadStavka = _serviceKriterijSt.SelectResult(null).Where(p => p.ID_KriterijSt == NadId).Select(p => p.Naziv).FirstOrDefault();

                    if (NadId != IdNad)
                    {
                        ViewBag.NadStavka = NadStavka;
                    }
                    else
                    {
                        ViewBag.NadStavka = KeyWord.PorukeKontroler.NemaNadredjenaStavka;
                    }

                }
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijStKriterijStKriterijStDetaljFormFormatted();
                if (IdMaster.HasValue)
                {
                    rezult.ID_Kriterij = Convert.ToInt64(IdMaster);
                }
                if (IdNad.HasValue)
                {
                    rezult.ID_KriterijStNad = Convert.ToInt64(IdNad);
                    var NadStavka = _serviceKriterijSt.SelectResult(null).Where(p => p.ID_KriterijSt == IdNad).Select(p => p.Naziv).FirstOrDefault();
                    ViewBag.NadStavka = NadStavka;
                }

                else
                {
                    rezult.ID_KriterijStNad = -1;
                    ViewBag.NadStavka = KeyWord.PorukeKontroler.NemaNadredjenaStavka;
                }

                rezult.ID_KriterijSt = -1;

            }

            return PartialView(rezult);
        }

        public IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> KriterijStKriterijStKriterijStGetData()
        {
            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);
            List<InLine.Model.Data.Field.View.KriterijStKriterijStKriterijSt> field = new List<InLine.Model.Data.Field.View.KriterijStKriterijStKriterijSt>();
            List<InLine.Model.Data.Filter.View.KriterijStKriterijStKriterijSt> filter = new List<InLine.Model.Data.Filter.View.KriterijStKriterijStKriterijSt>();
            List<InLine.Model.Data.Sort.View.KriterijStKriterijStKriterijSt> sort = new List<InLine.Model.Data.Sort.View.KriterijStKriterijStKriterijSt>();
            sort.Add(new InLine.Model.Data.Sort.View.KriterijStKriterijStKriterijSt { Field = InLine.Model.Data.Field.View.KriterijStKriterijStKriterijSt.RedniBroj, Descending = true });
            var item = _serviceViewKriterijStKriterijStKriterijSt.GetData(field, filter, sort);
            return item;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult KriterijStKriterijStKriterijStInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijStKriterijStKriterijStDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);


                if (viewmodel.ID_KriterijSt == -1)
                {
                    Model.Data.Item.KriterijStItem item = new Model.Data.Item.KriterijStItem();
                    item.ID_Kriterij = viewmodel.ID_Kriterij;
                    item.Oznaka = viewmodel.Oznaka;
                    item.Naziv = viewmodel.Naziv;
                    item.NazivKr = viewmodel.NazivKr;
                    item.Kratica = viewmodel.Kratica;

                    Model.Data.KriterijSt insert = _serviceKriterijSt.InsertResult(item);

                    if (insert != null)
                    {
                        _serviceKriterijStKriterijSt = new Service.Data.KriterijStKriterijSt(korisnik_data);

                        Model.Data.Item.KriterijStKriterijStItem item2 = new Model.Data.Item.KriterijStKriterijStItem();
                        item2.ID_Kriterij = insert.ID_Kriterij;
                        item2.ID_KriterijSt = insert.ID_KriterijSt;
                        if (viewmodel.ID_KriterijStNad > -1)
                        {
                            item2.ID_KriterijStNad = viewmodel.ID_KriterijStNad;
                        }
                        else
                        {
                            item2.ID_KriterijStNad = insert.ID_KriterijSt;
                        }

                        Model.Data.KriterijStKriterijSt insert2 = _serviceKriterijStKriterijSt.InsertResult(item2);
                    }

                    else
                    {

                        //if (viewmodel.ID_Kriterij != -1)
                        //{
                        //    Model.Data.Item.KriterijStItem itemdelete = new Model.Data.Item.KriterijStItem();
                        //    itemdelete.ID_KriterijSt = insert.ID_KriterijSt;
                        //    int delete = _serviceKriterijSt.DeleteResult(item);
                        //}
                    }
                }
                else
                {
                    Model.Data.KriterijSt model = _serviceKriterijSt.FindID(viewmodel.ID_KriterijSt);

                    if (model != null)
                    {
                        Model.Data.Item.KriterijStItem item = new Model.Data.Item.KriterijStItem(viewmodel);
                        Model.Data.KriterijSt update = _serviceKriterijSt.UpdateResult(item);
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

        public ActionResult KriterijStKriterijStKriterijStDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.KriterijStKriterijStKriterijStDetaljFormFormatted viewmodel, long? id, long? idTablicaPutNivo)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceKriterijStKriterijSt = new Service.Data.KriterijStKriterijSt(korisnik_data);

                if (viewmodel.ID_KriterijSt == 0)
                {

                    if (id != null && idTablicaPutNivo != null)
                    {
                        Model.Data.Item.KriterijStKriterijStItem item = new Model.Data.Item.KriterijStKriterijStItem();
                        item.ID_KriterijStKriterijSt = Convert.ToInt64(idTablicaPutNivo);
                        int delete = _serviceKriterijStKriterijSt.DeleteResult(item);

                        if (delete > 0)
                        {
                            _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);
                            Model.Data.Item.KriterijStItem item2 = new Model.Data.Item.KriterijStItem();
                            item2.ID_KriterijSt = Convert.ToInt64(id);
                            int delete2 = _serviceKriterijSt.DeleteResult(item2);
                        }
                    }

                }

                else
                {
                    if (viewmodel.ID_KriterijStKriterijSt != null)
                    {
                        if (viewmodel.ID_KriterijStKriterijSt != -1)
                        {
                            Model.Data.Item.KriterijStKriterijStItem item = new Model.Data.Item.KriterijStKriterijStItem();
                            item.ID_KriterijStKriterijSt = viewmodel.ID_KriterijStKriterijSt;
                            int delete = _serviceKriterijStKriterijSt.DeleteResult(item);

                            if (delete > 0)
                            {
                                _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);
                                Model.Data.Item.KriterijStItem item2 = new Model.Data.Item.KriterijStItem();
                                item2.ID_KriterijSt = viewmodel.ID_KriterijSt;
                                int delete2 = _serviceKriterijSt.DeleteResult(item2);
                            }
                        }
                    }

                    else
                    {
                        _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);
                        Model.Data.Item.KriterijStItem item = new Model.Data.Item.KriterijStItem();
                        item.ID_KriterijSt = viewmodel.ID_KriterijSt;
                        int delete = _serviceKriterijSt.DeleteResult(item);
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


        #endregion


        #region Temeljnica

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGrid(JqGridRequest request, GlavnaKnjigaCustomSearch viewModel, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
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

                long totalRecordsCount = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGridFormatted>(Convert.ToString(item.ID_GlavnaKnjiga), new GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektGridFormatted(item)));


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

        //public ActionResult GetGlavnaKnjiga(string query, int kriterij)
        //{
        //    List<Model.Admin.StatusPoruka> poruke = null;
        //    List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> rezult = new List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();

        //    query = query.Replace(" ", "");

        //    if (query.Length > 1)
        //    {
        //        int op = query.LastIndexOf(",");
        //        query = query.Substring(op + 1);
        //    }

        //    try
        //    {
        //        _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
        //        List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
        //        List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
        //        List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();


        //        switch (kriterij)
        //        {
        //            case 1:
        //                rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Godina.ToString().Trim().StartsWith(query.ToUpper())).ToList();
        //                break;
        //            case 2:
        //                rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
        //                break;
        //            case 3:
        //                rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Godina.ToString().StartsWith(query.ToUpper())).ToList();
        //                break;

        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        //        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        //        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);

        //    }

        //    return Json(rezult, JsonRequestBehavior.AllowGet);

        //}

        public ActionResult GetGlavnaKnjiga(string query, int kriterij, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> rezult = new List<InLine.Model.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
                List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
                List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
                List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();


                switch (kriterij)
                {
                    case 1:
                        rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Godina.ToString().Trim().StartsWith(query.ToUpper())).ToList();
                        break;
                    case 2:
                        rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
                        break;
                    case 3:
                        rezult = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Godina.ToString().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
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

            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TemeljnicaVrGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewTemeljnicaVr = new Service.Data.View.TemeljnicaVr(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.TemeljnicaVrViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.TemeljnicaVrViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewTemeljnicaVr.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewTemeljnicaVr.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<TemeljnicaVrGridFormatted>(Convert.ToString(item.ID_TemeljnicaVr), new TemeljnicaVrGridFormatted(item)));



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


        public ActionResult TemeljnicaVrDetalj(long? Id, long? IdMaster)
        {
            _serviceViewTemeljnicaVrDetalj = new Service.Data.View.TemeljnicaVrDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaVrDetaljFormFormatted rezult;

            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.TemeljnicaVrDetalj> field = new List<InLine.Model.Data.Field.View.TemeljnicaVrDetalj>();
                List<InLine.Model.Data.Filter.View.TemeljnicaVrDetalj> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaVrDetalj>();
                List<InLine.Model.Data.Sort.View.TemeljnicaVrDetalj> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaVrDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaVrDetalj { Field = InLine.Model.Data.Field.View.TemeljnicaVrDetalj.ID_TemeljnicaVr, Value = Convert.ToInt64(Id) });
                var item = _serviceViewTemeljnicaVrDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaVrDetaljFormFormatted(item);
                rezult.Oznaka = rezult.Oznaka.TrimStart('0');
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaVrDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_GlavnaKnjiga = Convert.ToInt64(IdMaster);

                    _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt(korisnik_data);
                    List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> field = new List<InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
                    List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
                    List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt>();
                    filter.Add(new InLine.Model.Data.Filter.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt { Field = InLine.Model.Data.Field.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.ID_GlavnaKnjiga, Value = Convert.ToInt64(IdMaster) });
                    var item = _serviceViewGlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjekt.GetData(field, filter, sort).FirstOrDefault();

                    if (item != null)
                    {
                        rezult.IDValuta = item.IDValuta;
                    }

                }
                rezult.ID_TemeljnicaVr = -1;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TemeljnicaVrInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaVrDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            try
            {
                _serviceTemeljnicaVr = new Service.Data.TemeljnicaVr(korisnik_data);


                if (viewmodel.ID_TemeljnicaVr == -1)
                {
                    Model.Data.Item.TemeljnicaVrItem item = new Model.Data.Item.TemeljnicaVrItem(viewmodel);
                    item.ID_GlavnaKnjiga = viewmodel.ID_GlavnaKnjiga;
                    item.Oznaka = viewmodel.Oznaka.TrimStart('0');
                    Model.Data.TemeljnicaVr insert = _serviceTemeljnicaVr.InsertResult(item);
                }
                else
                {
                    Model.Data.TemeljnicaVr model = _serviceTemeljnicaVr.FindID(viewmodel.ID_TemeljnicaVr);

                    if (model != null)
                    {
                        Model.Data.Item.TemeljnicaVrItem item = new Model.Data.Item.TemeljnicaVrItem(viewmodel);
                        Model.Data.TemeljnicaVr update = _serviceTemeljnicaVr.UpdateResult(item);
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

        public ActionResult TemeljnicaVrDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaVrDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceTemeljnicaVr = new Service.Data.TemeljnicaVr(korisnik_data);

                if (viewmodel.ID_TemeljnicaVr != -1)
                {
                    Model.Data.Item.TemeljnicaVrItem item = new Model.Data.Item.TemeljnicaVrItem();
                    if (id != null)
                    {
                        item.ID_TemeljnicaVr = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_TemeljnicaVr = viewmodel.ID_TemeljnicaVr;
                    }

                    int delete = _serviceTemeljnicaVr.DeleteResult(item);
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
        public ActionResult TemeljnicaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewTemeljnica = new Service.Data.View.Temeljnica(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.TemeljnicaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.TemeljnicaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewTemeljnica.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewTemeljnica.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<TemeljnicaGridFormatted>(Convert.ToString(item.ID_Temeljnica), new TemeljnicaGridFormatted(item)));



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

        public ActionResult TemeljnicaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewTemeljnicaDetalj = new Service.Data.View.TemeljnicaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaDetaljFormFormatted rezult;


            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);



            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.TemeljnicaDetalj> field = new List<InLine.Model.Data.Field.View.TemeljnicaDetalj>();
                List<InLine.Model.Data.Filter.View.TemeljnicaDetalj> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaDetalj>();
                List<InLine.Model.Data.Sort.View.TemeljnicaDetalj> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaDetalj { Field = InLine.Model.Data.Field.View.TemeljnicaDetalj.ID_Temeljnica, Value = Convert.ToInt64(Id) });
                var item = _serviceViewTemeljnicaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaDetaljFormFormatted(item);
                //rezult.Oznaka = rezult.Oznaka.TrimStart('0');
                rezult.Oznaka = rezult.Oznaka;
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_TemeljnicaVr = Convert.ToInt64(IdMaster);
                    rezult.Knjizeno = false;

                    _serviceViewTemeljnicaVrDetalj = new Service.Data.View.TemeljnicaVrDetalj(korisnik_data);
                    List<InLine.Model.Data.Field.View.TemeljnicaVrDetalj> field = new List<InLine.Model.Data.Field.View.TemeljnicaVrDetalj>();
                    List<InLine.Model.Data.Filter.View.TemeljnicaVrDetalj> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaVrDetalj>();
                    List<InLine.Model.Data.Sort.View.TemeljnicaVrDetalj> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaVrDetalj>();
                    filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaVrDetalj { Field = InLine.Model.Data.Field.View.TemeljnicaVrDetalj.ID_TemeljnicaVr, Value = Convert.ToInt64(IdMaster) });
                    var item = _serviceViewTemeljnicaVrDetalj.GetData(field, filter, sort).FirstOrDefault();


                    if (item != null)
                    {
                        rezult.IDValuta = item.IDValuta;
                    }
                }
                rezult.ID_Temeljnica = -1;
                rezult.NazivKr = String.Empty;
                rezult.Kratica = String.Empty;
                rezult.Datum = DateTime.Now.Date;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TemeljnicaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceTemeljnica = new Service.Data.Temeljnica(korisnik_data);


                if (viewmodel.ID_Temeljnica == -1)
                {
                    Model.Data.Item.TemeljnicaItem item = new Model.Data.Item.TemeljnicaItem(viewmodel);
                    item.ID_TemeljnicaVr = viewmodel.ID_TemeljnicaVr;
                    //item.Oznaka = viewmodel.Oznaka.TrimStart('0');
                    item.Oznaka = viewmodel.Oznaka;
                    Model.Data.Temeljnica insert = _serviceTemeljnica.InsertResult(item);
                }
                else
                {
                    Model.Data.Temeljnica model = _serviceTemeljnica.FindID(viewmodel.ID_Temeljnica);

                    if (model != null)
                    {
                        Model.Data.Item.TemeljnicaItem item = new Model.Data.Item.TemeljnicaItem(viewmodel);
                        Model.Data.Temeljnica update = _serviceTemeljnica.UpdateResult(item);
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

        public ActionResult TemeljnicaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTemeljnica = new Service.Data.Temeljnica(korisnik_data);

                if (viewmodel.ID_Temeljnica != -1)
                {
                    Model.Data.Item.TemeljnicaItem item = new Model.Data.Item.TemeljnicaItem();
                    if (id != null)
                    {
                        item.ID_Temeljnica = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_Temeljnica = viewmodel.ID_Temeljnica;
                    }

                    int delete = _serviceTemeljnica.DeleteResult(item);
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

        public ActionResult Knjizi(long Id, int Knjizeno, string DatumKnjizenje)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTemeljnica = new Service.Data.Temeljnica(korisnik_data);
                _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);


                if (Knjizeno == 1)
                {
                    var item = _serviceTemeljnica.FindID(Id);

                    if (item != null)
                    {
                        Model.Data.Item.TemeljnicaItem itemUpdate = new Model.Data.Item.TemeljnicaItem(item);
                        itemUpdate.Knjizeno = false;
                        itemUpdate.DatumKnjizenje = null;
                        Model.Data.Temeljnica updated = _serviceTemeljnica.UpdateResult(itemUpdate);
                    }
                }

                else
                {
                    List<InLine.Model.Data.Field.TemeljnicaSt> field = new List<InLine.Model.Data.Field.TemeljnicaSt>();
                    List<InLine.Model.Data.Filter.TemeljnicaSt> filter = new List<InLine.Model.Data.Filter.TemeljnicaSt>();
                    List<InLine.Model.Data.Sort.TemeljnicaSt> sort = new List<InLine.Model.Data.Sort.TemeljnicaSt>();
                    filter.Add(new InLine.Model.Data.Filter.TemeljnicaSt { Field = InLine.Model.Data.Field.TemeljnicaSt.ID_Temeljnica, Value = Convert.ToInt64(Id) });

                    int brojTemeljnicaSt = _serviceTemeljnicaSt.GetData(field, filter, sort).Count();
                    bool saldoStavkiNul = _serviceTemeljnica.IsSaldoStavkiNula(Id);

                    if (brojTemeljnicaSt > 0 && saldoStavkiNul)
                    {
                        var item = _serviceTemeljnica.FindID(Id);

                        if (item != null)
                        {
                            Model.Data.Item.TemeljnicaItem itemUpdate = new Model.Data.Item.TemeljnicaItem(item);
                            itemUpdate.Knjizeno = true;

                            if (!String.IsNullOrEmpty(DatumKnjizenje))
                            {
                                string[] dijeloviDatuma = DatumKnjizenje.Split('/');
                                DateTime datumKnjizenjeNovi = new DateTime(Convert.ToInt32(dijeloviDatuma[2]), Convert.ToInt32(dijeloviDatuma[1]), Convert.ToInt32(dijeloviDatuma[0]));
                                itemUpdate.DatumKnjizenje = datumKnjizenjeNovi;
                            }
                            else
                            {
                                itemUpdate.DatumKnjizenje = DateTime.Now;
                            }
                       
                            Model.Data.Temeljnica updated = _serviceTemeljnica.UpdateResult(itemUpdate);
                        }
                    }

                    else
                    {
                        Model.Admin.StatusPoruka poruka = new StatusPoruka();
                        poruka.PorukaTekst = StatusPorukaTekst.Poruka.NijeKnizeno;
                        poruka.StatusTekst = StatusPorukaTekst.Status.Jedan;
                        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
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


            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }



        public ActionResult GetTemeljica(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.Temeljnica rezult = new InLine.Model.Data.Temeljnica();

            try
            {
                _serviceTemeljnica = new Service.Data.Temeljnica(korisnik_data);
                rezult = _serviceTemeljnica.FindID(id);
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




        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TemeljnicaStGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewTemeljnicaSt = new Service.Data.View.TemeljnicaSt(korisnik_data);
                string filterExpression = String.Empty;

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.TemeljnicaStViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.TemeljnicaStViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewTemeljnicaSt.GetCount(filterExpression, key, value, customsearch);

                var IznosDuguje = _serviceViewTemeljnicaSt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosDuguje);
                var IznosPotrazuje = _serviceViewTemeljnicaSt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosPotrazuje);
                var IznosDugujeValuta = _serviceViewTemeljnicaSt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosDugujeValuta);
                var IznosPotrazujeValuta = _serviceViewTemeljnicaSt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), null, null, customsearch).Sum(p => p.IznosPotrazujeValuta);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount,

                    UserData = new
                    {
                        IznosDuguje = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDuguje),
                        IznosPotrazuje = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosPotrazuje),
                        IznosDugujeValuta = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosDugujeValuta),
                        IznosPotrazujeValuta = String.Format(KeyWord.FormaterRazno.DecimalFormat.TockaZarez, IznosPotrazujeValuta)
                    }

                };
                response.Records.AddRange(from item in _serviceViewTemeljnicaSt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<TemeljnicaStGridFormatted>(Convert.ToString(item.ID_TemeljnicaSt), new TemeljnicaStGridFormatted(item)));



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

        public ActionResult TemeljnicaStDetalj(long? Id, long? IdMaster)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            _serviceViewTemeljnicaStDetalj = new Service.Data.View.TemeljnicaStDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted rezult;
            long idKontniPlan = 0;
            int analitikaOd = 0;
            //InLine.Model.Data.View.PoslovniSubjektSubjekt PoslovniPartner = new InLine.Model.Data.View.PoslovniSubjektSubjekt();
            InLine.Model.Data.View.Subjekt Subjekt = new InLine.Model.Data.View.Subjekt();
            InLine.Model.Data.View.Zapis Zapis = new InLine.Model.Data.View.Zapis();
            string SubjektNaziv = String.Empty;
            string SubjektOznaka = String.Empty;
            string ZapisNaziv = String.Empty;


            try
            {

                _serviceValuta = new Service.Data.Valuta(korisnik_data);
                List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
                IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
                ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);



                if (IdMaster.HasValue)
                {
                    _serviceViewTemeljnicaTemeljnicaVrGlavnaKnjiga = new Service.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga(korisnik_data);
                    idKontniPlan = this.TemeljnicaTemeljnicaVrGlavnaKnjigaGetData().Where(p => p.ID_Temeljnica == IdMaster).Select(p => p.ID_KontniPlan).FirstOrDefault();

                    if (idKontniPlan != 0)
                    {
                        _serviceKontniPlan = new Service.Data.KontniPlan(korisnik_data);
                        Model.Data.KontniPlan kp = _serviceKontniPlan.FindID(Convert.ToInt64(idKontniPlan));

                        if (kp != null)
                        {
                            analitikaOd = kp.AnalitikaOd;
                        }
                    }
                }


                if (Id != null)
                {
                    List<InLine.Model.Data.Field.View.TemeljnicaStDetalj> field = new List<InLine.Model.Data.Field.View.TemeljnicaStDetalj>();
                    List<InLine.Model.Data.Filter.View.TemeljnicaStDetalj> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaStDetalj>();
                    List<InLine.Model.Data.Sort.View.TemeljnicaStDetalj> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaStDetalj>();
                    filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaStDetalj { Field = InLine.Model.Data.Field.View.TemeljnicaStDetalj.ID_TemeljnicaSt, Value = Convert.ToInt64(Id) });
                    var item = _serviceViewTemeljnicaStDetalj.GetData(field, filter, sort).FirstOrDefault();
                    rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted(item);
                    rezult.SubjektDopusteno = 0;
                    rezult.ZapisDopusteno = 0;
                    rezult.ID_KontniPlan = idKontniPlan;
                    rezult.AnalitikaOd = analitikaOd;

                    if (item != null)
                    {
                        _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
                        var stavkaKontniPlan = _serviceKontniPlanSt.FindID(item.ID_KontniPlanSt);
                        rezult.Konto = stavkaKontniPlan.Konto;
                        rezult.Naziv = stavkaKontniPlan.Naziv;

                        if (stavkaKontniPlan.SubjektDopusteno == true)
                        {
                            rezult.SubjektDopusteno = 1;
                        }

                        if (stavkaKontniPlan.ZapisDopusteno == true)
                        {
                            rezult.ZapisDopusteno = 1;
                        }

                        if (rezult.ID_Subjekt != null)
                        {
                            //InLine.UI.Web.Controllers.MaticniPodaciController parentController = new InLine.UI.Web.Controllers.MaticniPodaciController(korisnik_data);
                            InLine.UI.Web.Controllers.SubjektSviController parentController = new InLine.UI.Web.Controllers.SubjektSviController(korisnik_data);
                            Subjekt = parentController.GetSubjekt(Convert.ToInt64(rezult.ID_Subjekt));
                            rezult.SubjektNaziv = Subjekt.Naziv;
                            rezult.SubjektOznaka = Subjekt.Oznaka;
                            rezult.ID_Subjekt = Subjekt.ID_Subjekt;
                        }

                        if (rezult.ID_Zapis == null && item.ID_KontniPlanAnalitika != null)
                        {
                            _serviceKontniPlanAnalitika = new Service.Data.KontniPlanAnalitika(korisnik_data);
                            var itemKontniPlanAnalitika = _serviceKontniPlanAnalitika.FindID(Convert.ToInt64(item.ID_KontniPlanAnalitika));
                            rezult.IDZapisVr = itemKontniPlanAnalitika.IDZapisVr;
                            rezult.IDKontniPlanAnalitikaIDZapisVr = item.ID_KontniPlanAnalitika + ":" + itemKontniPlanAnalitika.IDZapisVr;
                        }

                        if (rezult.ID_Zapis != null)
                        {
                            InLine.UI.Web.Controllers.ZapisSviController parentController = new InLine.UI.Web.Controllers.ZapisSviController(korisnik_data);
                            Zapis = parentController.GetZapis(Convert.ToInt64(rezult.ID_Zapis));

                            rezult.ID_Zapis = Zapis.ID_Zapis;
                            rezult.IDZapisVr = Zapis.IDZapisVr;
                            rezult.IDKontniPlanAnalitikaIDZapisVr = item.ID_KontniPlanAnalitika + ":" + Zapis.IDZapisVr;

                            switch (rezult.IDZapisVr)
                            {
                                case 1002:
                                    InLine.Model.Data.View.ZapisRacunUlaz ZapisRacunUlaz = new InLine.Model.Data.View.ZapisRacunUlaz();
                                    parentController = new InLine.UI.Web.Controllers.ZapisSviController(korisnik_data);
                                    ZapisRacunUlaz = parentController.GetZapisUlazniRacun(Convert.ToInt64(rezult.ID_Zapis));
                                    rezult.DocumentNaziv = "ID_POSLOVNISUBJEKT: " + ZapisRacunUlaz.ID_PoslovniSubjekt + " ID_SUBJEKT " + ZapisRacunUlaz.ID_SubjektRacunUlaz;
                                    break;

                                case 10001:
                                    InLine.Model.Data.View.ZapisUgovorStanOtkup ZapisUgovorStanOtkup = new InLine.Model.Data.View.ZapisUgovorStanOtkup();
                                    parentController = new InLine.UI.Web.Controllers.ZapisSviController(korisnik_data);
                                    ZapisUgovorStanOtkup = parentController.GetZapisUgovorStanOtkup(Convert.ToInt64(rezult.ID_Zapis), rezult.ID_Subjekt);
                                    rezult.DocumentNaziv = "BR. UGOVORA:" + ZapisUgovorStanOtkup.BrojUgovor + " BR. DOKUMENTA: " + ZapisUgovorStanOtkup.Broj;
                                    break;

                                case 10002:
                                    InLine.Model.Data.View.ZapisUgovorStanOtkupAneks ZapisUgovorStanOtkupAneks = new InLine.Model.Data.View.ZapisUgovorStanOtkupAneks();
                                    parentController = new InLine.UI.Web.Controllers.ZapisSviController(korisnik_data);
                                    ZapisUgovorStanOtkupAneks = parentController.GetZapisUgovorStanOtkupAneks(Convert.ToInt64(rezult.ID_Zapis), rezult.ID_Subjekt);
                                    rezult.DocumentNaziv = "BR. UGOVORA:" + ZapisUgovorStanOtkupAneks.BrojUgovor + " - BR. ANEKSA: " + ZapisUgovorStanOtkupAneks.BrojAneks + " - BR.DOKUMENTA: " + ZapisUgovorStanOtkupAneks.Broj;
                                    break;

                            }


                        }

                    }
                }

                else
                {
                    rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted();
                    if (IdMaster != null)
                    {
                        rezult.ID_Temeljnica = Convert.ToInt64(IdMaster);

                        _serviceViewTemeljnicaDetalj = new Service.Data.View.TemeljnicaDetalj(korisnik_data);
                        List<InLine.Model.Data.Field.View.TemeljnicaDetalj> field = new List<InLine.Model.Data.Field.View.TemeljnicaDetalj>();
                        List<InLine.Model.Data.Filter.View.TemeljnicaDetalj> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaDetalj>();
                        List<InLine.Model.Data.Sort.View.TemeljnicaDetalj> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaDetalj>();
                        filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaDetalj { Field = InLine.Model.Data.Field.View.TemeljnicaDetalj.ID_Temeljnica, Value = Convert.ToInt64(IdMaster) });
                        var item = _serviceViewTemeljnicaDetalj.GetData(field, filter, sort).FirstOrDefault();


                        if (item != null)
                        {
                            rezult.Tecaj = item.Tecaj;
                            rezult.Datum = item.Datum;
                            rezult.IDValuta = item.IDValuta;
                        }
                    }
                    rezult.ID_TemeljnicaSt = -1;
                    rezult.ID_KontniPlan = idKontniPlan;
                    rezult.AnalitikaOd = analitikaOd;
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
            return PartialView(rezult);
        }



        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TemeljnicaStInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();
            Model.Admin.StatusPoruka porukaKontniPlanStProvjera = new Model.Admin.StatusPoruka();
            IDictionary<long, long> KriterijKriterijStListZaUnos = null;
            IDictionary<long, long> PostojeciKriterijIzBaze = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaBrisanje = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaDodavanje = new Dictionary<long, long>();
            List<long> IdTemeljnicaStKriterijSt = new List<long>();
            List<long> IdTemeljnicaStKriterijStZaBrisanje = new List<long>();
            bool viseInsert = false;


            if (viewmodel.ID_TemeljnicaSt == -1)
            {

                try
                {

                    porukaKontniPlanStProvjera = KontniPlanStProvjera(viewmodel);

                    if (String.IsNullOrEmpty(porukaKontniPlanStProvjera.StatusTekst))
                    {
                        if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                        {
                            KriterijKriterijStListZaUnos = SplitStringKriterijKriterijSt(viewmodel.KriterijKriterijStList);
                            viseInsert = true;
                        }

                        if (viseInsert)
                        {
                            _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                            using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                            {

                                Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem(viewmodel);
                                item.ID_Temeljnica = viewmodel.ID_Temeljnica;
                                Model.Data.TemeljnicaSt insert = _serviceTemeljnicaSt.InsertResult(item);

                                if (insert != null)
                                {
                                    long temeljnicaStInserted = insert.ID_TemeljnicaSt;
                                    if (temeljnicaStInserted > -1)
                                    {
                                        _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);

                                        foreach (var kks in KriterijKriterijStListZaUnos)
                                        {
                                            Model.Data.Item.TemeljnicaStKriterijItem temeljnicaStKriterijItem = new Model.Data.Item.TemeljnicaStKriterijItem();
                                            temeljnicaStKriterijItem.ID_Kriterij = kks.Value;
                                            temeljnicaStKriterijItem.ID_KriterijSt = kks.Key;
                                            temeljnicaStKriterijItem.ID_TemeljnicaSt = temeljnicaStInserted;
                                            Model.Data.TemeljnicaStKriterij temeljnicaStKriterijItemiInsert = _serviceTemeljnicaStKriterij.InsertResult(temeljnicaStKriterijItem);

                                        }
                                    }

                                }

                                tran.Complete();
                            }

                        }

                        else
                        {
                            _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                            Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem(viewmodel);
                            item.ID_Temeljnica = viewmodel.ID_Temeljnica;
                            Model.Data.TemeljnicaSt insert = _serviceTemeljnicaSt.InsertResult(item);

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


                if (!String.IsNullOrEmpty(porukaKontniPlanStProvjera.StatusTekst))
                {
                    InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(porukaKontniPlanStProvjera, korisnik_data);
                }

                poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
                InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
                return Json(poruke, JsonRequestBehavior.AllowGet);
            }

            else
            {
                return RedirectToAction("TemeljnicaStEdit", viewmodel);
            }

        }

        public ActionResult TemeljnicaStEdit(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            Model.Admin.StatusPoruka porukaKontniPlanStProvjera = new Model.Admin.StatusPoruka();
            IDictionary<long, long> KriterijKriterijStListZaUnos = null;
            IDictionary<long, long> PostojeciKriterijIzBaze = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaBrisanje = new Dictionary<long, long>();
            IDictionary<long, long> KriterijZaDodavanje = new Dictionary<long, long>();
            List<long> IdTemeljnicaStKriterijSt = new List<long>();
            List<long> IdTemeljnicaStKriterijStZaBrisanje = new List<long>();
            bool viseInsert = false;

            if (viewmodel.ID_TemeljnicaSt > -1)
            {
                try
                {
                    porukaKontniPlanStProvjera = KontniPlanStProvjera(viewmodel);

                    if (String.IsNullOrEmpty(porukaKontniPlanStProvjera.StatusTekst))
                    {


                        if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                        {
                            KriterijKriterijStListZaUnos = SplitStringKriterijKriterijSt(viewmodel.KriterijKriterijStList);
                            viseInsert = true;
                        }


                        _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);
                        var Postojeci = _serviceTemeljnicaStKriterij.SelectResult(null).Where(p => p.ID_TemeljnicaSt == Convert.ToInt64(viewmodel.ID_TemeljnicaSt)).ToList();

                        if (Postojeci != null)
                        {
                            foreach (var item in Postojeci)
                            {
                                PostojeciKriterijIzBaze.Add(item.ID_KriterijSt, item.ID_Kriterij);
                                IdTemeljnicaStKriterijSt.Add(item.ID_TemeljnicaStKriterij);
                            }
                        }

                        if (!String.IsNullOrEmpty(viewmodel.KriterijKriterijStList))
                        {
                            KriterijZaDodavanje = KriterijKriterijStListZaUnos.Where(x => !PostojeciKriterijIzBaze.ContainsKey(x.Key)).ToDictionary(x => x.Key, x => x.Value);
                            KriterijZaBrisanje = PostojeciKriterijIzBaze.Where(x => !KriterijKriterijStListZaUnos.ContainsKey(x.Key)).ToDictionary(x => x.Key, x => x.Value);
                        }


                        if (Postojeci != null && KriterijZaBrisanje != null)
                        {


                            foreach (var item in KriterijZaBrisanje)
                            {
                                var IdZaBrisanje = Postojeci.Where(x => x.ID_KriterijSt == item.Key && x.ID_Kriterij == item.Value).Select(p => p.ID_TemeljnicaStKriterij);
                                IdTemeljnicaStKriterijStZaBrisanje.Add(IdZaBrisanje.ElementAt(0));
                            }


                        }


                        if (viseInsert)
                        {
                            _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                            Model.Data.TemeljnicaSt model = _serviceTemeljnicaSt.FindID(viewmodel.ID_TemeljnicaSt);

                            if (model != null)
                            {
                                using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                                {
                                    Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem(viewmodel);
                                    Model.Data.TemeljnicaSt update = _serviceTemeljnicaSt.UpdateResult(item);


                                    if (KriterijZaDodavanje != null || KriterijZaBrisanje != null)
                                    {
                                        if (KriterijZaBrisanje.Count > 0)
                                        {
                                            _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);

                                            foreach (long id in IdTemeljnicaStKriterijStZaBrisanje)
                                            {

                                                Model.Data.Item.TemeljnicaStKriterijItem temeljnicaStKriterijItem = new Model.Data.Item.TemeljnicaStKriterijItem();
                                                temeljnicaStKriterijItem.ID_TemeljnicaStKriterij = id;
                                                int delete = _serviceTemeljnicaStKriterij.DeleteResult(temeljnicaStKriterijItem);
                                            }
                                        }

                                        if (KriterijZaDodavanje.Count > 0)
                                        {
                                            _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);

                                            foreach (var element in KriterijZaDodavanje)
                                            {
                                                Model.Data.Item.TemeljnicaStKriterijItem temeljnicaStKriterijItem = new Model.Data.Item.TemeljnicaStKriterijItem();
                                                temeljnicaStKriterijItem.ID_Kriterij = element.Value;
                                                temeljnicaStKriterijItem.ID_KriterijSt = element.Key;
                                                temeljnicaStKriterijItem.ID_TemeljnicaSt = update.ID_TemeljnicaSt;
                                                Model.Data.TemeljnicaStKriterij temeljnicaStKriterijItemiInsert = _serviceTemeljnicaStKriterij.InsertResult(temeljnicaStKriterijItem);

                                            }
                                        }
                                    }

                                    tran.Complete();
                                }
                            }
                        }

                        else
                        {
                            _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                            Model.Data.TemeljnicaSt model = _serviceTemeljnicaSt.FindID(viewmodel.ID_TemeljnicaSt);

                            if (model != null)
                            {
                                Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem(viewmodel);
                                Model.Data.TemeljnicaSt update = _serviceTemeljnicaSt.UpdateResult(item);

                                int b = IdTemeljnicaStKriterijSt.Count();

                                if (String.IsNullOrEmpty(viewmodel.KriterijKriterijStList) && IdTemeljnicaStKriterijSt.Count() > 0)
                                {
                                    _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);

                                    foreach (long id in IdTemeljnicaStKriterijSt)
                                    {
                                        Model.Data.Item.TemeljnicaStKriterijItem temeljnicaStKriterijItem = new Model.Data.Item.TemeljnicaStKriterijItem();
                                        temeljnicaStKriterijItem.ID_TemeljnicaStKriterij = id;
                                        int delete = _serviceTemeljnicaStKriterij.DeleteResult(temeljnicaStKriterijItem);
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


            if (!String.IsNullOrEmpty(porukaKontniPlanStProvjera.StatusTekst))
            {
                InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(porukaKontniPlanStProvjera, korisnik_data);
            }

            poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
            InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
            return Json(poruke, JsonRequestBehavior.AllowGet);

        }

        public Model.Admin.StatusPoruka KontniPlanStProvjera(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted viewmodel)
        {
            Model.Admin.StatusPoruka poruka = new Model.Admin.StatusPoruka();

            string rezult = string.Empty;
            StringBuilder sb = new StringBuilder();
            String UnosObavezan = "UNESENI PODACI NISU PROŠLI PROVJERU KONTA: ";

            _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
            var item = _serviceKontniPlanSt.FindID(viewmodel.ID_KontniPlanSt);


            if (viewmodel.ID_KontniPlanSt == 0)
            {
                sb.Append("Odaberite konto,");
            }


            if (item != null)
            {

                if (item.SaldoKonti == true)
                {
                    if (viewmodel.ID_Subjekt == null)
                    {
                        sb.Append("Poslovni partner nije unesen,");
                    }

                    if (viewmodel.ID_Zapis == null)
                    {
                        if (viewmodel.ID_KontniPlanAnalitika == null)
                        {
                            sb.Append("U slučaju da nije odabran dokument, mora bitim odabrana analitika, ");
                        }
                    }

                }

                if (item.SubjektObavezno == true && item.SaldoKonti == false)
                {
                    if (viewmodel.ID_Subjekt == null)
                    {
                        sb.Append("Poslovni partner nije unesen, ");
                    }
                }

                if (item.ZapisObavezno == true && item.SaldoKonti == false)
                {
                    if (viewmodel.ID_Zapis == null)
                    {
                        if (viewmodel.ID_KontniPlanAnalitika == null)
                        {
                            sb.Append("U slučaju da nije odabran dokument, mora bitim odabrana analitika, ");
                        }
                    }
                }

                if (item.DugujeObavezno == true)
                {
                    if (viewmodel.IznosDuguje == 0)
                    {
                        sb.Append("Dugovna strana nije unesena, ");
                    }
                }

                if (item.PotrazujeObavezno == true)
                {
                    if (viewmodel.IznosPotrazuje == 0)
                    {
                        sb.Append("Potražna strana nije unesena, ");
                    }
                }


                if (item.DugujeObavezno == false && item.DugujeDopusteno == false)
                {
                    if (viewmodel.IznosDuguje != 0)
                    {
                        sb.Append("Unos dugovne strane nije dopušten, ");
                    }
                }


                if (item.PotrazujeObavezno == false && item.PotrazujeDopusteno == false)
                {
                    if (viewmodel.IznosPotrazuje != 0)
                    {
                        sb.Append("Unos potražne strane nije dopušten, ");
                    }
                }


                if (item.DugujeDopusteno == true && item.PotrazujeDopusteno == true)
                {
                    if (viewmodel.IznosDuguje == 0 && viewmodel.IznosPotrazuje == 0)
                    {
                        sb.Append("Unosi ne smiju biti nula na dugovnoj i potražnoj strani, ");
                    }
                }

            }

            if (sb.ToString() != "")
            {
                rezult = UnosObavezan + sb.Remove(sb.ToString().Length - 2, 2);
                poruka.PorukaTekst = rezult;
                poruka.StatusTekst = "1";

            }

            return poruka;
        }

        //public ActionResult TemeljnicaStDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted viewmodel, long? id)
        //{
        //    List<Model.Admin.StatusPoruka> poruke = null;

        //    try
        //    {
        //        _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

        //        if (viewmodel.ID_TemeljnicaSt != -1)
        //        {
        //            Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem();
        //            if (id != null)
        //            {
        //                item.ID_TemeljnicaSt = Convert.ToInt64(id);
        //            }
        //            else
        //            {
        //                item.ID_TemeljnicaSt = viewmodel.ID_TemeljnicaSt;
        //            }

        //            int delete = _serviceTemeljnicaSt.DeleteResult(item);
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        Repository.Admin.IDozvoleZabranePoruke _admin = new Repository.Admin.DozvoleZabranePoruke();
        //        Model.Admin.StatusPoruka poruka = _admin.AddLogGetPorukaConstraint((ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString()), ex.StackTrace.ToString(), korisnik_data);
        //        InLine.Repository.Data.Helper.CommonFunctions.StaviPorukuUSession(poruka, korisnik_data);
        //        poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
        //        return PartialView(Repository.Data.Helper.CommonFunctions.ViewName.StatusPoruka, poruke);
        //    }

        //    poruke = InLine.Repository.Data.Helper.CommonFunctions.IzvadiPorukuUSession(korisnik_data);
        //    InLine.Repository.Data.Helper.CommonFunctions.OcistiPorukaSession(korisnik_data);
        //    return Json(poruke, JsonRequestBehavior.AllowGet);

        //}


        public ActionResult TemeljnicaStDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TemeljnicaStDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);
                List<InLine.Model.Data.Field.TemeljnicaStKriterij> field = new List<InLine.Model.Data.Field.TemeljnicaStKriterij>();
                List<InLine.Model.Data.Filter.TemeljnicaStKriterij> filter = new List<InLine.Model.Data.Filter.TemeljnicaStKriterij>();
                List<InLine.Model.Data.Sort.TemeljnicaStKriterij> sort = new List<InLine.Model.Data.Sort.TemeljnicaStKriterij>();

                if (id != null)
                {
                    filter.Add(new InLine.Model.Data.Filter.TemeljnicaStKriterij { Field = InLine.Model.Data.Field.TemeljnicaStKriterij.ID_TemeljnicaSt, Value = Convert.ToInt64(id) });
                }
                else
                {

                    filter.Add(new InLine.Model.Data.Filter.TemeljnicaStKriterij { Field = InLine.Model.Data.Field.TemeljnicaStKriterij.ID_TemeljnicaSt, Value = Convert.ToInt64(viewmodel.ID_TemeljnicaSt) });
                }

                var Postojeci = _serviceTemeljnicaStKriterij.GetData(field, filter, sort).Select(p => p.ID_TemeljnicaStKriterij).ToList();



                if (Postojeci.Count() > 0)
                {
                    using (TransactionScope tran = new TransactionScope(TransactionScopeOption.Suppress))
                    {
                        foreach (long idPostojeci in Postojeci)
                        {
                            Model.Data.Item.TemeljnicaStKriterijItem temeljnicaStKriterijItem = new Model.Data.Item.TemeljnicaStKriterijItem();
                            temeljnicaStKriterijItem.ID_TemeljnicaStKriterij = idPostojeci;
                            int delete = _serviceTemeljnicaStKriterij.DeleteResult(temeljnicaStKriterijItem);
                        }


                        _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                        if (viewmodel.ID_TemeljnicaSt != -1)
                        {
                            Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem();
                            if (id != null)
                            {
                                item.ID_TemeljnicaSt = Convert.ToInt64(id);
                            }
                            else
                            {
                                item.ID_TemeljnicaSt = viewmodel.ID_TemeljnicaSt;
                            }

                            int delete = _serviceTemeljnicaSt.DeleteResult(item);
                        }

                        tran.Complete();
                    }
                }

                else
                {
                    _serviceTemeljnicaSt = new Service.Data.TemeljnicaSt(korisnik_data);

                    Model.Data.Item.TemeljnicaStItem item = new Model.Data.Item.TemeljnicaStItem();
                    if (id != null)
                    {
                        item.ID_TemeljnicaSt = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_TemeljnicaSt = viewmodel.ID_TemeljnicaSt;
                    }

                    int delete = _serviceTemeljnicaSt.DeleteResult(item);

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

        public IEnumerable<InLine.Model.Data.View.TemeljnicaStKontniPlanSt> TemeljnicaStKontniPlanStGetData(long ID_Temeljnica)
        {
            _serviceViewTemeljnicaStKontniPlanSt = new Service.Data.View.TemeljnicaStKontniPlanSt(korisnik_data);
            List<InLine.Model.Data.Field.View.TemeljnicaStKontniPlanSt> field = new List<InLine.Model.Data.Field.View.TemeljnicaStKontniPlanSt>();
            List<InLine.Model.Data.Filter.View.TemeljnicaStKontniPlanSt> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaStKontniPlanSt>();
            List<InLine.Model.Data.Sort.View.TemeljnicaStKontniPlanSt> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaStKontniPlanSt>();
            sort.Add(new InLine.Model.Data.Sort.View.TemeljnicaStKontniPlanSt { Field = InLine.Model.Data.Field.View.TemeljnicaStKontniPlanSt.Naziv });
            filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaStKontniPlanSt { Field = InLine.Model.Data.Field.View.TemeljnicaStKontniPlanSt.ID_Temeljnica, Value = ID_Temeljnica });
            var item = _serviceViewTemeljnicaStKontniPlanSt.GetData(field, filter, sort);
            return item;
        }

        public IEnumerable<InLine.Model.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> TemeljnicaTemeljnicaVrGlavnaKnjigaGetData()
        {
            _serviceViewTemeljnicaTemeljnicaVrGlavnaKnjiga = new Service.Data.View.TemeljnicaTemeljnicaVrGlavnaKnjiga(korisnik_data);
            List<InLine.Model.Data.Field.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> field = new List<InLine.Model.Data.Field.View.TemeljnicaTemeljnicaVrGlavnaKnjiga>();
            List<InLine.Model.Data.Filter.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaTemeljnicaVrGlavnaKnjiga>();
            List<InLine.Model.Data.Sort.View.TemeljnicaTemeljnicaVrGlavnaKnjiga> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaTemeljnicaVrGlavnaKnjiga>();
            var item = _serviceViewTemeljnicaTemeljnicaVrGlavnaKnjiga.GetData(field, filter, sort);
            return item;
        }

        public ActionResult KontniPlanKriterij(long ID_KontniPlan, long? ID_KontniPlanSt, long? ID_TemeljnicaSt)
        {
            InLine.UI.Web.Controllers.KriterijFolder model = new InLine.UI.Web.Controllers.KriterijFolder();

            _serviceKriterij = new Service.Data.Kriterij(korisnik_data);
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> children = null;
            List<IDKriterijNaziv> IdKriterijNaziv = null;

            IdKriterijNaziv = _serviceKriterij.SelectResult(null).Where(p => p.ID_KontniPlan == ID_KontniPlan).Select(c => new IDKriterijNaziv { ID_Kriterij = c.ID_Kriterij, Naziv = c.Naziv }).ToList();

            if (IdKriterijNaziv.Count > 0)
            {
                List<long> IdKriterijList = new List<long>();
                foreach (var kriterij in IdKriterijNaziv)
                {
                    IdKriterijList.Add(kriterij.ID_Kriterij);
                }

                _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);

                children = KriterijStKriterijStKriterijStGetData().Where(p => IdKriterijList.Contains(p.ID_Kriterij)).ToList();

            }

            model.KojiKriterijList = IdKriterijNaziv;
            model.ID_TemeljnicaSt = ID_TemeljnicaSt;
            model.ID_KontniPlanSt = ID_KontniPlanSt;


            return PartialView(ViewList.FinancijskoKnjigovodstvo.ViewTreeViewKontniPlanKriterijPartial, model);
        }

        public ActionResult TemeljnicaStKriterijForma(long ID_KontniPlan, long? ID_KontniPlanSt, long? ID_TemeljnicaSt)
        {
            InLine.UI.Web.Controllers.KriterijFolder model = new InLine.UI.Web.Controllers.KriterijFolder();

            _serviceKriterij = new Service.Data.Kriterij(korisnik_data);
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> children = null;
            List<IDKriterijNaziv> IdKriterijNaziv = null;

            IdKriterijNaziv = _serviceKriterij.SelectResult(null).Where(p => p.ID_KontniPlan == ID_KontniPlan).Select(c => new IDKriterijNaziv { ID_Kriterij = c.ID_Kriterij, Naziv = c.Naziv }).ToList();

            if (IdKriterijNaziv.Count > 0)
            {
                List<long> IdKriterijList = new List<long>();
                foreach (var kriterij in IdKriterijNaziv)
                {
                    IdKriterijList.Add(kriterij.ID_Kriterij);
                }

                _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);

                children = KriterijStKriterijStKriterijStGetData().Where(p => IdKriterijList.Contains(p.ID_Kriterij)).ToList();

            }

            model.KojiKriterijList = IdKriterijNaziv;
            model.ID_TemeljnicaSt = ID_TemeljnicaSt;
            model.ID_KontniPlanSt = ID_KontniPlanSt;


            return PartialView(ViewList.FinancijskoKnjigovodstvo.ViewTreeViewTemeljnicaStKriterijPartial, model);
        }

        public string TemeljnicStKriterijOdabrani(long? ID_TemeljnicaSt)
        {
            string rezult = string.Empty;
            StringBuilder sb = new StringBuilder();

            _serviceViewTemeljnicaStKriterij = new Service.Data.View.TemeljnicaStKriterij(korisnik_data);
            List<InLine.Model.Data.Field.View.TemeljnicaStKriterij> field = new List<InLine.Model.Data.Field.View.TemeljnicaStKriterij>();
            List<InLine.Model.Data.Filter.View.TemeljnicaStKriterij> filter = new List<InLine.Model.Data.Filter.View.TemeljnicaStKriterij>();
            filter.Add(new InLine.Model.Data.Filter.View.TemeljnicaStKriterij { Field = InLine.Model.Data.Field.View.TemeljnicaStKriterij.ID_TemeljnicaSt, Value = Convert.ToInt64(ID_TemeljnicaSt) });
            List<InLine.Model.Data.Sort.View.TemeljnicaStKriterij> sort = new List<InLine.Model.Data.Sort.View.TemeljnicaStKriterij>();
            var item = _serviceViewTemeljnicaStKriterij.GetData(field, filter, sort).FirstOrDefault();

            if (item != null)
            {
                sb.Append("ODABRANI KRITERIJI: ");


                if (item.KriterijNaziv1 != null)
                {
                    sb.Append("1." + item.KriterijNaziv1 + "-" + item.KriterijStNaziv1 + " ");
                }

                if (item.KriterijNaziv2 != null)
                {
                    sb.Append("2." + item.KriterijNaziv2 + "-" + item.KriterijStNaziv2 + " ");
                }

                if (item.KriterijNaziv3 != null)
                {
                    sb.Append("3." + item.KriterijNaziv3 + "-" + item.KriterijStNaziv3 + " ");
                }

                if (item.KriterijNaziv4 != null)
                {
                    sb.Append("4." + item.KriterijNaziv4 + "-" + item.KriterijStNaziv4 + " ");
                }

                if (item.KriterijNaziv5 != null)
                {
                    sb.Append("5." + item.KriterijNaziv5 + "-" + item.KriterijStNaziv5 + " ");
                }

                if (item.KriterijNaziv6 != null)
                {
                    sb.Append("6." + item.KriterijNaziv6 + "-" + item.KriterijStNaziv6);
                }


                rezult = sb.ToString();

            }

            return rezult;
        }


        //public ActionResult TreeViewKriterij(InLine.UI.Web.Controllers.KriterijFolder model)
        //{

        //    if (model.ID_KontniPlanSt.HasValue)
        //    {
        //        return PartialView(this.KontniPlanStKriterijKriterijStTreeView(model));
        //    }
        //    else
        //    {
        //        return PartialView(this.KriterijKriterijStTreeView(model));
        //    }
        //}

        public ActionResult TreeViewKontniPlanKriterij(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            return PartialView(this.KontniPlanStKriterijKriterijStTreeView(model));

        }

        public ActionResult TreeViewTemeljnicaStKriterij(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            return PartialView(this.TemeljnicaStKriterijKriterijStTreeView(model));

        }

        public KriterijFolder KontniPlanStKriterijKriterijStTreeView(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            KriterijFolder treeViewContentZaView = new KriterijFolder();
            IList<Folder> treeViewContent = new List<Folder>();
            IList<long> kriterijKontniPlanSt = new List<long>();
            IDictionary<long, bool> kriterijKontniPlanStObavezan = new Dictionary<long, bool>();
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> nulti = null;
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> kriteriji = null;


            Folder nultiFolder = new Folder();

            List<long> IdKriterijList = new List<long>();

            List<IDKriterijNaziv> IdKriterijNaziv = null;
            KriterijKriterijstTreeViewModel vm = new KriterijKriterijstTreeViewModel();

            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);
            nulti = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_Kriterij == model.KojiKriterij).ToList();

            if (model.ID_KontniPlanSt.HasValue)
            {
                _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);
                kriterijKontniPlanSt = _serviceKontniPlanStKriterij.SelectResult(null).Where(p => p.ID_KontniPlanSt == Convert.ToInt64(model.ID_KontniPlanSt)).Select(p => p.ID_KriterijSt).ToList();
                kriterijKontniPlanStObavezan = _serviceKontniPlanStKriterij.SelectResult(null).Where(p => p.ID_KontniPlanSt == Convert.ToInt64(model.ID_KontniPlanSt) && p.Obavezno == true).ToDictionary(x => x.ID_KriterijSt, x => x.Obavezno);
            }


            foreach (var itemKriterijStKriterijStkriterijSt in nulti)
            {
                kriteriji = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == itemKriterijStKriterijStkriterijSt.ID_KriterijSt && p.ID_Kriterij == model.KojiKriterij).ToList();
                bool nultiCkecked = false;
                bool kriterijObavezan = false;


                if (kriterijKontniPlanSt != null)
                {
                    foreach (long item in kriterijKontniPlanSt)
                    {
                        if (item == itemKriterijStKriterijStkriterijSt.ID_KriterijSt)
                        {
                            nultiCkecked = true;
                        }
                    }

                    foreach (var item in kriterijKontniPlanStObavezan)
                    {
                        if (item.Key == itemKriterijStKriterijStkriterijSt.ID_KriterijSt && item.Value == true)
                        {
                            kriterijObavezan = true;
                        }
                    }
                }

                nultiFolder = new Folder
                {
                    ID_KriterijSt = itemKriterijStKriterijStkriterijSt.ID_KriterijSt,
                    KriterijStNaziv = itemKriterijStKriterijStkriterijSt.Naziv,
                    KriterijNaziv = itemKriterijStKriterijStkriterijSt.KriterijNaziv,
                    Nulti = true,
                    KriterijNazivList = IdKriterijNaziv,
                    ID_Kriterij = itemKriterijStKriterijStkriterijSt.ID_Kriterij,
                    IsChecked = nultiCkecked,
                    IsKriterijObavezanFolder = kriterijObavezan

                };


                treeViewContent.Add(nultiFolder);
            }

            treeViewContentZaView.Folderi = treeViewContent;
            treeViewContentZaView.KojiKriterij = 1;

            return treeViewContentZaView;
        }

        public KriterijFolder TemeljnicaStKriterijKriterijStTreeView(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            KriterijFolder treeViewContentZaView = new KriterijFolder();
            IList<Folder> treeViewContent = new List<Folder>();
            IList<long> kriterijKontniPlanSt = new List<long>();
            IDictionary<long, bool> kriterijKontniPlanStObavezan = new Dictionary<long, bool>();
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> nulti = null;
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> kriteriji = null;


            Folder nultiFolder = new Folder();

            List<long> IdKriterijList = new List<long>();

            List<IDKriterijNaziv> IdKriterijNaziv = null;
            KriterijKriterijstTreeViewModel vm = new KriterijKriterijstTreeViewModel();

            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);
            nulti = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_Kriterij == model.KojiKriterij).ToList();

            if (model.ID_KontniPlanSt.HasValue)
            {
                _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);
                kriterijKontniPlanSt = _serviceKontniPlanStKriterij.SelectResult(null).Where(p => p.ID_KontniPlanSt == Convert.ToInt64(model.ID_KontniPlanSt)).Select(p => p.ID_KriterijSt).ToList();
                kriterijKontniPlanStObavezan = _serviceKontniPlanStKriterij.SelectResult(null).Where(p => p.ID_KontniPlanSt == Convert.ToInt64(model.ID_KontniPlanSt) && p.Obavezno == true).ToDictionary(x => x.ID_KriterijSt, x => x.Obavezno);
            }


            foreach (var itemKriterijStKriterijStkriterijSt in nulti)
            {
                kriteriji = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == itemKriterijStKriterijStkriterijSt.ID_KriterijSt && p.ID_Kriterij == model.KojiKriterij).ToList();
                bool nultiCkecked = false;
                bool kriterijObavezan = false;


                if (kriterijKontniPlanSt != null)
                {
                    //foreach (long item in kriterijKontniPlanSt)
                    //{
                    //    if (item == itemKriterijStKriterijStkriterijSt.ID_KriterijSt)
                    //    {
                    //        nultiCkecked = true;
                    //    }
                    //}

                    foreach (var item in kriterijKontniPlanStObavezan)
                    {
                        if (item.Key == itemKriterijStKriterijStkriterijSt.ID_KriterijSt && item.Value == true)
                        {
                            kriterijObavezan = true;
                        }
                    }
                }

                nultiFolder = new Folder
                {
                    KriterijNaziv = itemKriterijStKriterijStkriterijSt.KriterijNaziv,
                    ID_KriterijSt = itemKriterijStKriterijStkriterijSt.ID_KriterijSt,
                    KriterijStNaziv = itemKriterijStKriterijStkriterijSt.Naziv,
                    Nulti = true,
                    KriterijNazivList = IdKriterijNaziv,
                    ID_Kriterij = itemKriterijStKriterijStkriterijSt.ID_Kriterij,
                    IsChecked = nultiCkecked,
                    IsKriterijObavezanFolder = kriterijObavezan

                };


                treeViewContent.Add(nultiFolder);
            }

            treeViewContentZaView.Folderi = treeViewContent;
            treeViewContentZaView.KojiKriterij = 1;

            return treeViewContentZaView;
        }

        public KriterijFolder KriterijKriterijStTreeView(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            KriterijFolder treeViewContentZaView = new KriterijFolder();
            IList<Folder> treeViewContent = new List<Folder>();
            IList<long> kriterijTemeljnicaSt = new List<long>();
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> nulti = null;
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> kriteriji = null;
            IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> subchildren = null;

            Folder subchildrenFolder = new Folder();
            Folder childrenFolder = new Folder();
            Folder nultiFolder = new Folder();

            List<long> IdKriterijList = new List<long>();

            List<IDKriterijNaziv> IdKriterijNaziv = null;
            KriterijKriterijstTreeViewModel vm = new KriterijKriterijstTreeViewModel();

            _serviceViewKriterijStKriterijStKriterijSt = new Service.Data.View.KriterijStKriterijStKriterijSt(korisnik_data);
            nulti = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_Kriterij == model.KojiKriterij && p.Nivo == 0).ToList();

            if (model.ID_TemeljnicaSt.HasValue)
            {
                _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);
                kriterijTemeljnicaSt = _serviceTemeljnicaStKriterij.SelectResult(null).Where(p => p.ID_TemeljnicaSt == Convert.ToInt64(model.ID_TemeljnicaSt)).Select(p => p.ID_KriterijSt).ToList();
            }


            foreach (var continent in nulti)
            {
                kriteriji = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == continent.ID_KriterijSt && p.Nivo != 0 && p.ID_Kriterij == model.KojiKriterij).ToList();
                bool nultiCkecked = false;


                if (kriterijTemeljnicaSt != null)
                {
                    foreach (long item in kriterijTemeljnicaSt)
                    {
                        if (item == continent.ID_KriterijSt)
                        {
                            nultiCkecked = true;
                        }
                    }
                }

                nultiFolder = new Folder
                {
                    ID_KriterijSt = continent.ID_KriterijSt,
                    KriterijStNaziv = continent.Naziv,
                    KriterijNaziv = continent.KriterijNaziv,
                    Nulti = true,
                    KriterijNazivList = IdKriterijNaziv,
                    ID_Kriterij = continent.ID_Kriterij,
                    IsChecked = nultiCkecked

                };

                foreach (var a in kriteriji)
                {
                    bool childrenFolderChecked = false;
                    subchildren = KriterijStKriterijStKriterijStGetData().Where(p => p.ID_KriterijStNad == a.ID_KriterijSt && p.ID_Kriterij == model.KojiKriterij).ToList();

                    if (kriterijTemeljnicaSt != null)
                    {
                        foreach (long item in kriterijTemeljnicaSt)
                        {
                            if (item == a.ID_KriterijSt)
                            {
                                childrenFolderChecked = true;
                            }
                        }
                    }

                    childrenFolder = new Folder
                    {
                        ID_KriterijSt = a.ID_KriterijSt,
                        KriterijStNaziv = a.Naziv,
                        KriterijNaziv = a.KriterijNaziv,
                        Nulti = false,
                        KriterijNazivList = IdKriterijNaziv,
                        ID_Kriterij = continent.ID_Kriterij,
                        IsChecked = childrenFolderChecked
                    };

                    foreach (var b in subchildren)
                    {
                        bool subchildrenFolderChecked = false;

                        if (kriterijTemeljnicaSt != null)
                        {
                            foreach (long item in kriterijTemeljnicaSt)
                            {
                                if (item == b.ID_KriterijSt)
                                {
                                    subchildrenFolderChecked = true;
                                }
                            }
                        }

                        subchildrenFolder = new Folder
                        {
                            ID_KriterijSt = b.ID_KriterijSt,
                            KriterijStNaziv = b.Naziv,
                            KriterijNaziv = b.KriterijNaziv,
                            Nulti = false,
                            KriterijNazivList = IdKriterijNaziv,
                            ID_Kriterij = continent.ID_Kriterij,
                            IsChecked = subchildrenFolderChecked

                        };

                        childrenFolder.Subfolders.Add(subchildrenFolder);
                    }

                    nultiFolder.Subfolders.Add(childrenFolder);
                }

                treeViewContent.Add(nultiFolder);
            }

            treeViewContentZaView.Folderi = treeViewContent;
            treeViewContentZaView.KojiKriterij = 1;

            return treeViewContentZaView;
        }

        public virtual ActionResult TreeViewKontniPlanKriterijPartial(InLine.UI.Web.Controllers.KriterijFolder model)
        {
            if (model.ID_KontniPlanSt.HasValue)
            {
                return View(this.KontniPlanStKriterijKriterijStTreeView(model));
            }
            else
            {
                return View(this.KriterijKriterijStTreeView(model));
            }

        }


        public IDictionary<long, long> SplitStringKriterijKriterijSt(string kriterijKriterijSt)
        {
            Dictionary<long, long> rezult = new Dictionary<long, long>();
            string[] stringseparator = new string[] { CommonFunctions.KeyWord.Zarez };
            string[] stringlista;

            stringlista = kriterijKriterijSt.Split(stringseparator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in stringlista)
            {
                long prvi = 0;
                long drugi = 0;
                string[] polja;
                string[] sep = new string[] { CommonFunctions.KeyWord.DvoTocka };
                polja = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                prvi = Convert.ToInt64(polja.ElementAt(0).ToString().Trim());
                drugi = Convert.ToInt64(polja.ElementAt(1).ToString().Trim());
                rezult.Add(prvi, drugi);
            }
            return rezult;
        }

        public List<long> SplitStringKriterijObavezno(string kriterijObavezno)
        {
            List<long> rezult = new List<long>();

            if (!String.IsNullOrEmpty(kriterijObavezno))
            {
                string[] stringseparator = new string[] { CommonFunctions.KeyWord.Zarez };
                string[] stringlista;

                stringlista = kriterijObavezno.Split(stringseparator, StringSplitOptions.RemoveEmptyEntries);

                foreach (string str in stringlista)
                {
                    long prvi = 0;
                    long drugi = 0;
                    string[] polja;
                    string[] sep = new string[] { CommonFunctions.KeyWord.DvoTocka };

                    polja = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    prvi = Convert.ToInt64(polja.ElementAt(0).ToString().Trim());
                    drugi = Convert.ToInt64(polja.ElementAt(1).ToString().Trim());

                    if (drugi == 1)
                    {
                        rezult.Add(prvi);
                    }


                }

            }
            return rezult;
        }

        public virtual ActionResult KontniPlanStKriterijiStTemeljnicaSt(long idKontniPlanStPost)
        {
            //List<InLine.Model.Data.KontniPlanStKriterij> item = new List<InLine.Model.Data.KontniPlanStKriterij>();

            _serviceKontniPlanStKriterij = new Service.Data.KontniPlanStKriterij(korisnik_data);
            List<InLine.Model.Data.Field.KontniPlanStKriterij> field = new List<InLine.Model.Data.Field.KontniPlanStKriterij>();
            List<InLine.Model.Data.Filter.KontniPlanStKriterij> filter = new List<InLine.Model.Data.Filter.KontniPlanStKriterij>();
            List<InLine.Model.Data.Sort.KontniPlanStKriterij> sort = new List<InLine.Model.Data.Sort.KontniPlanStKriterij>();
            filter.Add(new InLine.Model.Data.Filter.KontniPlanStKriterij { Field = InLine.Model.Data.Field.KontniPlanStKriterij.ID_KontniPlanSt, Value = Convert.ToInt64(idKontniPlanStPost) });
            var item = _serviceKontniPlanStKriterij.GetData(field, filter, sort).ToList();
            var result = from i in item
                         select new
                         {
                             ID_KontniPlanStKriterij = i.ID_KontniPlanStKriterij,
                             ID_KontniPlanSt = i.ID_KontniPlanSt,
                             ID_Kriterij = i.ID_Kriterij,
                             ID_KriterijSt = i.ID_KriterijSt,
                             Obavezno = i.Obavezno

                         };



            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public virtual ActionResult TemeljnicaStKriteriji(long idTemeljnicaStPost)
        {
            _serviceTemeljnicaStKriterij = new Service.Data.TemeljnicaStKriterij(korisnik_data);
            List<InLine.Model.Data.Field.TemeljnicaStKriterij> field = new List<InLine.Model.Data.Field.TemeljnicaStKriterij>();
            List<InLine.Model.Data.Filter.TemeljnicaStKriterij> filter = new List<InLine.Model.Data.Filter.TemeljnicaStKriterij>();
            List<InLine.Model.Data.Sort.TemeljnicaStKriterij> sort = new List<InLine.Model.Data.Sort.TemeljnicaStKriterij>();
            filter.Add(new InLine.Model.Data.Filter.TemeljnicaStKriterij { Field = InLine.Model.Data.Field.TemeljnicaStKriterij.ID_TemeljnicaSt, Value = Convert.ToInt64(idTemeljnicaStPost) });
            var item = _serviceTemeljnicaStKriterij.GetData(field, filter, sort).ToList();

            var result = from i in item
                         select new
                         {
                             ID_TemeljnicaStKriterij = i.ID_TemeljnicaStKriterij,
                             ID_TemeljnicaSt = i.ID_TemeljnicaSt,
                             ID_Kriterij = i.ID_Kriterij,
                             ID_KriterijSt = i.ID_KriterijSt

                         };

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        #endregion

        #region Ispisi

        public ActionResult Ispisi() //Prikuplja podatke o korisniku (ID_Subjekt, ID_GlavnaKnjiga, ID_KontniPlan...)
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
                rezult.Godina = Convert.ToInt32(item.Godina);
                rezult.Naziv = item.Naziv;
                ViewBag.DatumOd = item.DatumOd;
                ViewBag.DatumDo = item.DatumDo;
                rezult.ID_Subjekt = Convert.ToInt64(item.ID_Subjekt);
            }

            else
            {
                rezult.ID_GlavnaKnjiga = 0;
                rezult.ID_KontniPlan = 0;
                rezult.Godina = 0;
                rezult.Naziv = "";
                rezult.ID_Subjekt = 0;
            }
            return View(rezult);
        }

        public ActionResult IspisiPartial(long Kontni, long Glavna, string DatumOd, string DatumDo) //Na osnovi podataka o korisniku skuplja podatke za comboboxeve
        {
            _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
            _serviceTemeljnicaVr = new Service.Data.TemeljnicaVr(korisnik_data);
            _serviceKriterij = new Service.Data.Kriterij(korisnik_data);
            _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);
            _serviceKontniPlanAnalitika = new Service.Data.KontniPlanAnalitika(korisnik_data);
                _serviceZapisVr = new Service.Data.ZapisVr(korisnik_data);

            ViewBag.DatumOd = DatumOd;
            ViewBag.DatumDo = DatumDo;
            Session["kojaGlavnaZaIspise"] = Glavna;
            Session["Kontni"] = Kontni;

            //KONTO

            List<InLine.Model.Data.Field.KontniPlanSt> fieldKontniPlanSt = new List<InLine.Model.Data.Field.KontniPlanSt>();
            List<InLine.Model.Data.Filter.KontniPlanSt> filterKontniPlanSt = new List<InLine.Model.Data.Filter.KontniPlanSt>();
            filterKontniPlanSt.Add(new InLine.Model.Data.Filter.KontniPlanSt { Field = InLine.Model.Data.Field.KontniPlanSt.ID_KontniPlan, Value = Kontni });
            List<InLine.Model.Data.Sort.KontniPlanSt> sortKontniPlanSt = new List<InLine.Model.Data.Sort.KontniPlanSt>();
            sortKontniPlanSt.Add(new InLine.Model.Data.Sort.KontniPlanSt { Field = InLine.Model.Data.Field.KontniPlanSt.Konto });

            List<InLine.Model.Data.KontniPlanSt> dataKontniPlanSt = _serviceKontniPlanSt.GetData(fieldKontniPlanSt, filterKontniPlanSt, sortKontniPlanSt).ToList();

            List<SelectListItem> KontniPlanStCombo = dataKontniPlanSt.Select(x => new SelectListItem() { Value = x.Konto, Text = x.Konto + " - " + x.Naziv }).ToList();

            ViewBag.KontniPlanStCombo = new SelectList(KontniPlanStCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            //DOKUMENT

            List<InLine.Model.Data.Field.KontniPlanAnalitika> fieldKontniPlanAnalitika = new List<InLine.Model.Data.Field.KontniPlanAnalitika>();
            List<InLine.Model.Data.Filter.KontniPlanAnalitika> filterKontniPlanAnalitika = new List<InLine.Model.Data.Filter.KontniPlanAnalitika>();
            filterKontniPlanAnalitika.Add(new InLine.Model.Data.Filter.KontniPlanAnalitika { Field = InLine.Model.Data.Field.KontniPlanAnalitika.ID_KontniPlan, Value = Kontni });
            List<InLine.Model.Data.Sort.KontniPlanAnalitika> sortKontniPlanAnalitika = new List<InLine.Model.Data.Sort.KontniPlanAnalitika>();
            sortKontniPlanAnalitika.Add(new InLine.Model.Data.Sort.KontniPlanAnalitika { Field = InLine.Model.Data.Field.KontniPlanAnalitika.IDZapisVr });

            List<InLine.Model.Data.KontniPlanAnalitika> dataKontniPlanAnalitika = _serviceKontniPlanAnalitika.GetData(fieldKontniPlanAnalitika, filterKontniPlanAnalitika, sortKontniPlanAnalitika).ToList();

            List<SelectListItem> zapisVrComboKonacno = new List<SelectListItem>();
            foreach (var analitika in dataKontniPlanAnalitika)
            {
                List<InLine.Model.Data.Field.ZapisVr> fieldZapisVr = new List<InLine.Model.Data.Field.ZapisVr>();
                List<InLine.Model.Data.Filter.ZapisVr> filterZapisVr = new List<InLine.Model.Data.Filter.ZapisVr>();
                filterZapisVr.Add(new InLine.Model.Data.Filter.ZapisVr { Field = InLine.Model.Data.Field.ZapisVr.IDZapisVr, Value = analitika.IDZapisVr });
                List<InLine.Model.Data.Sort.ZapisVr> sortZapisVr = new List<InLine.Model.Data.Sort.ZapisVr>();
                sortZapisVr.Add(new InLine.Model.Data.Sort.ZapisVr { Field = InLine.Model.Data.Field.ZapisVr.Naziv });

                List<InLine.Model.Data.ZapisVr> dataZapisVr = _serviceZapisVr.GetData(fieldZapisVr, filterZapisVr, sortZapisVr).ToList();

                List<SelectListItem> zapisVrCombo = dataZapisVr.Select(x => new SelectListItem() { Value = x.IDZapisVr.ToString(), Text = x.IDZapisVr.ToString() + " - " + x.Naziv }).ToList();

                foreach (var item in zapisVrCombo)
                {
                    zapisVrComboKonacno.Add(item);
                }
            }

            ViewBag.ZapisVrCombo = new SelectList(zapisVrComboKonacno.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            //VRSTA TEMELJNICE

            List<InLine.Model.Data.Field.TemeljnicaVr> fieldTemeljnicaVr = new List<InLine.Model.Data.Field.TemeljnicaVr>();
            List<InLine.Model.Data.Filter.TemeljnicaVr> filterTemeljnicaVr = new List<InLine.Model.Data.Filter.TemeljnicaVr>();
            filterTemeljnicaVr.Add(new InLine.Model.Data.Filter.TemeljnicaVr { Field = InLine.Model.Data.Field.TemeljnicaVr.ID_GlavnaKnjiga, Value = Glavna });
            List<InLine.Model.Data.Sort.TemeljnicaVr> sortTemeljnicaVr = new List<InLine.Model.Data.Sort.TemeljnicaVr>();
            sortTemeljnicaVr.Add(new InLine.Model.Data.Sort.TemeljnicaVr { Field = InLine.Model.Data.Field.TemeljnicaVr.Oznaka });

            List<InLine.Model.Data.TemeljnicaVr> dataTemeljnicaVr = _serviceTemeljnicaVr.GetData(fieldTemeljnicaVr, filterTemeljnicaVr, sortTemeljnicaVr).ToList();

            List<SelectListItem> TemeljnicaVrCombo = dataTemeljnicaVr.Select(x => new SelectListItem() { Value = x.Oznaka, Text = x.Oznaka + " - " + x.Naziv }).ToList();

            ViewBag.VrstaTemeljniceCombo = new SelectList(TemeljnicaVrCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            //KRITERIJI
            List<InLine.Model.Data.Field.Kriterij> fieldKriterij = new List<InLine.Model.Data.Field.Kriterij>();
            List<InLine.Model.Data.Filter.Kriterij> filterKriterij = new List<InLine.Model.Data.Filter.Kriterij>();
            filterKriterij.Add(new InLine.Model.Data.Filter.Kriterij { Field = InLine.Model.Data.Field.Kriterij.ID_KontniPlan, Value = Kontni });
            List<InLine.Model.Data.Sort.Kriterij> sortKriterij = new List<InLine.Model.Data.Sort.Kriterij>();

            List<InLine.Model.Data.Kriterij> dataKriterij = _serviceKriterij.GetData(fieldKriterij, filterKriterij, sortKriterij).ToList();
            ViewBag.Kriteriji = dataKriterij.ToList();

            int brojIME = 1;
            foreach (var kriteriji in dataKriterij)
            {
                List<InLine.Model.Data.Field.KriterijSt> fieldKriterijSt = new List<InLine.Model.Data.Field.KriterijSt>();
                List<InLine.Model.Data.Filter.KriterijSt> filterKriterijSt = new List<InLine.Model.Data.Filter.KriterijSt>();
                filterKriterijSt.Add(new InLine.Model.Data.Filter.KriterijSt { Field = InLine.Model.Data.Field.KriterijSt.ID_Kriterij, Value = kriteriji.ID_Kriterij });
                List<InLine.Model.Data.Sort.KriterijSt> sortKriterijSt = new List<InLine.Model.Data.Sort.KriterijSt>();
                sortKriterijSt.Add(new InLine.Model.Data.Sort.KriterijSt { Field = InLine.Model.Data.Field.KriterijSt.Oznaka });

                List<InLine.Model.Data.KriterijSt> dataKriterijSt = _serviceKriterijSt.GetData(fieldKriterijSt, filterKriterijSt, sortKriterijSt).ToList();

                List<SelectListItem> KriterijStCombo = dataKriterijSt.Select(x => new SelectListItem() { Value = x.ID_KriterijSt.ToString(), Text = x.Oznaka.ToString() + " - " + x.Naziv }).ToList();

                ViewData["listaKriterija" + brojIME.ToString() + "COMBO"] = new SelectList(KriterijStCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

                brojIME++;
            }
            return PartialView();
        }

        public ActionResult ListaDatoteka(string path) //Služi za ona tri comboboxa na lijevoj strani za odabir željenog ispisa
        {
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath(@"~/Content/Reporti/IspisiFinancijsko" + path));
            List<SelectListItem> lista = new List<SelectListItem>();

            foreach (FileInfo FajlInfo in dir.GetFiles("*.mrt"))
            {
                lista.Add(new SelectListItem() { Text = FajlInfo.Name.Replace(".mrt", ""), Value = FajlInfo.Name.Replace(".mrt", "") });
            }

            foreach (DirectoryInfo DirInfo in dir.GetDirectories())
            {
                lista.Add(new SelectListItem() { Text = DirInfo.Name, Value = DirInfo.Name });
            }
            ViewBag.Lista = new SelectList(lista, KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);
            return PartialView();
        }

        public ActionResult IspisReport(string S) // Sprema SQLUpit u session kako bi ga moga koristiti u View-u i ostalim funkcijama
        {
            Session["ostatakSQLUpita_STR"] = S;
            return View();
        }

        public ActionResult GetReportSnapshot() // Generira WHERE dio SQL upita i na kraju pokreče željeni ispis
        {
            _serviceKontniPlanSt = new Service.Data.KontniPlanSt(korisnik_data);
            _serviceKriterij = new Service.Data.Kriterij(korisnik_data);
            _serviceKriterijSt = new Service.Data.KriterijSt(korisnik_data);

            string[] parametri_STRa = Session["ostatakSQLUpita_STR"].ToString().Split(';');
            string ostatakSQLUpita_STR = " WHERE fik.GlavnaKnjiga.ID_GlavnaKnjiga = " + Session["kojaGlavnaZaIspise"] + "";
            string nazivReporta_STR = "";
            StringList sortReporta_STRa = new StringList();
            StringList suma1 = new StringList();
            StringList suma2 = new StringList();
            StringList suma3 = new StringList();
            StringList suma4 = new StringList();
            string zaglavljeReporta = "";
            string dnevnikPo_STR = "";
            bool knjizeno_BOOL = false;
            string periodOD = "", periodDO = "", ugovorOD = "", ugovorDO = "";

            List<InLine.Model.Data.Field.KontniPlanSt> fieldKontniPlanSt = new List<InLine.Model.Data.Field.KontniPlanSt>();
            List<InLine.Model.Data.Filter.KontniPlanSt> filterKontniPlanSt = new List<InLine.Model.Data.Filter.KontniPlanSt>();
            filterKontniPlanSt.Add(new InLine.Model.Data.Filter.KontniPlanSt { Field = InLine.Model.Data.Field.KontniPlanSt.ID_KontniPlan, Value = Session["Kontni"] });
            List<InLine.Model.Data.Sort.KontniPlanSt> sortKontniPlanSt = new List<InLine.Model.Data.Sort.KontniPlanSt>();
            sortKontniPlanSt.Add(new InLine.Model.Data.Sort.KontniPlanSt { Field = InLine.Model.Data.Field.KontniPlanSt.Konto });

            List<InLine.Model.Data.KontniPlanSt> dataKontniPlanStSVI = _serviceKontniPlanSt.GetData(fieldKontniPlanSt, filterKontniPlanSt, sortKontniPlanSt).ToList();
            List<InLine.Model.Data.KontniPlanSt> dataKontniPlanStIZABRANI = new List<Model.Data.KontniPlanSt>();

            if (parametri_STRa[0].Substring(0, 3) == "P:3") //ISPISI ZA GRAD (POČINJU SA 3)
            {
                ostatakSQLUpita_STR = " WHERE ";

                foreach (var parametar in parametri_STRa)
                {
                    string[] dijeloviParametra_STRa = parametar.Split(':');

                    switch (dijeloviParametra_STRa[0])
                    {
                        case "P":
                            string[] nazivReporta_STRa = dijeloviParametra_STRa[1].Split('.');
                            nazivReporta_STR = PutINazivReporta(dijeloviParametra_STRa[1]);
                            break;

                        case "BrUgOD":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.UgovorStanOtkup.BrojUgovor >= " + dijeloviParametra_STRa[1];
                            ugovorOD = dijeloviParametra_STRa[1];
                            break;

                        case "BrUgDO":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.UgovorStanOtkup.BrojUgovor <= " + dijeloviParametra_STRa[1];
                            ugovorDO = dijeloviParametra_STRa[1];
                            break;

                        case "BrNaOD":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.Nalog.BrojNalog >= " + dijeloviParametra_STRa[1];
                            ugovorOD = dijeloviParametra_STRa[1];
                            break;

                        case "BrNaDO":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.Nalog.BrojNalog <= " + dijeloviParametra_STRa[1];
                            ugovorDO = dijeloviParametra_STRa[1];
                            break;

                        case "GodNaOD":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.Nalog.GodinaNalog >= " + dijeloviParametra_STRa[1];
                            ugovorOD = dijeloviParametra_STRa[1];
                            break;

                        case "GodNaDO":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += "ots.Nalog.GodinaNalog <= " + dijeloviParametra_STRa[1];
                            ugovorDO = dijeloviParametra_STRa[1];
                            break;

                        case "DatDosObrOd":
                            string[] dijeloviDatDosOd_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumDos_DTOd = new DateTime(Convert.ToInt32(dijeloviDatDosOd_STRa[2]), Convert.ToInt32(dijeloviDatDosOd_STRa[1]), Convert.ToInt32(dijeloviDatDosOd_STRa[0]));

                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += " ots.UgovorStanOtkupObrok.DatumDospijece >= '" + datumDos_DTOd.ToString("yyyy.MM.dd") + "'";
                            periodOD = datumDos_DTOd.ToString("dd.MM.yyyy");
                            break;

                        case "DatDosObrDo":
                            string[] dijeloviDatDosDo_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumDos_DTDo = new DateTime(Convert.ToInt32(dijeloviDatDosDo_STRa[2]), Convert.ToInt32(dijeloviDatDosDo_STRa[1]), Convert.ToInt32(dijeloviDatDosDo_STRa[0]));

                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += " ots.UgovorStanOtkupObrok.DatumDospijece <= '" + datumDos_DTDo.ToString("yyyy.MM.dd") + "'";
                            periodDO = datumDos_DTDo.ToString("dd.MM.yyyy");
                            break;

                        case "Op":
                            List<string> ostaliP_STRa = dijeloviParametra_STRa[1].Split(',').ToList();

                            foreach (var op in ostaliP_STRa)
                            {
                                switch (op)
                                {
                                    case "0":
                                        if (ostatakSQLUpita_STR != " WHERE ")
                                            ostatakSQLUpita_STR += " AND ";

                                        ostatakSQLUpita_STR += " ots.UgovorStanOtkupKupac.Nositelj = 1 ";
                                        break;
                                }
                            }
                            break;
                        case "Ut":
                            if (ostatakSQLUpita_STR != " WHERE ")
                                ostatakSQLUpita_STR += " AND ";
                            ostatakSQLUpita_STR += " ots.UgovorStanOtkup.UgovorTuzen = 1";
                            break;
                    }
                }
            }
            else //OSTALI ISPISI (NE POČINJU SA 3)
            {

                foreach (var parametar in parametri_STRa)
                {
                    string[] dijeloviParametra_STRa = parametar.Split(':');

                    switch (dijeloviParametra_STRa[0])
                    {
                        case "P":
                            string[] nazivReporta_STRa = dijeloviParametra_STRa[1].Split('.');
                            nazivReporta_STR = PutINazivReporta(dijeloviParametra_STRa[1]);
                            break;

                        case "datOD":
                            string[] dijeloviDatumaOd_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datum_DTOd = new DateTime(Convert.ToInt32(dijeloviDatumaOd_STRa[2]), Convert.ToInt32(dijeloviDatumaOd_STRa[1]), Convert.ToInt32(dijeloviDatumaOd_STRa[0]));

                            ostatakSQLUpita_STR += " AND (fik.Temeljnica.Datum BETWEEN '" + datum_DTOd.ToString("yyyy.MM.dd") + "'";
                            zaglavljeReporta += "DATUM OD: " + datum_DTOd.ToString("dd.MM.yyyy.");
                            break;

                        case "datDO":
                            string[] dijeloviDatumaDo_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datum_DTDo = new DateTime(Convert.ToInt32(dijeloviDatumaDo_STRa[2]), Convert.ToInt32(dijeloviDatumaDo_STRa[1]), Convert.ToInt32(dijeloviDatumaDo_STRa[0]));

                            if (nazivReporta_STR == "1. GLAVNA KNJIGA/1.4. Bilanca/1.4.5. Konto (Račun).mrt")
                                ostatakSQLUpita_STR += " AND '" + datum_DTDo.ToString("yyyy.MM.dd") + "' OR fik.Temeljnica.Datum IS NULL)";
                            else
                                ostatakSQLUpita_STR += " AND '" + datum_DTDo.ToString("yyyy.MM.dd") + "')";

                            zaglavljeReporta += " do: " + datum_DTDo.ToString("dd.MM.yyyy.");
                            break;

                        case "DatDosOd":
                            string[] dijeloviDatDosOd_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumDos_DTOd = new DateTime(Convert.ToInt32(dijeloviDatDosOd_STRa[2]), Convert.ToInt32(dijeloviDatDosOd_STRa[1]), Convert.ToInt32(dijeloviDatDosOd_STRa[0]));

                            ostatakSQLUpita_STR += " AND zps.Zapis.Datum >= '" + datumDos_DTOd.ToString("yyyy.MM.dd") + "'";
                            break;

                        case "DatDosDo":
                            string[] dijeloviDatDosDo_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumDos_DTDo = new DateTime(Convert.ToInt32(dijeloviDatDosDo_STRa[2]), Convert.ToInt32(dijeloviDatDosDo_STRa[1]), Convert.ToInt32(dijeloviDatDosDo_STRa[0]));

                            ostatakSQLUpita_STR += " AND zps.Zapis.Datum <= '" + datumDos_DTDo.ToString("yyyy.MM.dd") + "'";
                            break;

                        case "Kla":
                            string[] dijeloviKlasa_STRa = dijeloviParametra_STRa[1].Split(',');
                            ostatakSQLUpita_STR += " AND (";
                            zaglavljeReporta += "&ensp;&ensp;&ensp; Klase: " + dijeloviParametra_STRa[1].ToString();
                            foreach (var item in dijeloviKlasa_STRa)
                            {
                                ostatakSQLUpita_STR += " konto LIKE '" + item + "%' OR";
                            }
                            if (dijeloviKlasa_STRa.Length != 0)
                            {
                                ostatakSQLUpita_STR = ostatakSQLUpita_STR.Remove(ostatakSQLUpita_STR.LastIndexOf("OR"));
                                ostatakSQLUpita_STR += ")";
                            }

                            break;

                        case "Kon":
                            ostatakSQLUpita_STR += " AND fik.KontniPlanSt.Konto IN (" + dijeloviParametra_STRa[1] + ")";
                            var listaIzabranihKonta = dijeloviParametra_STRa[1].Split(',').ToList();
                            zaglavljeReporta += "&ensp;&ensp;&ensp; KONTO: ";
                            dataKontniPlanStIZABRANI = dataKontniPlanStSVI.Where(x => listaIzabranihKonta.Contains(x.ID_KontniPlanSt.ToString())).ToList();

                            if (listaIzabranihKonta.Count <= 5)
                            {
                                if (listaIzabranihKonta.Count != 0)
                                    zaglavljeReporta += string.Join(",", listaIzabranihKonta);
                            }
                            else
                                zaglavljeReporta += listaIzabranihKonta.Count.ToString() + " izabranih";

                            break;

                        case "PoslP":
                            var listaIzabranihPoslovnihPartnera = dijeloviParametra_STRa[1].Trim().Split(',').ToList();
                            List<string> listaIzabranihPoslovnihPartneraUredena = new List<string>();
                            foreach (var item in listaIzabranihPoslovnihPartnera)
                            {
                                if (item.Contains('-'))
                                {
                                    var razdvojeniBrojevi = item.Split('-');
                                    int prviBroj = Convert.ToInt32(razdvojeniBrojevi[0]);
                                    int drugiBroj = Convert.ToInt32(razdvojeniBrojevi[1]);

                                    for (var a = prviBroj; a <= drugiBroj; a++)
                                    {
                                        listaIzabranihPoslovnihPartneraUredena.Add(a.ToString());
                                    }
                                }
                                else
                                    listaIzabranihPoslovnihPartneraUredena.Add(item);
                            }

                            ostatakSQLUpita_STR += " AND Subjekt2.ID_Subjekt IN (" + string.Join(",", listaIzabranihPoslovnihPartneraUredena) + ")";

                            zaglavljeReporta += "&ensp;&ensp;&ensp; Poslovni partneri: ";

                            if (listaIzabranihPoslovnihPartneraUredena.Count <= 5)
                            {
                                if (listaIzabranihPoslovnihPartneraUredena.Count != 0)
                                    zaglavljeReporta += string.Join(",", listaIzabranihPoslovnihPartneraUredena);
                            }
                            else
                                zaglavljeReporta += listaIzabranihPoslovnihPartneraUredena.Count.ToString() + " izabranih";

                            break;

                        case "VrTm":
                            var listaIzabranihVrstaTemeljnice = dijeloviParametra_STRa[1].Trim().Split(',').ToList();
                            List<string> listaIzabranihVrstaTemeljniceUredena = new List<string>();
                            foreach (var item in listaIzabranihVrstaTemeljnice)
                            {
                                if (item.Contains('-'))
                                {
                                    var razdvojeniBrojevi = item.Split('-');
                                    int prviBroj = Convert.ToInt32(razdvojeniBrojevi[0]);
                                    int drugiBroj = Convert.ToInt32(razdvojeniBrojevi[1]);

                                    for (var a = prviBroj; a <= drugiBroj; a++)
                                    {
                                        listaIzabranihVrstaTemeljniceUredena.Add(a.ToString());
                                    }
                                }
                                else
                                    listaIzabranihVrstaTemeljniceUredena.Add(item);
                            }

                            ostatakSQLUpita_STR += " AND fik.TemeljnicaVr.Oznaka IN (" + string.Join(",", listaIzabranihVrstaTemeljniceUredena) + ")";

                            zaglavljeReporta += "&ensp;&ensp;&ensp; Vrste temeljnice: ";

                            if (listaIzabranihVrstaTemeljniceUredena.Count <= 5)
                            {
                                if (listaIzabranihVrstaTemeljniceUredena.Count != 0)
                                    zaglavljeReporta += string.Join(",", listaIzabranihVrstaTemeljniceUredena);
                            }
                            else
                                zaglavljeReporta += listaIzabranihVrstaTemeljniceUredena.Count.ToString() + " izabranih";

                            break;

                        case "VrDok":
                            var listaIzabranihVrstaDokumenta = dijeloviParametra_STRa[1].Trim().Split(',').ToList();
                            List<string> listaIzabranihVrstaDokumentaUredena = new List<string>();
                            foreach (var item in listaIzabranihVrstaDokumenta)
                            {
                                if (item.Contains('-'))
                                {
                                    var razdvojeniBrojevi = item.Split('-');
                                    int prviBroj = Convert.ToInt32(razdvojeniBrojevi[0]);
                                    int drugiBroj = Convert.ToInt32(razdvojeniBrojevi[1]);

                                    for (var a = prviBroj; a <= drugiBroj; a++)
                                    {
                                        listaIzabranihVrstaDokumentaUredena.Add(a.ToString());
                                    }
                                }
                                else
                                    listaIzabranihVrstaDokumentaUredena.Add(item);
                            }

                            ostatakSQLUpita_STR += " AND sis.ZapisVr.IDZapisVr IN (" + string.Join(",", listaIzabranihVrstaDokumentaUredena) + ")";

                            zaglavljeReporta += "&ensp;&ensp;&ensp; Vrste dokumenta: ";

                            if (listaIzabranihVrstaDokumentaUredena.Count <= 5)
                            {
                                if (listaIzabranihVrstaDokumentaUredena.Count != 0)
                                    zaglavljeReporta += string.Join(",", listaIzabranihVrstaDokumentaUredena);
                            }
                            else
                                zaglavljeReporta += listaIzabranihVrstaDokumentaUredena.Count.ToString() + " izabranih";

                            break;

                        case "Kr":
                            var listaIzabranihKriterija = dijeloviParametra_STRa[1].Split(',').ToList();

                            List<string> listaIzabranihKriterijaUredena = new List<string>();
                            foreach (var item in listaIzabranihKriterija)
                            {
                                if (item.Contains('-'))
                                {
                                    var razdvojeniBrojevi = item.Split('-');
                                    int prviBroj = Convert.ToInt32(razdvojeniBrojevi[0]);
                                    int drugiBroj = Convert.ToInt32(razdvojeniBrojevi[1]);

                                    for (var a = prviBroj; a <= drugiBroj; a++)
                                    {
                                        listaIzabranihKriterijaUredena.Add(a.ToString());
                                    }
                                }
                                else
                                    listaIzabranihKriterijaUredena.Add(item);
                            }

                            ostatakSQLUpita_STR += " AND fik.KriterijSt.ID_KriterijSt IN (" + string.Join(",", listaIzabranihKriterijaUredena) + ")";

                            List<InLine.Model.Data.Field.Kriterij> fieldKriterij = new List<InLine.Model.Data.Field.Kriterij>();
                            List<InLine.Model.Data.Filter.Kriterij> filterKriterij = new List<InLine.Model.Data.Filter.Kriterij>();
                            filterKriterij.Add(new InLine.Model.Data.Filter.Kriterij { Field = InLine.Model.Data.Field.Kriterij.ID_KontniPlan, Value = Session["Kontni"] });
                            List<InLine.Model.Data.Sort.Kriterij> sortKriterij = new List<InLine.Model.Data.Sort.Kriterij>();

                            List<InLine.Model.Data.Kriterij> dataKriterij = _serviceKriterij.GetData(fieldKriterij, filterKriterij, sortKriterij).ToList();

                            foreach (var kriteriji in dataKriterij)
                            {
                                List<InLine.Model.Data.Field.KriterijSt> fieldKriterijSt = new List<InLine.Model.Data.Field.KriterijSt>();
                                List<InLine.Model.Data.Filter.KriterijSt> filterKriterijSt = new List<InLine.Model.Data.Filter.KriterijSt>();
                                filterKriterijSt.Add(new InLine.Model.Data.Filter.KriterijSt { Field = InLine.Model.Data.Field.KriterijSt.ID_Kriterij, Value = kriteriji.ID_Kriterij });
                                List<InLine.Model.Data.Sort.KriterijSt> sortKriterijSt = new List<InLine.Model.Data.Sort.KriterijSt>();
                                sortKriterijSt.Add(new InLine.Model.Data.Sort.KriterijSt { Field = InLine.Model.Data.Field.KriterijSt.Oznaka });

                                List<InLine.Model.Data.KriterijSt> dataKriterijSt = _serviceKriterijSt.GetData(fieldKriterijSt, filterKriterijSt, sortKriterijSt).ToList();

                                var listaIzabranihDataKriterij = dataKriterijSt.Where(x => listaIzabranihKriterijaUredena.Contains(x.ID_KriterijSt.ToString())).ToList();
                                if (listaIzabranihDataKriterij.Count <= 5 && listaIzabranihDataKriterij.Count > 0)
                                {
                                    zaglavljeReporta += "&ensp;&ensp;&ensp; " + kriteriji.Kratica + ": ";
                                    foreach (var item in listaIzabranihDataKriterij)
                                    {
                                        zaglavljeReporta += item.Oznaka + ", ";
                                    }
                                    if (listaIzabranihDataKriterij.Count != 0)
                                        zaglavljeReporta = zaglavljeReporta.Remove(zaglavljeReporta.LastIndexOf(','));
                                }
                                else if (listaIzabranihDataKriterij.Count != 0)
                                {
                                    zaglavljeReporta += kriteriji.Kratica + ": ";
                                    zaglavljeReporta += listaIzabranihDataKriterij.Count.ToString() + " izabranih";
                                }
                            }
                            break;

                        case "BrTmOD":
                            ostatakSQLUpita_STR += " AND fik.Temeljnica.Oznaka >= " + dijeloviParametra_STRa[1];
                            break;

                        case "BrTmDO":
                            ostatakSQLUpita_STR += " AND fik.Temeljnica.Oznaka <= " + dijeloviParametra_STRa[1];
                            break;

                        case "DatPPOd":
                            string[] dijeloviDatPPOd_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumPP_DTOd = new DateTime(Convert.ToInt32(dijeloviDatPPOd_STRa[2]), Convert.ToInt32(dijeloviDatPPOd_STRa[1]), Convert.ToInt32(dijeloviDatPPOd_STRa[0]));

                            ostatakSQLUpita_STR += " AND fik.TemeljnicaSt.Datum >= '" + datumPP_DTOd.ToString("yyyy.MM.dd") + "'";
                            break;

                        case "DatPPDo":
                            string[] dijeloviDatPPDo_STRa = dijeloviParametra_STRa[1].Split('.');
                            DateTime datumPP_DTDo = new DateTime(Convert.ToInt32(dijeloviDatPPDo_STRa[2]), Convert.ToInt32(dijeloviDatPPDo_STRa[1]), Convert.ToInt32(dijeloviDatPPDo_STRa[0]));

                            ostatakSQLUpita_STR += " AND fik.TemeljnicaSt.Datum <= '" + datumPP_DTDo.ToString("yyyy.MM.dd") + "'";
                            break;

                        case "Is":
                            if (dijeloviParametra_STRa[1] == "0")
                            {
                                knjizeno_BOOL = true;
                                ostatakSQLUpita_STR += " AND fik.Temeljnica.Knjizeno = 1";
                            }
                            else if (dijeloviParametra_STRa[1] == "1")
                                ostatakSQLUpita_STR += " AND fik.Temeljnica.Knjizeno = 0";

                            break;

                        case "DnePo":
                            zaglavljeReporta += "&ensp;&ensp;&ensp; Dnevnik po: ";

                            switch (dijeloviParametra_STRa[1])
                            {
                                case "0":
                                    dnevnikPo_STR = "DataSource1.DatumTemeljnica";
                                    zaglavljeReporta += "Datumu temeljnice ";
                                    break;

                                case "1":
                                    dnevnikPo_STR = "DataSource1.DatumKnjizenje";
                                    zaglavljeReporta += "Datumu knjiženja ";
                                    break;

                                case "2":
                                    dnevnikPo_STR = "DataSource1.DatumTemeljnicaSt";
                                    zaglavljeReporta += "Datumu poslovne promjene ";
                                    break;
                            }
                            break;

                        case "Pp":
                            List<string> sort_STRa = dijeloviParametra_STRa[1].Split(',').ToList();
                            zaglavljeReporta += "&ensp;&ensp;&ensp; Poredak: ";

                            foreach (var sort in sort_STRa)
                            {
                                switch (sort)
                                {
                                    case "0":
                                        sortReporta_STRa.Add("RedniBrojTemeljnicaSt");
                                        zaglavljeReporta += "Broj stavke, ";
                                        break;

                                    case "1":
                                        sortReporta_STRa.Add("OpisTemeljnicaSt");
                                        zaglavljeReporta += "Opis knjiženja, ";
                                        break;

                                    case "2":
                                        sortReporta_STRa.Add("DatumTemeljnicaSt");
                                        zaglavljeReporta += "Datum posl. prom., ";
                                        break;

                                    case "3":
                                        sortReporta_STRa.Add("KontoKontniPlanSt");
                                        zaglavljeReporta += "Konto, ";
                                        break;

                                    case "4":
                                        sortReporta_STRa.Add("___POSLOVNIPARTNER___");
                                        zaglavljeReporta += "Poslovni partner, ";
                                        break;

                                    case "5":
                                        sortReporta_STRa.Add("___DOKUMENT___");
                                        zaglavljeReporta += "Dokument, ";
                                        break;

                                    case "6":
                                        sortReporta_STRa.Add("DatumTemeljnica");
                                        zaglavljeReporta += "Datum temeljnice, ";
                                        break;

                                    case "7":
                                        sortReporta_STRa.Add("OznakaTemeljnicaVr");
                                        zaglavljeReporta += "Vrsta temeljnice, ";
                                        break;

                                    case "8":
                                        sortReporta_STRa.Add("___BROJ DOKUMENTA___");
                                        zaglavljeReporta += "Broj dokumenta, ";
                                        break;

                                    case "9":
                                        sortReporta_STRa.Add("OznakaTemeljnica");
                                        zaglavljeReporta += "Broj temeljnice, ";
                                        break;

                                    case "10":
                                        sortReporta_STRa.Add("DatumKnjizenja");
                                        zaglavljeReporta += "Datum knjiženja, ";
                                        break;
                                }
                            }
                            zaglavljeReporta = zaglavljeReporta.Remove(zaglavljeReporta.LastIndexOf(','));
                            break;

                        case "Op":
                            List<string> ostaliP_STRa = dijeloviParametra_STRa[1].Split(',').ToList();

                            foreach (var op in ostaliP_STRa)
                            {
                                switch (op)
                                {
                                    case "0":
                                        //NEUSKLAĐENE TEMELJNICE
                                        break;

                                    case "1":
                                        //SVAKI KONTO NA NOVU STRANU
                                        break;

                                    case "2":
                                        ostatakSQLUpita_STR += " AND fik.KontniPlanSt.SaldoKonti = 1";
                                        break;
                                }
                            }
                            break;

                        case "Sum":
                            List<string> Suma_STRa = dijeloviParametra_STRa[1].Split(',').ToList();

                            foreach (var sum in Suma_STRa)
                            {
                                switch (sum)
                                {
                                    case "0":

                                        var result1 = dataKontniPlanStIZABRANI.Select(m => m.Konto.Substring(0, 1)).Distinct().ToList();
                                        if (dataKontniPlanStIZABRANI.Count == 0)
                                            result1 = dataKontniPlanStSVI.Select(m => m.Konto.Substring(0, 1)).Distinct().ToList();
                                        foreach (var item in dataKontniPlanStSVI.Where(x => result1.Contains(x.Konto)).OrderBy(y => y.Konto).ToList())
                                        {
                                            suma1.Add(item.Naziv);
                                        }
                                        break;

                                    case "1":
                                        var result2 = dataKontniPlanStIZABRANI.Where(y => y.Konto.Length > 1).Select(m => m.Konto.Substring(0, 2)).Distinct().ToList();
                                        if (dataKontniPlanStIZABRANI.Count == 0)
                                            result2 = dataKontniPlanStSVI.Where(y => y.Konto.Length > 1).Select(m => m.Konto.Substring(0, 2)).Distinct().ToList();
                                        foreach (var item in dataKontniPlanStSVI.Where(x => result2.Contains(x.Konto)).OrderBy(y => y.Konto).ToList())
                                        {
                                            suma2.Add(item.Naziv);
                                        }
                                        break;

                                    case "2":
                                        var result3 = dataKontniPlanStIZABRANI.Where(y => y.Konto.Length > 2).Select(m => m.Konto.Substring(0, 3)).Distinct().ToList();
                                        if (dataKontniPlanStIZABRANI.Count == 0)
                                            result3 = dataKontniPlanStSVI.Where(y => y.Konto.Length > 2).Select(m => m.Konto.Substring(0, 3)).Distinct().ToList();
                                        foreach (var item in dataKontniPlanStSVI.Where(x => result3.Contains(x.Konto)).OrderBy(y => y.Konto).ToList())
                                        {
                                            suma3.Add(item.Naziv);
                                        }
                                        break;

                                    case "3":
                                        var result4 = dataKontniPlanStIZABRANI.Where(y => y.Konto.Length > 3).Select(m => m.Konto.Substring(0, 4)).Distinct().ToList();
                                        if (dataKontniPlanStIZABRANI.Count == 0)
                                            result4 = dataKontniPlanStSVI.Where(y => y.Konto.Length > 3).Select(m => m.Konto.Substring(0, 4)).Distinct().ToList();
                                        foreach (var item in dataKontniPlanStSVI.Where(x => result4.Contains(x.Konto)).OrderBy(y => y.Konto).ToList())
                                        {
                                            suma4.Add(item.Naziv);
                                        }
                                        break;

                                }
                            }
                            break;
                    }
                }
            }

            StiReport report = new StiReport();
            report.Load(Server.MapPath("~/Content/Reporti/IspisiFinancijsko/" + nazivReporta_STR));

            if (dnevnikPo_STR != "")
            {
                StiGroupHeaderBand groupHeader = report.GetComponentByName("GroupHeaderBand2") as StiGroupHeaderBand;
                groupHeader.Condition = new StiGroupConditionExpression("{" + dnevnikPo_STR + "}");

                StiText stiTextHeader = report.GetComponentByName("TextGroupHeader") as StiText;
                stiTextHeader.Text = "{" + dnevnikPo_STR + ".ToString(\"dd.MM.yyyy.\")}";

                StiText stiTextFooter = report.GetComponentByName("TextGroupFooter") as StiText;
                stiTextFooter.Text = "Ukupno za: {" + dnevnikPo_STR + ".ToString(\"dd.MM.yyyy.\")}";

            }

            report.Compile();
            report["ostatakSQLUpita_STR"] = ostatakSQLUpita_STR;
            report["Sort"] = sortReporta_STRa;
            report["Suma1"] = suma1;
            report["Suma2"] = suma2;
            report["Suma3"] = suma3;
            report["Suma4"] = suma4;
            report["brojOD"] = ugovorOD;
            report["brojDO"] = ugovorDO;
            report["periodOD"] = periodOD;
            report["periodDO"] = periodDO;
            report["Zaglavlje"] = zaglavljeReporta;
            report["Knjizeno_BOOL"] = knjizeno_BOOL;

            report["dnevnikPo"] = dnevnikPo_STR;

            report.Render();

            return StiMvcMobileViewer.GetReportSnapshotResult(HttpContext, report);
        }

        public ActionResult ViewerEvent()
        {
            return StiMvcMobileViewer.ViewerEventResult(HttpContext);
        }

        public ActionResult PrintReport()
        {
            return StiMvcMobileViewer.PrintReportResult(HttpContext);
        }

        public FileResult ExportReport()
        {
            return StiMvcMobileViewer.ExportReportResult(HttpContext);
        }

        public string PutINazivReporta(string sifraReporta_STR)
        {
            string izlaz = "";
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(Server.MapPath("~/Content/Reporti/IspisiFinancijsko/"));
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles(sifraReporta_STR + "*.mrt", SearchOption.AllDirectories);

            foreach (FileInfo foundFile in filesInDir)
            {
                izlaz = foundFile.Directory.Parent.Name + "/" + foundFile.Directory.Name + "/" + foundFile.Name;
            }

            return izlaz;
        }

        #endregion
    }



    # region PomocneKlase

    public class Folder
    {
        public Folder()
        {
            this.Subfolders = new List<Folder>();
        }

        public long ID_KriterijSt { get; set; }
        public string KriterijStNaziv { get; set; }
        public long ID_Kriterij { get; set; }
        public string KriterijNaziv { get; set; }
        public IList<IDKriterijNaziv> KriterijNazivList { get; set; }
        public bool Nulti { get; set; }
        public IList<Folder> Subfolders { get; set; }
        public bool IsChecked { get; set; }
        public bool IsKriterijObavezanFolder { get; set; }
        public bool IsLeaf
        {
            get
            {
                return this.Subfolders.Count == 0;
            }
        }

    }

    public class IDKriterijNaziv
    {
        public long ID_Kriterij { get; set; }
        public string Naziv { get; set; }
    }

    public class KriterijFolder
    {
        public long? ID_TemeljnicaSt { get; set; }
        public long? ID_KontniPlanSt { get; set; }
        public long KojiKriterij { get; set; }
        public long KontniPlan { get; set; }
        public IList<IDKriterijNaziv> KojiKriterijList { get; set; }
        public IList<Folder> Folderi { get; set; }
        public bool IsKriterijObavezan { get; set; }

    }

    public class KriterijKriterijstTreeViewModel
    {
        public List<long> ID_KriterijList { get; set; }
        public List<IDKriterijNaziv> IDKriterijNaziv { get; set; }
        public IEnumerable<InLine.Model.Data.View.KriterijStKriterijStKriterijSt> KriterijKriterijStList { get; set; }
    }

    public class KontniPlanKriterijFolder
    {
        public long? ID_TemeljnicaSt { get; set; }
        public long? ID_KontniPlanSt { get; set; }
        public long KojiKriterij { get; set; }
        public long KontniPlan { get; set; }
        public IList<IDKriterijNaziv> KojiKriterijList { get; set; }
        public IList<Folder> Folderi { get; set; }
        public bool IsKriterijObavezan { get; set; }

    }


    public class PosebnaTemeljnicaVr
    {
        public long ID_GlavnaKnjiga { get; set; }
        public long ID_KontniPlan { get; set; }
        public string KontniPlanTemeljnicaVrList { get; set; }
        public IEnumerable<Model.Data.TemeljnicaVrVr> ListaTemeljnicaVrVr { get; set; }
        public IEnumerable<Model.Data.TemeljnicaVr> ListaSveTemeljnica { get; set; }
        public List<SelectedProperties> SelectedProperties { get; set; }
    }


    public class SelectedProperties
    {
        public int VrstaVrsta { get; set; }
        public string VrstaVrstaNaziv { get; set; }
        public long Vrsta { get; set; }
        public string VrstaNaziv { get; set; }
        public bool IsSelected { get; set; }
    }

    # endregion

}



