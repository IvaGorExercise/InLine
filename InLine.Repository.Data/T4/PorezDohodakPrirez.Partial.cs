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
    
    public partial class PorezDohodakPrirez : CRUD.PorezDohodakPrirez, IPorezDohodakPrirez
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PorezDohodakPrirez(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PorezDohodakPrirezItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PorezDohodakPrirezItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PorezDohodakPrirezItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PorezDohodakPrirez> InsertResult(Model.Data.Item.PorezDohodakPrirezItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PorezDohodakPrirez)
    			{
    				base.Select(ID_PorezDohodakPrirez);
    			}
    
    					
    			public ObjectResult<Model.Data.PorezDohodakPrirez> SelectResult (Nullable<long> ID_PorezDohodakPrirez)
    			{
    				return base.SelectResult(ID_PorezDohodakPrirez);
    			}
    										
    				
    			public void Update(Model.Data.Item.PorezDohodakPrirezItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PorezDohodakPrirez> UpdateResult (Model.Data.Item.PorezDohodakPrirezItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PorezDohodakPrirez FindID(long id)
           // {
              //  return _context.PorezDohodakPrirez.SingleOrDefault(p => p.ID_PorezDohodakPrirez == id);
            //}
    
    
    		public Model.Data.PorezDohodakPrirez FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PorezDohodakPrirez", id.ToString());
    			querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PorezDohodakPrirez>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PorezDohodakPrirez> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PorezDohodakPrirez
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PorezDohodakPrirez
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PorezDohodakPrirez.Where(filter).Count();
    
                else
                    return _context.PorezDohodakPrirez.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PorezDohodakPrirez> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PorezDohodakPrirez";
    			string model = "InLine.Model.Data.PorezDohodakPrirez";
    
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
                return _context.Database.SqlQuery<Model.Data.PorezDohodakPrirez>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PorezDohodakPrirez";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "dav" + "." + "PorezDohodakPrirez");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PorezDohodakPrirez>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PorezDohodakPrirez> GetData(List<Model.Data.Field.PorezDohodakPrirez> fields, List<Model.Data.Filter.PorezDohodakPrirez>  filter, List<Model.Data.Sort.PorezDohodakPrirez>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PorezDohodakPrirez";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PorezDohodakPrirez>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
