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
    
    public partial class ObrazacPolje : CRUD.ObrazacPolje, IObrazacPolje
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ObrazacPolje(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacPoljeItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacPoljeItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ObrazacPoljeItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ObrazacPolje> InsertResult(Model.Data.Item.ObrazacPoljeItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacPolje)
    			{
    				base.Select(ID_ObrazacPolje);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacPolje> SelectResult (Nullable<long> ID_ObrazacPolje)
    			{
    				return base.SelectResult(ID_ObrazacPolje);
    			}
    										
    				
    			public void Update(Model.Data.Item.ObrazacPoljeItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ObrazacPolje> UpdateResult (Model.Data.Item.ObrazacPoljeItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ObrazacPolje FindID(long id)
           // {
              //  return _context.ObrazacPolje.SingleOrDefault(p => p.ID_ObrazacPolje == id);
            //}
    
    
    		public Model.Data.ObrazacPolje FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ObrazacPolje", id.ToString());
    			querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ObrazacPolje>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ObrazacPolje> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ObrazacPolje
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ObrazacPolje
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ObrazacPolje.Where(filter).Count();
    
                else
                    return _context.ObrazacPolje.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ObrazacPolje> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "zps" + "." + "ObrazacPolje";
    			string model = "InLine.Model.Data.ObrazacPolje";
    
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
                return _context.Database.SqlQuery<Model.Data.ObrazacPolje>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ObrazacPolje";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "zps" + "." + "ObrazacPolje");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ObrazacPolje>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ObrazacPolje> GetData(List<Model.Data.Field.ObrazacPolje> fields, List<Model.Data.Filter.ObrazacPolje>  filter, List<Model.Data.Sort.ObrazacPolje>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "zps" + "." + "ObrazacPolje";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ObrazacPolje>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
