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
    
    public partial class HUBImportHUB : CRUD.HUBImportHUB, IHUBImportHUB
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public HUBImportHUB(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.HUBImportHUBItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.HUBImportHUBItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.HUBImportHUBItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.HUBImportHUB> InsertResult(Model.Data.Item.HUBImportHUBItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_HUBImportHUB)
    			{
    				base.Select(ID_HUBImportHUB);
    			}
    
    					
    			public ObjectResult<Model.Data.HUBImportHUB> SelectResult (Nullable<long> ID_HUBImportHUB)
    			{
    				return base.SelectResult(ID_HUBImportHUB);
    			}
    										
    				
    			public void Update(Model.Data.Item.HUBImportHUBItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.HUBImportHUB> UpdateResult (Model.Data.Item.HUBImportHUBItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.HUBImportHUB FindID(long id)
           // {
              //  return _context.HUBImportHUB.SingleOrDefault(p => p.ID_HUBImportHUB == id);
            //}
    
    
    		public Model.Data.HUBImportHUB FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_HUBImportHUB", id.ToString());
    			querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.HUBImportHUB>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.HUBImportHUB> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.HUBImportHUB
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.HUBImportHUB
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.HUBImportHUB.Where(filter).Count();
    
                else
                    return _context.HUBImportHUB.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.HUBImportHUB> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "HUBImportHUB";
    			string model = "InLine.Model.Data.HUBImportHUB";
    
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
                return _context.Database.SqlQuery<Model.Data.HUBImportHUB>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.HUBImportHUB";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "ots" + "." + "HUBImportHUB");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.HUBImportHUB>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.HUBImportHUB> GetData(List<Model.Data.Field.HUBImportHUB> fields, List<Model.Data.Filter.HUBImportHUB>  filter, List<Model.Data.Sort.HUBImportHUB>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "ots" + "." + "HUBImportHUB";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.HUBImportHUB>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
