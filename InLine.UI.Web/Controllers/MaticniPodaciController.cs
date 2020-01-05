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
using System.Xml.Linq;
using System.Xml;
using System.Data.Objects;

namespace InLine.UI.Web.Controllers
{
    public class MaticniPodaciController : InLine.UI.Web.Controllers.View.GlavnaKnjigaKontniPlanPoslovnaGodinaPoslovniSubjektViewController
    {

        # region Konstruktor

  

        Service.Data.View.IPoslovniSubjekt _serviceViewPoslovniSubjekt;
        Service.Data.IPoslovniSubjekt _servicePoslovniSubjekt;

        Service.Data.View.PoslovniSubjektSubjekt _serviceViewPoslovniSubjektSubjekt;

        Service.Data.View.IPoslovnaGodinaPoslovniSubjekt _serviceViewPoslovnaGodinaPoslovniSubjekt;
        Service.Data.View.IPoslovnaGodinaDetalj _serviceViewPoslovnaGodinaDetalj;
        Service.Data.IPoslovnaGodina _servicePoslovnaGodina;

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


        public MaticniPodaciController()
        {
        
        }


        public MaticniPodaciController(Model.Admin.KorisnikData korisnik_data)   
        {
            this.korisnik_data = korisnik_data;
    	}


        #endregion


        #region View

        public ActionResult MaticniPodaci()
        {
            return View();
        }

        public ActionResult PoslovnaGodina()
        {
            return View();
        }

        public ActionResult Tecaj()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.TecajnaListaComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.TecajnaListaComboFormatted();

                var rez = GetBankaOne();
                if (rez != null)
                {
                    rezult.ID_Banka = rez.ID_Banka;

                }

                else
                {
                    rezult.ID_Banka = -1;
                }



                return View(rezult);
        }


        #endregion


        #region PoslovniSubjekt

