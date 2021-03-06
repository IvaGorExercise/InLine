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
    
    public partial class PosebanPorezDohodak : CRUD.PosebanPorezDohodak, IPosebanPorezDohodak
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public PosebanPorezDohodak(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.PosebanPorezDohodakItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.PosebanPorezDohodakItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.PosebanPorezDohodakItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.PosebanPorezDohodak> InsertResult(Model.Data.Item.PosebanPorezDohodakItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_PosebanPorezDohodak)
    			{
    				base.Select(ID_PosebanPorezDohodak);
    			}
    
    					
    			public ObjectResult<Model.Data.PosebanPorezDohodak> SelectResult (Nullable<long> ID_PosebanPorezDohodak)
    			{
    				return base.SelectResult(ID_PosebanPorezDohodak);
    			}
    										
    				
    			public void Update(Model.Data.Item.PosebanPorezDohodakItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.PosebanPorezDohodak> UpdateResult (Model.Data.Item.PosebanPorezDohodakItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.PosebanPorezDohodak FindID(long id)
           // {
              //  return _context.PosebanPorezDohodak.SingleOrDefault(p => p.ID_PosebanPorezDohodak == id);
            //}
    
    
    		public Model.Data.PosebanPorezDohodak FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_PosebanPorezDohodak", id.ToString());
    			querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PosebanPorezDohodak>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.PosebanPorezDohodak> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.PosebanPorezDohodak
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.PosebanPorezDohodak
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.PosebanPorezDohodak.Where(filter).Count();
    
                else
                    return _context.PosebanPorezDohodak.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.PosebanPorezDohodak> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PosebanPorezDohodak";
    			string model = "InLine.Model.Data.PosebanPorezDohodak";
    
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
                return _context.Database.SqlQuery<Model.Data.PosebanPorezDohodak>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.PosebanPorezDohodak";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "dav" + "." + "PosebanPorezDohodak");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.PosebanPorezDohodak>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.PosebanPorezDohodak> GetData(List<Model.Data.Field.PosebanPorezDohodak> fields, List<Model.Data.Filter.PosebanPorezDohodak>  filter, List<Model.Data.Sort.PosebanPorezDohodak>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "dav" + "." + "PosebanPorezDohodak";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.PosebanPorezDohodak>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
