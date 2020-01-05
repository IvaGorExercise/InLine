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
    
    public partial class DavanjeDoprinosDohodak : CRUD.DavanjeDoprinosDohodak, IDavanjeDoprinosDohodak
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public DavanjeDoprinosDohodak(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.DavanjeDoprinosDohodakItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.DavanjeDoprinosDohodakItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.DavanjeDoprinosDohodakItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.DavanjeDoprinosDohodak> InsertResult(Model.Data.Item.DavanjeDoprinosDohodakItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<int> IDDavanjeDoprinosDohodak)
    			{
    				base.Select(IDDavanjeDoprinosDohodak);
    			}
    
    					
    			public ObjectResult<Model.Data.DavanjeDoprinosDohodak> SelectResult (Nullable<int> IDDavanjeDoprinosDohodak)
    			{
    				return base.SelectResult(IDDavanjeDoprinosDohodak);
    			}
    										
    				
    			public void Update(Model.Data.Item.DavanjeDoprinosDohodakItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.DavanjeDoprinosDohodak> UpdateResult (Model.Data.Item.DavanjeDoprinosDohodakItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    		public Model.Data.DavanjeDoprinosDohodak FindID(long id)
            {
                return null;
            }
    		
    
    
    		public IEnumerable <Model.Data.DavanjeDoprinosDohodak> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.DavanjeDoprinosDohodak
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.DavanjeDoprinosDohodak
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.DavanjeDoprinosDohodak.Where(filter).Count();
    
                else
                    return _context.DavanjeDoprinosDohodak.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.DavanjeDoprinosDohodak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "DavanjeDoprinosDohodak";
    			string model = "InLine.Model.Data.DavanjeDoprinosDohodak";
    
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
                return _context.Database.SqlQuery<Model.Data.DavanjeDoprinosDohodak>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.DavanjeDoprinosDohodak";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "DavanjeDoprinosDohodak");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "sis" + "." + "DavanjeDoprinosDohodak");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "DavanjeDoprinosDohodak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "sis" + "." + "DavanjeDoprinosDohodak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "sis" + "." + "DavanjeDoprinosDohodak");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.DavanjeDoprinosDohodak>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.DavanjeDoprinosDohodak> GetData(List<Model.Data.Field.DavanjeDoprinosDohodak> fields, List<Model.Data.Filter.DavanjeDoprinosDohodak>  filter, List<Model.Data.Sort.DavanjeDoprinosDohodak>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "sis" + "." + "DavanjeDoprinosDohodak";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.DavanjeDoprinosDohodak>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
