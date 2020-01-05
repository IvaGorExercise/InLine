//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Repository.Data.View
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial class UgovorStanOtkupOpomenaDetalj : CRUD.View.UgovorStanOtkupOpomenaDetalj, View.IUgovorStanOtkupOpomenaDetalj
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupOpomenaDetalj(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    	
    		//public Model.Data.View.UgovorStanOtkupOpomenaDetalj FindID(long id)
           // {
              //  return _context.VIEW_UgovorStanOtkupOpomenaDetalj.SingleOrDefault(p => p.ID_UgovorStanOtkupOpomena == id);
            //}
    
    
    		public Model.Data.View.UgovorStanOtkupOpomenaDetalj FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_UgovorStanOtkupOpomena", id.ToString());
    			querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupOpomenaDetalj>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupOpomenaDetalj> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_UgovorStanOtkupOpomenaDetalj
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_UgovorStanOtkupOpomenaDetalj
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_UgovorStanOtkupOpomenaDetalj.Where(filter).Count();
    
                else
                    return _context.VIEW_UgovorStanOtkupOpomenaDetalj.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.UgovorStanOtkupOpomenaDetalj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj";
    			string model = "InLine.Model.Data.View.UgovorStanOtkupOpomenaDetalj";
    
    			if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    }
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                      filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;   
                }
    
    
                query = Repository.Data.Helper.QueryBulider.CreateQuerySelect(entity, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupOpomenaDetalj>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.UgovorStanOtkupOpomenaDetalj";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupOpomenaDetalj>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupOpomenaDetalj> GetData(List<Model.Data.Field.View.UgovorStanOtkupOpomenaDetalj> fields, List<Model.Data.Filter.View.UgovorStanOtkupOpomenaDetalj>  filter, List<Model.Data.Sort.View.UgovorStanOtkupOpomenaDetalj>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupOpomenaDetalj";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupOpomenaDetalj>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}