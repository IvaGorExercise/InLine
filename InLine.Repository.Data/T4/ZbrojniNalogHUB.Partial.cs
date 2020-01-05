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
    
    public partial class ZbrojniNalogHUB : CRUD.ZbrojniNalogHUB, IZbrojniNalogHUB
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ZbrojniNalogHUB(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ZbrojniNalogHUBItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ZbrojniNalogHUBItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ZbrojniNalogHUBItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ZbrojniNalogHUB> InsertResult(Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ZbrojniNalogHUB)
    			{
    				base.Select(ID_ZbrojniNalogHUB);
    			}
    
    					
    			public ObjectResult<Model.Data.ZbrojniNalogHUB> SelectResult (Nullable<long> ID_ZbrojniNalogHUB)
    			{
    				return base.SelectResult(ID_ZbrojniNalogHUB);
    			}
    										
    				
    			public void Update(Model.Data.Item.ZbrojniNalogHUBItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ZbrojniNalogHUB> UpdateResult (Model.Data.Item.ZbrojniNalogHUBItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ZbrojniNalogHUB FindID(long id)
           // {
              //  return _context.ZbrojniNalogHUB.SingleOrDefault(p => p.ID_ZbrojniNalogHUB == id);
            //}
    
    
    		public Model.Data.ZbrojniNalogHUB FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ZbrojniNalogHUB", id.ToString());
    			querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZbrojniNalogHUB>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ZbrojniNalogHUB> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ZbrojniNalogHUB
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ZbrojniNalogHUB
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ZbrojniNalogHUB.Where(filter).Count();
    
                else
                    return _context.ZbrojniNalogHUB.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ZbrojniNalogHUB> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "ZbrojniNalogHUB";
    			string model = "InLine.Model.Data.ZbrojniNalogHUB";
    
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
                return _context.Database.SqlQuery<Model.Data.ZbrojniNalogHUB>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ZbrojniNalogHUB";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "hub" + "." + "ZbrojniNalogHUB");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ZbrojniNalogHUB>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ZbrojniNalogHUB> GetData(List<Model.Data.Field.ZbrojniNalogHUB> fields, List<Model.Data.Filter.ZbrojniNalogHUB>  filter, List<Model.Data.Sort.ZbrojniNalogHUB>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "hub" + "." + "ZbrojniNalogHUB";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ZbrojniNalogHUB>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