        public ActionResult PoslovniSubjektGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewPoslovniSubjekt = new Service.Data.View.PoslovniSubjekt(korisnik_data);
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
                        filterExpression = InLine.UI.Web.Controllers.View.PoslovniSubjektViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.PoslovniSubjektViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewPoslovniSubjekt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewPoslovniSubjekt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<PoslovniSubjektGridFormatted>(Convert.ToString(item.ID_PoslovniSubjekt), new PoslovniSubjektGridFormatted(item)));



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

        public ActionResult PoslovniSubjektInsert(long? Id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            bool rezult = false;

            try
            {
                _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);

                if (Id.HasValue)
                {
                    Model.Data.Item.PoslovniSubjektItem item = new Model.Data.Item.PoslovniSubjektItem();
                    item.ID_Subjekt = Id;
                    Model.Data.PoslovniSubjekt insert = _servicePoslovniSubjekt.InsertResult(item);
                    if (insert != null)
                    {
                        rezult = true;
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
            return Json(rezult, JsonRequestBehavior.AllowGet);

        }

        public ActionResult PoslovniPartner()
        {
            return View();
        }

        public ActionResult GetPoslovniPartner(string query)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.PoslovniSubjektSubjekt> rezult = new List<InLine.Model.Data.View.PoslovniSubjektSubjekt>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
             
                _serviceViewPoslovniSubjektSubjekt = new Service.Data.View.PoslovniSubjektSubjekt(korisnik_data);
                List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt> field = new List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt>();
                List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt> filter = new List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt>();
                List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt> sort = new List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt>();
                rezult = _serviceViewPoslovniSubjektSubjekt.GetData(field, filter, sort).Where(p => p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.SubjektVrNaziv.ToUpper().Trim().StartsWith(query.ToUpper())).ToList();
                       

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

        public InLine.Model.Data.View.PoslovniSubjektSubjekt GetSubjekt(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.PoslovniSubjektSubjekt rezult = new InLine.Model.Data.View.PoslovniSubjektSubjekt();


            try
            {
                _serviceViewPoslovniSubjektSubjekt = new Service.Data.View.PoslovniSubjektSubjekt(korisnik_data);
                List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt> field = new List<InLine.Model.Data.Field.View.PoslovniSubjektSubjekt>();
                List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt> filter = new List<InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt>();
                List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt> sort = new List<InLine.Model.Data.Sort.View.PoslovniSubjektSubjekt>();
                filter.Add(new InLine.Model.Data.Filter.View.PoslovniSubjektSubjekt { Field = InLine.Model.Data.Field.View.PoslovniSubjektSubjekt.ID_Subjekt, Value = id });
                rezult = _serviceViewPoslovniSubjektSubjekt.GetData(field, filter, sort).SingleOrDefault();
                       

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


        #region PoslovnaGodina

        public ActionResult PoslovnaGodinaPoslovniSubjektGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewPoslovnaGodinaPoslovniSubjekt = new Service.Data.View.PoslovnaGodinaPoslovniSubjekt(korisnik_data);
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
                        filterExpression = InLine.UI.Web.Controllers.View.PoslovnaGodinaPoslovniSubjektViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.PoslovnaGodinaPoslovniSubjektViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewPoslovnaGodinaPoslovniSubjekt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewPoslovnaGodinaPoslovniSubjekt.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<PoslovnaGodinaPoslovniSubjektGridFormatted>(Convert.ToString(item.ID_PoslovnaGodina), new PoslovnaGodinaPoslovniSubjektGridFormatted(item)));



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

        public ActionResult PoslovnaGodinaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewPoslovnaGodinaDetalj = new Service.Data.View.PoslovnaGodinaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.PoslovnaGodinaDetaljFormFormatted rezult;

            //_serviceValuta = new Service.Data.Valuta(korisnik_data);
            //var IDValuta = _serviceValuta.SelectResult(null).Select(c => c.IDValuta).ToList();
            //ViewBag.IDValuta = new SelectList(IDValuta.AsEnumerable(), InLine.Model.Data.FieldString.Valuta.IDValuta);

            _serviceValuta = new Service.Data.Valuta(korisnik_data);
            List<SelectListItem> IDValutaCombo = new List<SelectListItem>();
            IDValutaCombo = _serviceValuta.SelectResult(null).Select(c => new SelectListItem() { Value = c.IDValuta.ToString(), Text = c.IDValuta + " " + c.Naziv }).ToList();
            ViewBag.IDValuta = new SelectList(IDValutaCombo.AsEnumerable(), KeyWord.Combo.Rijec.Value, KeyWord.Combo.Rijec.Text);

            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.PoslovnaGodinaDetalj> field = new List<InLine.Model.Data.Field.View.PoslovnaGodinaDetalj>();
                List<InLine.Model.Data.Filter.View.PoslovnaGodinaDetalj> filter = new List<InLine.Model.Data.Filter.View.PoslovnaGodinaDetalj>();
                List<InLine.Model.Data.Sort.View.PoslovnaGodinaDetalj> sort = new List<InLine.Model.Data.Sort.View.PoslovnaGodinaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.PoslovnaGodinaDetalj { Field = InLine.Model.Data.Field.View.PoslovnaGodinaDetalj.ID_PoslovnaGodina, Value = Convert.ToInt64(Id) });
                var item = _serviceViewPoslovnaGodinaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.PoslovnaGodinaDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.PoslovnaGodinaDetaljFormFormatted();
                if (IdMaster != null)
                {
                    rezult.ID_PoslovniSubjekt = Convert.ToInt64(IdMaster);
                }
                rezult.ID_PoslovnaGodina = -1;
                rezult.Godina = DateTime.Now.Year;
                rezult.DatumOd = new DateTime(DateTime.Now.Year, 1, 1).Date;
                rezult.DatumDo = new DateTime(DateTime.Now.Year, 12, 31).Date;
            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PoslovnaGodinaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.PoslovnaGodinaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _servicePoslovnaGodina = new Service.Data.PoslovnaGodina(korisnik_data);


                if (viewmodel.ID_PoslovnaGodina == -1)
                {
                    Model.Data.Item.PoslovnaGodinaItem item = new Model.Data.Item.PoslovnaGodinaItem(viewmodel);
                    item.ID_PoslovniSubjekt = viewmodel.ID_PoslovniSubjekt;
                    Model.Data.PoslovnaGodina insert = _servicePoslovnaGodina.InsertResult(item);
                }
                else
                {
                    Model.Data.PoslovnaGodina model = _servicePoslovnaGodina.FindID(viewmodel.ID_PoslovnaGodina);

                    if (model != null)
                    {
                        Model.Data.Item.PoslovnaGodinaItem item = new Model.Data.Item.PoslovnaGodinaItem(viewmodel);
                        Model.Data.PoslovnaGodina update = _servicePoslovnaGodina.UpdateResult(item);
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

        public ActionResult PoslovnaGodinaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.PoslovnaGodinaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _servicePoslovnaGodina = new Service.Data.PoslovnaGodina(korisnik_data);

                if (viewmodel.ID_PoslovnaGodina != -1)
                {
                    Model.Data.Item.PoslovnaGodinaItem item = new Model.Data.Item.PoslovnaGodinaItem();

                    if (id != null)
                    {
                        item.ID_PoslovnaGodina = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_PoslovnaGodina = viewmodel.ID_PoslovnaGodina;
                    }
                 
                    int delete = _servicePoslovnaGodina.DeleteResult(item);
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


        # region Tecaj

        public ActionResult GetBanka(string query, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.Banka> rezult = new List<InLine.Model.Data.Banka>();

            //query = query.Replace(" ", "");

            query = query.TrimStart();

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceBanka = new Service.Data.Banka(korisnik_data);
                List<InLine.Model.Data.Field.Banka> field = new List<InLine.Model.Data.Field.Banka>();
                List<InLine.Model.Data.Filter.Banka> filter = new List<InLine.Model.Data.Filter.Banka>();
                List<InLine.Model.Data.Sort.Banka> sort = new List<InLine.Model.Data.Sort.Banka>();
                sort.Add(new InLine.Model.Data.Sort.Banka { Field = InLine.Model.Data.Field.Banka.Naziv, Descending = false });
                rezult = _serviceBanka.GetData(field, filter, sort).Where(p => p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
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

        public ActionResult GetBankaDefault()
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            InLine.Model.Data.Banka item = new InLine.Model.Data.Banka();
            var rezult = new InLine.Model.Data.Banka();

            try
            {

                item = GetBankaOne();

                rezult = new InLine.Model.Data.Banka()
                {
                    ID_Banka = item.ID_Banka,
                    ID_Subjekt = item.ID_Subjekt,
                    Oznaka = item.Oznaka,
                    Naziv = item.Naziv,
                    NazivKr = item.NazivKr,
                    Kratica = item.Kratica,
                    VBDI = item.VBDI,
                    Swift = item.Swift,
                    DealingCode = item.DealingCode,
                    FINAModel = item.FINAModel,
                    OIB = item.OIB

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

        public InLine.Model.Data.Banka GetBankaOne()
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.Banka rezult = new InLine.Model.Data.Banka();

            try
            {
                _serviceBanka = new Service.Data.Banka(korisnik_data);
                List<InLine.Model.Data.Field.Banka> field = new List<InLine.Model.Data.Field.Banka>();
                List<InLine.Model.Data.Filter.Banka> filter = new List<InLine.Model.Data.Filter.Banka>();
                List<InLine.Model.Data.Sort.Banka> sort = new List<InLine.Model.Data.Sort.Banka>();
                rezult = _serviceBanka.GetData(field, filter, sort).Where(p => p.Oznaka.Trim() == "000201").FirstOrDefault();
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


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TecajListaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewTecajLista = new Service.Data.View.TecajLista(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.TecajListaViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.TecajListaViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewTecajLista.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewTecajLista.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<TecajListaGridFormatted>(Convert.ToString(item.ID_TecajLista), new TecajListaGridFormatted(item)));



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

        public ActionResult TecajListaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewTecajListaDetalj = new Service.Data.View.TecajListaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaDetaljFormFormatted rezult;


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.TecajListaDetalj> field = new List<InLine.Model.Data.Field.View.TecajListaDetalj>();
                List<InLine.Model.Data.Filter.View.TecajListaDetalj> filter = new List<InLine.Model.Data.Filter.View.TecajListaDetalj>();
                List<InLine.Model.Data.Sort.View.TecajListaDetalj> sort = new List<InLine.Model.Data.Sort.View.TecajListaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.TecajListaDetalj { Field = InLine.Model.Data.Field.View.TecajListaDetalj.ID_TecajLista, Value = Convert.ToInt64(Id) });
                var item = _serviceViewTecajListaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaDetaljFormFormatted();
                rezult.ID_TecajLista = -1;
                rezult.Datum = DateTime.Now;

                Model.Data.TecajLista tl = UzmiAkoPostojiTecajnaListaNaDanasnjiDan();

                if (tl.ID_TecajLista != -1)
                {
                    rezult.RedniBroj = tl.RedniBroj + 1;
                    rezult.GodinaRedniBroj = tl.GodinaRedniBroj;
                }
                else
                {
                    rezult.RedniBroj = 1;
                    rezult.GodinaRedniBroj = 1;
                }

             
                if (IdMaster != null)
                {
                    rezult.ID_Banka = Convert.ToInt64(IdMaster);
                }
               
                //_serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                //int? MaxRedniBrojGodina = _serviceTecajLista.SelectResult(null).Where(p => p.Datum == DateTime.Now.AddDays(1)).Select(p => p.GodinaRedniBroj).Max();

                if (IdMaster != null)
                {
                }


            }

            return PartialView(rezult);
        }


        public Model.Data.TecajLista UzmiAkoPostojiTecajnaListaNaDanasnjiDan()
        {
            Model.Data.TecajLista rezult = new Model.Data.TecajLista();
            String BankaNaziv = "Narodna banka Hrvatske";

            _serviceBanka = new Service.Data.Banka(korisnik_data);
            InLine.Model.Data.Banka bank = _serviceBanka.SelectResult(null).Where(p => p.Naziv.Trim().ToUpper().Contains(BankaNaziv.Trim().ToUpper())).FirstOrDefault();

            if (bank != null)
            {
                _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);
                List<Model.Data.TecajLista> tl = _serviceTecajLista.SelectResult(null).Where(p => p.ID_Banka == bank.ID_Banka && p.Datum == DateTime.Now.Date).ToList();

                if (tl != null)
                {
                    rezult = tl.OrderByDescending(p => p.RedniBroj).FirstOrDefault();
                }
            }

            return rezult;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TecajListaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);

                if (viewmodel.ID_TecajLista == -1)
                {
                    Model.Data.Item.TecajListaItem item = new Model.Data.Item.TecajListaItem(viewmodel);
                    item.Godina = viewmodel.Datum.Year;
                    Model.Data.TecajLista insert = _serviceTecajLista.InsertResult(item);
                }
                else
                {
                    Model.Data.TecajLista model = _serviceTecajLista.FindID(viewmodel.ID_TecajLista);

                    if (model != null)
                    {
                        Model.Data.Item.TecajListaItem item = new Model.Data.Item.TecajListaItem(viewmodel);
                        Model.Data.TecajLista update = _serviceTecajLista.UpdateResult(item);
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

        public ActionResult TecajListaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = new List<Model.Admin.StatusPoruka>();

            try
            {
                _serviceTecajLista = new Service.Data.TecajLista(korisnik_data);

                if (viewmodel.ID_TecajLista != -1)
                {
                    Model.Data.Item.TecajListaItem item = new Model.Data.Item.TecajListaItem();

                    if (id != null)
                    {
                        item.ID_TecajLista = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_TecajLista = viewmodel.ID_TecajLista;
                    }

                    int delete = _serviceTecajLista.DeleteResult(item);
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
        public ActionResult TecajListaStGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewTecajListaSt = new Service.Data.View.TecajListaSt(korisnik_data);
                string filterExpression = String.Empty;

                if (String.IsNullOrEmpty(value))
                {
                    key = null;
                }

                bool customsearch = false;

                if (request.Searching)
                {
                    if (request.SearchingFilter != null)
                        filterExpression = InLine.UI.Web.Controllers.View.TecajListaStViewController.GetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(InLine.UI.Web.Controllers.View.TecajListaStViewController.GetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewTecajListaSt.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewTecajListaSt.GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<TecajListaStGridFormatted>(Convert.ToString(item.ID_TecajListaSt), new TecajListaStGridFormatted(item)));



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

        public ActionResult TecajListaStDetalj(long? Id, long? IdMaster)
        {
            _serviceViewTecajListaStDetalj = new Service.Data.View.TecajListaStDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaStDetaljFormFormatted rezult;


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.TecajListaStDetalj> field = new List<InLine.Model.Data.Field.View.TecajListaStDetalj>();
                List<InLine.Model.Data.Filter.View.TecajListaStDetalj> filter = new List<InLine.Model.Data.Filter.View.TecajListaStDetalj>();
                List<InLine.Model.Data.Sort.View.TecajListaStDetalj> sort = new List<InLine.Model.Data.Sort.View.TecajListaStDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.TecajListaStDetalj { Field = InLine.Model.Data.Field.View.TecajListaStDetalj.ID_TecajListaSt, Value = Convert.ToInt64(Id) });
                var item = _serviceViewTecajListaStDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaStDetaljFormFormatted(item);
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaStDetaljFormFormatted();
                rezult.ID_TecajListaSt = -1;

                if (IdMaster != null)
                {
                    rezult.ID_TecajLista = Convert.ToInt64(IdMaster);
                }
                else
                {
                    rezult.ID_TecajLista = 0;
                }
            
                rezult.TecajSD = 1;
                rezult.TecajKD = 1;
                rezult.TecajPD = 1;
                rezult.TecajKE = 1;
                rezult.TecajPE = 1;
                rezult.BrojJedinica = 1;
                rezult.IDDrzavaIz = "EU";
                rezult.IDDrzavaU = "HR";
                rezult.IDValutaIz = "EUR";
                rezult.IDValutaU = "HRK";
                rezult.ValutaIz = "EUR";
                rezult.ValutaU = "HRK";

                _serviceTecajVr = new Service.Data.TecajVr(korisnik_data);
                IEnumerable<InLine.Model.Data.TecajVr> tecajVr = _serviceTecajVr.SelectResult(null).ToList();

                if (tecajVr != null)
                {
                    rezult.ID_TecajVrSD = tecajVr.Where(p => p.Oznaka == "SD").Select(p => p.ID_TecajVr).FirstOrDefault();
                    rezult.ID_TecajVrKD = tecajVr.Where(p => p.Oznaka == "KD").Select(p => p.ID_TecajVr).FirstOrDefault();
                    rezult.ID_TecajVrPD = tecajVr.Where(p => p.Oznaka == "PD").Select(p => p.ID_TecajVr).FirstOrDefault();
                    rezult.ID_TecajVrKE = tecajVr.Where(p => p.Oznaka == "KE").Select(p => p.ID_TecajVr).FirstOrDefault();
                    rezult.ID_TecajVrPE = tecajVr.Where(p => p.Oznaka == "PE").Select(p => p.ID_TecajVr).FirstOrDefault();
                }
                

            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TecajListaStInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaStDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTecajListaSt = new Service.Data.TecajListaSt(korisnik_data);

                string Tecaj = "Tecaj";
                string IDTecaj = "ID_Tecaj";
                string IDTecajVr = "ID_TecajVr";
                string Tecaj6 = "Tecaj6";


                if (viewmodel.ID_TecajListaSt == -1)
                {

                    Model.Data.TecajListaSt item = new Model.Data.TecajListaSt();
                    item.ID_TecajLista = viewmodel.ID_TecajLista;
                    item.IDDrzavaIz = viewmodel.IDDrzavaIz;
                    item.IDDrzavaU = viewmodel.IDDrzavaU;
                    item.IDValutaIz = viewmodel.IDValutaIz;
                    item.IDValutaU = viewmodel.IDValutaU;
                    item.BrojJedinica = viewmodel.BrojJedinica;

            
                    XDocument listaTecaj = new XDocument(
                    new XElement("Tecajevi",
                      new XElement(Tecaj,
                            new XElement(IDTecajVr, viewmodel.ID_TecajVrSD.ToString()),
                            new XElement(Tecaj6, viewmodel.TecajSD.ToString().Replace(',', '.'))
                    ),
                       new XElement(Tecaj,
                            new XElement(IDTecajVr, viewmodel.ID_TecajVrKD.ToString()),
                            new XElement(Tecaj6, viewmodel.TecajKD.ToString().Replace(',', '.'))
                    ),
                       new XElement(Tecaj,
                            new XElement(IDTecajVr, viewmodel.ID_TecajVrPD.ToString()),
                            new XElement(Tecaj6, viewmodel.TecajPD.ToString().Replace(',', '.'))
                    ),
                       new XElement(Tecaj,
                            new XElement(IDTecajVr, viewmodel.ID_TecajVrKE.ToString()),
                            new XElement(Tecaj6, viewmodel.TecajKE.ToString().Replace(',', '.'))
                    ),
                       new XElement(Tecaj,
                            new XElement(IDTecajVr, viewmodel.ID_TecajVrPE.ToString()),
                            new XElement(Tecaj6, viewmodel.TecajPE.ToString().Replace(',', '.'))
                    )
                  
                 )
            );

                    String data = listaTecaj.ToString();
                    ObjectResult<Model.Data.TecajListaSt> insert2 = _serviceTecajListaSt.TecajnaListaStInsert_Complex(item, data);

                }
                else
                {
                    Model.Data.TecajListaSt model = _serviceTecajListaSt.FindID(viewmodel.ID_TecajListaSt);

                    if (model != null)
                    {
                        Model.Data.TecajListaSt item = new Model.Data.TecajListaSt();
                        item.ID_TecajListaSt = model.ID_TecajListaSt;
                        item.ID_TecajLista = viewmodel.ID_TecajLista;
                        item.IDDrzavaIz = viewmodel.IDDrzavaIz;
                        item.IDDrzavaU = viewmodel.IDDrzavaU;
                        item.IDValutaIz = viewmodel.IDValutaIz;
                        item.IDValutaU = viewmodel.IDValutaU;
                        item.BrojJedinica = viewmodel.BrojJedinica;

                        XDocument listaTecaj = new XDocument(
                        new XElement("Tecajevi",
                          new XElement(Tecaj,
                                new XElement(IDTecaj, viewmodel.ID_TecajSD.ToString()),
                                new XElement(IDTecajVr, viewmodel.ID_TecajVrSD.ToString()),
                                new XElement(Tecaj6, viewmodel.TecajSD.ToString().Replace(',', '.'))
                        ),
                           new XElement(Tecaj,
                               new XElement(IDTecaj, viewmodel.ID_TecajKD.ToString()),
                                new XElement(IDTecajVr, viewmodel.ID_TecajVrKD.ToString()),
                                new XElement(Tecaj6, viewmodel.TecajKD.ToString().Replace(',', '.'))
                        ),
                           new XElement(Tecaj,
                               new XElement(IDTecaj, viewmodel.ID_TecajPD.ToString()),
                                new XElement(IDTecajVr, viewmodel.ID_TecajVrPD.ToString()),
                                new XElement(Tecaj6, viewmodel.TecajPD.ToString().Replace(',', '.'))
                        ),
                           new XElement(Tecaj,
                               new XElement(IDTecaj, viewmodel.ID_TecajKE.ToString()),
                                new XElement(IDTecajVr, viewmodel.ID_TecajVrKE.ToString()),
                                new XElement(Tecaj6, viewmodel.TecajKE.ToString().Replace(',', '.'))
                        ),
                           new XElement(Tecaj,
                                new XElement(IDTecaj, viewmodel.ID_TecajPE.ToString()),
                                new XElement(IDTecajVr, viewmodel.ID_TecajVrPE.ToString()),
                                new XElement(Tecaj6, viewmodel.TecajPE.ToString().Replace(',', '.'))
                        )

                     )
                );

                        String data = listaTecaj.ToString();
                        ObjectResult<Model.Data.TecajListaSt> update2 = _serviceTecajListaSt.TecajnaListaStUpdate_Complex(item, data);

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

        public ActionResult TecajListaStDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.TecajListaStDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceTecajListaSt = new Service.Data.TecajListaSt(korisnik_data);

                if (viewmodel.ID_TecajListaSt != -1)
                {
                    Model.Data.TecajListaSt item = new Model.Data.TecajListaSt();

                    if (id != null)
                    {
                        item.ID_TecajListaSt = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_TecajListaSt = viewmodel.ID_TecajListaSt;
                    }


                    ObjectResult<int?> delete = _serviceTecajListaSt.TecajnaListaStDelete_Complex(item);
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

        public ActionResult GetDrzavaValuta(string query, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<DrzavaDrzavaValutaDrzava> rezult = new List<DrzavaDrzavaValutaDrzava>();

            //query = query.Replace(" ", "");

            query = query.TrimStart();

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {
                _serviceDrzava = new Service.Data.Drzava(korisnik_data);
                List<InLine.Model.Data.Field.Drzava> fieldD = new List<InLine.Model.Data.Field.Drzava>();
                List<InLine.Model.Data.Filter.Drzava> filterD = new List<InLine.Model.Data.Filter.Drzava>();
                List<InLine.Model.Data.Sort.Drzava> sortD = new List<InLine.Model.Data.Sort.Drzava>();
                IEnumerable <Model.Data.Drzava>  rezultD = _serviceDrzava.GetData(fieldD, filterD, sortD).ToList();

                _serviceDrzavaValuta = new Service.Data.DrzavaValuta(korisnik_data);
                List<InLine.Model.Data.Field.DrzavaValuta> fieldDV = new List<InLine.Model.Data.Field.DrzavaValuta>();
                List<InLine.Model.Data.Filter.DrzavaValuta> filterDV = new List<InLine.Model.Data.Filter.DrzavaValuta>();
                List<InLine.Model.Data.Sort.DrzavaValuta> sortDV = new List<InLine.Model.Data.Sort.DrzavaValuta>();
                IEnumerable<Model.Data.DrzavaValuta> rezultDV = _serviceDrzavaValuta.GetData(fieldDV, filterDV, sortDV).ToList();

                _serviceValuta = new Service.Data.Valuta(korisnik_data);
                List<InLine.Model.Data.Field.Valuta> fieldV = new List<InLine.Model.Data.Field.Valuta>();
                List<InLine.Model.Data.Filter.Valuta> filterV = new List<InLine.Model.Data.Filter.Valuta>();
                List<InLine.Model.Data.Sort.Valuta> sortV = new List<InLine.Model.Data.Sort.Valuta>();
                IEnumerable<Model.Data.Valuta> rezultV = _serviceValuta.GetData(fieldV, filterV, sortV).ToList();

                var Podaci = from d in rezultD
                          join dv in rezultDV on d.IDDrzava equals dv.IDDrzava
                          join v in rezultV on dv.IDValuta equals v.IDValuta
                          orderby d.Naziv ascending
                          select new DrzavaDrzavaValutaDrzava { IDDrzava = d.IDDrzava, NazivDrzava = d.Naziv,  IDValuta = v.IDValuta, NazivValuta = v.Naziv };

                rezult = Podaci.Where(p => p.IDDrzava.ToUpper().Trim().StartsWith(query.ToUpper()) || p.NazivDrzava.ToUpper().Trim().StartsWith(query.ToUpper()) || p.IDDrzava.ToUpper().Trim().StartsWith(query.ToUpper()) || p.NazivValuta.ToUpper().Trim().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();
   
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

        public ActionResult IzborTecaj()
        {
            InLine.UI.Web.T4.GridFormattedTemplate.View.TecajnaListaComboFormatted rezult = new InLine.UI.Web.T4.GridFormattedTemplate.View.TecajnaListaComboFormatted();

            var rez = GetBankaOne();
            if (rez != null)
            {
                rezult.ID_Banka = rez.ID_Banka;

            }

            else
            {
                rezult.ID_Banka = -1;
            }



            return PartialView(rezult);
        }

        public PartialViewResult TecajVrPartial()
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.TecajVr> rezult = new List<InLine.Model.Data.TecajVr>();
            List<TecajVrViewModelCustom> VMrezult = new List<TecajVrViewModelCustom>();


            try
            {
                _serviceTecajVr = new Service.Data.TecajVr(korisnik_data);
                List<InLine.Model.Data.Field.TecajVr> field = new List<InLine.Model.Data.Field.TecajVr>();
                List<InLine.Model.Data.Filter.TecajVr> filter = new List<InLine.Model.Data.Filter.TecajVr>();
                List<InLine.Model.Data.Sort.TecajVr> sort = new List<InLine.Model.Data.Sort.TecajVr>();
                sort.Add(new InLine.Model.Data.Sort.TecajVr { Field = InLine.Model.Data.Field.TecajVr.ID_TecajVr, Descending = false });
                rezult = _serviceTecajVr.GetData(field, filter, sort).ToList();

                if (rezult.Count > 0)
                {
                    foreach(var item in rezult)
                    {
                        TecajVrViewModelCustom VMitem = new TecajVrViewModelCustom();
                        VMitem.ID_TecajVr = item.ID_TecajVr;
                        VMitem.Oznaka = item.Oznaka;
                        VMitem.Naziv = item.Naziv;
                        VMitem.NazivKr = item.NazivKr;
                        VMitem.Kratica = item.Kratica;
                        VMrezult.Add(VMitem);
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

            return PartialView(ViewList.MaticniPodaci.ViewTecajVr, VMrezult);
        }
        # endregion


        # region PomocneKlase

        public class DrzavaDrzavaValutaDrzava
        {
            public string IDDrzava { get; set; }
            public string IDValuta { get; set; }
            public string NazivDrzava { get; set; }
            public string NazivValuta { get; set; }
        }

        # endregion

    }
}
