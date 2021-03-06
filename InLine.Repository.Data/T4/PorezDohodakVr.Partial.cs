//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InLine.Repository.Data
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics;
    using System.Data.Objects;
    using InLine;
    
    public partial class PorezDohodakVr : CRUD.PorezDohodakVr, IPorezDohodakVr
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PorezDohodakVr(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PorezDohodakVrItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PorezDohodakVrItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PorezDohodakVrItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PorezDohodakVr> InsertResult(Model.Data.Item.PorezDohodakVrItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PorezDohodakVr)
    			{
    				base.Select(ID_PorezDohodakVr);
    			}
    
    					
    			public ObjectResult<Model.Data.PorezDohodakVr> SelectResult (Nullable<long> ID_PorezDohodakVr)
    			{
    				return base.SelectResult(ID_PorezDohodakVr);
    			}
    										
    				
    			public void Update(Model.Data.Item.PorezDohodakVrItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PorezDohodakVr> UpdateResult (Model.Data.Item.PorezDohodakVrItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PorezDohodakVr FindID(long id)
           // {
              //  return _context.PorezDohodakVr.SingleOrDefault(p => p.ID_PorezDohodakVr == id);
            //}
    
    
    		public Model.Data.PorezDohodakVr FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PorezDohodakVr", id.ToString());
    			querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PorezDohodakVr>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PorezDohodakVr> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PorezDohodakVr
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PorezDohodakVr
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PorezDohodakVr.Where(filter).Count();
    
                else
                    return _context.PorezDohodakVr.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PorezDohodakVr> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PorezDohodakVr";
    			string model = "InLine.Model.Data.PorezDohodakVr";
    
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
                return _context.Database.SqlQuery<Model.Data.PorezDohodakVr>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PorezDohodakVr";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakVr");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PorezDohodakVr>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PorezDohodakVr> GetData(List<Model.Data.Field.PorezDohodakVr> fields, List<Model.Data.Filter.PorezDohodakVr>  filter, List<Model.Data.Sort.PorezDohodakVr>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PorezDohodakVr";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PorezDohodakVr>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
