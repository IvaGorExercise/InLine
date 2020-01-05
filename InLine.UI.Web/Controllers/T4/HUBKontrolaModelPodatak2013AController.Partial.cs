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
    
    public partial class HUBKontrolaModelPodatak2013AController : Controller
    {
    	
    	#region Fields
    
    	 Service.Data.IHUBKontrolaModelPodatak2013A _service;
         Repository.Admin.IKorisnikDataFromSession _korisnikDataFromSession = new Repository.Admin.KorisnikDataFromSession();
         public InLine.Model.Admin.KorisnikData korisnik_data = new InLine.Model.Admin.KorisnikData();
         long KorisnikID;
    	 string _serviceList = String.Empty;
    	 string gridModelNamespace =  "InLine.UI.Web.T4.GridFormattedTemplate.";
    
        #endregion
    
    		
        #region Constructors
        #endregion
    
    
    	#region Methods
    
    	
    	 
    			
        public InLine.Model.Data.HUBKontrolaModelPodatak2013A FindID(long id)
        {
    		InLine.Model.Data.HUBKontrolaModelPodatak2013A rezultat;
            rezultat = _service.FindID(id);
            return rezultat;  
        }
    	
    	
        //public IEnumerable<InLine.Model.Data.HUBKontrolaModelPodatak2013A> GetGridData(string filter, string sort, long? start, long? count, bool customsearch = false)
        //{
        //    IEnumerable<InLine.Model.Data.HUBKontrolaModelPodatak2013A> rezultat;
         //   rezultat = _service.GetGridData(filter, sort, start, count, customsearch);
         //   return rezultat;  
        //}
    
    	public IEnumerable<InLine.Model.Data.HUBKontrolaModelPodatak2013A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customsearch = false)
        {
            IEnumerable<InLine.Model.Data.HUBKontrolaModelPodatak2013A> rezultat;
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
                fieldMain = "IDHUBKontrolaModelPodatak2013A";
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
    
    				
    				if (searchingName == "IDHUBKontrolaModelPodatak2013A")
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
    				if (searchingName == "IDHUBKontrola")
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
    				if (searchingName == "IDHUBModelPodatak2013A")
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
    		
    					if (searchingName == "ZnakGranica")
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
                   _service = new Service.Data.HUBKontrolaModelPodatak2013A(korisnik_data);
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
