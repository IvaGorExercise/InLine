//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using InLine;
using InLine.UI.Web.Helper;
using Lib.Web.Mvc.JQuery.JqGrid;

namespace InLine.UI.Web.Controllers
{
    
    public partial class UgovorStanOtkupController : Controller
    {
    	
    	#region Fields
    
    	 Service.Data.IUgovorStanOtkup _service;
         Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
         public InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
         long KorisnikID;
    	 string _serviceList = String.Empty;
    	 string gridModelNamespace =  "InLine.UI.Web.T4.GridFormattedTemplate.";
    
        #endregion
    
    		
        #region Constructors
        #endregion
    
    
    	#region Methods
    
    	
    	 			
    	public ActionResult Insert(InLine.Model.Data.Item.UgovorStanOtkupItem item)
    	{
    		
    		if (item.ID_UgovorStanOtkup == -1)
    		{
    			IList<InLine.Model.Admin.StatusPoruka> status = _service.Insert(item);
    			return Json(status, JsonRequestBehavior.AllowGet);
    		}
    		else
    		{
    			IList<InLine.Model.Admin.StatusPoruka> status = _service.Update(item);
    			return Json(status, JsonRequestBehavior.AllowGet);
    		}
              
    	}
    
    	public ActionResult Delete(InLine.Model.Data.Item.UgovorStanOtkupItem item)
    	{
    		IList<InLine.Model.Admin.StatusPoruka> status = _service.Delete(item);
    		return Json(status, JsonRequestBehavior.AllowGet);
               
    	}
    
    			
        public InLine.Model.Data.UgovorStanOtkup FindID(long id)
        {
    		InLine.Model.Data.UgovorStanOtkup rezultat;
            rezultat = _service.FindID(id);
            return rezultat;  
        }
    	
    	
        //public IEnumerable<InLine.Model.Data.UgovorStanOtkup> GetGridData(string filter, string sort, long? start, long? count, bool customsearch = false)
        //{
        //    IEnumerable<InLine.Model.Data.UgovorStanOtkup> rezultat;
         //   rezultat = _service.GetGridData(filter, sort, start, count, customsearch);
         //   return rezultat;  
        //}
    
    	public IEnumerable<InLine.Model.Data.UgovorStanOtkup> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customsearch = false)
        {
            IEnumerable<InLine.Model.Data.UgovorStanOtkup> rezultat;
            rezultat = _service.GetGridData(filter, key, value, sort, start, count, customsearch);
            return rezultat;  
        }
    		
    
        public long GetCount(string filter, string key, string value, bool customsearch = false)
        {
            long rezultat;
            rezultat = _service.GetCount(filter, key, value, customsearch );
            return rezultat;  
        }
    
    
    
    
    	public ActionResult GetGrid(JqGridRequest request, string key, string value, string viewModel, string field, long? id_master)
        {
    
            string fieldMain = String.Empty;
            long ID_master;
            bool result = Int64.TryParse(id_master.ToString(), out ID_master);
    
    
            if (String.IsNullOrEmpty(field))
            {
                fieldMain = "ID_UgovorStanOtkup";
            }
    
            else
            {
                fieldMain = field;
            }
    
    		viewModel = gridModelNamespace + viewModel;
    
            string filterExpression = String.Empty;
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
            long totalRecordsCount = GetCount(filterExpression, key, value);
    
    
            JqGridResponse response = new JqGridResponse()
            {
                TotalPagesCount = (int)Math.Ceiling((float)totalRecordsCount / (float)request.RecordsCount),
                PageIndex = request.PageIndex,
                TotalRecordsCount = totalRecordsCount,
            };
    
    
            response.Records.AddRange
                (
                from item in GetGridData(filterExpression, key, value, String.Format(KeyWord.FormaterRazno.StringFormat.PrviDrugi, sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount)
                select new JqGridRecord(Convert.ToString(item.GetType().GetProperty(fieldMain).GetValue(item, null)), Activator.CreateInstance(Type.GetType(viewModel), new[] { item }))
                );
    
    
            return new JqGridJsonResult() { Data = response };
        }
    
    
    
    
    		public static string GetFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
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
    				if (searchingName == "BrojAneks")
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
    				if (searchingName == "BrojStorno")
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
    		
    					if (searchingName == "BrojObrok")
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
    				if (searchingName == "BrojObrokDospjelo")
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
    				if (searchingName == "TemeljnicaGodina")
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
    				if (searchingName == "TemeljnicaVrsta")
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
    				if (searchingName == "TemeljnicaBroj")
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
    				if (searchingName == "DokumentGrupa")
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
    				if (searchingName == "DokumentVrsta")
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
    
    	#endregion
    
    
    
    	#region Akcije
    
    	    protected override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                korisnik_data = _korisnikDataFromSession.GetKorisnikDataFromSession();
                if (korisnik_data != null)
                {
                   KorisnikID = korisnik_data.KorisnikID;
                   _service = new Service.Data.UgovorStanOtkup(korisnik_data);
                }
    			else
                {
                   RedirectToAction("LogOn", "Home");
                }
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
    
                                for (int i = 0; i <= dijelovi.Length - 1; i++ )
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
    
    	#endregion 
    }
    
    
    
}
