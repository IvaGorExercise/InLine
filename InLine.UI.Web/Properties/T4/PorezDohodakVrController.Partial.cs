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
    
    public partial class PorezDohodakVrController : Controller
    {
    	
    	#region Fields
    
    	 Service.Data.IPorezDohodakVr _service;
         Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
         InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
         long KorisnikID;
    	 string _serviceList = String.Empty;
    	 string gridModelNamespace =  "InLine.UI.Web.T4.GridFormattedTemplate.";
    
        #endregion
    
    		
        #region Constructors
        #endregion
    
    
    	#region Methods
    
    	
    	 			
    	public ActionResult Insert(InLine.Model.Data.Item.PorezDohodakVrItem item)
    	{
    		
    		if (item.ID_PorezDohodakVr == -1)
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
    
    	public ActionResult Delete(InLine.Model.Data.Item.PorezDohodakVrItem item)
    	{
    		IList<InLine.Model.Admin.StatusPoruka> status = _service.Delete(item);
    		return Json(status, JsonRequestBehavior.AllowGet);
               
    	}
    
    			
        public InLine.Model.Data.PorezDohodakVr FindID(long id)
        {
    		InLine.Model.Data.PorezDohodakVr rezultat;
            rezultat = _service.FindID(id);
            return rezultat;  
        }
    	
    	
        //public IEnumerable<InLine.Model.Data.PorezDohodakVr> GetGridData(string filter, string sort, long? start, long? count, bool customsearch = false)
        //{
        //    IEnumerable<InLine.Model.Data.PorezDohodakVr> rezultat;
         //   rezultat = _service.GetGridData(filter, sort, start, count, customsearch);
         //   return rezultat;  
        //}
    
    	public IEnumerable<InLine.Model.Data.PorezDohodakVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customsearch = false)
        {
            IEnumerable<InLine.Model.Data.PorezDohodakVr> rezultat;
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
                fieldMain = "ID_PorezDohodakVr";
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
                        filterExpressionBuilder.Append(String.Format(" {0} ", groupingOperatorToString));
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
                from item in GetGridData(filterExpression, key, value, String.Format("{0} {1}", sortingName, request.SortingOrder), request.PageIndex * request.RecordsCount, (request.PagesCount.HasValue ? request.PagesCount.Value : 1) * request.RecordsCount)
                select new JqGridRecord(Convert.ToString(item.GetType().GetProperty(fieldMain).GetValue(item, null)), Activator.CreateInstance(Type.GetType(viewModel), new[] { item }))
                );
    
    
            return new JqGridJsonResult() { Data = response };
        }
    
    
    
    
    		public string GetFilter(string searchingName, JqGridSearchOperators searchingOperator, string searchingValue)
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
    
    				if (searchingName == "ID_PorezDohodakVr")
    				{
    					return String.Format("{0} {1} {2}", searchingName, searchingOperatorString, searchingValue);
    				}
    		
    
    				if (searchingName == "Oznaka")
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
    				if (searchingName == "NazivKr")
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
    				if (searchingName == "Kratica")
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
                   _service = new Service.Data.PorezDohodakVr(korisnik_data);
                }
    			else
                {
                   RedirectToAction("LogOn", "Home");
                }
            }
    
    	#endregion 
    }
    
    
    
}
