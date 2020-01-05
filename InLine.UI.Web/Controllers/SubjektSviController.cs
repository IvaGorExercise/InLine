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
    public partial class SubjektSviController : InLine.UI.Web.Controllers.View.OsobaViewController
    {

        #region Konstruktor

        Service.Data.View.IOsoba _serviceViewOsoba;
        Service.Data.View.IOsobaDetalj _serviceViewOsobaDetalj;
        Service.Data.IOsoba _serviceOsoba;

        Service.Data.IPoslovniSubjekt _servicePoslovniSubjekt;

        Service.Data.IDrzavljanstvo _serviceDrzavljanstvo;
        Service.Data.INarodnost _serviceNarodnost;

        Service.Data.View.Subjekt _serviceViewSubjekt;
        Service.Data.Subjekt _serviceSubjekt;


        public SubjektSviController()
        {
        
        }

        public SubjektSviController(Model.Admin.KorisnikData korisnik_data)   
        {
            this.korisnik_data = korisnik_data;
    	}


        # endregion


        #region View

        public ActionResult Osoba()
        {
            return View();
        }
        # endregion


        #region Osoba

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OsobaGrid(JqGridRequest request, string key, string value)
        {
            JqGridResponse response = new JqGridResponse();

            try
            {
                _serviceViewOsoba = new Service.Data.View.Osoba(korisnik_data);
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
                        filterExpression = OsobaGetFilter(request.SearchingFilter.SearchingName, request.SearchingFilter.SearchingOperator, request.SearchingFilter.SearchingValue);
                    else if (request.SearchingFilters != null)
                    {
                        StringBuilder filterExpressionBuilder = new StringBuilder();
                        string groupingOperatorToString = request.SearchingFilters.GroupingOperator.ToString();
                        foreach (JqGridRequestSearchingFilter searchingFilter in request.SearchingFilters.Filters)
                        {
                            filterExpressionBuilder.Append(OsobaGetFilter(searchingFilter.SearchingName, searchingFilter.SearchingOperator, searchingFilter.SearchingValue));
                            filterExpressionBuilder.Append(String.Format(KeyWord.FormaterRazno.StringFormat.Prvi, groupingOperatorToString));
                        }
                        if (filterExpressionBuilder.Length > 0)
                            filterExpressionBuilder.Remove(filterExpressionBuilder.Length - groupingOperatorToString.Length - 2, groupingOperatorToString.Length + 2);
                        filterExpression = filterExpressionBuilder.ToString();
                    }

                }

                string sortingName = request.SortingName;

                long totalRecordsCount = _serviceViewOsoba.GetCount(filterExpression, key, value, customsearch);

                response = new JqGridResponse()
                {
                    TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                    PageIndex = request.PageIndex,
                    TotalRecordsCount = totalRecordsCount

                };
                response.Records.AddRange(from item in _serviceViewOsoba.GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount, customsearch)
                                          select new JqGridRecord<OsobaGridFormatted>(Convert.ToString(item.ID_Osoba), new OsobaGridFormatted(item)));



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

        public ActionResult OsobaDetalj(long? Id, long? IdMaster)
        {
            _serviceViewOsobaDetalj = new Service.Data.View.OsobaDetalj(korisnik_data);
            InLine.UI.Web.T4.FormFormattedTemplate.View.OsobaDetaljFormFormatted rezult;

            _serviceDrzavljanstvo = new Service.Data.Drzavljanstvo(korisnik_data);
            var ID_Drzavljanstvo = _serviceDrzavljanstvo.SelectResult(null).Select(c => new { c.ID_Drzavljanstvo, c.Naziv }).ToList();
            ViewBag.ID_Drzavljanstvo = new SelectList(ID_Drzavljanstvo.AsEnumerable(), InLine.Model.Data.FieldString.Drzavljanstvo.ID_Drzavljanstvo, InLine.Model.Data.FieldString.Drzavljanstvo.Naziv);

            _serviceNarodnost = new Service.Data.Narodnost(korisnik_data);
            var ID_Narodnost = _serviceNarodnost.SelectResult(null).Select(c => new { c.ID_Narodnost, c.Naziv }).ToList();
            ViewBag.ID_Narodnost = new SelectList(ID_Narodnost.AsEnumerable(), InLine.Model.Data.FieldString.Narodnost.ID_Narodnost, InLine.Model.Data.FieldString.Narodnost.Naziv);


            if (Id != null)
            {
                List<InLine.Model.Data.Field.View.OsobaDetalj> field = new List<InLine.Model.Data.Field.View.OsobaDetalj>();
                List<InLine.Model.Data.Filter.View.OsobaDetalj> filter = new List<InLine.Model.Data.Filter.View.OsobaDetalj>();
                List<InLine.Model.Data.Sort.View.OsobaDetalj> sort = new List<InLine.Model.Data.Sort.View.OsobaDetalj>();
                filter.Add(new InLine.Model.Data.Filter.View.OsobaDetalj { Field = InLine.Model.Data.Field.View.OsobaDetalj.ID_Osoba, Value = Convert.ToInt64(Id) });
                var item = _serviceViewOsobaDetalj.GetData(field, filter, sort).FirstOrDefault();
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OsobaDetaljFormFormatted(item);

                if(item != null)
                {
                    _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);
                    //Model.Data.PoslovniSubjekt ps = _servicePoslovniSubjekt.SelectResult(null).Where(p => p.ID_Subjekt == item.ID_Subjekt).FirstOrDefault();

                    List<InLine.Model.Data.Field.PoslovniSubjekt> field2 = new List<InLine.Model.Data.Field.PoslovniSubjekt>();
                    List<InLine.Model.Data.Filter.PoslovniSubjekt> filter2 = new List<InLine.Model.Data.Filter.PoslovniSubjekt>();
                    List<InLine.Model.Data.Sort.PoslovniSubjekt> sort2 = new List<InLine.Model.Data.Sort.PoslovniSubjekt>();
                    filter2.Add(new InLine.Model.Data.Filter.PoslovniSubjekt { Field = InLine.Model.Data.Field.PoslovniSubjekt.ID_Subjekt, Value = Convert.ToInt64(item.ID_Subjekt) });
                    Model.Data.PoslovniSubjekt ps = _servicePoslovniSubjekt.GetData(field2, filter2, sort2).FirstOrDefault();

                    if (ps != null)
                    {
                        rezult.JePoslovniSubjekt = ps.ID_PoslovniSubjekt != 0 ? true : false;
                    }
                }
            }

            else
            {
                rezult = new InLine.UI.Web.T4.FormFormattedTemplate.View.OsobaDetaljFormFormatted();

                _serviceSubjekt = new Service.Data.Subjekt(korisnik_data);

                List<InLine.Model.Data.Field.Subjekt> field = new List<InLine.Model.Data.Field.Subjekt>();
                List<InLine.Model.Data.Filter.Subjekt> filter = new List<InLine.Model.Data.Filter.Subjekt>();
                List<InLine.Model.Data.Sort.Subjekt> sort = new List<InLine.Model.Data.Sort.Subjekt>();
                int itemOznaka = _serviceSubjekt.GetData(field, filter, sort).Select(p => Convert.ToInt32(p.Oznaka)).Max();
                itemOznaka = itemOznaka + 1;
                rezult.Oznaka = itemOznaka.ToString();
                    
                rezult.ID_Osoba = -1;

            }

            return PartialView(rezult);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult OsobaInsert(InLine.UI.Web.T4.FormFormattedTemplate.View.OsobaDetaljFormFormatted viewmodel)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceOsoba = new Service.Data.Osoba(korisnik_data);

                if (viewmodel.ID_Osoba == -1)
                {
                    Model.Data.Item.OsobaItem item = new Model.Data.Item.OsobaItem(viewmodel);
                    Model.Data.Osoba insert = _serviceOsoba.InsertResult(item);

                    if (viewmodel.JePoslovniSubjekt == true && insert != null)
                    {
                        _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);
                        Model.Data.Item.PoslovniSubjektItem poslovniSubjektItem = new Model.Data.Item.PoslovniSubjektItem();
                        poslovniSubjektItem.ID_Subjekt = insert.ID_Subjekt;
                        Model.Data.PoslovniSubjekt insertPoslovniSubjektItem = _servicePoslovniSubjekt.InsertResult(poslovniSubjektItem);
                    }
                }
                else
                {
                    _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);
                    //Model.Data.PoslovniSubjekt ps = _servicePoslovniSubjekt.SelectResult(null).Where(p => p.ID_Subjekt == viewmodel.ID_Subjekt).FirstOrDefault();

                    List<InLine.Model.Data.Field.PoslovniSubjekt> field = new List<InLine.Model.Data.Field.PoslovniSubjekt>();
                    List<InLine.Model.Data.Filter.PoslovniSubjekt> filter = new List<InLine.Model.Data.Filter.PoslovniSubjekt>();
                    List<InLine.Model.Data.Sort.PoslovniSubjekt> sort = new List<InLine.Model.Data.Sort.PoslovniSubjekt>();
                    filter.Add(new InLine.Model.Data.Filter.PoslovniSubjekt { Field = InLine.Model.Data.Field.PoslovniSubjekt.ID_Subjekt, Value = Convert.ToInt64(viewmodel.ID_Subjekt) });
                    Model.Data.PoslovniSubjekt ps = _servicePoslovniSubjekt.GetData(field, filter, sort).FirstOrDefault();

                    Model.Data.Osoba model = _serviceOsoba.FindID(viewmodel.ID_Osoba);
                    if (model != null)
                    {
                        if (viewmodel.JePoslovniSubjekt == false && ps != null)
                        {
                            _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);
                            Model.Data.Item.PoslovniSubjektItem poslovniSubjektItem = new Model.Data.Item.PoslovniSubjektItem();
                            poslovniSubjektItem.ID_PoslovniSubjekt = ps.ID_PoslovniSubjekt;
                            int deletePoslovniSubjektItem = _servicePoslovniSubjekt.DeleteResult(poslovniSubjektItem);
                        }

                        else if (viewmodel.JePoslovniSubjekt == true && ps == null)
                        {
                            _servicePoslovniSubjekt = new Service.Data.PoslovniSubjekt(korisnik_data);
                            Model.Data.Item.PoslovniSubjektItem poslovniSubjektItem = new Model.Data.Item.PoslovniSubjektItem();
                            poslovniSubjektItem.ID_Subjekt = model.ID_Subjekt;
                            Model.Data.PoslovniSubjekt insertPoslovniSubjektItem = _servicePoslovniSubjekt.InsertResult(poslovniSubjektItem);
                        }

                        Model.Data.Item.OsobaItem item = new Model.Data.Item.OsobaItem(viewmodel);
                        Model.Data.Osoba update = _serviceOsoba.UpdateResult(item);
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

        public ActionResult OsobaDelete(InLine.UI.Web.T4.FormFormattedTemplate.View.OsobaDetaljFormFormatted viewmodel, long? id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;

            try
            {
                _serviceOsoba = new Service.Data.Osoba(korisnik_data);

                if (viewmodel.ID_Osoba != -1)
                {
                    Model.Data.Item.OsobaItem item = new Model.Data.Item.OsobaItem();

                    if (id != null)
                    {
                        item.ID_Osoba = Convert.ToInt64(id);
                    }
                    else
                    {
                        item.ID_Osoba = viewmodel.ID_Osoba;
                    }
                  
                    int delete = _serviceOsoba.DeleteResult(item);
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

        public static string OsobaGetFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
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

            if (searchingName == "ID_Osoba" || (searchingName == "ID_Drzavljanstvo") || (searchingName == "ID_Narodnost"))
            {
                return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
            }




            if (searchingName == "Prezime")
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
            if (searchingName == "Ime")
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
            if (searchingName == "MjestoRodenja")
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
            if (searchingName == "OIBHR")
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
            if (searchingName == "OtacIme")
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
            if (searchingName == "MajkaPrezime")
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
            if (searchingName == "MajkaIme")
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
            if (searchingName == "MajkaPrezimeDjevojacko")
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
            if (searchingName == "NazivDrzavljanstvo")
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
            if (searchingName == "NazivNarodnost")
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

        #endregion





        #region Subjekt

        public ActionResult Subjekt()
        {
            return View();
        }

        public ActionResult GetPoslovniSubjekt(string query, long? start, long? count)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            List<InLine.Model.Data.View.Subjekt> rezult = new List<InLine.Model.Data.View.Subjekt>();

            query = query.Replace(" ", "");

            if (query.Length > 1)
            {
                int op = query.LastIndexOf(",");
                query = query.Substring(op + 1);
            }

            try
            {

                _serviceViewSubjekt = new Service.Data.View.Subjekt(korisnik_data);
                List<InLine.Model.Data.Field.View.Subjekt> field = new List<InLine.Model.Data.Field.View.Subjekt>();
                List<InLine.Model.Data.Filter.View.Subjekt> filter = new List<InLine.Model.Data.Filter.View.Subjekt>();
                List<InLine.Model.Data.Sort.View.Subjekt> sort = new List<InLine.Model.Data.Sort.View.Subjekt>();
                rezult = _serviceViewSubjekt.GetData(field, filter, sort).Where(p => p.Oznaka.ToUpper().Trim().StartsWith(query.ToUpper()) || p.Naziv.ToUpper().Trim().StartsWith(query.ToUpper()) || p.SubjektVrNaziv.ToUpper().Trim().StartsWith(query.ToUpper())).Skip(Convert.ToInt32(start)).Take(Convert.ToInt32(count)).ToList();


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

        public InLine.Model.Data.View.Subjekt GetSubjekt(long id)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            InLine.Model.Data.View.Subjekt rezult = new InLine.Model.Data.View.Subjekt();


            try
            {
                _serviceViewSubjekt = new Service.Data.View.Subjekt(korisnik_data);
                List<InLine.Model.Data.Field.View.Subjekt> field = new List<InLine.Model.Data.Field.View.Subjekt>();
                List<InLine.Model.Data.Filter.View.Subjekt> filter = new List<InLine.Model.Data.Filter.View.Subjekt>();
                List<InLine.Model.Data.Sort.View.Subjekt> sort = new List<InLine.Model.Data.Sort.View.Subjekt>();
                filter.Add(new InLine.Model.Data.Filter.View.Subjekt { Field = InLine.Model.Data.Field.View.Subjekt.ID_Subjekt, Value = id });
                rezult = _serviceViewSubjekt.GetData(field, filter, sort).SingleOrDefault();


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


        public ActionResult GetSubjektOznaka(int Oznaka)
        {
            List<Model.Admin.StatusPoruka> poruke = null;
            IEnumerable<InLine.Model.Data.Subjekt> rezult = new List<InLine.Model.Data.Subjekt>();

            try
            {
                _serviceSubjekt = new Service.Data.Subjekt(korisnik_data);

                List<InLine.Model.Data.Field.Subjekt> field = new List<InLine.Model.Data.Field.Subjekt>();
                List<InLine.Model.Data.Filter.Subjekt> filter = new List<InLine.Model.Data.Filter.Subjekt>();
                List<InLine.Model.Data.Sort.Subjekt> sort = new List<InLine.Model.Data.Sort.Subjekt>();
                filter.Add(new InLine.Model.Data.Filter.Subjekt { Field = InLine.Model.Data.Field.Subjekt.Oznaka, Value = Oznaka});
                rezult = _serviceSubjekt.GetData(field, filter, sort).ToList();
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

        # endregion


    }
}
