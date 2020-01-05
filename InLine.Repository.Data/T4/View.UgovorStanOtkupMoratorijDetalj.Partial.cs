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
    
    public partial class UgovorStanOtkupMoratorijDetalj : CRUD.View.UgovorStanOtkupMoratorijDetalj, View.IUgovorStanOtkupMoratorijDetalj
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public UgovorStanOtkupMoratorijDetalj(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    		public Model.Data.View.UgovorStanOtkupMoratorijDetalj FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupMoratorijDetalj> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_UgovorStanOtkupMoratorijDetalj
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_UgovorStanOtkupMoratorijDetalj
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_UgovorStanOtkupMoratorijDetalj.Where(filter).Count();
    
                else
                    return _context.VIEW_UgovorStanOtkupMoratorijDetalj.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.UgovorStanOtkupMoratorijDetalj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj";
    			string model = "InLine.Model.Data.View.UgovorStanOtkupMoratorijDetalj";
    
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
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupMoratorijDetalj>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.UgovorStanOtkupMoratorijDetalj";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupMoratorijDetalj>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.UgovorStanOtkupMoratorijDetalj> GetData(List<Model.Data.Field.View.UgovorStanOtkupMoratorijDetalj> fields, List<Model.Data.Filter.View.UgovorStanOtkupMoratorijDetalj>  filter, List<Model.Data.Sort.View.UgovorStanOtkupMoratorijDetalj>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "VIEW_UgovorStanOtkupMoratorijDetalj";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.UgovorStanOtkupMoratorijDetalj>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}