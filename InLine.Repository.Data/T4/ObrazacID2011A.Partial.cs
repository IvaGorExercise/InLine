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
    
    public partial class ObrazacID2011A : CRUD.ObrazacID2011A, IObrazacID2011A
    {
    
    	#region Fields
         public Model.Data.Context _context;
        #endregion
    
        #region Constructor
    
        public ObrazacID2011A(string connstring)
                : base(connstring)
        {
             _context = new Model.Data.Context(connstring);
        }
            #endregion
    
    
    	#region Methods
       		
    			public void Delete(Model.Data.Item.ObrazacID2011AItem item)
            	{
                	base.Delete(item);
            	}
    
    				
    			public ObjectResult<int?> DeleteResult(Model.Data.Item.ObrazacID2011AItem item)
            	{
                	return base.DeleteResult(item);
            	}	
    									
    			public void Insert(Model.Data.Item.ObrazacID2011AItem item)
            	{
                	base.Insert(item);
            	}
    
    				public ObjectResult<Model.Data.ObrazacID2011A> InsertResult(Model.Data.Item.ObrazacID2011AItem item)
    			{
    				return base.InsertResult(item);
    			}	
    									
    				
    			public void Select(Nullable<long> ID_ObrazacID2011A)
    			{
    				base.Select(ID_ObrazacID2011A);
    			}
    
    					
    			public ObjectResult<Model.Data.ObrazacID2011A> SelectResult (Nullable<long> ID_ObrazacID2011A)
    			{
    				return base.SelectResult(ID_ObrazacID2011A);
    			}
    										
    				
    			public void Update(Model.Data.Item.ObrazacID2011AItem item)
            	{
                	base.Update(item);
            	}
    
    					
    			public ObjectResult<Model.Data.ObrazacID2011A> UpdateResult (Model.Data.Item.ObrazacID2011AItem item)
    			{
    				return base.UpdateResult(item);
    			}
    										
    		
    	
    		//public Model.Data.ObrazacID2011A FindID(long id)
           // {
              //  return _context.ObrazacID2011A.SingleOrDefault(p => p.ID_ObrazacID2011A == id);
            //}
    
    
    		public Model.Data.ObrazacID2011A FindID(long id)
            {
    			string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue("ID_ObrazacID2011A", id.ToString());
    			querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    			querybilder.Append(" WHERE " + filter);
    			query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ObrazacID2011A>(query).SingleOrDefault();
            }
    		
    
    
    		public IEnumerable <Model.Data.ObrazacID2011A> GetGridDataEF(string filter, string sort, long? start, long? count)
    		{
    		   if (!String.IsNullOrEmpty(filter))
                    return _context.ObrazacID2011A
                        .Where(filter)
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
                else
                    return _context.ObrazacID2011A
                        .OrderBy(sort)
                        .Skip((int)start)
                        .Take((int)count);
    		}
    		
    		public long GetCountEF(string filter)
    		{
    			if (!String.IsNullOrEmpty(filter))
    
                    return _context.ObrazacID2011A.Where(filter).Count();
    
                else
                    return _context.ObrazacID2011A.Count();
    		}
    
    
    	
    		public IEnumerable <Model.Data.ObrazacID2011A> GetGridData(string filter, string key, string value, string sort, long? start, long? count, bool customserach = false)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "ObrazacID2011A";
    			string model = "InLine.Model.Data.ObrazacID2011A";
    
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
                return _context.Database.SqlQuery<Model.Data.ObrazacID2011A>(query);
    
    		}
    
    
    		public long GetCount(string filter, string key, string value, bool customserach = false)
            {
                string query = String.Empty;
                StringBuilder querybilder = new StringBuilder();
    			string model = "InLine.Model.Data.ObrazacID2011A";
    
                if (!String.IsNullOrEmpty(filter) && String.IsNullOrEmpty(key) && String.IsNullOrEmpty(value))
                {
                    if (customserach == false)
                    {
                        filter = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    					querybilder.Append(" WHERE " + filter);
                    }
    
    				else
    				{
    					querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    					querybilder.Append(" WHERE " + filter);
    				}
                }
    
    			else if (String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                   
                    filter = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
    			else if (!String.IsNullOrEmpty(filter) && !String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(value))
                {
                    string filterF = Repository.Data.Helper.QueryBulider.CreateWhere(model, filter);
                    string filterKV = Repository.Data.Helper.QueryBulider.CreateWhereKeyValue(key, value);
                    filter = filterF + " AND " + filterKV;
    				querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    				querybilder.Append(" WHERE " + filter);
                    
                }
    
                else
                {
                    querybilder.Append("SELECT * FROM " + "doh" + "." + "ObrazacID2011A");
    
                }
    
                query = querybilder.ToString();
                return _context.Database.SqlQuery<Model.Data.ObrazacID2011A>(query).Count();
            }
    
    
    
    
    		public IEnumerable <Model.Data.ObrazacID2011A> GetData(List<Model.Data.Field.ObrazacID2011A> fields, List<Model.Data.Filter.ObrazacID2011A>  filter, List<Model.Data.Sort.ObrazacID2011A>  sort, long? start = null, long? count = null)
    		{
    		    string query = String.Empty;
    			string entity = "doh" + "." + "ObrazacID2011A";
                query = Repository.Data.Helper.QueryBulider.CreateQuery(entity, fields, filter, sort, start, count);
                return _context.Database.SqlQuery<Model.Data.ObrazacID2011A>(query);
    		}
    		
    		
    
    #endregion
    	
    }
    
}
