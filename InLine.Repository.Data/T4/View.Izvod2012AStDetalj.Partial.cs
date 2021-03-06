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
    
    public partial class Izvod2012AStDetalj : CRUD.View.Izvod2012AStDetalj, View.IIzvod2012AStDetalj
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public Izvod2012AStDetalj(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       
    	
    		//public Model.Data.View.Izvod2012AStDetalj FindID(long id)
           // {
              //  return _context.VIEW_Izvod2012AStDetalj.SingleOrDefault(p => p.ID_Izvod2012ASt == id);
            //}
    
    
    		public Model.Data.View.Izvod2012AStDetalj FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_Izvod2012ASt", id.ToString());
    			querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.Izvod2012AStDetalj>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.View.Izvod2012AStDetalj> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.VIEW_Izvod2012AStDetalj
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.VIEW_Izvod2012AStDetalj
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.VIEW_Izvod2012AStDetalj.Where(filter).Count();
    
                else
                    return _context.VIEW_Izvod2012AStDetalj.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.View.Izvod2012AStDetalj> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "VIEW_Izvod2012AStDetalj";
    			string model = "InLine.Model.Data.View.Izvod2012AStDetalj";
    
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
                return _context.Database.SqlQuery<Model.Data.View.Izvod2012AStDetalj>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.View.Izvod2012AStDetalj";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "hub" + "." + "VIEW_Izvod2012AStDetalj");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.View.Izvod2012AStDetalj>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.View.Izvod2012AStDetalj> GetData(List<Model.Data.Field.View.Izvod2012AStDetalj> fields, List<Model.Data.Filter.View.Izvod2012AStDetalj>  filter, List<Model.Data.Sort.View.Izvod2012AStDetalj>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "VIEW_Izvod2012AStDetalj";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.View.Izvod2012AStDetalj>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
