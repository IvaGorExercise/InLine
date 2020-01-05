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
    
    public partial class UgovorStanOtkupKupac : CRUD.View.UgovorStanOtkupKupac, View.IUgovorStanOtkupKupac
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupKupac(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    		public Model.Data.View.UgovorStanOtkupKupac FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupKupac> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_UgovorStanOtkupKupac
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_UgovorStanOtkupKupac
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_UgovorStanOtkupKupac.Where(filter).Count();
    
                else
                    return _context.VIEW_UgovorStanOtkupKupac.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.UgovorStanOtkupKupac> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupKupac";
    			string model = "InLine.Model.Data.View.UgovorStanOtkupKupac";
    
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
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupKupac>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.UgovorStanOtkupKupac";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupKupac");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupKupac");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupKupac");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupKupac");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupKupac");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupKupac>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupKupac> GetData(List<Model.Data.Field.View.UgovorStanOtkupKupac> fields, List<Model.Data.Filter.View.UgovorStanOtkupKupac>  filter, List<Model.Data.Sort.View.UgovorStanOtkupKupac>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupKupac";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupKupac>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}